using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Platform;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative;

public abstract class ViewBase<TViewModel> : ViewBase
    where TViewModel : class
{
    public virtual TViewModel ViewModel
    {
        get => DataContext as TViewModel;
        set => DataContext = value;
    }

    protected ViewBase(TViewModel viewModel)
        : base(true)
    {
        DataContext = viewModel;
        OnCreatedCore();
        Initialize();
    }

    //protected ViewBase(bool deferredLoading = false) : base(deferredLoading)
    //{
    //}

    protected abstract object Build(TViewModel vm);

    protected override object Build() => Build(ViewModel);

    protected Binding Bind<TProp>(TProp propertyPath, BindingMode bindingMode = BindingMode.Default,
        [CallerArgumentExpression("propertyPath")] string propertyPathString = null, [CallerMemberName] string callerMethod = null)
    {
        var propName = PropertyPathHelper.GetNameFromPropertyPath(propertyPathString);

        //normal binding from View
        if (callerMethod == nameof(Build))
            return new Binding()
            {
                Source = ViewModel,
                Path = propName,
                Mode = bindingMode,
            };

        //if property not set, but only vm
        if (propName == propertyPathString)
            return new Binding(); //bind self

        //binding to current DataContext's property
        return new Binding(propName, bindingMode);

    }
}

/// <summary>
/// Base view class used like UserControl in XAML
/// </summary>
public abstract class ViewBase : Decorator, IReloadable, INotifyPropertyChanged, IDeclarativeViewBase
{
    public event Action ViewInitialized;

    protected abstract object Build();

    protected ViewBase(bool deferredLoading = false)
    {
        if (!deferredLoading)
        {
            OnCreatedCore();
            Initialize();
        }
    }

    protected virtual void OnAfterInitialized() { }

    protected internal void OnCreatedCore() => OnCreated();

    protected virtual void OnCreated()
    {
    }

    public void Reload()
    {
        Dispatcher.UIThread.InvokeAsync(() =>
        {
            OnBeforeReload();
            Child = null;
            VisualChildren.Clear();

            OnCreatedCore();
            Initialize();

            InvalidateArrange();
            InvalidateMeasure();
            InvalidateVisual();
        });
    }

    protected virtual void OnBeforeReload()
    {
    }

    public void Initialize()
    {
        try
        {
            InitStateMembers();

            var content = Build();
            Child = content as Control;

            ViewInitialized?.Invoke();
            OnAfterInitialized();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            Debug.WriteLine(ex.StackTrace);
            throw;
        }
    }

    public static T GetResource<T>(string key)
    {
        if (Application.Current.Resources.TryGetResource(key, out var res))
        {
            if (res is T tres)
                return tres;
        }
        return default;
    }

    protected TControl Create<TControl>(Action<TControl> initializer)
        where TControl : Control, new()

    {
        var control = new TControl();
        initializer?.Invoke(control);
        return control;
    }

    /// <summary>
    /// Create binding to Avalonia property
    /// </summary>
    /// <param name="property">Avalonia property</param>
    /// <param name="bindingMode">Binding mode</param>
    /// <returns></returns>
    protected Binding Bind(AvaloniaProperty property, BindingMode bindingMode = BindingMode.Default)
    {
        return new Binding()
        {
            Source = this,
            Path = property.Name,
            Mode = bindingMode
        };
    }

    protected static Binding Bind<T>(T source, object propertyPath, BindingMode bindingMode = BindingMode.Default,
        [CallerArgumentExpression("propertyPath")] string propertyPathString = null)
    {
        return new Binding()
        {
            Source = source,
            Path = PropertyPathHelper.GetNameFromPropertyPath(propertyPathString),
            Mode = bindingMode,
        };
    }

    protected static Binding Bind<T, TProp>(T source, Expression<Func<T, TProp>> propertyGetterExp, BindingMode bindingMode = BindingMode.Default)
    {
        if (propertyGetterExp.Body is MemberExpression propertyGetter)
        {
            return new Binding()
            {
                Source = source,
                Path = propertyGetter.Member.Name,
                Mode = bindingMode,
            };
        }

        throw new MemberAccessException("Wrong property getter expression");
    }

    public static Stream GetAsset(string uri)
    {
        var assets = AvaloniaLocator.Current.GetService<IAssetLoader>();

        //var prefix = "avares://MyAssembly/"

        var asset = assets.Open(new Uri(uri));
        return asset;
    }



    #region Property States


    ViewPropertyState[]? _localPropertyStates = null;
    List<ViewPropertyState> _externalPropertyStates = null;
    List<IDeclarativeViewBase> _dependentViews = null;

    private void InitStateMembers()
    {
        var viewType = GetType();
        _localPropertyStates = viewType
            .GetProperties()
            .Where(p => p.DeclaringType == viewType)
            .Select(p => new ViewPropertyState(p, this))
            .ToArray();
    }
    public void UpdateState()
    {
        StateHasChanged();
    }

    protected void StateHasChanged()
    {
        if (_externalPropertyStates != null)
            foreach (var prop in _externalPropertyStates)
                if (prop.CheckStateChangedAndUpdate())
                    OnPropertyChanged(prop.Name);

        if (_localPropertyStates != null)
            foreach (var prop in _localPropertyStates)
                if (prop.CheckStateChangedAndUpdate())
                    OnPropertyChanged(prop.Name);

        if (_dependentViews != null)
            foreach (var dependentView in _dependentViews)
                dependentView.UpdateState();
    }

    public void AddExternalState<TContorl, TValue>(TContorl source, string propertyName, Action<TValue> setAction)
        where TContorl : ViewBase
    {
        _externalPropertyStates ??= new List<ViewPropertyState>();

        var propInfo = source.GetType().GetProperty(propertyName);

        var propertyState = new ViewPropertyState<TValue>(propInfo, source, setAction);
        _externalPropertyStates.Add(propertyState);

        source.AddDependentView(this, propertyState);
    }

    private void AddDependentView(IDeclarativeViewBase view, ViewPropertyState propertyState)
    {
        _dependentViews ??= new List<IDeclarativeViewBase>();

        if (!_dependentViews.Contains(view))
            _dependentViews.Add(view);
    }

    protected IBinding Bind(object value, BindingMode bindingMode = BindingMode.Default, [CallerArgumentExpression("value")] string bindingString = null)
    {
        object bindingSource = this;
        var useStateValueAsSource = false;

        var propName = PropertyPathHelper.GetNameFromPropertyPath(bindingString);
        var stateName = propName;

        var splitterIndex = bindingString!.IndexOf('.');

        if (splitterIndex > -1)
        {
            var startIndex = bindingString.StartsWith("@") ? 1 : 0;
            stateName = bindingString.Substring(0, splitterIndex - startIndex);

            useStateValueAsSource = true;
        }

        var stateInfo = FindStateForBindingString(stateName);
        if (stateInfo == null)
            throw new ArgumentException("No properties found in binding string");

        if (useStateValueAsSource)
            bindingSource = stateInfo.Value;

        return new BindingEx()
        {
            Source = bindingSource,
            Path = propName,
            Mode = bindingMode,
            Value = value
        };
    }

    public class BindingEx : Binding
    {
        public object Value { get; set; }
    }

    private ViewPropertyState FindStateForBindingString(string stateName) =>
        _localPropertyStates?.FirstOrDefault(x => x.Name == stateName);

    public new event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

    #region Hot reload stuff

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
#if DEBUG
        HotReloadManager.RegisterInstance(this);
#endif
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
#if DEBUG
        HotReloadManager.UnregisterInstance(this);
#endif
    }

    #endregion

    #region Debug stuff

    [DebuggerHidden]
    protected static void Break()
    {
#if DEBUG
        Debugger.Break();
#endif
    }
    #endregion

}
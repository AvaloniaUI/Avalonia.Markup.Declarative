using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Platform;
using Avalonia.Styling;
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
public abstract class ViewBase : Decorator, IReloadable, IDeclarativeViewBase
{
    public event Action ViewInitialized;

    protected abstract object Build();

    protected ViewBase() : this(false)
    {

    }

    protected ViewBase(bool deferredLoading)
    {
        if (!deferredLoading)
        {
            OnCreatedCore();
            Initialize();
        }
    }

    protected virtual void OnAfterInitialized() { }

    protected internal void OnCreatedCore() => OnCreated();

    /// <summary>
    /// Called from constructor, right before initialization and building UI
    /// Override this method when you want to run some stuff before creation of children controls
    /// </summary>
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

    [Obsolete("There is no reason to keep it inside view base. Use Avalonia methods: Application.Current.Resources.TryGetResource")]
    public static T GetResource<T>(string key)
    {
        if (Application.Current.Resources.TryGetResource(key, ThemeVariant.Default, out var res))
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
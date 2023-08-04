using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative;

public abstract class ViewBase<TViewModel> : ViewBase
    where TViewModel : class
{
    public virtual TViewModel? ViewModel
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

    protected abstract object Build(TViewModel? vm);

    protected override object Build() => Build(ViewModel);


    [Obsolete("Just use Property name in extension method")]
    protected Binding Bind<TProp>(TProp propertyPath, BindingMode bindingMode = BindingMode.Default,
        [CallerArgumentExpression("propertyPath")] string? propertyPathString = null, [CallerMemberName] string? callerMethod = null)
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
    internal List<ViewPropertyComputedState> __viewComputedStates { get; set; } = new();

    private INameScope? _nameScope;
    
    /// <summary>
    /// Current NameScope of this view
    /// </summary>
    protected INameScope Scope => _nameScope ??= new NameScope();

    public event Action? ViewInitialized;

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

    public void Initialize()
    {
        try
        {
            NameScope.SetNameScope(this, Scope);

            using (var viewContext = new ViewBuildContext(this))
            {
                var content = Build();
                Child = content as Control;
            }

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

    [Obsolete("Threre is new Extension, that allows to bind AvaloniaProperty directly as parameter, eg. TextBlock.Text(HeaderProperty, BindingMode.OneWay)")]
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

    [Obsolete("It looks like this overload is useless")]
    protected static Binding Bind<T>(T source, object propertyPath, BindingMode bindingMode = BindingMode.Default,
        [CallerArgumentExpression("propertyPath")] string? propertyPathString = null)
    {
        return new Binding()
        {
            Source = source,
            Path = PropertyPathHelper.GetNameFromPropertyPath(propertyPathString),
            Mode = bindingMode,
        };
    }

    [Obsolete("It looks like this overload is useless, and can be replaced with other mehtods")]
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

    #region Hot reload stuff
    public void Reload()
    {
        Dispatcher.UIThread.InvokeAsync(() =>
        {
            OnBeforeReload();
            Child = null;
            VisualChildren.Clear();
            _nameScope = null;

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

internal class ViewBuildContext : IDisposable
{
    private static Stack<ViewBuildContext> _viewsStack = new();
    private static ViewBuildContext? _currentContext;

    internal static ViewBase? CurrentView => _currentContext?._view;

    ViewBase _view;

    public ViewBuildContext(ViewBase view)
    {
        _view = view;
        
        if(_currentContext != null)
            _viewsStack.Push(_currentContext);

        _currentContext = this;
        
        //Debug.WriteLine($"Pushed view {view.GetType().Name}");
    }

    public void Dispose()
    {
        _currentContext = _viewsStack.Count > 0 ? _viewsStack.Pop() : null;
        
        //if( _currentContext != null )
        //    Debug.WriteLine($"Poped view {_currentContext._view.GetType().Name}");
    }
}

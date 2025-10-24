using Avalonia.Controls;
using Avalonia.Threading;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Avalonia.Markup.Declarative;

/// <summary>
/// Defines when a view should be initialized.
/// </summary>
public enum ViewInitializationStrategy
{
    /// <summary>
    /// View is initialized lazily when first accessed (e.g., when Child property is accessed or when attached to visual tree).
    /// </summary>
    Lazy,
    
    /// <summary>
    /// View is initialized immediately in the constructor.
    /// </summary>
    Immediate
}

public abstract class ViewBase<TViewModel> : ViewBase
{
    public virtual TViewModel? ViewModel
    {
        get => (TViewModel)DataContext!;
        set => DataContext = value;
    }

    protected ViewBase(TViewModel viewModel) 
        : this(viewModel, ViewInitializationStrategy.Immediate)
    {
    }

    protected ViewBase(TViewModel viewModel, ViewInitializationStrategy initializationStrategy) 
        : base(initializationStrategy)
    {
        DataContext = viewModel;
        // For ViewBase<T>, default to immediate initialization since it's intended for MVVM scenarios
        // where the view should be ready to use right after construction
        if (initializationStrategy == ViewInitializationStrategy.Immediate)
        {
            Initialize();
        }
    }

    protected abstract object Build(TViewModel? vm);

    protected override object Build() => Build(ViewModel);
}

/// <summary>
/// Base view class used like UserControl in XAML
/// </summary>
public abstract class ViewBase : Decorator, IReloadable, IDeclarativeViewBase
{
    internal List<ExpressionBindingBase> ViewComputedStates { get; } = [];
    internal List<IDeclarativeViewBase> DependentViews { get; set; } = [];

    private INotifyPropertyChanged? _currentObservedDataContext;


    private INameScope? _nameScope;

    /// <summary>
    /// Current NameScope of this view
    /// </summary>
    protected INameScope Scope => _nameScope ??= new NameScope();

    public event Action? ViewInitialized;

    protected abstract object Build();

    protected virtual StyleGroup? BuildStyles() => null;

    protected ViewBase() 
        : this(AppBuilderExtensions.DefaultViewInitializationStrategy)
    {
    }

    protected ViewBase(ViewInitializationStrategy initializationStrategy)
    {
        InitializationStrategy = initializationStrategy;
    }

    /// <summary>
    /// Gets the initialization strategy used by this view.
    /// </summary>
    public ViewInitializationStrategy InitializationStrategy { get; }

    private bool _isInitialized;
    private bool _isInitializing;

    private void EnsureInitialized()
    {
        if (!_isInitialized && !_isInitializing)
        {
            Initialize();
        }
    }

    /// <summary>
    /// Called from constructor, right before initialization and building UI
    /// Override this method when you want to run some stuff before creation of children controls
    /// </summary>
    protected virtual void OnCreated()
    {
    }

    protected virtual void OnAfterInitialized() 
    {
    }

    public void Initialize()
    {
        if (_isInitialized || _isInitializing)
            return;
            
        _isInitializing = true;
        
        try
        {
            OnCreated();
            NameScope.SetNameScope(this, Scope);

            using (var context = new ViewBuildContext(this))
            {
                context.SetState(ViewBuildContextState.StyleBuilding);
                if (BuildStyles() is { } styleGroup)
                {
                    context.SetState(ViewBuildContextState.StyleSelectorUpdating);
                    var viewStyles = StyleBuilder.StylesToRange(styleGroup).ToImmutableList();
                    Styles.AddRange(viewStyles);
                }

                context.SetState(ViewBuildContextState.ViewBuilding);
                var content = Build();
                Child = content as Control;
            }

            _isInitialized = true;
            ViewInitialized?.Invoke();
            OnAfterInitialized();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            Debug.WriteLine(ex.StackTrace);
            throw new ViewBuildingException($"Build error in {GetType().Name} : {ex.Message}", ex);
        }
        finally
        {
            _isInitializing = false;
        }
    }

    /// <summary>
    /// Overrides Avalonia's OnDataContextChanged to handle ViewModel property changes.
    /// </summary>
    protected override void OnDataContextChanged(EventArgs e)
    {
        base.OnDataContextChanged(e); 

        if (_currentObservedDataContext != null)
        {
            _currentObservedDataContext.PropertyChanged -= OnViewModelPropertyChanged;
            _currentObservedDataContext = null;
        }

        if (DataContext is INotifyPropertyChanged newContext)
        {
            _currentObservedDataContext = newContext;
            _currentObservedDataContext.PropertyChanged += OnViewModelPropertyChanged;
        }

        // Only recompute bindings if the view has been initialized
        if (_isInitialized)
        {
            RecomputeAllBindings();
        }
    }
    
    /// <summary>
    /// Handles PropertyChanged event from the DataContext.
    /// </summary>
    protected void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        Dispatcher.UIThread.Invoke(RecomputeAllBindings, DispatcherPriority.Normal);
    }

    /// <summary>
    /// Adds a computed state to the collection of view property computed states.
    /// </summary>
    /// <param name="state">The computed state to add. This parameter cannot be null.</param>
    /// <param name="dependentControl">Avalonia control that contains property to bind</param>
    internal virtual void AddComputedState<TControl>(ExpressionBindingBase state, TControl dependentControl)
    {
        ViewComputedStates.Add(state);

        if (dependentControl is ViewBase targetView) 
            AddDependentView(targetView);
    }

    /// <summary>
    /// Recomputes all registered computed bindings in the view.
    /// </summary>
    protected void RecomputeAllBindings()
    {
        foreach (var state in ViewComputedStates.ToList()) 
            state.OnPropertyChanged();
    }

    /// <summary>
    /// Adds a dependent view to the collection if it is not already present.
    /// </summary>
    /// <remarks>This method ensures that the specified view is added to the collection of dependent views
    /// only if it is not already included.</remarks>
    /// <param name="view">The dependent view to add. Must implement <see cref="IDeclarativeViewBase"/>.</param>
    protected void AddDependentView(IDeclarativeViewBase view)
    {
        if (!DependentViews.Contains(view))
            DependentViews.Add(view);
    }

    /// <summary>
    /// Gets the child control, ensuring initialization if needed.
    /// This property provides access to the built content and triggers initialization if not already done.
    /// </summary>
    public new Control? Child
    {
        get
        {
            EnsureInitialized();
            return base.Child;
        }
        protected set => base.Child = value;
    }

    #region Hot reload stuff
    public void Reload()
    {
        Dispatcher.UIThread.InvokeAsync(() =>
        {
            // clean DataContext subscriptions and clear all computed states
            if (_currentObservedDataContext != null)
            {
                _currentObservedDataContext.PropertyChanged -= OnViewModelPropertyChanged;
                _currentObservedDataContext = null;
            }

            ViewComputedStates.Clear();
            OnBeforeReload();
            SetValue(ChildProperty, null);
            VisualChildren.Clear();
            _nameScope = null;
            _isInitialized = false;
            _isInitializing = false;

            var oldDataContext = DataContext; 
            DataContext = null; // guarantee that OnDataContextChanged is called

            Initialize();
            DataContext = oldDataContext; // set DataContext back

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
        HotReloadManager.RegisterInstance(this);
        EnsureInitialized();
    }


    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        HotReloadManager.UnregisterInstance(this);

        if (_currentObservedDataContext == null) return;

        _currentObservedDataContext.PropertyChanged -= OnViewModelPropertyChanged;
        _currentObservedDataContext = null;
    }
    #endregion

}

internal class ViewBuildContext : IDisposable
{
    private static readonly Stack<ViewBuildContext> ViewsStack = new();
    private static ViewBuildContext? _currentContext;

    internal static ViewBase? CurrentView => _currentContext?._view;
    internal static ViewBuildContextState? CurrentState => _currentContext?._state;

    private readonly ViewBase _view;
    private ViewBuildContextState _state;

    public ViewBuildContext(ViewBase view)
    {
        _view = view;

        if (_currentContext != null)
            ViewsStack.Push(_currentContext);

        _currentContext = this;

        //Debug.WriteLine($"Pushed view {view.GetType().Name}");
    }

    internal void SetState(ViewBuildContextState state)
    {
        _state = state;
    }

    public void Dispose()
    {
        _currentContext = ViewsStack.Count > 0 ? ViewsStack.Pop() : null;

        //if( _currentContext != null )
        //    Debug.WriteLine($"Poped view {_currentContext._view.GetType().Name}");
    }

    public static string GetViewStackString() => string.Join("/", ViewsStack.Reverse().Select(x => x._view.GetType().Name));
}

internal enum ViewBuildContextState
{
    None,
    StyleBuilding,
    StyleSelectorUpdating,
    ViewBuilding
}

public class ViewBuildingException(string message, Exception innerException) : Exception(message, innerException);
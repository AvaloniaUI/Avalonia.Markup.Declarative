using Avalonia.Controls;
using Avalonia.Threading;
using System;
using System.Collections.Immutable;
using System.Diagnostics;

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
    where TViewModel : class
{
    public virtual TViewModel? ViewModel
    {
        get => (TViewModel?)DataContext!;
        set => DataContext = value;
    }

    //injecting viewmodel through constructor is optional, but if you do it, the view will be initialized immediately with provided viewmodel as DataContext
    protected ViewBase(TViewModel viewModel) : base(ViewInitializationStrategy.Lazy)
    {
        DataContext = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        Initialize();
    }

    //classic mvvm approach with parameterless constructor and setting DataContext later is also supported, but in this case the view will be initialized lazily when first accessed or attached to visual tree
    protected ViewBase() : base(ViewInitializationStrategy.Lazy)
    {
        // not calling Initialize()! Waiting for OnDataContextChanged
    }

    protected override void OnDataContextChanged(EventArgs e)
    {
        base.OnDataContextChanged(e);

        // once DataContext is set to a compatible viewmodel type, we can initialize the view if it hasn't been initialized yet
        if (DataContext is TViewModel && !IsInitialized)
        {
            Initialize();
        }
    }

    protected abstract object Build(TViewModel vm);

    protected override object Build()
    {
        if (DataContext is not TViewModel vm)
        {
            throw new InvalidOperationException(
                $"Cannot build view {GetType().Name} without a valid ViewModel of type {typeof(TViewModel).Name}.");
        }

        return Build(vm);
    }
}

/// <summary>
/// Base view class used like UserControl in XAML
/// </summary>
public abstract class ViewBase : Decorator, IReloadable, IDeclarativeViewBase
{
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

        if (initializationStrategy == ViewInitializationStrategy.Immediate)
            Initialize();
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

            if (BuildStyles() is { } styleGroup)
            {
                var viewStyles = StyleBuilder.StylesToRange(styleGroup).ToImmutableList();
                Styles.AddRange(viewStyles);
            }

            var content = Build();
            Child = content as Control;

            _isInitialized = true;
            ViewInitialized?.Invoke();
            OnAfterInitialized();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            Debug.WriteLine(ex.StackTrace);
            throw new ViewBuildingException(CreateBuildErrorMessage(GetType(), ex), ex);
        }
        finally
        {
            _isInitializing = false;
        }
    }

    private static string CreateBuildErrorMessage(Type viewType, Exception exception)
    {
        var rootCause = GetRootCause(exception);
        var message = $"Build error in {viewType.Name} ({rootCause.GetType().Name}): {rootCause.Message}";

        if (IsBinaryCompatibilityException(rootCause))
        {
            message += " This usually means an external package was built against a different version of Avalonia or another dependency. Check the package's declared dependency versions against the versions resolved by the app.";
        }

        return message;
    }

    private static Exception GetRootCause(Exception exception)
    {
        while (exception.InnerException != null)
        {
            exception = exception.InnerException;
        }

        return exception;
    }

    private static bool IsBinaryCompatibilityException(Exception exception) =>
        exception is MissingFieldException or MissingMethodException or TypeLoadException or System.IO.FileLoadException;

    /// <summary>
    /// Gets the child control, ensuring initialization if needed.
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
            OnBeforeReload();
            SetValue(ChildProperty, null);
            VisualChildren.Clear();
            _nameScope = null;
            _isInitialized = false;
            _isInitializing = false;

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
        HotReloadManager.RegisterInstance(this);
        EnsureInitialized();
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        HotReloadManager.UnregisterInstance(this);
    }
    #endregion
}

public class ViewBuildingException(string message, Exception innerException) : Exception(message, innerException);
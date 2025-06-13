using Avalonia.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Markup.Declarative.Helpers;

namespace Avalonia.Markup.Declarative;

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.NonPublicFields)]
public abstract class ComponentBase<TViewModel> : ComponentBase
{
    public virtual TViewModel? ViewModel
    {
        get => (TViewModel)DataContext!;
        set => DataContext = value;
    }

    protected ComponentBase(TViewModel viewModel)
        : base(true)
    {
        DataContext = viewModel;
        OnCreatedCore();
        Initialize();
    }

    protected abstract object Build(TViewModel? vm);

    protected override object Build() => Build(ViewModel);
}

[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.NonPublicFields)]
public abstract class ComponentBase : ViewBase, IMvuComponent
{
    private ViewPropertyState[]? _localPropertyStates;
    private List<ViewPropertyState>? _externalPropertyStates;
    private List<IMvuComponent>? _dependentViews;

    protected ComponentBase()
        : base()
    {
    }

    protected ComponentBase(bool deferredLoading)
        : base(deferredLoading)
    {
    }
    
    protected override void OnCreated()
    {
        InjectServices();
        InitStateMembers();
        StateHasChanged();
    }

    [RequiresUnreferencedCode("Method InjectServices is using reflection to iterate through Type hierarchy. That's can not be analyzed statically.")]
    private void InjectServices()
    {
        var componentType = GetType();
        var types = new List<Type>();

        // Walk up the inheritance chain, but stop at object
        for (var type = componentType; type != null && type != typeof(object); type = type.BaseType)
        {
            types.Add(type);
        }

        // Go from base to derived so base properties are injected first
        types.Reverse();

        foreach (var type in types)
        {
            var injectProps = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(x => x.GetCustomAttribute(typeof(InjectAttribute)) != null)
                .ToArray();

            foreach (var propertyInfo in injectProps)
            {
                var service = GetServiceFromProvider(propertyInfo.PropertyType);

                if (propertyInfo.CanWrite)
                {
                    propertyInfo.SetValue(this, service);
                }
                else
                {
                    if (type.GetField($"<{propertyInfo.Name}>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance) is { } backingField)
                        backingField.SetValue(this, service);
                    else
                        throw new InvalidOperationException($"Can't inject {service?.GetType()} service. Ensure that target property: {type.Name}.{propertyInfo.Name} has public setter or it's an auto-property");
                }
            }
        }
    }

    private static object? GetServiceFromProvider(Type serviceType)
    {
        if (AppBuilderExtensions.ServiceProvider == null)
            throw new InvalidOperationException("Please set Service Provider by calling UseServiceProvider on AppBuilder");

        return AppBuilderExtensions.ServiceProvider.GetService(serviceType);
    }

    /// <summary>
    /// Creates a new instance of the control using the component factory. Injects services into the control if needed.
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static TControl New<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TControl>() where TControl : Control
    {
        if (AppBuilderExtensions.ComponentControlFactory == null)
            throw new InvalidOperationException("Please set Component Factory by calling UseComponentControlFactory on AppBuilder");

        var control = AppBuilderExtensions.ComponentControlFactory.CreateControlInstance<TControl>();
        return control;
    }

    private void InitStateMembers()
    {
        var viewType = GetType();
        _localPropertyStates = viewType
            .GetProperties()
            .Where(p => p.DeclaringType == viewType)
            .Select(p => new ViewPropertyState(p, this))
            .ToArray();
    }
    public void UpdateState(Action? updateStateAction = null)
    {
        updateStateAction?.Invoke();
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

        foreach (var computedState in __viewComputedStates)
            computedState.OnPropertyChanged();
    }

    public void AddExternalState<TControl, TValue>(TControl source, string propertyName, Action<TValue?> setAction)
        where TControl : ComponentBase
    {
        _externalPropertyStates ??= [];

        var propInfo = source.GetType().GetProperty(propertyName);

        if (propInfo == null)
            throw new NullReferenceException($"Property info {propertyName} is null");

        var propertyState = new ViewPropertyState<TValue>(propInfo, source, setAction);
        _externalPropertyStates.Add(propertyState);

        source.AddDependentView(this, propertyState);
    }

    private void AddDependentView(IMvuComponent view, ViewPropertyState propertyState)
    {
        _dependentViews ??= [];

        if (!_dependentViews.Contains(view))
            _dependentViews.Add(view);
    }

    #region ObsoleteMvuBinding

    [Obsolete("This is old binding method relies on Reflection. Use lambda expressions instead.")]
    protected Binding Bind(object value, BindingMode bindingMode = BindingMode.Default, [CallerArgumentExpression(nameof(value))] string? valueExpressionString = null)
    {
        return CreateMvuBinding(value, bindingMode, valueExpressionString);
    }

    [Obsolete("This is old binding method relies on Reflection.")]
    private Binding CreateMvuBinding(object value, BindingMode? bindingMode, string? valueExpressionString)
    {
        object? bindingSource = this;
        var useStateValueAsSource = false;

        var propName = PropertyPathHelper.GetNameFromPropertyPath(valueExpressionString);
        var stateName = propName;

        var splitterIndex = valueExpressionString!.IndexOf('.');

        if (splitterIndex > -1)
        {
            var startIndex = valueExpressionString.StartsWith("@") ? 1 : 0;
            stateName = valueExpressionString.Substring(startIndex, splitterIndex - startIndex);

            useStateValueAsSource = true;
        }

        var stateInfo = FindStateForBindingString(stateName);
        if (stateInfo == null)
            throw new ArgumentException("No properties found in binding string. Make sure that your properties are public!");

        if (useStateValueAsSource)
            bindingSource = stateInfo.Value;

        return new MvuBinding()
        {
            Source = bindingSource,
            Path = propName,
            Mode = bindingMode ?? BindingMode.Default,
            Value = value
        };
    }

    [Obsolete("This is old binding method relies on Reflection.")]
    public class MvuBinding : Binding
    {
        public object? Value { get; set; }
    }

    [Obsolete("This is old binding method relies on Reflection.")]
    private ViewPropertyState? FindStateForBindingString(string stateName) =>
        _localPropertyStates?.FirstOrDefault(x => x.Name == stateName);

    #endregion

    public new event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

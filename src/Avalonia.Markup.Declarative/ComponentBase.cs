using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Avalonia.Data;

namespace Avalonia.Markup.Declarative;

public abstract class ComponentBase : ViewBase, IMvuComponent
{
    private ViewPropertyState[]? _localPropertyStates;
    private List<ViewPropertyState>? _externalPropertyStates;
    private List<IMvuComponent>? _dependentViews;

    protected override void OnCreated()
    {
        InjectServices();
        InitStateMembers();
    }

    private void InjectServices()
    {
        var componentType = GetType();
        var serviceProps = componentType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(x => x.GetCustomAttribute(typeof(InjectAttribute)) != null)
            .ToArray();

        foreach (var propertyInfo in serviceProps)
        {
            var service = GetServiceFromProvider(propertyInfo.PropertyType);

            if (propertyInfo.CanWrite)
            {
                propertyInfo.SetValue(this, service);
            }
            else
            {
                if (componentType.GetField($"<{propertyInfo.Name}>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance) is { } backingField)
                    backingField.SetValue(this, service);
                else
                    throw new InvalidOperationException($"Can't inject {service?.GetType()} service. Ensure that target property: {GetType().Name}.{propertyInfo.Name} has public setter or it's an auto-property");
            }
        }
    }

    private static object? GetServiceFromProvider(Type serviceType)
    {
        if (AppBuilderExtensions.ServiceProvider == null)
            throw new InvalidOperationException("Please set Service Provider by calling UseServiceProvider on AppBuilder");

        return AppBuilderExtensions.ServiceProvider.GetService(serviceType);
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

        foreach (var computedState in __viewComputedStates)
            computedState.OnPropertyChanged();
    }

    public void AddExternalState<TContorl, TValue>(TContorl source, string propertyName, Action<TValue?> setAction)
        where TContorl : ComponentBase
    {
        _externalPropertyStates ??= new List<ViewPropertyState>();

        var propInfo = source.GetType().GetProperty(propertyName);

        if (propInfo == null)
            throw new NullReferenceException($"Property info {propertyName} is null");

        var propertyState = new ViewPropertyState<TValue>(propInfo, source, setAction);
        _externalPropertyStates.Add(propertyState);

        source.AddDependentView(this, propertyState);
    }

    private void AddDependentView(IMvuComponent view, ViewPropertyState propertyState)
    {
        _dependentViews ??= new List<IMvuComponent>();

        if (!_dependentViews.Contains(view))
            _dependentViews.Add(view);
    }

    protected Binding Bind(object value, BindingMode bindingMode = BindingMode.Default, [CallerArgumentExpression("value")] string? valueExpressionString = null)
    {
        return CreateMvuBinding(value, bindingMode, valueExpressionString);
    }

    internal Binding CreateMvuBinding(object value, BindingMode? bindingMode, string? valueExpressionString)
    {
        object? bindingSource = this;
        var useStateValueAsSource = false;

        var propName = PropertyPathHelper.GetNameFromPropertyPath(valueExpressionString);
        var stateName = propName;

        var splitterIndex = valueExpressionString!.IndexOf('.');

        if (splitterIndex > -1)
        {
            var startIndex = valueExpressionString.StartsWith("@") ? 1 : 0;
            stateName = valueExpressionString.Substring(0, splitterIndex - startIndex);

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

    public class MvuBinding : Binding
    {
        public object? Value { get; set; }
    }

    private ViewPropertyState? FindStateForBindingString(string stateName) =>
        _localPropertyStates?.FirstOrDefault(x => x.Name == stateName);

    public new event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
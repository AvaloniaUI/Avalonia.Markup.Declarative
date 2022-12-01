using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Avalonia.Data;

namespace Avalonia.Markup.Declarative.Mvu;

public abstract class ComponentBase : ViewBase, IMvuComponent
{
    ViewPropertyState[]? _localPropertyStates = null;
    List<ViewPropertyState> _externalPropertyStates = null;
    List<IMvuComponent> _dependentViews = null;

    protected override void OnCreated()
    {
        InitStateMembers();

        InjectServices();
    }

    private void InjectServices()
    {
        var serviceProps = GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Instance)
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
                throw new InvalidOperationException($"Can't inject {service.GetType()} service. Ensure that target property: {GetType().Name}.{propertyInfo.Name} has public setter");
            }
        }
    }

    private object GetServiceFromProvider(Type serviceType)
    {
        if (ComponentExtensions.ServiceProvider == null)
            throw new InvalidOperationException("Please set Service Provider by calling UseServiceProvider on AppBuilder");

        return ComponentExtensions.ServiceProvider.GetService(serviceType);
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
    }

    public void AddExternalState<TContorl, TValue>(TContorl source, string propertyName, Action<TValue> setAction)
        where TContorl : ComponentBase
    {
        _externalPropertyStates ??= new List<ViewPropertyState>();

        var propInfo = source.GetType().GetProperty(propertyName);

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

        return new MvuBinding()
        {
            Source = bindingSource,
            Path = propName,
            Mode = bindingMode,
            Value = value
        };
    }

    public class MvuBinding : Binding
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
}
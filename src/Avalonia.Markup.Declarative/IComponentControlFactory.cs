using System;
using Avalonia.Controls;

namespace Avalonia.Markup.Declarative;

public interface IComponentControlFactory
{
    TControl CreateControlInstance<TControl>() where TControl : Control;
}

public class FuncComponentControlFactory(Func<Type, Control> factoryFunc) : IComponentControlFactory
{
    public TControl CreateControlInstance<TControl>() where TControl : Control
    {
        return (TControl)factoryFunc(typeof(TControl));
    }
}
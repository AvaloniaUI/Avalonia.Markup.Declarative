using Avalonia.Controls;
using System.Diagnostics.CodeAnalysis;

namespace Avalonia.Markup.Declarative;

/// <summary>
/// Factory for creating control instances with optional dependency injection.
/// Replaces the former ComponentBase.New&lt;T&gt;() pattern.
/// </summary>
public static class ViewFactory
{
    /// <summary>
    /// Creates a control instance using the registered <see cref="IComponentControlFactory"/>
    /// or falls back to parameterless constructor.
    /// </summary>
    public static TControl Create<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] TControl>() where TControl : Control
    {
        var factory = AppBuilderExtensions.ComponentControlFactory;

        if (factory != null)
            return factory.CreateControlInstance<TControl>();

        if (ViewFactoryRegistry.TryCreate<TControl>(out var registeredControl))
            return registeredControl;

        return System.Activator.CreateInstance<TControl>();
    }
}

using Avalonia.Controls;
using System.Diagnostics.CodeAnalysis;

namespace Avalonia.Markup.Declarative;

/// <summary>
/// Defines a factory interface for creating Avalonia <see cref="Control"/> instances with support for dependency injection.
/// Implementations can use an <see cref="IServiceProvider"/> or other mechanisms to inject services into control constructors.
///
/// <para>
/// <b>Example implementation using Microsoft.Extensions.DependencyInjection:</b>
/// <code language="csharp">
/// public class ControlFactory(IServiceProvider serviceProvider) : IComponentControlFactory
/// {
///     public TControl CreateControlInstance&lt;TControl&gt;()
///         where TControl : Control
///         => ActivatorUtilities.CreateInstance&lt;TControl&gt;(serviceProvider);
/// }
/// </code>
/// </para>
/// </summary>
public interface IComponentControlFactory
{
    /// <summary>
    /// Creates an instance of the specified <see cref="Control"/> type, optionally injecting dependencies.
    /// </summary>
    /// <typeparam name="TControl">The type of control to create. Must have a public constructor.</typeparam>
    /// <returns>An instance of <typeparamref name="TControl"/>.</returns>
    TControl CreateControlInstance<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TControl>() where TControl : Control;
}
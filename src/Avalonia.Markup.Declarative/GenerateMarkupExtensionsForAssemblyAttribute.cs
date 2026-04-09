using System;

namespace Avalonia.Markup.Declarative;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GenerateMarkupExtensionsForAssemblyAttribute(Type anchorType) : Attribute
{
    public Type AnchorType { get; } = anchorType;
}

using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InlineUIContainerExtensions
{
public static Style<InlineUIContainer> Child(this Style<InlineUIContainer> style, Control value)
=> style._addSetter(InlineUIContainer.ChildProperty, value);
public static Style<InlineUIContainer> Child(this Style<InlineUIContainer> style, IBinding binding)
=> style._addSetter(InlineUIContainer.ChildProperty, binding);
}


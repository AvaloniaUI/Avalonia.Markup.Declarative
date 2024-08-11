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
public static Style<T> Child<T>(this Style<T> style, Control value) where T : InlineUIContainer
=> style._addSetter(InlineUIContainer.ChildProperty, value);
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : InlineUIContainer
=> style._addSetter(InlineUIContainer.ChildProperty, binding);
}


using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using InlineUIContainer = Avalonia.Controls.Documents.InlineUIContainer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InlineUIContainerExtensions
{
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Documents.InlineUIContainer
=> style._addSetter(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, value);
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.InlineUIContainer
=> style._addSetter(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, binding);
}


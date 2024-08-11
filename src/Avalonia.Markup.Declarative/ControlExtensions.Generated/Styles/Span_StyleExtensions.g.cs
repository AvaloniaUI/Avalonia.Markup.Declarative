using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SpanExtensions
{
public static Style<T> Inlines<T>(this Style<T> style, InlineCollection value) where T : Span
=> style._addSetter(Span.InlinesProperty, value);
public static Style<T> Inlines<T>(this Style<T> style, IBinding binding) where T : Span
=> style._addSetter(Span.InlinesProperty, binding);
}


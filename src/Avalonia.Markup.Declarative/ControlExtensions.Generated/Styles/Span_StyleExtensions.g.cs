using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Span = Avalonia.Controls.Documents.Span;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SpanExtensions
{
public static Style<T> Inlines<T>(this Style<T> style, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.Documents.Span
=> style._addSetter(Avalonia.Controls.Documents.Span.InlinesProperty, value);
public static Style<T> Inlines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Span
=> style._addSetter(Avalonia.Controls.Documents.Span.InlinesProperty, binding);
}


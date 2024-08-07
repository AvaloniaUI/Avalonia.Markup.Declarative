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
public static Style<Span> Inlines(this Style<Span> style, InlineCollection value)
=> style._addSetter(Span.InlinesProperty, value);
public static Style<Span> Inlines(this Style<Span> style, IBinding binding)
=> style._addSetter(Span.InlinesProperty, binding);
}


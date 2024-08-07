using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InlineExtensions
{
public static Style<Inline> TextDecorations(this Style<Inline> style, TextDecorationCollection value)
=> style._addSetter(Inline.TextDecorationsProperty, value);
public static Style<Inline> TextDecorations(this Style<Inline> style, IBinding binding)
=> style._addSetter(Inline.TextDecorationsProperty, binding);
public static Style<Inline> BaselineAlignment(this Style<Inline> style, BaselineAlignment value)
=> style._addSetter(Inline.BaselineAlignmentProperty, value);
public static Style<Inline> BaselineAlignment(this Style<Inline> style, IBinding binding)
=> style._addSetter(Inline.BaselineAlignmentProperty, binding);
}


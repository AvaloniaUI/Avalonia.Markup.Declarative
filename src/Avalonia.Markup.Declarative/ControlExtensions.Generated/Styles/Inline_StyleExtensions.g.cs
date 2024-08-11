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
public static Style<T> TextDecorations<T>(this Style<T> style, TextDecorationCollection value) where T : Inline
=> style._addSetter(Inline.TextDecorationsProperty, value);
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : Inline
=> style._addSetter(Inline.TextDecorationsProperty, binding);
public static Style<T> BaselineAlignment<T>(this Style<T> style, BaselineAlignment value) where T : Inline
=> style._addSetter(Inline.BaselineAlignmentProperty, value);
public static Style<T> BaselineAlignment<T>(this Style<T> style, IBinding binding) where T : Inline
=> style._addSetter(Inline.BaselineAlignmentProperty, binding);
}


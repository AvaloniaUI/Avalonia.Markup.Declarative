using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Inline = Avalonia.Controls.Documents.Inline;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InlineExtensions
{
public static Style<T> TextDecorations<T>(this Style<T> style, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.Documents.Inline
=> style._addSetter(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, value);
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Inline
=> style._addSetter(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, binding);
public static Style<T> BaselineAlignment<T>(this Style<T> style, Avalonia.Media.BaselineAlignment value) where T : Avalonia.Controls.Documents.Inline
=> style._addSetter(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, value);
public static Style<T> BaselineAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Inline
=> style._addSetter(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, binding);
}


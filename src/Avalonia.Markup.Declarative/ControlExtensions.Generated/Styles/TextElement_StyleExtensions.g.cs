using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TextElement = Avalonia.Controls.Documents.TextElement;

namespace Avalonia.Markup.Declarative;
public static partial class TextElementExtensions
{
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement
=> style._addSetter(Avalonia.Controls.Documents.TextElement.BackgroundProperty, binding);
}


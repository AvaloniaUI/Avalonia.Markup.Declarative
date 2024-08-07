using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ImageExtensions
{
public static Style<Image> Source(this Style<Image> style, IImage value)
=> style._addSetter(Image.SourceProperty, value);
public static Style<Image> Source(this Style<Image> style, IBinding binding)
=> style._addSetter(Image.SourceProperty, binding);
public static Style<Image> Stretch(this Style<Image> style, Stretch value)
=> style._addSetter(Image.StretchProperty, value);
public static Style<Image> Stretch(this Style<Image> style, IBinding binding)
=> style._addSetter(Image.StretchProperty, binding);
public static Style<Image> StretchDirection(this Style<Image> style, StretchDirection value)
=> style._addSetter(Image.StretchDirectionProperty, value);
public static Style<Image> StretchDirection(this Style<Image> style, IBinding binding)
=> style._addSetter(Image.StretchDirectionProperty, binding);
}


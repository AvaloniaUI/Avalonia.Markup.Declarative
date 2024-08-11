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
public static Style<T> Source<T>(this Style<T> style, IImage value) where T : Image
=> style._addSetter(Image.SourceProperty, value);
public static Style<T> Source<T>(this Style<T> style, IBinding binding) where T : Image
=> style._addSetter(Image.SourceProperty, binding);
public static Style<T> Stretch<T>(this Style<T> style, Stretch value) where T : Image
=> style._addSetter(Image.StretchProperty, value);
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Image
=> style._addSetter(Image.StretchProperty, binding);
public static Style<T> StretchDirection<T>(this Style<T> style, StretchDirection value) where T : Image
=> style._addSetter(Image.StretchDirectionProperty, value);
public static Style<T> StretchDirection<T>(this Style<T> style, IBinding binding) where T : Image
=> style._addSetter(Image.StretchDirectionProperty, binding);
}


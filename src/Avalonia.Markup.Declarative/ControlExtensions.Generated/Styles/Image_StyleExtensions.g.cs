using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Image = Avalonia.Controls.Image;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ImageExtensions
{
public static Style<T> Source<T>(this Style<T> style, Avalonia.Media.IImage value) where T : Avalonia.Controls.Image
=> style._addSetter(Avalonia.Controls.Image.SourceProperty, value);
public static Style<T> Source<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image
=> style._addSetter(Avalonia.Controls.Image.SourceProperty, binding);
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Image
=> style._addSetter(Avalonia.Controls.Image.StretchProperty, value);
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image
=> style._addSetter(Avalonia.Controls.Image.StretchProperty, binding);
public static Style<T> StretchDirection<T>(this Style<T> style, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Image
=> style._addSetter(Avalonia.Controls.Image.StretchDirectionProperty, value);
public static Style<T> StretchDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image
=> style._addSetter(Avalonia.Controls.Image.StretchDirectionProperty, binding);
}


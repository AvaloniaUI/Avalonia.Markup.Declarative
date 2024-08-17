using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using PathIcon = Avalonia.Controls.PathIcon;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PathIconExtensions
{
public static Style<T> Data<T>(this Style<T> style, Avalonia.Media.Geometry value) where T : Avalonia.Controls.PathIcon
=> style._addSetter(Avalonia.Controls.PathIcon.DataProperty, value);
public static Style<T> Data<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.PathIcon
=> style._addSetter(Avalonia.Controls.PathIcon.DataProperty, binding);
}


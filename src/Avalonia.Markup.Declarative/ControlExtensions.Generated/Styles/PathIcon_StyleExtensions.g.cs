using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PathIconExtensions
{
public static Style<PathIcon> Data(this Style<PathIcon> style, Geometry value)
=> style._addSetter(PathIcon.DataProperty, value);
public static Style<PathIcon> Data(this Style<PathIcon> style, IBinding binding)
=> style._addSetter(PathIcon.DataProperty, binding);
}


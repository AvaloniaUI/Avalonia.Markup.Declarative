using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Path = Avalonia.Controls.Shapes.Path;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PathExtensions
{
public static Style<T> Data<T>(this Style<T> style, Avalonia.Media.Geometry value) where T : Avalonia.Controls.Shapes.Path
=> style._addSetter(Avalonia.Controls.Shapes.Path.DataProperty, value);
public static Style<T> Data<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Path
=> style._addSetter(Avalonia.Controls.Shapes.Path.DataProperty, binding);
}


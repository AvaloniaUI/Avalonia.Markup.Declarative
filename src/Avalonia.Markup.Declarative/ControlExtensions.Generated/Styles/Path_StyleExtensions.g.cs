using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PathExtensions
{
public static Style<T> Data<T>(this Style<T> style, Geometry value) where T : Path
=> style._addSetter(Path.DataProperty, value);
public static Style<T> Data<T>(this Style<T> style, IBinding binding) where T : Path
=> style._addSetter(Path.DataProperty, binding);
}


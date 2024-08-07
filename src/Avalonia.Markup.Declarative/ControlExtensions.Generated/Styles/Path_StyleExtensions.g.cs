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
public static Style<Path> Data(this Style<Path> style, Geometry value)
=> style._addSetter(Path.DataProperty, value);
public static Style<Path> Data(this Style<Path> style, IBinding binding)
=> style._addSetter(Path.DataProperty, binding);
}


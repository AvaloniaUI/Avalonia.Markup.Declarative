using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Geometry = Avalonia.Media.Geometry;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GeometryEventsExtensions
{
    public static T OnChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Geometry => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Changed += h);
}


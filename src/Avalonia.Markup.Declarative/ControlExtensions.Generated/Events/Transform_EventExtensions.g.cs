using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Transform = Avalonia.Media.Transform;

namespace Avalonia.Markup.Declarative;
public static partial class TransformEventsExtensions
{
    public static T OnChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Transform => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Changed += h);
}


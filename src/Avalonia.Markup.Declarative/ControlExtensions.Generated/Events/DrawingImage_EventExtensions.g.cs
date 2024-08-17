using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using DrawingImage = Avalonia.Media.DrawingImage;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DrawingImageEventsExtensions
{
    public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.DrawingImage => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);
}


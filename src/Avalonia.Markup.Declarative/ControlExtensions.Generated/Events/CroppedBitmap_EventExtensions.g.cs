using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CroppedBitmapEventsExtensions
{
    public static T OnInvalidated<T>(this T control, Action action) where T : CroppedBitmap => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}


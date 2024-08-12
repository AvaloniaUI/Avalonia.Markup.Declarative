using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class EffectEventsExtensions
{
    public static T OnInvalidated<T>(this T control, Action action) where T : Effect => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}


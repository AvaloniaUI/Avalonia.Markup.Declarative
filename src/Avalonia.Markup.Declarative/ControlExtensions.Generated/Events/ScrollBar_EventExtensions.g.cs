using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollBarEventsExtensions
{
    public static T OnScroll<T>(this T control, Action<ScrollEventArgs> action) where T : ScrollBar => 
        control._setEvent((EventHandler<ScrollEventArgs>) ((_, args) => action(args)), h => control.Scroll += h);
}


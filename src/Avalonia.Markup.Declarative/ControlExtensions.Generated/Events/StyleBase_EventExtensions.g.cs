using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using StyleBase = Avalonia.Styling.StyleBase;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StyleBaseEventsExtensions
{
    public static T OnOwnerChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Styling.StyleBase => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.OwnerChanged += h);
}


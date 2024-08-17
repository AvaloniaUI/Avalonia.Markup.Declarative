using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using Styles = Avalonia.Styling.Styles;
using System;
using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StylesEventsExtensions
{
    public static T OnCollectionChanged<T>(this T control, Action<System.Collections.Specialized.NotifyCollectionChangedEventArgs> action) where T : Avalonia.Styling.Styles => 
        control._setEvent((System.Collections.Specialized.NotifyCollectionChangedEventHandler) ((arg0, arg1) => action(arg1)), h => control.CollectionChanged += h);
    public static T OnOwnerChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Styling.Styles => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.OwnerChanged += h);
}


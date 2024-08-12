using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StylesEventsExtensions
{
    public static T OnCollectionChanged<T>(this T control, Action action) where T : Styles => 
        control._setEvent((NotifyCollectionChangedEventHandler) ((_, args) => action()), h => control.CollectionChanged += h);
    public static T OnOwnerChanged<T>(this T control, Action action) where T : Styles => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.OwnerChanged += h);
}


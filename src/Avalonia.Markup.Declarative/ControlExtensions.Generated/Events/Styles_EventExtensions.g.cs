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
    public static Styles OnCollectionChanged(this Styles control, Action action) => 
        control._setEvent((NotifyCollectionChangedEventHandler) ((_, args) => action()), h => control.CollectionChanged += h);
    public static Styles OnOwnerChanged(this Styles control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.OwnerChanged += h);
}


using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class AvaloniaObjectEventsExtensions
{
    public static T OnPropertyChanged<T>(this T control, Action<AvaloniaPropertyChangedEventArgs> action) where T : AvaloniaObject => 
        control._setEvent((EventHandler<AvaloniaPropertyChangedEventArgs>) ((_, args) => action(args)), h => control.PropertyChanged += h);
}


using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using AvaloniaObject = Avalonia.AvaloniaObject;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class AvaloniaObjectEventsExtensions
{
    public static T OnPropertyChanged<T>(this T control, Action<Avalonia.AvaloniaPropertyChangedEventArgs> action) where T : Avalonia.AvaloniaObject => 
        control._setEvent((System.EventHandler<Avalonia.AvaloniaPropertyChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PropertyChanged += h);
}


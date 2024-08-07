using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SplitButtonEventsExtensions
{
    public static SplitButton OnClick(this SplitButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Click += h);
}


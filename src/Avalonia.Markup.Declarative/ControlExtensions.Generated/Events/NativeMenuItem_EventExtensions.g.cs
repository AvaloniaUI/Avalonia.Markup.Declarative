using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NativeMenuItemEventsExtensions
{
    public static NativeMenuItem OnClick(this NativeMenuItem control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Click += h);
}


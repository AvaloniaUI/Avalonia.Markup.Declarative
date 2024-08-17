using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.LogicalTree;
using StyledElement = Avalonia.StyledElement;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StyledElementEventsExtensions
{
    public static T OnAttachedToLogicalTree<T>(this T control, Action<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs> action) where T : Avalonia.StyledElement => 
        control._setEvent((System.EventHandler<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.AttachedToLogicalTree += h);
    public static T OnDetachedFromLogicalTree<T>(this T control, Action<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs> action) where T : Avalonia.StyledElement => 
        control._setEvent((System.EventHandler<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DetachedFromLogicalTree += h);
    public static T OnDataContextChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DataContextChanged += h);
    public static T OnInitialized<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Initialized += h);
    public static T OnResourcesChanged<T>(this T control, Action<Avalonia.Controls.ResourcesChangedEventArgs> action) where T : Avalonia.StyledElement => 
        control._setEvent((System.EventHandler<Avalonia.Controls.ResourcesChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ResourcesChanged += h);
    public static T OnActualThemeVariantChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ActualThemeVariantChanged += h);
}


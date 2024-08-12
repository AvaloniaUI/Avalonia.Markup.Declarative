using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.LogicalTree;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StyledElementEventsExtensions
{
    public static T OnAttachedToLogicalTree<T>(this T control, Action<LogicalTreeAttachmentEventArgs> action) where T : StyledElement => 
        control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.AttachedToLogicalTree += h);
    public static T OnDetachedFromLogicalTree<T>(this T control, Action<LogicalTreeAttachmentEventArgs> action) where T : StyledElement => 
        control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.DetachedFromLogicalTree += h);
    public static T OnDataContextChanged<T>(this T control, Action action) where T : StyledElement => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DataContextChanged += h);
    public static T OnInitialized<T>(this T control, Action action) where T : StyledElement => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Initialized += h);
    public static T OnResourcesChanged<T>(this T control, Action<ResourcesChangedEventArgs> action) where T : StyledElement => 
        control._setEvent((EventHandler<ResourcesChangedEventArgs>) ((_, args) => action(args)), h => control.ResourcesChanged += h);
    public static T OnActualThemeVariantChanged<T>(this T control, Action action) where T : StyledElement => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ActualThemeVariantChanged += h);
}


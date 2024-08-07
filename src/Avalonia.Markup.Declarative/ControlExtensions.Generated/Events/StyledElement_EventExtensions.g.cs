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
    public static StyledElement OnAttachedToLogicalTree(this StyledElement control, Action<LogicalTreeAttachmentEventArgs> action) => 
        control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.AttachedToLogicalTree += h);
    public static StyledElement OnDetachedFromLogicalTree(this StyledElement control, Action<LogicalTreeAttachmentEventArgs> action) => 
        control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.DetachedFromLogicalTree += h);
    public static StyledElement OnDataContextChanged(this StyledElement control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DataContextChanged += h);
    public static StyledElement OnInitialized(this StyledElement control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Initialized += h);
    public static StyledElement OnResourcesChanged(this StyledElement control, Action<ResourcesChangedEventArgs> action) => 
        control._setEvent((EventHandler<ResourcesChangedEventArgs>) ((_, args) => action(args)), h => control.ResourcesChanged += h);
    public static StyledElement OnActualThemeVariantChanged(this StyledElement control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ActualThemeVariantChanged += h);
}


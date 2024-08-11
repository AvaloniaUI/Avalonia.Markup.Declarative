using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollViewerExtensions
{
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, Boolean value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.BringIntoViewOnFocusChangeProperty, value);
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);
public static Style<T> Offset<T>(this Style<T> style, Vector value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.OffsetProperty, value);
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.OffsetProperty, binding);
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, ScrollBarVisibility value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.HorizontalScrollBarVisibilityProperty, value);
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, SnapPointsType value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.HorizontalSnapPointsTypeProperty, value);
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.HorizontalSnapPointsTypeProperty, binding);
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, SnapPointsType value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.VerticalSnapPointsTypeProperty, value);
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.VerticalSnapPointsTypeProperty, binding);
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, SnapPointsAlignment value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.HorizontalSnapPointsAlignmentProperty, value);
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, SnapPointsAlignment value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.VerticalSnapPointsAlignmentProperty, value);
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, ScrollBarVisibility value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.VerticalScrollBarVisibilityProperty, value);
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.VerticalScrollBarVisibilityProperty, binding);
public static Style<T> AllowAutoHide<T>(this Style<T> style, Boolean value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.AllowAutoHideProperty, value);
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.AllowAutoHideProperty, binding);
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, Boolean value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.IsScrollChainingEnabledProperty, value);
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.IsScrollChainingEnabledProperty, binding);
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, Boolean value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.IsScrollInertiaEnabledProperty, value);
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.IsScrollInertiaEnabledProperty, binding);
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, Boolean value) where T : ScrollViewer
=> style._addSetter(ScrollViewer.IsDeferredScrollingEnabledProperty, value);
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, IBinding binding) where T : ScrollViewer
=> style._addSetter(ScrollViewer.IsDeferredScrollingEnabledProperty, binding);
}


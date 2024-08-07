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
public static Style<ScrollViewer> BringIntoViewOnFocusChange(this Style<ScrollViewer> style, Boolean value)
=> style._addSetter(ScrollViewer.BringIntoViewOnFocusChangeProperty, value);
public static Style<ScrollViewer> BringIntoViewOnFocusChange(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);
public static Style<ScrollViewer> Offset(this Style<ScrollViewer> style, Vector value)
=> style._addSetter(ScrollViewer.OffsetProperty, value);
public static Style<ScrollViewer> Offset(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.OffsetProperty, binding);
public static Style<ScrollViewer> HorizontalScrollBarVisibility(this Style<ScrollViewer> style, ScrollBarVisibility value)
=> style._addSetter(ScrollViewer.HorizontalScrollBarVisibilityProperty, value);
public static Style<ScrollViewer> HorizontalScrollBarVisibility(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);
public static Style<ScrollViewer> HorizontalSnapPointsType(this Style<ScrollViewer> style, SnapPointsType value)
=> style._addSetter(ScrollViewer.HorizontalSnapPointsTypeProperty, value);
public static Style<ScrollViewer> HorizontalSnapPointsType(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.HorizontalSnapPointsTypeProperty, binding);
public static Style<ScrollViewer> VerticalSnapPointsType(this Style<ScrollViewer> style, SnapPointsType value)
=> style._addSetter(ScrollViewer.VerticalSnapPointsTypeProperty, value);
public static Style<ScrollViewer> VerticalSnapPointsType(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.VerticalSnapPointsTypeProperty, binding);
public static Style<ScrollViewer> HorizontalSnapPointsAlignment(this Style<ScrollViewer> style, SnapPointsAlignment value)
=> style._addSetter(ScrollViewer.HorizontalSnapPointsAlignmentProperty, value);
public static Style<ScrollViewer> HorizontalSnapPointsAlignment(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);
public static Style<ScrollViewer> VerticalSnapPointsAlignment(this Style<ScrollViewer> style, SnapPointsAlignment value)
=> style._addSetter(ScrollViewer.VerticalSnapPointsAlignmentProperty, value);
public static Style<ScrollViewer> VerticalSnapPointsAlignment(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);
public static Style<ScrollViewer> VerticalScrollBarVisibility(this Style<ScrollViewer> style, ScrollBarVisibility value)
=> style._addSetter(ScrollViewer.VerticalScrollBarVisibilityProperty, value);
public static Style<ScrollViewer> VerticalScrollBarVisibility(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.VerticalScrollBarVisibilityProperty, binding);
public static Style<ScrollViewer> AllowAutoHide(this Style<ScrollViewer> style, Boolean value)
=> style._addSetter(ScrollViewer.AllowAutoHideProperty, value);
public static Style<ScrollViewer> AllowAutoHide(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.AllowAutoHideProperty, binding);
public static Style<ScrollViewer> IsScrollChainingEnabled(this Style<ScrollViewer> style, Boolean value)
=> style._addSetter(ScrollViewer.IsScrollChainingEnabledProperty, value);
public static Style<ScrollViewer> IsScrollChainingEnabled(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.IsScrollChainingEnabledProperty, binding);
public static Style<ScrollViewer> IsScrollInertiaEnabled(this Style<ScrollViewer> style, Boolean value)
=> style._addSetter(ScrollViewer.IsScrollInertiaEnabledProperty, value);
public static Style<ScrollViewer> IsScrollInertiaEnabled(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.IsScrollInertiaEnabledProperty, binding);
public static Style<ScrollViewer> IsDeferredScrollingEnabled(this Style<ScrollViewer> style, Boolean value)
=> style._addSetter(ScrollViewer.IsDeferredScrollingEnabledProperty, value);
public static Style<ScrollViewer> IsDeferredScrollingEnabled(this Style<ScrollViewer> style, IBinding binding)
=> style._addSetter(ScrollViewer.IsDeferredScrollingEnabledProperty, binding);
}


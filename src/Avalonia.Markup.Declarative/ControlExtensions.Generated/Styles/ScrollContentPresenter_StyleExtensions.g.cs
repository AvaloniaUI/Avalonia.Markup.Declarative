using Avalonia;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollContentPresenterExtensions
{
public static Style<ScrollContentPresenter> CanHorizontallyScroll(this Style<ScrollContentPresenter> style, Boolean value)
=> style._addSetter(ScrollContentPresenter.CanHorizontallyScrollProperty, value);
public static Style<ScrollContentPresenter> CanHorizontallyScroll(this Style<ScrollContentPresenter> style, IBinding binding)
=> style._addSetter(ScrollContentPresenter.CanHorizontallyScrollProperty, binding);
public static Style<ScrollContentPresenter> CanVerticallyScroll(this Style<ScrollContentPresenter> style, Boolean value)
=> style._addSetter(ScrollContentPresenter.CanVerticallyScrollProperty, value);
public static Style<ScrollContentPresenter> CanVerticallyScroll(this Style<ScrollContentPresenter> style, IBinding binding)
=> style._addSetter(ScrollContentPresenter.CanVerticallyScrollProperty, binding);
public static Style<ScrollContentPresenter> Offset(this Style<ScrollContentPresenter> style, Vector value)
=> style._addSetter(ScrollContentPresenter.OffsetProperty, value);
public static Style<ScrollContentPresenter> Offset(this Style<ScrollContentPresenter> style, IBinding binding)
=> style._addSetter(ScrollContentPresenter.OffsetProperty, binding);
public static Style<ScrollContentPresenter> HorizontalSnapPointsType(this Style<ScrollContentPresenter> style, SnapPointsType value)
=> style._addSetter(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, value);
public static Style<ScrollContentPresenter> HorizontalSnapPointsType(this Style<ScrollContentPresenter> style, IBinding binding)
=> style._addSetter(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);
public static Style<ScrollContentPresenter> VerticalSnapPointsType(this Style<ScrollContentPresenter> style, SnapPointsType value)
=> style._addSetter(ScrollContentPresenter.VerticalSnapPointsTypeProperty, value);
public static Style<ScrollContentPresenter> VerticalSnapPointsType(this Style<ScrollContentPresenter> style, IBinding binding)
=> style._addSetter(ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);
public static Style<ScrollContentPresenter> HorizontalSnapPointsAlignment(this Style<ScrollContentPresenter> style, SnapPointsAlignment value)
=> style._addSetter(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, value);
public static Style<ScrollContentPresenter> HorizontalSnapPointsAlignment(this Style<ScrollContentPresenter> style, IBinding binding)
=> style._addSetter(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);
public static Style<ScrollContentPresenter> VerticalSnapPointsAlignment(this Style<ScrollContentPresenter> style, SnapPointsAlignment value)
=> style._addSetter(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, value);
public static Style<ScrollContentPresenter> VerticalSnapPointsAlignment(this Style<ScrollContentPresenter> style, IBinding binding)
=> style._addSetter(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);
public static Style<ScrollContentPresenter> IsScrollChainingEnabled(this Style<ScrollContentPresenter> style, Boolean value)
=> style._addSetter(ScrollContentPresenter.IsScrollChainingEnabledProperty, value);
public static Style<ScrollContentPresenter> IsScrollChainingEnabled(this Style<ScrollContentPresenter> style, IBinding binding)
=> style._addSetter(ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);
}


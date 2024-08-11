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
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, Boolean value) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.CanHorizontallyScrollProperty, value);
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, IBinding binding) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.CanHorizontallyScrollProperty, binding);
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, Boolean value) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.CanVerticallyScrollProperty, value);
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, IBinding binding) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.CanVerticallyScrollProperty, binding);
public static Style<T> Offset<T>(this Style<T> style, Vector value) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.OffsetProperty, value);
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.OffsetProperty, binding);
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, SnapPointsType value) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, value);
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, SnapPointsType value) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.VerticalSnapPointsTypeProperty, value);
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, SnapPointsAlignment value) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, value);
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, SnapPointsAlignment value) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, value);
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, Boolean value) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.IsScrollChainingEnabledProperty, value);
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : ScrollContentPresenter
=> style._addSetter(ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);
}


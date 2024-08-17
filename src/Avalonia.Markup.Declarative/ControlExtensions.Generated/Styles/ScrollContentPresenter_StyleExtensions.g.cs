using Avalonia;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ScrollContentPresenter = Avalonia.Controls.Presenters.ScrollContentPresenter;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollContentPresenterExtensions
{
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, value);
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, binding);
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, value);
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, binding);
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, value);
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, binding);
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, value);
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, value);
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, value);
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, value);
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, value);
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);
}


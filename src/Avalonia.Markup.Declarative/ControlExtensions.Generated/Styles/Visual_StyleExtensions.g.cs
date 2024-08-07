using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class VisualExtensions
{
public static Style<T> ClipToBounds<T>(this Style<T> style, Boolean value) where T : Visual
=> style._addSetter(Visual.ClipToBoundsProperty, value);
public static Style<T> ClipToBounds<T>(this Style<T> style, IBinding binding) where T : Visual
=> style._addSetter(Visual.ClipToBoundsProperty, binding);
public static Style<T> Clip<T>(this Style<T> style, Geometry value) where T : Visual
=> style._addSetter(Visual.ClipProperty, value);
public static Style<T> Clip<T>(this Style<T> style, IBinding binding) where T : Visual
=> style._addSetter(Visual.ClipProperty, binding);
public static Style<T> IsVisible<T>(this Style<T> style, Boolean value) where T : Visual
=> style._addSetter(Visual.IsVisibleProperty, value);
public static Style<T> IsVisible<T>(this Style<T> style, IBinding binding) where T : Visual
=> style._addSetter(Visual.IsVisibleProperty, binding);
public static Style<T> Opacity<T>(this Style<T> style, Double value) where T : Visual
=> style._addSetter(Visual.OpacityProperty, value);
public static Style<T> Opacity<T>(this Style<T> style, IBinding binding) where T : Visual
=> style._addSetter(Visual.OpacityProperty, binding);
public static Style<T> OpacityMask<T>(this Style<T> style, IBrush value) where T : Visual
=> style._addSetter(Visual.OpacityMaskProperty, value);
public static Style<T> OpacityMask<T>(this Style<T> style, IBinding binding) where T : Visual
=> style._addSetter(Visual.OpacityMaskProperty, binding);
public static Style<T> Effect<T>(this Style<T> style, IEffect value) where T : Visual
=> style._addSetter(Visual.EffectProperty, value);
public static Style<T> Effect<T>(this Style<T> style, IBinding binding) where T : Visual
=> style._addSetter(Visual.EffectProperty, binding);
public static Style<T> RenderTransform<T>(this Style<T> style, ITransform value) where T : Visual
=> style._addSetter(Visual.RenderTransformProperty, value);
public static Style<T> RenderTransform<T>(this Style<T> style, IBinding binding) where T : Visual
=> style._addSetter(Visual.RenderTransformProperty, binding);
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, RelativePoint value) where T : Visual
=> style._addSetter(Visual.RenderTransformOriginProperty, value);
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, IBinding binding) where T : Visual
=> style._addSetter(Visual.RenderTransformOriginProperty, binding);

public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Double x, Double y, RelativeUnit unit) where T : Visual
   => style._addSetter(Visual.RenderTransformOriginProperty, new RelativePoint(x, y, unit));
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Point point, RelativeUnit unit) where T : Visual
   => style._addSetter(Visual.RenderTransformOriginProperty, new RelativePoint(point, unit));
public static Style<T> FlowDirection<T>(this Style<T> style, FlowDirection value) where T : Visual
=> style._addSetter(Visual.FlowDirectionProperty, value);
public static Style<T> FlowDirection<T>(this Style<T> style, IBinding binding) where T : Visual
=> style._addSetter(Visual.FlowDirectionProperty, binding);
public static Style<T> ZIndex<T>(this Style<T> style, Int32 value) where T : Visual
=> style._addSetter(Visual.ZIndexProperty, value);
public static Style<T> ZIndex<T>(this Style<T> style, IBinding binding) where T : Visual
=> style._addSetter(Visual.ZIndexProperty, binding);
}


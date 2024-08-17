using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Visual = Avalonia.Visual;

namespace Avalonia.Markup.Declarative;
public static partial class VisualExtensions
{
public static Style<T> ClipToBounds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.ClipToBoundsProperty, value);
public static Style<T> ClipToBounds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.ClipToBoundsProperty, binding);
public static Style<T> Clip<T>(this Style<T> style, Avalonia.Media.Geometry value) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.ClipProperty, value);
public static Style<T> Clip<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.ClipProperty, binding);
public static Style<T> IsVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.IsVisibleProperty, value);
public static Style<T> IsVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.IsVisibleProperty, binding);
public static Style<T> Opacity<T>(this Style<T> style, System.Double value) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.OpacityProperty, value);
public static Style<T> Opacity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.OpacityProperty, binding);
public static Style<T> OpacityMask<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.OpacityMaskProperty, value);
public static Style<T> OpacityMask<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.OpacityMaskProperty, binding);
public static Style<T> Effect<T>(this Style<T> style, Avalonia.Media.IEffect value) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.EffectProperty, value);
public static Style<T> Effect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.EffectProperty, binding);
public static Style<T> RenderTransform<T>(this Style<T> style, Avalonia.Media.ITransform value) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.RenderTransformProperty, value);
public static Style<T> RenderTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.RenderTransformProperty, binding);
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Avalonia.RelativePoint value) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, value);
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, binding);

public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Double x, Double y, RelativeUnit unit) where T : Avalonia.Visual
   => style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, new Avalonia.RelativePoint(x, y, unit));
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Point point, RelativeUnit unit) where T : Avalonia.Visual
   => style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, new Avalonia.RelativePoint(point, unit));
public static Style<T> ZIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.ZIndexProperty, value);
public static Style<T> ZIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual
=> style._addSetter(Avalonia.Visual.ZIndexProperty, binding);
}


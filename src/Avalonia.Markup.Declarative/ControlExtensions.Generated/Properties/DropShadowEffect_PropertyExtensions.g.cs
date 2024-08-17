#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using DropShadowEffect = Avalonia.Media.DropShadowEffect;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DropShadowEffectExtensions
{
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, IBinding binding)
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty, binding);
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty, func, onChanged, expression);
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DropShadowEffect.OffsetXProperty, ps, () => control.OffsetX = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.DropShadowEffect OffsetX<TValue>(this Avalonia.Media.DropShadowEffect control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DropShadowEffect.OffsetXProperty, ps, () => control.OffsetX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, IBinding binding)
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty, binding);
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty, func, onChanged, expression);
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DropShadowEffect.OffsetYProperty, ps, () => control.OffsetY = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.DropShadowEffect OffsetY<TValue>(this Avalonia.Media.DropShadowEffect control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DropShadowEffect.OffsetYProperty, ps, () => control.OffsetY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


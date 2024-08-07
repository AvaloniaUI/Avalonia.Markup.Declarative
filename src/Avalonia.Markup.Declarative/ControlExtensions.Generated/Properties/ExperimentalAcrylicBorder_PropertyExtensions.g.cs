#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExperimentalAcrylicBorderExtensions
{
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, IBinding binding)
   => control._set(ExperimentalAcrylicBorder.CornerRadiusProperty, binding);
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ExperimentalAcrylicBorder.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Func<CornerRadius> func, Action<CornerRadius>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicBorder.CornerRadiusProperty, func, onChanged, expression);
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicBorder.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicBorder CornerRadius<TValue>(this ExperimentalAcrylicBorder control, TValue value, FuncValueConverter<TValue, CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicBorder.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double uniformRadius = default)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double top = default, Double bottom = default)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double topLeft = default, Double topRight = default, Double bottomRight = default, Double bottomLeft = default)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, IBinding binding)
   => control._set(ExperimentalAcrylicBorder.MaterialProperty, binding);
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ExperimentalAcrylicBorder.MaterialProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, Func<ExperimentalAcrylicMaterial> func, Action<ExperimentalAcrylicMaterial>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicBorder.MaterialProperty, func, onChanged, expression);
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, ExperimentalAcrylicMaterial value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicBorder.MaterialProperty, ps, () => control.Material = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicBorder Material<TValue>(this ExperimentalAcrylicBorder control, TValue value, FuncValueConverter<TValue, ExperimentalAcrylicMaterial> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicBorder.MaterialProperty, ps, () => control.Material = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


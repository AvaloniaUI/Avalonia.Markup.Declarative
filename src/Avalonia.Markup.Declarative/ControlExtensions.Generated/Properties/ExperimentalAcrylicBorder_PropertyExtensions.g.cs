#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using ExperimentalAcrylicBorder = Avalonia.Controls.ExperimentalAcrylicBorder;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExperimentalAcrylicBorderExtensions
{
public static T CornerRadius<T>(this T control, IBinding binding) where T : Avalonia.Controls.ExperimentalAcrylicBorder
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, binding);
public static T CornerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, func, onChanged, expression);
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder
=> control._setEx(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static T CornerRadius<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder
=> control._setEx(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T CornerRadius<T>(this T control, Double uniformRadius = default) where T : Avalonia.Controls.ExperimentalAcrylicBorder
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, Double top = default, Double bottom = default) where T : Avalonia.Controls.ExperimentalAcrylicBorder
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, Double topLeft = default, Double topRight = default, Double bottomRight = default, Double bottomLeft = default) where T : Avalonia.Controls.ExperimentalAcrylicBorder
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static T Material<T>(this T control, IBinding binding) where T : Avalonia.Controls.ExperimentalAcrylicBorder
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty, binding);
public static T Material<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Material<T>(this T control, Func<Avalonia.Media.ExperimentalAcrylicMaterial> func, Action<Avalonia.Media.ExperimentalAcrylicMaterial>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder
   => control._set(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty, func, onChanged, expression);
public static T Material<T>(this T control, Avalonia.Media.ExperimentalAcrylicMaterial value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder
=> control._setEx(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty, ps, () => control.Material = value, bindingMode, converter, bindingSource);
public static T Material<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.ExperimentalAcrylicMaterial> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder
=> control._setEx(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty, ps, () => control.Material = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


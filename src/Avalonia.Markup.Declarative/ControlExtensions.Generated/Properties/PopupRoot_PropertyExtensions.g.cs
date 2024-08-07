#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PopupRootExtensions
{
public static PopupRoot Transform(this PopupRoot control, IBinding binding)
   => control._set(PopupRoot.TransformProperty, binding);
public static PopupRoot Transform(this PopupRoot control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PopupRoot.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PopupRoot Transform(this PopupRoot control, Func<Transform> func, Action<Transform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PopupRoot.TransformProperty, func, onChanged, expression);
public static PopupRoot Transform(this PopupRoot control, Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PopupRoot.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static PopupRoot Transform<TValue>(this PopupRoot control, TValue value, FuncValueConverter<TValue, Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PopupRoot.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PopupRoot WindowManagerAddShadowHint(this PopupRoot control, IBinding binding)
   => control._set(PopupRoot.WindowManagerAddShadowHintProperty, binding);
public static PopupRoot WindowManagerAddShadowHint(this PopupRoot control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PopupRoot.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PopupRoot WindowManagerAddShadowHint(this PopupRoot control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PopupRoot.WindowManagerAddShadowHintProperty, func, onChanged, expression);
public static PopupRoot WindowManagerAddShadowHint(this PopupRoot control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PopupRoot.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);
public static PopupRoot WindowManagerAddShadowHint<TValue>(this PopupRoot control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PopupRoot.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


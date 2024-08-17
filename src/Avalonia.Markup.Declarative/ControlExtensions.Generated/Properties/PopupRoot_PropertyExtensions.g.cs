#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using PopupRoot = Avalonia.Controls.Primitives.PopupRoot;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PopupRootExtensions
{
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, IBinding binding)
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, binding);
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, Func<Avalonia.Media.Transform> func, Action<Avalonia.Media.Transform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, func, onChanged, expression);
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, Avalonia.Media.Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Primitives.PopupRoot Transform<TValue>(this Avalonia.Controls.Primitives.PopupRoot control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, IBinding binding)
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, binding);
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, func, onChanged, expression);
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint<TValue>(this Avalonia.Controls.Primitives.PopupRoot control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


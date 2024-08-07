#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ViewboxExtensions
{
public static Viewbox Stretch(this Viewbox control, IBinding binding)
   => control._set(Viewbox.StretchProperty, binding);
public static Viewbox Stretch(this Viewbox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Viewbox.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Viewbox Stretch(this Viewbox control, Func<Stretch> func, Action<Stretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Viewbox.StretchProperty, func, onChanged, expression);
public static Viewbox Stretch(this Viewbox control, Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static Viewbox Stretch<TValue>(this Viewbox control, TValue value, FuncValueConverter<TValue, Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Viewbox StretchDirection(this Viewbox control, IBinding binding)
   => control._set(Viewbox.StretchDirectionProperty, binding);
public static Viewbox StretchDirection(this Viewbox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Viewbox.StretchDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Viewbox StretchDirection(this Viewbox control, Func<StretchDirection> func, Action<StretchDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Viewbox.StretchDirectionProperty, func, onChanged, expression);
public static Viewbox StretchDirection(this Viewbox control, StretchDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.StretchDirectionProperty, ps, () => control.StretchDirection = value, bindingMode, converter, bindingSource);
public static Viewbox StretchDirection<TValue>(this Viewbox control, TValue value, FuncValueConverter<TValue, StretchDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.StretchDirectionProperty, ps, () => control.StretchDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Viewbox Child(this Viewbox control, IBinding binding)
   => control._set(Viewbox.ChildProperty, binding);
public static Viewbox Child(this Viewbox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Viewbox.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Viewbox Child(this Viewbox control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Viewbox.ChildProperty, func, onChanged, expression);
public static Viewbox Child(this Viewbox control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static Viewbox Child<TValue>(this Viewbox control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


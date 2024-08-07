#nullable enable
using Avalonia.Animation;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class AnimatableExtensions
{
public static Animatable Transitions(this Animatable control, IBinding binding)
   => control._set(Animatable.TransitionsProperty, binding);
public static Animatable Transitions(this Animatable control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Animatable.TransitionsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Animatable Transitions(this Animatable control, Func<Transitions> func, Action<Transitions>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Animatable.TransitionsProperty, func, onChanged, expression);
public static Animatable Transitions(this Animatable control, Transitions value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Animatable.TransitionsProperty, ps, () => control.Transitions = value, bindingMode, converter, bindingSource);
public static Animatable Transitions<TValue>(this Animatable control, TValue value, FuncValueConverter<TValue, Transitions> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Animatable.TransitionsProperty, ps, () => control.Transitions = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


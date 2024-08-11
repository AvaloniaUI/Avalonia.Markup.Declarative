#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InlineUIContainerExtensions
{
public static T Child<T>(this T control, IBinding binding) where T : InlineUIContainer
   => control._set(InlineUIContainer.ChildProperty, binding);
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : InlineUIContainer
   => control._set(InlineUIContainer.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Child<T>(this T control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : InlineUIContainer
   => control._set(InlineUIContainer.ChildProperty, func, onChanged, expression);
public static T Child<T>(this T control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InlineUIContainer
=> control._setEx(InlineUIContainer.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static T Child<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InlineUIContainer
=> control._setEx(InlineUIContainer.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


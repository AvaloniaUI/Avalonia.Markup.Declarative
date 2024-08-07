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
public static InlineUIContainer Child(this InlineUIContainer control, IBinding binding)
   => control._set(InlineUIContainer.ChildProperty, binding);
public static InlineUIContainer Child(this InlineUIContainer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(InlineUIContainer.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static InlineUIContainer Child(this InlineUIContainer control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(InlineUIContainer.ChildProperty, func, onChanged, expression);
public static InlineUIContainer Child(this InlineUIContainer control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(InlineUIContainer.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static InlineUIContainer Child<TValue>(this InlineUIContainer control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(InlineUIContainer.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


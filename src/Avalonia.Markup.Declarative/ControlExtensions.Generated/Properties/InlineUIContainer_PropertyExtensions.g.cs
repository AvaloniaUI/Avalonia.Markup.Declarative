#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using InlineUIContainer = Avalonia.Controls.Documents.InlineUIContainer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InlineUIContainerExtensions
{
public static T Child<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.InlineUIContainer
   => control._set(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, binding);
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.InlineUIContainer
   => control._set(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.InlineUIContainer
   => control._set(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, func, onChanged, expression);
public static T Child<T>(this T control, Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.InlineUIContainer
=> control._setEx(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static T Child<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.InlineUIContainer
=> control._setEx(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


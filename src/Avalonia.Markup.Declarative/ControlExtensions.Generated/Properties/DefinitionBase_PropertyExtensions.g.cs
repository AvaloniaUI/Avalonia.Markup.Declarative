#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DefinitionBaseExtensions
{
public static T SharedSizeGroup<T>(this T control, IBinding binding) where T : DefinitionBase
   => control._set(DefinitionBase.SharedSizeGroupProperty, binding);
public static T SharedSizeGroup<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DefinitionBase
   => control._set(DefinitionBase.SharedSizeGroupProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SharedSizeGroup<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DefinitionBase
   => control._set(DefinitionBase.SharedSizeGroupProperty, func, onChanged, expression);
public static T SharedSizeGroup<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DefinitionBase
=> control._setEx(DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = value, bindingMode, converter, bindingSource);
public static T SharedSizeGroup<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DefinitionBase
=> control._setEx(DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


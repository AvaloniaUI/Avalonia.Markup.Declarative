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
public static DefinitionBase SharedSizeGroup(this DefinitionBase control, IBinding binding)
   => control._set(DefinitionBase.SharedSizeGroupProperty, binding);
public static DefinitionBase SharedSizeGroup(this DefinitionBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DefinitionBase.SharedSizeGroupProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DefinitionBase SharedSizeGroup(this DefinitionBase control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DefinitionBase.SharedSizeGroupProperty, func, onChanged, expression);
public static DefinitionBase SharedSizeGroup(this DefinitionBase control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = value, bindingMode, converter, bindingSource);
public static DefinitionBase SharedSizeGroup<TValue>(this DefinitionBase control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


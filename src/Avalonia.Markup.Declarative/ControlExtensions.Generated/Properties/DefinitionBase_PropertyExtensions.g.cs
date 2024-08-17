#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DefinitionBase = Avalonia.Controls.DefinitionBase;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DefinitionBaseExtensions
{
public static T SharedSizeGroup<T>(this T control, IBinding binding) where T : Avalonia.Controls.DefinitionBase
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, binding);
public static T SharedSizeGroup<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DefinitionBase
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SharedSizeGroup<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DefinitionBase
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, func, onChanged, expression);
public static T SharedSizeGroup<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DefinitionBase
=> control._setEx(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = value, bindingMode, converter, bindingSource);
public static T SharedSizeGroup<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DefinitionBase
=> control._setEx(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


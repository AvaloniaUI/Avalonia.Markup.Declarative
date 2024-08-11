#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DataValidationErrorsExtensions
{
public static T ErrorTemplate<T>(this T control, IBinding binding) where T : DataValidationErrors
   => control._set(DataValidationErrors.ErrorTemplateProperty, binding);
public static T ErrorTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DataValidationErrors
   => control._set(DataValidationErrors.ErrorTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ErrorTemplate<T>(this T control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DataValidationErrors
   => control._set(DataValidationErrors.ErrorTemplateProperty, func, onChanged, expression);
public static T ErrorTemplate<T>(this T control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DataValidationErrors
=> control._setEx(DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = value, bindingMode, converter, bindingSource);
public static T ErrorTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DataValidationErrors
=> control._setEx(DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Owner<T>(this T control, IBinding binding) where T : DataValidationErrors
   => control._set(DataValidationErrors.OwnerProperty, binding);
public static T Owner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DataValidationErrors
   => control._set(DataValidationErrors.OwnerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Owner<T>(this T control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DataValidationErrors
   => control._set(DataValidationErrors.OwnerProperty, func, onChanged, expression);
public static T Owner<T>(this T control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DataValidationErrors
=> control._setEx(DataValidationErrors.OwnerProperty, ps, () => control.Owner = value, bindingMode, converter, bindingSource);
public static T Owner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DataValidationErrors
=> control._setEx(DataValidationErrors.OwnerProperty, ps, () => control.Owner = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


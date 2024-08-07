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
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, IBinding binding)
   => control._set(DataValidationErrors.ErrorTemplateProperty, binding);
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DataValidationErrors.ErrorTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DataValidationErrors.ErrorTemplateProperty, func, onChanged, expression);
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = value, bindingMode, converter, bindingSource);
public static DataValidationErrors ErrorTemplate<TValue>(this DataValidationErrors control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DataValidationErrors Owner(this DataValidationErrors control, IBinding binding)
   => control._set(DataValidationErrors.OwnerProperty, binding);
public static DataValidationErrors Owner(this DataValidationErrors control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DataValidationErrors.OwnerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DataValidationErrors Owner(this DataValidationErrors control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DataValidationErrors.OwnerProperty, func, onChanged, expression);
public static DataValidationErrors Owner(this DataValidationErrors control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DataValidationErrors.OwnerProperty, ps, () => control.Owner = value, bindingMode, converter, bindingSource);
public static DataValidationErrors Owner<TValue>(this DataValidationErrors control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DataValidationErrors.OwnerProperty, ps, () => control.Owner = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarItemExtensions
{
public static CalendarItem HeaderBackground(this CalendarItem control, IBinding binding)
   => control._set(CalendarItem.HeaderBackgroundProperty, binding);
public static CalendarItem HeaderBackground(this CalendarItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarItem.HeaderBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarItem HeaderBackground(this CalendarItem control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarItem.HeaderBackgroundProperty, func, onChanged, expression);
public static CalendarItem HeaderBackground(this CalendarItem control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarItem.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value, bindingMode, converter, bindingSource);
public static CalendarItem HeaderBackground<TValue>(this CalendarItem control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarItem.HeaderBackgroundProperty, ps, () => control.HeaderBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarItem DayTitleTemplate(this CalendarItem control, IBinding binding)
   => control._set(CalendarItem.DayTitleTemplateProperty, binding);
public static CalendarItem DayTitleTemplate(this CalendarItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CalendarItem.DayTitleTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CalendarItem DayTitleTemplate(this CalendarItem control, Func<ITemplate<Control>> func, Action<ITemplate<Control>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarItem.DayTitleTemplateProperty, func, onChanged, expression);
public static CalendarItem DayTitleTemplate(this CalendarItem control, ITemplate<Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarItem.DayTitleTemplateProperty, ps, () => control.DayTitleTemplate = value, bindingMode, converter, bindingSource);
public static CalendarItem DayTitleTemplate<TValue>(this CalendarItem control, TValue value, FuncValueConverter<TValue, ITemplate<Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarItem.DayTitleTemplateProperty, ps, () => control.DayTitleTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


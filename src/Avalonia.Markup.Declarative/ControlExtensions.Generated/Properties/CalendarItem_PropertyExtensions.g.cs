#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using CalendarItem = Avalonia.Controls.Primitives.CalendarItem;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CalendarItemExtensions
{
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, IBinding binding)
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, binding);
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, func, onChanged, expression);
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground<TValue>(this Avalonia.Controls.Primitives.CalendarItem control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, ps, () => control.HeaderBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, IBinding binding)
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, binding);
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, func, onChanged, expression);
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, ps, () => control.DayTitleTemplate = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate<TValue>(this Avalonia.Controls.Primitives.CalendarItem control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, ps, () => control.DayTitleTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


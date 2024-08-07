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
public static Style<CalendarItem> HeaderBackground(this Style<CalendarItem> style, IBrush value)
=> style._addSetter(CalendarItem.HeaderBackgroundProperty, value);
public static Style<CalendarItem> HeaderBackground(this Style<CalendarItem> style, IBinding binding)
=> style._addSetter(CalendarItem.HeaderBackgroundProperty, binding);
public static Style<CalendarItem> DayTitleTemplate(this Style<CalendarItem> style, ITemplate<Control> value)
=> style._addSetter(CalendarItem.DayTitleTemplateProperty, value);
public static Style<CalendarItem> DayTitleTemplate(this Style<CalendarItem> style, IBinding binding)
=> style._addSetter(CalendarItem.DayTitleTemplateProperty, binding);
}


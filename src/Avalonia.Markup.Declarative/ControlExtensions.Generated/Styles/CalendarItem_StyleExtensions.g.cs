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
public static Style<Avalonia.Controls.Primitives.CalendarItem> HeaderBackground(this Style<Avalonia.Controls.Primitives.CalendarItem> style, Avalonia.Media.IBrush value)
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, value);
public static Style<Avalonia.Controls.Primitives.CalendarItem> HeaderBackground(this Style<Avalonia.Controls.Primitives.CalendarItem> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, binding);
public static Style<Avalonia.Controls.Primitives.CalendarItem> DayTitleTemplate(this Style<Avalonia.Controls.Primitives.CalendarItem> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value)
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, value);
public static Style<Avalonia.Controls.Primitives.CalendarItem> DayTitleTemplate(this Style<Avalonia.Controls.Primitives.CalendarItem> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, binding);
}


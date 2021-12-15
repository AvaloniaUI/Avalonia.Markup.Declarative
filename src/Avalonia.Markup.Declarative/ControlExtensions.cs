using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Styling;

namespace Avalonia.Markup.Declarative;

public static partial class ControlExtensions
{
    public static TElement Col<TElement>(this TElement control, int value)
        where TElement : Control
    {
        Grid.SetColumn(control, value);
        return control;
    }

    public static TElement Row<TElement>(this TElement control, int value)
        where TElement : Control
    {
        Grid.SetRow(control, value);
        return control;
    }
    public static TElement Cols<TElement>(this TElement control, ColumnDefinitions value)
        where TElement : Grid
    {
        control.ColumnDefinitions = value;
        return control;
    }

    public static TElement Rows<TElement>(this TElement control, RowDefinitions value)
        where TElement : Grid
    {
        control.RowDefinitions = value;
        return control;
    }

    public static TElement Cols<TElement>(this TElement control, string value)
        where TElement : Grid
    {
        control.ColumnDefinitions = Avalonia.Controls.ColumnDefinitions.Parse(value);
        return control;
    }

    public static TElement Rows<TElement>(this TElement control, string value)
        where TElement : Grid
    {
        control.RowDefinitions = Avalonia.Controls.RowDefinitions.Parse(value);
        return control;
    }

    public static TElement ColSpan<TElement>(this TElement control, int value)
        where TElement : Control
    {
        Grid.SetColumnSpan(control, value);
        return control;
    }

    public static TElement RowSpan<TElement>(this TElement control, int value)
        where TElement : Control
    {
        Grid.SetRowSpan(control, value);
        return control;
    }
    public static TElement HorizontalScrollBarVisibility<TElement>(this TElement control, ScrollBarVisibility value)
        where TElement : Control
    {
        ScrollViewer.SetHorizontalScrollBarVisibility(control, value);
        return control;
    }

    public static TPanel Children<TPanel>(this TPanel container, params Control[] children)
        where TPanel : IPanel
    {
        foreach (var child in children)
            container.Children.Add(child);
        return container;
    }

    public static TElement With<TElement>(this TElement control, Action<TElement> process)
    {
        process(control);
        return control;
    }

    public static TElement Name<TElement>(this TElement control, string name)
        where TElement : Control
    {
        control.Name = name;
        return control;
    }
    public static TElement Styles<TElement>(this TElement control, Style style)
        where TElement : Control
    {
        control.Styles.Add(style);
        return control;
    }

    public static TElement Classes<TElement>(this TElement control, string className, [CallerLineNumber] int line = 0, [CallerMemberName] string caller = default)
        where TElement : Control
    {
        control.Classes.Add(className);
        return control;
    }
    public static StackTrace GetDeeperStackTrace(int depth) =>
        depth > 0 ? GetDeeperStackTrace(depth - 1) : new StackTrace(0, true);


    public static TElement DataTemplates<TElement>(this TElement control, IDataTemplate dataTemplate)
        where TElement : Control
    {
        control.DataTemplates.Add(dataTemplate);
        return control;
    }

    public static TElement SetProp<TElement, TValue>(this TElement control, Avalonia.AvaloniaProperty property, TValue value)
        where TElement : Control
    {
        if (value is IBinding binding)
        {
            control[!property] = binding;
        }
        else
        {
            control[property] = value;
        }
        return control;
    }

    public static TElement ToolTip<TElement, TValue>(this TElement control, TValue value)
        where TElement : Control
    {
        var prop = Avalonia.Controls.ToolTip.TipProperty;
        if (value is IBinding binding)
        {
            control[!prop] = binding;
        }
        else
        {
            control[prop] = value;
        }
        return control;
    }

    public static TElement AddItem<TElement>(this TElement menuFlyout, string text, ICommand command)
        where TElement : MenuFlyout
    {
        (menuFlyout?.Items as AvaloniaList<object>)?.Add(new MenuItem() { Header = text, Command = command });
        return menuFlyout;
    }

    public static TElement Ref<TElement>(this TElement control, out TElement field)
    {
        field = control;
        return control;
    }

}
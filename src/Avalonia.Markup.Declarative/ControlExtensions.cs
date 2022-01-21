using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Styling;

namespace Avalonia.Markup.Declarative;

public static partial class ControlExtensions
{
    public static TControl _set<TControl>(this TControl control, Action setAction)
    {
        setAction();
        return control;
    }
    
    public static TControl _setEx<TControl>(this TControl control, AvaloniaProperty destProperty, string sourcePropertyPathString, Action setAction,
                        BindingMode? bindingMode, IValueConverter converter, object bindingSource)
        where TControl : AvaloniaObject
    {
        if (sourcePropertyPathString.StartsWith("@") || bindingMode.HasValue)
        {
            var path = sourcePropertyPathString.TrimStart('@');
            var propertyName = PropertyPathHelper.GetPropertyName(path);

            var binding = propertyName == path
                ? new Binding() // if property not set, but only vm itself
                : new Binding(propertyName);

            binding.Mode = bindingMode ?? BindingMode.Default;

            if (converter != null)
                binding.Converter = converter;

            if (bindingSource != null)
                binding.Source = bindingSource;

            control.Bind(destProperty, binding);
        }
        else
        {
            setAction();
        }

        return control;
    }

    public static TElement DataContext<TElement>(
        this TElement control,
        object value,
        BindingMode? bindingMode = null,
        IValueConverter converter = null,
        [CallerArgumentExpression("value")] string ps = null)
        where TElement : StyledElement
    {
        return control._setEx(StyledElement.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, null);
    }
    public static TElement DataContext<TElement, TDataContext>(
        this TElement control,
        TDataContext value,
        out TDataContext dataContext,
        BindingMode? bindingMode = null,
        IValueConverter converter = null,
        [CallerArgumentExpression("value")] string ps = null)
        where TElement : StyledElement where TDataContext : class
    {
        dataContext = value;
        return control._setEx(StyledElement.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, null);
    }

    public static Brush ToBrush(this Color color) => new SolidColorBrush(color);

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
        control.ColumnDefinitions = ColumnDefinitions.Parse(value);
        return control;
    }

    public static TElement Rows<TElement>(this TElement control, string value)
        where TElement : Grid
    {
        control.RowDefinitions = RowDefinitions.Parse(value);
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

    public static TElement AddItem<TElement>(this TElement menuFlyout, MenuItem menuItem)
        where TElement : MenuFlyout
    {
        (menuFlyout?.Items as AvaloniaList<object>)?.Add(menuItem);
        return menuFlyout;
    }

    public static TElement AddItem<TElement>(this TElement menuFlyout, string text, ICommand command, object commandParameter = null)
        where TElement : MenuFlyout
    {
        var item = new MenuItem() {Header = text, Command = command};
        if (commandParameter != null)
            item.CommandParameter = commandParameter;

        (menuFlyout?.Items as AvaloniaList<object>)?.Add(item);
        return menuFlyout;
    }

    /// <summary>
    /// Sets control instance reference to field so it can be accessed later in Markup
    /// </summary>
    /// <typeparam name="TElement">Control Type</typeparam>
    /// <param name="control">Control instance</param>
    /// <param name="field">field that will accept reference to control</param>
    /// <returns></returns>
    public static TElement Ref<TElement>(this TElement control, out TElement field)
    {
        field = control;
        return control;
    }

}
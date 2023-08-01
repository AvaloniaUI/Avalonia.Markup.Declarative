using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Styling;
using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;

public static class ControlPropertyExtensions
{
    public static TControl _set<TControl>(this TControl control, Action setAction)
    {
        setAction();
        return control;
    }

    /// <summary>
    /// Used to bind one avalonia property to another
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <param name="control"></param>
    /// <param name="avaloniaProperty"></param>
    /// <param name="propertyToBindTo"></param>
    /// <param name="bindingMode"></param>
    /// <param name="converter"></param>
    /// <returns></returns>
    public static TControl _set<TControl>(this TControl control, AvaloniaProperty avaloniaProperty, AvaloniaProperty propertyToBindTo, BindingMode? bindingMode, IValueConverter? converter)
    where TControl : AvaloniaObject
    {
        var view = ViewBuildContext.CurrentView;
        var binding = new Binding()
        {
            Source = view,
            Path = propertyToBindTo.Name,
            Mode = bindingMode ?? BindingMode.Default,
            Converter = converter
        };

        control[!avaloniaProperty] = binding;
        return control;
    }

    /// <summary>
    /// Used to pass Binding object constructed by end-user
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <param name="control"></param>
    /// <param name="avaloniaProperty"></param>
    /// <param name="binding"></param>
    /// <returns></returns>
    public static TControl _set<TControl>(this TControl control, AvaloniaProperty avaloniaProperty, IBinding binding)
        where TControl : AvaloniaObject
    {
        control[!avaloniaProperty] = binding;
        return control;
    }

    /// <summary>
    /// Creates binding based on expression argument
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="control"></param>
    /// <param name="avaloniaProperty"></param>
    /// <param name="func"></param>
    /// <param name="expression"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static TControl _set<TControl, TValue>(this TControl control, AvaloniaProperty avaloniaProperty, Func<TValue> func, string expression)
        where TControl : AvaloniaObject
    {
        var view = ViewBuildContext.CurrentView;

        if (view == null)
            throw new InvalidOperationException("Curent view is not set");

        var state = new ViewPropertyComputedState<TValue>(func, expression);

        if (!view.__viewComputedStates.Any(x => x.Equals(state)))
            view.__viewComputedStates.Add(state);

        var index = view.__viewComputedStates.IndexOf(state);

        var binding = new Binding
        {
            Path = "Value",
            Mode = BindingMode.OneWay,
            Source = view.__viewComputedStates[index]
        };
        control.Bind(avaloniaProperty, binding);

        return control;
    }

    /// <summary>
    /// Creates binding to property on DataContext of the control parsed from Value's expression arg , used by generated extensions
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <param name="control"></param>
    /// <param name="destProperty"></param>
    /// <param name="sourcePropertyPathString"></param>
    /// <param name="setAction"></param>
    /// <param name="bindingMode"></param>
    /// <param name="converter"></param>
    /// <param name="bindingSource"></param>
    /// <returns></returns>
    public static TControl _setEx<TControl>(this TControl control, AvaloniaProperty destProperty, string? sourcePropertyPathString, Action setAction,
                        BindingMode? bindingMode, IValueConverter? converter, object? bindingSource)
        where TControl : AvaloniaObject
    {
        if (sourcePropertyPathString == null
            || bindingMode.HasValue
            || bindingSource != default
            || sourcePropertyPathString.StartsWith("@"))
        {
            var binding = new Binding
            {
                Path = PropertyPathHelper.GetNameFromPropertyPath(sourcePropertyPathString),
                Mode = bindingMode ?? BindingMode.Default,
                Converter = converter,
                Source = bindingSource
            };

            //for components the default binding context is the component itself instead of the control's data context
            var view = ViewBuildContext.CurrentView;
            if (view is IMvuComponent component)
            {
                binding.Source ??= component;
            }

            setAction();
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
        IValueConverter? converter = null,
        [CallerArgumentExpression("value")] string? ps = null)
        where TElement : StyledElement
    {
        return control._setEx(StyledElement.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, null);
    }
    public static TElement DataContext<TElement, TDataContext>(
        this TElement control,
        TDataContext value,
        out TDataContext dataContext,
        BindingMode? bindingMode = null,
        IValueConverter? converter = null,
        [CallerArgumentExpression("value")] string? ps = null)
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

    public static TElement Top<TElement>(this TElement control, double value)
        where TElement : Control
    {
        Canvas.SetTop(control, value);
        return control;
    }

    public static TElement Left<TElement>(this TElement control, double value)
        where TElement : Control
    {
        Canvas.SetLeft(control, value);
        return control;
    }

    public static TElement Bottom<TElement>(this TElement control, double value)
        where TElement : Control
    {
        Canvas.SetBottom(control, value);
        return control;
    }

    public static TElement Right<TElement>(this TElement control, double value)
        where TElement : Control
    {
        Canvas.SetRight(control, value);
        return control;
    }

    public static TElement HorizontalScrollBarVisibility<TElement>(this TElement control, ScrollBarVisibility value)
        where TElement : Control
    {
        ScrollViewer.SetHorizontalScrollBarVisibility(control, value);
        return control;
    }
    public static TElement VerticalScrollBarVisibility<TElement>(this TElement control, ScrollBarVisibility value)
        where TElement : Control
    {
        ScrollViewer.SetVerticalScrollBarVisibility(control, value);
        return control;
    }

    public static TPanel Children<TPanel>(this TPanel container, params Control[] children)
        where TPanel : Panel
    {
        foreach (var child in children)
            container.Children.Add(child);
        return container;
    }

    public static TItemsControl Items<TItemsControl>(this TItemsControl container, params Control[] items)
        where TItemsControl : ItemsControl
    {
        if (container.Items is IList itemsCollection)
            foreach (var item in items)
                itemsCollection.Add(item);
        return container;
    }

    public static TabControl ItemTemplate<TItem>(this TabControl control, Func<TItem, Control> build) =>
        ItemTemplate<TItem, TabControl>(control, build);
    public static SelectingItemsControl ItemTemplate<TItem>(this SelectingItemsControl control, Func<TItem, Control> build) =>
        ItemTemplate<TItem, SelectingItemsControl>(control, build);

    public static ItemsControl ItemTemplate<TItem>(this ItemsControl control, Func<TItem, Control> build) =>
        ItemTemplate<TItem, ItemsControl>(control, build);

    public static TItemsControl ItemTemplate<TItem, TItemsControl>(this TItemsControl control, Func<TItem, Control> build)
        where TItemsControl : ItemsControl
    {
        control.ItemTemplate =
            new FuncDataTemplate<TItem>(
                (val, _) => build(val));
        return control;
    }

    public static TItemsControl ItemsPanel<TItemsControl>(this TItemsControl control, Panel panel)
        where TItemsControl : ItemsControl
    {
        control.ItemsPanel = new PanelTemplate(panel);
        return control;
    }

    record PanelTemplate(Panel panel) : ITemplate<Panel?>
    {
        public Panel Build() => panel;
        object ITemplate.Build() => throw new NotImplementedException();
    }

    public static TElement With<TElement>(this TElement control, Action<TElement> process)
    {
        process?.Invoke(control);
        return control;
    }

    public static TElement Name<TElement>(this TElement control, string name, INameScope? ns = null)
        where TElement : Control
    {
        ns?.Register(name, control);
        control.Name = name;
        return control;
    }

    public static TElement Styles<TElement>(this TElement control, params Style[] styles)
        where TElement : Control
    {
        foreach (var style in styles)
            control.Styles.Add(style);

        return control;
    }

    public static TElement Classes<TElement>(this TElement control, string className, [CallerLineNumber] int line = 0, [CallerMemberName] string? caller = default)
        where TElement : Control
    {
        control.Classes.Add(className);
        return control;
    }

    public static TElement BindClass<TElement>(this TElement control, bool value, string className, [CallerLineNumber] int line = 0, [CallerMemberName] string? caller = default, [CallerArgumentExpression("value")] string? ps = null)
        where TElement : Control
    {
        var path = PropertyPathHelper.GetNameFromPropertyPath(ps);
        var binding = new Binding(path, BindingMode.OneWay);
        control.BindClass(className, binding, null!);
        return control;
    }
    public static StackTrace GetDeeperStackTrace(int depth) =>
        depth > 0 ? GetDeeperStackTrace(depth - 1) : new StackTrace(0, true);


    public static TElement DataTemplates<TElement>(this TElement control, params IDataTemplate[] dataTemplate)
        where TElement : Control
    {
        foreach (var template in dataTemplate)
            control.DataTemplates.Add(template);
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

    /// <summary>
    /// Adds a menu item to the specified menu flyout.
    /// </summary>
    /// <typeparam name="TElement">The type of the menu flyout element.</typeparam>
    /// <param name="menuFlyout">The menu flyout to which the item will be added.</param>
    /// <param name="menuItem">The menu item to be added to the flyout.</param>
    /// <returns>The menu flyout with the added item.</returns>
    public static TElement? AddItem<TElement>(this TElement menuFlyout, MenuItem menuItem)
        where TElement : MenuFlyout
    {
        (menuFlyout?.Items)?.Add(menuItem);
        return menuFlyout;
    }

    /// <summary>
    /// Adds item to MenuFlyout
    /// </summary>
    /// <typeparam name="TElement">MenuFlyout type</typeparam>
    /// <param name="menuFlyout">Target MenuFlyout control</param>
    /// <param name="text">Item text</param>
    /// <param name="command">Item command</param>
    /// <param name="commandParameter">Command parameter</param>
    /// <returns></returns>
    public static TElement? AddItem<TElement>(this TElement menuFlyout, string text, ICommand command, object? commandParameter = null)
        where TElement : MenuFlyout
    {
        var item = new MenuItem() { Header = text, Command = command };
        if (commandParameter != null)
            item.CommandParameter = commandParameter;

        (menuFlyout?.Items)?.Add(item);
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
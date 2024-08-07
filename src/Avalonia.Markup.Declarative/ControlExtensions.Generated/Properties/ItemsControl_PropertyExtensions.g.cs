#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ItemsControlExtensions
{
public static T ItemContainerTheme<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(ItemsControl.ItemContainerThemeProperty, binding);
public static T ItemContainerTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ItemsControl
   => control._set(ItemsControl.ItemContainerThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemContainerTheme<T>(this T control, Func<ControlTheme> func, Action<ControlTheme>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsControl
   => control._set(ItemsControl.ItemContainerThemeProperty, func, onChanged, expression);
public static T ItemContainerTheme<T>(this T control, ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = value, bindingMode, converter, bindingSource);
public static T ItemContainerTheme<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemsPanel<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(ItemsControl.ItemsPanelProperty, binding);
public static T ItemsPanel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ItemsControl
   => control._set(ItemsControl.ItemsPanelProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemsPanel<T>(this T control, Func<ITemplate<Panel>> func, Action<ITemplate<Panel>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsControl
   => control._set(ItemsControl.ItemsPanelProperty, func, onChanged, expression);
public static T ItemsPanel<T>(this T control, ITemplate<Panel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemsPanelProperty, ps, () => control.ItemsPanel = value, bindingMode, converter, bindingSource);
public static T ItemsPanel<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITemplate<Panel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemsPanelProperty, ps, () => control.ItemsPanel = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemsSource<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(ItemsControl.ItemsSourceProperty, binding);
public static T ItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ItemsControl
   => control._set(ItemsControl.ItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemsSource<T>(this T control, Func<IEnumerable> func, Action<IEnumerable>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsControl
   => control._set(ItemsControl.ItemsSourceProperty, func, onChanged, expression);
public static T ItemsSource<T>(this T control, IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemsSourceProperty, ps, () => control.ItemsSource = value, bindingMode, converter, bindingSource);
public static T ItemsSource<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemTemplate<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(ItemsControl.ItemTemplateProperty, binding);
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ItemsControl
   => control._set(ItemsControl.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemTemplate<T>(this T control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsControl
   => control._set(ItemsControl.ItemTemplateProperty, func, onChanged, expression);
public static T ItemTemplate<T>(this T control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemTemplateProperty, ps, () => control.ItemTemplate = value, bindingMode, converter, bindingSource);
public static T ItemTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayMemberBinding<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(ItemsControl.DisplayMemberBindingProperty, binding);
public static T DisplayMemberBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ItemsControl
   => control._set(ItemsControl.DisplayMemberBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayMemberBinding<T>(this T control, Func<IBinding> func, Action<IBinding>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsControl
   => control._set(ItemsControl.DisplayMemberBindingProperty, func, onChanged, expression);
public static T DisplayMemberBinding<T>(this T control, IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.DisplayMemberBindingProperty, ps, () => control.DisplayMemberBinding = value, bindingMode, converter, bindingSource);
public static T DisplayMemberBinding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.DisplayMemberBindingProperty, ps, () => control.DisplayMemberBinding = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using ItemsControl = Avalonia.Controls.ItemsControl;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ItemsControlExtensions
{
public static T ItemContainerTheme<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, binding);
public static T ItemContainerTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemContainerTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, func, onChanged, expression);
public static T ItemContainerTheme<T>(this T control, Avalonia.Styling.ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ItemsControl
=> control._setEx(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = value, bindingMode, converter, bindingSource);
public static T ItemContainerTheme<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ItemsControl
=> control._setEx(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemsPanel<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty, binding);
public static T ItemsPanel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty, func, onChanged, expression);
public static T ItemsPanel<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ItemsControl
=> control._setEx(Avalonia.Controls.ItemsControl.ItemsPanelProperty, ps, () => control.ItemsPanel = value, bindingMode, converter, bindingSource);
public static T ItemsPanel<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ItemsControl
=> control._setEx(Avalonia.Controls.ItemsControl.ItemsPanelProperty, ps, () => control.ItemsPanel = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemsSource<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty, binding);
public static T ItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable> func, Action<System.Collections.IEnumerable>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty, func, onChanged, expression);
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ItemsControl
=> control._setEx(Avalonia.Controls.ItemsControl.ItemsSourceProperty, ps, () => control.ItemsSource = value, bindingMode, converter, bindingSource);
public static T ItemsSource<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ItemsControl
=> control._setEx(Avalonia.Controls.ItemsControl.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty, binding);
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty, func, onChanged, expression);
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ItemsControl
=> control._setEx(Avalonia.Controls.ItemsControl.ItemTemplateProperty, ps, () => control.ItemTemplate = value, bindingMode, converter, bindingSource);
public static T ItemTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ItemsControl
=> control._setEx(Avalonia.Controls.ItemsControl.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayMemberBinding<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, binding);
public static T DisplayMemberBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayMemberBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ItemsControl
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, func, onChanged, expression);
public static T DisplayMemberBinding<T>(this T control, Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ItemsControl
=> control._setEx(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, ps, () => control.DisplayMemberBinding = value, bindingMode, converter, bindingSource);
public static T DisplayMemberBinding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ItemsControl
=> control._setEx(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, ps, () => control.DisplayMemberBinding = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


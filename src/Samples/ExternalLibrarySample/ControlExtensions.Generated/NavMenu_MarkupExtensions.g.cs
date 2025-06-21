#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class NavMenu_MarkupExtensions
{
//================= Properties ======================//
 // SelectedItem

/*ValueSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.SelectedItem = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.SelectedItemProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedItem<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.SelectedItemProperty, ps, () => control.SelectedItem = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedItem<T>(this T control, IBinding binding) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.SelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedItem<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IconBinding

/*ValueSetterGenerator*/
public static T IconBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.IconBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T IconBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.IconBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IconBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.IconBindingProperty, ps, () => control.IconBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.IconBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IconBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.IconBindingProperty, ps, () => control.IconBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HeaderBinding

/*ValueSetterGenerator*/
public static T HeaderBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.HeaderBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T HeaderBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.HeaderBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HeaderBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.HeaderBindingProperty, ps, () => control.HeaderBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HeaderBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.HeaderBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HeaderBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.HeaderBindingProperty, ps, () => control.HeaderBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SubMenuBinding

/*ValueSetterGenerator*/
public static T SubMenuBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.SubMenuBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T SubMenuBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.SubMenuBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SubMenuBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.SubMenuBindingProperty, ps, () => control.SubMenuBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SubMenuBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.SubMenuBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SubMenuBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.SubMenuBindingProperty, ps, () => control.SubMenuBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CommandBinding

/*ValueSetterGenerator*/
public static T CommandBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.CommandBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T CommandBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.CommandBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CommandBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.CommandBindingProperty, ps, () => control.CommandBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.CommandBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CommandBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.CommandBindingProperty, ps, () => control.CommandBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HeaderTemplate

/*ValueSetterGenerator*/
public static T HeaderTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.HeaderTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T HeaderTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.HeaderTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HeaderTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HeaderTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.HeaderTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HeaderTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.HeaderTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HeaderTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.HeaderTemplateProperty, ps, () => control.HeaderTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IconTemplate

/*ValueSetterGenerator*/
public static T IconTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.IconTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T IconTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.IconTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IconTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.IconTemplateProperty, ps, () => control.IconTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IconTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.IconTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.IconTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IconTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.IconTemplateProperty, ps, () => control.IconTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SubMenuIndent

/*ValueSetterGenerator*/
public static T SubMenuIndent<T>(this T control, System.Double value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.SubMenuIndent = value!);

/*BindFromExpressionSetterGenerator*/
public static T SubMenuIndent<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.SubMenuIndentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SubMenuIndent<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.SubMenuIndentProperty, ps, () => control.SubMenuIndent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SubMenuIndent<T>(this T control, IBinding binding) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.SubMenuIndentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SubMenuIndent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.SubMenuIndentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SubMenuIndent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.SubMenuIndentProperty, ps, () => control.SubMenuIndent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsHorizontalCollapsed

/*ValueSetterGenerator*/
public static T IsHorizontalCollapsed<T>(this T control, System.Boolean value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.IsHorizontalCollapsed = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsHorizontalCollapsed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.IsHorizontalCollapsedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsHorizontalCollapsed<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.IsHorizontalCollapsedProperty, ps, () => control.IsHorizontalCollapsed = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsHorizontalCollapsed<T>(this T control, IBinding binding) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.IsHorizontalCollapsedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsHorizontalCollapsed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.IsHorizontalCollapsedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsHorizontalCollapsed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.IsHorizontalCollapsedProperty, ps, () => control.IsHorizontalCollapsed = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Header

/*ValueSetterGenerator*/
public static T Header<T>(this T control, System.Object value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.Header = value!);

/*BindFromExpressionSetterGenerator*/
public static T Header<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.HeaderProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Header<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.HeaderProperty, ps, () => control.Header = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Header<T>(this T control, IBinding binding) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.HeaderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Header<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.HeaderProperty, ps, () => control.Header = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Footer

/*ValueSetterGenerator*/
public static T Footer<T>(this T control, System.Object value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.Footer = value!);

/*BindFromExpressionSetterGenerator*/
public static T Footer<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.FooterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Footer<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.FooterProperty, ps, () => control.Footer = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Footer<T>(this T control, IBinding binding) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.FooterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Footer<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.FooterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Footer<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.FooterProperty, ps, () => control.Footer = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ExpandWidth

/*ValueSetterGenerator*/
public static T ExpandWidth<T>(this T control, System.Double value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.ExpandWidth = value!);

/*BindFromExpressionSetterGenerator*/
public static T ExpandWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.ExpandWidthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ExpandWidth<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.ExpandWidthProperty, ps, () => control.ExpandWidth = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ExpandWidth<T>(this T control, IBinding binding) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.ExpandWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ExpandWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.ExpandWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ExpandWidth<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.ExpandWidthProperty, ps, () => control.ExpandWidth = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CollapseWidth

/*ValueSetterGenerator*/
public static T CollapseWidth<T>(this T control, System.Double value) where T : Ursa.Controls.NavMenu 
=> control._set(() => control.CollapseWidth = value!);

/*BindFromExpressionSetterGenerator*/
public static T CollapseWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.CollapseWidthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CollapseWidth<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.CollapseWidthProperty, ps, () => control.CollapseWidth = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CollapseWidth<T>(this T control, IBinding binding) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.CollapseWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CollapseWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.NavMenu 
   => control._set(Ursa.Controls.NavMenu.CollapseWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CollapseWidth<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.NavMenu 
=> control._setEx(Ursa.Controls.NavMenu.CollapseWidthProperty, ps, () => control.CollapseWidth = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // CanToggle

/*AttachedPropertyMagicalSetterGenerator*/
public static T NavMenu_CanToggle<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement
 => control._setEx(Ursa.Controls.NavMenu.CanToggleProperty, ps, () => Ursa.Controls.NavMenu.SetCanToggle(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T NavMenu_CanToggle<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Ursa.Controls.NavMenu.CanToggleProperty!, func, onChanged, expression);



//================= Events ======================//
 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.NavMenu 
{
  control.AddHandler(Ursa.Controls.NavMenu.SelectionChangedEvent, (_, args) => action(args), routes ?? Ursa.Controls.NavMenu.SelectionChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // SelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedItem<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.SelectedItemProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedItem<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.SelectedItemProperty, binding);


 // IconBinding

/*ValueStyleSetterGenerator*/
public static Style<T> IconBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.IconBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped IconBinding because already exist in value setters


 // HeaderBinding

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.HeaderBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped HeaderBinding because already exist in value setters


 // SubMenuBinding

/*ValueStyleSetterGenerator*/
public static Style<T> SubMenuBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.SubMenuBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped SubMenuBinding because already exist in value setters


 // CommandBinding

/*ValueStyleSetterGenerator*/
public static Style<T> CommandBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.CommandBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped CommandBinding because already exist in value setters


 // HeaderTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.HeaderTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HeaderTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.HeaderTemplateProperty, binding);


 // IconTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.IconTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.IconTemplateProperty, binding);


 // SubMenuIndent

/*ValueStyleSetterGenerator*/
public static Style<T> SubMenuIndent<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.SubMenuIndentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SubMenuIndent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.SubMenuIndentProperty, binding);


 // IsHorizontalCollapsed

/*ValueStyleSetterGenerator*/
public static Style<T> IsHorizontalCollapsed<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.IsHorizontalCollapsedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsHorizontalCollapsed<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.IsHorizontalCollapsedProperty, binding);


 // Header

/*ValueStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.HeaderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.HeaderProperty, binding);


 // Footer

/*ValueStyleSetterGenerator*/
public static Style<T> Footer<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.FooterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Footer<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.FooterProperty, binding);


 // ExpandWidth

/*ValueStyleSetterGenerator*/
public static Style<T> ExpandWidth<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.ExpandWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExpandWidth<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.ExpandWidthProperty, binding);


 // CollapseWidth

/*ValueStyleSetterGenerator*/
public static Style<T> CollapseWidth<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.CollapseWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CollapseWidth<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.NavMenu 
=> style._addSetter(Ursa.Controls.NavMenu.CollapseWidthProperty, binding);



}

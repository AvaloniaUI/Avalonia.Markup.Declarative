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
public static partial class ThemeVariantScope_MarkupExtensions
{
//================= Properties ======================//
 // RequestedThemeVariant

/*ValueSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.ThemeVariantScope 
=> control._set(() => control.RequestedThemeVariant = value!);

/*BindFromExpressionSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func, Action<Avalonia.Styling.ThemeVariant>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T RequestedThemeVariant<T>(this T control,Avalonia.Styling.ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ThemeVariantScope 
=> control._setEx(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T RequestedThemeVariant<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ThemeVariantScope 
=> control._setEx(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // RequestedThemeVariant

/*ValueStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.ThemeVariantScope 
=> style._addSetter(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ThemeVariantScope 
=> style._addSetter(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, binding);



}

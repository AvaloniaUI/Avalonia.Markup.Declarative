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
public static partial class ColorPaletteResources_MarkupExtensions
{
//================= Properties ======================//
 // Accent

/*ValueSetterGenerator*/
public static T Accent<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Themes.Fluent.ColorPaletteResources 
=> control._set(() => control.Accent = value!);

/*BindFromExpressionSetterGenerator*/
public static T Accent<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources 
   => control._set(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Accent<T>(this T control,Avalonia.Media.Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources 
=> control._setEx(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, ps, () => control.Accent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Accent<T>(this T control, IBinding binding) where T : Avalonia.Themes.Fluent.ColorPaletteResources 
   => control._set(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Accent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources 
   => control._set(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Accent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources 
=> control._setEx(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, ps, () => control.Accent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}

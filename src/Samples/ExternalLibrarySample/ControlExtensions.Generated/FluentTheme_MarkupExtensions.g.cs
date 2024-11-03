#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class FluentTheme_MarkupExtensions
{
//================= Properties ======================//
 // DensityStyleProperty

/*BindFromExpressionSetterGenerator*/
public static T DensityStyle<T>(this T control, Func<Avalonia.Themes.Fluent.DensityStyle> func, Action<Avalonia.Themes.Fluent.DensityStyle>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Themes.Fluent.FluentTheme
   => control._set(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DensityStyle<T>(this T control, Avalonia.Themes.Fluent.DensityStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Themes.Fluent.FluentTheme
=> control._setEx(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty, ps, () => control.DensityStyle = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DensityStyle<T>(this T control, IBinding binding) where T : Avalonia.Themes.Fluent.FluentTheme
   => control._set(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DensityStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Themes.Fluent.FluentTheme
   => control._set(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DensityStyle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Themes.Fluent.DensityStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Themes.Fluent.FluentTheme
=> control._setEx(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty, ps, () => control.DensityStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//

}

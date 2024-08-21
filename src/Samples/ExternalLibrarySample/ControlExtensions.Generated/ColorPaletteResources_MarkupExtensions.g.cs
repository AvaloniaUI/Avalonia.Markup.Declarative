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
public static partial class ColorPaletteResources_MarkupExtensions
{
//================= Properties ======================//
 // AccentProperty

/*BindFromExpressionSetterGenerator*/
public static T Accent<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources
   => control._set(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Accent<T>(this T control, Avalonia.Media.Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources
=> control._setEx(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, ps, () => control.Accent = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Accent<T>(this T control, IBinding binding) where T : Avalonia.Themes.Fluent.ColorPaletteResources
   => control._set(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Accent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources
   => control._set(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Accent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Themes.Fluent.ColorPaletteResources
=> control._setEx(Avalonia.Themes.Fluent.ColorPaletteResources.AccentProperty, ps, () => control.Accent = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//

}

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
public static partial class RefreshVisualizer_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Controls.RefreshVisualizerOrientation> func, Action<Avalonia.Controls.RefreshVisualizerOrientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(Avalonia.Controls.RefreshVisualizer.OrientationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Orientation<T>(this T control,Avalonia.Controls.RefreshVisualizerOrientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RefreshVisualizer 
=> control._setEx(Avalonia.Controls.RefreshVisualizer.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(Avalonia.Controls.RefreshVisualizer.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(Avalonia.Controls.RefreshVisualizer.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Orientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.RefreshVisualizerOrientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RefreshVisualizer 
=> control._setEx(Avalonia.Controls.RefreshVisualizer.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // RefreshRequested

/*ActionToEventGenerator*/
    public static T OnRefreshRequested<T>(this T control, Action<Avalonia.Controls.RefreshRequestedEventArgs> action) where T : Avalonia.Controls.RefreshVisualizer => 
        control._setEvent((System.EventHandler<Avalonia.Controls.RefreshRequestedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.RefreshRequested += h);



}

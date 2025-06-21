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
public static partial class TimeBox_MarkupExtensions
{
//================= Properties ======================//
 // Time

/*ValueSetterGenerator*/
public static T Time<T>(this T control, System.Nullable<System.TimeSpan> value) where T : Ursa.Controls.TimeBox 
=> control._set(() => control.Time = value!);

/*BindFromExpressionSetterGenerator*/
public static T Time<T>(this T control, Func<System.Nullable<System.TimeSpan>> func, Action<System.Nullable<System.TimeSpan>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.TimeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Time<T>(this T control,System.Nullable<System.TimeSpan> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.TimeProperty, ps, () => control.Time = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Time<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.TimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Time<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.TimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Time<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.TimeSpan>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.TimeProperty, ps, () => control.Time = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Ursa.Controls.TimeBox 
=> control._set(() => control.TextAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.TextAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TextAlignment<T>(this T control,Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.TextAlignmentProperty, ps, () => control.TextAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextAlignment<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.TextAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TextAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectionBrush

/*ValueSetterGenerator*/
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Controls.TimeBox 
=> control._set(() => control.SelectionBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.SelectionBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.SelectionBrushProperty, ps, () => control.SelectionBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionBrush<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.SelectionBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectionForegroundBrush

/*ValueSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Controls.TimeBox 
=> control._set(() => control.SelectionForegroundBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.SelectionForegroundBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionForegroundBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.SelectionForegroundBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionForegroundBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CaretBrush

/*ValueSetterGenerator*/
public static T CaretBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Controls.TimeBox 
=> control._set(() => control.CaretBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T CaretBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.CaretBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CaretBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.CaretBrushProperty, ps, () => control.CaretBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretBrush<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.CaretBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.CaretBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CaretBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowLeadingZero

/*ValueSetterGenerator*/
public static T ShowLeadingZero<T>(this T control, System.Boolean value) where T : Ursa.Controls.TimeBox 
=> control._set(() => control.ShowLeadingZero = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowLeadingZero<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.ShowLeadingZeroProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowLeadingZero<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.ShowLeadingZeroProperty, ps, () => control.ShowLeadingZero = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowLeadingZero<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.ShowLeadingZeroProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowLeadingZero<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.ShowLeadingZeroProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowLeadingZero<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.ShowLeadingZeroProperty, ps, () => control.ShowLeadingZero = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InputMode

/*ValueSetterGenerator*/
public static T InputMode<T>(this T control, Ursa.Controls.TimeBoxInputMode value) where T : Ursa.Controls.TimeBox 
=> control._set(() => control.InputMode = value!);

/*BindFromExpressionSetterGenerator*/
public static T InputMode<T>(this T control, Func<Ursa.Controls.TimeBoxInputMode> func, Action<Ursa.Controls.TimeBoxInputMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.InputModeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InputMode<T>(this T control,Ursa.Controls.TimeBoxInputMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.InputModeProperty, ps, () => control.InputMode = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InputMode<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.InputModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InputMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.InputModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InputMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.TimeBoxInputMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.InputModeProperty, ps, () => control.InputMode = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AllowDrag

/*ValueSetterGenerator*/
public static T AllowDrag<T>(this T control, System.Boolean value) where T : Ursa.Controls.TimeBox 
=> control._set(() => control.AllowDrag = value!);

/*BindFromExpressionSetterGenerator*/
public static T AllowDrag<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.AllowDragProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AllowDrag<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.AllowDragProperty, ps, () => control.AllowDrag = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AllowDrag<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.AllowDragProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AllowDrag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.AllowDragProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AllowDrag<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.AllowDragProperty, ps, () => control.AllowDrag = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DragOrientation

/*ValueSetterGenerator*/
public static T DragOrientation<T>(this T control, Ursa.Controls.TimeBoxDragOrientation value) where T : Ursa.Controls.TimeBox 
=> control._set(() => control.DragOrientation = value!);

/*BindFromExpressionSetterGenerator*/
public static T DragOrientation<T>(this T control, Func<Ursa.Controls.TimeBoxDragOrientation> func, Action<Ursa.Controls.TimeBoxDragOrientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.DragOrientationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DragOrientation<T>(this T control,Ursa.Controls.TimeBoxDragOrientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.DragOrientationProperty, ps, () => control.DragOrientation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DragOrientation<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.DragOrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DragOrientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.DragOrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DragOrientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.TimeBoxDragOrientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.DragOrientationProperty, ps, () => control.DragOrientation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsTimeLoop

/*ValueSetterGenerator*/
public static T IsTimeLoop<T>(this T control, System.Boolean value) where T : Ursa.Controls.TimeBox 
=> control._set(() => control.IsTimeLoop = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsTimeLoop<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.IsTimeLoopProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsTimeLoop<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.IsTimeLoopProperty, ps, () => control.IsTimeLoop = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTimeLoop<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.IsTimeLoopProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTimeLoop<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeBox 
   => control._set(Ursa.Controls.TimeBox.IsTimeLoopProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsTimeLoop<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeBox 
=> control._setEx(Ursa.Controls.TimeBox.IsTimeLoopProperty, ps, () => control.IsTimeLoop = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Time

/*ValueStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, System.Nullable<System.TimeSpan> value) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.TimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.TimeProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.TextAlignmentProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.SelectionBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.SelectionForegroundBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.SelectionForegroundBrushProperty, binding);


 // CaretBrush

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.CaretBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.CaretBrushProperty, binding);


 // ShowLeadingZero

/*ValueStyleSetterGenerator*/
public static Style<T> ShowLeadingZero<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.ShowLeadingZeroProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowLeadingZero<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.ShowLeadingZeroProperty, binding);


 // InputMode

/*ValueStyleSetterGenerator*/
public static Style<T> InputMode<T>(this Style<T> style, Ursa.Controls.TimeBoxInputMode value) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.InputModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InputMode<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.InputModeProperty, binding);


 // AllowDrag

/*ValueStyleSetterGenerator*/
public static Style<T> AllowDrag<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.AllowDragProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowDrag<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.AllowDragProperty, binding);


 // DragOrientation

/*ValueStyleSetterGenerator*/
public static Style<T> DragOrientation<T>(this Style<T> style, Ursa.Controls.TimeBoxDragOrientation value) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.DragOrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DragOrientation<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.DragOrientationProperty, binding);


 // IsTimeLoop

/*ValueStyleSetterGenerator*/
public static Style<T> IsTimeLoop<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.IsTimeLoopProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTimeLoop<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeBox 
=> style._addSetter(Ursa.Controls.TimeBox.IsTimeLoopProperty, binding);



}

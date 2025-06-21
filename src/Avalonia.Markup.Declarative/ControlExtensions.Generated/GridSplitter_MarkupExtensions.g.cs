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
public static partial class GridSplitter_MarkupExtensions
{
//================= Properties ======================//
 // ResizeDirection

/*ValueSetterGenerator*/
public static T ResizeDirection<T>(this T control, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.ResizeDirection = value!);

/*BindFromExpressionSetterGenerator*/
public static T ResizeDirection<T>(this T control, Func<Avalonia.Controls.GridResizeDirection> func, Action<Avalonia.Controls.GridResizeDirection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ResizeDirection<T>(this T control,Avalonia.Controls.GridResizeDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, ps, () => control.ResizeDirection = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ResizeDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ResizeDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ResizeDirection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.GridResizeDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, ps, () => control.ResizeDirection = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ResizeBehavior

/*ValueSetterGenerator*/
public static T ResizeBehavior<T>(this T control, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.ResizeBehavior = value!);

/*BindFromExpressionSetterGenerator*/
public static T ResizeBehavior<T>(this T control, Func<Avalonia.Controls.GridResizeBehavior> func, Action<Avalonia.Controls.GridResizeBehavior>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ResizeBehavior<T>(this T control,Avalonia.Controls.GridResizeBehavior value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, ps, () => control.ResizeBehavior = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ResizeBehavior<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ResizeBehavior<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ResizeBehavior<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.GridResizeBehavior> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, ps, () => control.ResizeBehavior = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowsPreview

/*ValueSetterGenerator*/
public static T ShowsPreview<T>(this T control, System.Boolean value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.ShowsPreview = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowsPreview<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowsPreview<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, ps, () => control.ShowsPreview = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowsPreview<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowsPreview<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowsPreview<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, ps, () => control.ShowsPreview = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // KeyboardIncrement

/*ValueSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.KeyboardIncrement = value!);

/*BindFromExpressionSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T KeyboardIncrement<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, ps, () => control.KeyboardIncrement = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T KeyboardIncrement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, ps, () => control.KeyboardIncrement = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DragIncrement

/*ValueSetterGenerator*/
public static T DragIncrement<T>(this T control, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.DragIncrement = value!);

/*BindFromExpressionSetterGenerator*/
public static T DragIncrement<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DragIncrement<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.DragIncrementProperty, ps, () => control.DragIncrement = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DragIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DragIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DragIncrement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.DragIncrementProperty, ps, () => control.DragIncrement = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PreviewContent

/*ValueSetterGenerator*/
public static T PreviewContent<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.PreviewContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T PreviewContent<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PreviewContent<T>(this T control,Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.PreviewContentProperty, ps, () => control.PreviewContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PreviewContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PreviewContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PreviewContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.GridSplitter 
=> control._setEx(Avalonia.Controls.GridSplitter.PreviewContentProperty, ps, () => control.PreviewContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // ResizeDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ResizeDirection<T>(this Style<T> style, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResizeDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, binding);


 // ResizeBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> ResizeBehavior<T>(this Style<T> style, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResizeBehavior<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, binding);


 // ShowsPreview

/*ValueStyleSetterGenerator*/
public static Style<T> ShowsPreview<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowsPreview<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, binding);


 // KeyboardIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> KeyboardIncrement<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> KeyboardIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, binding);


 // DragIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> DragIncrement<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.DragIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DragIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.DragIncrementProperty, binding);


 // PreviewContent

/*ValueStyleSetterGenerator*/
public static Style<T> PreviewContent<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.PreviewContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PreviewContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.PreviewContentProperty, binding);



}

#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
<<<<<<< HEAD
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
=======
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
>>>>>>> c1347bc81bdb20ad44b1fda7d31eecec56065f2f
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class WindowNotificationManager_MarkupExtensions
{
//================= Properties ======================//
 // Position

/*BindFromExpressionSetterGenerator*/
public static T Position<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationPosition> func, Action<Avalonia.Controls.Notifications.NotificationPosition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Position<T>(this T control,Avalonia.Controls.Notifications.NotificationPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> control._setEx(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, ps, () => control.Position = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Position<T>(this T control, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Position<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Position<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Notifications.NotificationPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> control._setEx(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, ps, () => control.Position = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxItems

/*BindFromExpressionSetterGenerator*/
public static T MaxItems<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxItems<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> control._setEx(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxItems<T>(this T control, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxItems<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> control._setEx(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Position

/*ValueStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationPosition value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, binding);


 // MaxItems

/*ValueStyleSetterGenerator*/
public static Style<T> MaxItems<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxItems<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, binding);



}

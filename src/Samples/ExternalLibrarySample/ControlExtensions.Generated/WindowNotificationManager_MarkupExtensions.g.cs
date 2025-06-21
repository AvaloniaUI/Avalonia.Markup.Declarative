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
public static partial class WindowNotificationManager_MarkupExtensions
{
//================= Properties ======================//
 // Position

/*ValueSetterGenerator*/
public static T Position<T>(this T control, Avalonia.Controls.Notifications.NotificationPosition value) where T : Ursa.Controls.WindowNotificationManager 
=> control._set(() => control.Position = value!);

/*BindFromExpressionSetterGenerator*/
public static T Position<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationPosition> func, Action<Avalonia.Controls.Notifications.NotificationPosition>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.WindowNotificationManager 
   => control._set(Ursa.Controls.WindowNotificationManager.PositionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Position<T>(this T control,Avalonia.Controls.Notifications.NotificationPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.WindowNotificationManager 
=> control._setEx(Ursa.Controls.WindowNotificationManager.PositionProperty, ps, () => control.Position = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Position<T>(this T control, IBinding binding) where T : Ursa.Controls.WindowNotificationManager 
   => control._set(Ursa.Controls.WindowNotificationManager.PositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Position<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.WindowNotificationManager 
   => control._set(Ursa.Controls.WindowNotificationManager.PositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Position<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Notifications.NotificationPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.WindowNotificationManager 
=> control._setEx(Ursa.Controls.WindowNotificationManager.PositionProperty, ps, () => control.Position = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Position

/*ValueStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationPosition value) where T : Ursa.Controls.WindowNotificationManager 
=> style._addSetter(Ursa.Controls.WindowNotificationManager.PositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.WindowNotificationManager 
=> style._addSetter(Ursa.Controls.WindowNotificationManager.PositionProperty, binding);



}

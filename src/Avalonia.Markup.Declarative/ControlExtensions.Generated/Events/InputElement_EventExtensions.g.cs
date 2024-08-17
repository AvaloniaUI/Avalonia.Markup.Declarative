using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Avalonia.Input.TextInput;
using Avalonia.Interactivity;
using InputElement = Avalonia.Input.InputElement;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InputElementEventsExtensions
{
    public static T OnGotFocus<T>(this T control, Action<Avalonia.Input.GotFocusEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.GotFocusEventArgs>) ((arg0, arg1) => action(arg1)), h => control.GotFocus += h);
    public static T OnLostFocus<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.LostFocus += h);
    public static T OnKeyDown<T>(this T control, Action<Avalonia.Input.KeyEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.KeyEventArgs>) ((arg0, arg1) => action(arg1)), h => control.KeyDown += h);
    public static T OnKeyUp<T>(this T control, Action<Avalonia.Input.KeyEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.KeyEventArgs>) ((arg0, arg1) => action(arg1)), h => control.KeyUp += h);
    public static T OnTextInput<T>(this T control, Action<Avalonia.Input.TextInputEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.TextInputEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TextInput += h);
    public static T OnTextInputMethodClientRequested<T>(this T control, Action<Avalonia.Input.TextInput.TextInputMethodClientRequestedEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.TextInput.TextInputMethodClientRequestedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TextInputMethodClientRequested += h);
    public static T OnPointerEntered<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PointerEntered += h);
    public static T OnPointerExited<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PointerExited += h);
    public static T OnPointerMoved<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PointerMoved += h);
    public static T OnPointerPressed<T>(this T control, Action<Avalonia.Input.PointerPressedEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerPressedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PointerPressed += h);
    public static T OnPointerReleased<T>(this T control, Action<Avalonia.Input.PointerReleasedEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerReleasedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PointerReleased += h);
    public static T OnPointerCaptureLost<T>(this T control, Action<Avalonia.Input.PointerCaptureLostEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerCaptureLostEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PointerCaptureLost += h);
    public static T OnPointerWheelChanged<T>(this T control, Action<Avalonia.Input.PointerWheelEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerWheelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PointerWheelChanged += h);
    public static T OnTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.TappedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Tapped += h);
    public static T OnHolding<T>(this T control, Action<Avalonia.Input.HoldingRoutedEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.HoldingRoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Holding += h);
    public static T OnDoubleTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action) where T : Avalonia.Input.InputElement => 
        control._setEvent((System.EventHandler<Avalonia.Input.TappedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DoubleTapped += h);
}


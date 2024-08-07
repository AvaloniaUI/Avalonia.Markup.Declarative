using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Avalonia.Input.TextInput;
using Avalonia.Interactivity;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InputElementEventsExtensions
{
    public static T OnGotFocus<T>(this T control, Action<GotFocusEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<GotFocusEventArgs>) ((_, args) => action(args)), h => control.GotFocus += h);
    public static T OnLostFocus<T>(this T control, Action<RoutedEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.LostFocus += h);
    public static T OnKeyDown<T>(this T control, Action<KeyEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<KeyEventArgs>) ((_, args) => action(args)), h => control.KeyDown += h);
    public static T OnKeyUp<T>(this T control, Action<KeyEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<KeyEventArgs>) ((_, args) => action(args)), h => control.KeyUp += h);
    public static T OnTextInput<T>(this T control, Action<TextInputEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<TextInputEventArgs>) ((_, args) => action(args)), h => control.TextInput += h);
    public static T OnTextInputMethodClientRequested<T>(this T control, Action<TextInputMethodClientRequestedEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<TextInputMethodClientRequestedEventArgs>) ((_, args) => action(args)), h => control.TextInputMethodClientRequested += h);
    public static T OnPointerEntered<T>(this T control, Action<PointerEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerEntered += h);
    public static T OnPointerExited<T>(this T control, Action<PointerEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerExited += h);
    public static T OnPointerMoved<T>(this T control, Action<PointerEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerMoved += h);
    public static T OnPointerPressed<T>(this T control, Action<PointerPressedEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => control.PointerPressed += h);
    public static T OnPointerReleased<T>(this T control, Action<PointerReleasedEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => control.PointerReleased += h);
    public static T OnPointerCaptureLost<T>(this T control, Action<PointerCaptureLostEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<PointerCaptureLostEventArgs>) ((_, args) => action(args)), h => control.PointerCaptureLost += h);
    public static T OnPointerWheelChanged<T>(this T control, Action<PointerWheelEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<PointerWheelEventArgs>) ((_, args) => action(args)), h => control.PointerWheelChanged += h);
    public static T OnTapped<T>(this T control, Action<TappedEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<TappedEventArgs>) ((_, args) => action(args)), h => control.Tapped += h);
    public static T OnHolding<T>(this T control, Action<HoldingRoutedEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<HoldingRoutedEventArgs>) ((_, args) => action(args)), h => control.Holding += h);
    public static T OnDoubleTapped<T>(this T control, Action<TappedEventArgs> action) where T : InputElement => 
        control._setEvent((EventHandler<TappedEventArgs>) ((_, args) => action(args)), h => control.DoubleTapped += h);
}


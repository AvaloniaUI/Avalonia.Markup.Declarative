using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using InputElement = Avalonia.Input.InputElement;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InputElementExtensions
{
public static Style<T> Focusable<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.FocusableProperty, value);
public static Style<T> Focusable<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.FocusableProperty, binding);
public static Style<T> IsEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.IsEnabledProperty, value);
public static Style<T> IsEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.IsEnabledProperty, binding);
public static Style<T> Cursor<T>(this Style<T> style, Avalonia.Input.Cursor value) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.CursorProperty, value);
public static Style<T> Cursor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.CursorProperty, binding);
public static Style<T> IsHitTestVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.IsHitTestVisibleProperty, value);
public static Style<T> IsHitTestVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.IsHitTestVisibleProperty, binding);
public static Style<T> IsTabStop<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.IsTabStopProperty, value);
public static Style<T> IsTabStop<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.IsTabStopProperty, binding);
public static Style<T> TabIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.TabIndexProperty, value);
public static Style<T> TabIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement
=> style._addSetter(Avalonia.Input.InputElement.TabIndexProperty, binding);
}


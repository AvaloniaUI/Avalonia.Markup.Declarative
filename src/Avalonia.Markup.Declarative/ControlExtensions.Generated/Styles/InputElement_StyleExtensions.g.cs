using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InputElementExtensions
{
public static Style<T> Focusable<T>(this Style<T> style, Boolean value) where T : InputElement
=> style._addSetter(InputElement.FocusableProperty, value);
public static Style<T> Focusable<T>(this Style<T> style, IBinding binding) where T : InputElement
=> style._addSetter(InputElement.FocusableProperty, binding);
public static Style<T> IsEnabled<T>(this Style<T> style, Boolean value) where T : InputElement
=> style._addSetter(InputElement.IsEnabledProperty, value);
public static Style<T> IsEnabled<T>(this Style<T> style, IBinding binding) where T : InputElement
=> style._addSetter(InputElement.IsEnabledProperty, binding);
public static Style<T> Cursor<T>(this Style<T> style, Cursor value) where T : InputElement
=> style._addSetter(InputElement.CursorProperty, value);
public static Style<T> Cursor<T>(this Style<T> style, IBinding binding) where T : InputElement
=> style._addSetter(InputElement.CursorProperty, binding);
public static Style<T> IsHitTestVisible<T>(this Style<T> style, Boolean value) where T : InputElement
=> style._addSetter(InputElement.IsHitTestVisibleProperty, value);
public static Style<T> IsHitTestVisible<T>(this Style<T> style, IBinding binding) where T : InputElement
=> style._addSetter(InputElement.IsHitTestVisibleProperty, binding);
public static Style<T> IsTabStop<T>(this Style<T> style, Boolean value) where T : InputElement
=> style._addSetter(InputElement.IsTabStopProperty, value);
public static Style<T> IsTabStop<T>(this Style<T> style, IBinding binding) where T : InputElement
=> style._addSetter(InputElement.IsTabStopProperty, binding);
public static Style<T> TabIndex<T>(this Style<T> style, Int32 value) where T : InputElement
=> style._addSetter(InputElement.TabIndexProperty, value);
public static Style<T> TabIndex<T>(this Style<T> style, IBinding binding) where T : InputElement
=> style._addSetter(InputElement.TabIndexProperty, binding);
}


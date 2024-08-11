using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Platform;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class WindowExtensions
{
public static Style<T> SizeToContent<T>(this Style<T> style, SizeToContent value) where T : Window
=> style._addSetter(Window.SizeToContentProperty, value);
public static Style<T> SizeToContent<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.SizeToContentProperty, binding);
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, Boolean value) where T : Window
=> style._addSetter(Window.ExtendClientAreaToDecorationsHintProperty, value);
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.ExtendClientAreaToDecorationsHintProperty, binding);
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, ExtendClientAreaChromeHints value) where T : Window
=> style._addSetter(Window.ExtendClientAreaChromeHintsProperty, value);
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.ExtendClientAreaChromeHintsProperty, binding);
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, Double value) where T : Window
=> style._addSetter(Window.ExtendClientAreaTitleBarHeightHintProperty, value);
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.ExtendClientAreaTitleBarHeightHintProperty, binding);
public static Style<T> SystemDecorations<T>(this Style<T> style, SystemDecorations value) where T : Window
=> style._addSetter(Window.SystemDecorationsProperty, value);
public static Style<T> SystemDecorations<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.SystemDecorationsProperty, binding);
public static Style<T> ShowActivated<T>(this Style<T> style, Boolean value) where T : Window
=> style._addSetter(Window.ShowActivatedProperty, value);
public static Style<T> ShowActivated<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.ShowActivatedProperty, binding);
public static Style<T> ShowInTaskbar<T>(this Style<T> style, Boolean value) where T : Window
=> style._addSetter(Window.ShowInTaskbarProperty, value);
public static Style<T> ShowInTaskbar<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.ShowInTaskbarProperty, binding);
public static Style<T> ClosingBehavior<T>(this Style<T> style, WindowClosingBehavior value) where T : Window
=> style._addSetter(Window.ClosingBehaviorProperty, value);
public static Style<T> ClosingBehavior<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.ClosingBehaviorProperty, binding);
public static Style<T> WindowState<T>(this Style<T> style, WindowState value) where T : Window
=> style._addSetter(Window.WindowStateProperty, value);
public static Style<T> WindowState<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.WindowStateProperty, binding);
public static Style<T> Title<T>(this Style<T> style, String value) where T : Window
=> style._addSetter(Window.TitleProperty, value);
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.TitleProperty, binding);
public static Style<T> Icon<T>(this Style<T> style, WindowIcon value) where T : Window
=> style._addSetter(Window.IconProperty, value);
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.IconProperty, binding);
public static Style<T> WindowStartupLocation<T>(this Style<T> style, WindowStartupLocation value) where T : Window
=> style._addSetter(Window.WindowStartupLocationProperty, value);
public static Style<T> WindowStartupLocation<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.WindowStartupLocationProperty, binding);
public static Style<T> CanResize<T>(this Style<T> style, Boolean value) where T : Window
=> style._addSetter(Window.CanResizeProperty, value);
public static Style<T> CanResize<T>(this Style<T> style, IBinding binding) where T : Window
=> style._addSetter(Window.CanResizeProperty, binding);
}


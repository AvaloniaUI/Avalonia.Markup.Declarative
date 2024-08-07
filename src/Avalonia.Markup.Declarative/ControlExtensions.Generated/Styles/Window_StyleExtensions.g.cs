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
public static Style<Window> SizeToContent(this Style<Window> style, SizeToContent value)
=> style._addSetter(Window.SizeToContentProperty, value);
public static Style<Window> SizeToContent(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.SizeToContentProperty, binding);
public static Style<Window> ExtendClientAreaToDecorationsHint(this Style<Window> style, Boolean value)
=> style._addSetter(Window.ExtendClientAreaToDecorationsHintProperty, value);
public static Style<Window> ExtendClientAreaToDecorationsHint(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.ExtendClientAreaToDecorationsHintProperty, binding);
public static Style<Window> ExtendClientAreaChromeHints(this Style<Window> style, ExtendClientAreaChromeHints value)
=> style._addSetter(Window.ExtendClientAreaChromeHintsProperty, value);
public static Style<Window> ExtendClientAreaChromeHints(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.ExtendClientAreaChromeHintsProperty, binding);
public static Style<Window> ExtendClientAreaTitleBarHeightHint(this Style<Window> style, Double value)
=> style._addSetter(Window.ExtendClientAreaTitleBarHeightHintProperty, value);
public static Style<Window> ExtendClientAreaTitleBarHeightHint(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.ExtendClientAreaTitleBarHeightHintProperty, binding);
public static Style<Window> SystemDecorations(this Style<Window> style, SystemDecorations value)
=> style._addSetter(Window.SystemDecorationsProperty, value);
public static Style<Window> SystemDecorations(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.SystemDecorationsProperty, binding);
public static Style<Window> ShowActivated(this Style<Window> style, Boolean value)
=> style._addSetter(Window.ShowActivatedProperty, value);
public static Style<Window> ShowActivated(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.ShowActivatedProperty, binding);
public static Style<Window> ShowInTaskbar(this Style<Window> style, Boolean value)
=> style._addSetter(Window.ShowInTaskbarProperty, value);
public static Style<Window> ShowInTaskbar(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.ShowInTaskbarProperty, binding);
public static Style<Window> ClosingBehavior(this Style<Window> style, WindowClosingBehavior value)
=> style._addSetter(Window.ClosingBehaviorProperty, value);
public static Style<Window> ClosingBehavior(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.ClosingBehaviorProperty, binding);
public static Style<Window> WindowState(this Style<Window> style, WindowState value)
=> style._addSetter(Window.WindowStateProperty, value);
public static Style<Window> WindowState(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.WindowStateProperty, binding);
public static Style<Window> Title(this Style<Window> style, String value)
=> style._addSetter(Window.TitleProperty, value);
public static Style<Window> Title(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.TitleProperty, binding);
public static Style<Window> Icon(this Style<Window> style, WindowIcon value)
=> style._addSetter(Window.IconProperty, value);
public static Style<Window> Icon(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.IconProperty, binding);
public static Style<Window> WindowStartupLocation(this Style<Window> style, WindowStartupLocation value)
=> style._addSetter(Window.WindowStartupLocationProperty, value);
public static Style<Window> WindowStartupLocation(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.WindowStartupLocationProperty, binding);
public static Style<Window> CanResize(this Style<Window> style, Boolean value)
=> style._addSetter(Window.CanResizeProperty, value);
public static Style<Window> CanResize(this Style<Window> style, IBinding binding)
=> style._addSetter(Window.CanResizeProperty, binding);
}


using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Platform;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Window = Avalonia.Controls.Window;

namespace Avalonia.Markup.Declarative;
public static partial class WindowExtensions
{
public static Style<T> SizeToContent<T>(this Style<T> style, Avalonia.Controls.SizeToContent value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.SizeToContentProperty, value);
public static Style<T> SizeToContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.SizeToContentProperty, binding);
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, value);
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, binding);
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, Avalonia.Platform.ExtendClientAreaChromeHints value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, value);
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, binding);
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, value);
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, binding);
public static Style<T> SystemDecorations<T>(this Style<T> style, Avalonia.Controls.SystemDecorations value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.SystemDecorationsProperty, value);
public static Style<T> SystemDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.SystemDecorationsProperty, binding);
public static Style<T> ShowActivated<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ShowActivatedProperty, value);
public static Style<T> ShowActivated<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ShowActivatedProperty, binding);
public static Style<T> ShowInTaskbar<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ShowInTaskbarProperty, value);
public static Style<T> ShowInTaskbar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ShowInTaskbarProperty, binding);
public static Style<T> ClosingBehavior<T>(this Style<T> style, Avalonia.Controls.WindowClosingBehavior value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ClosingBehaviorProperty, value);
public static Style<T> ClosingBehavior<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.ClosingBehaviorProperty, binding);
public static Style<T> WindowState<T>(this Style<T> style, Avalonia.Controls.WindowState value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.WindowStateProperty, value);
public static Style<T> WindowState<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.WindowStateProperty, binding);
public static Style<T> Title<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.TitleProperty, value);
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.TitleProperty, binding);
public static Style<T> Icon<T>(this Style<T> style, Avalonia.Controls.WindowIcon value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.IconProperty, value);
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.IconProperty, binding);
public static Style<T> WindowStartupLocation<T>(this Style<T> style, Avalonia.Controls.WindowStartupLocation value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.WindowStartupLocationProperty, value);
public static Style<T> WindowStartupLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.WindowStartupLocationProperty, binding);
public static Style<T> CanResize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.CanResizeProperty, value);
public static Style<T> CanResize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window
=> style._addSetter(Avalonia.Controls.Window.CanResizeProperty, binding);
}


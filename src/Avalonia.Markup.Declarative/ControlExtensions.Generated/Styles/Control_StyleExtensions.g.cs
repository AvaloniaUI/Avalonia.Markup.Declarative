using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ControlExtensions
{
public static Style<T> FocusAdorner<T>(this Style<T> style, ITemplate<Control> value) where T : Control
=> style._addSetter(Control.FocusAdornerProperty, value);
public static Style<T> FocusAdorner<T>(this Style<T> style, IBinding binding) where T : Control
=> style._addSetter(Control.FocusAdornerProperty, binding);
public static Style<T> Tag<T>(this Style<T> style, Object value) where T : Control
=> style._addSetter(Control.TagProperty, value);
public static Style<T> Tag<T>(this Style<T> style, IBinding binding) where T : Control
=> style._addSetter(Control.TagProperty, binding);
public static Style<T> ContextMenu<T>(this Style<T> style, Avalonia.Controls.ContextMenu value) where T : Control
=> style._addSetter(Control.ContextMenuProperty, value);
public static Style<T> ContextMenu<T>(this Style<T> style, IBinding binding) where T : Control
=> style._addSetter(Control.ContextMenuProperty, binding);
public static Style<T> ContextFlyout<T>(this Style<T> style, FlyoutBase value) where T : Control
=> style._addSetter(Control.ContextFlyoutProperty, value);
public static Style<T> ContextFlyout<T>(this Style<T> style, IBinding binding) where T : Control
=> style._addSetter(Control.ContextFlyoutProperty, binding);
}


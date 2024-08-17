using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Control = Avalonia.Controls.Control;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ControlExtensions
{
public static Style<T> FocusAdorner<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Control
=> style._addSetter(Avalonia.Controls.Control.FocusAdornerProperty, value);
public static Style<T> FocusAdorner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control
=> style._addSetter(Avalonia.Controls.Control.FocusAdornerProperty, binding);
public static Style<T> Tag<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Control
=> style._addSetter(Avalonia.Controls.Control.TagProperty, value);
public static Style<T> Tag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control
=> style._addSetter(Avalonia.Controls.Control.TagProperty, binding);
public static Style<T> ContextMenu<T>(this Style<T> style, Avalonia.Controls.ContextMenu value) where T : Avalonia.Controls.Control
=> style._addSetter(Avalonia.Controls.Control.ContextMenuProperty, value);
public static Style<T> ContextMenu<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control
=> style._addSetter(Avalonia.Controls.Control.ContextMenuProperty, binding);
public static Style<T> ContextFlyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Control
=> style._addSetter(Avalonia.Controls.Control.ContextFlyoutProperty, value);
public static Style<T> ContextFlyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control
=> style._addSetter(Avalonia.Controls.Control.ContextFlyoutProperty, binding);
}


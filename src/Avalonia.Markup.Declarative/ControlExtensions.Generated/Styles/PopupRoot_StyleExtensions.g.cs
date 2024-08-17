using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using PopupRoot = Avalonia.Controls.Primitives.PopupRoot;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PopupRootExtensions
{
public static Style<Avalonia.Controls.Primitives.PopupRoot> Transform(this Style<Avalonia.Controls.Primitives.PopupRoot> style, Avalonia.Media.Transform value)
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, value);
public static Style<Avalonia.Controls.Primitives.PopupRoot> Transform(this Style<Avalonia.Controls.Primitives.PopupRoot> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, binding);
public static Style<Avalonia.Controls.Primitives.PopupRoot> WindowManagerAddShadowHint(this Style<Avalonia.Controls.Primitives.PopupRoot> style, System.Boolean value)
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, value);
public static Style<Avalonia.Controls.Primitives.PopupRoot> WindowManagerAddShadowHint(this Style<Avalonia.Controls.Primitives.PopupRoot> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, binding);
}


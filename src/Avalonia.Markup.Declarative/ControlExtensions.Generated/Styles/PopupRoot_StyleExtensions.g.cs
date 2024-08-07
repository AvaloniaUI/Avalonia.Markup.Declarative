using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PopupRootExtensions
{
public static Style<PopupRoot> Transform(this Style<PopupRoot> style, Transform value)
=> style._addSetter(PopupRoot.TransformProperty, value);
public static Style<PopupRoot> Transform(this Style<PopupRoot> style, IBinding binding)
=> style._addSetter(PopupRoot.TransformProperty, binding);
public static Style<PopupRoot> WindowManagerAddShadowHint(this Style<PopupRoot> style, Boolean value)
=> style._addSetter(PopupRoot.WindowManagerAddShadowHintProperty, value);
public static Style<PopupRoot> WindowManagerAddShadowHint(this Style<PopupRoot> style, IBinding binding)
=> style._addSetter(PopupRoot.WindowManagerAddShadowHintProperty, binding);
}


using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using OverlayPopupHost = Avalonia.Controls.Primitives.OverlayPopupHost;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class OverlayPopupHostExtensions
{
public static Style<T> Transform<T>(this Style<T> style, Avalonia.Media.Transform value) where T : Avalonia.Controls.Primitives.OverlayPopupHost
=> style._addSetter(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, value);
public static Style<T> Transform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.OverlayPopupHost
=> style._addSetter(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, binding);
}


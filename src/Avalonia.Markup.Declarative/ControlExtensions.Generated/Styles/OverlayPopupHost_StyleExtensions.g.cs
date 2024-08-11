using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class OverlayPopupHostExtensions
{
public static Style<T> Transform<T>(this Style<T> style, Transform value) where T : OverlayPopupHost
=> style._addSetter(OverlayPopupHost.TransformProperty, value);
public static Style<T> Transform<T>(this Style<T> style, IBinding binding) where T : OverlayPopupHost
=> style._addSetter(OverlayPopupHost.TransformProperty, binding);
}


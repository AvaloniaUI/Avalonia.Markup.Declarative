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
public static Style<OverlayPopupHost> Transform(this Style<OverlayPopupHost> style, Transform value)
=> style._addSetter(OverlayPopupHost.TransformProperty, value);
public static Style<OverlayPopupHost> Transform(this Style<OverlayPopupHost> style, IBinding binding)
=> style._addSetter(OverlayPopupHost.TransformProperty, binding);
}


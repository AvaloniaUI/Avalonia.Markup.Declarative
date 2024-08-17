using AdornerLayer = Avalonia.Controls.Primitives.AdornerLayer;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class AdornerLayerExtensions
{
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Primitives.AdornerLayer
=> style._addSetter(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, value);
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.AdornerLayer
=> style._addSetter(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, binding);
}


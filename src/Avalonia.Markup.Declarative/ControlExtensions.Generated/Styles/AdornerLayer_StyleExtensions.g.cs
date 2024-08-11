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
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, ITemplate<Control> value) where T : AdornerLayer
=> style._addSetter(AdornerLayer.DefaultFocusAdornerProperty, value);
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, IBinding binding) where T : AdornerLayer
=> style._addSetter(AdornerLayer.DefaultFocusAdornerProperty, binding);
}


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
public static Style<AdornerLayer> DefaultFocusAdorner(this Style<AdornerLayer> style, ITemplate<Control> value)
=> style._addSetter(AdornerLayer.DefaultFocusAdornerProperty, value);
public static Style<AdornerLayer> DefaultFocusAdorner(this Style<AdornerLayer> style, IBinding binding)
=> style._addSetter(AdornerLayer.DefaultFocusAdornerProperty, binding);
}


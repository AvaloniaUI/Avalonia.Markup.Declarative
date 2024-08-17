using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using RangeBase = Avalonia.Controls.Primitives.RangeBase;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RangeBaseExtensions
{
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, value);
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, binding);
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, value);
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, binding);
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.ValueProperty, value);
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.ValueProperty, binding);
public static Style<T> SmallChange<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, value);
public static Style<T> SmallChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, binding);
public static Style<T> LargeChange<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, value);
public static Style<T> LargeChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, binding);
}


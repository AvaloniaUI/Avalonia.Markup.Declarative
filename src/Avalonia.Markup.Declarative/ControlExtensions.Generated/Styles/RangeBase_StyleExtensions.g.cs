using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RangeBaseExtensions
{
public static Style<T> Minimum<T>(this Style<T> style, Double value) where T : RangeBase
=> style._addSetter(RangeBase.MinimumProperty, value);
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : RangeBase
=> style._addSetter(RangeBase.MinimumProperty, binding);
public static Style<T> Maximum<T>(this Style<T> style, Double value) where T : RangeBase
=> style._addSetter(RangeBase.MaximumProperty, value);
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : RangeBase
=> style._addSetter(RangeBase.MaximumProperty, binding);
public static Style<T> Value<T>(this Style<T> style, Double value) where T : RangeBase
=> style._addSetter(RangeBase.ValueProperty, value);
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : RangeBase
=> style._addSetter(RangeBase.ValueProperty, binding);
public static Style<T> SmallChange<T>(this Style<T> style, Double value) where T : RangeBase
=> style._addSetter(RangeBase.SmallChangeProperty, value);
public static Style<T> SmallChange<T>(this Style<T> style, IBinding binding) where T : RangeBase
=> style._addSetter(RangeBase.SmallChangeProperty, binding);
public static Style<T> LargeChange<T>(this Style<T> style, Double value) where T : RangeBase
=> style._addSetter(RangeBase.LargeChangeProperty, value);
public static Style<T> LargeChange<T>(this Style<T> style, IBinding binding) where T : RangeBase
=> style._addSetter(RangeBase.LargeChangeProperty, binding);
}


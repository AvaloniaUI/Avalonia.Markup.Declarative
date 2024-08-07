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
public static Style<RangeBase> Minimum(this Style<RangeBase> style, Double value)
=> style._addSetter(RangeBase.MinimumProperty, value);
public static Style<RangeBase> Minimum(this Style<RangeBase> style, IBinding binding)
=> style._addSetter(RangeBase.MinimumProperty, binding);
public static Style<RangeBase> Maximum(this Style<RangeBase> style, Double value)
=> style._addSetter(RangeBase.MaximumProperty, value);
public static Style<RangeBase> Maximum(this Style<RangeBase> style, IBinding binding)
=> style._addSetter(RangeBase.MaximumProperty, binding);
public static Style<RangeBase> Value(this Style<RangeBase> style, Double value)
=> style._addSetter(RangeBase.ValueProperty, value);
public static Style<RangeBase> Value(this Style<RangeBase> style, IBinding binding)
=> style._addSetter(RangeBase.ValueProperty, binding);
public static Style<RangeBase> SmallChange(this Style<RangeBase> style, Double value)
=> style._addSetter(RangeBase.SmallChangeProperty, value);
public static Style<RangeBase> SmallChange(this Style<RangeBase> style, IBinding binding)
=> style._addSetter(RangeBase.SmallChangeProperty, binding);
public static Style<RangeBase> LargeChange(this Style<RangeBase> style, Double value)
=> style._addSetter(RangeBase.LargeChangeProperty, value);
public static Style<RangeBase> LargeChange(this Style<RangeBase> style, IBinding binding)
=> style._addSetter(RangeBase.LargeChangeProperty, binding);
}


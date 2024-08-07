using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LayoutTransformControlExtensions
{
public static Style<LayoutTransformControl> LayoutTransform(this Style<LayoutTransformControl> style, ITransform value)
=> style._addSetter(LayoutTransformControl.LayoutTransformProperty, value);
public static Style<LayoutTransformControl> LayoutTransform(this Style<LayoutTransformControl> style, IBinding binding)
=> style._addSetter(LayoutTransformControl.LayoutTransformProperty, binding);
public static Style<LayoutTransformControl> UseRenderTransform(this Style<LayoutTransformControl> style, Boolean value)
=> style._addSetter(LayoutTransformControl.UseRenderTransformProperty, value);
public static Style<LayoutTransformControl> UseRenderTransform(this Style<LayoutTransformControl> style, IBinding binding)
=> style._addSetter(LayoutTransformControl.UseRenderTransformProperty, binding);
}


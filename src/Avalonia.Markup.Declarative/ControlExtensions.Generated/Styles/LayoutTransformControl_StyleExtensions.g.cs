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
public static Style<T> LayoutTransform<T>(this Style<T> style, ITransform value) where T : LayoutTransformControl
=> style._addSetter(LayoutTransformControl.LayoutTransformProperty, value);
public static Style<T> LayoutTransform<T>(this Style<T> style, IBinding binding) where T : LayoutTransformControl
=> style._addSetter(LayoutTransformControl.LayoutTransformProperty, binding);
public static Style<T> UseRenderTransform<T>(this Style<T> style, Boolean value) where T : LayoutTransformControl
=> style._addSetter(LayoutTransformControl.UseRenderTransformProperty, value);
public static Style<T> UseRenderTransform<T>(this Style<T> style, IBinding binding) where T : LayoutTransformControl
=> style._addSetter(LayoutTransformControl.UseRenderTransformProperty, binding);
}


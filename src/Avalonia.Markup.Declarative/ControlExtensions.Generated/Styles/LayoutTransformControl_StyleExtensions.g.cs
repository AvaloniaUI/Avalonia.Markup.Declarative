using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using LayoutTransformControl = Avalonia.Controls.LayoutTransformControl;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LayoutTransformControlExtensions
{
public static Style<T> LayoutTransform<T>(this Style<T> style, Avalonia.Media.ITransform value) where T : Avalonia.Controls.LayoutTransformControl
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, value);
public static Style<T> LayoutTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, binding);
public static Style<T> UseRenderTransform<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.LayoutTransformControl
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, value);
public static Style<T> UseRenderTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, binding);
}


#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TransformGroupExtensions
{
public static TransformGroup Children(this TransformGroup control, IBinding binding)
   => control._set(TransformGroup.ChildrenProperty, binding);
public static TransformGroup Children(this TransformGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TransformGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TransformGroup Children(this TransformGroup control, Func<Transforms> func, Action<Transforms>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TransformGroup.ChildrenProperty, func, onChanged, expression);
public static TransformGroup Children(this TransformGroup control, Transforms value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransformGroup.ChildrenProperty, ps, () => control.Children = value, bindingMode, converter, bindingSource);
public static TransformGroup Children<TValue>(this TransformGroup control, TValue value, FuncValueConverter<TValue, Transforms> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransformGroup.ChildrenProperty, ps, () => control.Children = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PathSegmentExtensions
{
public static PathSegment IsStroked(this PathSegment control, IBinding binding)
   => control._set(PathSegment.IsStrokedProperty, binding);
public static PathSegment IsStroked(this PathSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PathSegment.IsStrokedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PathSegment IsStroked(this PathSegment control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathSegment.IsStrokedProperty, func, onChanged, expression);
public static PathSegment IsStroked(this PathSegment control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathSegment.IsStrokedProperty, ps, () => control.IsStroked = value, bindingMode, converter, bindingSource);
public static PathSegment IsStroked<TValue>(this PathSegment control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathSegment.IsStrokedProperty, ps, () => control.IsStroked = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


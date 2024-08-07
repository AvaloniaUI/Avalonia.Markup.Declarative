#nullable enable
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RunExtensions
{
public static Run Text(this Run control, IBinding binding)
   => control._set(Run.TextProperty, binding);
public static Run Text(this Run control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Run.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Run Text(this Run control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Run.TextProperty, func, onChanged, expression);
public static Run Text(this Run control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Run.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static Run Text<TValue>(this Run control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Run.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


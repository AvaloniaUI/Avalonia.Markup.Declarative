#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Dialogs;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ManagedFileChooserOverwritePromptExtensions
{
public static T FileName<T>(this T control, IBinding binding) where T : ManagedFileChooserOverwritePrompt
   => control._set(ManagedFileChooserOverwritePrompt.FileNameProperty, binding);
public static T FileName<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ManagedFileChooserOverwritePrompt
   => control._set(ManagedFileChooserOverwritePrompt.FileNameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FileName<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ManagedFileChooserOverwritePrompt
   => control._set(ManagedFileChooserOverwritePrompt.FileNameProperty, func, onChanged, expression);
public static T FileName<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ManagedFileChooserOverwritePrompt
=> control._setEx(ManagedFileChooserOverwritePrompt.FileNameProperty, ps, () => control.FileName = value, bindingMode, converter, bindingSource);
public static T FileName<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ManagedFileChooserOverwritePrompt
=> control._setEx(ManagedFileChooserOverwritePrompt.FileNameProperty, ps, () => control.FileName = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


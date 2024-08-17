#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Dialogs;
using ManagedFileChooserOverwritePrompt = Avalonia.Dialogs.ManagedFileChooserOverwritePrompt;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ManagedFileChooserOverwritePromptExtensions
{
public static T FileName<T>(this T control, IBinding binding) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt
   => control._set(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty, binding);
public static T FileName<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt
   => control._set(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FileName<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt
   => control._set(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty, func, onChanged, expression);
public static T FileName<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt
=> control._setEx(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty, ps, () => control.FileName = value, bindingMode, converter, bindingSource);
public static T FileName<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt
=> control._setEx(Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty, ps, () => control.FileName = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


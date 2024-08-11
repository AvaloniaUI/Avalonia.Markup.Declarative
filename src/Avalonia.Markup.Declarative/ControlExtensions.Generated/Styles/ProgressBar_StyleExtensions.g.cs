using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ProgressBarExtensions
{
public static Style<T> IsIndeterminate<T>(this Style<T> style, Boolean value) where T : ProgressBar
=> style._addSetter(ProgressBar.IsIndeterminateProperty, value);
public static Style<T> IsIndeterminate<T>(this Style<T> style, IBinding binding) where T : ProgressBar
=> style._addSetter(ProgressBar.IsIndeterminateProperty, binding);
public static Style<T> ShowProgressText<T>(this Style<T> style, Boolean value) where T : ProgressBar
=> style._addSetter(ProgressBar.ShowProgressTextProperty, value);
public static Style<T> ShowProgressText<T>(this Style<T> style, IBinding binding) where T : ProgressBar
=> style._addSetter(ProgressBar.ShowProgressTextProperty, binding);
public static Style<T> ProgressTextFormat<T>(this Style<T> style, String value) where T : ProgressBar
=> style._addSetter(ProgressBar.ProgressTextFormatProperty, value);
public static Style<T> ProgressTextFormat<T>(this Style<T> style, IBinding binding) where T : ProgressBar
=> style._addSetter(ProgressBar.ProgressTextFormatProperty, binding);
public static Style<T> Orientation<T>(this Style<T> style, Orientation value) where T : ProgressBar
=> style._addSetter(ProgressBar.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : ProgressBar
=> style._addSetter(ProgressBar.OrientationProperty, binding);
}


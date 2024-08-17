using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using ProgressBar = Avalonia.Controls.ProgressBar;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ProgressBarExtensions
{
public static Style<T> IsIndeterminate<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, value);
public static Style<T> IsIndeterminate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, binding);
public static Style<T> ShowProgressText<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, value);
public static Style<T> ShowProgressText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, binding);
public static Style<T> ProgressTextFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, value);
public static Style<T> ProgressTextFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, binding);
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.OrientationProperty, binding);
}


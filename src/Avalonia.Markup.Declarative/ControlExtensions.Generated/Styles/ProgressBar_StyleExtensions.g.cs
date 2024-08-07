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
public static Style<ProgressBar> IsIndeterminate(this Style<ProgressBar> style, Boolean value)
=> style._addSetter(ProgressBar.IsIndeterminateProperty, value);
public static Style<ProgressBar> IsIndeterminate(this Style<ProgressBar> style, IBinding binding)
=> style._addSetter(ProgressBar.IsIndeterminateProperty, binding);
public static Style<ProgressBar> ShowProgressText(this Style<ProgressBar> style, Boolean value)
=> style._addSetter(ProgressBar.ShowProgressTextProperty, value);
public static Style<ProgressBar> ShowProgressText(this Style<ProgressBar> style, IBinding binding)
=> style._addSetter(ProgressBar.ShowProgressTextProperty, binding);
public static Style<ProgressBar> ProgressTextFormat(this Style<ProgressBar> style, String value)
=> style._addSetter(ProgressBar.ProgressTextFormatProperty, value);
public static Style<ProgressBar> ProgressTextFormat(this Style<ProgressBar> style, IBinding binding)
=> style._addSetter(ProgressBar.ProgressTextFormatProperty, binding);
public static Style<ProgressBar> Orientation(this Style<ProgressBar> style, Orientation value)
=> style._addSetter(ProgressBar.OrientationProperty, value);
public static Style<ProgressBar> Orientation(this Style<ProgressBar> style, IBinding binding)
=> style._addSetter(ProgressBar.OrientationProperty, binding);
}


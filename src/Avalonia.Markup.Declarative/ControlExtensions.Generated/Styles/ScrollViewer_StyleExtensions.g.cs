using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ScrollViewer = Avalonia.Controls.ScrollViewer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollViewerExtensions
{
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, value);
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);
}


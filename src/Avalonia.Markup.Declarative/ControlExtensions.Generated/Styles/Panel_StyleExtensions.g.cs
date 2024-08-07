using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PanelExtensions
{
public static Style<T> Background<T>(this Style<T> style, IBrush value) where T : Panel
=> style._addSetter(Panel.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Panel
=> style._addSetter(Panel.BackgroundProperty, binding);
}


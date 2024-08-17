using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Panel = Avalonia.Controls.Panel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PanelExtensions
{
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Panel
=> style._addSetter(Avalonia.Controls.Panel.BackgroundProperty, value);
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Panel
=> style._addSetter(Avalonia.Controls.Panel.BackgroundProperty, binding);
}


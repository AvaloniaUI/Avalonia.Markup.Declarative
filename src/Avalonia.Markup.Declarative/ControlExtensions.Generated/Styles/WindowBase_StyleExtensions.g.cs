using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using WindowBase = Avalonia.Controls.WindowBase;

namespace Avalonia.Markup.Declarative;
public static partial class WindowBaseExtensions
{
public static Style<T> Topmost<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.WindowBase
=> style._addSetter(Avalonia.Controls.WindowBase.TopmostProperty, value);
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WindowBase
=> style._addSetter(Avalonia.Controls.WindowBase.TopmostProperty, binding);
}


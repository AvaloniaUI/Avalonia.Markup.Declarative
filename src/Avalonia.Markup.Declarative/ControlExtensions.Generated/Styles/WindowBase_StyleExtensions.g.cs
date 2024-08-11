using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class WindowBaseExtensions
{
public static Style<T> Topmost<T>(this Style<T> style, Boolean value) where T : WindowBase
=> style._addSetter(WindowBase.TopmostProperty, value);
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : WindowBase
=> style._addSetter(WindowBase.TopmostProperty, binding);
}


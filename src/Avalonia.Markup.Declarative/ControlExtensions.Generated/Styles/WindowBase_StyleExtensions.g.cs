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
public static Style<WindowBase> Topmost(this Style<WindowBase> style, Boolean value)
=> style._addSetter(WindowBase.TopmostProperty, value);
public static Style<WindowBase> Topmost(this Style<WindowBase> style, IBinding binding)
=> style._addSetter(WindowBase.TopmostProperty, binding);
}


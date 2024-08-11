using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class AccessTextExtensions
{
public static Style<T> ShowAccessKey<T>(this Style<T> style, Boolean value) where T : AccessText
=> style._addSetter(AccessText.ShowAccessKeyProperty, value);
public static Style<T> ShowAccessKey<T>(this Style<T> style, IBinding binding) where T : AccessText
=> style._addSetter(AccessText.ShowAccessKeyProperty, binding);
}


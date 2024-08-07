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
public static Style<AccessText> ShowAccessKey(this Style<AccessText> style, Boolean value)
=> style._addSetter(AccessText.ShowAccessKeyProperty, value);
public static Style<AccessText> ShowAccessKey(this Style<AccessText> style, IBinding binding)
=> style._addSetter(AccessText.ShowAccessKeyProperty, binding);
}


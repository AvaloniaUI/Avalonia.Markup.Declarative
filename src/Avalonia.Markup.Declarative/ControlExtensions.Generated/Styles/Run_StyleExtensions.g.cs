using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RunExtensions
{
public static Style<T> Text<T>(this Style<T> style, String value) where T : Run
=> style._addSetter(Run.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Run
=> style._addSetter(Run.TextProperty, binding);
}


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
public static Style<Run> Text(this Style<Run> style, String value)
=> style._addSetter(Run.TextProperty, value);
public static Style<Run> Text(this Style<Run> style, IBinding binding)
=> style._addSetter(Run.TextProperty, binding);
}


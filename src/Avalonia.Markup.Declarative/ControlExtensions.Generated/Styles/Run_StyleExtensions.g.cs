using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Run = Avalonia.Controls.Documents.Run;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RunExtensions
{
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Documents.Run
=> style._addSetter(Avalonia.Controls.Documents.Run.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Run
=> style._addSetter(Avalonia.Controls.Documents.Run.TextProperty, binding);
}


using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ThemeVariantScopeExtensions
{
public static Style<ThemeVariantScope> RequestedThemeVariant(this Style<ThemeVariantScope> style, ThemeVariant value)
=> style._addSetter(ThemeVariantScope.RequestedThemeVariantProperty, value);
public static Style<ThemeVariantScope> RequestedThemeVariant(this Style<ThemeVariantScope> style, IBinding binding)
=> style._addSetter(ThemeVariantScope.RequestedThemeVariantProperty, binding);
}


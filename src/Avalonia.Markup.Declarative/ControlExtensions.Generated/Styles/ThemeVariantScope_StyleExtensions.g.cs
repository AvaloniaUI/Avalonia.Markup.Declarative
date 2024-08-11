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
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, ThemeVariant value) where T : ThemeVariantScope
=> style._addSetter(ThemeVariantScope.RequestedThemeVariantProperty, value);
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : ThemeVariantScope
=> style._addSetter(ThemeVariantScope.RequestedThemeVariantProperty, binding);
}


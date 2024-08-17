using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using ThemeVariantScope = Avalonia.Controls.ThemeVariantScope;

namespace Avalonia.Markup.Declarative;
public static partial class ThemeVariantScopeExtensions
{
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.ThemeVariantScope
=> style._addSetter(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, value);
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ThemeVariantScope
=> style._addSetter(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, binding);
}


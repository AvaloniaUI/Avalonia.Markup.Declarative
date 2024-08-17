using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using RefreshContainer = Avalonia.Controls.RefreshContainer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RefreshContainerExtensions
{
public static Style<T> PullDirection<T>(this Style<T> style, Avalonia.Input.PullDirection value) where T : Avalonia.Controls.RefreshContainer
=> style._addSetter(Avalonia.Controls.RefreshContainer.PullDirectionProperty, value);
public static Style<T> PullDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RefreshContainer
=> style._addSetter(Avalonia.Controls.RefreshContainer.PullDirectionProperty, binding);
}


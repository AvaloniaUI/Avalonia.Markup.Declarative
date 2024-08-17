using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using HeaderedSelectingItemsControl = Avalonia.Controls.Primitives.HeaderedSelectingItemsControl;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HeaderedSelectingItemsControlExtensions
{
public static Style<T> Header<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, value);
public static Style<T> Header<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, binding);
public static Style<T> HeaderTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty, value);
public static Style<T> HeaderTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty, binding);
}


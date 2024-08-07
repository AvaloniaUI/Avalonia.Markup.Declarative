using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HeaderedSelectingItemsControlExtensions
{
public static Style<T> Header<T>(this Style<T> style, Object value) where T : HeaderedSelectingItemsControl
=> style._addSetter(HeaderedSelectingItemsControl.HeaderProperty, value);
public static Style<T> Header<T>(this Style<T> style, IBinding binding) where T : HeaderedSelectingItemsControl
=> style._addSetter(HeaderedSelectingItemsControl.HeaderProperty, binding);
public static Style<T> HeaderTemplate<T>(this Style<T> style, IDataTemplate value) where T : HeaderedSelectingItemsControl
=> style._addSetter(HeaderedSelectingItemsControl.HeaderTemplateProperty, value);
public static Style<T> HeaderTemplate<T>(this Style<T> style, IBinding binding) where T : HeaderedSelectingItemsControl
=> style._addSetter(HeaderedSelectingItemsControl.HeaderTemplateProperty, binding);
}


using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using HeaderedItemsControl = Avalonia.Controls.Primitives.HeaderedItemsControl;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HeaderedItemsControlExtensions
{
public static Style<T> Header<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty, value);
public static Style<T> Header<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty, binding);
public static Style<T> HeaderTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty, value);
public static Style<T> HeaderTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty, binding);
}


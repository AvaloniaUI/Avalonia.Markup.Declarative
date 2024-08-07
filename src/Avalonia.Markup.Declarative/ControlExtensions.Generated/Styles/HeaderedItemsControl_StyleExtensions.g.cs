using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HeaderedItemsControlExtensions
{
public static Style<HeaderedItemsControl> Header(this Style<HeaderedItemsControl> style, Object value)
=> style._addSetter(HeaderedItemsControl.HeaderProperty, value);
public static Style<HeaderedItemsControl> Header(this Style<HeaderedItemsControl> style, IBinding binding)
=> style._addSetter(HeaderedItemsControl.HeaderProperty, binding);
public static Style<HeaderedItemsControl> HeaderTemplate(this Style<HeaderedItemsControl> style, IDataTemplate value)
=> style._addSetter(HeaderedItemsControl.HeaderTemplateProperty, value);
public static Style<HeaderedItemsControl> HeaderTemplate(this Style<HeaderedItemsControl> style, IBinding binding)
=> style._addSetter(HeaderedItemsControl.HeaderTemplateProperty, binding);
}


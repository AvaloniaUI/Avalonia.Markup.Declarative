using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ContentControlExtensions
{
public static Style<T> Content<T>(this Style<T> style, Object value) where T : ContentControl
=> style._addSetter(ContentControl.ContentProperty, value);
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : ContentControl
=> style._addSetter(ContentControl.ContentProperty, binding);
public static Style<T> ContentTemplate<T>(this Style<T> style, IDataTemplate value) where T : ContentControl
=> style._addSetter(ContentControl.ContentTemplateProperty, value);
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : ContentControl
=> style._addSetter(ContentControl.ContentTemplateProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, HorizontalAlignment value) where T : ContentControl
=> style._addSetter(ContentControl.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : ContentControl
=> style._addSetter(ContentControl.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, VerticalAlignment value) where T : ContentControl
=> style._addSetter(ContentControl.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : ContentControl
=> style._addSetter(ContentControl.VerticalContentAlignmentProperty, binding);
}


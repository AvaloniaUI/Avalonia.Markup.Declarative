using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using ContentControl = Avalonia.Controls.ContentControl;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ContentControlExtensions
{
public static Style<T> Content<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.ContentControl
=> style._addSetter(Avalonia.Controls.ContentControl.ContentProperty, value);
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl
=> style._addSetter(Avalonia.Controls.ContentControl.ContentProperty, binding);
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ContentControl
=> style._addSetter(Avalonia.Controls.ContentControl.ContentTemplateProperty, value);
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl
=> style._addSetter(Avalonia.Controls.ContentControl.ContentTemplateProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentControl
=> style._addSetter(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl
=> style._addSetter(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentControl
=> style._addSetter(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl
=> style._addSetter(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty, binding);
}


#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class ItemsPresenter_MarkupExtensions
{
//================= Properties ======================//
 // ItemsPanel

/*BindFromExpressionSetterGenerator*/
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ItemsPanel<T>(this T control,Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, ps, () => control.ItemsPanel = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemsPanel<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsPanel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ItemsPanel<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, ps, () => control.ItemsPanel = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//
 // ItemsPanel

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, binding);



}

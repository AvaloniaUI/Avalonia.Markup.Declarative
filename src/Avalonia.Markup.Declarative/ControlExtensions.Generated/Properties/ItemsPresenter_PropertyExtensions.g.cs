#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ItemsPresenter = Avalonia.Controls.Presenters.ItemsPresenter;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ItemsPresenterExtensions
{
public static T ItemsPanel<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ItemsPresenter
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, binding);
public static T ItemsPanel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ItemsPresenter
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ItemsPresenter
   => control._set(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, func, onChanged, expression);
public static T ItemsPanel<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ItemsPresenter
=> control._setEx(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, ps, () => control.ItemsPanel = value, bindingMode, converter, bindingSource);
public static T ItemsPanel<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ItemsPresenter
=> control._setEx(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, ps, () => control.ItemsPanel = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


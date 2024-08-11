#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ItemsPresenterExtensions
{
public static T ItemsPanel<T>(this T control, IBinding binding) where T : ItemsPresenter
   => control._set(ItemsPresenter.ItemsPanelProperty, binding);
public static T ItemsPanel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ItemsPresenter
   => control._set(ItemsPresenter.ItemsPanelProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemsPanel<T>(this T control, Func<ITemplate<Panel>> func, Action<ITemplate<Panel>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsPresenter
   => control._set(ItemsPresenter.ItemsPanelProperty, func, onChanged, expression);
public static T ItemsPanel<T>(this T control, ITemplate<Panel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsPresenter
=> control._setEx(ItemsPresenter.ItemsPanelProperty, ps, () => control.ItemsPanel = value, bindingMode, converter, bindingSource);
public static T ItemsPanel<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITemplate<Panel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsPresenter
=> control._setEx(ItemsPresenter.ItemsPanelProperty, ps, () => control.ItemsPanel = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


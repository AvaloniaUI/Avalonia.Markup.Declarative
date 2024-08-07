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
public static ItemsPresenter ItemsPanel(this ItemsPresenter control, IBinding binding)
   => control._set(ItemsPresenter.ItemsPanelProperty, binding);
public static ItemsPresenter ItemsPanel(this ItemsPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ItemsPresenter.ItemsPanelProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ItemsPresenter ItemsPanel(this ItemsPresenter control, Func<ITemplate<Panel>> func, Action<ITemplate<Panel>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ItemsPresenter.ItemsPanelProperty, func, onChanged, expression);
public static ItemsPresenter ItemsPanel(this ItemsPresenter control, ITemplate<Panel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ItemsPresenter.ItemsPanelProperty, ps, () => control.ItemsPanel = value, bindingMode, converter, bindingSource);
public static ItemsPresenter ItemsPanel<TValue>(this ItemsPresenter control, TValue value, FuncValueConverter<TValue, ITemplate<Panel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ItemsPresenter.ItemsPanelProperty, ps, () => control.ItemsPanel = converter.TryConvert(value), bindingMode, converter, bindingSource);
}


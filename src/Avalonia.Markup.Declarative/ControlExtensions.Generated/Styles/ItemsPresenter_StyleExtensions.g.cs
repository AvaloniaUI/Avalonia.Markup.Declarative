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
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.Presenters.ItemsPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, value);
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ItemsPresenter
=> style._addSetter(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, binding);
}


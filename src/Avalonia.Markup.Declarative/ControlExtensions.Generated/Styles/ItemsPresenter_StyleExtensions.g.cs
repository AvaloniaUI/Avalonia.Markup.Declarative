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
public static Style<ItemsPresenter> ItemsPanel(this Style<ItemsPresenter> style, ITemplate<Panel> value)
=> style._addSetter(ItemsPresenter.ItemsPanelProperty, value);
public static Style<ItemsPresenter> ItemsPanel(this Style<ItemsPresenter> style, IBinding binding)
=> style._addSetter(ItemsPresenter.ItemsPanelProperty, binding);
}


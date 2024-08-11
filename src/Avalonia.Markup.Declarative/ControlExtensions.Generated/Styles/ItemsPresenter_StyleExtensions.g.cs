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
public static Style<T> ItemsPanel<T>(this Style<T> style, ITemplate<Panel> value) where T : ItemsPresenter
=> style._addSetter(ItemsPresenter.ItemsPanelProperty, value);
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : ItemsPresenter
=> style._addSetter(ItemsPresenter.ItemsPanelProperty, binding);
}


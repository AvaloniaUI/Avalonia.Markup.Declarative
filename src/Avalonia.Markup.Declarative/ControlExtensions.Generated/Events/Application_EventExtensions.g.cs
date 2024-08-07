using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ApplicationEventsExtensions
{
    public static Application OnResourcesChanged(this Application control, Action<ResourcesChangedEventArgs> action) => 
        control._setEvent((EventHandler<ResourcesChangedEventArgs>) ((_, args) => action(args)), h => control.ResourcesChanged += h);
	[Obsolete("Use Application.Current.TryGetFeature<IActivatableLifetime>() instead.")]
    public static Application OnUrlsOpened(this Application control, Action<UrlOpenedEventArgs> action) => 
        control._setEvent((EventHandler<UrlOpenedEventArgs>) ((_, args) => action(args)), h => control.UrlsOpened += h);
    public static Application OnActualThemeVariantChanged(this Application control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ActualThemeVariantChanged += h);
}


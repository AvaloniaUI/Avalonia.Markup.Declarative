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
    public static T OnResourcesChanged<T>(this T control, Action<ResourcesChangedEventArgs> action) where T : Application => 
        control._setEvent((EventHandler<ResourcesChangedEventArgs>) ((_, args) => action(args)), h => control.ResourcesChanged += h);
	[Obsolete("Use Application.Current.TryGetFeature<IActivatableLifetime>() instead.")]
    public static T OnUrlsOpened<T>(this T control, Action<UrlOpenedEventArgs> action) where T : Application => 
        control._setEvent((EventHandler<UrlOpenedEventArgs>) ((_, args) => action(args)), h => control.UrlsOpened += h);
    public static T OnActualThemeVariantChanged<T>(this T control, Action action) where T : Application => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ActualThemeVariantChanged += h);
}


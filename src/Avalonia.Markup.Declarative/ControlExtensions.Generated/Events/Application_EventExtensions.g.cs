using Application = Avalonia.Application;
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
    public static T OnResourcesChanged<T>(this T control, Action<Avalonia.Controls.ResourcesChangedEventArgs> action) where T : Avalonia.Application => 
        control._setEvent((System.EventHandler<Avalonia.Controls.ResourcesChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ResourcesChanged += h);
	[Obsolete("Use Application.Current.TryGetFeature<IActivatableLifetime>() instead.")]
    public static T OnUrlsOpened<T>(this T control, Action<Avalonia.UrlOpenedEventArgs> action) where T : Avalonia.Application => 
        control._setEvent((System.EventHandler<Avalonia.UrlOpenedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.UrlsOpened += h);
    public static T OnActualThemeVariantChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Application => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ActualThemeVariantChanged += h);
}


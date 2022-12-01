﻿using System;
using Avalonia.Data;
using Avalonia.Data.Converters;

namespace Avalonia.Markup.Declarative.Mvu;

public static class ComponentExtensions
{

    private static IServiceProvider _serviceProvider;
    internal static IServiceProvider ServiceProvider => _serviceProvider;

    public static AppBuilder UseServiceProvider(this AppBuilder appBuilder, IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        return appBuilder;
    }

    /// <summary>
    /// Userd by autogenerated extensions from source generator for direct apply value to component's property
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <param name="control"></param>
    /// <param name="sourcePropertyPathString"></param>
    /// <param name="setAction"></param>
    /// <param name="bindingMode"></param>
    /// <param name="converter"></param>
    /// <param name="bindingSource"></param>
    /// <returns></returns>
    public static TControl _setCommonEx<TControl>(this TControl control, string sourcePropertyPathString, Action setAction,
        BindingMode? bindingMode, IValueConverter converter, object bindingSource)
        where TControl : AvaloniaObject
    {
        setAction();
        if (control is IMvuComponent viewBase)
            viewBase.UpdateState();
        return control;
    }

    /// <summary>
    /// Userd by autogenerated extensions from source generator for binding Common properties to ViewBase components
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="control"></param>
    /// <param name="setAction"></param>
    /// <param name="binding"></param>
    /// <returns></returns>
    public static TControl _setCommonBindingEx<TControl, TValue>(this TControl control, Action<TValue> setAction, IBinding ibinding)
        where TControl : AvaloniaObject
    {
        if (ibinding is ComponentBase.MvuBinding bindingEx)
        {
            TValue val = (TValue)bindingEx.Value;
            setAction(val);

            if (control is ComponentBase targetView)
            {
                targetView.UpdateState();

                if (bindingEx.Source is ComponentBase sourceView)
                {
                    targetView.AddExternalState(sourceView, bindingEx.Path, setAction);
                }
            }
        }

        return control;
    }
}
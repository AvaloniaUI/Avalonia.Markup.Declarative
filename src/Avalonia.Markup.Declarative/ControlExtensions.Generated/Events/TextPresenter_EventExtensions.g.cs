using Avalonia.Controls.Presenters;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TextPresenter = Avalonia.Controls.Presenters.TextPresenter;

namespace Avalonia.Markup.Declarative;
public static partial class TextPresenterEventsExtensions
{
    public static T OnCaretBoundsChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Presenters.TextPresenter => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CaretBoundsChanged += h);
}


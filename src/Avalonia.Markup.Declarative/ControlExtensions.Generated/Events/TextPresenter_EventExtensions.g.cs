using Avalonia.Controls.Presenters;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TextPresenterEventsExtensions
{
    public static T OnCaretBoundsChanged<T>(this T control, Action action) where T : TextPresenter => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CaretBoundsChanged += h);
}


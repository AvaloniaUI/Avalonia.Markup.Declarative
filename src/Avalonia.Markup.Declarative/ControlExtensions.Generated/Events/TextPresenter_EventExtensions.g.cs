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
    public static TextPresenter OnCaretBoundsChanged(this TextPresenter control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CaretBoundsChanged += h);
}


using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TemplatedControl = Avalonia.Controls.Primitives.TemplatedControl;

namespace Avalonia.Markup.Declarative;
public static partial class TemplatedControlEventsExtensions
{
    public static T OnTemplateApplied<T>(this T control, Action<Avalonia.Controls.Primitives.TemplateAppliedEventArgs> action) where T : Avalonia.Controls.Primitives.TemplatedControl => 
        control._setEvent((System.EventHandler<Avalonia.Controls.Primitives.TemplateAppliedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TemplateApplied += h);
}


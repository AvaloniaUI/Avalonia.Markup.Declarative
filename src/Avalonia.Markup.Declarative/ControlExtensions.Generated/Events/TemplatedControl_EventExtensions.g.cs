using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TemplatedControlEventsExtensions
{
    public static T OnTemplateApplied<T>(this T control, Action<TemplateAppliedEventArgs> action) where T : TemplatedControl => 
        control._setEvent((EventHandler<TemplateAppliedEventArgs>) ((_, args) => action(args)), h => control.TemplateApplied += h);
}


using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExperimentalAcrylicMaterialEventsExtensions
{
    public static ExperimentalAcrylicMaterial OnInvalidated(this ExperimentalAcrylicMaterial control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}


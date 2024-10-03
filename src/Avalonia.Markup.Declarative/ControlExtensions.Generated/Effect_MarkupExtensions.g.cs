#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Effect_MarkupExtensions
{
//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
    public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Effect => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);



}

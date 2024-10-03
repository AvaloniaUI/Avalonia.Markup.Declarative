#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
<<<<<<< HEAD
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
=======
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
>>>>>>> c1347bc81bdb20ad44b1fda7d31eecec56065f2f
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class AvaloniaObject_MarkupExtensions
{
//================= Events ======================//
 // PropertyChanged

/*ActionToEventGenerator*/
public static T OnPropertyChanged<T>(this T control, Action<Avalonia.AvaloniaPropertyChangedEventArgs> action) where T : Avalonia.AvaloniaObject  => 
 control._setEvent((System.EventHandler<Avalonia.AvaloniaPropertyChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PropertyChanged += h);



}

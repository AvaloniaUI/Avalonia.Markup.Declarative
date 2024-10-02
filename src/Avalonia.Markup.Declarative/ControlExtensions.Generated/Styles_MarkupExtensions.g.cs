#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Styles_MarkupExtensions
{
//================= Properties ======================//

//================= Attached Properties ======================//

//================= Events ======================//
 // CollectionChanged

/*ActionToEventGenerator*/
    public static T OnCollectionChanged<T>(this T control, Action<System.Collections.Specialized.NotifyCollectionChangedEventArgs> action) where T : Avalonia.Styling.Styles => 
        control._setEvent((System.Collections.Specialized.NotifyCollectionChangedEventHandler) ((arg0, arg1) => action(arg1)), h => control.CollectionChanged += h);


 // OwnerChanged

/*ActionToEventGenerator*/
    public static T OnOwnerChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Styling.Styles => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.OwnerChanged += h);



//================= Styles ======================//

}

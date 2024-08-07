using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HeaderedContentControlExtensions
{
public static Style<HeaderedContentControl> Header(this Style<HeaderedContentControl> style, Object value)
=> style._addSetter(HeaderedContentControl.HeaderProperty, value);
public static Style<HeaderedContentControl> Header(this Style<HeaderedContentControl> style, IBinding binding)
=> style._addSetter(HeaderedContentControl.HeaderProperty, binding);
public static Style<HeaderedContentControl> HeaderTemplate(this Style<HeaderedContentControl> style, IDataTemplate value)
=> style._addSetter(HeaderedContentControl.HeaderTemplateProperty, value);
public static Style<HeaderedContentControl> HeaderTemplate(this Style<HeaderedContentControl> style, IBinding binding)
=> style._addSetter(HeaderedContentControl.HeaderTemplateProperty, binding);
}


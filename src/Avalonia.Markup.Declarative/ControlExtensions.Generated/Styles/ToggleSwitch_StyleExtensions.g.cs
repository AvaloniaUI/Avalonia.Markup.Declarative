using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleSwitchExtensions
{
public static Style<ToggleSwitch> OffContent(this Style<ToggleSwitch> style, Object value)
=> style._addSetter(ToggleSwitch.OffContentProperty, value);
public static Style<ToggleSwitch> OffContent(this Style<ToggleSwitch> style, IBinding binding)
=> style._addSetter(ToggleSwitch.OffContentProperty, binding);
public static Style<ToggleSwitch> OffContentTemplate(this Style<ToggleSwitch> style, IDataTemplate value)
=> style._addSetter(ToggleSwitch.OffContentTemplateProperty, value);
public static Style<ToggleSwitch> OffContentTemplate(this Style<ToggleSwitch> style, IBinding binding)
=> style._addSetter(ToggleSwitch.OffContentTemplateProperty, binding);
public static Style<ToggleSwitch> OnContent(this Style<ToggleSwitch> style, Object value)
=> style._addSetter(ToggleSwitch.OnContentProperty, value);
public static Style<ToggleSwitch> OnContent(this Style<ToggleSwitch> style, IBinding binding)
=> style._addSetter(ToggleSwitch.OnContentProperty, binding);
public static Style<ToggleSwitch> OnContentTemplate(this Style<ToggleSwitch> style, IDataTemplate value)
=> style._addSetter(ToggleSwitch.OnContentTemplateProperty, value);
public static Style<ToggleSwitch> OnContentTemplate(this Style<ToggleSwitch> style, IBinding binding)
=> style._addSetter(ToggleSwitch.OnContentTemplateProperty, binding);
public static Style<ToggleSwitch> KnobTransitions(this Style<ToggleSwitch> style, Transitions value)
=> style._addSetter(ToggleSwitch.KnobTransitionsProperty, value);
public static Style<ToggleSwitch> KnobTransitions(this Style<ToggleSwitch> style, IBinding binding)
=> style._addSetter(ToggleSwitch.KnobTransitionsProperty, binding);
}


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
public static Style<T> OffContent<T>(this Style<T> style, Object value) where T : ToggleSwitch
=> style._addSetter(ToggleSwitch.OffContentProperty, value);
public static Style<T> OffContent<T>(this Style<T> style, IBinding binding) where T : ToggleSwitch
=> style._addSetter(ToggleSwitch.OffContentProperty, binding);
public static Style<T> OffContentTemplate<T>(this Style<T> style, IDataTemplate value) where T : ToggleSwitch
=> style._addSetter(ToggleSwitch.OffContentTemplateProperty, value);
public static Style<T> OffContentTemplate<T>(this Style<T> style, IBinding binding) where T : ToggleSwitch
=> style._addSetter(ToggleSwitch.OffContentTemplateProperty, binding);
public static Style<T> OnContent<T>(this Style<T> style, Object value) where T : ToggleSwitch
=> style._addSetter(ToggleSwitch.OnContentProperty, value);
public static Style<T> OnContent<T>(this Style<T> style, IBinding binding) where T : ToggleSwitch
=> style._addSetter(ToggleSwitch.OnContentProperty, binding);
public static Style<T> OnContentTemplate<T>(this Style<T> style, IDataTemplate value) where T : ToggleSwitch
=> style._addSetter(ToggleSwitch.OnContentTemplateProperty, value);
public static Style<T> OnContentTemplate<T>(this Style<T> style, IBinding binding) where T : ToggleSwitch
=> style._addSetter(ToggleSwitch.OnContentTemplateProperty, binding);
public static Style<T> KnobTransitions<T>(this Style<T> style, Transitions value) where T : ToggleSwitch
=> style._addSetter(ToggleSwitch.KnobTransitionsProperty, value);
public static Style<T> KnobTransitions<T>(this Style<T> style, IBinding binding) where T : ToggleSwitch
=> style._addSetter(ToggleSwitch.KnobTransitionsProperty, binding);
}


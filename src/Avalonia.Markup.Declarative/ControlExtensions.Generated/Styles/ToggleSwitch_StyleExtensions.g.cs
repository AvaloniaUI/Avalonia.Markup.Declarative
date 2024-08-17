using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using ToggleSwitch = Avalonia.Controls.ToggleSwitch;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleSwitchExtensions
{
public static Style<T> OffContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.ToggleSwitch
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentProperty, value);
public static Style<T> OffContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentProperty, binding);
public static Style<T> OffContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, value);
public static Style<T> OffContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, binding);
public static Style<T> OnContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.ToggleSwitch
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentProperty, value);
public static Style<T> OnContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentProperty, binding);
public static Style<T> OnContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, value);
public static Style<T> OnContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, binding);
public static Style<T> KnobTransitions<T>(this Style<T> style, Avalonia.Animation.Transitions value) where T : Avalonia.Controls.ToggleSwitch
=> style._addSetter(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, value);
public static Style<T> KnobTransitions<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch
=> style._addSetter(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, binding);
}


using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using MaskedTextBox = Avalonia.Controls.MaskedTextBox;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MaskedTextBoxExtensions
{
public static Style<T> AsciiOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, value);
public static Style<T> AsciiOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, binding);
public static Style<T> Culture<T>(this Style<T> style, System.Globalization.CultureInfo value) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.CultureProperty, value);
public static Style<T> Culture<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.CultureProperty, binding);
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, value);
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, binding);
public static Style<T> Mask<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.MaskProperty, value);
public static Style<T> Mask<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.MaskProperty, binding);
public static Style<T> PromptChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.PromptCharProperty, value);
public static Style<T> PromptChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.PromptCharProperty, binding);
public static Style<T> ResetOnPrompt<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, value);
public static Style<T> ResetOnPrompt<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, binding);
public static Style<T> ResetOnSpace<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, value);
public static Style<T> ResetOnSpace<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, binding);
}


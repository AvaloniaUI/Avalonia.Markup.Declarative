using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MaskedTextBoxExtensions
{
public static Style<T> AsciiOnly<T>(this Style<T> style, Boolean value) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.AsciiOnlyProperty, value);
public static Style<T> AsciiOnly<T>(this Style<T> style, IBinding binding) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.AsciiOnlyProperty, binding);
public static Style<T> Culture<T>(this Style<T> style, CultureInfo value) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.CultureProperty, value);
public static Style<T> Culture<T>(this Style<T> style, IBinding binding) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.CultureProperty, binding);
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, Boolean value) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.HidePromptOnLeaveProperty, value);
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, IBinding binding) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.HidePromptOnLeaveProperty, binding);
public static Style<T> Mask<T>(this Style<T> style, String value) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.MaskProperty, value);
public static Style<T> Mask<T>(this Style<T> style, IBinding binding) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.MaskProperty, binding);
public static Style<T> PromptChar<T>(this Style<T> style, Char value) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.PromptCharProperty, value);
public static Style<T> PromptChar<T>(this Style<T> style, IBinding binding) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.PromptCharProperty, binding);
public static Style<T> ResetOnPrompt<T>(this Style<T> style, Boolean value) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.ResetOnPromptProperty, value);
public static Style<T> ResetOnPrompt<T>(this Style<T> style, IBinding binding) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.ResetOnPromptProperty, binding);
public static Style<T> ResetOnSpace<T>(this Style<T> style, Boolean value) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.ResetOnSpaceProperty, value);
public static Style<T> ResetOnSpace<T>(this Style<T> style, IBinding binding) where T : MaskedTextBox
=> style._addSetter(MaskedTextBox.ResetOnSpaceProperty, binding);
}


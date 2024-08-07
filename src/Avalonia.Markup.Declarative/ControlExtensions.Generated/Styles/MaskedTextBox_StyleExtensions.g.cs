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
public static Style<MaskedTextBox> AsciiOnly(this Style<MaskedTextBox> style, Boolean value)
=> style._addSetter(MaskedTextBox.AsciiOnlyProperty, value);
public static Style<MaskedTextBox> AsciiOnly(this Style<MaskedTextBox> style, IBinding binding)
=> style._addSetter(MaskedTextBox.AsciiOnlyProperty, binding);
public static Style<MaskedTextBox> Culture(this Style<MaskedTextBox> style, CultureInfo value)
=> style._addSetter(MaskedTextBox.CultureProperty, value);
public static Style<MaskedTextBox> Culture(this Style<MaskedTextBox> style, IBinding binding)
=> style._addSetter(MaskedTextBox.CultureProperty, binding);
public static Style<MaskedTextBox> HidePromptOnLeave(this Style<MaskedTextBox> style, Boolean value)
=> style._addSetter(MaskedTextBox.HidePromptOnLeaveProperty, value);
public static Style<MaskedTextBox> HidePromptOnLeave(this Style<MaskedTextBox> style, IBinding binding)
=> style._addSetter(MaskedTextBox.HidePromptOnLeaveProperty, binding);
public static Style<MaskedTextBox> Mask(this Style<MaskedTextBox> style, String value)
=> style._addSetter(MaskedTextBox.MaskProperty, value);
public static Style<MaskedTextBox> Mask(this Style<MaskedTextBox> style, IBinding binding)
=> style._addSetter(MaskedTextBox.MaskProperty, binding);
public static Style<MaskedTextBox> PromptChar(this Style<MaskedTextBox> style, Char value)
=> style._addSetter(MaskedTextBox.PromptCharProperty, value);
public static Style<MaskedTextBox> PromptChar(this Style<MaskedTextBox> style, IBinding binding)
=> style._addSetter(MaskedTextBox.PromptCharProperty, binding);
public static Style<MaskedTextBox> ResetOnPrompt(this Style<MaskedTextBox> style, Boolean value)
=> style._addSetter(MaskedTextBox.ResetOnPromptProperty, value);
public static Style<MaskedTextBox> ResetOnPrompt(this Style<MaskedTextBox> style, IBinding binding)
=> style._addSetter(MaskedTextBox.ResetOnPromptProperty, binding);
public static Style<MaskedTextBox> ResetOnSpace(this Style<MaskedTextBox> style, Boolean value)
=> style._addSetter(MaskedTextBox.ResetOnSpaceProperty, value);
public static Style<MaskedTextBox> ResetOnSpace(this Style<MaskedTextBox> style, IBinding binding)
=> style._addSetter(MaskedTextBox.ResetOnSpaceProperty, binding);
}


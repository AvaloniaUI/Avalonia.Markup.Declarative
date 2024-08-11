using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Dialogs;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ManagedFileChooserOverwritePromptExtensions
{
public static Style<T> FileName<T>(this Style<T> style, String value) where T : ManagedFileChooserOverwritePrompt
=> style._addSetter(ManagedFileChooserOverwritePrompt.FileNameProperty, value);
public static Style<T> FileName<T>(this Style<T> style, IBinding binding) where T : ManagedFileChooserOverwritePrompt
=> style._addSetter(ManagedFileChooserOverwritePrompt.FileNameProperty, binding);
}


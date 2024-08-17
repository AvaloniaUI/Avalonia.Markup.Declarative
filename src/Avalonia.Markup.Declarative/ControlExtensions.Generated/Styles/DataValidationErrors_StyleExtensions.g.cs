using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DataValidationErrors = Avalonia.Controls.DataValidationErrors;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DataValidationErrorsExtensions
{
public static Style<T> ErrorTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.DataValidationErrors
=> style._addSetter(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, value);
public static Style<T> ErrorTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DataValidationErrors
=> style._addSetter(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, binding);
}


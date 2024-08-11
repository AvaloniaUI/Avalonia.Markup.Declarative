using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DataValidationErrorsExtensions
{
public static Style<T> ErrorTemplate<T>(this Style<T> style, IDataTemplate value) where T : DataValidationErrors
=> style._addSetter(DataValidationErrors.ErrorTemplateProperty, value);
public static Style<T> ErrorTemplate<T>(this Style<T> style, IBinding binding) where T : DataValidationErrors
=> style._addSetter(DataValidationErrors.ErrorTemplateProperty, binding);
public static Style<T> Owner<T>(this Style<T> style, Control value) where T : DataValidationErrors
=> style._addSetter(DataValidationErrors.OwnerProperty, value);
public static Style<T> Owner<T>(this Style<T> style, IBinding binding) where T : DataValidationErrors
=> style._addSetter(DataValidationErrors.OwnerProperty, binding);
}


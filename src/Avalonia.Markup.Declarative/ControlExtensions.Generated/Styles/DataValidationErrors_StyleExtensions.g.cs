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
public static Style<DataValidationErrors> ErrorTemplate(this Style<DataValidationErrors> style, IDataTemplate value)
=> style._addSetter(DataValidationErrors.ErrorTemplateProperty, value);
public static Style<DataValidationErrors> ErrorTemplate(this Style<DataValidationErrors> style, IBinding binding)
=> style._addSetter(DataValidationErrors.ErrorTemplateProperty, binding);
public static Style<DataValidationErrors> Owner(this Style<DataValidationErrors> style, Control value)
=> style._addSetter(DataValidationErrors.OwnerProperty, value);
public static Style<DataValidationErrors> Owner(this Style<DataValidationErrors> style, IBinding binding)
=> style._addSetter(DataValidationErrors.OwnerProperty, binding);
}


using Avalonia.Data.Converters;
using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace Avalonia.Markup.Declarative;

internal static class DeclarativeBindingAutoConverter
{
    private static readonly ConcurrentDictionary<ConverterCacheKey, IValueConverter> Cache = new();

    public static IValueConverter? GetEffectiveConverter<TSourceValue>(AvaloniaProperty? avaloniaProperty, IValueConverter? converter)
        => GetEffectiveConverter(typeof(TSourceValue), avaloniaProperty?.PropertyType, converter);

    public static IValueConverter? GetEffectiveConverter(Type sourceType, Type? targetType, IValueConverter? converter)
    {
        if (converter is not null || targetType is null || CanPassWithoutConversion(sourceType, targetType))
        {
            return converter;
        }

        return Cache.GetOrAdd(new ConverterCacheKey(sourceType, targetType), static key =>
            new RuntimeBindingConverter(key.SourceType, key.TargetType));
    }

    private static bool CanPassWithoutConversion(Type sourceType, Type targetType)
        => sourceType == targetType || targetType.IsAssignableFrom(sourceType);

    private static object? ConvertValue(object? value, Type targetType, CultureInfo culture)
    {
        if (value is null)
        {
            if (IsNullableOrReferenceType(targetType))
            {
                return null;
            }

            throw new InvalidOperationException($"Cannot convert null to '{FormatTypeName(targetType)}'.");
        }

        var actualType = value.GetType();
        var nonNullableTargetType = Nullable.GetUnderlyingType(targetType) ?? targetType;

        if (nonNullableTargetType.IsAssignableFrom(actualType) || actualType == nonNullableTargetType)
        {
            return value;
        }

        if (TryConvertEnum(value, actualType, nonNullableTargetType, out var enumValue))
        {
            return enumValue;
        }

        if (TryConvertPrimitive(value, actualType, nonNullableTargetType, culture, out var primitiveValue))
        {
            return primitiveValue;
        }

        throw new InvalidOperationException(
            $"Automatic binding conversion from '{FormatTypeName(actualType)}' to '{FormatTypeName(targetType)}' is not supported. Provide an IValueConverter explicitly.");
    }

    private static bool TryConvertEnum(object value, Type sourceType, Type targetType, out object? convertedValue)
    {
        convertedValue = null;

        if (targetType == typeof(string) && sourceType.IsEnum)
        {
            convertedValue = value.ToString();
            return true;
        }

        if (sourceType == typeof(string) && targetType.IsEnum)
        {
            convertedValue = Enum.Parse(targetType, (string)value, ignoreCase: true);
            return true;
        }

        return false;
    }

    private static bool TryConvertPrimitive(object value, Type sourceType, Type targetType, CultureInfo culture, out object? convertedValue)
    {
        convertedValue = null;

        if (!IsPrimitiveConvertibleType(sourceType) || !IsPrimitiveConvertibleType(targetType))
        {
            return false;
        }

        try
        {
            convertedValue = RequiresTruncation(sourceType, targetType)
                ? ConvertWithTruncation(value, targetType)
                : System.Convert.ChangeType(value, targetType, culture);

            return true;
        }
        catch (Exception ex) when (ex is InvalidCastException or FormatException or OverflowException)
        {
            throw new InvalidOperationException(
                $"Automatic binding conversion from '{FormatTypeName(sourceType)}' to '{FormatTypeName(targetType)}' failed.",
                ex);
        }
    }

    private static bool RequiresTruncation(Type sourceType, Type targetType)
        => IsIntegralType(targetType) && (sourceType == typeof(float) || sourceType == typeof(double) || sourceType == typeof(decimal));

    private static object ConvertWithTruncation(object value, Type targetType)
    {
        return Type.GetTypeCode(targetType) switch
        {
            TypeCode.SByte => checked((sbyte)TruncateToDecimal(value)),
            TypeCode.Byte => checked((byte)TruncateToDecimal(value)),
            TypeCode.Int16 => checked((short)TruncateToDecimal(value)),
            TypeCode.UInt16 => checked((ushort)TruncateToDecimal(value)),
            TypeCode.Int32 => checked((int)TruncateToDecimal(value)),
            TypeCode.UInt32 => checked((uint)TruncateToDecimal(value)),
            TypeCode.Int64 => checked((long)TruncateToDecimal(value)),
            TypeCode.UInt64 => checked((ulong)TruncateToDecimal(value)),
            _ => throw new InvalidOperationException($"Automatic binding conversion to '{FormatTypeName(targetType)}' is not supported.")
        };
    }

    private static decimal TruncateToDecimal(object value)
    {
        return value switch
        {
            decimal decimalValue => decimal.Truncate(decimalValue),
            double doubleValue when !double.IsNaN(doubleValue) && !double.IsInfinity(doubleValue) => decimal.Truncate((decimal)doubleValue),
            float floatValue when !float.IsNaN(floatValue) && !float.IsInfinity(floatValue) => decimal.Truncate((decimal)floatValue),
            double => throw new InvalidOperationException("Automatic binding conversion from 'double' to an integral type requires a finite value."),
            float => throw new InvalidOperationException("Automatic binding conversion from 'float' to an integral type requires a finite value."),
            _ => throw new InvalidOperationException($"Automatic binding conversion from '{FormatTypeName(value.GetType())}' to an integral type is not supported.")
        };
    }

    private static bool IsNullableOrReferenceType(Type type)
        => !type.IsValueType || Nullable.GetUnderlyingType(type) is not null;

    private static bool IsPrimitiveConvertibleType(Type type)
        => Type.GetTypeCode(type) is not TypeCode.Empty and not TypeCode.Object and not TypeCode.DBNull and not TypeCode.DateTime;

    private static bool IsIntegralType(Type type)
        => Type.GetTypeCode(type) is TypeCode.SByte or TypeCode.Byte or TypeCode.Int16 or TypeCode.UInt16 or TypeCode.Int32 or TypeCode.UInt32 or TypeCode.Int64 or TypeCode.UInt64;

    private static string FormatTypeName(Type type)
        => type.FullName ?? type.Name;

    private readonly record struct ConverterCacheKey(Type SourceType, Type TargetType);

    private sealed class RuntimeBindingConverter : IValueConverter
    {
        private readonly Type _sourceType;
        private readonly Type _targetType;

        public RuntimeBindingConverter(Type sourceType, Type targetType)
        {
            _sourceType = sourceType;
            _targetType = targetType;
        }

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
            => ConvertValue(value, _targetType, culture);

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
            => ConvertValue(value, _sourceType, culture);
    }
}
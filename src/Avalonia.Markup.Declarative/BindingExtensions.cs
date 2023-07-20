using Avalonia.Data;
using Avalonia.Data.Converters;
using System;

namespace Avalonia.Markup.Declarative;

public static class BindingExtensions
{
    public static TBinding Converter<TBinding>(this TBinding binding, IValueConverter converter)
        where TBinding : Binding
    {
        binding.Converter = converter;
        return binding;
    }

}
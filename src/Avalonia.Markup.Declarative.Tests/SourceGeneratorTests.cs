using Avalonia.Markup.Declarative.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Linq;
using FluentAssertions;

namespace Avalonia.Markup.Declarative.Tests
{
    public class GeneratorTests
    {
        private static string? GetGeneratedOutput(string sourceCode)
        {
            var loadDll = typeof(AvaloniaObject);
            var loadDll1 = typeof(ComponentBase);

            var syntaxTree = CSharpSyntaxTree.ParseText(sourceCode);
            var references = AppDomain.CurrentDomain.GetAssemblies()
                                      .Where(assembly => !assembly.IsDynamic)
                                      .Select(assembly => MetadataReference.CreateFromFile(assembly.Location))
                                      .Cast<MetadataReference>();

            var compilation = CSharpCompilation.Create("SourceGeneratorTests",
                          new[] { syntaxTree },
                          references,
                          new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            // Source Generator to test
            var generator = new AvaloniaExtensionsGenerator();

            CSharpGeneratorDriver.Create(generator)
                                 .RunGeneratorsAndUpdateCompilation(compilation,
                                                                    out var outputCompilation,
                                                                    out var diagnostics);

            // optional
            diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error)
                       .Should().BeEmpty();

            var code = outputCompilation.SyntaxTrees.Skip(1).LastOrDefault()?.ToString();

            // remove // Auto-generated code <date/time>
            if (code != null)
            {
                var lines = code.Split([Environment.NewLine], StringSplitOptions.None);
                code = string.Join(Environment.NewLine, lines.Where(line => !line.TrimStart().StartsWith("// Auto-generated code")));
            }

            return code?.Trim();
        }

        [Fact]
        public void DirectProperty()
        {
            var inputSource = """
                using Avalonia.Markup.Declarative;
                using Avalonia;
                using Avalonia.Controls

                namespace Tests;

                public class TestClass : ViewBase
                {
                    private bool _canSave = default;

                    public static readonly DirectProperty<TestClass, bool> CanSaveProperty =
                        AvaloniaProperty.RegisterDirect<TestClass, bool>
                        (
                            nameof(CanSave),
                            o => o.CanSave
                        );

                    public bool CanSave
                    {
                        get => _canSave;
                        set => SetAndRaise(CanSaveProperty, ref _canSave, value);
                    }

                    protected override object Build()
                    {
                        return new TextBox();
                    }
                }
                """;

            var output = GetGeneratedOutput(inputSource);

            var expectedOutput = """
                #nullable enable
                using Avalonia.Data;
                using Avalonia.Data.Converters;
                using System;
                using System.Numerics;
                using System.Linq.Expressions;
                using System.Runtime.CompilerServices;

                namespace Avalonia.Markup.Declarative;

                public static partial class TestClass_MarkupExtensions
                {
                //================= Properties ======================//
                 // CanSave

                /*BindFromExpressionSetterGenerator*/
                public static T CanSave<T>(this T control, Func<bool> func, Action<bool>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CanSaveProperty, func, onChanged, expression);

                /*MagicalSetterGenerator*/
                public static T CanSave<T>(this T control,bool value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Tests.TestClass
                => control._setEx(Tests.TestClass.CanSaveProperty, ps, () => control.CanSave = value, bindingMode, converter, bindingSource);

                /*BindSetterGenerator*/
                public static T CanSave<T>(this T control, IBinding binding) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CanSaveProperty, binding);

                /*AvaloniaPropertyBindSetterGenerator*/
                public static T CanSave<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CanSaveProperty, avaloniaProperty, bindingMode, converter, overrideView);

                /*MagicalSetterWithConverterGenerator*/
                public static T CanSave<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, bool> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Tests.TestClass
                   => control._setEx(Tests.TestClass.CanSaveProperty, ps, () => control.CanSave = converter.TryConvert(value), bindingMode, converter, bindingSource);



                }
                """;

            output.Should().Be(expectedOutput);
        }

        [Fact]
        public void StyledProperty()
        {
            var inputSource = """
                using Avalonia.Markup.Declarative;
                using Avalonia;
                using Avalonia.Controls;

                namespace Tests;

                public class TestClass : ViewBase
                {
                    private bool _canSave = default;

                    public static readonly StyledProperty<TestClass, bool> CanSaveProperty =
                        AvaloniaProperty.RegisterStyled<TestClass, bool>
                        (
                            nameof(CanSave),
                            o => o.CanSave
                        );

                    public bool CanSave
                    {
                        get => _canSave;
                        set => SetAndRaise(CanSaveProperty, ref _canSave, value);
                    }

                    protected override object Build()
                    {
                        return new TextBox();
                    }
                }
                """;

            var output = GetGeneratedOutput(inputSource);

            var expectedOutput = """
                #nullable enable
                using Avalonia.Data;
                using Avalonia.Data.Converters;
                using System;
                using System.Numerics;
                using System.Linq.Expressions;
                using System.Runtime.CompilerServices;

                namespace Avalonia.Markup.Declarative;

                public static partial class TestClass_MarkupExtensions
                {
                //================= Properties ======================//
                 // CanSave

                /*BindFromExpressionSetterGenerator*/
                public static T CanSave<T>(this T control, Func<bool> func, Action<bool>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CanSaveProperty, func, onChanged, expression);

                /*MagicalSetterGenerator*/
                public static T CanSave<T>(this T control,bool value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Tests.TestClass
                => control._setEx(Tests.TestClass.CanSaveProperty, ps, () => control.CanSave = value, bindingMode, converter, bindingSource);

                /*BindSetterGenerator*/
                public static T CanSave<T>(this T control, IBinding binding) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CanSaveProperty, binding);

                /*AvaloniaPropertyBindSetterGenerator*/
                public static T CanSave<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CanSaveProperty, avaloniaProperty, bindingMode, converter, overrideView);

                /*MagicalSetterWithConverterGenerator*/
                public static T CanSave<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, bool> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Tests.TestClass
                   => control._setEx(Tests.TestClass.CanSaveProperty, ps, () => control.CanSave = converter.TryConvert(value), bindingMode, converter, bindingSource);



                //================= Styles ======================//
                 // CanSave

                /*ValueStyleSetterGenerator*/
                public static Style<T> CanSave<T>(this Style<T> style, bool value) where T : Tests.TestClass 
                => style._addSetter(Tests.TestClass.CanSaveProperty, value);

                /*BindingStyleSetterGenerator*/
                public static Style<T> CanSave<T>(this Style<T> style, IBinding binding) where T : Tests.TestClass 
                => style._addSetter(Tests.TestClass.CanSaveProperty, binding);



                }
                """;

            output.Should().Be(expectedOutput);
        }

        [Fact]
        public void AttachedProperty()
        {
            var inputSource = """
                using Avalonia.Markup.Declarative;
                using Avalonia;
                using Avalonia.Controls;

                namespace Tests;

                public class TestClass : ViewBase
                {
                public static readonly AttachedProperty<ICommand> CommandProperty = AvaloniaProperty.RegisterAttached<TestClass, Interactive, ICommand>(
                "Command", default(ICommand), false, BindingMode.OneTime);

                public static void SetCommand(AvaloniaObject element, ICommand commandValue)
                {

                }

                    protected override object Build()
                    {
                        return new TextBox();
                    }
                }
                """;

            var output = GetGeneratedOutput(inputSource);

            var expectedOutput = """
                #nullable enable
                using Avalonia.Data;
                using Avalonia.Data.Converters;
                using System;
                using System.Numerics;
                using System.Linq.Expressions;
                using System.Runtime.CompilerServices;

                namespace Avalonia.Markup.Declarative;

                public static partial class TestClass_MarkupExtensions
                {
                //================= Properties ======================//
                 // Command

                /*BindFromExpressionSetterGenerator*/
                public static T Command<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CommandProperty, func, onChanged, expression);

                /*MagicalSetterGenerator*/
                public static T Command<T>(this T control,ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Tests.TestClass
                => control._setEx(Tests.TestClass.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);

                /*BindSetterGenerator*/
                public static T Command<T>(this T control, IBinding binding) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CommandProperty, binding);

                /*AvaloniaPropertyBindSetterGenerator*/
                public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

                /*MagicalSetterWithConverterGenerator*/
                public static T Command<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Tests.TestClass
                   => control._setEx(Tests.TestClass.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);



                }
                """;

            output.Should().Be(expectedOutput);
        }

        [Fact]
        public void AvaloniaProperty()
        {
            var inputSource = """
                using Avalonia.Markup.Declarative;
                using Avalonia;
                using Avalonia.Controls;

                namespace Tests;

                public class TestClass : ViewBase
                {
                public static readonly StyledProperty<int> RepeatCountProperty =
                    AvaloniaProperty.Register<TestClass, int>(nameof(RepeatCount), defaultValue: 1);

                public int RepeatCount
                {
                    get => GetValue(RepeatCountProperty);
                    set => SetValue(RepeatCountProperty, value);
                }

                    protected override object Build()
                    {
                        return new TextBox();
                    }
                }
                """;

            var output = GetGeneratedOutput(inputSource);

            var expectedOutput = """
                #nullable enable
                using Avalonia.Data;
                using Avalonia.Data.Converters;
                using System;
                using System.Numerics;
                using System.Linq.Expressions;
                using System.Runtime.CompilerServices;

                namespace Avalonia.Markup.Declarative;

                public static partial class TestClass_MarkupExtensions
                {
                //================= Properties ======================//
                 // RepeatCount

                /*BindFromExpressionSetterGenerator*/
                public static T RepeatCount<T>(this T control, Func<int> func, Action<int>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Tests.TestClass
                   => control._set(Tests.TestClass.RepeatCountProperty, func, onChanged, expression);

                /*MagicalSetterGenerator*/
                public static T RepeatCount<T>(this T control,int value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Tests.TestClass
                => control._setEx(Tests.TestClass.RepeatCountProperty, ps, () => control.RepeatCount = value, bindingMode, converter, bindingSource);

                /*BindSetterGenerator*/
                public static T RepeatCount<T>(this T control, IBinding binding) where T : Tests.TestClass
                   => control._set(Tests.TestClass.RepeatCountProperty, binding);

                /*AvaloniaPropertyBindSetterGenerator*/
                public static T RepeatCount<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Tests.TestClass
                   => control._set(Tests.TestClass.RepeatCountProperty, avaloniaProperty, bindingMode, converter, overrideView);

                /*MagicalSetterWithConverterGenerator*/
                public static T RepeatCount<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, int> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Tests.TestClass
                   => control._setEx(Tests.TestClass.RepeatCountProperty, ps, () => control.RepeatCount = converter.TryConvert(value), bindingMode, converter, bindingSource);



                //================= Styles ======================//
                 // RepeatCount

                /*ValueStyleSetterGenerator*/
                public static Style<T> RepeatCount<T>(this Style<T> style, int value) where T : Tests.TestClass 
                => style._addSetter(Tests.TestClass.RepeatCountProperty, value);

                /*BindingStyleSetterGenerator*/
                public static Style<T> RepeatCount<T>(this Style<T> style, IBinding binding) where T : Tests.TestClass 
                => style._addSetter(Tests.TestClass.RepeatCountProperty, binding);



                }
                """;

            output.Should().Be(expectedOutput);
        }

        [Fact]
        public void ArrayValue()
        {
            var inputSource = """
                using Avalonia.Markup.Declarative;
                using Avalonia;
                using Avalonia.Controls

                namespace Tests;

                public class TestClass : ViewBase
                {
                    private bool[] _canSave = default;

                    public static readonly DirectProperty<TestClass, bool[]> CanSaveProperty =
                        AvaloniaProperty.RegisterDirect<TestClass, bool[]>
                        (
                            nameof(CanSave),
                            o => o.CanSave
                        );

                    public bool[] CanSave
                    {
                        get => _canSave;
                        set => SetAndRaise(CanSaveProperty, ref _canSave, value);
                    }

                    protected override object Build()
                    {
                        return new TextBox();
                    }
                }
                """;

            var output = GetGeneratedOutput(inputSource);

            var expectedOutput = """
                #nullable enable
                using Avalonia.Data;
                using Avalonia.Data.Converters;
                using System;
                using System.Numerics;
                using System.Linq.Expressions;
                using System.Runtime.CompilerServices;

                namespace Avalonia.Markup.Declarative;

                public static partial class TestClass_MarkupExtensions
                {
                //================= Properties ======================//
                 // CanSave

                /*BindFromExpressionSetterGenerator*/
                public static T CanSave<T>(this T control, Func<bool[]> func, Action<bool[]>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CanSaveProperty, func, onChanged, expression);

                /*MagicalSetterGenerator*/
                public static T CanSave<T>(this T control,bool[] value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Tests.TestClass
                => control._setEx(Tests.TestClass.CanSaveProperty, ps, () => control.CanSave = value, bindingMode, converter, bindingSource);

                /*BindSetterGenerator*/
                public static T CanSave<T>(this T control, IBinding binding) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CanSaveProperty, binding);

                /*AvaloniaPropertyBindSetterGenerator*/
                public static T CanSave<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Tests.TestClass
                   => control._set(Tests.TestClass.CanSaveProperty, avaloniaProperty, bindingMode, converter, overrideView);

                /*MagicalSetterWithConverterGenerator*/
                public static T CanSave<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, bool[]> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Tests.TestClass
                   => control._setEx(Tests.TestClass.CanSaveProperty, ps, () => control.CanSave = converter.TryConvert(value), bindingMode, converter, bindingSource);



                }
                """;

            output.Should().Be(expectedOutput);
        }

        [Fact]
        public void ReadOnlyDirectProperty()
        {
            var inputSource = """
                using Avalonia.Markup.Declarative;
                using Avalonia;
                using Avalonia.Controls;

                namespace Tests;

                public class TestClass : ViewBase
                {
                    private bool _canSave = default;

                    public static readonly DirectProperty<TestClass, bool> CanSaveProperty =
                        AvaloniaProperty.RegisterDirect<TestClass, bool>
                        (
                            nameof(CanSave),
                            o => o.CanSave
                        );

                    public bool CanSave
                    {
                        get => _canSave;
                        private set => SetAndRaise(CanSaveProperty, ref _canSave, value);
                    }

                    protected override object Build()
                    {
                        return new TextBox();
                    }
                }
                """;

            var output = GetGeneratedOutput(inputSource);

            output.Should().BeNull();
        }

        [Fact]
        public void CommonProperty()
        {
            var inputSource = """
                using Avalonia.Markup.Declarative;
                using Avalonia;
                using Avalonia.Controls

                namespace Tests;

                public class Component : ComponentBase
                {
                    protected override object Build() =>
                        new StackPanel()
                            .Children(
                                new TextBlock()
                                    .Text("This is nested MVU Component"),

                                new TextBlock()
                                    .Text(Bind(InnerContent))
                            );

                    public string InnerContent { get; set; } = "Parameter value";
                }
                """;

            var output = GetGeneratedOutput(inputSource);

            var expectedOutput = """
                #nullable enable
                using Avalonia.Data;
                using Avalonia.Data.Converters;
                using System;
                using System.Numerics;
                using System.Linq.Expressions;
                using System.Runtime.CompilerServices;

                namespace Avalonia.Markup.Declarative;

                public static partial class Component_MarkupExtensions
                {
                //================= Common Properties ======================//
                 // InnerContent

                /*CommonPropertySetterExtension*/
                public static Tests.Component InnerContent(this Tests.Component control, string value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)
                   => control._setCommonEx(ps, () => control.InnerContent = value, bindingMode, converter, bindingSource);



                }
                """;

            output.Should().Be(expectedOutput);
        }
    }
}

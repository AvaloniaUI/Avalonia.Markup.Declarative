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
using System;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System.Runtime.CompilerServices;
using Tests;
namespace Avalonia.Markup.Declarative;
public static partial class TestClassExtensions
{
//Avalonia Properties

public static TestClass CanSave(this TestClass control, Tests.TestClass value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)=>
 control._setEx(TestClass.CanSaveProperty, ps, () => control.CanSave = value, bindingMode, converter, bindingSource);
public static TestClass CanSave(this TestClass control, Func<Tests.TestClass> func, Action<Tests.TestClass>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)
   => control._set(TestClass.CanSaveProperty, func, onChanged, expression);
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
using System;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System.Runtime.CompilerServices;
using Tests;
namespace Avalonia.Markup.Declarative;
public static partial class TestClassExtensions
{
//Avalonia Properties

public static TestClass CanSave(this TestClass control, Tests.TestClass value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)=>
 control._setEx(TestClass.CanSaveProperty, ps, () => control.CanSave = value, bindingMode, converter, bindingSource);
public static TestClass CanSave(this TestClass control, Func<Tests.TestClass> func, Action<Tests.TestClass>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)
   => control._set(TestClass.CanSaveProperty, func, onChanged, expression);
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

    protected override object Build()
    {
        return new TextBox();
    }
}
""";
            var output = GetGeneratedOutput(inputSource);

            var expectedOutput = """
test
""";

            //todo fix test
            output.Should().BeNull();
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
using System;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System.Runtime.CompilerServices;
using Tests;
namespace Avalonia.Markup.Declarative;
public static partial class TestClassExtensions
{
//Avalonia Properties

public static TestClass RepeatCount(this TestClass control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)=>
 control._setEx(TestClass.RepeatCountProperty, ps, () => control.RepeatCount = value, bindingMode, converter, bindingSource);
public static TestClass RepeatCount(this TestClass control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)
   => control._set(TestClass.RepeatCountProperty, func, onChanged, expression);
}
""";

            //todo fix test
            output.Should().BeNull();
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
    }
}

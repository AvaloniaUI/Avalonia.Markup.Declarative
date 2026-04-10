using System.Collections.Immutable;
using System.Text;
using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators;

[Generator]
public sealed class ExternalAssemblyExtensionsGenerator : IIncrementalGenerator
{
    private static readonly ExternalGeneratorHost GeneratorHost = new();

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var generationTargets = context.CompilationProvider
            .SelectMany(static (compilation, _) => GetGenerationTargets(compilation))
            .WithComparer(ExternalGenerationTargetComparer.Instance);

        context.RegisterSourceOutput(generationTargets, static (spc, target) =>
        {
            try
            {
                var code = GeneratorHost.GenerateExtensions(target.TypeSymbol);
                if (string.IsNullOrWhiteSpace(code))
                {
                    return;
                }

                spc.AddSource(target.HintName, SourceText.From(code!, Encoding.UTF8));
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        });
    }

    private static ImmutableArray<ExternalGenerationTarget> GetGenerationTargets(Compilation compilation) =>
        [..
            SymbolUtilities.GetTargetAssemblies(compilation)
                .SelectMany(static assembly => SymbolUtilities.GetPublicClasses(assembly.GlobalNamespace))
                .Where(static publicClass => publicClass.IsOrInheritsFrom("Avalonia.AvaloniaObject"))
                .Select(static publicClass => ExternalGenerationTarget.Create(publicClass))
                .OrderBy(static target => target.HintName, StringComparer.Ordinal)
        ];

    private readonly struct ExternalGenerationTarget
    {
        public ExternalGenerationTarget(INamedTypeSymbol typeSymbol, string hintName, string signature)
        {
            TypeSymbol = typeSymbol;
            HintName = hintName;
            Signature = signature;
        }

        public INamedTypeSymbol TypeSymbol { get; }

        public string HintName { get; }

        public string Signature { get; }

        public static ExternalGenerationTarget Create(INamedTypeSymbol typeSymbol)
        {
            var hintName = $"External_{SymbolUtilities.RemoveIllegalFileNameCharacters(typeSymbol.ToDisplayString())}.g.cs";
            var signature = CreateSignature(typeSymbol);

            return new ExternalGenerationTarget(typeSymbol, hintName, signature);
        }
    }

    private sealed class ExternalGenerationTargetComparer : IEqualityComparer<ExternalGenerationTarget>
    {
        internal static readonly ExternalGenerationTargetComparer Instance = new();

        public bool Equals(ExternalGenerationTarget x, ExternalGenerationTarget y) =>
            StringComparer.Ordinal.Equals(x.HintName, y.HintName) &&
            StringComparer.Ordinal.Equals(x.Signature, y.Signature);

        public int GetHashCode(ExternalGenerationTarget obj)
        {
            unchecked
            {
                return (StringComparer.Ordinal.GetHashCode(obj.HintName) * 397) ^
                    StringComparer.Ordinal.GetHashCode(obj.Signature);
            }
        }
    }

    private static string CreateSignature(INamedTypeSymbol typeSymbol)
    {
        var signature = new StringBuilder(1024);
        AppendSignaturePart(signature, typeSymbol.ContainingAssembly.Identity.ToString());
        AppendSignaturePart(signature, typeSymbol.GetFullTypeName());
        AppendSignaturePart(signature, SymbolUtilities.BuildExtensionClassName(typeSymbol));
        AppendSignaturePart(signature, typeSymbol.IsSealed ? "sealed" : "open");

        foreach (var info in ExternalGeneratorHost.GetPropertyInfos(typeSymbol)
                     .OrderBy(static x => x.ExtensionName, StringComparer.Ordinal)
                     .ThenBy(static x => x.FieldSymbol.Name, StringComparer.Ordinal))
        {
            AppendPropertyInfoSignature(signature, "property", info);
        }

        foreach (var info in ExternalGeneratorHost.GetAttachedPropertyInfos(typeSymbol)
                     .OrderBy(static x => x.ExtensionName, StringComparer.Ordinal)
                     .ThenBy(static x => x.FieldSymbol.Name, StringComparer.Ordinal))
        {
            AppendPropertyInfoSignature(signature, "attached", info);
            AppendSignaturePart(signature, info.AttachedPropertyHostTypeName);
        }

        foreach (var info in ExternalGeneratorHost.GetEventInfos(typeSymbol)
                     .OrderBy(static x => x.EventName, StringComparer.Ordinal))
        {
            AppendEventInfoSignature(signature, info);
        }

        foreach (var info in ExternalGeneratorHost.GetStyleInfos(typeSymbol)
                     .OrderBy(static x => x.ExtensionName, StringComparer.Ordinal)
                     .ThenBy(static x => x.FieldSymbol.Name, StringComparer.Ordinal))
        {
            AppendPropertyInfoSignature(signature, "style", info);
        }

        return signature.ToString();
    }

    private static void AppendPropertyInfoSignature(StringBuilder signature, string groupName, PropertyExtensionInfo info)
    {
        AppendSignaturePart(signature, groupName);
        AppendSignaturePart(signature, info.ControlTypeName);
        AppendSignaturePart(signature, info.ExtensionName);
        AppendSignaturePart(signature, info.MemberName);
        AppendSignaturePart(signature, info.ValueTypeSource);
        AppendSignaturePart(signature, info.ReturnType);
        AppendSignaturePart(signature, info.GenericConstraint);
        AppendSignaturePart(signature, info.StyleGenericConstraint);
        AppendSignaturePart(signature, info.GenericArg);
        AppendSignaturePart(signature, info.FieldSymbol.Name);
        AppendValueTypeSignature(signature, info.ValueType);
    }

    private static void AppendEventInfoSignature(StringBuilder signature, EventExtensionInfo info)
    {
        AppendSignaturePart(signature, "event");
        AppendSignaturePart(signature, info.ControlTypeName);
        AppendSignaturePart(signature, info.EventName);
        AppendSignaturePart(signature, info.EventHandler);
        AppendSignaturePart(signature, info.ReturnType);
        AppendSignaturePart(signature, info.GenericConstraint);
        AppendSignaturePart(signature, info.GenericArg);
        AppendSignaturePart(signature, info.IsRoutedEvent ? "routed" : "plain");
        AppendSignaturePart(signature, info.IsObsolete ? "obsolete" : "active");
        AppendSignaturePart(signature, info.ReturnsVoid ? "void" : "nonvoid");

        foreach (var parameterType in info.EventParameterTypes)
        {
            AppendSignaturePart(signature, parameterType);
        }
    }

    private static void AppendValueTypeSignature(StringBuilder signature, ITypeSymbol valueType)
    {
        AppendSignaturePart(signature, valueType.GetFullTypeName());

        if (!valueType.IsValueType ||
            valueType.ContainingNamespace.ToDisplayString().StartsWith("System", StringComparison.Ordinal))
        {
            return;
        }

        foreach (var constructor in valueType.GetMembers()
                     .OfType<IMethodSymbol>()
                     .Where(static x => x.MethodKind == MethodKind.Constructor && x.Parameters.Length > 0)
                     .OrderBy(static x => x.ToDisplayString(), StringComparer.Ordinal))
        {
            AppendSignaturePart(signature, "ctor");

            foreach (var parameter in constructor.Parameters)
            {
                AppendSignaturePart(signature, parameter.Type.GetFullTypeName());
                AppendSignaturePart(signature, parameter.Name);
            }
        }
    }

    private static void AppendSignaturePart(StringBuilder signature, string? value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            signature.Append(value);
        }

        signature.Append('\u001F');
    }
}

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Diagnostics;
using System.Text;
using static Avalonia.Markup.Declarative.SourceGenerator.MarkupTypeHelpers;

namespace Avalonia.Markup.Declarative.SourceGenerator.InternalGenerators;

[Generator]
public class AvaloniaPropertyExtensionsGenerator : IIncrementalGenerator
{

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
#if DEBUG
        if (!Debugger.IsAttached)
        {
            //Debugger.Launch();
        }
#endif
        Debug.WriteLine("Initialize AvaloniaPropertyExtensionsGenerator code generator");

        var classDeclarations = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: static (s, _) => s is ClassDeclarationSyntax,
                transform: static (ctx, _) => GetSemanticTarget(ctx))
            .Where(static c => c is not null)
            .Select(static (c, _) => c!.Value)
            .WithComparer(PropertyGenerationTargetComparer.Instance);

        context.RegisterSourceOutput(classDeclarations,
            static (spc, target) => GenerateSource(spc, target));
    }

    private static PropertyGenerationTarget? GetSemanticTarget(GeneratorSyntaxContext context)
    {
        var classDecl = (ClassDeclarationSyntax)context.Node;
        var symbol = context.SemanticModel.GetDeclaredSymbol(classDecl);
        
        // Check if this class or any of its base types implements IDeclarativeViewBase
        return symbol is INamedTypeSymbol typeSymbol &&
               ImplementsIDeclarativeViewBase(typeSymbol)
            ? PropertyGenerationTarget.Create(classDecl, context.SemanticModel, typeSymbol)
            : null;
    }

    private static bool ImplementsIDeclarativeViewBase(INamedTypeSymbol typeSymbol)
    {
        // Check direct interfaces
        if (typeSymbol.AllInterfaces.Any(x => x.Name == "IDeclarativeViewBase"))
            return true;

        // Check base types (for inheritance)
        var current = typeSymbol.BaseType;
        while (current != null)
        {
            if (current.AllInterfaces.Any(x => x.Name == "IDeclarativeViewBase"))
                return true;
            current = current.BaseType;
        }

        return false;
    }

    private static void GenerateSource(SourceProductionContext context, PropertyGenerationTarget target)
    {
        var type = target.Syntax;
        var semanticModel = target.SemanticModel;
        var root = type.SyntaxTree.GetRoot();
        var ns = root.DescendantNodes()
            .FirstOrDefault(x => x is BaseNamespaceDeclarationSyntax) as BaseNamespaceDeclarationSyntax;

        var typeNamespace = ns?.Name.ToString() ?? string.Empty;
        var sb = new StringBuilder(4096);

        sb.AppendLine("#nullable enable");
        sb.AppendLine("// Auto-generated code");
        sb.AppendLine("using System;");
        sb.AppendLine("using Avalonia.Data;");
        sb.AppendLine("using Avalonia.Data.Converters;");
        sb.AppendLine("using System.Linq.Expressions;");

        if (root is CompilationUnitSyntax compilationUnit)
        {
            foreach (var usingDirective in compilationUnit.Usings)
            {
                sb.AppendLine(usingDirective.ToString());
            }
        }

        if (!string.IsNullOrWhiteSpace(typeNamespace))
            sb.AppendLine($"using {typeNamespace};");

        // Build the extension class name - handle nested classes properly
        var extensionClassName = target.ExtensionClassName;
        
        // Fully qualified control type name including namespace, containing types and type parameters
        var controlTypeQualified = GetControlTypeQualifiedName(target.TypeSymbol);

        // Build method generic parameters for all containing type parameters (outermost -> innermost)
        string allTypeParamsForMethods = BuildAllTypeParameters(type);

        sb.AppendLine("namespace Avalonia.Markup.Declarative;");
        sb.AppendLine($"public static partial class {extensionClassName}Extensions");
        sb.AppendLine("{");

        var members = type.Members;
        var processedFields = new HashSet<string>(StringComparer.Ordinal);

        // PROCESS AVALONIA PROPERTIES
        foreach (var field in members.OfType<FieldDeclarationSyntax>())
        {
            if (field.Declaration.Type is GenericNameSyntax { Identifier.ValueText: "DirectProperty" or "StyledProperty" or "AttachedProperty" }
                && HasAvaloniaPropertyPublicSetter(field, members))
            {
                sb.AppendLine($"// avalonia properties\n");
                AppendIfNotNull(sb, GetPropertySetterExtension(controlTypeQualified, allTypeParamsForMethods, field));
                AppendIfNotNull(sb, GetExpressionBindingSetterExtension(controlTypeQualified, allTypeParamsForMethods, field));
                processedFields.Add(field.Declaration.Variables[0].Identifier.ValueText);
            }
        }

        // PROCESS COMMON PROPERTIES
        foreach (var property in members.OfType<PropertyDeclarationSyntax>())
        {
            var propertyName = property.Identifier.ToString();
            if (!processedFields.Contains(propertyName + "Property")
                && IsPublic(property)
                && HasPublicSetter(property)
                && IsCommonInstanceProperty(property, members))
            {
                sb.AppendLine($"// common properties\n");

                AppendIfNotNull(sb, GetCommonPropertySetterExtension(controlTypeQualified, property, semanticModel));
                // AppendIfNotNull(sb, GetCommonPropertyBindingSetterExtension(controlTypeQualified, property, semanticModel));
                AppendIfNotNull(sb, GetCommonPropertyExpressionBindingSetterExtension(controlTypeQualified, property, semanticModel));

                processedFields.Add(propertyName);
            }
        }

        sb.AppendLine("}");

        if (processedFields.Count > 0)
        {
            context.AddSource(target.HintName, SourceText.From(sb.ToString(), Encoding.UTF8));
        }
    }

    private readonly struct PropertyGenerationTarget
    {
        public PropertyGenerationTarget(
            ClassDeclarationSyntax syntax,
            SemanticModel semanticModel,
            INamedTypeSymbol typeSymbol,
            string extensionClassName,
            string hintName,
            string signature)
        {
            Syntax = syntax;
            SemanticModel = semanticModel;
            TypeSymbol = typeSymbol;
            ExtensionClassName = extensionClassName;
            HintName = hintName;
            Signature = signature;
        }

        public ClassDeclarationSyntax Syntax { get; }

        public SemanticModel SemanticModel { get; }

        public INamedTypeSymbol TypeSymbol { get; }

        public string ExtensionClassName { get; }

        public string HintName { get; }

        public string Signature { get; }

        public static PropertyGenerationTarget Create(ClassDeclarationSyntax syntax, SemanticModel semanticModel, INamedTypeSymbol typeSymbol)
        {
            var extensionClassName = BuildExtensionClassName(typeSymbol);
            var hintName = SymbolUtilities.RemoveIllegalFileNameCharacters(extensionClassName) + "Extensions.g.cs";
            var signature = CreateSignature(syntax, semanticModel, typeSymbol);

            return new PropertyGenerationTarget(syntax, semanticModel, typeSymbol, extensionClassName, hintName, signature);
        }
    }

    private sealed class PropertyGenerationTargetComparer : IEqualityComparer<PropertyGenerationTarget>
    {
        internal static readonly PropertyGenerationTargetComparer Instance = new();

        public bool Equals(PropertyGenerationTarget x, PropertyGenerationTarget y) =>
            StringComparer.Ordinal.Equals(x.HintName, y.HintName) &&
            StringComparer.Ordinal.Equals(x.Signature, y.Signature);

        public int GetHashCode(PropertyGenerationTarget obj)
        {
            unchecked
            {
                return (StringComparer.Ordinal.GetHashCode(obj.HintName) * 397) ^
                    StringComparer.Ordinal.GetHashCode(obj.Signature);
            }
        }
    }

    private static string BuildExtensionClassName(INamedTypeSymbol? typeSymbol)
    {
        if (typeSymbol == null)
            return "Unknown";

        var parts = new List<string>();
        
        // Build from innermost to outermost
        var current = typeSymbol;
        while (current != null)
        {
            var name = current.Name;
            if (current.TypeParameters.Length > 0)
            {
                name += $"`{current.TypeParameters.Length}";
            }
            parts.Insert(0, name);
            
            current = current.ContainingType;
        }
        
        return CleanIdentifier(string.Join("_", parts)) ?? "Unknown";
    }

    private static string BuildAllTypeParameters(ClassDeclarationSyntax type)
    {
        var stack = new Stack<string>();
        SyntaxNode? current = type;
        while (current is ClassDeclarationSyntax cds)
        {
            if (cds.TypeParameterList is { Parameters.Count: > 0 })
            {
                // Push in reverse so that when we read Stack.ToArray() we keep original order per containing type
                foreach (var p in cds.TypeParameterList.Parameters.Reverse())
                {
                    stack.Push(p.Identifier.Text);
                }
            }
            current = current.Parent;
            if (current is BaseNamespaceDeclarationSyntax)
                break;
        }

        if (stack.Count == 0)
            return string.Empty;

        var arr = stack.ToArray(); // outermost -> innermost order
        return $"<{string.Join(", ", arr)}>";
    }

    private static string GetControlTypeQualifiedName(INamedTypeSymbol typeSymbol) =>
        typeSymbol.ToDisplayString(
            SymbolDisplayFormat.FullyQualifiedFormat
                .WithGenericsOptions(SymbolDisplayGenericsOptions.IncludeTypeParameters | SymbolDisplayGenericsOptions.IncludeVariance)
                .WithMiscellaneousOptions(SymbolDisplayMiscellaneousOptions.UseSpecialTypes | SymbolDisplayMiscellaneousOptions.ExpandNullable));

    private static string CreateSignature(ClassDeclarationSyntax type, SemanticModel semanticModel, INamedTypeSymbol typeSymbol)
    {
        var signature = new StringBuilder(1024);
        AppendSignaturePart(signature, GetControlTypeQualifiedName(typeSymbol));
        AppendSignaturePart(signature, typeSymbol.ContainingNamespace?.ToDisplayString());

        if (type.SyntaxTree.GetRoot() is CompilationUnitSyntax compilationUnit)
        {
            foreach (var usingDirective in compilationUnit.Usings)
            {
                AppendSyntaxFingerprint(signature, usingDirective);
            }
        }

        AppendSyntaxFingerprint(signature, type.Modifiers);
        AppendSyntaxFingerprint(signature, type.TypeParameterList);
        foreach (var constraintClause in type.ConstraintClauses)
        {
            AppendSyntaxFingerprint(signature, constraintClause);
        }

        var members = type.Members;
        var processedFields = new HashSet<string>(StringComparer.Ordinal);

        foreach (var field in members.OfType<FieldDeclarationSyntax>())
        {
            if (field.Declaration.Type is GenericNameSyntax { Identifier.ValueText: "DirectProperty" or "StyledProperty" or "AttachedProperty" }
                && HasAvaloniaPropertyPublicSetter(field, members))
            {
                AppendFieldSignature(signature, field, semanticModel);
                processedFields.Add(field.Declaration.Variables[0].Identifier.ValueText);
            }
        }

        foreach (var property in members.OfType<PropertyDeclarationSyntax>())
        {
            var propertyName = property.Identifier.ValueText;
            if (!processedFields.Contains(propertyName + "Property")
                && IsPublic(property)
                && HasPublicSetter(property)
                && IsCommonInstanceProperty(property, members))
            {
                AppendPropertySignature(signature, property, semanticModel);
                processedFields.Add(propertyName);
            }
        }

        return signature.ToString();
    }

    private static void AppendFieldSignature(StringBuilder signature, FieldDeclarationSyntax field, SemanticModel semanticModel)
    {
        AppendSignaturePart(signature, "field");
        AppendSyntaxFingerprint(signature, field.Modifiers);
        AppendSyntaxFingerprint(signature, field.Declaration.Type);

        foreach (var variable in field.Declaration.Variables)
        {
            AppendSignaturePart(signature, variable.Identifier.ValueText);

            if (semanticModel.GetDeclaredSymbol(variable) is IFieldSymbol fieldSymbol)
            {
                AppendSignaturePart(signature, fieldSymbol.Type.GetFullTypeName());
                AppendSignaturePart(signature, fieldSymbol.Type.GetLastGenericArgument().GetFullTypeName());
            }
        }
    }

    private static void AppendPropertySignature(StringBuilder signature, PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        AppendSignaturePart(signature, "property");
        AppendSyntaxFingerprint(signature, property.Modifiers);
        AppendSyntaxFingerprint(signature, property.Type);
        AppendSignaturePart(signature, property.Identifier.ValueText);

        if (property.AccessorList is { } accessorList)
        {
            foreach (var accessor in accessorList.Accessors)
            {
                AppendSignaturePart(signature, accessor.Keyword.ValueText);
                AppendSyntaxFingerprint(signature, accessor.Modifiers);
            }
        }

        if (property.ExpressionBody is not null)
        {
            AppendSignaturePart(signature, "expr");
        }

        if (semanticModel.GetDeclaredSymbol(property) is IPropertySymbol propertySymbol)
        {
            AppendSignaturePart(signature, propertySymbol.Type.GetFullTypeName());
        }
    }

    private static void AppendSyntaxFingerprint(StringBuilder signature, SyntaxNode? node)
    {
        if (node is null)
        {
            signature.Append('\u001E');
            return;
        }

        signature.Append(node.RawKind);
        signature.Append('\u001F');

        foreach (var token in node.DescendantTokens(descendIntoTrivia: false))
        {
            signature.Append(token.Text);
            signature.Append('\u001F');
        }

        signature.Append('\u001E');
    }

    private static void AppendSyntaxFingerprint(StringBuilder signature, SyntaxTokenList tokens)
    {
        foreach (var token in tokens)
        {
            signature.Append(token.Text);
            signature.Append('\u001F');
        }

        signature.Append('\u001E');
    }

    private static void AppendSignaturePart(StringBuilder signature, string? value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            signature.Append(value);
        }

        signature.Append('\u001F');
    }

    private static string? CleanIdentifier(string name, bool @namespace = false)
    {
        // trim off leading and trailing whitespace
        name = name.Trim();

        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        var sb = new StringBuilder();
        if (!SyntaxFacts.IsIdentifierStartCharacter(name[0]))
        {
            // the first characters
            sb.Append('_');
        }

        foreach (var ch in name)
        {
            if (SyntaxFacts.IsIdentifierPartCharacter(ch) || (@namespace && ch == '.'))
            {
                sb.Append(ch);
            }
        }

        var result = sb.ToString();

        if (SyntaxFacts.GetKeywordKind(result) != SyntaxKind.None)
        {
            result = '@' + result;
        }

        if (@namespace)
        {
            var newResult = string.Empty;
            foreach (var chunk in result.Split('.'))
            {
                if (!string.IsNullOrEmpty(newResult))
                {
                    newResult += '.';
                }

                if (SyntaxFacts.GetKeywordKind(chunk) != SyntaxKind.None)
                {
                    newResult += '@' + chunk;
                }
                else
                {
                    newResult += chunk;
                }
            }

            return newResult;
        }

        return result;
    }

    private static void AppendIfNotNull(StringBuilder sb, string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return;
        sb.AppendLine(value);
    }

    public static string GetPropertySetterExtension(string controlTypeName, string genericParamsAll, FieldDeclarationSyntax field)
    {
        var extensionName = field.Declaration.Variables[0].Identifier.ToString().Replace("Property", "");

        var genericName = field.Declaration.Type as GenericNameSyntax;
        if (genericName == null)
            return string.Empty;

        var valueTypeSource = genericName.TypeArgumentList.Arguments.Last();

        var valueName = valueTypeSource is NullableTypeSyntax nullableTypeSyntax
            ? nullableTypeSyntax.ElementType.ToString()
            : valueTypeSource.ToString();

        // Get Class constraints
        var classConstraint = "";
        if (field.Parent is ClassDeclarationSyntax classDecleration)
        {
            foreach (TypeParameterConstraintClauseSyntax constraintClause in classDecleration.ConstraintClauses)
            {
                if (constraintClause.Name.ToString() == valueName)
                {
                    classConstraint = " " + constraintClause.ToString();
                }
            }
        }

        var extensionText =
            $"public static {controlTypeName} {extensionName}{genericParamsAll}" +
            $"(this {controlTypeName} control, {valueTypeSource} value){classConstraint}{NewLine}" +
            $"=> control._set(() => control.{extensionName} = value!);";

        return extensionText;
    }

    private static string GetCommonPropertySetterExtension(string controlTypeName, PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        var extensionName = property.Identifier.ToString();

        var valueTypeSource = GetPropertyTypeName(property, semanticModel);

        var extensionText =
            $"public static {controlTypeName} {extensionName}" +
            $"(this {controlTypeName} control, {valueTypeSource} value)" +
            $"=>{NewLine} control._set(() => control.{extensionName} = value);";

        return extensionText;
    }

    // private static string GetCommonPropertyBindingSetterExtension(string controlTypeName, PropertyDeclarationSyntax property, SemanticModel semanticModel)
    // {
    //     var extensionName = property.Identifier.ToString();
    //     var valueTypeSource = GetPropertyTypeName(property, semanticModel);

    //     var extensionText =
    //         $"#pragma warning disable CS8601{NewLine}" +
    //         $"[Obsolete] public static {controlTypeName} {extensionName}" +
    //         $"(this {controlTypeName} control, IBinding binding)" +
    //         $"=>{NewLine} control._setCommonBindingEx(({valueTypeSource}? v) => control.{extensionName} = v ?? default({valueTypeSource}), binding);{NewLine}" +
    //         $"#pragma warning restore CS8601";

    //     return extensionText;
    // }
    public static string GetExpressionBindingSetterExtension(string controlTypeName, string genericParamsAll, FieldDeclarationSyntax field)
    {
        var extensionName = field.Declaration.Variables[0].Identifier.ToString().Replace("Property", "");

        var genericName = field.Declaration.Type as GenericNameSyntax;
        if (genericName == null)
            return string.Empty;

        var valueTypeSource = genericName.TypeArgumentList.Arguments.Last();

        var valueName = valueTypeSource is NullableTypeSyntax nullableTypeSyntax
            ? nullableTypeSyntax.ElementType.ToString()
            : valueTypeSource.ToString();

        // Get Class constraints
        var classConstraint = "";
        if (field.Parent is ClassDeclarationSyntax classDecleration)
        {
            foreach (TypeParameterConstraintClauseSyntax constraintClause in classDecleration.ConstraintClauses)
            {
                if (constraintClause.Name.ToString() == valueName)
                {
                    classConstraint = " " + constraintClause.ToString();
                }
            }
        }

        // Check if TViewModel already exists as a type parameter (e.g. ReactiveViewBase<TViewModel>)
        var existingParams = string.IsNullOrEmpty(genericParamsAll) 
            ? Array.Empty<string>() 
            : genericParamsAll.Trim('<', '>').Split(',').Select(p => p.Trim()).ToArray();
        var hasTViewModel = existingParams.Contains("TViewModel");

        var genericParamsCombined = hasTViewModel
            ? genericParamsAll // TViewModel already present, no need to add
            : string.IsNullOrEmpty(genericParamsAll)
                ? "<TViewModel>"
                : genericParamsAll.Insert(1, "TViewModel, "); // e.g. "<T>" -> "<TViewModel, T>"

        var extensionText =
            $"public static {controlTypeName} {extensionName}{genericParamsCombined}(this {controlTypeName} control, TViewModel source, Expression<Func<TViewModel, {valueTypeSource}>> getter, BindingMode? mode = null, IValueConverter? converter = null){classConstraint}{NewLine}" +
            $"   => control._setCompiledBinding({controlTypeName}.{extensionName}Property, source, getter, mode, converter);";

        return extensionText;
    }

    private static string GetCommonPropertyExpressionBindingSetterExtension(string controlTypeName, PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        var extensionName = property.Identifier.ToString();
        var valueTypeSource = GetPropertyTypeName(property, semanticModel);

        var extensionText =
            $"//Generated by GetCommonPropertyExpressionBindingSetterExtension{NewLine}" +
            $"public static {controlTypeName} {extensionName}<TViewModel>(this {controlTypeName} control, TViewModel source, Expression<Func<TViewModel, {valueTypeSource}>> getter, BindingMode? mode = null, IValueConverter? converter = null){NewLine}" +
            $"   => control._setCompiledBinding(null!, source, getter, mode, converter);";


        return extensionText;
    }
}

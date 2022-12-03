using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Avalonia.Markup.Declarative.SourceGenerator;

internal static class MarkupTypeHelpers
{
    internal static ImmutableArray<ClassDeclarationSyntax> FindAvaloniaMarkupViews(Compilation compilation)
    {
        IEnumerable<SyntaxNode> allNodes = compilation.SyntaxTrees.SelectMany(s => s.GetRoot().DescendantNodes());
        IEnumerable<ClassDeclarationSyntax> allClasses = allNodes
            .Where(d => d.IsKind(SyntaxKind.ClassDeclaration))
            .OfType<ClassDeclarationSyntax>();

        return allClasses
            .Where(type => IsGenerateExtensionsView(compilation, type))
            .ToImmutableArray();
    }

    private static bool IsGenerateExtensionsView(Compilation compilation, ClassDeclarationSyntax component)
    {
        var sModel = compilation.GetSemanticModel(component.SyntaxTree);
        var classSymbol = ModelExtensions.GetDeclaredSymbol(sModel, component);

        return classSymbol is INamedTypeSymbol cs && cs.AllInterfaces.Any(x => x.Name == "IDeclarativeViewBase");
    }

    /// <summary>
    /// Determines if property also has Avalonia property backend or not
    /// </summary>
    /// <param name="property">target property</param>
    /// <param name="members"></param>
    /// <returns></returns>
    internal static bool IsCommonInstanceProperty(PropertyDeclarationSyntax property, SyntaxList<MemberDeclarationSyntax> members)
    {
        if(property.Modifiers.Any(x=>x.Text == "static"))
            return false;

        var avaloniaPropertyName = property.Identifier + "Property";
        return members.OfType<FieldDeclarationSyntax>().All(field => field.Declaration.Variables[0].Identifier.ToString() != avaloniaPropertyName);
    }

    internal static bool HasAvaloniaPropertyPublicSetter(FieldDeclarationSyntax field, SyntaxList<MemberDeclarationSyntax> members)
    {
        var backingPropertyName = field.Declaration.Variables[0].Identifier.ToString().Replace("Property", "");

        var property = members
            .OfType<PropertyDeclarationSyntax>()
            .FirstOrDefault(x => x.Identifier.ValueText == backingPropertyName);

        return HasPublicSetter(property);
    }

    internal static bool HasPublicSetter(PropertyDeclarationSyntax property)
    {
        if (property != null)
        {
            var setter = property.AccessorList?.Accessors.FirstOrDefault(x => x.IsKind(SyntaxKind.SetAccessorDeclaration));
            if (setter?.Modifiers.Any() == false)
                return true;
        }

        return false;
    }

    internal static bool IsPublic(PropertyDeclarationSyntax property)
    {
        return property != null && property.Modifiers.Any(x => x.ValueText == "public");
    }

    internal static string GetPropertyTypeName(PropertyDeclarationSyntax property, Compilation compilation)
    {
        var semanticModel = compilation.GetSemanticModel(property.SyntaxTree);
        var fullTypeName = semanticModel.GetTypeInfo(property.Type).Type?.ToString();

        return !string.IsNullOrWhiteSpace(fullTypeName) ? fullTypeName : property.Type.ToString();
    }


}
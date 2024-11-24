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
    internal static bool IsCommonInstanceProperty(IPropertySymbol property, ImmutableArray<ISymbol> members)
    {
        if(property.IsStatic)
            return false;

        var avaloniaPropertyName = property.Name + "Property";
        return members.OfType<IFieldSymbol>().All(field => field.Name != avaloniaPropertyName);
    }

    internal static bool HasAvaloniaPropertyPublicSetter(ISymbol field, ImmutableArray<ISymbol> members)
    {
        var property = members
            .FirstOrDefault(x => x.DeclaredAccessibility == Accessibility.Public && x.Name == field.Name.Replace("Property", ""));

        return HasPublicSetter(property as IPropertySymbol);
    }

    internal static bool HasPublicSetter(IPropertySymbol? property)
    {
        return property?.SetMethod != null && property.SetMethod.DeclaredAccessibility == Accessibility.Public;
    }

    internal static bool IsPublic(IPropertySymbol? property)
    {
        return property != null && property.DeclaredAccessibility == Accessibility.Public;
    }

    internal static string GetPropertyTypeName(IPropertySymbol property)
    {
        //var semanticModel = compilation.GetSemanticModel(property.SyntaxTree);
        //var fullTypeName = semanticModel.GetTypeInfo(property.Type).Type?.ToString();

        return property.Type.ToString();
    }
}
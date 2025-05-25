using System.Text.RegularExpressions;
using Avalonia.Styling;

namespace Avalonia.Markup.Declarative.Helpers;

internal static class SelectorParserHelper
{
    public static string? GetTypeNameFromSelector(this Selector selector) =>
        GetTypeNameFromSelectorString(selector.ToString());

    public static string? GetTypeNameFromSelectorString(string selectorString)
    {
        if (string.IsNullOrWhiteSpace(selectorString))
        {
            return null;
        }

        // Regular expression for finding type names.
        // It searches for:
        // 1. A word that is not preceded by '.', '#', or ':' (a direct type name, e.g., "Button", "TextBlock").
        //    Uses negative lookbehind `(?<![.#:])`
        // 2. Or a word that is inside `:is(...)` (e.g., ":is(TextBlock)").
        //    Uses lookbehind `(?<=:is\()` and lookahead `(?=\))`
        // Combines them using `|` (OR) and uses the named group `(?<typeName>...)` to capture the name.
        string pattern = @"(?<![.#:])\b(?<typeName>[A-Za-z_][A-Za-z0-9_]*)\b|:is\((?<typeName>[A-Za-z_][A-Za-z0-9_]*)\)";

        MatchCollection matches = Regex.Matches(selectorString, pattern);

        // If there are matches, take the last one and extract the type name from it.
        if (matches.Count > 0)
        {
            // Iterate in reverse order to find the last non-empty type name.
            // This is important because the same position can be captured by both parts of the OR in the pattern,
            // but only one of the 'typeName' groups will have a value.
            for (int i = matches.Count - 1; i >= 0; i--)
            {
                Match match = matches[i];
                // Check the named group 'typeName'.
                // If it contains a value (i.e., one of the OR parts matched), return it.
                string typeName = match.Groups["typeName"].Value;
                if (!string.IsNullOrEmpty(typeName))
                {
                    return typeName.Trim();
                }
            }
        }

        return null;
    }
}
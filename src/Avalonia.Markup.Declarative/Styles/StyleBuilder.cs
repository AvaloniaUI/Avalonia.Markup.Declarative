using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Styling;

namespace Avalonia.Markup.Declarative;

internal static class StyleBuilder
{
    internal static IEnumerable<IStyle> StylesToRange(StyleGroup? styleGroup, Func<Selector, Selector>? selector = null)
    {
        if (styleGroup == null)
            yield break;

        var stack = new Stack<(StyleGroup, Func<Selector, Selector>?)>();
        stack.Push((styleGroup, selector));

        while (stack.Count > 0)
        {
            var (currentGroup, currentSelectorFunc) = stack.Pop();

            foreach (var item in currentGroup)
            {
                switch (item)
                {
                    case IRelativeStyle relStyle:
                        relStyle.UpdateSelector(currentSelectorFunc);
                        yield return relStyle;
                        break;
                    case Style style:
                        if (currentSelectorFunc != null)
                            style.Selector = currentSelectorFunc(style.Selector);
                        yield return style;
                        break;

                    case IStyle iStyle:
                        yield return iStyle;
                        break;

                    case StyleGroup group:
                        var groupSelectorFunc = currentSelectorFunc;

                        if (group.GroupSelectorFunc != null && currentSelectorFunc != null)
                            groupSelectorFunc = s => group.GroupSelectorFunc(currentSelectorFunc(s));
                        else if (group.GroupSelectorFunc != null)
                            groupSelectorFunc = s => group.GroupSelectorFunc(s);

                        stack.Push((group, groupSelectorFunc));
                        break;
                }
            }
        }
    }
}
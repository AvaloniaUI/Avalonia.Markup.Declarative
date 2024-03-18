using System;
using System.Collections.Generic;
using Avalonia.Styling;

namespace Avalonia.Markup.Declarative;

public class StyleGroup(Func<Selector,Selector>? groupSelectorFunc = null) : List<object>
{
    public Func<Selector, Selector>? GroupSelectorFunc { get; } = groupSelectorFunc;

    public override string ToString()
    {
        if (GroupSelectorFunc != null)
        {
            return GroupSelectorFunc(null!).ToString();
        }
        return base.ToString() ?? "- No selector --";
    }
}
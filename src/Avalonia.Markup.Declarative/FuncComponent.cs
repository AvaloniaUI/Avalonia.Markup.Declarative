using System;
using Avalonia.Controls;

namespace Avalonia.Markup.Declarative;

public class FuncComponent<TViewModel>(TViewModel model, Func<TViewModel, Control> build) : ComponentBase
{
    protected override object Build() => build.Invoke(model);
}
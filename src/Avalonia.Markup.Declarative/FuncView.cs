using System;
using Avalonia.Controls;

namespace Avalonia.Markup.Declarative;

public class FuncView<TViewModel>(TViewModel model, Func<TViewModel, Control> build) : ViewBase<TViewModel>(model)
{
    protected override object Build(TViewModel? vm) => build.Invoke(vm!);
}
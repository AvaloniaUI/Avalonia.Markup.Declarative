using System;
using System.ComponentModel;

namespace Avalonia.Markup.Declarative;

public interface IMvuComponent : INotifyPropertyChanged
{
    void UpdateState(Action? updateStateAction = default);
}
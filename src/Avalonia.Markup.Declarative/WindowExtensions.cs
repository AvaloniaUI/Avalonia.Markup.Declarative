using Avalonia.Controls;

namespace Avalonia.Markup.Declarative;

public static class NativeMenuExtensions
{
    public static NativeMenu Items(this NativeMenu menu, params NativeMenuItemBase[] items)
    {
        foreach (var item in items)
            menu.Items.Add(item);

        return menu;
    }

    public static NativeMenuItem Items(this NativeMenuItem menu, params NativeMenuItemBase[] items)
    {
        menu.Menu ??= [];
        foreach (var item in items)
            menu.Menu.Items.Add(item);

        return menu;
    }
}
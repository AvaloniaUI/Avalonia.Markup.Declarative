using Avalonia.Controls;
using Avalonia.Headless;
using Avalonia.Markup.Declarative.Tests.ControlsTests.Controls;
using Avalonia.Platform;
using Avalonia.Threading;
using System.Collections.ObjectModel;
using Xunit.Abstractions;
using Color = Avalonia.Media.Color;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class ColorPickerView : ComponentBase
{
    protected override object Build() =>
        new TabControl()
            .SelectedIndex(() => ColorTypeIndex, v => ColorTypeIndex = v)
            .Items(
                new TabItem() //PALETTE EDITOR
                    .Content(
                        new ColorPalette().Row(1)
                            .Colors(() => Colors)
                            .OnColorSelected(c =>
                            {
                                SelectedColor = c;
                                UpdateEditors();
                            })
                    ),

                new TabItem() //HEX EDITOR
                    .Content(
                        new TextBox()
                            .Text(() => HexValue, v => HexValue = v)
                    )
            );

    public void UpdateEditors()
    {
        var value = SelectedColor;
        HexValue = $"#{value.A:X2}{value.R:X2}{value.G:X2}{value.B:X2}";
        OnPropertyChanged(nameof(HexValue));
        StateHasChanged();
    }

    private ObservableCollection<Color> Colors { get; set; } = [];
    public Color SelectedColor { get; set; }
    public string HexValue { get; set; }

    public ColorPickerColorType ColorType { get; set; }
    public int ColorTypeIndex
    {
        get => (int)ColorType;
        set
        {
            ColorType = (ColorPickerColorType)value;
            UpdateEditors();
        }
    }

    public enum ColorPickerColorType : byte
    {
        Hex = 1,
        Hsv = 2,
        Rgb = 3,
    }
}

public class NestedComponentStateTest(ITestOutputHelper testOutputHelper) : AvaloniaTestBase
{
    [Fact]
    public async Task ColorPickerView_BindingStateChanges_PreventInfiniteRecursion()
    {
        var view = new ColorPickerView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        view.UpdateState(() => view.SelectedColor = Color.FromArgb(255, 255, 0, 0));
        view.UpdateEditors();

        //Should not throw exceptions after run

        var viewHexValue = view.HexValue;
        testOutputHelper.WriteLine($"Hex value: {viewHexValue}");
        Assert.Equal("#FFFF0000", viewHexValue);
    }
}
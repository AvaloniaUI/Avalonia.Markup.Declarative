using Avalonia.Controls;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class AttachedPropertySetterTests : AvaloniaTestBase
{
    [Fact]
    public void AttachedProperty_Value_Setters_Are_Generated()
    {
        var control = new Border()
            .Grid_Row(2)
            .Canvas_Left(42d);

        Assert.Equal(2, Grid.GetRow(control));
        Assert.Equal(42d, Canvas.GetLeft(control));
    }
}
using Avalonia.Markup.Declarative.Helpers;

namespace Avalonia.Markup.Declarative.Tests.HelpersTests;

public class SelectorParserHelperTests
{
    [Theory]
    [InlineData("Button", "Button")]
    [InlineData("TextBlock.someClass", "TextBlock")]
    [InlineData(".someClass", null)]
    [InlineData("#someId", null)]
    [InlineData(":is(TextBlock)", "TextBlock")]
    [InlineData("Button:is(TextBlock)", "TextBlock")]
    [InlineData("Button#id.class", "Button")]
    [InlineData("Button.child", "Button")]
    [InlineData("", null)]
    [InlineData("   ", null)]
    [InlineData(null, null)]
    [InlineData("Panel:foo(Button)", "Button")]
    [InlineData("Panel:is(Button):is(TextBlock)", "TextBlock")]
    [InlineData("Button:is(TextBlock):is(Panel)", "Panel")]
    [InlineData("Button#id.class:is(Panel)", "Panel")]
    [InlineData("#SideBar :is(TextBlock)#title", "TextBlock")]
    [InlineData("StackPanel#SideBar :is(TextBlock)#title", "TextBlock")]
    public void GetTypeNameFromSelectorString_ReturnsExpected(string selector, string expected)
    {
        var result = SelectorParserHelper.GetTypeNameFromSelectorString(selector);
        Assert.Equal(expected, result);
    }
}
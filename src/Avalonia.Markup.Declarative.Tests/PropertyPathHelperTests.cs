using Avalonia.Markup.Declarative.Helpers;

namespace Avalonia.Markup.Declarative.Tests
{
    public class PropertyPathHelperTests
    {
        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData("TextProperty", "TextProperty")]
        [InlineData("@TextProperty", "TextProperty")]
        [InlineData("@vm.TextProperty", "TextProperty")]
        [InlineData("vm.Property", "Property")]
        [InlineData("vm.Property ?? 0", "Property")]
        [InlineData("vm.Property?.SubProperty", "Property")]
        [InlineData("vm.Property,SubProperty", "Property")]
        [InlineData("vm.Property\nSubProperty", "Property")]
        [InlineData("vm.Property\tSubProperty", "Property")]
        //nested properties works with binding Path in Avalonia
        [InlineData("vm.Property.SubProperty", "Property.SubProperty")]
        [InlineData("@vm.Property.SubProperty", "Property.SubProperty")]

        //using brackets to isolate single property from its data source
        [InlineData("(vm.Property).SubProperty", "SubProperty")]
        [InlineData("((type)vm.Property).SubProperty", "SubProperty")]
        public void GetNameFromPropertyPath_ReturnsExpected(string path, string expected)
        {
            var result = PropertyPathHelper.GetNameFromPropertyPath(path);
            Assert.Equal(expected, result);
        }
    }
}
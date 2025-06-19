using System.Reflection;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests
{
    public class InjectServiceTests
    {
        public class TestService { }

        public class BaseComponent : ComponentBase
        {
            [Inject]
            public TestService? Service { get; private set; }
            protected override object Build() => new object();
        }

        public class DerivedComponent : BaseComponent
        {
            protected override object Build() => new object();
        }

        [Fact]
        public void InjectServices_InjectsIntoBaseClassProperties()
        {
            // Arrange
            SetServiceProvider(new TestServiceProvider(new TestService()));
            var component = new DerivedComponent();
            
            // Act
            var property = typeof(BaseComponent).GetProperty("Service", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var value = property?.GetValue(component);

            // Assert
            Assert.NotNull(value);
            Assert.IsType<TestService>(value);
        }

        private class TestServiceProvider(object service) : IServiceProvider
        {
            public object? GetService(Type serviceType) => service;
        }

        private static void SetServiceProvider(IServiceProvider provider)
        {
            // Use reflection to set the private static field _serviceProvider in AppBuilderExtensions
            var type = typeof(AppBuilderExtensions);
            var field = type.GetField("_serviceProvider", BindingFlags.Static | BindingFlags.NonPublic);
            field?.SetValue(null, provider);
        }
    }
}

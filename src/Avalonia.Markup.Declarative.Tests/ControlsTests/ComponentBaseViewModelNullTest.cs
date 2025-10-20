using Avalonia.Controls;
using Avalonia.Threading;
using Xunit;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

/// <summary>
/// Tests for ComponentBase&lt;TViewModel&gt; initialization to ensure ViewModel is properly set
/// before Build() is called.
/// 
/// Bug Context:
/// Before the fix, ComponentBase() constructor called Initialize() immediately, which triggered
/// Build() before the derived ComponentBase&lt;TViewModel&gt; constructor could set DataContext.
/// This caused Build(TViewModel? vm) to receive null, leading to NullReferenceExceptions when
/// trying to access ViewModel properties or subscribe to events.
/// 
/// The fix ensures ComponentBase&lt;TViewModel&gt; sets DataContext first, then calls Initialize(),
/// guaranteeing Build() is called with a valid ViewModel.
/// 
/// Real-world example from user's code:
/// <code>
/// public class LayerItemView(LayerItemViewModel viewModel) : ComponentBase&lt;LayerItemViewModel&gt;(viewModel)
/// {
///     protected override object Build(LayerItemViewModel? vm)
///     {
///         vm.Invalidated += StateHasChanged;  // NullReferenceException when vm is null!
///         // ...
///     }
/// }
/// </code>
/// </summary>
public class ComponentBaseViewModelNullTest
{
    /// <summary>
    /// This test reproduces the issue where Build(TViewModel? vm) is called before
    /// the ViewModel is set in the constructor, causing vm to be null.
    /// </summary>
    [Fact]
    public void ComponentBaseWithViewModel_Build_ShouldHaveNonNullViewModel()
    {
        // Arrange & Act
        var viewModel = new TestViewModel { Message = "Test Message" };
        TestComponentView? view = null;
        
        // This should not throw NullReferenceException
        var exception = Record.Exception(() =>
        {
            view = new TestComponentView(viewModel);
        });

        // Assert
        Assert.Null(exception);
        Assert.NotNull(view);
        Assert.NotNull(view.ViewModel);
        Assert.Equal("Test Message", view.ViewModel.Message);
        Assert.True(view.BuildWasCalledWithNonNullViewModel, 
            "Build method should have been called with non-null ViewModel");
    }

    /// <summary>
    /// Simulates the LayerItemView scenario where Build method subscribes to ViewModel events.
    /// This would throw NullReferenceException if vm is null during Build().
    /// </summary>
    [Fact]
    public void ComponentBaseWithViewModel_Build_CanSubscribeToViewModelEvents()
    {
        // Arrange
        var viewModel = new TestViewModel { Message = "Initial" };
        
        // Act
        var view = new TestComponentViewWithEventSubscription(viewModel);
        
        // Trigger the event
        viewModel.TriggerInvalidated();
        Dispatcher.UIThread.RunJobs();
        
        // The subscription should work because vm was not null during Build
        var eventWasRaised = view.InvalidatedEventWasHandled;

        // Assert
        Assert.True(eventWasRaised, "ViewModel event subscription should work");
    }

    [Fact]
    public void ComponentBaseWithViewModel_InitializeCalledOnce()
    {
        // Arrange & Act
        var viewModel = new TestViewModel { Message = "Test" };
        var view = new TestComponentView(viewModel);

        // Assert
        Assert.Equal(1, view.BuildCallCount);
    }

    // Helper classes for testing
    private class TestViewModel
    {
        public string Message { get; set; } = string.Empty;
        public event Action? Invalidated;

        public void TriggerInvalidated() => Invalidated?.Invoke();
    }

    private class TestComponentView : ComponentBase<TestViewModel>
    {
        public bool BuildWasCalledWithNonNullViewModel { get; private set; }
        public int BuildCallCount { get; private set; }

        public TestComponentView(TestViewModel viewModel) : base(viewModel)
        {
        }

        protected override object Build(TestViewModel? vm)
        {
            BuildCallCount++;
            
            // This should not be null - this is the key assertion
            if (vm != null)
            {
                BuildWasCalledWithNonNullViewModel = true;
            }

            return new TextBlock()
                .Text(vm?.Message ?? "ViewModel was null!");
        }
    }

    private class TestComponentViewWithEventSubscription : ComponentBase<TestViewModel>
    {
        public bool InvalidatedEventWasHandled { get; private set; }

        public TestComponentViewWithEventSubscription(TestViewModel viewModel) : base(viewModel)
        {
        }

        protected override object Build(TestViewModel? vm)
        {
            // This simulates the LayerItemView scenario:
            // vm.Invalidated += StateHasChanged;
            
            if (vm == null)
            {
                throw new NullReferenceException(
                    "ViewModel is null in Build method! This reproduces the bug where " +
                    "ComponentBase<TViewModel> calls Initialize() before setting DataContext.");
            }

            // Subscribe to event (like in LayerItemView)
            vm.Invalidated += OnInvalidated;

            return new TextBlock().Text(vm.Message);
        }

        private void OnInvalidated()
        {
            InvalidatedEventWasHandled = true;
        }
    }
}

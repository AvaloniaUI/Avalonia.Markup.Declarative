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
///     // ...
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

    /// <summary>
    /// This test specifically reproduces the LayerItemView scenario with nested classes
    /// as in the real-world example provided by the user.
    /// </summary>
    [Fact]
    public void LayerItemView_BuildWithNestedClasses_ViewModelNotNull()
    {
        // Arrange
        var viewModel = new LayerItemViewModelStub { Name = "Layer 1" };

        // Act - Should not throw NullReferenceException
        var exception = Record.Exception(() =>
            {
                var view = new LayerItemViewStub(viewModel);
            });

        // Assert
        Assert.Null(exception);
    }

    /// <summary>
    /// Verifies that the Build Method is called with non-null ViewModel.
    /// </summary>
    [Fact]
    public void LayerItemView_Build_ReceivesNonNullViewModel()
    {
        // Arrange
        var viewModel = new LayerItemViewModelStub { Name = "Layer 1" };

        // Act
        var view = new LayerItemViewStub(viewModel);

        // Assert
        Assert.NotNull(view.ViewModel);
        Assert.Equal("Layer 1", view.ViewModel.Name);
        Assert.True(view.WasBuiltSuccessfully, "Build method should have completed without null reference");
    }

    /// <summary>
    /// Verifies that subscribing to ViewModel events in Build() works correctly.
    /// This is the critical test case that would fail if vm was null during Build.
    /// </summary>
    [Fact]
    public void LayerItemView_Build_SubscribeToInvalidatedEvent()
    {
        // Arrange
        var viewModel = new LayerItemViewModelStub { Name = "Layer 1" };

        // Act
        var view = new LayerItemViewStub(viewModel);
        viewModel.RaiseInvalidated();
        Dispatcher.UIThread.RunJobs();

        // Assert
        Assert.True(view.InvalidatedEventWasHandled,
   "Invalidated event subscription in Build() should work with non-null ViewModel");
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

    // Real-world scenario with nested classes
    private class LayerItemViewModelStub
    {
        public string Name { get; set; } = string.Empty;
        public event Action? Invalidated;

        public void RaiseInvalidated() => Invalidated?.Invoke();
    }

    private class LayerItemViewStub : ComponentBase<LayerItemViewModelStub>
    {
        public bool WasBuiltSuccessfully { get; private set; }
        public bool InvalidatedEventWasHandled { get; private set; }

        public LayerItemViewStub(LayerItemViewModelStub viewModel) : base(viewModel)
        {
        }

        protected override object Build(LayerItemViewModelStub? vm)
        {
            // This mirrors the real LayerItemView scenario
            if (vm == null)
            {
                throw new NullReferenceException(
             "LayerItemViewModel is null in Build! This would happen if Build is called " +
             "before the ViewModel is set in the constructor.");
            }

            // Subscribe to events - this is what would fail if vm was null
            vm.Invalidated += () =>
                   {
                       InvalidatedEventWasHandled = true;
                       StateHasChanged();
                   };

            WasBuiltSuccessfully = true;

            return new Border()
                .Child(
        new TextBlock()
      .Text(vm.Name)
                );
        }
    }
}

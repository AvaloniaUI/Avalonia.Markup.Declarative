using Avalonia.Controls;
using System;
using System.Collections.Generic;

namespace Avalonia.Markup.Declarative;

public abstract class MvuView : ViewBase, IMvuComponent
{
    public class ItemComponent<TViewModel>(TViewModel model, Func<TViewModel, Control> build) : MvuView
    {
        protected override object Build() => build.Invoke(model);
    }

    private List<IMvuComponent>? _observerViews;

    protected ItemComponent<TViewModel> BuildItem<TViewModel>(TViewModel model, Func<TViewModel, Control> build)
    {
        return new ItemComponent<TViewModel>(model, build);
    }

    private bool deferredLoading;
    private bool deferredLoaded;

    public MvuView()
        : this(false)
    {
    }

    public MvuView(bool deferredLoading)
        : base(deferredLoading)
    {
        this.deferredLoading = deferredLoading;
    }

    protected override void OnCreated()
    {
        InitializeState();
    }

    protected virtual void InitializeState()
    {
    }

    public void UpdateState(Action? updateStateAction = default)
    {
        updateStateAction?.Invoke();
        StateHasChanged();
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        if(this.deferredLoading == true && deferredLoaded == false)
        {
            deferredLoaded = true;
            OnCreatedCore();
            Initialize();
        }

        base.OnAttachedToVisualTree(e);
    }

    internal Action? setStateAction;

    protected virtual void StateHasChanged()
    {
        if (setStateAction != null) setStateAction();

        if (_observerViews != null)
            foreach (var view in _observerViews)
                view.UpdateState();

        foreach (var computedState in __viewComputedStates)
            computedState.OnPropertyChanged();
    }

    public static Control[] BuildControls(params Control[] controls)
    {
        var list = new List<Control>(controls.Length);
        foreach (var control in controls)
        {
            if (control != null)
                list.Add(control);
        }
        return list.ToArray();
    }

    public void AddObserverView(IMvuComponent view)
    {
        _observerViews ??= new List<IMvuComponent>();

        if (!_observerViews.Contains(view))
            _observerViews.Add(view);
    }

    public void RemoveObserverView(IMvuComponent view)
    {
        _observerViews?.Remove(view);
    }

    public void ClearObserverViews()
    {
        _observerViews?.Clear();
    }
}

public static class MvuViewExtensions
{
    public static TViewModel Observe<TViewModel>(this TViewModel targetView, MvuView view)
        where TViewModel : MvuView
    {
        view.AddObserverView(targetView);
        return targetView;
    }

    public static TViewModel RemoveObserve<TViewModel>(this TViewModel targetView, MvuView view)
    where TViewModel : MvuView
    {
        view.RemoveObserverView(targetView);
        return targetView;
    }

    public static TViewModel SetState<TViewModel>(this TViewModel targetView, Action<TViewModel> action, bool setOnce = true)
        where TViewModel : MvuView
    {
        if (setOnce == false)
            targetView.setStateAction = () => { action(targetView); };
        else
            targetView.setStateAction = null;

        action.Invoke(targetView);
        targetView.UpdateState();
        return targetView;
    }
}
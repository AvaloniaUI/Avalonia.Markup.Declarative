using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Avalonia.Markup.Declarative;

public abstract class MvuView : ViewBase, IMvuComponent
{
    // 全局的 update 版本号
    internal static long __GlobalViewUpdateVersion = 0;

    // 当前 view 的 update 版本号
    protected long CurrentViewUpdateVersion = 0;

    public class ItemComponent<TViewModel>(TViewModel model, Func<TViewModel, Control> build) : MvuView
    {
        protected override object Build() => build.Invoke(model);
    }

    private List<MvuView>? _observerViews;

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

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        if (this.deferredLoading == true && deferredLoaded == false)
        {
            deferredLoaded = true;
            OnCreatedCore();
            Initialize();
        }

        base.OnAttachedToVisualTree(e);
    }

    public void UpdateState(Action? updateStateAction = default)
    {
        Interlocked.Increment(ref __GlobalViewUpdateVersion);

        updateStateAction?.Invoke();
        StateHasChanged();
    }

    protected void UpdateStateTriggerByObserver()
    {
        // 版本号一样，不更新，避免循环触发
        if(this.CurrentViewUpdateVersion == __GlobalViewUpdateVersion)
            return;

        // 触发更新
        this.CurrentViewUpdateVersion = __GlobalViewUpdateVersion;
        StateHasChanged();
    }

    internal Action? setStateAction;

    /// <summary>
    /// 一般来说，在应用中不要直接调用 StateHasChanged，而应该调用 UpdateState。
    /// 
    /// 为了避免循环引用，在观察者体系中，维护了版本号机制。UpdateState 会正确的触发观察者的更新逻辑，
    /// StateHasChanged 则可能无法触发观察者的更新。
    /// 
    /// </summary>
    protected virtual void StateHasChanged()
    {
        if (setStateAction != null) setStateAction();

        if (_observerViews != null)
            foreach (var view in _observerViews)
                view.UpdateStateTriggerByObserver();  // 只有当版本号不一样时，才会触发观察者

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

    public void AddObserverView(MvuView view)
    {
        _observerViews ??= new List<MvuView>();

        if (!_observerViews.Contains(view))
            _observerViews.Add(view);
    }

    public void RemoveObserverView(MvuView view)
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

    public static T Observable<T, TProperty>(this T ctrl, AvaloniaProperty<TProperty?> property, Action<TProperty?> onUpdate) where T : Control
    {
        ctrl.GetObservable(property)
            .Subscribe(onUpdate);
        return ctrl;
    }
}
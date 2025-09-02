# Expression Binding: Current State and Next Steps

Date: 2025-09-02
Branch: master (after parent-notification changes)

## Summary
Expression bindings are implemented via lightweight computed states that capture lambdas and push values into controls. They support MVVM (INotifyPropertyChanged) and MVU (explicit StateHasChanged) and now propagate UI-originated changes upward to parent components. Recent changes fixed changed-handler semantics (no handler call on VM→UI path) and added parent notification without reflection. Disposal and scoped recompute are still pending.

## How it works (today)
- Authoring
  - Example: `.Text(() => vm?.MyObject.MyProperty ?? "", v => vm!.MyObject = new MyObject(v))`.
  - Source generator emits: `control._set(AvaloniaProperty, func, onChanged, expression)` (see BindFromExpressionSetterGenerator).

- Control hookup
  - ControlPropertyExtensions creates ViewPropertyComputedState and registers it via ViewBase.AddComputedState.

- States
  - ViewPropertyComputedState<TControl,TValue>
    - Keeps getter, optional setter (for non-Avalonia properties), optional changed handler, and control/AvaloniaProperty refs.
    - Sets initial control value from getter.
    - For Avalonia properties:
      - Binds one-way VM→UI by calling `control.Bind(ap, this)` where the state is an IObservable that emits on recompute.
      - Subscribes UI→VM via `control.GetObservable(ap).Subscribe(this)` and calls the changed handler only on UI-originated updates.
    - On UI→VM (IObserver.OnNext): invokes SetChangedHandler and notifies parent components using ExpressionString (no reflection).
  - ViewPropertyComputedState<TValue>
    - Used for boolean/class bindings and other computed-only cases.

- Recompute triggers
  - MVVM: ViewBase subscribes to DataContext (INotifyPropertyChanged) and calls RecomputeAllBindings() on PropertyChanged.
  - MVU: ComponentBase.StateHasChanged() iterates ViewComputedStates and calls OnPropertyChanged() to push current values.
  - ComponentBase subscribes to INotifyPropertyChanged members (fields and properties) of the component itself via reflection (SubscribeToNotifyPropertyChangedMembers) and triggers StateHasChanged on their changes.
  - Dependent views: parent/child components are chained via DependentViews and UpdateState.

- Upward propagation (new)
  - UI-originated changes are propagated to the parent component:
    - ViewPropertyComputedState.OnNext calls parentComponent.NotifyExternalPropertyChanged(ExpressionString, value).
    - ComponentBase.NotifyExternalPropertyChanged executes a registered callback (if any), calls StateHasChanged, and continues bubbling to its parent.
  - UpdateState has an optional bubbleToParent=true parameter to request parent StateHasChanged explicitly.

- Lifecycle
  - ComponentBase.OnCreated runs InjectServices, SubscribeToNotifyPropertyChangedMembers, InitStateMembers (obsolete path), and StateHasChanged.
  - OnCreatedCore was removed; OnCreated is the entry point now.

- Tests
  - ExpressionBindingTests verify that Text is updated on StateHasChanged (without PropertyChanged) and on PropertyChanged.

## Strengths
- Simple functional API; minimal ceremony for MVVM/MVU.
- Works with templates and class bindings.
- Correct two-way semantics: handler is only invoked on UI→VM, preventing feedback.
- Parent notification on UI changes without reflection-based path walking.
- Avoids redundant SetValue with equality checks.

## Issues and risks (current)
1) Global recompute on every change
- RecomputeAllBindings() loops all states for any PropertyChanged; scales poorly in complex views.

2) Lifecycle and disposal
- Disposables from `control.Bind(...)` and `GetObservable(...).Subscribe(...)` are not stored/disposed; states keep strong references to controls; potential leaks.

3) Coarse dependency tracking
- No mapping from PropertyChanged.PropertyName to a subset of states; ExpressionString is present but unused for targeting.

4) DataContext swap with closures
- Getter lambdas typically capture variables; swapping DataContext doesn’t retarget getters automatically.

5) Non-Avalonia setter semantics
- For non-Avalonia properties, setter is invoked on recompute but there’s still no explicit directionality; UI-originated updates require a separate callback path.

6) Error handling
- IObserver.OnCompleted/OnError throw NotImplementedException in ViewPropertyComputedState; this can surface during control disposal/unbind.

7) Bubble semantics overlap
- There are two upward paths now: explicit UpdateState(bubbleToParent: true) and automatic UI→parent propagation via NotifyExternalPropertyChanged. The interplay should be clarified to avoid double work.

## What changed recently (since the last report)
- Changed handler semantics fixed
  - UpdateControlValue no longer invokes SetChangedHandler on VM→UI path. Handlers are only called from OnNext (UI→VM).

- Parent propagation added
  - On UI changes, OnNext notifies the parent ComponentBase via NotifyExternalPropertyChanged with the ExpressionString, then triggers StateHasChanged up the chain.

- OnCreatedCore removed
  - Initialization happens in ComponentBase.OnCreated.

## Improvements (prioritized)
1) Dispose subscriptions and prevent leaks (low risk)
- Store IDisposable from:
  - `control.Bind(_avaloniaProperty, this)` and
  - `control.GetObservable(_avaloniaProperty).Subscribe(this)`.
- Implement IDisposable on ViewPropertyComputedState and dispose in ViewBase.OnDetachedFromVisualTree (and on reload) to drop subscriptions and references.

2) Scoped recompute by property (perf win)
- Maintain a Dictionary<string,List<ExpressionBindingBase>> mapping property names to states.
- On DataContext PropertyChanged(e.PropertyName), recompute only the affected states; fallback to all when unknown.
- Initial, heuristic approach: use the last token in ExpressionString; longer-term, add Expression<Func<TValue>> overloads and walk expression trees.

3) Improve DataContext swap behavior
- Encourage getters to reference ViewModel/DataContext where possible.
- Add overloads that accept Expression<Func<TVm,TValue>> and evaluate against live DataContext to auto-retarget on swap.

4) Clarify non-Avalonia setter semantics
- Treat setter/getter bindings as one-way by default; surface two-way only through explicit UI-origin callbacks.
- Document this in XML docs and tests.

5) Robust error handling
- Change OnCompleted/OnError to no-op logging instead of throwing; ensure disposal paths call Dispose safely.

6) Unify upward propagation
- Keep automatic UI→parent NotifyExternalPropertyChanged.
- Consider removing or relegating UpdateState(bubbleToParent: true) to advanced cases; at minimum, document precedence to avoid double updates.

7) Tests
- Verify no handler call on VM→UI path, handler called on UI→VM.
- Validate parent propagation: child control update triggers parent notification and recompute.
- Validate disposal: no events after detach; no leaks under stress.
- Validate scoped recompute once implemented.

## Implementation sketch
- ViewPropertyComputedState<TControl,TValue>
  - Hold IDisposable _bindingSub, _controlSub; implement Dispose().
  - Update OnCompleted/OnError to no-op.
- ViewBase
  - Track states by property name (from ExpressionString) to support targeted recompute.
  - Dispose states in OnDetachedFromVisualTree and on Reload.
- ControlPropertyExtensions / generator
  - Optional: add expression-based overloads to capture reliable member paths.

## Closing notes
The model remains incremental and non-breaking for existing authoring patterns. Recent changes improved correctness (no VM→UI handler feedback) and added useful parent propagation. Focusing next on disposal and scoped recompute will address correctness and performance in larger views.

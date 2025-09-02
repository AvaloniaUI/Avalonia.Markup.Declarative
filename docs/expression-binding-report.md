# Expression Binding: Analysis and Improvements

Date: 2025-08-23
Branch: binding-paent-notification

## Summary
Expression bindings in this repo are implemented via lightweight computed states that capture lambdas and push values into controls. It works for MVVM (INotifyPropertyChanged) and MVU (explicit StateHasChanged). The design is simple and effective, but currently recomputes all bindings on any change, invokes VM changed handlers on VM-originated updates (potential feedback), and doesn’t dispose subscriptions, which may cause leaks. Below are findings and concrete, incremental improvements.

## How it works (today)
- Authoring: `.Text(() => vm?.MyObject.MyProperty ?? "", v => vm!.MyObject = new MyObject(v))`.
- Control hookup: `ControlPropertyExtensions` creates `ViewPropertyComputedState<...>` and registers it via `ViewBase.AddComputedState`.
- States:
  - `ViewPropertyComputedState<TControl,TValue>` keeps getter, optional setter/changed handler, and control/AvaloniaProperty refs. It sets initial value and, for Avalonia properties, binds one-way and subscribes to control changes for two-way.
  - `ViewPropertyComputedState<TValue>` is used for boolean class bindings (`BindClass`).
- Recompute triggers:
  - MVVM: `ViewBase.OnDataContextChanged` subscribes to `INotifyPropertyChanged` and calls `RecomputeAllBindings()` on every PropertyChanged.
  - MVU: `ComponentBase.StateHasChanged()` iterates `ViewComputedStates` and calls `OnPropertyChanged()`.

Key files and lines:
- `ControlPropertyExtensions.cs` — `_set` overloads for Avalonia properties and general setters; `BindClass` usage.
- `ViewPropertyComputedState.cs` — computed state types, update logic, IObservable plumbing.
- `ViewBase.cs` — registration (`ViewComputedStates`), DataContext subscriptions, recompute loop.
- `ComponentBase.cs` — MVU update loop and dependent view propagation.
- Tests: `ViewBaseBindingTests.cs`, `ExpressionBindingTests.cs`, `TemplateBindingTests.cs` validate the behavior.

## Strengths
- Simple functional API; minimal ceremony for common MVVM/MVU cases.
- Works across MVVM and MVU, templates, and class bindings.
- Avoids redundant SetValue with equality checks.

## Issues and risks
1. Global recompute on every change
   - `RecomputeAllBindings()` loops all states for any PropertyChanged, which scales poorly in complex views.
2. Changed handler invoked on VM-originated updates
   - `UpdateControlValue()` calls `SetChangedHandler` after pushing VM value to control, which can cause feedback or redundant writes. UI→VM is already handled in `OnNext`.
3. Lifecycle and disposal
   - Subscriptions returned by `control.Bind(...)` and `GetObservable(...).Subscribe(...)` are not disposed; states hold strong refs to controls; potential leaks.
4. DataContext swap with closures
   - Getters built with `Build(TViewModel vm)` capture the ctor parameter; swapping DataContext doesn’t retarget the getter to the new instance.
5. Coarse dependency tracking
   - No mapping from PropertyChanged.PropertyName to a subset of states; all states recompute. `ExpressionString` is stored but unused for this.
6. Setter path semantics (non-Avalonia props)
   - No way to distinguish UI-originated updates; handler is called immediately after setter is invoked from VM, mixing directions.
7. Minor robustness gaps
   - `OnCompleted/OnError` throw; `bubbleToParent` flag isn’t functional; no custom equality hooks.

## Improvements (prioritized)

### 1) Fix changed handler semantics (fast, low-risk)
- In `ViewPropertyComputedState<TControl,TValue>.UpdateControlValue()`:
  - Remove calls to `SetChangedHandler?.Invoke(newValue)`. This path is VM→control; handler should run only on UI→VM (`OnNext`).
- Keeps two-way updates correct and prevents feedback loops.

### 2) Dispose subscriptions and cut leaks (fast, low-risk)
- Store `IDisposable` from:
  - `control.Bind(_avaloniaProperty, this)`;
  - `_obs.Subscribe(this)`.
- Add `Dispose()` on `ViewPropertyComputedState` and call from:
  - `ViewBase.OnDetachedFromVisualTree` for each state;
  - or when the associated control detaches.
- Optionally use `WeakReference<TControl>` and prune dead states during recompute.

### 3) Scoped recompute by property (perf win)
- Map property names → states. On `PropertyChanged(e.PropertyName)`, only recompute related states.
- Implementation options:
  - Parse `ExpressionString` to extract the property token(s) (start with last property name); populate an index on state registration.
  - Longer-term: add `Expression<Func<TValue>>` overloads, walk expression tree to extract a reliable path and nested `INotifyPropertyChanged` subscriptions.

### 4) Improve DataContext swap patterns
- Encourage expression getters to reference `ViewModel`/`DataContext`, not a captured parameter.
- Or add `_set` overloads that accept `Expression<Func<TViewModel, TValue>>` evaluated against the live `DataContext` so swaps auto-retarget.

### 5) Clarify non-Avalonia setter semantics
- Treat setter/getter bindings as one-way by default: call setter on recompute; don’t invoke changed handler there.
- If two-way is needed, require an explicit UI-origin callback registration to surface changes.

### 6) API robustness
- Implement no-op `OnCompleted/OnError`.
- Remove or implement `bubbleToParent` with tests.
- Allow optional `IEqualityComparer<T>` on state to customize change detection.
- Optional debounce/throttle for high-churn paths (opt-in).

### 7) Tests
- Ensure handler isn’t called on VM→control path; is called on UI→VM.
- Validate scoped recompute: only states for a changed property fire.
- Verify disposal prevents leaks and no events fire after detach.
- If added, validate DataContext swap behavior.

## Suggested implementation sketch
- ViewPropertyComputedState<TControl,TValue>:
  - Store disposables `_bindingSub`, `_controlSub` and implement `Dispose()`.
  - Update UpdateControlValue to skip invoking changed handler.
- ViewBase:
  - Keep a `Dictionary<string,List<ViewPropertyComputedState>> _byProperty`.
  - On registration, parse `ExpressionString` and add to index; on DataContext PropertyChanged, call either targeted recompute or fallback to all when unknown.
  - On detach, dispose states; optionally clear index.
- ControlPropertyExtensions:
  - Add overloads that take `Expression<Func<TVm,TValue>>` for more robust path extraction (optional phase 2).

## Closing notes
These changes keep the current authoring model intact while improving correctness and performance. They’re incremental, testable, and can be implemented in steps without breaking existing apps.

using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Input.Raw;
using Avalonia.Platform;
using Avalonia.Threading;
using Avalonia.VisualTree;
using AvPointer = Avalonia.Input.Pointer;

namespace Avalonia.Markup.Declarative.Diagnostics;

/// <summary>
/// Synthesizes <b>real</b> pointer and keyboard input that travels the same path as input from a
/// physical device: it feeds <c>RawInputEventArgs</c> into the top-level's platform input sink
/// (<c>ITopLevelImpl.Input</c>), which hit-tests the point and hands the event to
/// <c>InputManager.ProcessInput</c>. Hit-testing, pointer capture and the routed
/// <c>PointerPressed</c>/<c>PointerMoved</c>/<c>PointerReleased</c> / <c>KeyDown</c>/<c>KeyUp</c> /
/// <c>TextInput</c> events therefore fire exactly as they would from a mouse or keyboard.
/// </summary>
/// <remarks>
/// <para>
/// This is the universal way to drive a control — unlike UI-Automation invoke, it needs no automation
/// peer, so it works for custom <c>Border</c>/<c>Panel</c> controls with hand-written pointer handlers,
/// drag thumbs and drawing canvases. It is <em>not</em> the headless-only <c>Avalonia.Headless</c>
/// simulation: <c>ITopLevelImpl.Input</c> is wired by every real windowing backend, so this drives a
/// live desktop window too.
/// </para>
/// <para>
/// The input constructors and <c>ITopLevelImpl.Input</c>/<c>AvaloniaLocator.Current</c> are public at
/// runtime but hidden in the NuGet <em>reference</em> assembly, so they are reached by reflection
/// (cached once). Everything else uses ordinary public API. Coordinates are absolute client-DIP
/// coordinates of the top-level (the same frame reported by <see cref="VisualBoundsHelper"/>/
/// <c>hit_test</c> and by <c>get_visual_tree</c>'s <c>center</c>). All methods must run on the UI
/// thread; the caller marshals.
/// </para>
/// </remarks>
public static class InputSynthesizer
{
    // A gesture in progress. The SAME MouseDevice/Pointer must be reused across press → move → release
    // so pointer capture is maintained exactly as the platform does it; a fresh device would lose the
    // capture set on press. Held statically so the separate pointer_press/move/release MCP tools (each
    // a distinct call) continue one coherent gesture.
    private sealed class Gesture
    {
        public required object Device { get; init; }
        public required MouseButton Button { get; init; }
        public required RawInputModifiers HeldButtons { get; init; }
    }

    private static Gesture? _active;

    /// <summary>Whether a pointer button is currently held down by a synthetic gesture.</summary>
    public static bool HasActiveGesture => _active is not null;

    /// <summary>
    /// Whether real input can be synthesized for <paramref name="top"/> (its platform input sink and
    /// input root are reachable). Lets a caller choose pointer synthesis vs an automation fallback.
    /// </summary>
    public static bool CanSynthesize(TopLevel top) => TryGetSink(top, out _, out _, out _);

    private static ulong Now() => (ulong)Environment.TickCount64;

    // ── Pointer ─────────────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Presses <paramref name="button"/> at <paramref name="point"/>, beginning a gesture. Sends a move
    /// to the point first (so hover/pointer-over state is set, as with a real device) then the button
    /// press. Reuse <see cref="PointerMove"/>/<see cref="PointerRelease"/> to continue the gesture.
    /// </summary>
    public static string PointerPress(TopLevel top, Point point, MouseButton button, RawInputModifiers modifiers)
    {
        if (!TryGetSink(top, out var sink, out var root, out var error))
            return error;

        var device = Native.CreateMouseDevice();
        var held = modifiers | ButtonFlag(button);
        _active = new Gesture { Device = device, Button = button, HeldButtons = held };

        Pointer(sink, device, root, RawPointerEventType.Move, point, modifiers);
        Pointer(sink, device, root, DownType(button), point, held);

        return $"pointer press {button} at {Fmt(point)}{HitSuffix(top, point)}.";
    }

    /// <summary>
    /// Moves the pointer to <paramref name="point"/>. If a gesture is active the held button(s) are
    /// carried (so <c>PointerMoved</c> reports the button pressed — what a drag/scrub handler checks);
    /// otherwise it is a plain hover move.
    /// </summary>
    public static string PointerMove(TopLevel top, Point point, RawInputModifiers modifiers)
    {
        if (!TryGetSink(top, out var sink, out var root, out var error))
            return error;

        if (_active is { } gesture)
        {
            Pointer(sink, gesture.Device, root, RawPointerEventType.Move, point, gesture.HeldButtons | modifiers);
            return $"pointer move to {Fmt(point)} ({gesture.Button} held).";
        }

        Pointer(sink, Native.CreateMouseDevice(), root, RawPointerEventType.Move, point, modifiers);
        return $"pointer hover-move to {Fmt(point)}.";
    }

    /// <summary>
    /// Releases <paramref name="button"/> at <paramref name="point"/>, ending the active gesture (if
    /// any). A final move to the point (button still held) precedes the release, matching a real device.
    /// </summary>
    public static string PointerRelease(TopLevel top, Point point, MouseButton button, RawInputModifiers modifiers)
    {
        if (!TryGetSink(top, out var sink, out var root, out var error))
            return error;

        var gesture = _active;
        var device = gesture?.Device ?? Native.CreateMouseDevice();
        var releaseButton = gesture?.Button ?? button;

        if (gesture is not null)
            Pointer(sink, device, root, RawPointerEventType.Move, point, gesture.HeldButtons);

        // On release the button is no longer down: don't set its modifier flag (the Released update
        // kind also forces IsPressed=false).
        Pointer(sink, device, root, UpType(releaseButton), point, modifiers);
        _active = null;

        return $"pointer release {releaseButton} at {Fmt(point)}.";
    }

    /// <summary>
    /// A complete tap/click: move → press → release at one point. Drives any control (invokable or
    /// raw-pointer-only) and focuses a focusable one, exactly like a real click.
    /// </summary>
    public static string Tap(TopLevel top, Point point, MouseButton button, RawInputModifiers modifiers)
    {
        if (!TryGetSink(top, out var sink, out var root, out var error))
            return error;

        // A self-contained gesture: its own device, not the shared _active one, so a dangling press
        // from a separate pointer_press can't entangle a tap.
        var device = Native.CreateMouseDevice();
        var held = modifiers | ButtonFlag(button);
        Pointer(sink, device, root, RawPointerEventType.Move, point, modifiers);
        Pointer(sink, device, root, DownType(button), point, held);
        Pointer(sink, device, root, UpType(button), point, modifiers);

        return $"tap {button} at {Fmt(point)}{HitSuffix(top, point)}.";
    }

    /// <summary>
    /// A press-drag-release from <paramref name="from"/> to <paramref name="to"/> in
    /// <paramref name="steps"/> intermediate moves (each carrying the held button so scrub/drag
    /// handlers see the button down), with an optional dwell (<paramref name="holdMs"/>) after press.
    /// </summary>
    public static string Drag(TopLevel top, Point from, Point to, MouseButton button, int steps, int holdMs, RawInputModifiers modifiers)
    {
        if (!TryGetSink(top, out var sink, out var root, out var error))
            return error;

        steps = Math.Clamp(steps, 1, 500);
        var device = Native.CreateMouseDevice();
        var held = modifiers | ButtonFlag(button);

        Pointer(sink, device, root, RawPointerEventType.Move, from, modifiers);
        Pointer(sink, device, root, DownType(button), from, held);

        if (holdMs > 0)
            PumpFor(holdMs);

        for (var i = 1; i <= steps; i++)
        {
            var t = (double)i / steps;
            var p = new Point(from.X + (to.X - from.X) * t, from.Y + (to.Y - from.Y) * t);
            Pointer(sink, device, root, RawPointerEventType.Move, p, held);
        }

        Pointer(sink, device, root, UpType(button), to, modifiers);

        return $"drag {button} from {Fmt(from)} to {Fmt(to)} in {steps} step(s).";
    }

    // ── Keyboard ────────────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Sends a real <c>KeyDown</c> then <c>KeyUp</c> for <paramref name="key"/> (+ modifiers) to the
    /// element that currently has keyboard focus. Escape/Enter/etc. reach a focused <c>TextBox</c> and
    /// trigger its key handling. Focus the target first (<c>tap</c> it, or <c>invoke … focus</c>).
    /// </summary>
    public static string PressKey(TopLevel top, Key key, RawInputModifiers modifiers)
    {
        if (!TryGetSink(top, out var sink, out var root, out var error))
            return error;
        if (Native.GetKeyboard() is not { } keyboard)
            return "No keyboard device is available.";

        Key(sink, keyboard, root, RawKeyEventType.KeyDown, key, modifiers);
        Key(sink, keyboard, root, RawKeyEventType.KeyUp, key, modifiers);
        return $"key {DescribeKey(key, modifiers)} sent to the focused element.";
    }

    /// <summary>Sends a real <c>KeyDown</c> only (for held keys / combos), to the focused element.</summary>
    public static string KeyDown(TopLevel top, Key key, RawInputModifiers modifiers)
    {
        if (!TryGetSink(top, out var sink, out var root, out var error))
            return error;
        if (Native.GetKeyboard() is not { } keyboard)
            return "No keyboard device is available.";

        Key(sink, keyboard, root, RawKeyEventType.KeyDown, key, modifiers);
        return $"keydown {DescribeKey(key, modifiers)} sent to the focused element.";
    }

    /// <summary>Sends a real <c>KeyUp</c> only, to the focused element.</summary>
    public static string KeyUp(TopLevel top, Key key, RawInputModifiers modifiers)
    {
        if (!TryGetSink(top, out var sink, out var root, out var error))
            return error;
        if (Native.GetKeyboard() is not { } keyboard)
            return "No keyboard device is available.";

        Key(sink, keyboard, root, RawKeyEventType.KeyUp, key, modifiers);
        return $"keyup {DescribeKey(key, modifiers)} sent to the focused element.";
    }

    /// <summary>
    /// Sends real <c>TextInput</c> for <paramref name="text"/> to the focused element — the way typed
    /// characters reach a <c>TextBox</c> (independent of <c>KeyDown</c>).
    /// </summary>
    public static string TextInput(TopLevel top, string text)
    {
        if (!TryGetSink(top, out var sink, out var root, out var error))
            return error;
        if (Native.GetKeyboard() is not { } keyboard)
            return "No keyboard device is available.";

        sink((RawInputEventArgs)Native.CreateTextInputArgs(keyboard, Now(), root, text));
        return $"typed '{text}' into the focused element.";
    }

    // ── Plumbing ────────────────────────────────────────────────────────────────────────────────

    private static void Pointer(Action<RawInputEventArgs> sink, object device, IInputRoot root, RawPointerEventType type, Point point, RawInputModifiers modifiers) =>
        sink((RawInputEventArgs)Native.CreatePointerArgs(device, Now(), root, type, point, modifiers));

    private static void Key(Action<RawInputEventArgs> sink, object keyboard, IInputRoot root, RawKeyEventType type, Key key, RawInputModifiers modifiers) =>
        sink((RawInputEventArgs)Native.CreateKeyArgs(keyboard, Now(), root, type, key, modifiers));

    /// <summary>
    /// Resolves the platform input sink and the input root for <paramref name="top"/>. The sink is
    /// <c>ITopLevelImpl.Input</c> (the exact callback the windowing backend calls); its delegate target
    /// is the <c>PresentationSource</c>, which is the <see cref="IInputRoot"/> the raw events need.
    /// </summary>
    private static bool TryGetSink(TopLevel top, out Action<RawInputEventArgs> sink, out IInputRoot root, out string error)
    {
        sink = null!;
        root = null!;
        error = string.Empty;

        if (top is null)
        {
            error = "No top-level was given to synthesize input on.";
            return false;
        }

        if (top.PlatformImpl is not { } impl)
        {
            error = "This top-level has no platform implementation (the window is not realized yet). " +
                    "Ensure the window is shown before synthesizing input.";
            return false;
        }

        if (Native.GetInputSink(impl) is not { } input)
        {
            error = "Could not access the platform input sink; synthetic input is unavailable on this " +
                    "windowing backend/Avalonia version.";
            return false;
        }

        if (ResolveInputRoot(top, input) is not { } resolved)
        {
            error = "Could not resolve the input root for this top-level; synthetic input cannot be routed.";
            return false;
        }

        sink = input;
        root = resolved;
        return true;
    }

    private static IInputRoot? ResolveInputRoot(TopLevel top, Action<RawInputEventArgs> input)
    {
        // The Input delegate is bound to the PresentationSource, which implements IInputRoot.
        foreach (var d in input.GetInvocationList())
            if (d.Target is IInputRoot fromDelegate)
                return fromDelegate;

        // Fallback: the internal TopLevel.InputRoot property (stable across the 12.x line).
        var property = typeof(TopLevel).GetProperty("InputRoot", BindingFlags.NonPublic | BindingFlags.Instance);
        return property?.GetValue(top) as IInputRoot;
    }

    private static void PumpFor(int milliseconds)
    {
        // Dwell without blocking the dispatcher: run a nested frame that a timer ends. Works headless too.
        var frame = new DispatcherFrame();
        var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(milliseconds) };
        timer.Tick += (_, _) =>
        {
            timer.Stop();
            frame.Continue = false;
        };
        timer.Start();
        Dispatcher.UIThread.PushFrame(frame);
    }

    private static RawInputModifiers ButtonFlag(MouseButton button) =>
        button switch
        {
            MouseButton.Left => RawInputModifiers.LeftMouseButton,
            MouseButton.Right => RawInputModifiers.RightMouseButton,
            MouseButton.Middle => RawInputModifiers.MiddleMouseButton,
            MouseButton.XButton1 => RawInputModifiers.XButton1MouseButton,
            MouseButton.XButton2 => RawInputModifiers.XButton2MouseButton,
            _ => RawInputModifiers.None
        };

    private static RawPointerEventType DownType(MouseButton button) =>
        button switch
        {
            MouseButton.Left => RawPointerEventType.LeftButtonDown,
            MouseButton.Right => RawPointerEventType.RightButtonDown,
            MouseButton.Middle => RawPointerEventType.MiddleButtonDown,
            MouseButton.XButton1 => RawPointerEventType.XButton1Down,
            MouseButton.XButton2 => RawPointerEventType.XButton2Down,
            _ => RawPointerEventType.LeftButtonDown
        };

    private static RawPointerEventType UpType(MouseButton button) =>
        button switch
        {
            MouseButton.Left => RawPointerEventType.LeftButtonUp,
            MouseButton.Right => RawPointerEventType.RightButtonUp,
            MouseButton.Middle => RawPointerEventType.MiddleButtonUp,
            MouseButton.XButton1 => RawPointerEventType.XButton1Up,
            MouseButton.XButton2 => RawPointerEventType.XButton2Up,
            _ => RawPointerEventType.LeftButtonUp
        };

    private static string HitSuffix(TopLevel top, Point point)
    {
        try
        {
            var hit = HitTester.HitTest(top, point);
            if (hit is null)
                return " (nothing under the point)";
            var name = hit is StyledElement { Name: { Length: > 0 } n } ? $" #{n}" : string.Empty;
            return $" (over {hit.GetType().Name}{name})";
        }
        catch
        {
            return string.Empty;
        }
    }

    private static string Fmt(Point p) =>
        string.Format(CultureInfo.InvariantCulture, "({0:0.#}, {1:0.#})", p.X, p.Y);

    private static string DescribeKey(Key key, RawInputModifiers modifiers)
    {
        var mods = modifiers & RawInputModifiers.KeyboardMask;
        return mods == RawInputModifiers.None ? key.ToString() : $"{mods}+{key}";
    }

    /// <summary>
    /// Reflection bridge for the runtime-public-but-reference-hidden members: the raw-event/device
    /// constructors, <c>ITopLevelImpl.Input</c>, and <c>AvaloniaLocator.Current</c>. Resolved once and
    /// cached; if resolution fails the callers degrade to a clear diagnostic rather than throwing.
    /// </summary>
    private static class Native
    {
        private static readonly ConstructorInfo? PointerCtor;
        private static readonly ConstructorInfo? KeyCtor;
        private static readonly ConstructorInfo? TextCtor;
        private static readonly ConstructorInfo? MouseDeviceCtor;
        private static readonly PropertyInfo? InputProperty;
        private static readonly PropertyInfo? LocatorCurrent;
        private static readonly MethodInfo? GetServiceMethod;

        static Native()
        {
            const BindingFlags ctorFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            var baseAsm = typeof(MouseButton).Assembly;

            var rawPointer = baseAsm.GetType("Avalonia.Input.Raw.RawPointerEventArgs");
            PointerCtor = rawPointer?.GetConstructor(ctorFlags, binder: null,
                new[] { typeof(IInputDevice), typeof(ulong), typeof(IInputRoot), typeof(RawPointerEventType), typeof(Point), typeof(RawInputModifiers) },
                modifiers: null);

            var rawKey = baseAsm.GetType("Avalonia.Input.Raw.RawKeyEventArgs");
            KeyCtor = rawKey?.GetConstructor(ctorFlags, binder: null,
                new[] { typeof(IInputDevice), typeof(ulong), typeof(IInputRoot), typeof(RawKeyEventType), typeof(Key), typeof(RawInputModifiers), typeof(PhysicalKey), typeof(string), typeof(KeyDeviceType) },
                modifiers: null);

            var rawText = baseAsm.GetType("Avalonia.Input.Raw.RawTextInputEventArgs");
            TextCtor = rawText?.GetConstructor(ctorFlags, binder: null,
                new[] { typeof(IKeyboardDevice), typeof(ulong), typeof(IInputRoot), typeof(string) },
                modifiers: null);

            var mouseDevice = baseAsm.GetType("Avalonia.Input.MouseDevice");
            MouseDeviceCtor = mouseDevice?.GetConstructor(ctorFlags, binder: null, new[] { typeof(AvPointer) }, modifiers: null);

            InputProperty = typeof(ITopLevelImpl).GetProperty("Input", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            LocatorCurrent = typeof(AvaloniaLocator).GetProperty("Current", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            GetServiceMethod = typeof(IAvaloniaDependencyResolver).GetMethod("GetService", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, binder: null, new[] { typeof(Type) }, modifiers: null);
        }

        public static object CreateMouseDevice()
        {
            var pointer = new AvPointer(AvPointer.GetNextFreeId(), PointerType.Mouse, isPrimary: true);
            return MouseDeviceCtor is not null
                ? MouseDeviceCtor.Invoke(new object?[] { pointer })!
                : throw new InvalidOperationException("MouseDevice constructor is unavailable.");
        }

        public static object CreatePointerArgs(object device, ulong timestamp, IInputRoot root, RawPointerEventType type, Point position, RawInputModifiers modifiers) =>
            PointerCtor is not null
                ? PointerCtor.Invoke(new object?[] { device, timestamp, root, type, position, modifiers })!
                : throw new InvalidOperationException("RawPointerEventArgs constructor is unavailable.");

        public static object CreateKeyArgs(object keyboard, ulong timestamp, IInputRoot root, RawKeyEventType type, Key key, RawInputModifiers modifiers) =>
            KeyCtor is not null
                ? KeyCtor.Invoke(new object?[] { keyboard, timestamp, root, type, key, modifiers, PhysicalKey.None, null, KeyDeviceType.Keyboard })!
                : throw new InvalidOperationException("RawKeyEventArgs constructor is unavailable.");

        public static object CreateTextInputArgs(object keyboard, ulong timestamp, IInputRoot root, string text) =>
            TextCtor is not null
                ? TextCtor.Invoke(new object?[] { keyboard, timestamp, root, text })!
                : throw new InvalidOperationException("RawTextInputEventArgs constructor is unavailable.");

        public static Action<RawInputEventArgs>? GetInputSink(object platformImpl) =>
            InputProperty?.GetValue(platformImpl) as Action<RawInputEventArgs>;

        public static object? GetKeyboard()
        {
            if (LocatorCurrent?.GetValue(null) is not { } resolver || GetServiceMethod is null)
                return null;
            return GetServiceMethod.Invoke(resolver, new object?[] { typeof(IKeyboardDevice) });
        }
    }
}

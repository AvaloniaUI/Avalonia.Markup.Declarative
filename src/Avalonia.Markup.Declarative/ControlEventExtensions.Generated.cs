using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Avalonia.Input.TextInput;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.LogicalTree;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Styling;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ApplicationEventsExtensions
{
public static Application OnResourcesChanged(this Application control, Action<ResourcesChangedEventArgs> action) {
void Handler(object sender, ResourcesChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<ResourcesChangedEventArgs>) Handler, h => control.ResourcesChanged += h, h => control.ResourcesChanged -= h);
}
public static Application OnUrlsOpened(this Application control, Action<UrlOpenedEventArgs> action) {
void Handler(object sender, UrlOpenedEventArgs args) => action(args);
return control._setEvent((EventHandler<UrlOpenedEventArgs>) Handler, h => control.UrlsOpened += h, h => control.UrlsOpened -= h);
}
}
public static partial class AutoCompleteBoxEventsExtensions
{
public static AutoCompleteBox OnTextChanged(this AutoCompleteBox control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.TextChanged += h, h => control.TextChanged -= h);
}
public static AutoCompleteBox OnPopulating(this AutoCompleteBox control, Action<PopulatingEventArgs> action) {
void Handler(object sender, PopulatingEventArgs args) => action(args);
return control._setEvent((EventHandler<PopulatingEventArgs>) Handler, h => control.Populating += h, h => control.Populating -= h);
}
public static AutoCompleteBox OnPopulated(this AutoCompleteBox control, Action<PopulatedEventArgs> action) {
void Handler(object sender, PopulatedEventArgs args) => action(args);
return control._setEvent((EventHandler<PopulatedEventArgs>) Handler, h => control.Populated += h, h => control.Populated -= h);
}
public static AutoCompleteBox OnDropDownOpening(this AutoCompleteBox control, Action<CancelEventArgs> action) {
void Handler(object sender, CancelEventArgs args) => action(args);
return control._setEvent((EventHandler<CancelEventArgs>) Handler, h => control.DropDownOpening += h, h => control.DropDownOpening -= h);
}
public static AutoCompleteBox OnDropDownOpened(this AutoCompleteBox control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.DropDownOpened += h, h => control.DropDownOpened -= h);
}
public static AutoCompleteBox OnDropDownClosing(this AutoCompleteBox control, Action<CancelEventArgs> action) {
void Handler(object sender, CancelEventArgs args) => action(args);
return control._setEvent((EventHandler<CancelEventArgs>) Handler, h => control.DropDownClosing += h, h => control.DropDownClosing -= h);
}
public static AutoCompleteBox OnDropDownClosed(this AutoCompleteBox control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.DropDownClosed += h, h => control.DropDownClosed -= h);
}
public static AutoCompleteBox OnSelectionChanged(this AutoCompleteBox control, Action<SelectionChangedEventArgs> action) {
void Handler(object sender, SelectionChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<SelectionChangedEventArgs>) Handler, h => control.SelectionChanged += h, h => control.SelectionChanged -= h);
}
}
public static partial class ButtonEventsExtensions
{
public static Button OnClick(this Button control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.Click += h, h => control.Click -= h);
}
}
public static partial class CalendarEventsExtensions
{
public static Calendar OnSelectedDatesChanged(this Calendar control, Action<SelectionChangedEventArgs> action) {
void Handler(object sender, SelectionChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<SelectionChangedEventArgs>) Handler, h => control.SelectedDatesChanged += h, h => control.SelectedDatesChanged -= h);
}
public static Calendar OnDisplayDateChanged(this Calendar control, Action<CalendarDateChangedEventArgs> action) {
void Handler(object sender, CalendarDateChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<CalendarDateChangedEventArgs>) Handler, h => control.DisplayDateChanged += h, h => control.DisplayDateChanged -= h);
}
public static Calendar OnDisplayModeChanged(this Calendar control, Action<CalendarModeChangedEventArgs> action) {
void Handler(object sender, CalendarModeChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<CalendarModeChangedEventArgs>) Handler, h => control.DisplayModeChanged += h, h => control.DisplayModeChanged -= h);
}
}
public static partial class CalendarDatePickerEventsExtensions
{
public static CalendarDatePicker OnCalendarClosed(this CalendarDatePicker control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.CalendarClosed += h, h => control.CalendarClosed -= h);
}
public static CalendarDatePicker OnCalendarOpened(this CalendarDatePicker control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.CalendarOpened += h, h => control.CalendarOpened -= h);
}
public static CalendarDatePicker OnDateValidationError(this CalendarDatePicker control, Action<CalendarDatePickerDateValidationErrorEventArgs> action) {
void Handler(object sender, CalendarDatePickerDateValidationErrorEventArgs args) => action(args);
return control._setEvent((EventHandler<CalendarDatePickerDateValidationErrorEventArgs>) Handler, h => control.DateValidationError += h, h => control.DateValidationError -= h);
}
public static CalendarDatePicker OnSelectedDateChanged(this CalendarDatePicker control, Action<SelectionChangedEventArgs> action) {
void Handler(object sender, SelectionChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<SelectionChangedEventArgs>) Handler, h => control.SelectedDateChanged += h, h => control.SelectedDateChanged -= h);
}
}
public static partial class ContextMenuEventsExtensions
{
public static ContextMenu OnContextMenuOpening(this ContextMenu control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((CancelEventHandler) Handler, h => control.ContextMenuOpening += h, h => control.ContextMenuOpening -= h);
}
public static ContextMenu OnContextMenuClosing(this ContextMenu control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((CancelEventHandler) Handler, h => control.ContextMenuClosing += h, h => control.ContextMenuClosing -= h);
}
}
public static partial class ControlEventsExtensions
{
public static Control OnContextRequested(this Control control, Action<ContextRequestedEventArgs> action) {
void Handler(object sender, ContextRequestedEventArgs args) => action(args);
return control._setEvent((EventHandler<ContextRequestedEventArgs>) Handler, h => control.ContextRequested += h, h => control.ContextRequested -= h);
}
}
public static partial class DatePickerEventsExtensions
{
public static DatePicker OnSelectedDateChanged(this DatePicker control, Action<DatePickerSelectedValueChangedEventArgs> action) {
void Handler(object sender, DatePickerSelectedValueChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<DatePickerSelectedValueChangedEventArgs>) Handler, h => control.SelectedDateChanged += h, h => control.SelectedDateChanged -= h);
}
}
public static partial class TimePickerEventsExtensions
{
public static TimePicker OnSelectedTimeChanged(this TimePicker control, Action<TimePickerSelectedValueChangedEventArgs> action) {
void Handler(object sender, TimePickerSelectedValueChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<TimePickerSelectedValueChangedEventArgs>) Handler, h => control.SelectedTimeChanged += h, h => control.SelectedTimeChanged -= h);
}
}
public static partial class MenuBaseEventsExtensions
{
public static MenuBase OnMenuOpened(this MenuBase control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.MenuOpened += h, h => control.MenuOpened -= h);
}
public static MenuBase OnMenuClosed(this MenuBase control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.MenuClosed += h, h => control.MenuClosed -= h);
}
}
public static partial class MenuItemEventsExtensions
{
public static MenuItem OnClick(this MenuItem control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.Click += h, h => control.Click -= h);
}
public static MenuItem OnPointerEnterItem(this MenuItem control, Action<PointerEventArgs> action) {
void Handler(object sender, PointerEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerEventArgs>) Handler, h => control.PointerEnterItem += h, h => control.PointerEnterItem -= h);
}
public static MenuItem OnPointerLeaveItem(this MenuItem control, Action<PointerEventArgs> action) {
void Handler(object sender, PointerEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerEventArgs>) Handler, h => control.PointerLeaveItem += h, h => control.PointerLeaveItem -= h);
}
public static MenuItem OnSubmenuOpened(this MenuItem control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.SubmenuOpened += h, h => control.SubmenuOpened -= h);
}
}
public static partial class NativeMenuEventsExtensions
{
public static NativeMenu OnNeedsUpdate(this NativeMenu control, Action<EventArgs> action) {
void Handler(object sender, EventArgs args) => action(args);
return control._setEvent((EventHandler<EventArgs>) Handler, h => control.NeedsUpdate += h, h => control.NeedsUpdate -= h);
}
public static NativeMenu OnOpening(this NativeMenu control, Action<EventArgs> action) {
void Handler(object sender, EventArgs args) => action(args);
return control._setEvent((EventHandler<EventArgs>) Handler, h => control.Opening += h, h => control.Opening -= h);
}
public static NativeMenu OnClosed(this NativeMenu control, Action<EventArgs> action) {
void Handler(object sender, EventArgs args) => action(args);
return control._setEvent((EventHandler<EventArgs>) Handler, h => control.Closed += h, h => control.Closed -= h);
}
}
public static partial class NativeMenuItemEventsExtensions
{
public static NativeMenuItem OnClick(this NativeMenuItem control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Click += h, h => control.Click -= h);
}
public static NativeMenuItem OnClicked(this NativeMenuItem control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Clicked += h, h => control.Clicked -= h);
}
}
public static partial class NumericUpDownEventsExtensions
{
public static NumericUpDown OnSpinned(this NumericUpDown control, Action<SpinEventArgs> action) {
void Handler(object sender, SpinEventArgs args) => action(args);
return control._setEvent((EventHandler<SpinEventArgs>) Handler, h => control.Spinned += h, h => control.Spinned -= h);
}
public static NumericUpDown OnValueChanged(this NumericUpDown control, Action<NumericUpDownValueChangedEventArgs> action) {
void Handler(object sender, NumericUpDownValueChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<NumericUpDownValueChangedEventArgs>) Handler, h => control.ValueChanged += h, h => control.ValueChanged -= h);
}
}
public static partial class ItemsRepeaterEventsExtensions
{
public static ItemsRepeater OnElementClearing(this ItemsRepeater control, Action<ItemsRepeaterElementClearingEventArgs> action) {
void Handler(object sender, ItemsRepeaterElementClearingEventArgs args) => action(args);
return control._setEvent((EventHandler<ItemsRepeaterElementClearingEventArgs>) Handler, h => control.ElementClearing += h, h => control.ElementClearing -= h);
}
public static ItemsRepeater OnElementIndexChanged(this ItemsRepeater control, Action<ItemsRepeaterElementIndexChangedEventArgs> action) {
void Handler(object sender, ItemsRepeaterElementIndexChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<ItemsRepeaterElementIndexChangedEventArgs>) Handler, h => control.ElementIndexChanged += h, h => control.ElementIndexChanged -= h);
}
public static ItemsRepeater OnElementPrepared(this ItemsRepeater control, Action<ItemsRepeaterElementPreparedEventArgs> action) {
void Handler(object sender, ItemsRepeaterElementPreparedEventArgs args) => action(args);
return control._setEvent((EventHandler<ItemsRepeaterElementPreparedEventArgs>) Handler, h => control.ElementPrepared += h, h => control.ElementPrepared -= h);
}
}
public static partial class ScrollViewerEventsExtensions
{
public static ScrollViewer OnScrollChanged(this ScrollViewer control, Action<ScrollChangedEventArgs> action) {
void Handler(object sender, ScrollChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<ScrollChangedEventArgs>) Handler, h => control.ScrollChanged += h, h => control.ScrollChanged -= h);
}
}
public static partial class SpinnerEventsExtensions
{
public static Spinner OnSpin(this Spinner control, Action<SpinEventArgs> action) {
void Handler(object sender, SpinEventArgs args) => action(args);
return control._setEvent((EventHandler<SpinEventArgs>) Handler, h => control.Spin += h, h => control.Spin -= h);
}
}
public static partial class SplitViewEventsExtensions
{
public static SplitView OnPaneClosed(this SplitView control, Action<EventArgs> action) {
void Handler(object sender, EventArgs args) => action(args);
return control._setEvent((EventHandler<EventArgs>) Handler, h => control.PaneClosed += h, h => control.PaneClosed -= h);
}
public static SplitView OnPaneClosing(this SplitView control, Action<SplitViewPaneClosingEventArgs> action) {
void Handler(object sender, SplitViewPaneClosingEventArgs args) => action(args);
return control._setEvent((EventHandler<SplitViewPaneClosingEventArgs>) Handler, h => control.PaneClosing += h, h => control.PaneClosing -= h);
}
public static SplitView OnPaneOpened(this SplitView control, Action<EventArgs> action) {
void Handler(object sender, EventArgs args) => action(args);
return control._setEvent((EventHandler<EventArgs>) Handler, h => control.PaneOpened += h, h => control.PaneOpened -= h);
}
public static SplitView OnPaneOpening(this SplitView control, Action<EventArgs> action) {
void Handler(object sender, EventArgs args) => action(args);
return control._setEvent((EventHandler<EventArgs>) Handler, h => control.PaneOpening += h, h => control.PaneOpening -= h);
}
}
public static partial class TextBoxEventsExtensions
{
public static TextBox OnCopyingToClipboard(this TextBox control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.CopyingToClipboard += h, h => control.CopyingToClipboard -= h);
}
public static TextBox OnCuttingToClipboard(this TextBox control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.CuttingToClipboard += h, h => control.CuttingToClipboard -= h);
}
public static TextBox OnPastingFromClipboard(this TextBox control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.PastingFromClipboard += h, h => control.PastingFromClipboard -= h);
}
}
public static partial class TopLevelEventsExtensions
{
public static TopLevel OnOpened(this TopLevel control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Opened += h, h => control.Opened -= h);
}
public static TopLevel OnClosed(this TopLevel control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Closed += h, h => control.Closed -= h);
}
}
public static partial class TrayIconEventsExtensions
{
public static TrayIcon OnClicked(this TrayIcon control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Clicked += h, h => control.Clicked -= h);
}
}
public static partial class TreeViewEventsExtensions
{
public static TreeView OnSelectionChanged(this TreeView control, Action<SelectionChangedEventArgs> action) {
void Handler(object sender, SelectionChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<SelectionChangedEventArgs>) Handler, h => control.SelectionChanged += h, h => control.SelectionChanged -= h);
}
}
public static partial class WindowEventsExtensions
{
public static Window OnClosing(this Window control, Action<CancelEventArgs> action) {
void Handler(object sender, CancelEventArgs args) => action(args);
return control._setEvent((EventHandler<CancelEventArgs>) Handler, h => control.Closing += h, h => control.Closing -= h);
}
}
public static partial class WindowBaseEventsExtensions
{
public static WindowBase OnActivated(this WindowBase control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Activated += h, h => control.Activated -= h);
}
public static WindowBase OnDeactivated(this WindowBase control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Deactivated += h, h => control.Deactivated -= h);
}
public static WindowBase OnPositionChanged(this WindowBase control, Action<PixelPointEventArgs> action) {
void Handler(object sender, PixelPointEventArgs args) => action(args);
return control._setEvent((EventHandler<PixelPointEventArgs>) Handler, h => control.PositionChanged += h, h => control.PositionChanged -= h);
}
}
public static partial class NotificationCardEventsExtensions
{
public static NotificationCard OnNotificationClosed(this NotificationCard control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.NotificationClosed += h, h => control.NotificationClosed -= h);
}
}
public static partial class CalendarButtonEventsExtensions
{
public static CalendarButton OnCalendarLeftMouseButtonDown(this CalendarButton control, Action<PointerPressedEventArgs> action) {
void Handler(object sender, PointerPressedEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerPressedEventArgs>) Handler, h => control.CalendarLeftMouseButtonDown += h, h => control.CalendarLeftMouseButtonDown -= h);
}
public static CalendarButton OnCalendarLeftMouseButtonUp(this CalendarButton control, Action<PointerReleasedEventArgs> action) {
void Handler(object sender, PointerReleasedEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerReleasedEventArgs>) Handler, h => control.CalendarLeftMouseButtonUp += h, h => control.CalendarLeftMouseButtonUp -= h);
}
}
public static partial class CalendarDayButtonEventsExtensions
{
public static CalendarDayButton OnCalendarDayButtonMouseDown(this CalendarDayButton control, Action<PointerPressedEventArgs> action) {
void Handler(object sender, PointerPressedEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerPressedEventArgs>) Handler, h => control.CalendarDayButtonMouseDown += h, h => control.CalendarDayButtonMouseDown -= h);
}
public static CalendarDayButton OnCalendarDayButtonMouseUp(this CalendarDayButton control, Action<PointerReleasedEventArgs> action) {
void Handler(object sender, PointerReleasedEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerReleasedEventArgs>) Handler, h => control.CalendarDayButtonMouseUp += h, h => control.CalendarDayButtonMouseUp -= h);
}
}
public static partial class DateTimePickerPanelEventsExtensions
{
public static DateTimePickerPanel OnScrollInvalidated(this DateTimePickerPanel control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.ScrollInvalidated += h, h => control.ScrollInvalidated -= h);
}
public static DateTimePickerPanel OnSelectionChanged(this DateTimePickerPanel control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.SelectionChanged += h, h => control.SelectionChanged -= h);
}
}
public static partial class PickerPresenterBaseEventsExtensions
{
public static PickerPresenterBase OnConfirmed(this PickerPresenterBase control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Confirmed += h, h => control.Confirmed -= h);
}
public static PickerPresenterBase OnDismissed(this PickerPresenterBase control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Dismissed += h, h => control.Dismissed -= h);
}
}
public static partial class FlyoutBaseEventsExtensions
{
public static FlyoutBase OnClosed(this FlyoutBase control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Closed += h, h => control.Closed -= h);
}
public static FlyoutBase OnClosing(this FlyoutBase control, Action<CancelEventArgs> action) {
void Handler(object sender, CancelEventArgs args) => action(args);
return control._setEvent((EventHandler<CancelEventArgs>) Handler, h => control.Closing += h, h => control.Closing -= h);
}
public static FlyoutBase OnOpened(this FlyoutBase control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Opened += h, h => control.Opened -= h);
}
public static FlyoutBase OnOpening(this FlyoutBase control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Opening += h, h => control.Opening -= h);
}
}
public static partial class PopupEventsExtensions
{
public static Popup OnClosed(this Popup control, Action<EventArgs> action) {
void Handler(object sender, EventArgs args) => action(args);
return control._setEvent((EventHandler<EventArgs>) Handler, h => control.Closed += h, h => control.Closed -= h);
}
public static Popup OnOpened(this Popup control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Opened += h, h => control.Opened -= h);
}
}
public static partial class ScrollBarEventsExtensions
{
public static ScrollBar OnScroll(this ScrollBar control, Action<ScrollEventArgs> action) {
void Handler(object sender, ScrollEventArgs args) => action(args);
return control._setEvent((EventHandler<ScrollEventArgs>) Handler, h => control.Scroll += h, h => control.Scroll -= h);
}
}
public static partial class SelectingItemsControlEventsExtensions
{
public static SelectingItemsControl OnSelectionChanged(this SelectingItemsControl control, Action<SelectionChangedEventArgs> action) {
void Handler(object sender, SelectionChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<SelectionChangedEventArgs>) Handler, h => control.SelectionChanged += h, h => control.SelectionChanged -= h);
}
}
public static partial class TemplatedControlEventsExtensions
{
public static TemplatedControl OnTemplateApplied(this TemplatedControl control, Action<TemplateAppliedEventArgs> action) {
void Handler(object sender, TemplateAppliedEventArgs args) => action(args);
return control._setEvent((EventHandler<TemplateAppliedEventArgs>) Handler, h => control.TemplateApplied += h, h => control.TemplateApplied -= h);
}
}
public static partial class ThumbEventsExtensions
{
public static Thumb OnDragStarted(this Thumb control, Action<VectorEventArgs> action) {
void Handler(object sender, VectorEventArgs args) => action(args);
return control._setEvent((EventHandler<VectorEventArgs>) Handler, h => control.DragStarted += h, h => control.DragStarted -= h);
}
public static Thumb OnDragDelta(this Thumb control, Action<VectorEventArgs> action) {
void Handler(object sender, VectorEventArgs args) => action(args);
return control._setEvent((EventHandler<VectorEventArgs>) Handler, h => control.DragDelta += h, h => control.DragDelta -= h);
}
public static Thumb OnDragCompleted(this Thumb control, Action<VectorEventArgs> action) {
void Handler(object sender, VectorEventArgs args) => action(args);
return control._setEvent((EventHandler<VectorEventArgs>) Handler, h => control.DragCompleted += h, h => control.DragCompleted -= h);
}
}
public static partial class ToggleButtonEventsExtensions
{
public static ToggleButton OnChecked(this ToggleButton control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.Checked += h, h => control.Checked -= h);
}
public static ToggleButton OnUnchecked(this ToggleButton control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.Unchecked += h, h => control.Unchecked -= h);
}
public static ToggleButton OnIndeterminate(this ToggleButton control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.Indeterminate += h, h => control.Indeterminate -= h);
}
}
public static partial class InputElementEventsExtensions
{
public static InputElement OnGotFocus(this InputElement control, Action<GotFocusEventArgs> action) {
void Handler(object sender, GotFocusEventArgs args) => action(args);
return control._setEvent((EventHandler<GotFocusEventArgs>) Handler, h => control.GotFocus += h, h => control.GotFocus -= h);
}
public static InputElement OnLostFocus(this InputElement control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.LostFocus += h, h => control.LostFocus -= h);
}
public static InputElement OnKeyDown(this InputElement control, Action<KeyEventArgs> action) {
void Handler(object sender, KeyEventArgs args) => action(args);
return control._setEvent((EventHandler<KeyEventArgs>) Handler, h => control.KeyDown += h, h => control.KeyDown -= h);
}
public static InputElement OnKeyUp(this InputElement control, Action<KeyEventArgs> action) {
void Handler(object sender, KeyEventArgs args) => action(args);
return control._setEvent((EventHandler<KeyEventArgs>) Handler, h => control.KeyUp += h, h => control.KeyUp -= h);
}
public static InputElement OnTextInput(this InputElement control, Action<TextInputEventArgs> action) {
void Handler(object sender, TextInputEventArgs args) => action(args);
return control._setEvent((EventHandler<TextInputEventArgs>) Handler, h => control.TextInput += h, h => control.TextInput -= h);
}
public static InputElement OnTextInputMethodClientRequested(this InputElement control, Action<TextInputMethodClientRequestedEventArgs> action) {
void Handler(object sender, TextInputMethodClientRequestedEventArgs args) => action(args);
return control._setEvent((EventHandler<TextInputMethodClientRequestedEventArgs>) Handler, h => control.TextInputMethodClientRequested += h, h => control.TextInputMethodClientRequested -= h);
}
public static InputElement OnTextInputOptionsQuery(this InputElement control, Action<TextInputOptionsQueryEventArgs> action) {
void Handler(object sender, TextInputOptionsQueryEventArgs args) => action(args);
return control._setEvent((EventHandler<TextInputOptionsQueryEventArgs>) Handler, h => control.TextInputOptionsQuery += h, h => control.TextInputOptionsQuery -= h);
}
public static InputElement OnPointerEnter(this InputElement control, Action<PointerEventArgs> action) {
void Handler(object sender, PointerEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerEventArgs>) Handler, h => control.PointerEnter += h, h => control.PointerEnter -= h);
}
public static InputElement OnPointerLeave(this InputElement control, Action<PointerEventArgs> action) {
void Handler(object sender, PointerEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerEventArgs>) Handler, h => control.PointerLeave += h, h => control.PointerLeave -= h);
}
public static InputElement OnPointerMoved(this InputElement control, Action<PointerEventArgs> action) {
void Handler(object sender, PointerEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerEventArgs>) Handler, h => control.PointerMoved += h, h => control.PointerMoved -= h);
}
public static InputElement OnPointerPressed(this InputElement control, Action<PointerPressedEventArgs> action) {
void Handler(object sender, PointerPressedEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerPressedEventArgs>) Handler, h => control.PointerPressed += h, h => control.PointerPressed -= h);
}
public static InputElement OnPointerReleased(this InputElement control, Action<PointerReleasedEventArgs> action) {
void Handler(object sender, PointerReleasedEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerReleasedEventArgs>) Handler, h => control.PointerReleased += h, h => control.PointerReleased -= h);
}
public static InputElement OnPointerCaptureLost(this InputElement control, Action<PointerCaptureLostEventArgs> action) {
void Handler(object sender, PointerCaptureLostEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerCaptureLostEventArgs>) Handler, h => control.PointerCaptureLost += h, h => control.PointerCaptureLost -= h);
}
public static InputElement OnPointerWheelChanged(this InputElement control, Action<PointerWheelEventArgs> action) {
void Handler(object sender, PointerWheelEventArgs args) => action(args);
return control._setEvent((EventHandler<PointerWheelEventArgs>) Handler, h => control.PointerWheelChanged += h, h => control.PointerWheelChanged -= h);
}
public static InputElement OnTapped(this InputElement control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.Tapped += h, h => control.Tapped -= h);
}
public static InputElement OnDoubleTapped(this InputElement control, Action<RoutedEventArgs> action) {
void Handler(object sender, RoutedEventArgs args) => action(args);
return control._setEvent((EventHandler<RoutedEventArgs>) Handler, h => control.DoubleTapped += h, h => control.DoubleTapped -= h);
}
}
public static partial class AttachedLayoutEventsExtensions
{
public static AttachedLayout OnMeasureInvalidated(this AttachedLayout control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.MeasureInvalidated += h, h => control.MeasureInvalidated -= h);
}
public static AttachedLayout OnArrangeInvalidated(this AttachedLayout control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.ArrangeInvalidated += h, h => control.ArrangeInvalidated -= h);
}
}
public static partial class LayoutableEventsExtensions
{
public static Layoutable OnEffectiveViewportChanged(this Layoutable control, Action<EffectiveViewportChangedEventArgs> action) {
void Handler(object sender, EffectiveViewportChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<EffectiveViewportChangedEventArgs>) Handler, h => control.EffectiveViewportChanged += h, h => control.EffectiveViewportChanged -= h);
}
public static Layoutable OnLayoutUpdated(this Layoutable control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.LayoutUpdated += h, h => control.LayoutUpdated -= h);
}
}
public static partial class VisualEventsExtensions
{
public static Visual OnAttachedToVisualTree(this Visual control, Action<VisualTreeAttachmentEventArgs> action) {
void Handler(object sender, VisualTreeAttachmentEventArgs args) => action(args);
return control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>) Handler, h => control.AttachedToVisualTree += h, h => control.AttachedToVisualTree -= h);
}
public static Visual OnDetachedFromVisualTree(this Visual control, Action<VisualTreeAttachmentEventArgs> action) {
void Handler(object sender, VisualTreeAttachmentEventArgs args) => action(args);
return control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>) Handler, h => control.DetachedFromVisualTree += h, h => control.DetachedFromVisualTree -= h);
}
}
public static partial class BrushEventsExtensions
{
public static Brush OnInvalidated(this Brush control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Invalidated += h, h => control.Invalidated -= h);
}
}
public static partial class DashStyleEventsExtensions
{
public static DashStyle OnInvalidated(this DashStyle control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Invalidated += h, h => control.Invalidated -= h);
}
}
public static partial class DrawingImageEventsExtensions
{
public static DrawingImage OnInvalidated(this DrawingImage control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Invalidated += h, h => control.Invalidated -= h);
}
}
public static partial class ExperimentalAcrylicMaterialEventsExtensions
{
public static ExperimentalAcrylicMaterial OnInvalidated(this ExperimentalAcrylicMaterial control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Invalidated += h, h => control.Invalidated -= h);
}
}
public static partial class GeometryEventsExtensions
{
public static Geometry OnChanged(this Geometry control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Changed += h, h => control.Changed -= h);
}
}
public static partial class PenEventsExtensions
{
public static Pen OnInvalidated(this Pen control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Invalidated += h, h => control.Invalidated -= h);
}
}
public static partial class TransformEventsExtensions
{
public static Transform OnChanged(this Transform control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Changed += h, h => control.Changed -= h);
}
}
public static partial class CroppedBitmapEventsExtensions
{
public static CroppedBitmap OnInvalidated(this CroppedBitmap control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Invalidated += h, h => control.Invalidated -= h);
}
}
public static partial class StyledElementEventsExtensions
{
public static StyledElement OnAttachedToLogicalTree(this StyledElement control, Action<LogicalTreeAttachmentEventArgs> action) {
void Handler(object sender, LogicalTreeAttachmentEventArgs args) => action(args);
return control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>) Handler, h => control.AttachedToLogicalTree += h, h => control.AttachedToLogicalTree -= h);
}
public static StyledElement OnDetachedFromLogicalTree(this StyledElement control, Action<LogicalTreeAttachmentEventArgs> action) {
void Handler(object sender, LogicalTreeAttachmentEventArgs args) => action(args);
return control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>) Handler, h => control.DetachedFromLogicalTree += h, h => control.DetachedFromLogicalTree -= h);
}
public static StyledElement OnDataContextChanged(this StyledElement control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.DataContextChanged += h, h => control.DataContextChanged -= h);
}
public static StyledElement OnInitialized(this StyledElement control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.Initialized += h, h => control.Initialized -= h);
}
public static StyledElement OnResourcesChanged(this StyledElement control, Action<ResourcesChangedEventArgs> action) {
void Handler(object sender, ResourcesChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<ResourcesChangedEventArgs>) Handler, h => control.ResourcesChanged += h, h => control.ResourcesChanged -= h);
}
}
public static partial class StyleEventsExtensions
{
public static Style OnOwnerChanged(this Style control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.OwnerChanged += h, h => control.OwnerChanged -= h);
}
}
public static partial class StylesEventsExtensions
{
public static Styles OnCollectionChanged(this Styles control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((NotifyCollectionChangedEventHandler) Handler, h => control.CollectionChanged += h, h => control.CollectionChanged -= h);
}
public static Styles OnOwnerChanged(this Styles control, Action action) {
void Handler(object sender, EventArgs args) => action();
return control._setEvent((EventHandler) Handler, h => control.OwnerChanged += h, h => control.OwnerChanged -= h);
}
}
public static partial class AvaloniaObjectEventsExtensions
{
public static AvaloniaObject OnPropertyChanged(this AvaloniaObject control, Action<AvaloniaPropertyChangedEventArgs> action) {
void Handler(object sender, AvaloniaPropertyChangedEventArgs args) => action(args);
return control._setEvent((EventHandler<AvaloniaPropertyChangedEventArgs>) Handler, h => control.PropertyChanged += h, h => control.PropertyChanged -= h);
}
}


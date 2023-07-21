using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Controls.Presenters;
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
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ApplicationEventsExtensions
{
    public static Application OnResourcesChanged(this Application control, Action<ResourcesChangedEventArgs> action) => 
        control._setEvent((EventHandler<ResourcesChangedEventArgs>) ((_, args) => action(args)), h => control.ResourcesChanged += h);
    public static Application OnUrlsOpened(this Application control, Action<UrlOpenedEventArgs> action) => 
        control._setEvent((EventHandler<UrlOpenedEventArgs>) ((_, args) => action(args)), h => control.UrlsOpened += h);
    public static Application OnActualThemeVariantChanged(this Application control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ActualThemeVariantChanged += h);
}
public static partial class AutoCompleteBoxEventsExtensions
{
    public static AutoCompleteBox OnTextChanged(this AutoCompleteBox control, Action<TextChangedEventArgs> action) => 
        control._setEvent((EventHandler<TextChangedEventArgs>) ((_, args) => action(args)), h => control.TextChanged += h);
    public static AutoCompleteBox OnPopulating(this AutoCompleteBox control, Action<PopulatingEventArgs> action) => 
        control._setEvent((EventHandler<PopulatingEventArgs>) ((_, args) => action(args)), h => control.Populating += h);
    public static AutoCompleteBox OnPopulated(this AutoCompleteBox control, Action<PopulatedEventArgs> action) => 
        control._setEvent((EventHandler<PopulatedEventArgs>) ((_, args) => action(args)), h => control.Populated += h);
    public static AutoCompleteBox OnDropDownOpening(this AutoCompleteBox control, Action<CancelEventArgs> action) => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.DropDownOpening += h);
    public static AutoCompleteBox OnDropDownOpened(this AutoCompleteBox control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownOpened += h);
    public static AutoCompleteBox OnDropDownClosing(this AutoCompleteBox control, Action<CancelEventArgs> action) => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.DropDownClosing += h);
    public static AutoCompleteBox OnDropDownClosed(this AutoCompleteBox control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownClosed += h);
    public static AutoCompleteBox OnSelectionChanged(this AutoCompleteBox control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectionChanged += h);
}
public static partial class ButtonEventsExtensions
{
    public static Button OnClick(this Button control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Click += h);
}
public static partial class CalendarDatePickerEventsExtensions
{
    public static CalendarDatePicker OnCalendarClosed(this CalendarDatePicker control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CalendarClosed += h);
    public static CalendarDatePicker OnCalendarOpened(this CalendarDatePicker control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CalendarOpened += h);
    public static CalendarDatePicker OnDateValidationError(this CalendarDatePicker control, Action<CalendarDatePickerDateValidationErrorEventArgs> action) => 
        control._setEvent((EventHandler<CalendarDatePickerDateValidationErrorEventArgs>) ((_, args) => action(args)), h => control.DateValidationError += h);
    public static CalendarDatePicker OnSelectedDateChanged(this CalendarDatePicker control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDateChanged += h);
}
public static partial class CalendarEventsExtensions
{
    public static Calendar OnSelectedDatesChanged(this Calendar control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDatesChanged += h);
    public static Calendar OnDisplayDateChanged(this Calendar control, Action<CalendarDateChangedEventArgs> action) => 
        control._setEvent((EventHandler<CalendarDateChangedEventArgs>) ((_, args) => action(args)), h => control.DisplayDateChanged += h);
    public static Calendar OnDisplayModeChanged(this Calendar control, Action<CalendarModeChangedEventArgs> action) => 
        control._setEvent((EventHandler<CalendarModeChangedEventArgs>) ((_, args) => action(args)), h => control.DisplayModeChanged += h);
}
public static partial class ComboBoxEventsExtensions
{
    public static ComboBox OnDropDownClosed(this ComboBox control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownClosed += h);
    public static ComboBox OnDropDownOpened(this ComboBox control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownOpened += h);
}
public static partial class ContextMenuEventsExtensions
{
    public static ContextMenu OnOpening(this ContextMenu control, Action action) => 
        control._setEvent((CancelEventHandler) ((_, args) => action()), h => control.Opening += h);
    public static ContextMenu OnClosing(this ContextMenu control, Action action) => 
        control._setEvent((CancelEventHandler) ((_, args) => action()), h => control.Closing += h);
}
public static partial class ControlEventsExtensions
{
    public static Control OnContextRequested(this Control control, Action<ContextRequestedEventArgs> action) => 
        control._setEvent((EventHandler<ContextRequestedEventArgs>) ((_, args) => action(args)), h => control.ContextRequested += h);
    public static Control OnLoaded(this Control control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Loaded += h);
    public static Control OnUnloaded(this Control control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Unloaded += h);
    public static Control OnSizeChanged(this Control control, Action<SizeChangedEventArgs> action) => 
        control._setEvent((EventHandler<SizeChangedEventArgs>) ((_, args) => action(args)), h => control.SizeChanged += h);
}
public static partial class DatePickerEventsExtensions
{
    public static DatePicker OnSelectedDateChanged(this DatePicker control, Action<DatePickerSelectedValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<DatePickerSelectedValueChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDateChanged += h);
}
public static partial class TimePickerEventsExtensions
{
    public static TimePicker OnSelectedTimeChanged(this TimePicker control, Action<TimePickerSelectedValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<TimePickerSelectedValueChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedTimeChanged += h);
}
public static partial class ExpanderEventsExtensions
{
    public static Expander OnCollapsed(this Expander control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Collapsed += h);
    public static Expander OnCollapsing(this Expander control, Action<CancelRoutedEventArgs> action) => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.Collapsing += h);
    public static Expander OnExpanded(this Expander control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Expanded += h);
    public static Expander OnExpanding(this Expander control, Action<CancelRoutedEventArgs> action) => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.Expanding += h);
}
public static partial class ItemsControlEventsExtensions
{
    public static ItemsControl OnContainerPrepared(this ItemsControl control, Action<ContainerPreparedEventArgs> action) => 
        control._setEvent((EventHandler<ContainerPreparedEventArgs>) ((_, args) => action(args)), h => control.ContainerPrepared += h);
    public static ItemsControl OnContainerIndexChanged(this ItemsControl control, Action<ContainerIndexChangedEventArgs> action) => 
        control._setEvent((EventHandler<ContainerIndexChangedEventArgs>) ((_, args) => action(args)), h => control.ContainerIndexChanged += h);
    public static ItemsControl OnContainerClearing(this ItemsControl control, Action<ContainerClearingEventArgs> action) => 
        control._setEvent((EventHandler<ContainerClearingEventArgs>) ((_, args) => action(args)), h => control.ContainerClearing += h);
}
public static partial class MenuBaseEventsExtensions
{
    public static MenuBase OnOpened(this MenuBase control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Opened += h);
    public static MenuBase OnClosed(this MenuBase control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Closed += h);
}
public static partial class MenuItemEventsExtensions
{
    public static MenuItem OnClick(this MenuItem control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Click += h);
    public static MenuItem OnPointerEnteredItem(this MenuItem control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PointerEnteredItem += h);
    public static MenuItem OnPointerExitedItem(this MenuItem control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PointerExitedItem += h);
    public static MenuItem OnSubmenuOpened(this MenuItem control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.SubmenuOpened += h);
}
public static partial class NativeMenuEventsExtensions
{
    public static NativeMenu OnNeedsUpdate(this NativeMenu control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.NeedsUpdate += h);
    public static NativeMenu OnOpening(this NativeMenu control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Opening += h);
    public static NativeMenu OnClosed(this NativeMenu control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Closed += h);
}
public static partial class NativeMenuItemEventsExtensions
{
    public static NativeMenuItem OnClick(this NativeMenuItem control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Click += h);
}
public static partial class NumericUpDownEventsExtensions
{
    public static NumericUpDown OnSpinned(this NumericUpDown control, Action<SpinEventArgs> action) => 
        control._setEvent((EventHandler<SpinEventArgs>) ((_, args) => action(args)), h => control.Spinned += h);
    public static NumericUpDown OnValueChanged(this NumericUpDown control, Action<NumericUpDownValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<NumericUpDownValueChangedEventArgs>) ((_, args) => action(args)), h => control.ValueChanged += h);
}
public static partial class RefreshContainerEventsExtensions
{
    public static RefreshContainer OnRefreshRequested(this RefreshContainer control, Action<RefreshRequestedEventArgs> action) => 
        control._setEvent((EventHandler<RefreshRequestedEventArgs>) ((_, args) => action(args)), h => control.RefreshRequested += h);
}
public static partial class RefreshVisualizerEventsExtensions
{
    public static RefreshVisualizer OnRefreshRequested(this RefreshVisualizer control, Action<RefreshRequestedEventArgs> action) => 
        control._setEvent((EventHandler<RefreshRequestedEventArgs>) ((_, args) => action(args)), h => control.RefreshRequested += h);
}
public static partial class ScrollViewerEventsExtensions
{
    public static ScrollViewer OnScrollChanged(this ScrollViewer control, Action<ScrollChangedEventArgs> action) => 
        control._setEvent((EventHandler<ScrollChangedEventArgs>) ((_, args) => action(args)), h => control.ScrollChanged += h);
}
public static partial class SelectableTextBlockEventsExtensions
{
    public static SelectableTextBlock OnCopyingToClipboard(this SelectableTextBlock control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CopyingToClipboard += h);
}
public static partial class SpinnerEventsExtensions
{
    public static Spinner OnSpin(this Spinner control, Action<SpinEventArgs> action) => 
        control._setEvent((EventHandler<SpinEventArgs>) ((_, args) => action(args)), h => control.Spin += h);
}
public static partial class SplitButtonEventsExtensions
{
    public static SplitButton OnClick(this SplitButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Click += h);
}
public static partial class ToggleSplitButtonEventsExtensions
{
    public static ToggleSplitButton OnIsCheckedChanged(this ToggleSplitButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.IsCheckedChanged += h);
}
public static partial class SplitViewEventsExtensions
{
    public static SplitView OnPaneClosed(this SplitView control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PaneClosed += h);
    public static SplitView OnPaneClosing(this SplitView control, Action<CancelRoutedEventArgs> action) => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.PaneClosing += h);
    public static SplitView OnPaneOpened(this SplitView control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PaneOpened += h);
    public static SplitView OnPaneOpening(this SplitView control, Action<CancelRoutedEventArgs> action) => 
        control._setEvent((EventHandler<CancelRoutedEventArgs>) ((_, args) => action(args)), h => control.PaneOpening += h);
}
public static partial class StackPanelEventsExtensions
{
    public static StackPanel OnHorizontalSnapPointsChanged(this StackPanel control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.HorizontalSnapPointsChanged += h);
    public static StackPanel OnVerticalSnapPointsChanged(this StackPanel control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.VerticalSnapPointsChanged += h);
}
public static partial class TextBoxEventsExtensions
{
    public static TextBox OnCopyingToClipboard(this TextBox control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CopyingToClipboard += h);
    public static TextBox OnCuttingToClipboard(this TextBox control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CuttingToClipboard += h);
    public static TextBox OnPastingFromClipboard(this TextBox control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PastingFromClipboard += h);
    public static TextBox OnTextChanged(this TextBox control, Action<TextChangedEventArgs> action) => 
        control._setEvent((EventHandler<TextChangedEventArgs>) ((_, args) => action(args)), h => control.TextChanged += h);
    public static TextBox OnTextChanging(this TextBox control, Action<TextChangingEventArgs> action) => 
        control._setEvent((EventHandler<TextChangingEventArgs>) ((_, args) => action(args)), h => control.TextChanging += h);
}
public static partial class TopLevelEventsExtensions
{
    public static TopLevel OnOpened(this TopLevel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opened += h);
    public static TopLevel OnClosed(this TopLevel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Closed += h);
    public static TopLevel OnScalingChanged(this TopLevel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ScalingChanged += h);
    public static TopLevel OnBackRequested(this TopLevel control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.BackRequested += h);
}
public static partial class TrayIconEventsExtensions
{
    public static TrayIcon OnClicked(this TrayIcon control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Clicked += h);
}
public static partial class TreeViewEventsExtensions
{
    public static TreeView OnSelectionChanged(this TreeView control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectionChanged += h);
}
public static partial class VirtualizingStackPanelEventsExtensions
{
    public static VirtualizingStackPanel OnHorizontalSnapPointsChanged(this VirtualizingStackPanel control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.HorizontalSnapPointsChanged += h);
    public static VirtualizingStackPanel OnVerticalSnapPointsChanged(this VirtualizingStackPanel control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.VerticalSnapPointsChanged += h);
}
public static partial class WindowEventsExtensions
{
    public static Window OnClosing(this Window control, Action<WindowClosingEventArgs> action) => 
        control._setEvent((EventHandler<WindowClosingEventArgs>) ((_, args) => action(args)), h => control.Closing += h);
}
public static partial class WindowBaseEventsExtensions
{
    public static WindowBase OnActivated(this WindowBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Activated += h);
    public static WindowBase OnDeactivated(this WindowBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Deactivated += h);
    public static WindowBase OnPositionChanged(this WindowBase control, Action<PixelPointEventArgs> action) => 
        control._setEvent((EventHandler<PixelPointEventArgs>) ((_, args) => action(args)), h => control.PositionChanged += h);
    public static WindowBase OnResized(this WindowBase control, Action<WindowResizedEventArgs> action) => 
        control._setEvent((EventHandler<WindowResizedEventArgs>) ((_, args) => action(args)), h => control.Resized += h);
}
public static partial class TextPresenterEventsExtensions
{
    public static TextPresenter OnCaretBoundsChanged(this TextPresenter control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CaretBoundsChanged += h);
}
public static partial class NotificationCardEventsExtensions
{
    public static NotificationCard OnNotificationClosed(this NotificationCard control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.NotificationClosed += h);
}
public static partial class CalendarButtonEventsExtensions
{
    public static CalendarButton OnCalendarLeftMouseButtonDown(this CalendarButton control, Action<PointerPressedEventArgs> action) => 
        control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => control.CalendarLeftMouseButtonDown += h);
    public static CalendarButton OnCalendarLeftMouseButtonUp(this CalendarButton control, Action<PointerReleasedEventArgs> action) => 
        control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => control.CalendarLeftMouseButtonUp += h);
}
public static partial class CalendarDayButtonEventsExtensions
{
    public static CalendarDayButton OnCalendarDayButtonMouseDown(this CalendarDayButton control, Action<PointerPressedEventArgs> action) => 
        control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => control.CalendarDayButtonMouseDown += h);
    public static CalendarDayButton OnCalendarDayButtonMouseUp(this CalendarDayButton control, Action<PointerReleasedEventArgs> action) => 
        control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => control.CalendarDayButtonMouseUp += h);
}
public static partial class DateTimePickerPanelEventsExtensions
{
    public static DateTimePickerPanel OnScrollInvalidated(this DateTimePickerPanel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ScrollInvalidated += h);
    public static DateTimePickerPanel OnSelectionChanged(this DateTimePickerPanel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.SelectionChanged += h);
}
public static partial class PickerPresenterBaseEventsExtensions
{
    public static PickerPresenterBase OnConfirmed(this PickerPresenterBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Confirmed += h);
    public static PickerPresenterBase OnDismissed(this PickerPresenterBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Dismissed += h);
}
public static partial class FlyoutBaseEventsExtensions
{
    public static FlyoutBase OnOpened(this FlyoutBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opened += h);
    public static FlyoutBase OnClosed(this FlyoutBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Closed += h);
}
public static partial class PopupFlyoutBaseEventsExtensions
{
    public static PopupFlyoutBase OnClosing(this PopupFlyoutBase control, Action<CancelEventArgs> action) => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.Closing += h);
    public static PopupFlyoutBase OnOpening(this PopupFlyoutBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opening += h);
}
public static partial class PopupEventsExtensions
{
    public static Popup OnClosed(this Popup control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Closed += h);
    public static Popup OnOpened(this Popup control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opened += h);
}
public static partial class RangeBaseEventsExtensions
{
    public static RangeBase OnValueChanged(this RangeBase control, Action<RangeBaseValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<RangeBaseValueChangedEventArgs>) ((_, args) => action(args)), h => control.ValueChanged += h);
}
public static partial class ScrollBarEventsExtensions
{
    public static ScrollBar OnScroll(this ScrollBar control, Action<ScrollEventArgs> action) => 
        control._setEvent((EventHandler<ScrollEventArgs>) ((_, args) => action(args)), h => control.Scroll += h);
}
public static partial class SelectingItemsControlEventsExtensions
{
    public static SelectingItemsControl OnSelectionChanged(this SelectingItemsControl control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectionChanged += h);
}
public static partial class TemplatedControlEventsExtensions
{
    public static TemplatedControl OnTemplateApplied(this TemplatedControl control, Action<TemplateAppliedEventArgs> action) => 
        control._setEvent((EventHandler<TemplateAppliedEventArgs>) ((_, args) => action(args)), h => control.TemplateApplied += h);
}
public static partial class ThumbEventsExtensions
{
    public static Thumb OnDragStarted(this Thumb control, Action<VectorEventArgs> action) => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragStarted += h);
    public static Thumb OnDragDelta(this Thumb control, Action<VectorEventArgs> action) => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragDelta += h);
    public static Thumb OnDragCompleted(this Thumb control, Action<VectorEventArgs> action) => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragCompleted += h);
}
public static partial class ToggleButtonEventsExtensions
{
	[Obsolete("Use IsCheckedChanged instead.")]
    public static ToggleButton OnChecked(this ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Checked += h);
	[Obsolete("Use IsCheckedChanged instead.")]
    public static ToggleButton OnUnchecked(this ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Unchecked += h);
	[Obsolete("Use IsCheckedChanged instead.")]
    public static ToggleButton OnIndeterminate(this ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Indeterminate += h);
    public static ToggleButton OnIsCheckedChanged(this ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.IsCheckedChanged += h);
}
public static partial class AvaloniaObjectEventsExtensions
{
    public static AvaloniaObject OnPropertyChanged(this AvaloniaObject control, Action<AvaloniaPropertyChangedEventArgs> action) => 
        control._setEvent((EventHandler<AvaloniaPropertyChangedEventArgs>) ((_, args) => action(args)), h => control.PropertyChanged += h);
}
public static partial class StyledElementEventsExtensions
{
    public static StyledElement OnAttachedToLogicalTree(this StyledElement control, Action<LogicalTreeAttachmentEventArgs> action) => 
        control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.AttachedToLogicalTree += h);
    public static StyledElement OnDetachedFromLogicalTree(this StyledElement control, Action<LogicalTreeAttachmentEventArgs> action) => 
        control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.DetachedFromLogicalTree += h);
    public static StyledElement OnDataContextChanged(this StyledElement control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DataContextChanged += h);
    public static StyledElement OnInitialized(this StyledElement control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Initialized += h);
    public static StyledElement OnResourcesChanged(this StyledElement control, Action<ResourcesChangedEventArgs> action) => 
        control._setEvent((EventHandler<ResourcesChangedEventArgs>) ((_, args) => action(args)), h => control.ResourcesChanged += h);
    public static StyledElement OnActualThemeVariantChanged(this StyledElement control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ActualThemeVariantChanged += h);
}
public static partial class VisualEventsExtensions
{
    public static Visual OnAttachedToVisualTree(this Visual control, Action<VisualTreeAttachmentEventArgs> action) => 
        control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.AttachedToVisualTree += h);
    public static Visual OnDetachedFromVisualTree(this Visual control, Action<VisualTreeAttachmentEventArgs> action) => 
        control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.DetachedFromVisualTree += h);
}
public static partial class StyleBaseEventsExtensions
{
    public static StyleBase OnOwnerChanged(this StyleBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.OwnerChanged += h);
}
public static partial class StylesEventsExtensions
{
    public static Styles OnCollectionChanged(this Styles control, Action action) => 
        control._setEvent((NotifyCollectionChangedEventHandler) ((_, args) => action()), h => control.CollectionChanged += h);
    public static Styles OnOwnerChanged(this Styles control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.OwnerChanged += h);
}
public static partial class LayoutableEventsExtensions
{
    public static Layoutable OnEffectiveViewportChanged(this Layoutable control, Action<EffectiveViewportChangedEventArgs> action) => 
        control._setEvent((EventHandler<EffectiveViewportChangedEventArgs>) ((_, args) => action(args)), h => control.EffectiveViewportChanged += h);
    public static Layoutable OnLayoutUpdated(this Layoutable control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.LayoutUpdated += h);
}
public static partial class InputElementEventsExtensions
{
    public static InputElement OnGotFocus(this InputElement control, Action<GotFocusEventArgs> action) => 
        control._setEvent((EventHandler<GotFocusEventArgs>) ((_, args) => action(args)), h => control.GotFocus += h);
    public static InputElement OnLostFocus(this InputElement control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.LostFocus += h);
    public static InputElement OnKeyDown(this InputElement control, Action<KeyEventArgs> action) => 
        control._setEvent((EventHandler<KeyEventArgs>) ((_, args) => action(args)), h => control.KeyDown += h);
    public static InputElement OnKeyUp(this InputElement control, Action<KeyEventArgs> action) => 
        control._setEvent((EventHandler<KeyEventArgs>) ((_, args) => action(args)), h => control.KeyUp += h);
    public static InputElement OnTextInput(this InputElement control, Action<TextInputEventArgs> action) => 
        control._setEvent((EventHandler<TextInputEventArgs>) ((_, args) => action(args)), h => control.TextInput += h);
    public static InputElement OnTextInputMethodClientRequested(this InputElement control, Action<TextInputMethodClientRequestedEventArgs> action) => 
        control._setEvent((EventHandler<TextInputMethodClientRequestedEventArgs>) ((_, args) => action(args)), h => control.TextInputMethodClientRequested += h);
    public static InputElement OnPointerEntered(this InputElement control, Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerEntered += h);
    public static InputElement OnPointerExited(this InputElement control, Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerExited += h);
    public static InputElement OnPointerMoved(this InputElement control, Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerMoved += h);
    public static InputElement OnPointerPressed(this InputElement control, Action<PointerPressedEventArgs> action) => 
        control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => control.PointerPressed += h);
    public static InputElement OnPointerReleased(this InputElement control, Action<PointerReleasedEventArgs> action) => 
        control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => control.PointerReleased += h);
    public static InputElement OnPointerCaptureLost(this InputElement control, Action<PointerCaptureLostEventArgs> action) => 
        control._setEvent((EventHandler<PointerCaptureLostEventArgs>) ((_, args) => action(args)), h => control.PointerCaptureLost += h);
    public static InputElement OnPointerWheelChanged(this InputElement control, Action<PointerWheelEventArgs> action) => 
        control._setEvent((EventHandler<PointerWheelEventArgs>) ((_, args) => action(args)), h => control.PointerWheelChanged += h);
    public static InputElement OnTapped(this InputElement control, Action<TappedEventArgs> action) => 
        control._setEvent((EventHandler<TappedEventArgs>) ((_, args) => action(args)), h => control.Tapped += h);
    public static InputElement OnHolding(this InputElement control, Action<HoldingRoutedEventArgs> action) => 
        control._setEvent((EventHandler<HoldingRoutedEventArgs>) ((_, args) => action(args)), h => control.Holding += h);
    public static InputElement OnDoubleTapped(this InputElement control, Action<TappedEventArgs> action) => 
        control._setEvent((EventHandler<TappedEventArgs>) ((_, args) => action(args)), h => control.DoubleTapped += h);
}
public static partial class DrawingImageEventsExtensions
{
    public static DrawingImage OnInvalidated(this DrawingImage control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}
public static partial class EffectEventsExtensions
{
    public static Effect OnInvalidated(this Effect control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}
public static partial class ExperimentalAcrylicMaterialEventsExtensions
{
    public static ExperimentalAcrylicMaterial OnInvalidated(this ExperimentalAcrylicMaterial control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}
public static partial class GeometryEventsExtensions
{
    public static Geometry OnChanged(this Geometry control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Changed += h);
}
public static partial class TransformEventsExtensions
{
    public static Transform OnChanged(this Transform control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Changed += h);
}
public static partial class CroppedBitmapEventsExtensions
{
    public static CroppedBitmap OnInvalidated(this CroppedBitmap control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}


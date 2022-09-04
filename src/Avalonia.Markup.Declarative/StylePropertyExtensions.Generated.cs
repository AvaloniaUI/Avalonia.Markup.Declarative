using Avalonia;
using Avalonia.Animation;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Controls.Notifications;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Primitives.PopupPositioning;
using Avalonia.Controls.Selection;
using Avalonia.Controls.Shapes;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Avalonia.Input.GestureRecognizers;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Styling;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class AutoCompleteBoxExtensions
{
    public static Style<AutoCompleteBox> Watermark(this Style<AutoCompleteBox> style, String value)
    => style._addSetter(AutoCompleteBox.WatermarkProperty, value);
    public static Style<AutoCompleteBox> MinimumPrefixLength(this Style<AutoCompleteBox> style, Int32 value)
    => style._addSetter(AutoCompleteBox.MinimumPrefixLengthProperty, value);
    public static Style<AutoCompleteBox> MinimumPopulateDelay(this Style<AutoCompleteBox> style, TimeSpan value)
    => style._addSetter(AutoCompleteBox.MinimumPopulateDelayProperty, value);
    public static Style<AutoCompleteBox> MaxDropDownHeight(this Style<AutoCompleteBox> style, Double value)
    => style._addSetter(AutoCompleteBox.MaxDropDownHeightProperty, value);
    public static Style<AutoCompleteBox> IsTextCompletionEnabled(this Style<AutoCompleteBox> style, Boolean value)
    => style._addSetter(AutoCompleteBox.IsTextCompletionEnabledProperty, value);
    public static Style<AutoCompleteBox> ItemTemplate(this Style<AutoCompleteBox> style, IDataTemplate value)
    => style._addSetter(AutoCompleteBox.ItemTemplateProperty, value);
    public static Style<AutoCompleteBox> IsDropDownOpen(this Style<AutoCompleteBox> style, Boolean value)
    => style._addSetter(AutoCompleteBox.IsDropDownOpenProperty, value);
    public static Style<AutoCompleteBox> SelectedItem(this Style<AutoCompleteBox> style, Object value)
    => style._addSetter(AutoCompleteBox.SelectedItemProperty, value);
    public static Style<AutoCompleteBox> Text(this Style<AutoCompleteBox> style, String value)
    => style._addSetter(AutoCompleteBox.TextProperty, value);
    public static Style<AutoCompleteBox> FilterMode(this Style<AutoCompleteBox> style, AutoCompleteFilterMode value)
    => style._addSetter(AutoCompleteBox.FilterModeProperty, value);
    public static Style<AutoCompleteBox> ItemFilter(this Style<AutoCompleteBox> style, AutoCompleteFilterPredicate<Object> value)
    => style._addSetter(AutoCompleteBox.ItemFilterProperty, value);
    public static Style<AutoCompleteBox> TextFilter(this Style<AutoCompleteBox> style, AutoCompleteFilterPredicate<String> value)
    => style._addSetter(AutoCompleteBox.TextFilterProperty, value);
    public static Style<AutoCompleteBox> ItemSelector(this Style<AutoCompleteBox> style, AutoCompleteSelector<Object> value)
    => style._addSetter(AutoCompleteBox.ItemSelectorProperty, value);
    public static Style<AutoCompleteBox> TextSelector(this Style<AutoCompleteBox> style, AutoCompleteSelector<String> value)
    => style._addSetter(AutoCompleteBox.TextSelectorProperty, value);
    public static Style<AutoCompleteBox> Items(this Style<AutoCompleteBox> style, IEnumerable value)
    => style._addSetter(AutoCompleteBox.ItemsProperty, value);
    public static Style<AutoCompleteBox> AsyncPopulator(this Style<AutoCompleteBox> style, Func<String, CancellationToken, Task<IEnumerable<Object>>> value)
    => style._addSetter(AutoCompleteBox.AsyncPopulatorProperty, value);
}
public static partial class BorderExtensions
{
    public static Style<Border> Background(this Style<Border> style, IBrush value)
    => style._addSetter(Border.BackgroundProperty, value);
    public static Style<Border> BorderBrush(this Style<Border> style, IBrush value)
    => style._addSetter(Border.BorderBrushProperty, value);
    public static Style<Border> BorderThickness(this Style<Border> style, Thickness value)
    => style._addSetter(Border.BorderThicknessProperty, value);
    public static Style<Border> CornerRadius(this Style<Border> style, CornerRadius value)
    => style._addSetter(Border.CornerRadiusProperty, value);
    public static Style<Border> BoxShadow(this Style<Border> style, BoxShadows value)
    => style._addSetter(Border.BoxShadowProperty, value);
    public static Style<Border> BorderDashOffset(this Style<Border> style, Double value)
    => style._addSetter(Border.BorderDashOffsetProperty, value);
    public static Style<Border> BorderDashArray(this Style<Border> style, AvaloniaList<Double> value)
    => style._addSetter(Border.BorderDashArrayProperty, value);
    public static Style<Border> BorderLineCap(this Style<Border> style, PenLineCap value)
    => style._addSetter(Border.BorderLineCapProperty, value);
    public static Style<Border> BorderLineJoin(this Style<Border> style, PenLineJoin value)
    => style._addSetter(Border.BorderLineJoinProperty, value);
}
public static partial class ButtonExtensions
{
    public static Style<Button> ClickMode(this Style<Button> style, ClickMode value)
    => style._addSetter(Button.ClickModeProperty, value);
    public static Style<Button> Command(this Style<Button> style, ICommand value)
    => style._addSetter(Button.CommandProperty, value);
    public static Style<Button> HotKey(this Style<Button> style, KeyGesture value)
    => style._addSetter(Button.HotKeyProperty, value);
    public static Style<Button> CommandParameter(this Style<Button> style, Object value)
    => style._addSetter(Button.CommandParameterProperty, value);
    public static Style<Button> IsDefault(this Style<Button> style, Boolean value)
    => style._addSetter(Button.IsDefaultProperty, value);
    public static Style<Button> IsCancel(this Style<Button> style, Boolean value)
    => style._addSetter(Button.IsCancelProperty, value);
    public static Style<Button> Flyout(this Style<Button> style, FlyoutBase value)
    => style._addSetter(Button.FlyoutProperty, value);
}
public static partial class ButtonSpinnerExtensions
{
    public static Style<ButtonSpinner> AllowSpin(this Style<ButtonSpinner> style, Boolean value)
    => style._addSetter(ButtonSpinner.AllowSpinProperty, value);
    public static Style<ButtonSpinner> ShowButtonSpinner(this Style<ButtonSpinner> style, Boolean value)
    => style._addSetter(ButtonSpinner.ShowButtonSpinnerProperty, value);
    public static Style<ButtonSpinner> ButtonSpinnerLocation(this Style<ButtonSpinner> style, Location value)
    => style._addSetter(ButtonSpinner.ButtonSpinnerLocationProperty, value);
}
public static partial class CalendarDatePickerExtensions
{
    public static Style<CalendarDatePicker> DisplayDate(this Style<CalendarDatePicker> style, DateTime value)
    => style._addSetter(CalendarDatePicker.DisplayDateProperty, value);
    public static Style<CalendarDatePicker> DisplayDateStart(this Style<CalendarDatePicker> style, Nullable<DateTime> value)
    => style._addSetter(CalendarDatePicker.DisplayDateStartProperty, value);
    public static Style<CalendarDatePicker> DisplayDateEnd(this Style<CalendarDatePicker> style, Nullable<DateTime> value)
    => style._addSetter(CalendarDatePicker.DisplayDateEndProperty, value);
    public static Style<CalendarDatePicker> FirstDayOfWeek(this Style<CalendarDatePicker> style, DayOfWeek value)
    => style._addSetter(CalendarDatePicker.FirstDayOfWeekProperty, value);
    public static Style<CalendarDatePicker> IsDropDownOpen(this Style<CalendarDatePicker> style, Boolean value)
    => style._addSetter(CalendarDatePicker.IsDropDownOpenProperty, value);
    public static Style<CalendarDatePicker> IsTodayHighlighted(this Style<CalendarDatePicker> style, Boolean value)
    => style._addSetter(CalendarDatePicker.IsTodayHighlightedProperty, value);
    public static Style<CalendarDatePicker> SelectedDate(this Style<CalendarDatePicker> style, Nullable<DateTime> value)
    => style._addSetter(CalendarDatePicker.SelectedDateProperty, value);
    public static Style<CalendarDatePicker> SelectedDateFormat(this Style<CalendarDatePicker> style, CalendarDatePickerFormat value)
    => style._addSetter(CalendarDatePicker.SelectedDateFormatProperty, value);
    public static Style<CalendarDatePicker> CustomDateFormatString(this Style<CalendarDatePicker> style, String value)
    => style._addSetter(CalendarDatePicker.CustomDateFormatStringProperty, value);
    public static Style<CalendarDatePicker> Text(this Style<CalendarDatePicker> style, String value)
    => style._addSetter(CalendarDatePicker.TextProperty, value);
    public static Style<CalendarDatePicker> Watermark(this Style<CalendarDatePicker> style, String value)
    => style._addSetter(CalendarDatePicker.WatermarkProperty, value);
    public static Style<CalendarDatePicker> UseFloatingWatermark(this Style<CalendarDatePicker> style, Boolean value)
    => style._addSetter(CalendarDatePicker.UseFloatingWatermarkProperty, value);
    public static Style<CalendarDatePicker> HorizontalContentAlignment(this Style<CalendarDatePicker> style, HorizontalAlignment value)
    => style._addSetter(CalendarDatePicker.HorizontalContentAlignmentProperty, value);
    public static Style<CalendarDatePicker> VerticalContentAlignment(this Style<CalendarDatePicker> style, VerticalAlignment value)
    => style._addSetter(CalendarDatePicker.VerticalContentAlignmentProperty, value);
}
public static partial class CalendarExtensions
{
    public static Style<Avalonia.Controls.Calendar> FirstDayOfWeek(this Style<Avalonia.Controls.Calendar> style, DayOfWeek value)
    => style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, value);
    public static Style<Avalonia.Controls.Calendar> IsTodayHighlighted(this Style<Avalonia.Controls.Calendar> style, Boolean value)
    => style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, value);
    public static Style<Avalonia.Controls.Calendar> HeaderBackground(this Style<Avalonia.Controls.Calendar> style, IBrush value)
    => style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty, value);
    public static Style<Avalonia.Controls.Calendar> DisplayMode(this Style<Avalonia.Controls.Calendar> style, CalendarMode value)
    => style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty, value);
    public static Style<Avalonia.Controls.Calendar> SelectionMode(this Style<Avalonia.Controls.Calendar> style, CalendarSelectionMode value)
    => style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty, value);
    public static Style<Avalonia.Controls.Calendar> SelectedDate(this Style<Avalonia.Controls.Calendar> style, Nullable<DateTime> value)
    => style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty, value);
    public static Style<Avalonia.Controls.Calendar> DisplayDate(this Style<Avalonia.Controls.Calendar> style, DateTime value)
    => style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty, value);
    public static Style<Avalonia.Controls.Calendar> DisplayDateStart(this Style<Avalonia.Controls.Calendar> style, Nullable<DateTime> value)
    => style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty, value);
    public static Style<Avalonia.Controls.Calendar> DisplayDateEnd(this Style<Avalonia.Controls.Calendar> style, Nullable<DateTime> value)
    => style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty, value);
}
public static partial class CarouselExtensions
{
    public static Style<Carousel> IsVirtualized(this Style<Carousel> style, Boolean value)
    => style._addSetter(Carousel.IsVirtualizedProperty, value);
    public static Style<Carousel> PageTransition(this Style<Carousel> style, IPageTransition value)
    => style._addSetter(Carousel.PageTransitionProperty, value);
}
public static partial class ComboBoxExtensions
{
    public static Style<ComboBox> IsDropDownOpen(this Style<ComboBox> style, Boolean value)
    => style._addSetter(ComboBox.IsDropDownOpenProperty, value);
    public static Style<ComboBox> MaxDropDownHeight(this Style<ComboBox> style, Double value)
    => style._addSetter(ComboBox.MaxDropDownHeightProperty, value);
    public static Style<ComboBox> VirtualizationMode(this Style<ComboBox> style, ItemVirtualizationMode value)
    => style._addSetter(ComboBox.VirtualizationModeProperty, value);
    public static Style<ComboBox> PlaceholderText(this Style<ComboBox> style, String value)
    => style._addSetter(ComboBox.PlaceholderTextProperty, value);
    public static Style<ComboBox> PlaceholderForeground(this Style<ComboBox> style, IBrush value)
    => style._addSetter(ComboBox.PlaceholderForegroundProperty, value);
    public static Style<ComboBox> HorizontalContentAlignment(this Style<ComboBox> style, HorizontalAlignment value)
    => style._addSetter(ComboBox.HorizontalContentAlignmentProperty, value);
    public static Style<ComboBox> VerticalContentAlignment(this Style<ComboBox> style, VerticalAlignment value)
    => style._addSetter(ComboBox.VerticalContentAlignmentProperty, value);
}
public static partial class ContentControlExtensions
{
    public static Style<T> Content<T>(this Style<T> style, Object value) where T : ContentControl
    => style._addSetter(ContentControl.ContentProperty, value);
    public static Style<T> ContentTemplate<T>(this Style<T> style, IDataTemplate value) where T : ContentControl
    => style._addSetter(ContentControl.ContentTemplateProperty, value);
    public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, HorizontalAlignment value) where T : ContentControl
    => style._addSetter(ContentControl.HorizontalContentAlignmentProperty, value);
    public static Style<T> VerticalContentAlignment<T>(this Style<T> style, VerticalAlignment value) where T : ContentControl
    => style._addSetter(ContentControl.VerticalContentAlignmentProperty, value);
}
public static partial class ContextMenuExtensions
{
    public static Style<Avalonia.Controls.ContextMenu> HorizontalOffset(this Style<Avalonia.Controls.ContextMenu> style, Double value)
    => style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, value);
    public static Style<Avalonia.Controls.ContextMenu> VerticalOffset(this Style<Avalonia.Controls.ContextMenu> style, Double value)
    => style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, value);
    public static Style<Avalonia.Controls.ContextMenu> PlacementAnchor(this Style<Avalonia.Controls.ContextMenu> style, PopupAnchor value)
    => style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, value);
    public static Style<Avalonia.Controls.ContextMenu> PlacementConstraintAdjustment(this Style<Avalonia.Controls.ContextMenu> style, PopupPositionerConstraintAdjustment value)
    => style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, value);
    public static Style<Avalonia.Controls.ContextMenu> PlacementGravity(this Style<Avalonia.Controls.ContextMenu> style, PopupGravity value)
    => style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty, value);
    public static Style<Avalonia.Controls.ContextMenu> PlacementMode(this Style<Avalonia.Controls.ContextMenu> style, PlacementMode value)
    => style._addSetter(Avalonia.Controls.ContextMenu.PlacementModeProperty, value);
    public static Style<Avalonia.Controls.ContextMenu> PlacementRect(this Style<Avalonia.Controls.ContextMenu> style, Nullable<Rect> value)
    => style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty, value);
    public static Style<Avalonia.Controls.ContextMenu> WindowManagerAddShadowHint(this Style<Avalonia.Controls.ContextMenu> style, Boolean value)
    => style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, value);
    public static Style<Avalonia.Controls.ContextMenu> PlacementTarget(this Style<Avalonia.Controls.ContextMenu> style, Control value)
    => style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty, value);
}
public static partial class ControlExtensions
{
    public static Style<T> FocusAdorner<T>(this Style<T> style, ITemplate<IControl> value) where T : Control
    => style._addSetter(Control.FocusAdornerProperty, value);
    public static Style<T> Tag<T>(this Style<T> style, Object value) where T : Control
    => style._addSetter(Control.TagProperty, value);
    public static Style<T> ContextMenu<T>(this Style<T> style, Avalonia.Controls.ContextMenu value) where T : Control
    => style._addSetter(Control.ContextMenuProperty, value);
    public static Style<T> ContextFlyout<T>(this Style<T> style, FlyoutBase value) where T : Control
    => style._addSetter(Control.ContextFlyoutProperty, value);
    public static Style<T> FlowDirection<T>(this Style<T> style, FlowDirection value) where T : Control
    => style._addSetter(Control.FlowDirectionProperty, value);
}
public static partial class DataValidationErrorsExtensions
{
    public static Style<DataValidationErrors> ErrorTemplate(this Style<DataValidationErrors> style, IDataTemplate value)
    => style._addSetter(DataValidationErrors.ErrorTemplateProperty, value);
    public static Style<DataValidationErrors> Owner(this Style<DataValidationErrors> style, Control value)
    => style._addSetter(DataValidationErrors.OwnerProperty, value);
}
public static partial class DatePickerExtensions
{
    public static Style<DatePicker> DayFormat(this Style<DatePicker> style, String value)
    => style._addSetter(DatePicker.DayFormatProperty, value);
    public static Style<DatePicker> DayVisible(this Style<DatePicker> style, Boolean value)
    => style._addSetter(DatePicker.DayVisibleProperty, value);
    public static Style<DatePicker> Header(this Style<DatePicker> style, Object value)
    => style._addSetter(DatePicker.HeaderProperty, value);
    public static Style<DatePicker> HeaderTemplate(this Style<DatePicker> style, IDataTemplate value)
    => style._addSetter(DatePicker.HeaderTemplateProperty, value);
    public static Style<DatePicker> MaxYear(this Style<DatePicker> style, DateTimeOffset value)
    => style._addSetter(DatePicker.MaxYearProperty, value);
    public static Style<DatePicker> MinYear(this Style<DatePicker> style, DateTimeOffset value)
    => style._addSetter(DatePicker.MinYearProperty, value);
    public static Style<DatePicker> MonthFormat(this Style<DatePicker> style, String value)
    => style._addSetter(DatePicker.MonthFormatProperty, value);
    public static Style<DatePicker> MonthVisible(this Style<DatePicker> style, Boolean value)
    => style._addSetter(DatePicker.MonthVisibleProperty, value);
    public static Style<DatePicker> YearFormat(this Style<DatePicker> style, String value)
    => style._addSetter(DatePicker.YearFormatProperty, value);
    public static Style<DatePicker> YearVisible(this Style<DatePicker> style, Boolean value)
    => style._addSetter(DatePicker.YearVisibleProperty, value);
    public static Style<DatePicker> SelectedDate(this Style<DatePicker> style, Nullable<DateTimeOffset> value)
    => style._addSetter(DatePicker.SelectedDateProperty, value);
}
public static partial class DatePickerPresenterExtensions
{
    public static Style<DatePickerPresenter> Date(this Style<DatePickerPresenter> style, DateTimeOffset value)
    => style._addSetter(DatePickerPresenter.DateProperty, value);
    public static Style<DatePickerPresenter> DayFormat(this Style<DatePickerPresenter> style, String value)
    => style._addSetter(DatePickerPresenter.DayFormatProperty, value);
    public static Style<DatePickerPresenter> DayVisible(this Style<DatePickerPresenter> style, Boolean value)
    => style._addSetter(DatePickerPresenter.DayVisibleProperty, value);
    public static Style<DatePickerPresenter> MaxYear(this Style<DatePickerPresenter> style, DateTimeOffset value)
    => style._addSetter(DatePickerPresenter.MaxYearProperty, value);
    public static Style<DatePickerPresenter> MinYear(this Style<DatePickerPresenter> style, DateTimeOffset value)
    => style._addSetter(DatePickerPresenter.MinYearProperty, value);
    public static Style<DatePickerPresenter> MonthFormat(this Style<DatePickerPresenter> style, String value)
    => style._addSetter(DatePickerPresenter.MonthFormatProperty, value);
    public static Style<DatePickerPresenter> MonthVisible(this Style<DatePickerPresenter> style, Boolean value)
    => style._addSetter(DatePickerPresenter.MonthVisibleProperty, value);
    public static Style<DatePickerPresenter> YearFormat(this Style<DatePickerPresenter> style, String value)
    => style._addSetter(DatePickerPresenter.YearFormatProperty, value);
    public static Style<DatePickerPresenter> YearVisible(this Style<DatePickerPresenter> style, Boolean value)
    => style._addSetter(DatePickerPresenter.YearVisibleProperty, value);
}
public static partial class TimePickerExtensions
{
    public static Style<TimePicker> MinuteIncrement(this Style<TimePicker> style, Int32 value)
    => style._addSetter(TimePicker.MinuteIncrementProperty, value);
    public static Style<TimePicker> Header(this Style<TimePicker> style, Object value)
    => style._addSetter(TimePicker.HeaderProperty, value);
    public static Style<TimePicker> HeaderTemplate(this Style<TimePicker> style, IDataTemplate value)
    => style._addSetter(TimePicker.HeaderTemplateProperty, value);
    public static Style<TimePicker> ClockIdentifier(this Style<TimePicker> style, String value)
    => style._addSetter(TimePicker.ClockIdentifierProperty, value);
    public static Style<TimePicker> SelectedTime(this Style<TimePicker> style, Nullable<TimeSpan> value)
    => style._addSetter(TimePicker.SelectedTimeProperty, value);
}
public static partial class TimePickerPresenterExtensions
{
    public static Style<TimePickerPresenter> MinuteIncrement(this Style<TimePickerPresenter> style, Int32 value)
    => style._addSetter(TimePickerPresenter.MinuteIncrementProperty, value);
    public static Style<TimePickerPresenter> ClockIdentifier(this Style<TimePickerPresenter> style, String value)
    => style._addSetter(TimePickerPresenter.ClockIdentifierProperty, value);
    public static Style<TimePickerPresenter> Time(this Style<TimePickerPresenter> style, TimeSpan value)
    => style._addSetter(TimePickerPresenter.TimeProperty, value);
}
public static partial class DecoratorExtensions
{
    public static Style<Decorator> Child(this Style<Decorator> style, IControl value)
    => style._addSetter(Decorator.ChildProperty, value);
    public static Style<Decorator> Padding(this Style<Decorator> style, Thickness value)
    => style._addSetter(Decorator.PaddingProperty, value);
}
public static partial class DockPanelExtensions
{
    public static Style<DockPanel> LastChildFill(this Style<DockPanel> style, Boolean value)
    => style._addSetter(DockPanel.LastChildFillProperty, value);
}
public static partial class ExpanderExtensions
{
    public static Style<Expander> ContentTransition(this Style<Expander> style, IPageTransition value)
    => style._addSetter(Expander.ContentTransitionProperty, value);
    public static Style<Expander> ExpandDirection(this Style<Expander> style, ExpandDirection value)
    => style._addSetter(Expander.ExpandDirectionProperty, value);
    public static Style<Expander> IsExpanded(this Style<Expander> style, Boolean value)
    => style._addSetter(Expander.IsExpandedProperty, value);
}
public static partial class ExperimentalAcrylicBorderExtensions
{
    public static Style<ExperimentalAcrylicBorder> CornerRadius(this Style<ExperimentalAcrylicBorder> style, CornerRadius value)
    => style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, value);
    public static Style<ExperimentalAcrylicBorder> Material(this Style<ExperimentalAcrylicBorder> style, ExperimentalAcrylicMaterial value)
    => style._addSetter(ExperimentalAcrylicBorder.MaterialProperty, value);
}
public static partial class GridExtensions
{
    public static Style<Grid> ShowGridLines(this Style<Grid> style, Boolean value)
    => style._addSetter(Grid.ShowGridLinesProperty, value);
}
public static partial class GridSplitterExtensions
{
    public static Style<GridSplitter> ResizeDirection(this Style<GridSplitter> style, GridResizeDirection value)
    => style._addSetter(GridSplitter.ResizeDirectionProperty, value);
    public static Style<GridSplitter> ResizeBehavior(this Style<GridSplitter> style, GridResizeBehavior value)
    => style._addSetter(GridSplitter.ResizeBehaviorProperty, value);
    public static Style<GridSplitter> ShowsPreview(this Style<GridSplitter> style, Boolean value)
    => style._addSetter(GridSplitter.ShowsPreviewProperty, value);
    public static Style<GridSplitter> KeyboardIncrement(this Style<GridSplitter> style, Double value)
    => style._addSetter(GridSplitter.KeyboardIncrementProperty, value);
    public static Style<GridSplitter> DragIncrement(this Style<GridSplitter> style, Double value)
    => style._addSetter(GridSplitter.DragIncrementProperty, value);
    public static Style<GridSplitter> PreviewContent(this Style<GridSplitter> style, ITemplate<IControl> value)
    => style._addSetter(GridSplitter.PreviewContentProperty, value);
}
public static partial class ImageExtensions
{
    public static Style<Image> Source(this Style<Image> style, IImage value)
    => style._addSetter(Image.SourceProperty, value);
    public static Style<Image> Stretch(this Style<Image> style, Stretch value)
    => style._addSetter(Image.StretchProperty, value);
    public static Style<Image> StretchDirection(this Style<Image> style, StretchDirection value)
    => style._addSetter(Image.StretchDirectionProperty, value);
}
public static partial class ItemsControlExtensions
{
    public static Style<T> Items<T>(this Style<T> style, IEnumerable value) where T : ItemsControl
    => style._addSetter(ItemsControl.ItemsProperty, value);
    public static Style<T> ItemContainerTheme<T>(this Style<T> style, ControlTheme value) where T : ItemsControl
    => style._addSetter(ItemsControl.ItemContainerThemeProperty, value);
    public static Style<T> ItemsPanel<T>(this Style<T> style, ITemplate<IPanel> value) where T : ItemsControl
    => style._addSetter(ItemsControl.ItemsPanelProperty, value);
    public static Style<T> ItemTemplate<T>(this Style<T> style, IDataTemplate value) where T : ItemsControl
    => style._addSetter(ItemsControl.ItemTemplateProperty, value);
}
public static partial class LabelExtensions
{
    public static Style<Label> Target(this Style<Label> style, IInputElement value)
    => style._addSetter(Label.TargetProperty, value);
}
public static partial class LayoutTransformControlExtensions
{
    public static Style<LayoutTransformControl> LayoutTransform(this Style<LayoutTransformControl> style, ITransform value)
    => style._addSetter(LayoutTransformControl.LayoutTransformProperty, value);
    public static Style<LayoutTransformControl> UseRenderTransform(this Style<LayoutTransformControl> style, Boolean value)
    => style._addSetter(LayoutTransformControl.UseRenderTransformProperty, value);
}
public static partial class ListBoxExtensions
{
    public static Style<ListBox> SelectedItems(this Style<ListBox> style, IList value)
    => style._addSetter(ListBox.SelectedItemsProperty, value);
    public static Style<ListBox> Selection(this Style<ListBox> style, ISelectionModel value)
    => style._addSetter(ListBox.SelectionProperty, value);
    public static Style<ListBox> SelectionMode(this Style<ListBox> style, SelectionMode value)
    => style._addSetter(ListBox.SelectionModeProperty, value);
    public static Style<ListBox> VirtualizationMode(this Style<ListBox> style, ItemVirtualizationMode value)
    => style._addSetter(ListBox.VirtualizationModeProperty, value);
}
public static partial class ListBoxItemExtensions
{
    public static Style<ListBoxItem> IsSelected(this Style<ListBoxItem> style, Boolean value)
    => style._addSetter(ListBoxItem.IsSelectedProperty, value);
}
public static partial class MaskedTextBoxExtensions
{
    public static Style<MaskedTextBox> AsciiOnly(this Style<MaskedTextBox> style, Boolean value)
    => style._addSetter(MaskedTextBox.AsciiOnlyProperty, value);
    public static Style<MaskedTextBox> Culture(this Style<MaskedTextBox> style, CultureInfo value)
    => style._addSetter(MaskedTextBox.CultureProperty, value);
    public static Style<MaskedTextBox> HidePromptOnLeave(this Style<MaskedTextBox> style, Boolean value)
    => style._addSetter(MaskedTextBox.HidePromptOnLeaveProperty, value);
    public static Style<MaskedTextBox> Mask(this Style<MaskedTextBox> style, String value)
    => style._addSetter(MaskedTextBox.MaskProperty, value);
    public static Style<MaskedTextBox> PasswordChar(this Style<MaskedTextBox> style, Char value)
    => style._addSetter(MaskedTextBox.PasswordCharProperty, value);
    public static Style<MaskedTextBox> PromptChar(this Style<MaskedTextBox> style, Char value)
    => style._addSetter(MaskedTextBox.PromptCharProperty, value);
    public static Style<MaskedTextBox> ResetOnPrompt(this Style<MaskedTextBox> style, Boolean value)
    => style._addSetter(MaskedTextBox.ResetOnPromptProperty, value);
    public static Style<MaskedTextBox> ResetOnSpace(this Style<MaskedTextBox> style, Boolean value)
    => style._addSetter(MaskedTextBox.ResetOnSpaceProperty, value);
}
public static partial class MenuItemExtensions
{
    public static Style<MenuItem> Command(this Style<MenuItem> style, ICommand value)
    => style._addSetter(MenuItem.CommandProperty, value);
    public static Style<MenuItem> HotKey(this Style<MenuItem> style, KeyGesture value)
    => style._addSetter(MenuItem.HotKeyProperty, value);
    public static Style<MenuItem> CommandParameter(this Style<MenuItem> style, Object value)
    => style._addSetter(MenuItem.CommandParameterProperty, value);
    public static Style<MenuItem> Icon(this Style<MenuItem> style, Object value)
    => style._addSetter(MenuItem.IconProperty, value);
    public static Style<MenuItem> InputGesture(this Style<MenuItem> style, KeyGesture value)
    => style._addSetter(MenuItem.InputGestureProperty, value);
    public static Style<MenuItem> IsSelected(this Style<MenuItem> style, Boolean value)
    => style._addSetter(MenuItem.IsSelectedProperty, value);
    public static Style<MenuItem> IsSubMenuOpen(this Style<MenuItem> style, Boolean value)
    => style._addSetter(MenuItem.IsSubMenuOpenProperty, value);
    public static Style<MenuItem> StaysOpenOnClick(this Style<MenuItem> style, Boolean value)
    => style._addSetter(MenuItem.StaysOpenOnClickProperty, value);
}
public static partial class ReversibleStackPanelExtensions
{
    public static Style<ReversibleStackPanel> ReverseOrder(this Style<ReversibleStackPanel> style, Boolean value)
    => style._addSetter(ReversibleStackPanel.ReverseOrderProperty, value);
}
public static partial class NumericUpDownExtensions
{
    public static Style<NumericUpDown> AllowSpin(this Style<NumericUpDown> style, Boolean value)
    => style._addSetter(NumericUpDown.AllowSpinProperty, value);
    public static Style<NumericUpDown> ButtonSpinnerLocation(this Style<NumericUpDown> style, Location value)
    => style._addSetter(NumericUpDown.ButtonSpinnerLocationProperty, value);
    public static Style<NumericUpDown> ShowButtonSpinner(this Style<NumericUpDown> style, Boolean value)
    => style._addSetter(NumericUpDown.ShowButtonSpinnerProperty, value);
    public static Style<NumericUpDown> ClipValueToMinMax(this Style<NumericUpDown> style, Boolean value)
    => style._addSetter(NumericUpDown.ClipValueToMinMaxProperty, value);
    public static Style<NumericUpDown> NumberFormat(this Style<NumericUpDown> style, NumberFormatInfo value)
    => style._addSetter(NumericUpDown.NumberFormatProperty, value);
    public static Style<NumericUpDown> FormatString(this Style<NumericUpDown> style, String value)
    => style._addSetter(NumericUpDown.FormatStringProperty, value);
    public static Style<NumericUpDown> Increment(this Style<NumericUpDown> style, Decimal value)
    => style._addSetter(NumericUpDown.IncrementProperty, value);
    public static Style<NumericUpDown> IsReadOnly(this Style<NumericUpDown> style, Boolean value)
    => style._addSetter(NumericUpDown.IsReadOnlyProperty, value);
    public static Style<NumericUpDown> Maximum(this Style<NumericUpDown> style, Decimal value)
    => style._addSetter(NumericUpDown.MaximumProperty, value);
    public static Style<NumericUpDown> Minimum(this Style<NumericUpDown> style, Decimal value)
    => style._addSetter(NumericUpDown.MinimumProperty, value);
    public static Style<NumericUpDown> ParsingNumberStyle(this Style<NumericUpDown> style, NumberStyles value)
    => style._addSetter(NumericUpDown.ParsingNumberStyleProperty, value);
    public static Style<NumericUpDown> Text(this Style<NumericUpDown> style, String value)
    => style._addSetter(NumericUpDown.TextProperty, value);
    public static Style<NumericUpDown> Value(this Style<NumericUpDown> style, Nullable<Decimal> value)
    => style._addSetter(NumericUpDown.ValueProperty, value);
    public static Style<NumericUpDown> Watermark(this Style<NumericUpDown> style, String value)
    => style._addSetter(NumericUpDown.WatermarkProperty, value);
    public static Style<NumericUpDown> HorizontalContentAlignment(this Style<NumericUpDown> style, HorizontalAlignment value)
    => style._addSetter(NumericUpDown.HorizontalContentAlignmentProperty, value);
    public static Style<NumericUpDown> VerticalContentAlignment(this Style<NumericUpDown> style, VerticalAlignment value)
    => style._addSetter(NumericUpDown.VerticalContentAlignmentProperty, value);
}
public static partial class PanelExtensions
{
    public static Style<T> Background<T>(this Style<T> style, IBrush value) where T : Panel
    => style._addSetter(Panel.BackgroundProperty, value);
}
public static partial class PathIconExtensions
{
    public static Style<PathIcon> Data(this Style<PathIcon> style, Geometry value)
    => style._addSetter(PathIcon.DataProperty, value);
}
public static partial class ProgressBarExtensions
{
    public static Style<ProgressBar> IsIndeterminate(this Style<ProgressBar> style, Boolean value)
    => style._addSetter(ProgressBar.IsIndeterminateProperty, value);
    public static Style<ProgressBar> ShowProgressText(this Style<ProgressBar> style, Boolean value)
    => style._addSetter(ProgressBar.ShowProgressTextProperty, value);
    public static Style<ProgressBar> ProgressTextFormat(this Style<ProgressBar> style, String value)
    => style._addSetter(ProgressBar.ProgressTextFormatProperty, value);
    public static Style<ProgressBar> Orientation(this Style<ProgressBar> style, Orientation value)
    => style._addSetter(ProgressBar.OrientationProperty, value);
    public static Style<ProgressBar> IndeterminateStartingOffset(this Style<ProgressBar> style, Double value)
    => style._addSetter(ProgressBar.IndeterminateStartingOffsetProperty, value);
    public static Style<ProgressBar> IndeterminateEndingOffset(this Style<ProgressBar> style, Double value)
    => style._addSetter(ProgressBar.IndeterminateEndingOffsetProperty, value);
}
public static partial class RadioButtonExtensions
{
    public static Style<RadioButton> GroupName(this Style<RadioButton> style, String value)
    => style._addSetter(RadioButton.GroupNameProperty, value);
}
public static partial class RepeatButtonExtensions
{
    public static Style<RepeatButton> Interval(this Style<RepeatButton> style, Int32 value)
    => style._addSetter(RepeatButton.IntervalProperty, value);
    public static Style<RepeatButton> Delay(this Style<RepeatButton> style, Int32 value)
    => style._addSetter(RepeatButton.DelayProperty, value);
}
public static partial class ItemsRepeaterExtensions
{
    public static Style<ItemsRepeater> HorizontalCacheLength(this Style<ItemsRepeater> style, Double value)
    => style._addSetter(ItemsRepeater.HorizontalCacheLengthProperty, value);
    public static Style<ItemsRepeater> ItemTemplate(this Style<ItemsRepeater> style, IDataTemplate value)
    => style._addSetter(ItemsRepeater.ItemTemplateProperty, value);
    public static Style<ItemsRepeater> Items(this Style<ItemsRepeater> style, IEnumerable value)
    => style._addSetter(ItemsRepeater.ItemsProperty, value);
    public static Style<ItemsRepeater> Layout(this Style<ItemsRepeater> style, AttachedLayout value)
    => style._addSetter(ItemsRepeater.LayoutProperty, value);
    public static Style<ItemsRepeater> VerticalCacheLength(this Style<ItemsRepeater> style, Double value)
    => style._addSetter(ItemsRepeater.VerticalCacheLengthProperty, value);
}
public static partial class RichTextBlockExtensions
{
    public static Style<RichTextBlock> IsTextSelectionEnabled(this Style<RichTextBlock> style, Boolean value)
    => style._addSetter(RichTextBlock.IsTextSelectionEnabledProperty, value);
    public static Style<RichTextBlock> SelectionStart(this Style<RichTextBlock> style, Int32 value)
    => style._addSetter(RichTextBlock.SelectionStartProperty, value);
    public static Style<RichTextBlock> SelectionEnd(this Style<RichTextBlock> style, Int32 value)
    => style._addSetter(RichTextBlock.SelectionEndProperty, value);
    public static Style<RichTextBlock> SelectionBrush(this Style<RichTextBlock> style, IBrush value)
    => style._addSetter(RichTextBlock.SelectionBrushProperty, value);
    public static Style<RichTextBlock> Inlines(this Style<RichTextBlock> style, InlineCollection value)
    => style._addSetter(RichTextBlock.InlinesProperty, value);
}
public static partial class ScrollViewerExtensions
{
    public static Style<ScrollViewer> Offset(this Style<ScrollViewer> style, Vector value)
    => style._addSetter(ScrollViewer.OffsetProperty, value);
    public static Style<ScrollViewer> HorizontalScrollBarVisibility(this Style<ScrollViewer> style, ScrollBarVisibility value)
    => style._addSetter(ScrollViewer.HorizontalScrollBarVisibilityProperty, value);
    public static Style<ScrollViewer> VerticalScrollBarVisibility(this Style<ScrollViewer> style, ScrollBarVisibility value)
    => style._addSetter(ScrollViewer.VerticalScrollBarVisibilityProperty, value);
    public static Style<ScrollViewer> AllowAutoHide(this Style<ScrollViewer> style, Boolean value)
    => style._addSetter(ScrollViewer.AllowAutoHideProperty, value);
    public static Style<ScrollViewer> IsScrollChainingEnabled(this Style<ScrollViewer> style, Boolean value)
    => style._addSetter(ScrollViewer.IsScrollChainingEnabledProperty, value);
}
public static partial class SliderExtensions
{
    public static Style<Slider> Orientation(this Style<Slider> style, Orientation value)
    => style._addSetter(Slider.OrientationProperty, value);
    public static Style<Slider> IsDirectionReversed(this Style<Slider> style, Boolean value)
    => style._addSetter(Slider.IsDirectionReversedProperty, value);
    public static Style<Slider> IsSnapToTickEnabled(this Style<Slider> style, Boolean value)
    => style._addSetter(Slider.IsSnapToTickEnabledProperty, value);
    public static Style<Slider> TickFrequency(this Style<Slider> style, Double value)
    => style._addSetter(Slider.TickFrequencyProperty, value);
    public static Style<Slider> TickPlacement(this Style<Slider> style, TickPlacement value)
    => style._addSetter(Slider.TickPlacementProperty, value);
    public static Style<Slider> Ticks(this Style<Slider> style, AvaloniaList<Double> value)
    => style._addSetter(Slider.TicksProperty, value);
}
public static partial class SpinnerExtensions
{
    public static Style<Spinner> ValidSpinDirection(this Style<Spinner> style, ValidSpinDirections value)
    => style._addSetter(Spinner.ValidSpinDirectionProperty, value);
}
public static partial class SplitButtonExtensions
{
    public static Style<SplitButton> Command(this Style<SplitButton> style, ICommand value)
    => style._addSetter(SplitButton.CommandProperty, value);
    public static Style<SplitButton> CommandParameter(this Style<SplitButton> style, Object value)
    => style._addSetter(SplitButton.CommandParameterProperty, value);
    public static Style<SplitButton> Flyout(this Style<SplitButton> style, FlyoutBase value)
    => style._addSetter(SplitButton.FlyoutProperty, value);
}
public static partial class ToggleSplitButtonExtensions
{
    public static Style<ToggleSplitButton> IsChecked(this Style<ToggleSplitButton> style, Boolean value)
    => style._addSetter(ToggleSplitButton.IsCheckedProperty, value);
}
public static partial class SplitViewExtensions
{
    public static Style<SplitView> CompactPaneLength(this Style<SplitView> style, Double value)
    => style._addSetter(SplitView.CompactPaneLengthProperty, value);
    public static Style<SplitView> DisplayMode(this Style<SplitView> style, SplitViewDisplayMode value)
    => style._addSetter(SplitView.DisplayModeProperty, value);
    public static Style<SplitView> IsPaneOpen(this Style<SplitView> style, Boolean value)
    => style._addSetter(SplitView.IsPaneOpenProperty, value);
    public static Style<SplitView> OpenPaneLength(this Style<SplitView> style, Double value)
    => style._addSetter(SplitView.OpenPaneLengthProperty, value);
    public static Style<SplitView> PaneBackground(this Style<SplitView> style, IBrush value)
    => style._addSetter(SplitView.PaneBackgroundProperty, value);
    public static Style<SplitView> PanePlacement(this Style<SplitView> style, SplitViewPanePlacement value)
    => style._addSetter(SplitView.PanePlacementProperty, value);
    public static Style<SplitView> Pane(this Style<SplitView> style, Object value)
    => style._addSetter(SplitView.PaneProperty, value);
    public static Style<SplitView> PaneTemplate(this Style<SplitView> style, IDataTemplate value)
    => style._addSetter(SplitView.PaneTemplateProperty, value);
    public static Style<SplitView> UseLightDismissOverlayMode(this Style<SplitView> style, Boolean value)
    => style._addSetter(SplitView.UseLightDismissOverlayModeProperty, value);
    public static Style<SplitView> TemplateSettings(this Style<SplitView> style, SplitViewTemplateSettings value)
    => style._addSetter(SplitView.TemplateSettingsProperty, value);
}
public static partial class StackPanelExtensions
{
    public static Style<StackPanel> Spacing(this Style<StackPanel> style, Double value)
    => style._addSetter(StackPanel.SpacingProperty, value);
    public static Style<StackPanel> Orientation(this Style<StackPanel> style, Orientation value)
    => style._addSetter(StackPanel.OrientationProperty, value);
}
public static partial class TabControlExtensions
{
    public static Style<TabControl> TabStripPlacement(this Style<TabControl> style, Avalonia.Controls.Dock value)
    => style._addSetter(TabControl.TabStripPlacementProperty, value);
    public static Style<TabControl> HorizontalContentAlignment(this Style<TabControl> style, HorizontalAlignment value)
    => style._addSetter(TabControl.HorizontalContentAlignmentProperty, value);
    public static Style<TabControl> VerticalContentAlignment(this Style<TabControl> style, VerticalAlignment value)
    => style._addSetter(TabControl.VerticalContentAlignmentProperty, value);
    public static Style<TabControl> ContentTemplate(this Style<TabControl> style, IDataTemplate value)
    => style._addSetter(TabControl.ContentTemplateProperty, value);
}
public static partial class TabItemExtensions
{
    public static Style<TabItem> IsSelected(this Style<TabItem> style, Boolean value)
    => style._addSetter(TabItem.IsSelectedProperty, value);
}
public static partial class TextBlockExtensions
{
    public static Style<TextBlock> Background(this Style<TextBlock> style, IBrush value)
    => style._addSetter(TextBlock.BackgroundProperty, value);
    public static Style<TextBlock> Padding(this Style<TextBlock> style, Thickness value)
    => style._addSetter(TextBlock.PaddingProperty, value);
    public static Style<TextBlock> FontFamily(this Style<TextBlock> style, FontFamily value)
    => style._addSetter(TextBlock.FontFamilyProperty, value);
    public static Style<TextBlock> FontSize(this Style<TextBlock> style, Double value)
    => style._addSetter(TextBlock.FontSizeProperty, value);
    public static Style<TextBlock> FontStyle(this Style<TextBlock> style, FontStyle value)
    => style._addSetter(TextBlock.FontStyleProperty, value);
    public static Style<TextBlock> FontWeight(this Style<TextBlock> style, FontWeight value)
    => style._addSetter(TextBlock.FontWeightProperty, value);
    public static Style<TextBlock> FontStretch(this Style<TextBlock> style, FontStretch value)
    => style._addSetter(TextBlock.FontStretchProperty, value);
    public static Style<TextBlock> Foreground(this Style<TextBlock> style, IBrush value)
    => style._addSetter(TextBlock.ForegroundProperty, value);
    public static Style<TextBlock> BaselineOffset(this Style<TextBlock> style, Double value)
    => style._addSetter(TextBlock.BaselineOffsetProperty, value);
    public static Style<TextBlock> LineHeight(this Style<TextBlock> style, Double value)
    => style._addSetter(TextBlock.LineHeightProperty, value);
    public static Style<TextBlock> MaxLines(this Style<TextBlock> style, Int32 value)
    => style._addSetter(TextBlock.MaxLinesProperty, value);
    public static Style<TextBlock> Text(this Style<TextBlock> style, String value)
    => style._addSetter(TextBlock.TextProperty, value);
    public static Style<TextBlock> TextAlignment(this Style<TextBlock> style, TextAlignment value)
    => style._addSetter(TextBlock.TextAlignmentProperty, value);
    public static Style<TextBlock> TextWrapping(this Style<TextBlock> style, TextWrapping value)
    => style._addSetter(TextBlock.TextWrappingProperty, value);
    public static Style<TextBlock> TextTrimming(this Style<TextBlock> style, TextTrimming value)
    => style._addSetter(TextBlock.TextTrimmingProperty, value);
    public static Style<TextBlock> TextDecorations(this Style<TextBlock> style, TextDecorationCollection value)
    => style._addSetter(TextBlock.TextDecorationsProperty, value);
}
public static partial class TextBoxExtensions
{
    public static Style<TextBox> AcceptsReturn(this Style<TextBox> style, Boolean value)
    => style._addSetter(TextBox.AcceptsReturnProperty, value);
    public static Style<TextBox> AcceptsTab(this Style<TextBox> style, Boolean value)
    => style._addSetter(TextBox.AcceptsTabProperty, value);
    public static Style<TextBox> CaretIndex(this Style<TextBox> style, Int32 value)
    => style._addSetter(TextBox.CaretIndexProperty, value);
    public static Style<TextBox> IsReadOnly(this Style<TextBox> style, Boolean value)
    => style._addSetter(TextBox.IsReadOnlyProperty, value);
    public static Style<TextBox> PasswordChar(this Style<TextBox> style, Char value)
    => style._addSetter(TextBox.PasswordCharProperty, value);
    public static Style<TextBox> SelectionBrush(this Style<TextBox> style, IBrush value)
    => style._addSetter(TextBox.SelectionBrushProperty, value);
    public static Style<TextBox> SelectionForegroundBrush(this Style<TextBox> style, IBrush value)
    => style._addSetter(TextBox.SelectionForegroundBrushProperty, value);
    public static Style<TextBox> CaretBrush(this Style<TextBox> style, IBrush value)
    => style._addSetter(TextBox.CaretBrushProperty, value);
    public static Style<TextBox> SelectionStart(this Style<TextBox> style, Int32 value)
    => style._addSetter(TextBox.SelectionStartProperty, value);
    public static Style<TextBox> SelectionEnd(this Style<TextBox> style, Int32 value)
    => style._addSetter(TextBox.SelectionEndProperty, value);
    public static Style<TextBox> MaxLength(this Style<TextBox> style, Int32 value)
    => style._addSetter(TextBox.MaxLengthProperty, value);
    public static Style<TextBox> MaxLines(this Style<TextBox> style, Int32 value)
    => style._addSetter(TextBox.MaxLinesProperty, value);
    public static Style<TextBox> Text(this Style<TextBox> style, String value)
    => style._addSetter(TextBox.TextProperty, value);
    public static Style<TextBox> TextAlignment(this Style<TextBox> style, TextAlignment value)
    => style._addSetter(TextBox.TextAlignmentProperty, value);
    public static Style<TextBox> HorizontalContentAlignment(this Style<TextBox> style, HorizontalAlignment value)
    => style._addSetter(TextBox.HorizontalContentAlignmentProperty, value);
    public static Style<TextBox> VerticalContentAlignment(this Style<TextBox> style, VerticalAlignment value)
    => style._addSetter(TextBox.VerticalContentAlignmentProperty, value);
    public static Style<TextBox> TextWrapping(this Style<TextBox> style, TextWrapping value)
    => style._addSetter(TextBox.TextWrappingProperty, value);
    public static Style<TextBox> LineHeight(this Style<TextBox> style, Double value)
    => style._addSetter(TextBox.LineHeightProperty, value);
    public static Style<TextBox> Watermark(this Style<TextBox> style, String value)
    => style._addSetter(TextBox.WatermarkProperty, value);
    public static Style<TextBox> UseFloatingWatermark(this Style<TextBox> style, Boolean value)
    => style._addSetter(TextBox.UseFloatingWatermarkProperty, value);
    public static Style<TextBox> NewLine(this Style<TextBox> style, String value)
    => style._addSetter(TextBox.NewLineProperty, value);
    public static Style<TextBox> InnerLeftContent(this Style<TextBox> style, Object value)
    => style._addSetter(TextBox.InnerLeftContentProperty, value);
    public static Style<TextBox> InnerRightContent(this Style<TextBox> style, Object value)
    => style._addSetter(TextBox.InnerRightContentProperty, value);
    public static Style<TextBox> RevealPassword(this Style<TextBox> style, Boolean value)
    => style._addSetter(TextBox.RevealPasswordProperty, value);
    public static Style<TextBox> IsUndoEnabled(this Style<TextBox> style, Boolean value)
    => style._addSetter(TextBox.IsUndoEnabledProperty, value);
    public static Style<TextBox> UndoLimit(this Style<TextBox> style, Int32 value)
    => style._addSetter(TextBox.UndoLimitProperty, value);
}
public static partial class TickBarExtensions
{
    public static Style<TickBar> Fill(this Style<TickBar> style, IBrush value)
    => style._addSetter(TickBar.FillProperty, value);
    public static Style<TickBar> Minimum(this Style<TickBar> style, Double value)
    => style._addSetter(TickBar.MinimumProperty, value);
    public static Style<TickBar> Maximum(this Style<TickBar> style, Double value)
    => style._addSetter(TickBar.MaximumProperty, value);
    public static Style<TickBar> TickFrequency(this Style<TickBar> style, Double value)
    => style._addSetter(TickBar.TickFrequencyProperty, value);
    public static Style<TickBar> Orientation(this Style<TickBar> style, Orientation value)
    => style._addSetter(TickBar.OrientationProperty, value);
    public static Style<TickBar> Ticks(this Style<TickBar> style, AvaloniaList<Double> value)
    => style._addSetter(TickBar.TicksProperty, value);
    public static Style<TickBar> IsDirectionReversed(this Style<TickBar> style, Boolean value)
    => style._addSetter(TickBar.IsDirectionReversedProperty, value);
    public static Style<TickBar> Placement(this Style<TickBar> style, TickBarPlacement value)
    => style._addSetter(TickBar.PlacementProperty, value);
    public static Style<TickBar> ReservedSpace(this Style<TickBar> style, Rect value)
    => style._addSetter(TickBar.ReservedSpaceProperty, value);
}
public static partial class ToggleSwitchExtensions
{
    public static Style<ToggleSwitch> OffContent(this Style<ToggleSwitch> style, Object value)
    => style._addSetter(ToggleSwitch.OffContentProperty, value);
    public static Style<ToggleSwitch> OffContentTemplate(this Style<ToggleSwitch> style, IDataTemplate value)
    => style._addSetter(ToggleSwitch.OffContentTemplateProperty, value);
    public static Style<ToggleSwitch> OnContent(this Style<ToggleSwitch> style, Object value)
    => style._addSetter(ToggleSwitch.OnContentProperty, value);
    public static Style<ToggleSwitch> OnContentTemplate(this Style<ToggleSwitch> style, IDataTemplate value)
    => style._addSetter(ToggleSwitch.OnContentTemplateProperty, value);
}
public static partial class TopLevelExtensions
{
    public static Style<TopLevel> TransparencyLevelHint(this Style<TopLevel> style, WindowTransparencyLevel value)
    => style._addSetter(TopLevel.TransparencyLevelHintProperty, value);
    public static Style<TopLevel> TransparencyBackgroundFallback(this Style<TopLevel> style, IBrush value)
    => style._addSetter(TopLevel.TransparencyBackgroundFallbackProperty, value);
}
public static partial class TransitioningContentControlExtensions
{
    public static Style<TransitioningContentControl> PageTransition(this Style<TransitioningContentControl> style, IPageTransition value)
    => style._addSetter(TransitioningContentControl.PageTransitionProperty, value);
}
public static partial class TreeViewExtensions
{
    public static Style<TreeView> AutoScrollToSelectedItem(this Style<TreeView> style, Boolean value)
    => style._addSetter(TreeView.AutoScrollToSelectedItemProperty, value);
    public static Style<TreeView> SelectedItem(this Style<TreeView> style, Object value)
    => style._addSetter(TreeView.SelectedItemProperty, value);
    public static Style<TreeView> SelectedItems(this Style<TreeView> style, IList value)
    => style._addSetter(TreeView.SelectedItemsProperty, value);
    public static Style<TreeView> SelectionMode(this Style<TreeView> style, SelectionMode value)
    => style._addSetter(TreeView.SelectionModeProperty, value);
}
public static partial class TreeViewItemExtensions
{
    public static Style<TreeViewItem> IsExpanded(this Style<TreeViewItem> style, Boolean value)
    => style._addSetter(TreeViewItem.IsExpandedProperty, value);
    public static Style<TreeViewItem> IsSelected(this Style<TreeViewItem> style, Boolean value)
    => style._addSetter(TreeViewItem.IsSelectedProperty, value);
}
public static partial class ViewboxExtensions
{
    public static Style<Viewbox> Stretch(this Style<Viewbox> style, Stretch value)
    => style._addSetter(Viewbox.StretchProperty, value);
    public static Style<Viewbox> StretchDirection(this Style<Viewbox> style, StretchDirection value)
    => style._addSetter(Viewbox.StretchDirectionProperty, value);
    public static Style<Viewbox> Child(this Style<Viewbox> style, IControl value)
    => style._addSetter(Viewbox.ChildProperty, value);
}
public static partial class WindowExtensions
{
    public static Style<Window> SizeToContent(this Style<Window> style, SizeToContent value)
    => style._addSetter(Window.SizeToContentProperty, value);
    public static Style<Window> ExtendClientAreaToDecorationsHint(this Style<Window> style, Boolean value)
    => style._addSetter(Window.ExtendClientAreaToDecorationsHintProperty, value);
    public static Style<Window> ExtendClientAreaChromeHints(this Style<Window> style, ExtendClientAreaChromeHints value)
    => style._addSetter(Window.ExtendClientAreaChromeHintsProperty, value);
    public static Style<Window> ExtendClientAreaTitleBarHeightHint(this Style<Window> style, Double value)
    => style._addSetter(Window.ExtendClientAreaTitleBarHeightHintProperty, value);
    public static Style<Window> SystemDecorations(this Style<Window> style, SystemDecorations value)
    => style._addSetter(Window.SystemDecorationsProperty, value);
    public static Style<Window> ShowActivated(this Style<Window> style, Boolean value)
    => style._addSetter(Window.ShowActivatedProperty, value);
    public static Style<Window> ShowInTaskbar(this Style<Window> style, Boolean value)
    => style._addSetter(Window.ShowInTaskbarProperty, value);
    public static Style<Window> WindowState(this Style<Window> style, WindowState value)
    => style._addSetter(Window.WindowStateProperty, value);
    public static Style<Window> Title(this Style<Window> style, String value)
    => style._addSetter(Window.TitleProperty, value);
    public static Style<Window> Icon(this Style<Window> style, WindowIcon value)
    => style._addSetter(Window.IconProperty, value);
    public static Style<Window> WindowStartupLocation(this Style<Window> style, WindowStartupLocation value)
    => style._addSetter(Window.WindowStartupLocationProperty, value);
    public static Style<Window> CanResize(this Style<Window> style, Boolean value)
    => style._addSetter(Window.CanResizeProperty, value);
}
public static partial class WindowBaseExtensions
{
    public static Style<WindowBase> Topmost(this Style<WindowBase> style, Boolean value)
    => style._addSetter(WindowBase.TopmostProperty, value);
}
public static partial class WrapPanelExtensions
{
    public static Style<WrapPanel> Orientation(this Style<WrapPanel> style, Orientation value)
    => style._addSetter(WrapPanel.OrientationProperty, value);
    public static Style<WrapPanel> ItemWidth(this Style<WrapPanel> style, Double value)
    => style._addSetter(WrapPanel.ItemWidthProperty, value);
    public static Style<WrapPanel> ItemHeight(this Style<WrapPanel> style, Double value)
    => style._addSetter(WrapPanel.ItemHeightProperty, value);
}
public static partial class ArcExtensions
{
    public static Style<Arc> StartAngle(this Style<Arc> style, Double value)
    => style._addSetter(Arc.StartAngleProperty, value);
    public static Style<Arc> SweepAngle(this Style<Arc> style, Double value)
    => style._addSetter(Arc.SweepAngleProperty, value);
}
public static partial class LineExtensions
{
    public static Style<Line> StartPoint(this Style<Line> style, Point value)
    => style._addSetter(Line.StartPointProperty, value);
    public static Style<Line> EndPoint(this Style<Line> style, Point value)
    => style._addSetter(Line.EndPointProperty, value);
}
public static partial class PathExtensions
{
    public static Style<Path> Data(this Style<Path> style, Geometry value)
    => style._addSetter(Path.DataProperty, value);
}
public static partial class PolygonExtensions
{
    public static Style<Polygon> Points(this Style<Polygon> style, IList<Point> value)
    => style._addSetter(Polygon.PointsProperty, value);
}
public static partial class PolylineExtensions
{
    public static Style<Polyline> Points(this Style<Polyline> style, IList<Point> value)
    => style._addSetter(Polyline.PointsProperty, value);
}
public static partial class RectangleExtensions
{
    public static Style<Rectangle> RadiusX(this Style<Rectangle> style, Double value)
    => style._addSetter(Rectangle.RadiusXProperty, value);
    public static Style<Rectangle> RadiusY(this Style<Rectangle> style, Double value)
    => style._addSetter(Rectangle.RadiusYProperty, value);
}
public static partial class SectorExtensions
{
    public static Style<Sector> StartAngle(this Style<Sector> style, Double value)
    => style._addSetter(Sector.StartAngleProperty, value);
    public static Style<Sector> SweepAngle(this Style<Sector> style, Double value)
    => style._addSetter(Sector.SweepAngleProperty, value);
}
public static partial class ShapeExtensions
{
    public static Style<Shape> Fill(this Style<Shape> style, IBrush value)
    => style._addSetter(Shape.FillProperty, value);
    public static Style<Shape> Stretch(this Style<Shape> style, Stretch value)
    => style._addSetter(Shape.StretchProperty, value);
    public static Style<Shape> Stroke(this Style<Shape> style, IBrush value)
    => style._addSetter(Shape.StrokeProperty, value);
    public static Style<Shape> StrokeDashArray(this Style<Shape> style, AvaloniaList<Double> value)
    => style._addSetter(Shape.StrokeDashArrayProperty, value);
    public static Style<Shape> StrokeDashOffset(this Style<Shape> style, Double value)
    => style._addSetter(Shape.StrokeDashOffsetProperty, value);
    public static Style<Shape> StrokeThickness(this Style<Shape> style, Double value)
    => style._addSetter(Shape.StrokeThicknessProperty, value);
    public static Style<Shape> StrokeLineCap(this Style<Shape> style, PenLineCap value)
    => style._addSetter(Shape.StrokeLineCapProperty, value);
    public static Style<Shape> StrokeJoin(this Style<Shape> style, PenLineJoin value)
    => style._addSetter(Shape.StrokeJoinProperty, value);
}
public static partial class CarouselPresenterExtensions
{
    public static Style<CarouselPresenter> IsVirtualized(this Style<CarouselPresenter> style, Boolean value)
    => style._addSetter(CarouselPresenter.IsVirtualizedProperty, value);
    public static Style<CarouselPresenter> SelectedIndex(this Style<CarouselPresenter> style, Int32 value)
    => style._addSetter(CarouselPresenter.SelectedIndexProperty, value);
    public static Style<CarouselPresenter> PageTransition(this Style<CarouselPresenter> style, IPageTransition value)
    => style._addSetter(CarouselPresenter.PageTransitionProperty, value);
}
public static partial class ContentPresenterExtensions
{
    public static Style<ContentPresenter> Background(this Style<ContentPresenter> style, IBrush value)
    => style._addSetter(ContentPresenter.BackgroundProperty, value);
    public static Style<ContentPresenter> BorderBrush(this Style<ContentPresenter> style, IBrush value)
    => style._addSetter(ContentPresenter.BorderBrushProperty, value);
    public static Style<ContentPresenter> BorderThickness(this Style<ContentPresenter> style, Thickness value)
    => style._addSetter(ContentPresenter.BorderThicknessProperty, value);
    public static Style<ContentPresenter> CornerRadius(this Style<ContentPresenter> style, CornerRadius value)
    => style._addSetter(ContentPresenter.CornerRadiusProperty, value);
    public static Style<ContentPresenter> BoxShadow(this Style<ContentPresenter> style, BoxShadows value)
    => style._addSetter(ContentPresenter.BoxShadowProperty, value);
    public static Style<ContentPresenter> Foreground(this Style<ContentPresenter> style, IBrush value)
    => style._addSetter(ContentPresenter.ForegroundProperty, value);
    public static Style<ContentPresenter> FontFamily(this Style<ContentPresenter> style, FontFamily value)
    => style._addSetter(ContentPresenter.FontFamilyProperty, value);
    public static Style<ContentPresenter> FontSize(this Style<ContentPresenter> style, Double value)
    => style._addSetter(ContentPresenter.FontSizeProperty, value);
    public static Style<ContentPresenter> FontStyle(this Style<ContentPresenter> style, FontStyle value)
    => style._addSetter(ContentPresenter.FontStyleProperty, value);
    public static Style<ContentPresenter> FontWeight(this Style<ContentPresenter> style, FontWeight value)
    => style._addSetter(ContentPresenter.FontWeightProperty, value);
    public static Style<ContentPresenter> FontStretch(this Style<ContentPresenter> style, FontStretch value)
    => style._addSetter(ContentPresenter.FontStretchProperty, value);
    public static Style<ContentPresenter> TextAlignment(this Style<ContentPresenter> style, TextAlignment value)
    => style._addSetter(ContentPresenter.TextAlignmentProperty, value);
    public static Style<ContentPresenter> TextWrapping(this Style<ContentPresenter> style, TextWrapping value)
    => style._addSetter(ContentPresenter.TextWrappingProperty, value);
    public static Style<ContentPresenter> TextTrimming(this Style<ContentPresenter> style, TextTrimming value)
    => style._addSetter(ContentPresenter.TextTrimmingProperty, value);
    public static Style<ContentPresenter> LineHeight(this Style<ContentPresenter> style, Double value)
    => style._addSetter(ContentPresenter.LineHeightProperty, value);
    public static Style<ContentPresenter> MaxLines(this Style<ContentPresenter> style, Int32 value)
    => style._addSetter(ContentPresenter.MaxLinesProperty, value);
    public static Style<ContentPresenter> Content(this Style<ContentPresenter> style, Object value)
    => style._addSetter(ContentPresenter.ContentProperty, value);
    public static Style<ContentPresenter> ContentTemplate(this Style<ContentPresenter> style, IDataTemplate value)
    => style._addSetter(ContentPresenter.ContentTemplateProperty, value);
    public static Style<ContentPresenter> HorizontalContentAlignment(this Style<ContentPresenter> style, HorizontalAlignment value)
    => style._addSetter(ContentPresenter.HorizontalContentAlignmentProperty, value);
    public static Style<ContentPresenter> VerticalContentAlignment(this Style<ContentPresenter> style, VerticalAlignment value)
    => style._addSetter(ContentPresenter.VerticalContentAlignmentProperty, value);
    public static Style<ContentPresenter> Padding(this Style<ContentPresenter> style, Thickness value)
    => style._addSetter(ContentPresenter.PaddingProperty, value);
    public static Style<ContentPresenter> RecognizesAccessKey(this Style<ContentPresenter> style, Boolean value)
    => style._addSetter(ContentPresenter.RecognizesAccessKeyProperty, value);
}
public static partial class ItemsPresenterExtensions
{
    public static Style<ItemsPresenter> VirtualizationMode(this Style<ItemsPresenter> style, ItemVirtualizationMode value)
    => style._addSetter(ItemsPresenter.VirtualizationModeProperty, value);
}
public static partial class ItemsPresenterBaseExtensions
{
    public static Style<ItemsPresenterBase> Items(this Style<ItemsPresenterBase> style, IEnumerable value)
    => style._addSetter(ItemsPresenterBase.ItemsProperty, value);
    public static Style<ItemsPresenterBase> ItemsPanel(this Style<ItemsPresenterBase> style, ITemplate<IPanel> value)
    => style._addSetter(ItemsPresenterBase.ItemsPanelProperty, value);
    public static Style<ItemsPresenterBase> ItemTemplate(this Style<ItemsPresenterBase> style, IDataTemplate value)
    => style._addSetter(ItemsPresenterBase.ItemTemplateProperty, value);
}
public static partial class ScrollContentPresenterExtensions
{
    public static Style<ScrollContentPresenter> CanHorizontallyScroll(this Style<ScrollContentPresenter> style, Boolean value)
    => style._addSetter(ScrollContentPresenter.CanHorizontallyScrollProperty, value);
    public static Style<ScrollContentPresenter> CanVerticallyScroll(this Style<ScrollContentPresenter> style, Boolean value)
    => style._addSetter(ScrollContentPresenter.CanVerticallyScrollProperty, value);
    public static Style<ScrollContentPresenter> Offset(this Style<ScrollContentPresenter> style, Vector value)
    => style._addSetter(ScrollContentPresenter.OffsetProperty, value);
    public static Style<ScrollContentPresenter> IsScrollChainingEnabled(this Style<ScrollContentPresenter> style, Boolean value)
    => style._addSetter(ScrollContentPresenter.IsScrollChainingEnabledProperty, value);
}
public static partial class TextPresenterExtensions
{
    public static Style<TextPresenter> CaretIndex(this Style<TextPresenter> style, Int32 value)
    => style._addSetter(TextPresenter.CaretIndexProperty, value);
    public static Style<TextPresenter> RevealPassword(this Style<TextPresenter> style, Boolean value)
    => style._addSetter(TextPresenter.RevealPasswordProperty, value);
    public static Style<TextPresenter> PasswordChar(this Style<TextPresenter> style, Char value)
    => style._addSetter(TextPresenter.PasswordCharProperty, value);
    public static Style<TextPresenter> SelectionBrush(this Style<TextPresenter> style, IBrush value)
    => style._addSetter(TextPresenter.SelectionBrushProperty, value);
    public static Style<TextPresenter> SelectionForegroundBrush(this Style<TextPresenter> style, IBrush value)
    => style._addSetter(TextPresenter.SelectionForegroundBrushProperty, value);
    public static Style<TextPresenter> CaretBrush(this Style<TextPresenter> style, IBrush value)
    => style._addSetter(TextPresenter.CaretBrushProperty, value);
    public static Style<TextPresenter> SelectionStart(this Style<TextPresenter> style, Int32 value)
    => style._addSetter(TextPresenter.SelectionStartProperty, value);
    public static Style<TextPresenter> SelectionEnd(this Style<TextPresenter> style, Int32 value)
    => style._addSetter(TextPresenter.SelectionEndProperty, value);
    public static Style<TextPresenter> Text(this Style<TextPresenter> style, String value)
    => style._addSetter(TextPresenter.TextProperty, value);
    public static Style<TextPresenter> TextAlignment(this Style<TextPresenter> style, TextAlignment value)
    => style._addSetter(TextPresenter.TextAlignmentProperty, value);
    public static Style<TextPresenter> TextWrapping(this Style<TextPresenter> style, TextWrapping value)
    => style._addSetter(TextPresenter.TextWrappingProperty, value);
    public static Style<TextPresenter> LineHeight(this Style<TextPresenter> style, Double value)
    => style._addSetter(TextPresenter.LineHeightProperty, value);
    public static Style<TextPresenter> Background(this Style<TextPresenter> style, IBrush value)
    => style._addSetter(TextPresenter.BackgroundProperty, value);
}
public static partial class NotificationCardExtensions
{
    public static Style<NotificationCard> IsClosed(this Style<NotificationCard> style, Boolean value)
    => style._addSetter(NotificationCard.IsClosedProperty, value);
}
public static partial class WindowNotificationManagerExtensions
{
    public static Style<WindowNotificationManager> Position(this Style<WindowNotificationManager> style, NotificationPosition value)
    => style._addSetter(WindowNotificationManager.PositionProperty, value);
    public static Style<WindowNotificationManager> MaxItems(this Style<WindowNotificationManager> style, Int32 value)
    => style._addSetter(WindowNotificationManager.MaxItemsProperty, value);
}
public static partial class InlineExtensions
{
    public static Style<Inline> TextDecorations(this Style<Inline> style, TextDecorationCollection value)
    => style._addSetter(Inline.TextDecorationsProperty, value);
    public static Style<Inline> BaselineAlignment(this Style<Inline> style, BaselineAlignment value)
    => style._addSetter(Inline.BaselineAlignmentProperty, value);
}
public static partial class InlineUIContainerExtensions
{
    public static Style<InlineUIContainer> Child(this Style<InlineUIContainer> style, IControl value)
    => style._addSetter(InlineUIContainer.ChildProperty, value);
}
public static partial class RunExtensions
{
    public static Style<Run> Text(this Style<Run> style, String value)
    => style._addSetter(Run.TextProperty, value);
}
public static partial class SpanExtensions
{
    public static Style<Span> Inlines(this Style<Span> style, InlineCollection value)
    => style._addSetter(Span.InlinesProperty, value);
}
public static partial class TextElementExtensions
{
    public static Style<TextElement> Background(this Style<TextElement> style, IBrush value)
    => style._addSetter(TextElement.BackgroundProperty, value);
    public static Style<TextElement> FontFamily(this Style<TextElement> style, FontFamily value)
    => style._addSetter(TextElement.FontFamilyProperty, value);
    public static Style<TextElement> FontSize(this Style<TextElement> style, Double value)
    => style._addSetter(TextElement.FontSizeProperty, value);
    public static Style<TextElement> FontStyle(this Style<TextElement> style, FontStyle value)
    => style._addSetter(TextElement.FontStyleProperty, value);
    public static Style<TextElement> FontWeight(this Style<TextElement> style, FontWeight value)
    => style._addSetter(TextElement.FontWeightProperty, value);
    public static Style<TextElement> FontStretch(this Style<TextElement> style, FontStretch value)
    => style._addSetter(TextElement.FontStretchProperty, value);
    public static Style<TextElement> Foreground(this Style<TextElement> style, IBrush value)
    => style._addSetter(TextElement.ForegroundProperty, value);
}
public static partial class CalendarItemExtensions
{
    public static Style<CalendarItem> HeaderBackground(this Style<CalendarItem> style, IBrush value)
    => style._addSetter(CalendarItem.HeaderBackgroundProperty, value);
    public static Style<CalendarItem> DayTitleTemplate(this Style<CalendarItem> style, ITemplate<IControl> value)
    => style._addSetter(CalendarItem.DayTitleTemplateProperty, value);
}
public static partial class DateTimePickerPanelExtensions
{
    public static Style<DateTimePickerPanel> ItemHeight(this Style<DateTimePickerPanel> style, Double value)
    => style._addSetter(DateTimePickerPanel.ItemHeightProperty, value);
    public static Style<DateTimePickerPanel> PanelType(this Style<DateTimePickerPanel> style, DateTimePickerPanelType value)
    => style._addSetter(DateTimePickerPanel.PanelTypeProperty, value);
    public static Style<DateTimePickerPanel> ItemFormat(this Style<DateTimePickerPanel> style, String value)
    => style._addSetter(DateTimePickerPanel.ItemFormatProperty, value);
    public static Style<DateTimePickerPanel> ShouldLoop(this Style<DateTimePickerPanel> style, Boolean value)
    => style._addSetter(DateTimePickerPanel.ShouldLoopProperty, value);
}
public static partial class AccessTextExtensions
{
    public static Style<AccessText> ShowAccessKey(this Style<AccessText> style, Boolean value)
    => style._addSetter(AccessText.ShowAccessKeyProperty, value);
}
public static partial class HeaderedContentControlExtensions
{
    public static Style<HeaderedContentControl> Header(this Style<HeaderedContentControl> style, Object value)
    => style._addSetter(HeaderedContentControl.HeaderProperty, value);
    public static Style<HeaderedContentControl> HeaderTemplate(this Style<HeaderedContentControl> style, IDataTemplate value)
    => style._addSetter(HeaderedContentControl.HeaderTemplateProperty, value);
}
public static partial class HeaderedItemsControlExtensions
{
    public static Style<HeaderedItemsControl> Header(this Style<HeaderedItemsControl> style, Object value)
    => style._addSetter(HeaderedItemsControl.HeaderProperty, value);
}
public static partial class HeaderedSelectingItemsControlExtensions
{
    public static Style<HeaderedSelectingItemsControl> Header(this Style<HeaderedSelectingItemsControl> style, Object value)
    => style._addSetter(HeaderedSelectingItemsControl.HeaderProperty, value);
}
public static partial class OverlayPopupHostExtensions
{
    public static Style<OverlayPopupHost> Transform(this Style<OverlayPopupHost> style, Transform value)
    => style._addSetter(OverlayPopupHost.TransformProperty, value);
}
public static partial class PopupExtensions
{
    public static Style<Popup> WindowManagerAddShadowHint(this Style<Popup> style, Boolean value)
    => style._addSetter(Popup.WindowManagerAddShadowHintProperty, value);
    public static Style<Popup> Child(this Style<Popup> style, Control value)
    => style._addSetter(Popup.ChildProperty, value);
    public static Style<Popup> InheritsTransform(this Style<Popup> style, Boolean value)
    => style._addSetter(Popup.InheritsTransformProperty, value);
    public static Style<Popup> IsOpen(this Style<Popup> style, Boolean value)
    => style._addSetter(Popup.IsOpenProperty, value);
    public static Style<Popup> PlacementAnchor(this Style<Popup> style, PopupAnchor value)
    => style._addSetter(Popup.PlacementAnchorProperty, value);
    public static Style<Popup> PlacementConstraintAdjustment(this Style<Popup> style, PopupPositionerConstraintAdjustment value)
    => style._addSetter(Popup.PlacementConstraintAdjustmentProperty, value);
    public static Style<Popup> PlacementGravity(this Style<Popup> style, PopupGravity value)
    => style._addSetter(Popup.PlacementGravityProperty, value);
    public static Style<Popup> PlacementMode(this Style<Popup> style, PlacementMode value)
    => style._addSetter(Popup.PlacementModeProperty, value);
    public static Style<Popup> PlacementRect(this Style<Popup> style, Nullable<Rect> value)
    => style._addSetter(Popup.PlacementRectProperty, value);
    public static Style<Popup> PlacementTarget(this Style<Popup> style, Control value)
    => style._addSetter(Popup.PlacementTargetProperty, value);
    public static Style<Popup> OverlayDismissEventPassThrough(this Style<Popup> style, Boolean value)
    => style._addSetter(Popup.OverlayDismissEventPassThroughProperty, value);
    public static Style<Popup> OverlayInputPassThroughElement(this Style<Popup> style, IInputElement value)
    => style._addSetter(Popup.OverlayInputPassThroughElementProperty, value);
    public static Style<Popup> HorizontalOffset(this Style<Popup> style, Double value)
    => style._addSetter(Popup.HorizontalOffsetProperty, value);
    public static Style<Popup> IsLightDismissEnabled(this Style<Popup> style, Boolean value)
    => style._addSetter(Popup.IsLightDismissEnabledProperty, value);
    public static Style<Popup> VerticalOffset(this Style<Popup> style, Double value)
    => style._addSetter(Popup.VerticalOffsetProperty, value);
    public static Style<Popup> Topmost(this Style<Popup> style, Boolean value)
    => style._addSetter(Popup.TopmostProperty, value);
}
public static partial class PopupRootExtensions
{
    public static Style<PopupRoot> Transform(this Style<PopupRoot> style, Transform value)
    => style._addSetter(PopupRoot.TransformProperty, value);
}
public static partial class RangeBaseExtensions
{
    public static Style<RangeBase> Minimum(this Style<RangeBase> style, Double value)
    => style._addSetter(RangeBase.MinimumProperty, value);
    public static Style<RangeBase> Maximum(this Style<RangeBase> style, Double value)
    => style._addSetter(RangeBase.MaximumProperty, value);
    public static Style<RangeBase> Value(this Style<RangeBase> style, Double value)
    => style._addSetter(RangeBase.ValueProperty, value);
    public static Style<RangeBase> SmallChange(this Style<RangeBase> style, Double value)
    => style._addSetter(RangeBase.SmallChangeProperty, value);
    public static Style<RangeBase> LargeChange(this Style<RangeBase> style, Double value)
    => style._addSetter(RangeBase.LargeChangeProperty, value);
}
public static partial class ScrollBarExtensions
{
    public static Style<ScrollBar> ViewportSize(this Style<ScrollBar> style, Double value)
    => style._addSetter(ScrollBar.ViewportSizeProperty, value);
    public static Style<ScrollBar> Visibility(this Style<ScrollBar> style, ScrollBarVisibility value)
    => style._addSetter(ScrollBar.VisibilityProperty, value);
    public static Style<ScrollBar> Orientation(this Style<ScrollBar> style, Orientation value)
    => style._addSetter(ScrollBar.OrientationProperty, value);
    public static Style<ScrollBar> AllowAutoHide(this Style<ScrollBar> style, Boolean value)
    => style._addSetter(ScrollBar.AllowAutoHideProperty, value);
    public static Style<ScrollBar> HideDelay(this Style<ScrollBar> style, TimeSpan value)
    => style._addSetter(ScrollBar.HideDelayProperty, value);
    public static Style<ScrollBar> ShowDelay(this Style<ScrollBar> style, TimeSpan value)
    => style._addSetter(ScrollBar.ShowDelayProperty, value);
}
public static partial class SelectingItemsControlExtensions
{
    public static Style<SelectingItemsControl> AutoScrollToSelectedItem(this Style<SelectingItemsControl> style, Boolean value)
    => style._addSetter(SelectingItemsControl.AutoScrollToSelectedItemProperty, value);
    public static Style<SelectingItemsControl> SelectedIndex(this Style<SelectingItemsControl> style, Int32 value)
    => style._addSetter(SelectingItemsControl.SelectedIndexProperty, value);
    public static Style<SelectingItemsControl> SelectedItem(this Style<SelectingItemsControl> style, Object value)
    => style._addSetter(SelectingItemsControl.SelectedItemProperty, value);
    public static Style<SelectingItemsControl> IsTextSearchEnabled(this Style<SelectingItemsControl> style, Boolean value)
    => style._addSetter(SelectingItemsControl.IsTextSearchEnabledProperty, value);
    public static Style<SelectingItemsControl> WrapSelection(this Style<SelectingItemsControl> style, Boolean value)
    => style._addSetter(SelectingItemsControl.WrapSelectionProperty, value);
}
public static partial class TemplatedControlExtensions
{
    public static Style<T> Background<T>(this Style<T> style, IBrush value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.BackgroundProperty, value);
    public static Style<T> BorderBrush<T>(this Style<T> style, IBrush value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.BorderBrushProperty, value);
    public static Style<T> BorderThickness<T>(this Style<T> style, Thickness value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.BorderThicknessProperty, value);
    public static Style<T> CornerRadius<T>(this Style<T> style, CornerRadius value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.CornerRadiusProperty, value);
    public static Style<T> FontFamily<T>(this Style<T> style, FontFamily value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.FontFamilyProperty, value);
    public static Style<T> FontSize<T>(this Style<T> style, Double value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.FontSizeProperty, value);
    public static Style<T> FontStyle<T>(this Style<T> style, FontStyle value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.FontStyleProperty, value);
    public static Style<T> FontWeight<T>(this Style<T> style, FontWeight value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.FontWeightProperty, value);
    public static Style<T> FontStretch<T>(this Style<T> style, FontStretch value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.FontStretchProperty, value);
    public static Style<T> Foreground<T>(this Style<T> style, IBrush value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.ForegroundProperty, value);
    public static Style<T> Padding<T>(this Style<T> style, Thickness value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.PaddingProperty, value);
    public static Style<T> Template<T>(this Style<T> style, IControlTemplate value) where T : TemplatedControl
    => style._addSetter(TemplatedControl.TemplateProperty, value);
}
public static partial class ToggleButtonExtensions
{
    public static Style<ToggleButton> IsChecked(this Style<ToggleButton> style, Nullable<Boolean> value)
    => style._addSetter(ToggleButton.IsCheckedProperty, value);
    public static Style<ToggleButton> IsThreeState(this Style<ToggleButton> style, Boolean value)
    => style._addSetter(ToggleButton.IsThreeStateProperty, value);
}
public static partial class TrackExtensions
{
    public static Style<Track> Minimum(this Style<Track> style, Double value)
    => style._addSetter(Track.MinimumProperty, value);
    public static Style<Track> Maximum(this Style<Track> style, Double value)
    => style._addSetter(Track.MaximumProperty, value);
    public static Style<Track> Value(this Style<Track> style, Double value)
    => style._addSetter(Track.ValueProperty, value);
    public static Style<Track> ViewportSize(this Style<Track> style, Double value)
    => style._addSetter(Track.ViewportSizeProperty, value);
    public static Style<Track> Orientation(this Style<Track> style, Orientation value)
    => style._addSetter(Track.OrientationProperty, value);
    public static Style<Track> Thumb(this Style<Track> style, Thumb value)
    => style._addSetter(Track.ThumbProperty, value);
    public static Style<Track> IncreaseButton(this Style<Track> style, Button value)
    => style._addSetter(Track.IncreaseButtonProperty, value);
    public static Style<Track> DecreaseButton(this Style<Track> style, Button value)
    => style._addSetter(Track.DecreaseButtonProperty, value);
    public static Style<Track> IsDirectionReversed(this Style<Track> style, Boolean value)
    => style._addSetter(Track.IsDirectionReversedProperty, value);
    public static Style<Track> IgnoreThumbDrag(this Style<Track> style, Boolean value)
    => style._addSetter(Track.IgnoreThumbDragProperty, value);
}
public static partial class UniformGridExtensions
{
    public static Style<UniformGrid> Rows(this Style<UniformGrid> style, Int32 value)
    => style._addSetter(UniformGrid.RowsProperty, value);
    public static Style<UniformGrid> Columns(this Style<UniformGrid> style, Int32 value)
    => style._addSetter(UniformGrid.ColumnsProperty, value);
    public static Style<UniformGrid> FirstColumn(this Style<UniformGrid> style, Int32 value)
    => style._addSetter(UniformGrid.FirstColumnProperty, value);
}
public static partial class StyledElementExtensions
{
    public static Style<StyledElement> DataContext(this Style<StyledElement> style, Object value)
    => style._addSetter(StyledElement.DataContextProperty, value);
    public static Style<StyledElement> Name(this Style<StyledElement> style, String value)
    => style._addSetter(StyledElement.NameProperty, value);
    public static Style<StyledElement> Theme(this Style<StyledElement> style, ControlTheme value)
    => style._addSetter(StyledElement.ThemeProperty, value);
}
public static partial class VisualExtensions
{
    public static Style<T> ClipToBounds<T>(this Style<T> style, Boolean value) where T : Visual
    => style._addSetter(Visual.ClipToBoundsProperty, value);
    public static Style<T> Clip<T>(this Style<T> style, Geometry value) where T : Visual
    => style._addSetter(Visual.ClipProperty, value);
    public static Style<T> IsVisible<T>(this Style<T> style, Boolean value) where T : Visual
    => style._addSetter(Visual.IsVisibleProperty, value);
    public static Style<T> Opacity<T>(this Style<T> style, Double value) where T : Visual
    => style._addSetter(Visual.OpacityProperty, value);
    public static Style<T> OpacityMask<T>(this Style<T> style, IBrush value) where T : Visual
    => style._addSetter(Visual.OpacityMaskProperty, value);
    public static Style<T> RenderTransform<T>(this Style<T> style, ITransform value) where T : Visual
    => style._addSetter(Visual.RenderTransformProperty, value);
    public static Style<T> RenderTransformOrigin<T>(this Style<T> style, RelativePoint value) where T : Visual
    => style._addSetter(Visual.RenderTransformOriginProperty, value);
    public static Style<T> ZIndex<T>(this Style<T> style, Int32 value) where T : Visual
    => style._addSetter(Visual.ZIndexProperty, value);
}
public static partial class LayoutableExtensions
{
    public static Style<T> Width<T>(this Style<T> style, Double value) where T : Layoutable
    => style._addSetter(Layoutable.WidthProperty, value);
    public static Style<T> Height<T>(this Style<T> style, Double value) where T : Layoutable
    => style._addSetter(Layoutable.HeightProperty, value);
    public static Style<T> MinWidth<T>(this Style<T> style, Double value) where T : Layoutable
    => style._addSetter(Layoutable.MinWidthProperty, value);
    public static Style<T> MaxWidth<T>(this Style<T> style, Double value) where T : Layoutable
    => style._addSetter(Layoutable.MaxWidthProperty, value);
    public static Style<T> MinHeight<T>(this Style<T> style, Double value) where T : Layoutable
    => style._addSetter(Layoutable.MinHeightProperty, value);
    public static Style<T> MaxHeight<T>(this Style<T> style, Double value) where T : Layoutable
    => style._addSetter(Layoutable.MaxHeightProperty, value);
    public static Style<T> Margin<T>(this Style<T> style, Thickness value) where T : Layoutable
    => style._addSetter(Layoutable.MarginProperty, value);
    public static Style<T> HorizontalAlignment<T>(this Style<T> style, HorizontalAlignment value) where T : Layoutable
    => style._addSetter(Layoutable.HorizontalAlignmentProperty, value);
    public static Style<T> VerticalAlignment<T>(this Style<T> style, VerticalAlignment value) where T : Layoutable
    => style._addSetter(Layoutable.VerticalAlignmentProperty, value);
    public static Style<T> UseLayoutRounding<T>(this Style<T> style, Boolean value) where T : Layoutable
    => style._addSetter(Layoutable.UseLayoutRoundingProperty, value);
}
public static partial class InputElementExtensions
{
    public static Style<T> Focusable<T>(this Style<T> style, Boolean value) where T : InputElement
    => style._addSetter(InputElement.FocusableProperty, value);
    public static Style<T> IsEnabled<T>(this Style<T> style, Boolean value) where T : InputElement
    => style._addSetter(InputElement.IsEnabledProperty, value);
    public static Style<T> Cursor<T>(this Style<T> style, Cursor value) where T : InputElement
    => style._addSetter(InputElement.CursorProperty, value);
    public static Style<T> IsHitTestVisible<T>(this Style<T> style, Boolean value) where T : InputElement
    => style._addSetter(InputElement.IsHitTestVisibleProperty, value);
    public static Style<T> IsTabStop<T>(this Style<T> style, Boolean value) where T : InputElement
    => style._addSetter(InputElement.IsTabStopProperty, value);
    public static Style<T> TabIndex<T>(this Style<T> style, Int32 value) where T : InputElement
    => style._addSetter(InputElement.TabIndexProperty, value);
}
public static partial class ScrollGestureRecognizerExtensions
{
    public static Style<ScrollGestureRecognizer> CanHorizontallyScroll(this Style<ScrollGestureRecognizer> style, Boolean value)
    => style._addSetter(ScrollGestureRecognizer.CanHorizontallyScrollProperty, value);
    public static Style<ScrollGestureRecognizer> CanVerticallyScroll(this Style<ScrollGestureRecognizer> style, Boolean value)
    => style._addSetter(ScrollGestureRecognizer.CanVerticallyScrollProperty, value);
}


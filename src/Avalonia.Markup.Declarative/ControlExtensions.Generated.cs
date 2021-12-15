using Avalonia;
using Avalonia.Animation;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Primitives.PopupPositioning;
using Avalonia.Controls.Selection;
using Avalonia.Controls.Shapes;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Platform;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Avalonia.Markup.Declarative;
public static partial class ControlExtensions
{
public static AutoCompleteBox Watermark(this AutoCompleteBox control, String value)
   => control._set(() => control.Watermark = value);
public static AutoCompleteBox Watermark(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.WatermarkProperty] = binding);

public static AutoCompleteBox MinimumPrefixLength(this AutoCompleteBox control, Int32 value)
   => control._set(() => control.MinimumPrefixLength = value);
public static AutoCompleteBox MinimumPrefixLength(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.MinimumPrefixLengthProperty] = binding);

public static AutoCompleteBox MinimumPopulateDelay(this AutoCompleteBox control, TimeSpan value)
   => control._set(() => control.MinimumPopulateDelay = value);
public static AutoCompleteBox MinimumPopulateDelay(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.MinimumPopulateDelayProperty] = binding);

public static AutoCompleteBox MaxDropDownHeight(this AutoCompleteBox control, Double value)
   => control._set(() => control.MaxDropDownHeight = value);
public static AutoCompleteBox MaxDropDownHeight(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.MaxDropDownHeightProperty] = binding);

public static AutoCompleteBox IsTextCompletionEnabled(this AutoCompleteBox control, Boolean value)
   => control._set(() => control.IsTextCompletionEnabled = value);
public static AutoCompleteBox IsTextCompletionEnabled(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.IsTextCompletionEnabledProperty] = binding);

public static AutoCompleteBox ItemTemplate(this AutoCompleteBox control, IDataTemplate value)
   => control._set(() => control.ItemTemplate = value);
public static AutoCompleteBox ItemTemplate(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.ItemTemplateProperty] = binding);

public static AutoCompleteBox IsDropDownOpen(this AutoCompleteBox control, Boolean value)
   => control._set(() => control.IsDropDownOpen = value);
public static AutoCompleteBox IsDropDownOpen(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.IsDropDownOpenProperty] = binding);

public static AutoCompleteBox SelectedItem(this AutoCompleteBox control, Object value)
   => control._set(() => control.SelectedItem = value);
public static AutoCompleteBox SelectedItem(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.SelectedItemProperty] = binding);

public static AutoCompleteBox Text(this AutoCompleteBox control, String value)
   => control._set(() => control.Text = value);
public static AutoCompleteBox Text(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.TextProperty] = binding);

public static AutoCompleteBox FilterMode(this AutoCompleteBox control, AutoCompleteFilterMode value)
   => control._set(() => control.FilterMode = value);
public static AutoCompleteBox FilterMode(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.FilterModeProperty] = binding);

public static AutoCompleteBox ItemFilter(this AutoCompleteBox control, AutoCompleteFilterPredicate<Object> value)
   => control._set(() => control.ItemFilter = value);
public static AutoCompleteBox ItemFilter(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.ItemFilterProperty] = binding);

public static AutoCompleteBox TextFilter(this AutoCompleteBox control, AutoCompleteFilterPredicate<String> value)
   => control._set(() => control.TextFilter = value);
public static AutoCompleteBox TextFilter(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.TextFilterProperty] = binding);

public static AutoCompleteBox ItemSelector(this AutoCompleteBox control, AutoCompleteSelector<Object> value)
   => control._set(() => control.ItemSelector = value);
public static AutoCompleteBox ItemSelector(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.ItemSelectorProperty] = binding);

public static AutoCompleteBox TextSelector(this AutoCompleteBox control, AutoCompleteSelector<String> value)
   => control._set(() => control.TextSelector = value);
public static AutoCompleteBox TextSelector(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.TextSelectorProperty] = binding);

public static AutoCompleteBox Items(this AutoCompleteBox control, IEnumerable value)
   => control._set(() => control.Items = value);
public static AutoCompleteBox Items(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.ItemsProperty] = binding);

public static AutoCompleteBox AsyncPopulator(this AutoCompleteBox control, Func<String,CancellationToken,Task<IEnumerable<Object>>> value)
   => control._set(() => control.AsyncPopulator = value);
public static AutoCompleteBox AsyncPopulator(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.AsyncPopulatorProperty] = binding);

public static Border Background(this Border control, IBrush value)
   => control._set(() => control.Background = value);
public static Border Background(this Border control, IBinding binding)
   => control._set(() => control[!Border.BackgroundProperty] = binding);

public static Border BorderBrush(this Border control, IBrush value)
   => control._set(() => control.BorderBrush = value);
public static Border BorderBrush(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderBrushProperty] = binding);

public static Border BorderThickness(this Border control, Thickness value)
   => control._set(() => control.BorderThickness = value);
public static Border BorderThickness(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderThicknessProperty] = binding);
public static Border BorderThickness(this Border control, Double uniformLength)
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static Border BorderThickness(this Border control, Double horizontal, Double vertical)
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static Border BorderThickness(this Border control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));

public static Border CornerRadius(this Border control, CornerRadius value)
   => control._set(() => control.CornerRadius = value);
public static Border CornerRadius(this Border control, IBinding binding)
   => control._set(() => control[!Border.CornerRadiusProperty] = binding);
public static Border CornerRadius(this Border control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static Border CornerRadius(this Border control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static Border CornerRadius(this Border control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));

public static Border BoxShadow(this Border control, BoxShadows value)
   => control._set(() => control.BoxShadow = value);
public static Border BoxShadow(this Border control, IBinding binding)
   => control._set(() => control[!Border.BoxShadowProperty] = binding);
public static Border BoxShadow(this Border control, BoxShadow shadow)
   => control._set(() => control.BoxShadow = new BoxShadows(shadow));
public static Border BoxShadow(this Border control, BoxShadow first, BoxShadow[] rest)
   => control._set(() => control.BoxShadow = new BoxShadows(first, rest));

public static Border BorderDashOffset(this Border control, Double value)
   => control._set(() => control.BorderDashOffset = value);
public static Border BorderDashOffset(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderDashOffsetProperty] = binding);

public static Border BorderDashArray(this Border control, AvaloniaList<Double> value)
   => control._set(() => control.BorderDashArray = value);
public static Border BorderDashArray(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderDashArrayProperty] = binding);

public static Border BorderLineCap(this Border control, PenLineCap value)
   => control._set(() => control.BorderLineCap = value);
public static Border BorderLineCap(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderLineCapProperty] = binding);

public static Border BorderLineJoin(this Border control, PenLineJoin value)
   => control._set(() => control.BorderLineJoin = value);
public static Border BorderLineJoin(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderLineJoinProperty] = binding);

public static Button ClickMode(this Button control, ClickMode value)
   => control._set(() => control.ClickMode = value);
public static Button ClickMode(this Button control, IBinding binding)
   => control._set(() => control[!Button.ClickModeProperty] = binding);

public static Button Command(this Button control, ICommand value)
   => control._set(() => control.Command = value);
public static Button Command(this Button control, IBinding binding)
   => control._set(() => control[!Button.CommandProperty] = binding);

public static Button HotKey(this Button control, KeyGesture value)
   => control._set(() => control.HotKey = value);
public static Button HotKey(this Button control, IBinding binding)
   => control._set(() => control[!Button.HotKeyProperty] = binding);

public static Button CommandParameter(this Button control, Object value)
   => control._set(() => control.CommandParameter = value);
public static Button CommandParameter(this Button control, IBinding binding)
   => control._set(() => control[!Button.CommandParameterProperty] = binding);

public static Button IsDefault(this Button control, Boolean value)
   => control._set(() => control.IsDefault = value);
public static Button IsDefault(this Button control, IBinding binding)
   => control._set(() => control[!Button.IsDefaultProperty] = binding);

public static Button IsCancel(this Button control, Boolean value)
   => control._set(() => control.IsCancel = value);
public static Button IsCancel(this Button control, IBinding binding)
   => control._set(() => control[!Button.IsCancelProperty] = binding);

public static Button Flyout(this Button control, FlyoutBase value)
   => control._set(() => control.Flyout = value);
public static Button Flyout(this Button control, IBinding binding)
   => control._set(() => control[!Button.FlyoutProperty] = binding);

public static ButtonSpinner AllowSpin(this ButtonSpinner control, Boolean value)
   => control._set(() => control.AllowSpin = value);
public static ButtonSpinner AllowSpin(this ButtonSpinner control, IBinding binding)
   => control._set(() => control[!ButtonSpinner.AllowSpinProperty] = binding);

public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, Boolean value)
   => control._set(() => control.ShowButtonSpinner = value);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, IBinding binding)
   => control._set(() => control[!ButtonSpinner.ShowButtonSpinnerProperty] = binding);

public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, Location value)
   => control._set(() => control.ButtonSpinnerLocation = value);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, IBinding binding)
   => control._set(() => control[!ButtonSpinner.ButtonSpinnerLocationProperty] = binding);

public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, DayOfWeek value)
   => control._set(() => control.FirstDayOfWeek = value);
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = binding);

public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, Boolean value)
   => control._set(() => control.IsTodayHighlighted = value);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.IsTodayHighlightedProperty] = binding);

public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, IBrush value)
   => control._set(() => control.HeaderBackground = value);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.HeaderBackgroundProperty] = binding);

public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, CalendarMode value)
   => control._set(() => control.DisplayMode = value);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.DisplayModeProperty] = binding);

public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, CalendarSelectionMode value)
   => control._set(() => control.SelectionMode = value);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.SelectionModeProperty] = binding);

public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, Nullable<DateTime> value)
   => control._set(() => control.SelectedDate = value);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.SelectedDateProperty] = binding);

public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, DateTime value)
   => control._set(() => control.DisplayDate = value);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.DisplayDateProperty] = binding);

public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, Nullable<DateTime> value)
   => control._set(() => control.DisplayDateStart = value);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.DisplayDateStartProperty] = binding);

public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, Nullable<DateTime> value)
   => control._set(() => control.DisplayDateEnd = value);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.DisplayDateEndProperty] = binding);

public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, DateTime value)
   => control._set(() => control.DisplayDate = value);
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.DisplayDateProperty] = binding);

public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, Nullable<DateTime> value)
   => control._set(() => control.DisplayDateStart = value);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.DisplayDateStartProperty] = binding);

public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, Nullable<DateTime> value)
   => control._set(() => control.DisplayDateEnd = value);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.DisplayDateEndProperty] = binding);

public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, DayOfWeek value)
   => control._set(() => control.FirstDayOfWeek = value);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.FirstDayOfWeekProperty] = binding);

public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, Boolean value)
   => control._set(() => control.IsDropDownOpen = value);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.IsDropDownOpenProperty] = binding);

public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, Boolean value)
   => control._set(() => control.IsTodayHighlighted = value);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.IsTodayHighlightedProperty] = binding);

public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, Nullable<DateTime> value)
   => control._set(() => control.SelectedDate = value);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.SelectedDateProperty] = binding);

public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, CalendarDatePickerFormat value)
   => control._set(() => control.SelectedDateFormat = value);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.SelectedDateFormatProperty] = binding);

public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, String value)
   => control._set(() => control.CustomDateFormatString = value);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.CustomDateFormatStringProperty] = binding);

public static CalendarDatePicker Text(this CalendarDatePicker control, String value)
   => control._set(() => control.Text = value);
public static CalendarDatePicker Text(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.TextProperty] = binding);

public static CalendarDatePicker Watermark(this CalendarDatePicker control, String value)
   => control._set(() => control.Watermark = value);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.WatermarkProperty] = binding);

public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, Boolean value)
   => control._set(() => control.UseFloatingWatermark = value);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.UseFloatingWatermarkProperty] = binding);

public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, HorizontalAlignment value)
   => control._set(() => control.HorizontalContentAlignment = value);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.HorizontalContentAlignmentProperty] = binding);

public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, VerticalAlignment value)
   => control._set(() => control.VerticalContentAlignment = value);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.VerticalContentAlignmentProperty] = binding);

public static Carousel IsVirtualized(this Carousel control, Boolean value)
   => control._set(() => control.IsVirtualized = value);
public static Carousel IsVirtualized(this Carousel control, IBinding binding)
   => control._set(() => control[!Carousel.IsVirtualizedProperty] = binding);

public static Carousel PageTransition(this Carousel control, IPageTransition value)
   => control._set(() => control.PageTransition = value);
public static Carousel PageTransition(this Carousel control, IBinding binding)
   => control._set(() => control[!Carousel.PageTransitionProperty] = binding);

public static ComboBox IsDropDownOpen(this ComboBox control, Boolean value)
   => control._set(() => control.IsDropDownOpen = value);
public static ComboBox IsDropDownOpen(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.IsDropDownOpenProperty] = binding);

public static ComboBox MaxDropDownHeight(this ComboBox control, Double value)
   => control._set(() => control.MaxDropDownHeight = value);
public static ComboBox MaxDropDownHeight(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.MaxDropDownHeightProperty] = binding);

public static ComboBox VirtualizationMode(this ComboBox control, ItemVirtualizationMode value)
   => control._set(() => control.VirtualizationMode = value);
public static ComboBox VirtualizationMode(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.VirtualizationModeProperty] = binding);

public static ComboBox PlaceholderText(this ComboBox control, String value)
   => control._set(() => control.PlaceholderText = value);
public static ComboBox PlaceholderText(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.PlaceholderTextProperty] = binding);

public static ComboBox PlaceholderForeground(this ComboBox control, IBrush value)
   => control._set(() => control.PlaceholderForeground = value);
public static ComboBox PlaceholderForeground(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.PlaceholderForegroundProperty] = binding);

public static ComboBox HorizontalContentAlignment(this ComboBox control, HorizontalAlignment value)
   => control._set(() => control.HorizontalContentAlignment = value);
public static ComboBox HorizontalContentAlignment(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.HorizontalContentAlignmentProperty] = binding);

public static ComboBox VerticalContentAlignment(this ComboBox control, VerticalAlignment value)
   => control._set(() => control.VerticalContentAlignment = value);
public static ComboBox VerticalContentAlignment(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.VerticalContentAlignmentProperty] = binding);

public static T Content<T>(this T control, Object value) where T : ContentControl
   => control._set(() => control.Content = value);
public static T Content<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(() => control[!ContentControl.ContentProperty] = binding);

public static T ContentTemplate<T>(this T control, IDataTemplate value) where T : ContentControl
   => control._set(() => control.ContentTemplate = value);
public static T ContentTemplate<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(() => control[!ContentControl.ContentTemplateProperty] = binding);

public static T HorizontalContentAlignment<T>(this T control, HorizontalAlignment value) where T : ContentControl
   => control._set(() => control.HorizontalContentAlignment = value);
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(() => control[!ContentControl.HorizontalContentAlignmentProperty] = binding);

public static T VerticalContentAlignment<T>(this T control, VerticalAlignment value) where T : ContentControl
   => control._set(() => control.VerticalContentAlignment = value);
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(() => control[!ContentControl.VerticalContentAlignmentProperty] = binding);

public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, Double value)
   => control._set(() => control.HorizontalOffset = value);
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.HorizontalOffsetProperty] = binding);

public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, Double value)
   => control._set(() => control.VerticalOffset = value);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.VerticalOffsetProperty] = binding);

public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, PopupAnchor value)
   => control._set(() => control.PlacementAnchor = value);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementAnchorProperty] = binding);

public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, PopupPositionerConstraintAdjustment value)
   => control._set(() => control.PlacementConstraintAdjustment = value);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty] = binding);

public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, PopupGravity value)
   => control._set(() => control.PlacementGravity = value);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementGravityProperty] = binding);

public static Avalonia.Controls.ContextMenu PlacementMode(this Avalonia.Controls.ContextMenu control, PlacementMode value)
   => control._set(() => control.PlacementMode = value);
public static Avalonia.Controls.ContextMenu PlacementMode(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementModeProperty] = binding);

public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, Nullable<Rect> value)
   => control._set(() => control.PlacementRect = value);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementRectProperty] = binding);

public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, Boolean value)
   => control._set(() => control.WindowManagerAddShadowHint = value);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty] = binding);

public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, Control value)
   => control._set(() => control.PlacementTarget = value);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementTargetProperty] = binding);

public static Control FocusAdorner(this Control control, ITemplate<IControl> value)
   => control._set(() => control.FocusAdorner = value);
public static Control FocusAdorner(this Control control, IBinding binding)
   => control._set(() => control[!Control.FocusAdornerProperty] = binding);

public static Control Tag(this Control control, Object value)
   => control._set(() => control.Tag = value);
public static Control Tag(this Control control, IBinding binding)
   => control._set(() => control[!Control.TagProperty] = binding);

public static Control ContextMenu(this Control control, Avalonia.Controls.ContextMenu value)
   => control._set(() => control.ContextMenu = value);
public static Control ContextMenu(this Control control, IBinding binding)
   => control._set(() => control[!Control.ContextMenuProperty] = binding);

public static Control ContextFlyout(this Control control, FlyoutBase value)
   => control._set(() => control.ContextFlyout = value);
public static Control ContextFlyout(this Control control, IBinding binding)
   => control._set(() => control[!Control.ContextFlyoutProperty] = binding);

public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, IDataTemplate value)
   => control._set(() => control.ErrorTemplate = value);
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, IBinding binding)
   => control._set(() => control[!DataValidationErrors.ErrorTemplateProperty] = binding);

public static DataValidationErrors Owner(this DataValidationErrors control, Control value)
   => control._set(() => control.Owner = value);
public static DataValidationErrors Owner(this DataValidationErrors control, IBinding binding)
   => control._set(() => control[!DataValidationErrors.OwnerProperty] = binding);

public static DatePicker DayFormat(this DatePicker control, String value)
   => control._set(() => control.DayFormat = value);
public static DatePicker DayFormat(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.DayFormatProperty] = binding);

public static DatePicker DayVisible(this DatePicker control, Boolean value)
   => control._set(() => control.DayVisible = value);
public static DatePicker DayVisible(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.DayVisibleProperty] = binding);

public static DatePicker Header(this DatePicker control, Object value)
   => control._set(() => control.Header = value);
public static DatePicker Header(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.HeaderProperty] = binding);

public static DatePicker HeaderTemplate(this DatePicker control, IDataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static DatePicker HeaderTemplate(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.HeaderTemplateProperty] = binding);

public static DatePicker MaxYear(this DatePicker control, DateTimeOffset value)
   => control._set(() => control.MaxYear = value);
public static DatePicker MaxYear(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.MaxYearProperty] = binding);

public static DatePicker MinYear(this DatePicker control, DateTimeOffset value)
   => control._set(() => control.MinYear = value);
public static DatePicker MinYear(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.MinYearProperty] = binding);

public static DatePicker MonthFormat(this DatePicker control, String value)
   => control._set(() => control.MonthFormat = value);
public static DatePicker MonthFormat(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.MonthFormatProperty] = binding);

public static DatePicker MonthVisible(this DatePicker control, Boolean value)
   => control._set(() => control.MonthVisible = value);
public static DatePicker MonthVisible(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.MonthVisibleProperty] = binding);

public static DatePicker YearFormat(this DatePicker control, String value)
   => control._set(() => control.YearFormat = value);
public static DatePicker YearFormat(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.YearFormatProperty] = binding);

public static DatePicker YearVisible(this DatePicker control, Boolean value)
   => control._set(() => control.YearVisible = value);
public static DatePicker YearVisible(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.YearVisibleProperty] = binding);

public static DatePicker SelectedDate(this DatePicker control, Nullable<DateTimeOffset> value)
   => control._set(() => control.SelectedDate = value);
public static DatePicker SelectedDate(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.SelectedDateProperty] = binding);

public static DatePickerPresenter Date(this DatePickerPresenter control, DateTimeOffset value)
   => control._set(() => control.Date = value);
public static DatePickerPresenter Date(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.DateProperty] = binding);

public static DatePickerPresenter DayFormat(this DatePickerPresenter control, String value)
   => control._set(() => control.DayFormat = value);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.DayFormatProperty] = binding);

public static DatePickerPresenter DayVisible(this DatePickerPresenter control, Boolean value)
   => control._set(() => control.DayVisible = value);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.DayVisibleProperty] = binding);

public static DatePickerPresenter MaxYear(this DatePickerPresenter control, DateTimeOffset value)
   => control._set(() => control.MaxYear = value);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.MaxYearProperty] = binding);

public static DatePickerPresenter MinYear(this DatePickerPresenter control, DateTimeOffset value)
   => control._set(() => control.MinYear = value);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.MinYearProperty] = binding);

public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, String value)
   => control._set(() => control.MonthFormat = value);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.MonthFormatProperty] = binding);

public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, Boolean value)
   => control._set(() => control.MonthVisible = value);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.MonthVisibleProperty] = binding);

public static DatePickerPresenter YearFormat(this DatePickerPresenter control, String value)
   => control._set(() => control.YearFormat = value);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.YearFormatProperty] = binding);

public static DatePickerPresenter YearVisible(this DatePickerPresenter control, Boolean value)
   => control._set(() => control.YearVisible = value);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.YearVisibleProperty] = binding);

public static TimePicker MinuteIncrement(this TimePicker control, Int32 value)
   => control._set(() => control.MinuteIncrement = value);
public static TimePicker MinuteIncrement(this TimePicker control, IBinding binding)
   => control._set(() => control[!TimePicker.MinuteIncrementProperty] = binding);

public static TimePicker Header(this TimePicker control, Object value)
   => control._set(() => control.Header = value);
public static TimePicker Header(this TimePicker control, IBinding binding)
   => control._set(() => control[!TimePicker.HeaderProperty] = binding);

public static TimePicker HeaderTemplate(this TimePicker control, IDataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static TimePicker HeaderTemplate(this TimePicker control, IBinding binding)
   => control._set(() => control[!TimePicker.HeaderTemplateProperty] = binding);

public static TimePicker ClockIdentifier(this TimePicker control, String value)
   => control._set(() => control.ClockIdentifier = value);
public static TimePicker ClockIdentifier(this TimePicker control, IBinding binding)
   => control._set(() => control[!TimePicker.ClockIdentifierProperty] = binding);

public static TimePicker SelectedTime(this TimePicker control, Nullable<TimeSpan> value)
   => control._set(() => control.SelectedTime = value);
public static TimePicker SelectedTime(this TimePicker control, IBinding binding)
   => control._set(() => control[!TimePicker.SelectedTimeProperty] = binding);

public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, Int32 value)
   => control._set(() => control.MinuteIncrement = value);
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, IBinding binding)
   => control._set(() => control[!TimePickerPresenter.MinuteIncrementProperty] = binding);

public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, String value)
   => control._set(() => control.ClockIdentifier = value);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, IBinding binding)
   => control._set(() => control[!TimePickerPresenter.ClockIdentifierProperty] = binding);

public static TimePickerPresenter Time(this TimePickerPresenter control, TimeSpan value)
   => control._set(() => control.Time = value);
public static TimePickerPresenter Time(this TimePickerPresenter control, IBinding binding)
   => control._set(() => control[!TimePickerPresenter.TimeProperty] = binding);

public static Decorator Child(this Decorator control, IControl value)
   => control._set(() => control.Child = value);
public static Decorator Child(this Decorator control, IBinding binding)
   => control._set(() => control[!Decorator.ChildProperty] = binding);

public static Decorator Padding(this Decorator control, Thickness value)
   => control._set(() => control.Padding = value);
public static Decorator Padding(this Decorator control, IBinding binding)
   => control._set(() => control[!Decorator.PaddingProperty] = binding);
public static Decorator Padding(this Decorator control, Double uniformLength)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static Decorator Padding(this Decorator control, Double horizontal, Double vertical)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static Decorator Padding(this Decorator control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));

public static DockPanel LastChildFill(this DockPanel control, Boolean value)
   => control._set(() => control.LastChildFill = value);
public static DockPanel LastChildFill(this DockPanel control, IBinding binding)
   => control._set(() => control[!DockPanel.LastChildFillProperty] = binding);

public static Expander ContentTransition(this Expander control, IPageTransition value)
   => control._set(() => control.ContentTransition = value);
public static Expander ContentTransition(this Expander control, IBinding binding)
   => control._set(() => control[!Expander.ContentTransitionProperty] = binding);

public static Expander ExpandDirection(this Expander control, ExpandDirection value)
   => control._set(() => control.ExpandDirection = value);
public static Expander ExpandDirection(this Expander control, IBinding binding)
   => control._set(() => control[!Expander.ExpandDirectionProperty] = binding);

public static Expander IsExpanded(this Expander control, Boolean value)
   => control._set(() => control.IsExpanded = value);
public static Expander IsExpanded(this Expander control, IBinding binding)
   => control._set(() => control[!Expander.IsExpandedProperty] = binding);

public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, CornerRadius value)
   => control._set(() => control.CornerRadius = value);
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, IBinding binding)
   => control._set(() => control[!ExperimentalAcrylicBorder.CornerRadiusProperty] = binding);
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));

public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, ExperimentalAcrylicMaterial value)
   => control._set(() => control.Material = value);
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, IBinding binding)
   => control._set(() => control[!ExperimentalAcrylicBorder.MaterialProperty] = binding);

public static MenuFlyoutPresenter CornerRadius(this MenuFlyoutPresenter control, CornerRadius value)
   => control._set(() => control.CornerRadius = value);
public static MenuFlyoutPresenter CornerRadius(this MenuFlyoutPresenter control, IBinding binding)
   => control._set(() => control[!MenuFlyoutPresenter.CornerRadiusProperty] = binding);
public static MenuFlyoutPresenter CornerRadius(this MenuFlyoutPresenter control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static MenuFlyoutPresenter CornerRadius(this MenuFlyoutPresenter control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static MenuFlyoutPresenter CornerRadius(this MenuFlyoutPresenter control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));

public static Grid ShowGridLines(this Grid control, Boolean value)
   => control._set(() => control.ShowGridLines = value);
public static Grid ShowGridLines(this Grid control, IBinding binding)
   => control._set(() => control[!Grid.ShowGridLinesProperty] = binding);

public static GridSplitter ResizeDirection(this GridSplitter control, GridResizeDirection value)
   => control._set(() => control.ResizeDirection = value);
public static GridSplitter ResizeDirection(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.ResizeDirectionProperty] = binding);

public static GridSplitter ResizeBehavior(this GridSplitter control, GridResizeBehavior value)
   => control._set(() => control.ResizeBehavior = value);
public static GridSplitter ResizeBehavior(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.ResizeBehaviorProperty] = binding);

public static GridSplitter ShowsPreview(this GridSplitter control, Boolean value)
   => control._set(() => control.ShowsPreview = value);
public static GridSplitter ShowsPreview(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.ShowsPreviewProperty] = binding);

public static GridSplitter KeyboardIncrement(this GridSplitter control, Double value)
   => control._set(() => control.KeyboardIncrement = value);
public static GridSplitter KeyboardIncrement(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.KeyboardIncrementProperty] = binding);

public static GridSplitter DragIncrement(this GridSplitter control, Double value)
   => control._set(() => control.DragIncrement = value);
public static GridSplitter DragIncrement(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.DragIncrementProperty] = binding);

public static GridSplitter PreviewContent(this GridSplitter control, ITemplate<IControl> value)
   => control._set(() => control.PreviewContent = value);
public static GridSplitter PreviewContent(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.PreviewContentProperty] = binding);

public static Image Source(this Image control, IImage value)
   => control._set(() => control.Source = value);
public static Image Source(this Image control, IBinding binding)
   => control._set(() => control[!Image.SourceProperty] = binding);

public static Image Stretch(this Image control, Stretch value)
   => control._set(() => control.Stretch = value);
public static Image Stretch(this Image control, IBinding binding)
   => control._set(() => control[!Image.StretchProperty] = binding);

public static Image StretchDirection(this Image control, StretchDirection value)
   => control._set(() => control.StretchDirection = value);
public static Image StretchDirection(this Image control, IBinding binding)
   => control._set(() => control[!Image.StretchDirectionProperty] = binding);

public static T Items<T>(this T control, IEnumerable value) where T : ItemsControl
   => control._set(() => control.Items = value);
public static T Items<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(() => control[!ItemsControl.ItemsProperty] = binding);

public static T ItemsPanel<T>(this T control, ITemplate<IPanel> value) where T : ItemsControl
   => control._set(() => control.ItemsPanel = value);
public static T ItemsPanel<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(() => control[!ItemsControl.ItemsPanelProperty] = binding);

public static T ItemTemplate<T>(this T control, IDataTemplate value) where T : ItemsControl
   => control._set(() => control.ItemTemplate = value);
public static T ItemTemplate<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(() => control[!ItemsControl.ItemTemplateProperty] = binding);

public static Label Target(this Label control, IInputElement value)
   => control._set(() => control.Target = value);
public static Label Target(this Label control, IBinding binding)
   => control._set(() => control[!Label.TargetProperty] = binding);

public static LayoutTransformControl LayoutTransform(this LayoutTransformControl control, ITransform value)
   => control._set(() => control.LayoutTransform = value);
public static LayoutTransformControl LayoutTransform(this LayoutTransformControl control, IBinding binding)
   => control._set(() => control[!LayoutTransformControl.LayoutTransformProperty] = binding);

public static LayoutTransformControl UseRenderTransform(this LayoutTransformControl control, Boolean value)
   => control._set(() => control.UseRenderTransform = value);
public static LayoutTransformControl UseRenderTransform(this LayoutTransformControl control, IBinding binding)
   => control._set(() => control[!LayoutTransformControl.UseRenderTransformProperty] = binding);

public static ListBox SelectedItems(this ListBox control, IList value)
   => control._set(() => control.SelectedItems = value);
public static ListBox SelectedItems(this ListBox control, IBinding binding)
   => control._set(() => control[!ListBox.SelectedItemsProperty] = binding);

public static ListBox Selection(this ListBox control, ISelectionModel value)
   => control._set(() => control.Selection = value);
public static ListBox Selection(this ListBox control, IBinding binding)
   => control._set(() => control[!ListBox.SelectionProperty] = binding);

public static ListBox SelectionMode(this ListBox control, SelectionMode value)
   => control._set(() => control.SelectionMode = value);
public static ListBox SelectionMode(this ListBox control, IBinding binding)
   => control._set(() => control[!ListBox.SelectionModeProperty] = binding);

public static ListBox VirtualizationMode(this ListBox control, ItemVirtualizationMode value)
   => control._set(() => control.VirtualizationMode = value);
public static ListBox VirtualizationMode(this ListBox control, IBinding binding)
   => control._set(() => control[!ListBox.VirtualizationModeProperty] = binding);

public static ListBoxItem IsSelected(this ListBoxItem control, Boolean value)
   => control._set(() => control.IsSelected = value);
public static ListBoxItem IsSelected(this ListBoxItem control, IBinding binding)
   => control._set(() => control[!ListBoxItem.IsSelectedProperty] = binding);

public static MaskedTextBox AsciiOnly(this MaskedTextBox control, Boolean value)
   => control._set(() => control.AsciiOnly = value);
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.AsciiOnlyProperty] = binding);

public static MaskedTextBox Culture(this MaskedTextBox control, CultureInfo value)
   => control._set(() => control.Culture = value);
public static MaskedTextBox Culture(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.CultureProperty] = binding);

public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, Boolean value)
   => control._set(() => control.HidePromptOnLeave = value);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.HidePromptOnLeaveProperty] = binding);

public static MaskedTextBox Mask(this MaskedTextBox control, String value)
   => control._set(() => control.Mask = value);
public static MaskedTextBox Mask(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.MaskProperty] = binding);

public static MaskedTextBox PasswordChar(this MaskedTextBox control, Char value)
   => control._set(() => control.PasswordChar = value);
public static MaskedTextBox PasswordChar(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.PasswordCharProperty] = binding);

public static MaskedTextBox PromptChar(this MaskedTextBox control, Char value)
   => control._set(() => control.PromptChar = value);
public static MaskedTextBox PromptChar(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.PromptCharProperty] = binding);

public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, Boolean value)
   => control._set(() => control.ResetOnPrompt = value);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.ResetOnPromptProperty] = binding);

public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, Boolean value)
   => control._set(() => control.ResetOnSpace = value);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.ResetOnSpaceProperty] = binding);

public static MenuItem Command(this MenuItem control, ICommand value)
   => control._set(() => control.Command = value);
public static MenuItem Command(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.CommandProperty] = binding);

public static MenuItem HotKey(this MenuItem control, KeyGesture value)
   => control._set(() => control.HotKey = value);
public static MenuItem HotKey(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.HotKeyProperty] = binding);

public static MenuItem CommandParameter(this MenuItem control, Object value)
   => control._set(() => control.CommandParameter = value);
public static MenuItem CommandParameter(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.CommandParameterProperty] = binding);

public static MenuItem Icon(this MenuItem control, Object value)
   => control._set(() => control.Icon = value);
public static MenuItem Icon(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.IconProperty] = binding);

public static MenuItem InputGesture(this MenuItem control, KeyGesture value)
   => control._set(() => control.InputGesture = value);
public static MenuItem InputGesture(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.InputGestureProperty] = binding);

public static MenuItem IsSelected(this MenuItem control, Boolean value)
   => control._set(() => control.IsSelected = value);
public static MenuItem IsSelected(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.IsSelectedProperty] = binding);

public static MenuItem IsSubMenuOpen(this MenuItem control, Boolean value)
   => control._set(() => control.IsSubMenuOpen = value);
public static MenuItem IsSubMenuOpen(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.IsSubMenuOpenProperty] = binding);

public static MenuItem StaysOpenOnClick(this MenuItem control, Boolean value)
   => control._set(() => control.StaysOpenOnClick = value);
public static MenuItem StaysOpenOnClick(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.StaysOpenOnClickProperty] = binding);

public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, Boolean value)
   => control._set(() => control.ReverseOrder = value);
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, IBinding binding)
   => control._set(() => control[!ReversibleStackPanel.ReverseOrderProperty] = binding);

public static NumericUpDown AllowSpin(this NumericUpDown control, Boolean value)
   => control._set(() => control.AllowSpin = value);
public static NumericUpDown AllowSpin(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.AllowSpinProperty] = binding);

public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, Location value)
   => control._set(() => control.ButtonSpinnerLocation = value);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.ButtonSpinnerLocationProperty] = binding);

public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, Boolean value)
   => control._set(() => control.ShowButtonSpinner = value);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.ShowButtonSpinnerProperty] = binding);

public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, Boolean value)
   => control._set(() => control.ClipValueToMinMax = value);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.ClipValueToMinMaxProperty] = binding);

public static NumericUpDown NumberFormat(this NumericUpDown control, NumberFormatInfo value)
   => control._set(() => control.NumberFormat = value);
public static NumericUpDown NumberFormat(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.NumberFormatProperty] = binding);

public static NumericUpDown FormatString(this NumericUpDown control, String value)
   => control._set(() => control.FormatString = value);
public static NumericUpDown FormatString(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.FormatStringProperty] = binding);

public static NumericUpDown Increment(this NumericUpDown control, Decimal value)
   => control._set(() => control.Increment = value);
public static NumericUpDown Increment(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.IncrementProperty] = binding);

public static NumericUpDown IsReadOnly(this NumericUpDown control, Boolean value)
   => control._set(() => control.IsReadOnly = value);
public static NumericUpDown IsReadOnly(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.IsReadOnlyProperty] = binding);

public static NumericUpDown Maximum(this NumericUpDown control, Decimal value)
   => control._set(() => control.Maximum = value);
public static NumericUpDown Maximum(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.MaximumProperty] = binding);

public static NumericUpDown Minimum(this NumericUpDown control, Decimal value)
   => control._set(() => control.Minimum = value);
public static NumericUpDown Minimum(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.MinimumProperty] = binding);

public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, NumberStyles value)
   => control._set(() => control.ParsingNumberStyle = value);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.ParsingNumberStyleProperty] = binding);

public static NumericUpDown Text(this NumericUpDown control, String value)
   => control._set(() => control.Text = value);
public static NumericUpDown Text(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.TextProperty] = binding);

public static NumericUpDown Value(this NumericUpDown control, Decimal value)
   => control._set(() => control.Value = value);
public static NumericUpDown Value(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.ValueProperty] = binding);

public static NumericUpDown Watermark(this NumericUpDown control, String value)
   => control._set(() => control.Watermark = value);
public static NumericUpDown Watermark(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.WatermarkProperty] = binding);

public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, HorizontalAlignment value)
   => control._set(() => control.HorizontalContentAlignment = value);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.HorizontalContentAlignmentProperty] = binding);

public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, VerticalAlignment value)
   => control._set(() => control.VerticalContentAlignment = value);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.VerticalContentAlignmentProperty] = binding);

public static Panel Background(this Panel control, IBrush value)
   => control._set(() => control.Background = value);
public static Panel Background(this Panel control, IBinding binding)
   => control._set(() => control[!Panel.BackgroundProperty] = binding);

public static PathIcon Data(this PathIcon control, Geometry value)
   => control._set(() => control.Data = value);
public static PathIcon Data(this PathIcon control, IBinding binding)
   => control._set(() => control[!PathIcon.DataProperty] = binding);

public static ProgressBar IsIndeterminate(this ProgressBar control, Boolean value)
   => control._set(() => control.IsIndeterminate = value);
public static ProgressBar IsIndeterminate(this ProgressBar control, IBinding binding)
   => control._set(() => control[!ProgressBar.IsIndeterminateProperty] = binding);

public static ProgressBar ShowProgressText(this ProgressBar control, Boolean value)
   => control._set(() => control.ShowProgressText = value);
public static ProgressBar ShowProgressText(this ProgressBar control, IBinding binding)
   => control._set(() => control[!ProgressBar.ShowProgressTextProperty] = binding);

public static ProgressBar Orientation(this ProgressBar control, Orientation value)
   => control._set(() => control.Orientation = value);
public static ProgressBar Orientation(this ProgressBar control, IBinding binding)
   => control._set(() => control[!ProgressBar.OrientationProperty] = binding);

public static RadioButton GroupName(this RadioButton control, String value)
   => control._set(() => control.GroupName = value);
public static RadioButton GroupName(this RadioButton control, IBinding binding)
   => control._set(() => control[!RadioButton.GroupNameProperty] = binding);

public static RepeatButton Interval(this RepeatButton control, Int32 value)
   => control._set(() => control.Interval = value);
public static RepeatButton Interval(this RepeatButton control, IBinding binding)
   => control._set(() => control[!RepeatButton.IntervalProperty] = binding);

public static RepeatButton Delay(this RepeatButton control, Int32 value)
   => control._set(() => control.Delay = value);
public static RepeatButton Delay(this RepeatButton control, IBinding binding)
   => control._set(() => control[!RepeatButton.DelayProperty] = binding);

public static ItemsRepeater HorizontalCacheLength(this ItemsRepeater control, Double value)
   => control._set(() => control.HorizontalCacheLength = value);
public static ItemsRepeater HorizontalCacheLength(this ItemsRepeater control, IBinding binding)
   => control._set(() => control[!ItemsRepeater.HorizontalCacheLengthProperty] = binding);

public static ItemsRepeater ItemTemplate(this ItemsRepeater control, IDataTemplate value)
   => control._set(() => control.ItemTemplate = value);
public static ItemsRepeater ItemTemplate(this ItemsRepeater control, IBinding binding)
   => control._set(() => control[!ItemsRepeater.ItemTemplateProperty] = binding);

public static ItemsRepeater Items(this ItemsRepeater control, IEnumerable value)
   => control._set(() => control.Items = value);
public static ItemsRepeater Items(this ItemsRepeater control, IBinding binding)
   => control._set(() => control[!ItemsRepeater.ItemsProperty] = binding);

public static ItemsRepeater Layout(this ItemsRepeater control, AttachedLayout value)
   => control._set(() => control.Layout = value);
public static ItemsRepeater Layout(this ItemsRepeater control, IBinding binding)
   => control._set(() => control[!ItemsRepeater.LayoutProperty] = binding);

public static ItemsRepeater VerticalCacheLength(this ItemsRepeater control, Double value)
   => control._set(() => control.VerticalCacheLength = value);
public static ItemsRepeater VerticalCacheLength(this ItemsRepeater control, IBinding binding)
   => control._set(() => control[!ItemsRepeater.VerticalCacheLengthProperty] = binding);

public static ScrollViewer Offset(this ScrollViewer control, Vector value)
   => control._set(() => control.Offset = value);
public static ScrollViewer Offset(this ScrollViewer control, IBinding binding)
   => control._set(() => control[!ScrollViewer.OffsetProperty] = binding);

public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, ScrollBarVisibility value)
   => control._set(() => control.HorizontalScrollBarVisibility = value);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, IBinding binding)
   => control._set(() => control[!ScrollViewer.HorizontalScrollBarVisibilityProperty] = binding);

public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, ScrollBarVisibility value)
   => control._set(() => control.VerticalScrollBarVisibility = value);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, IBinding binding)
   => control._set(() => control[!ScrollViewer.VerticalScrollBarVisibilityProperty] = binding);

public static ScrollViewer AllowAutoHide(this ScrollViewer control, Boolean value)
   => control._set(() => control.AllowAutoHide = value);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, IBinding binding)
   => control._set(() => control[!ScrollViewer.AllowAutoHideProperty] = binding);

public static Slider Orientation(this Slider control, Orientation value)
   => control._set(() => control.Orientation = value);
public static Slider Orientation(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.OrientationProperty] = binding);

public static Slider IsDirectionReversed(this Slider control, Boolean value)
   => control._set(() => control.IsDirectionReversed = value);
public static Slider IsDirectionReversed(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.IsDirectionReversedProperty] = binding);

public static Slider IsSnapToTickEnabled(this Slider control, Boolean value)
   => control._set(() => control.IsSnapToTickEnabled = value);
public static Slider IsSnapToTickEnabled(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.IsSnapToTickEnabledProperty] = binding);

public static Slider TickFrequency(this Slider control, Double value)
   => control._set(() => control.TickFrequency = value);
public static Slider TickFrequency(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.TickFrequencyProperty] = binding);

public static Slider TickPlacement(this Slider control, TickPlacement value)
   => control._set(() => control.TickPlacement = value);
public static Slider TickPlacement(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.TickPlacementProperty] = binding);

public static Slider Ticks(this Slider control, AvaloniaList<Double> value)
   => control._set(() => control.Ticks = value);
public static Slider Ticks(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.TicksProperty] = binding);

public static Spinner ValidSpinDirection(this Spinner control, ValidSpinDirections value)
   => control._set(() => control.ValidSpinDirection = value);
public static Spinner ValidSpinDirection(this Spinner control, IBinding binding)
   => control._set(() => control[!Spinner.ValidSpinDirectionProperty] = binding);

public static SplitView CompactPaneLength(this SplitView control, Double value)
   => control._set(() => control.CompactPaneLength = value);
public static SplitView CompactPaneLength(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.CompactPaneLengthProperty] = binding);

public static SplitView DisplayMode(this SplitView control, SplitViewDisplayMode value)
   => control._set(() => control.DisplayMode = value);
public static SplitView DisplayMode(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.DisplayModeProperty] = binding);

public static SplitView IsPaneOpen(this SplitView control, Boolean value)
   => control._set(() => control.IsPaneOpen = value);
public static SplitView IsPaneOpen(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.IsPaneOpenProperty] = binding);

public static SplitView OpenPaneLength(this SplitView control, Double value)
   => control._set(() => control.OpenPaneLength = value);
public static SplitView OpenPaneLength(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.OpenPaneLengthProperty] = binding);

public static SplitView PaneBackground(this SplitView control, IBrush value)
   => control._set(() => control.PaneBackground = value);
public static SplitView PaneBackground(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.PaneBackgroundProperty] = binding);

public static SplitView PanePlacement(this SplitView control, SplitViewPanePlacement value)
   => control._set(() => control.PanePlacement = value);
public static SplitView PanePlacement(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.PanePlacementProperty] = binding);

public static SplitView Pane(this SplitView control, Object value)
   => control._set(() => control.Pane = value);
public static SplitView Pane(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.PaneProperty] = binding);

public static SplitView PaneTemplate(this SplitView control, IDataTemplate value)
   => control._set(() => control.PaneTemplate = value);
public static SplitView PaneTemplate(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.PaneTemplateProperty] = binding);

public static SplitView UseLightDismissOverlayMode(this SplitView control, Boolean value)
   => control._set(() => control.UseLightDismissOverlayMode = value);
public static SplitView UseLightDismissOverlayMode(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.UseLightDismissOverlayModeProperty] = binding);

public static SplitView TemplateSettings(this SplitView control, SplitViewTemplateSettings value)
   => control._set(() => control.TemplateSettings = value);
public static SplitView TemplateSettings(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.TemplateSettingsProperty] = binding);

public static StackPanel Spacing(this StackPanel control, Double value)
   => control._set(() => control.Spacing = value);
public static StackPanel Spacing(this StackPanel control, IBinding binding)
   => control._set(() => control[!StackPanel.SpacingProperty] = binding);

public static StackPanel Orientation(this StackPanel control, Orientation value)
   => control._set(() => control.Orientation = value);
public static StackPanel Orientation(this StackPanel control, IBinding binding)
   => control._set(() => control[!StackPanel.OrientationProperty] = binding);

public static TabControl TabStripPlacement(this TabControl control, Dock value)
   => control._set(() => control.TabStripPlacement = value);
public static TabControl TabStripPlacement(this TabControl control, IBinding binding)
   => control._set(() => control[!TabControl.TabStripPlacementProperty] = binding);

public static TabControl HorizontalContentAlignment(this TabControl control, HorizontalAlignment value)
   => control._set(() => control.HorizontalContentAlignment = value);
public static TabControl HorizontalContentAlignment(this TabControl control, IBinding binding)
   => control._set(() => control[!TabControl.HorizontalContentAlignmentProperty] = binding);

public static TabControl VerticalContentAlignment(this TabControl control, VerticalAlignment value)
   => control._set(() => control.VerticalContentAlignment = value);
public static TabControl VerticalContentAlignment(this TabControl control, IBinding binding)
   => control._set(() => control[!TabControl.VerticalContentAlignmentProperty] = binding);

public static TabControl ContentTemplate(this TabControl control, IDataTemplate value)
   => control._set(() => control.ContentTemplate = value);
public static TabControl ContentTemplate(this TabControl control, IBinding binding)
   => control._set(() => control[!TabControl.ContentTemplateProperty] = binding);

public static TabItem IsSelected(this TabItem control, Boolean value)
   => control._set(() => control.IsSelected = value);
public static TabItem IsSelected(this TabItem control, IBinding binding)
   => control._set(() => control[!TabItem.IsSelectedProperty] = binding);

public static TextBlock Background(this TextBlock control, IBrush value)
   => control._set(() => control.Background = value);
public static TextBlock Background(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.BackgroundProperty] = binding);

public static TextBlock Padding(this TextBlock control, Thickness value)
   => control._set(() => control.Padding = value);
public static TextBlock Padding(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.PaddingProperty] = binding);
public static TextBlock Padding(this TextBlock control, Double uniformLength)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static TextBlock Padding(this TextBlock control, Double horizontal, Double vertical)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static TextBlock Padding(this TextBlock control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));

public static TextBlock FontFamily(this TextBlock control, FontFamily value)
   => control._set(() => control.FontFamily = value);
public static TextBlock FontFamily(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.FontFamilyProperty] = binding);

public static TextBlock FontSize(this TextBlock control, Double value)
   => control._set(() => control.FontSize = value);
public static TextBlock FontSize(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.FontSizeProperty] = binding);

public static TextBlock FontStyle(this TextBlock control, FontStyle value)
   => control._set(() => control.FontStyle = value);
public static TextBlock FontStyle(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.FontStyleProperty] = binding);

public static TextBlock FontWeight(this TextBlock control, FontWeight value)
   => control._set(() => control.FontWeight = value);
public static TextBlock FontWeight(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.FontWeightProperty] = binding);

public static TextBlock Foreground(this TextBlock control, IBrush value)
   => control._set(() => control.Foreground = value);
public static TextBlock Foreground(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.ForegroundProperty] = binding);

public static TextBlock LineHeight(this TextBlock control, Double value)
   => control._set(() => control.LineHeight = value);
public static TextBlock LineHeight(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.LineHeightProperty] = binding);

public static TextBlock MaxLines(this TextBlock control, Int32 value)
   => control._set(() => control.MaxLines = value);
public static TextBlock MaxLines(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.MaxLinesProperty] = binding);

public static TextBlock Text(this TextBlock control, String value)
   => control._set(() => control.Text = value);
public static TextBlock Text(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.TextProperty] = binding);

public static TextBlock TextAlignment(this TextBlock control, TextAlignment value)
   => control._set(() => control.TextAlignment = value);
public static TextBlock TextAlignment(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.TextAlignmentProperty] = binding);

public static TextBlock TextWrapping(this TextBlock control, TextWrapping value)
   => control._set(() => control.TextWrapping = value);
public static TextBlock TextWrapping(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.TextWrappingProperty] = binding);

public static TextBlock TextTrimming(this TextBlock control, TextTrimming value)
   => control._set(() => control.TextTrimming = value);
public static TextBlock TextTrimming(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.TextTrimmingProperty] = binding);

public static TextBlock TextDecorations(this TextBlock control, TextDecorationCollection value)
   => control._set(() => control.TextDecorations = value);
public static TextBlock TextDecorations(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.TextDecorationsProperty] = binding);

public static TextBox AcceptsReturn(this TextBox control, Boolean value)
   => control._set(() => control.AcceptsReturn = value);
public static TextBox AcceptsReturn(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.AcceptsReturnProperty] = binding);

public static TextBox AcceptsTab(this TextBox control, Boolean value)
   => control._set(() => control.AcceptsTab = value);
public static TextBox AcceptsTab(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.AcceptsTabProperty] = binding);

public static TextBox CaretIndex(this TextBox control, Int32 value)
   => control._set(() => control.CaretIndex = value);
public static TextBox CaretIndex(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.CaretIndexProperty] = binding);

public static TextBox IsReadOnly(this TextBox control, Boolean value)
   => control._set(() => control.IsReadOnly = value);
public static TextBox IsReadOnly(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.IsReadOnlyProperty] = binding);

public static TextBox PasswordChar(this TextBox control, Char value)
   => control._set(() => control.PasswordChar = value);
public static TextBox PasswordChar(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.PasswordCharProperty] = binding);

public static TextBox SelectionBrush(this TextBox control, IBrush value)
   => control._set(() => control.SelectionBrush = value);
public static TextBox SelectionBrush(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.SelectionBrushProperty] = binding);

public static TextBox SelectionForegroundBrush(this TextBox control, IBrush value)
   => control._set(() => control.SelectionForegroundBrush = value);
public static TextBox SelectionForegroundBrush(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.SelectionForegroundBrushProperty] = binding);

public static TextBox CaretBrush(this TextBox control, IBrush value)
   => control._set(() => control.CaretBrush = value);
public static TextBox CaretBrush(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.CaretBrushProperty] = binding);

public static TextBox SelectionStart(this TextBox control, Int32 value)
   => control._set(() => control.SelectionStart = value);
public static TextBox SelectionStart(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.SelectionStartProperty] = binding);

public static TextBox SelectionEnd(this TextBox control, Int32 value)
   => control._set(() => control.SelectionEnd = value);
public static TextBox SelectionEnd(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.SelectionEndProperty] = binding);

public static TextBox MaxLength(this TextBox control, Int32 value)
   => control._set(() => control.MaxLength = value);
public static TextBox MaxLength(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.MaxLengthProperty] = binding);

public static TextBox Text(this TextBox control, String value)
   => control._set(() => control.Text = value);
public static TextBox Text(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.TextProperty] = binding);

public static TextBox TextAlignment(this TextBox control, TextAlignment value)
   => control._set(() => control.TextAlignment = value);
public static TextBox TextAlignment(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.TextAlignmentProperty] = binding);

public static TextBox HorizontalContentAlignment(this TextBox control, HorizontalAlignment value)
   => control._set(() => control.HorizontalContentAlignment = value);
public static TextBox HorizontalContentAlignment(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.HorizontalContentAlignmentProperty] = binding);

public static TextBox VerticalContentAlignment(this TextBox control, VerticalAlignment value)
   => control._set(() => control.VerticalContentAlignment = value);
public static TextBox VerticalContentAlignment(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.VerticalContentAlignmentProperty] = binding);

public static TextBox TextWrapping(this TextBox control, TextWrapping value)
   => control._set(() => control.TextWrapping = value);
public static TextBox TextWrapping(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.TextWrappingProperty] = binding);

public static TextBox Watermark(this TextBox control, String value)
   => control._set(() => control.Watermark = value);
public static TextBox Watermark(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.WatermarkProperty] = binding);

public static TextBox UseFloatingWatermark(this TextBox control, Boolean value)
   => control._set(() => control.UseFloatingWatermark = value);
public static TextBox UseFloatingWatermark(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.UseFloatingWatermarkProperty] = binding);

public static TextBox NewLine(this TextBox control, String value)
   => control._set(() => control.NewLine = value);
public static TextBox NewLine(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.NewLineProperty] = binding);

public static TextBox InnerLeftContent(this TextBox control, Object value)
   => control._set(() => control.InnerLeftContent = value);
public static TextBox InnerLeftContent(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.InnerLeftContentProperty] = binding);

public static TextBox InnerRightContent(this TextBox control, Object value)
   => control._set(() => control.InnerRightContent = value);
public static TextBox InnerRightContent(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.InnerRightContentProperty] = binding);

public static TextBox RevealPassword(this TextBox control, Boolean value)
   => control._set(() => control.RevealPassword = value);
public static TextBox RevealPassword(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.RevealPasswordProperty] = binding);

public static TextBox IsUndoEnabled(this TextBox control, Boolean value)
   => control._set(() => control.IsUndoEnabled = value);
public static TextBox IsUndoEnabled(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.IsUndoEnabledProperty] = binding);

public static TextBox UndoLimit(this TextBox control, Int32 value)
   => control._set(() => control.UndoLimit = value);
public static TextBox UndoLimit(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.UndoLimitProperty] = binding);

public static TickBar Fill(this TickBar control, IBrush value)
   => control._set(() => control.Fill = value);
public static TickBar Fill(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.FillProperty] = binding);

public static TickBar Minimum(this TickBar control, Double value)
   => control._set(() => control.Minimum = value);
public static TickBar Minimum(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.MinimumProperty] = binding);

public static TickBar Maximum(this TickBar control, Double value)
   => control._set(() => control.Maximum = value);
public static TickBar Maximum(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.MaximumProperty] = binding);

public static TickBar TickFrequency(this TickBar control, Double value)
   => control._set(() => control.TickFrequency = value);
public static TickBar TickFrequency(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.TickFrequencyProperty] = binding);

public static TickBar Orientation(this TickBar control, Orientation value)
   => control._set(() => control.Orientation = value);
public static TickBar Orientation(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.OrientationProperty] = binding);

public static TickBar Ticks(this TickBar control, AvaloniaList<Double> value)
   => control._set(() => control.Ticks = value);
public static TickBar Ticks(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.TicksProperty] = binding);

public static TickBar IsDirectionReversed(this TickBar control, Boolean value)
   => control._set(() => control.IsDirectionReversed = value);
public static TickBar IsDirectionReversed(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.IsDirectionReversedProperty] = binding);

public static TickBar Placement(this TickBar control, TickBarPlacement value)
   => control._set(() => control.Placement = value);
public static TickBar Placement(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.PlacementProperty] = binding);

public static TickBar ReservedSpace(this TickBar control, Rect value)
   => control._set(() => control.ReservedSpace = value);
public static TickBar ReservedSpace(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.ReservedSpaceProperty] = binding);
public static TickBar ReservedSpace(this TickBar control, Double x, Double y, Double width, Double height)
   => control._set(() => control.ReservedSpace = new Rect(x, y, width, height));
public static TickBar ReservedSpace(this TickBar control, Size size)
   => control._set(() => control.ReservedSpace = new Rect(size));
public static TickBar ReservedSpace(this TickBar control, Point position, Size size)
   => control._set(() => control.ReservedSpace = new Rect(position, size));
public static TickBar ReservedSpace(this TickBar control, Point topLeft, Point bottomRight)
   => control._set(() => control.ReservedSpace = new Rect(topLeft, bottomRight));

public static ToggleSwitch OffContent(this ToggleSwitch control, Object value)
   => control._set(() => control.OffContent = value);
public static ToggleSwitch OffContent(this ToggleSwitch control, IBinding binding)
   => control._set(() => control[!ToggleSwitch.OffContentProperty] = binding);

public static ToggleSwitch OffContentTemplate(this ToggleSwitch control, IDataTemplate value)
   => control._set(() => control.OffContentTemplate = value);
public static ToggleSwitch OffContentTemplate(this ToggleSwitch control, IBinding binding)
   => control._set(() => control[!ToggleSwitch.OffContentTemplateProperty] = binding);

public static ToggleSwitch OnContent(this ToggleSwitch control, Object value)
   => control._set(() => control.OnContent = value);
public static ToggleSwitch OnContent(this ToggleSwitch control, IBinding binding)
   => control._set(() => control[!ToggleSwitch.OnContentProperty] = binding);

public static ToggleSwitch OnContentTemplate(this ToggleSwitch control, IDataTemplate value)
   => control._set(() => control.OnContentTemplate = value);
public static ToggleSwitch OnContentTemplate(this ToggleSwitch control, IBinding binding)
   => control._set(() => control[!ToggleSwitch.OnContentTemplateProperty] = binding);

public static TopLevel TransparencyLevelHint(this TopLevel control, WindowTransparencyLevel value)
   => control._set(() => control.TransparencyLevelHint = value);
public static TopLevel TransparencyLevelHint(this TopLevel control, IBinding binding)
   => control._set(() => control[!TopLevel.TransparencyLevelHintProperty] = binding);

public static TopLevel TransparencyBackgroundFallback(this TopLevel control, IBrush value)
   => control._set(() => control.TransparencyBackgroundFallback = value);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, IBinding binding)
   => control._set(() => control[!TopLevel.TransparencyBackgroundFallbackProperty] = binding);

public static TreeView AutoScrollToSelectedItem(this TreeView control, Boolean value)
   => control._set(() => control.AutoScrollToSelectedItem = value);
public static TreeView AutoScrollToSelectedItem(this TreeView control, IBinding binding)
   => control._set(() => control[!TreeView.AutoScrollToSelectedItemProperty] = binding);

public static TreeView SelectedItem(this TreeView control, Object value)
   => control._set(() => control.SelectedItem = value);
public static TreeView SelectedItem(this TreeView control, IBinding binding)
   => control._set(() => control[!TreeView.SelectedItemProperty] = binding);

public static TreeView SelectedItems(this TreeView control, IList value)
   => control._set(() => control.SelectedItems = value);
public static TreeView SelectedItems(this TreeView control, IBinding binding)
   => control._set(() => control[!TreeView.SelectedItemsProperty] = binding);

public static TreeView SelectionMode(this TreeView control, SelectionMode value)
   => control._set(() => control.SelectionMode = value);
public static TreeView SelectionMode(this TreeView control, IBinding binding)
   => control._set(() => control[!TreeView.SelectionModeProperty] = binding);

public static TreeViewItem IsExpanded(this TreeViewItem control, Boolean value)
   => control._set(() => control.IsExpanded = value);
public static TreeViewItem IsExpanded(this TreeViewItem control, IBinding binding)
   => control._set(() => control[!TreeViewItem.IsExpandedProperty] = binding);

public static TreeViewItem IsSelected(this TreeViewItem control, Boolean value)
   => control._set(() => control.IsSelected = value);
public static TreeViewItem IsSelected(this TreeViewItem control, IBinding binding)
   => control._set(() => control[!TreeViewItem.IsSelectedProperty] = binding);

public static Viewbox Stretch(this Viewbox control, Stretch value)
   => control._set(() => control.Stretch = value);
public static Viewbox Stretch(this Viewbox control, IBinding binding)
   => control._set(() => control[!Viewbox.StretchProperty] = binding);

public static Viewbox StretchDirection(this Viewbox control, StretchDirection value)
   => control._set(() => control.StretchDirection = value);
public static Viewbox StretchDirection(this Viewbox control, IBinding binding)
   => control._set(() => control[!Viewbox.StretchDirectionProperty] = binding);

public static Window SizeToContent(this Window control, SizeToContent value)
   => control._set(() => control.SizeToContent = value);
public static Window SizeToContent(this Window control, IBinding binding)
   => control._set(() => control[!Window.SizeToContentProperty] = binding);

public static Window ExtendClientAreaToDecorationsHint(this Window control, Boolean value)
   => control._set(() => control.ExtendClientAreaToDecorationsHint = value);
public static Window ExtendClientAreaToDecorationsHint(this Window control, IBinding binding)
   => control._set(() => control[!Window.ExtendClientAreaToDecorationsHintProperty] = binding);

public static Window ExtendClientAreaChromeHints(this Window control, ExtendClientAreaChromeHints value)
   => control._set(() => control.ExtendClientAreaChromeHints = value);
public static Window ExtendClientAreaChromeHints(this Window control, IBinding binding)
   => control._set(() => control[!Window.ExtendClientAreaChromeHintsProperty] = binding);

public static Window ExtendClientAreaTitleBarHeightHint(this Window control, Double value)
   => control._set(() => control.ExtendClientAreaTitleBarHeightHint = value);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, IBinding binding)
   => control._set(() => control[!Window.ExtendClientAreaTitleBarHeightHintProperty] = binding);

public static Window SystemDecorations(this Window control, SystemDecorations value)
   => control._set(() => control.SystemDecorations = value);
public static Window SystemDecorations(this Window control, IBinding binding)
   => control._set(() => control[!Window.SystemDecorationsProperty] = binding);

public static Window ShowActivated(this Window control, Boolean value)
   => control._set(() => control.ShowActivated = value);
public static Window ShowActivated(this Window control, IBinding binding)
   => control._set(() => control[!Window.ShowActivatedProperty] = binding);

public static Window ShowInTaskbar(this Window control, Boolean value)
   => control._set(() => control.ShowInTaskbar = value);
public static Window ShowInTaskbar(this Window control, IBinding binding)
   => control._set(() => control[!Window.ShowInTaskbarProperty] = binding);

public static Window WindowState(this Window control, WindowState value)
   => control._set(() => control.WindowState = value);
public static Window WindowState(this Window control, IBinding binding)
   => control._set(() => control[!Window.WindowStateProperty] = binding);

public static Window Title(this Window control, String value)
   => control._set(() => control.Title = value);
public static Window Title(this Window control, IBinding binding)
   => control._set(() => control[!Window.TitleProperty] = binding);

public static Window Icon(this Window control, WindowIcon value)
   => control._set(() => control.Icon = value);
public static Window Icon(this Window control, IBinding binding)
   => control._set(() => control[!Window.IconProperty] = binding);

public static Window WindowStartupLocation(this Window control, WindowStartupLocation value)
   => control._set(() => control.WindowStartupLocation = value);
public static Window WindowStartupLocation(this Window control, IBinding binding)
   => control._set(() => control[!Window.WindowStartupLocationProperty] = binding);

public static Window CanResize(this Window control, Boolean value)
   => control._set(() => control.CanResize = value);
public static Window CanResize(this Window control, IBinding binding)
   => control._set(() => control[!Window.CanResizeProperty] = binding);

public static WindowBase Topmost(this WindowBase control, Boolean value)
   => control._set(() => control.Topmost = value);
public static WindowBase Topmost(this WindowBase control, IBinding binding)
   => control._set(() => control[!WindowBase.TopmostProperty] = binding);

public static WrapPanel Orientation(this WrapPanel control, Orientation value)
   => control._set(() => control.Orientation = value);
public static WrapPanel Orientation(this WrapPanel control, IBinding binding)
   => control._set(() => control[!WrapPanel.OrientationProperty] = binding);

public static WrapPanel ItemWidth(this WrapPanel control, Double value)
   => control._set(() => control.ItemWidth = value);
public static WrapPanel ItemWidth(this WrapPanel control, IBinding binding)
   => control._set(() => control[!WrapPanel.ItemWidthProperty] = binding);

public static WrapPanel ItemHeight(this WrapPanel control, Double value)
   => control._set(() => control.ItemHeight = value);
public static WrapPanel ItemHeight(this WrapPanel control, IBinding binding)
   => control._set(() => control[!WrapPanel.ItemHeightProperty] = binding);

public static Arc StartAngle(this Arc control, Double value)
   => control._set(() => control.StartAngle = value);
public static Arc StartAngle(this Arc control, IBinding binding)
   => control._set(() => control[!Arc.StartAngleProperty] = binding);

public static Arc SweepAngle(this Arc control, Double value)
   => control._set(() => control.SweepAngle = value);
public static Arc SweepAngle(this Arc control, IBinding binding)
   => control._set(() => control[!Arc.SweepAngleProperty] = binding);

public static Line StartPoint(this Line control, Point value)
   => control._set(() => control.StartPoint = value);
public static Line StartPoint(this Line control, IBinding binding)
   => control._set(() => control[!Line.StartPointProperty] = binding);

public static Line EndPoint(this Line control, Point value)
   => control._set(() => control.EndPoint = value);
public static Line EndPoint(this Line control, IBinding binding)
   => control._set(() => control[!Line.EndPointProperty] = binding);

public static Path Data(this Path control, Geometry value)
   => control._set(() => control.Data = value);
public static Path Data(this Path control, IBinding binding)
   => control._set(() => control[!Path.DataProperty] = binding);

public static Polygon Points(this Polygon control, IList<Point> value)
   => control._set(() => control.Points = value);
public static Polygon Points(this Polygon control, IBinding binding)
   => control._set(() => control[!Polygon.PointsProperty] = binding);

public static Polyline Points(this Polyline control, IList<Point> value)
   => control._set(() => control.Points = value);
public static Polyline Points(this Polyline control, IBinding binding)
   => control._set(() => control[!Polyline.PointsProperty] = binding);

public static Shape Fill(this Shape control, IBrush value)
   => control._set(() => control.Fill = value);
public static Shape Fill(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.FillProperty] = binding);

public static Shape Stretch(this Shape control, Stretch value)
   => control._set(() => control.Stretch = value);
public static Shape Stretch(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StretchProperty] = binding);

public static Shape Stroke(this Shape control, IBrush value)
   => control._set(() => control.Stroke = value);
public static Shape Stroke(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeProperty] = binding);

public static Shape StrokeDashArray(this Shape control, AvaloniaList<Double> value)
   => control._set(() => control.StrokeDashArray = value);
public static Shape StrokeDashArray(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeDashArrayProperty] = binding);

public static Shape StrokeDashOffset(this Shape control, Double value)
   => control._set(() => control.StrokeDashOffset = value);
public static Shape StrokeDashOffset(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeDashOffsetProperty] = binding);

public static Shape StrokeThickness(this Shape control, Double value)
   => control._set(() => control.StrokeThickness = value);
public static Shape StrokeThickness(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeThicknessProperty] = binding);

public static Shape StrokeLineCap(this Shape control, PenLineCap value)
   => control._set(() => control.StrokeLineCap = value);
public static Shape StrokeLineCap(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeLineCapProperty] = binding);

public static Shape StrokeJoin(this Shape control, PenLineJoin value)
   => control._set(() => control.StrokeJoin = value);
public static Shape StrokeJoin(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeJoinProperty] = binding);

public static CarouselPresenter IsVirtualized(this CarouselPresenter control, Boolean value)
   => control._set(() => control.IsVirtualized = value);
public static CarouselPresenter IsVirtualized(this CarouselPresenter control, IBinding binding)
   => control._set(() => control[!CarouselPresenter.IsVirtualizedProperty] = binding);

public static CarouselPresenter SelectedIndex(this CarouselPresenter control, Int32 value)
   => control._set(() => control.SelectedIndex = value);
public static CarouselPresenter SelectedIndex(this CarouselPresenter control, IBinding binding)
   => control._set(() => control[!CarouselPresenter.SelectedIndexProperty] = binding);

public static CarouselPresenter PageTransition(this CarouselPresenter control, IPageTransition value)
   => control._set(() => control.PageTransition = value);
public static CarouselPresenter PageTransition(this CarouselPresenter control, IBinding binding)
   => control._set(() => control[!CarouselPresenter.PageTransitionProperty] = binding);

public static ContentPresenter Background(this ContentPresenter control, IBrush value)
   => control._set(() => control.Background = value);
public static ContentPresenter Background(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.BackgroundProperty] = binding);

public static ContentPresenter BorderBrush(this ContentPresenter control, IBrush value)
   => control._set(() => control.BorderBrush = value);
public static ContentPresenter BorderBrush(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.BorderBrushProperty] = binding);

public static ContentPresenter BorderThickness(this ContentPresenter control, Thickness value)
   => control._set(() => control.BorderThickness = value);
public static ContentPresenter BorderThickness(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.BorderThicknessProperty] = binding);
public static ContentPresenter BorderThickness(this ContentPresenter control, Double uniformLength)
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static ContentPresenter BorderThickness(this ContentPresenter control, Double horizontal, Double vertical)
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static ContentPresenter BorderThickness(this ContentPresenter control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));

public static ContentPresenter CornerRadius(this ContentPresenter control, CornerRadius value)
   => control._set(() => control.CornerRadius = value);
public static ContentPresenter CornerRadius(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.CornerRadiusProperty] = binding);
public static ContentPresenter CornerRadius(this ContentPresenter control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static ContentPresenter CornerRadius(this ContentPresenter control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static ContentPresenter CornerRadius(this ContentPresenter control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));

public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadows value)
   => control._set(() => control.BoxShadow = value);
public static ContentPresenter BoxShadow(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.BoxShadowProperty] = binding);
public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadow shadow)
   => control._set(() => control.BoxShadow = new BoxShadows(shadow));
public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadow first, BoxShadow[] rest)
   => control._set(() => control.BoxShadow = new BoxShadows(first, rest));

public static ContentPresenter Content(this ContentPresenter control, Object value)
   => control._set(() => control.Content = value);
public static ContentPresenter Content(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.ContentProperty] = binding);

public static ContentPresenter ContentTemplate(this ContentPresenter control, IDataTemplate value)
   => control._set(() => control.ContentTemplate = value);
public static ContentPresenter ContentTemplate(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.ContentTemplateProperty] = binding);

public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, HorizontalAlignment value)
   => control._set(() => control.HorizontalContentAlignment = value);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.HorizontalContentAlignmentProperty] = binding);

public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, VerticalAlignment value)
   => control._set(() => control.VerticalContentAlignment = value);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.VerticalContentAlignmentProperty] = binding);

public static ContentPresenter Padding(this ContentPresenter control, Thickness value)
   => control._set(() => control.Padding = value);
public static ContentPresenter Padding(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.PaddingProperty] = binding);
public static ContentPresenter Padding(this ContentPresenter control, Double uniformLength)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static ContentPresenter Padding(this ContentPresenter control, Double horizontal, Double vertical)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static ContentPresenter Padding(this ContentPresenter control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));

public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, Boolean value)
   => control._set(() => control.RecognizesAccessKey = value);
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.RecognizesAccessKeyProperty] = binding);

public static ItemsPresenter VirtualizationMode(this ItemsPresenter control, ItemVirtualizationMode value)
   => control._set(() => control.VirtualizationMode = value);
public static ItemsPresenter VirtualizationMode(this ItemsPresenter control, IBinding binding)
   => control._set(() => control[!ItemsPresenter.VirtualizationModeProperty] = binding);

public static ItemsPresenterBase Items(this ItemsPresenterBase control, IEnumerable value)
   => control._set(() => control.Items = value);
public static ItemsPresenterBase Items(this ItemsPresenterBase control, IBinding binding)
   => control._set(() => control[!ItemsPresenterBase.ItemsProperty] = binding);

public static ItemsPresenterBase ItemsPanel(this ItemsPresenterBase control, ITemplate<IPanel> value)
   => control._set(() => control.ItemsPanel = value);
public static ItemsPresenterBase ItemsPanel(this ItemsPresenterBase control, IBinding binding)
   => control._set(() => control[!ItemsPresenterBase.ItemsPanelProperty] = binding);

public static ItemsPresenterBase ItemTemplate(this ItemsPresenterBase control, IDataTemplate value)
   => control._set(() => control.ItemTemplate = value);
public static ItemsPresenterBase ItemTemplate(this ItemsPresenterBase control, IBinding binding)
   => control._set(() => control[!ItemsPresenterBase.ItemTemplateProperty] = binding);

public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, Boolean value)
   => control._set(() => control.CanHorizontallyScroll = value);
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, IBinding binding)
   => control._set(() => control[!ScrollContentPresenter.CanHorizontallyScrollProperty] = binding);

public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, Boolean value)
   => control._set(() => control.CanVerticallyScroll = value);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, IBinding binding)
   => control._set(() => control[!ScrollContentPresenter.CanVerticallyScrollProperty] = binding);

public static ScrollContentPresenter Offset(this ScrollContentPresenter control, Vector value)
   => control._set(() => control.Offset = value);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, IBinding binding)
   => control._set(() => control[!ScrollContentPresenter.OffsetProperty] = binding);

public static TextPresenter CaretIndex(this TextPresenter control, Int32 value)
   => control._set(() => control.CaretIndex = value);
public static TextPresenter CaretIndex(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.CaretIndexProperty] = binding);

public static TextPresenter RevealPassword(this TextPresenter control, Boolean value)
   => control._set(() => control.RevealPassword = value);
public static TextPresenter RevealPassword(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.RevealPasswordProperty] = binding);

public static TextPresenter PasswordChar(this TextPresenter control, Char value)
   => control._set(() => control.PasswordChar = value);
public static TextPresenter PasswordChar(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.PasswordCharProperty] = binding);

public static TextPresenter SelectionBrush(this TextPresenter control, IBrush value)
   => control._set(() => control.SelectionBrush = value);
public static TextPresenter SelectionBrush(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.SelectionBrushProperty] = binding);

public static TextPresenter SelectionForegroundBrush(this TextPresenter control, IBrush value)
   => control._set(() => control.SelectionForegroundBrush = value);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.SelectionForegroundBrushProperty] = binding);

public static TextPresenter CaretBrush(this TextPresenter control, IBrush value)
   => control._set(() => control.CaretBrush = value);
public static TextPresenter CaretBrush(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.CaretBrushProperty] = binding);

public static TextPresenter SelectionStart(this TextPresenter control, Int32 value)
   => control._set(() => control.SelectionStart = value);
public static TextPresenter SelectionStart(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.SelectionStartProperty] = binding);

public static TextPresenter SelectionEnd(this TextPresenter control, Int32 value)
   => control._set(() => control.SelectionEnd = value);
public static TextPresenter SelectionEnd(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.SelectionEndProperty] = binding);

public static TextPresenter Text(this TextPresenter control, String value)
   => control._set(() => control.Text = value);
public static TextPresenter Text(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.TextProperty] = binding);

public static TextPresenter TextAlignment(this TextPresenter control, TextAlignment value)
   => control._set(() => control.TextAlignment = value);
public static TextPresenter TextAlignment(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.TextAlignmentProperty] = binding);

public static TextPresenter TextWrapping(this TextPresenter control, TextWrapping value)
   => control._set(() => control.TextWrapping = value);
public static TextPresenter TextWrapping(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.TextWrappingProperty] = binding);

public static TextPresenter Background(this TextPresenter control, IBrush value)
   => control._set(() => control.Background = value);
public static TextPresenter Background(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.BackgroundProperty] = binding);

public static NotificationCard IsClosed(this NotificationCard control, Boolean value)
   => control._set(() => control.IsClosed = value);
public static NotificationCard IsClosed(this NotificationCard control, IBinding binding)
   => control._set(() => control[!NotificationCard.IsClosedProperty] = binding);

public static WindowNotificationManager Position(this WindowNotificationManager control, NotificationPosition value)
   => control._set(() => control.Position = value);
public static WindowNotificationManager Position(this WindowNotificationManager control, IBinding binding)
   => control._set(() => control[!WindowNotificationManager.PositionProperty] = binding);

public static WindowNotificationManager MaxItems(this WindowNotificationManager control, Int32 value)
   => control._set(() => control.MaxItems = value);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, IBinding binding)
   => control._set(() => control[!WindowNotificationManager.MaxItemsProperty] = binding);

public static CalendarItem HeaderBackground(this CalendarItem control, IBrush value)
   => control._set(() => control.HeaderBackground = value);
public static CalendarItem HeaderBackground(this CalendarItem control, IBinding binding)
   => control._set(() => control[!CalendarItem.HeaderBackgroundProperty] = binding);

public static CalendarItem DayTitleTemplate(this CalendarItem control, ITemplate<IControl> value)
   => control._set(() => control.DayTitleTemplate = value);
public static CalendarItem DayTitleTemplate(this CalendarItem control, IBinding binding)
   => control._set(() => control[!CalendarItem.DayTitleTemplateProperty] = binding);

public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, Double value)
   => control._set(() => control.ItemHeight = value);
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, IBinding binding)
   => control._set(() => control[!DateTimePickerPanel.ItemHeightProperty] = binding);

public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, DateTimePickerPanelType value)
   => control._set(() => control.PanelType = value);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, IBinding binding)
   => control._set(() => control[!DateTimePickerPanel.PanelTypeProperty] = binding);

public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, String value)
   => control._set(() => control.ItemFormat = value);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, IBinding binding)
   => control._set(() => control[!DateTimePickerPanel.ItemFormatProperty] = binding);

public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, Boolean value)
   => control._set(() => control.ShouldLoop = value);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, IBinding binding)
   => control._set(() => control[!DateTimePickerPanel.ShouldLoopProperty] = binding);

public static AccessText ShowAccessKey(this AccessText control, Boolean value)
   => control._set(() => control.ShowAccessKey = value);
public static AccessText ShowAccessKey(this AccessText control, IBinding binding)
   => control._set(() => control[!AccessText.ShowAccessKeyProperty] = binding);

public static HeaderedContentControl Header(this HeaderedContentControl control, Object value)
   => control._set(() => control.Header = value);
public static HeaderedContentControl Header(this HeaderedContentControl control, IBinding binding)
   => control._set(() => control[!HeaderedContentControl.HeaderProperty] = binding);

public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, IDataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, IBinding binding)
   => control._set(() => control[!HeaderedContentControl.HeaderTemplateProperty] = binding);

public static HeaderedItemsControl Header(this HeaderedItemsControl control, Object value)
   => control._set(() => control.Header = value);
public static HeaderedItemsControl Header(this HeaderedItemsControl control, IBinding binding)
   => control._set(() => control[!HeaderedItemsControl.HeaderProperty] = binding);

public static HeaderedSelectingItemsControl Header(this HeaderedSelectingItemsControl control, Object value)
   => control._set(() => control.Header = value);
public static HeaderedSelectingItemsControl Header(this HeaderedSelectingItemsControl control, IBinding binding)
   => control._set(() => control[!HeaderedSelectingItemsControl.HeaderProperty] = binding);

public static Popup WindowManagerAddShadowHint(this Popup control, Boolean value)
   => control._set(() => control.WindowManagerAddShadowHint = value);
public static Popup WindowManagerAddShadowHint(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.WindowManagerAddShadowHintProperty] = binding);

public static Popup Child(this Popup control, Control value)
   => control._set(() => control.Child = value);
public static Popup Child(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.ChildProperty] = binding);

public static Popup IsOpen(this Popup control, Boolean value)
   => control._set(() => control.IsOpen = value);
public static Popup IsOpen(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.IsOpenProperty] = binding);

public static Popup PlacementAnchor(this Popup control, PopupAnchor value)
   => control._set(() => control.PlacementAnchor = value);
public static Popup PlacementAnchor(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementAnchorProperty] = binding);

public static Popup PlacementConstraintAdjustment(this Popup control, PopupPositionerConstraintAdjustment value)
   => control._set(() => control.PlacementConstraintAdjustment = value);
public static Popup PlacementConstraintAdjustment(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementConstraintAdjustmentProperty] = binding);

public static Popup PlacementGravity(this Popup control, PopupGravity value)
   => control._set(() => control.PlacementGravity = value);
public static Popup PlacementGravity(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementGravityProperty] = binding);

public static Popup PlacementMode(this Popup control, PlacementMode value)
   => control._set(() => control.PlacementMode = value);
public static Popup PlacementMode(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementModeProperty] = binding);

public static Popup PlacementRect(this Popup control, Nullable<Rect> value)
   => control._set(() => control.PlacementRect = value);
public static Popup PlacementRect(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementRectProperty] = binding);

public static Popup PlacementTarget(this Popup control, Control value)
   => control._set(() => control.PlacementTarget = value);
public static Popup PlacementTarget(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementTargetProperty] = binding);

public static Popup ObeyScreenEdges(this Popup control, Boolean value)
   => control._set(() => control.ObeyScreenEdges = value);
public static Popup ObeyScreenEdges(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.ObeyScreenEdgesProperty] = binding);

public static Popup OverlayDismissEventPassThrough(this Popup control, Boolean value)
   => control._set(() => control.OverlayDismissEventPassThrough = value);
public static Popup OverlayDismissEventPassThrough(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.OverlayDismissEventPassThroughProperty] = binding);

public static Popup OverlayInputPassThroughElement(this Popup control, IInputElement value)
   => control._set(() => control.OverlayInputPassThroughElement = value);
public static Popup OverlayInputPassThroughElement(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.OverlayInputPassThroughElementProperty] = binding);

public static Popup HorizontalOffset(this Popup control, Double value)
   => control._set(() => control.HorizontalOffset = value);
public static Popup HorizontalOffset(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.HorizontalOffsetProperty] = binding);

public static Popup IsLightDismissEnabled(this Popup control, Boolean value)
   => control._set(() => control.IsLightDismissEnabled = value);
public static Popup IsLightDismissEnabled(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.IsLightDismissEnabledProperty] = binding);

public static Popup VerticalOffset(this Popup control, Double value)
   => control._set(() => control.VerticalOffset = value);
public static Popup VerticalOffset(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.VerticalOffsetProperty] = binding);

public static Popup Topmost(this Popup control, Boolean value)
   => control._set(() => control.Topmost = value);
public static Popup Topmost(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.TopmostProperty] = binding);

public static RangeBase Minimum(this RangeBase control, Double value)
   => control._set(() => control.Minimum = value);
public static RangeBase Minimum(this RangeBase control, IBinding binding)
   => control._set(() => control[!RangeBase.MinimumProperty] = binding);

public static RangeBase Maximum(this RangeBase control, Double value)
   => control._set(() => control.Maximum = value);
public static RangeBase Maximum(this RangeBase control, IBinding binding)
   => control._set(() => control[!RangeBase.MaximumProperty] = binding);

public static RangeBase Value(this RangeBase control, Double value)
   => control._set(() => control.Value = value);
public static RangeBase Value(this RangeBase control, IBinding binding)
   => control._set(() => control[!RangeBase.ValueProperty] = binding);

public static RangeBase SmallChange(this RangeBase control, Double value)
   => control._set(() => control.SmallChange = value);
public static RangeBase SmallChange(this RangeBase control, IBinding binding)
   => control._set(() => control[!RangeBase.SmallChangeProperty] = binding);

public static RangeBase LargeChange(this RangeBase control, Double value)
   => control._set(() => control.LargeChange = value);
public static RangeBase LargeChange(this RangeBase control, IBinding binding)
   => control._set(() => control[!RangeBase.LargeChangeProperty] = binding);

public static ScrollBar ViewportSize(this ScrollBar control, Double value)
   => control._set(() => control.ViewportSize = value);
public static ScrollBar ViewportSize(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.ViewportSizeProperty] = binding);

public static ScrollBar Visibility(this ScrollBar control, ScrollBarVisibility value)
   => control._set(() => control.Visibility = value);
public static ScrollBar Visibility(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.VisibilityProperty] = binding);

public static ScrollBar Orientation(this ScrollBar control, Orientation value)
   => control._set(() => control.Orientation = value);
public static ScrollBar Orientation(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.OrientationProperty] = binding);

public static ScrollBar AllowAutoHide(this ScrollBar control, Boolean value)
   => control._set(() => control.AllowAutoHide = value);
public static ScrollBar AllowAutoHide(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.AllowAutoHideProperty] = binding);

public static ScrollBar HideDelay(this ScrollBar control, TimeSpan value)
   => control._set(() => control.HideDelay = value);
public static ScrollBar HideDelay(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.HideDelayProperty] = binding);

public static ScrollBar ShowDelay(this ScrollBar control, TimeSpan value)
   => control._set(() => control.ShowDelay = value);
public static ScrollBar ShowDelay(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.ShowDelayProperty] = binding);

public static SelectingItemsControl AutoScrollToSelectedItem(this SelectingItemsControl control, Boolean value)
   => control._set(() => control.AutoScrollToSelectedItem = value);
public static SelectingItemsControl AutoScrollToSelectedItem(this SelectingItemsControl control, IBinding binding)
   => control._set(() => control[!SelectingItemsControl.AutoScrollToSelectedItemProperty] = binding);

public static SelectingItemsControl SelectedIndex(this SelectingItemsControl control, Int32 value)
   => control._set(() => control.SelectedIndex = value);
public static SelectingItemsControl SelectedIndex(this SelectingItemsControl control, IBinding binding)
   => control._set(() => control[!SelectingItemsControl.SelectedIndexProperty] = binding);

public static SelectingItemsControl SelectedItem(this SelectingItemsControl control, Object value)
   => control._set(() => control.SelectedItem = value);
public static SelectingItemsControl SelectedItem(this SelectingItemsControl control, IBinding binding)
   => control._set(() => control[!SelectingItemsControl.SelectedItemProperty] = binding);

public static SelectingItemsControl IsTextSearchEnabled(this SelectingItemsControl control, Boolean value)
   => control._set(() => control.IsTextSearchEnabled = value);
public static SelectingItemsControl IsTextSearchEnabled(this SelectingItemsControl control, IBinding binding)
   => control._set(() => control[!SelectingItemsControl.IsTextSearchEnabledProperty] = binding);

public static T Background<T>(this T control, IBrush value) where T : TemplatedControl
   => control._set(() => control.Background = value);
public static T Background<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.BackgroundProperty] = binding);

public static T BorderBrush<T>(this T control, IBrush value) where T : TemplatedControl
   => control._set(() => control.BorderBrush = value);
public static T BorderBrush<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.BorderBrushProperty] = binding);

public static T BorderThickness<T>(this T control, Thickness value) where T : TemplatedControl
   => control._set(() => control.BorderThickness = value);
public static T BorderThickness<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.BorderThicknessProperty] = binding);
public static T BorderThickness<T>(this T control, Double uniformLength) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static T BorderThickness<T>(this T control, Double horizontal, Double vertical) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, Double left, Double top, Double right, Double bottom) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));

public static T CornerRadius<T>(this T control, CornerRadius value) where T : TemplatedControl
   => control._set(() => control.CornerRadius = value);
public static T CornerRadius<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.CornerRadiusProperty] = binding);
public static T CornerRadius<T>(this T control, Double uniformRadius) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, Double top, Double bottom) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));

public static T FontFamily<T>(this T control, FontFamily value) where T : TemplatedControl
   => control._set(() => control.FontFamily = value);
public static T FontFamily<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.FontFamilyProperty] = binding);

public static T FontSize<T>(this T control, Double value) where T : TemplatedControl
   => control._set(() => control.FontSize = value);
public static T FontSize<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.FontSizeProperty] = binding);

public static T FontStyle<T>(this T control, FontStyle value) where T : TemplatedControl
   => control._set(() => control.FontStyle = value);
public static T FontStyle<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.FontStyleProperty] = binding);

public static T FontWeight<T>(this T control, FontWeight value) where T : TemplatedControl
   => control._set(() => control.FontWeight = value);
public static T FontWeight<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.FontWeightProperty] = binding);

public static T Foreground<T>(this T control, IBrush value) where T : TemplatedControl
   => control._set(() => control.Foreground = value);
public static T Foreground<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.ForegroundProperty] = binding);

public static T Padding<T>(this T control, Thickness value) where T : TemplatedControl
   => control._set(() => control.Padding = value);
public static T Padding<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.PaddingProperty] = binding);
public static T Padding<T>(this T control, Double uniformLength) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static T Padding<T>(this T control, Double horizontal, Double vertical) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static T Padding<T>(this T control, Double left, Double top, Double right, Double bottom) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));

public static T Template<T>(this T control, IControlTemplate value) where T : TemplatedControl
   => control._set(() => control.Template = value);
public static T Template<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.TemplateProperty] = binding);

public static ToggleButton IsChecked(this ToggleButton control, Nullable<Boolean> value)
   => control._set(() => control.IsChecked = value);
public static ToggleButton IsChecked(this ToggleButton control, IBinding binding)
   => control._set(() => control[!ToggleButton.IsCheckedProperty] = binding);

public static ToggleButton IsThreeState(this ToggleButton control, Boolean value)
   => control._set(() => control.IsThreeState = value);
public static ToggleButton IsThreeState(this ToggleButton control, IBinding binding)
   => control._set(() => control[!ToggleButton.IsThreeStateProperty] = binding);

public static Track Minimum(this Track control, Double value)
   => control._set(() => control.Minimum = value);
public static Track Minimum(this Track control, IBinding binding)
   => control._set(() => control[!Track.MinimumProperty] = binding);

public static Track Maximum(this Track control, Double value)
   => control._set(() => control.Maximum = value);
public static Track Maximum(this Track control, IBinding binding)
   => control._set(() => control[!Track.MaximumProperty] = binding);

public static Track Value(this Track control, Double value)
   => control._set(() => control.Value = value);
public static Track Value(this Track control, IBinding binding)
   => control._set(() => control[!Track.ValueProperty] = binding);

public static Track ViewportSize(this Track control, Double value)
   => control._set(() => control.ViewportSize = value);
public static Track ViewportSize(this Track control, IBinding binding)
   => control._set(() => control[!Track.ViewportSizeProperty] = binding);

public static Track Orientation(this Track control, Orientation value)
   => control._set(() => control.Orientation = value);
public static Track Orientation(this Track control, IBinding binding)
   => control._set(() => control[!Track.OrientationProperty] = binding);

public static Track Thumb(this Track control, Thumb value)
   => control._set(() => control.Thumb = value);
public static Track Thumb(this Track control, IBinding binding)
   => control._set(() => control[!Track.ThumbProperty] = binding);

public static Track IncreaseButton(this Track control, Button value)
   => control._set(() => control.IncreaseButton = value);
public static Track IncreaseButton(this Track control, IBinding binding)
   => control._set(() => control[!Track.IncreaseButtonProperty] = binding);

public static Track DecreaseButton(this Track control, Button value)
   => control._set(() => control.DecreaseButton = value);
public static Track DecreaseButton(this Track control, IBinding binding)
   => control._set(() => control[!Track.DecreaseButtonProperty] = binding);

public static Track IsDirectionReversed(this Track control, Boolean value)
   => control._set(() => control.IsDirectionReversed = value);
public static Track IsDirectionReversed(this Track control, IBinding binding)
   => control._set(() => control[!Track.IsDirectionReversedProperty] = binding);

public static UniformGrid Rows(this UniformGrid control, Int32 value)
   => control._set(() => control.Rows = value);
public static UniformGrid Rows(this UniformGrid control, IBinding binding)
   => control._set(() => control[!UniformGrid.RowsProperty] = binding);

public static UniformGrid Columns(this UniformGrid control, Int32 value)
   => control._set(() => control.Columns = value);
public static UniformGrid Columns(this UniformGrid control, IBinding binding)
   => control._set(() => control[!UniformGrid.ColumnsProperty] = binding);

public static UniformGrid FirstColumn(this UniformGrid control, Int32 value)
   => control._set(() => control.FirstColumn = value);
public static UniformGrid FirstColumn(this UniformGrid control, IBinding binding)
   => control._set(() => control[!UniformGrid.FirstColumnProperty] = binding);

public static T Width<T>(this T control, Double value) where T : Layoutable
   => control._set(() => control.Width = value);
public static T Width<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.WidthProperty] = binding);

public static T Height<T>(this T control, Double value) where T : Layoutable
   => control._set(() => control.Height = value);
public static T Height<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.HeightProperty] = binding);

public static T MinWidth<T>(this T control, Double value) where T : Layoutable
   => control._set(() => control.MinWidth = value);
public static T MinWidth<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.MinWidthProperty] = binding);

public static T MaxWidth<T>(this T control, Double value) where T : Layoutable
   => control._set(() => control.MaxWidth = value);
public static T MaxWidth<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.MaxWidthProperty] = binding);

public static T MinHeight<T>(this T control, Double value) where T : Layoutable
   => control._set(() => control.MinHeight = value);
public static T MinHeight<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.MinHeightProperty] = binding);

public static T MaxHeight<T>(this T control, Double value) where T : Layoutable
   => control._set(() => control.MaxHeight = value);
public static T MaxHeight<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.MaxHeightProperty] = binding);

public static T Margin<T>(this T control, Thickness value) where T : Layoutable
   => control._set(() => control.Margin = value);
public static T Margin<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.MarginProperty] = binding);
public static T Margin<T>(this T control, Double uniformLength) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(uniformLength));
public static T Margin<T>(this T control, Double horizontal, Double vertical) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(horizontal, vertical));
public static T Margin<T>(this T control, Double left, Double top, Double right, Double bottom) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(left, top, right, bottom));

public static T HorizontalAlignment<T>(this T control, HorizontalAlignment value) where T : Layoutable
   => control._set(() => control.HorizontalAlignment = value);
public static T HorizontalAlignment<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.HorizontalAlignmentProperty] = binding);

public static T VerticalAlignment<T>(this T control, VerticalAlignment value) where T : Layoutable
   => control._set(() => control.VerticalAlignment = value);
public static T VerticalAlignment<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.VerticalAlignmentProperty] = binding);

public static T UseLayoutRounding<T>(this T control, Boolean value) where T : Layoutable
   => control._set(() => control.UseLayoutRounding = value);
public static T UseLayoutRounding<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.UseLayoutRoundingProperty] = binding);

public static T ClipToBounds<T>(this T control, Boolean value) where T : Visual
   => control._set(() => control.ClipToBounds = value);
public static T ClipToBounds<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.ClipToBoundsProperty] = binding);

public static T Clip<T>(this T control, Geometry value) where T : Visual
   => control._set(() => control.Clip = value);
public static T Clip<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.ClipProperty] = binding);

public static T IsVisible<T>(this T control, Boolean value) where T : Visual
   => control._set(() => control.IsVisible = value);
public static T IsVisible<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.IsVisibleProperty] = binding);

public static T Opacity<T>(this T control, Double value) where T : Visual
   => control._set(() => control.Opacity = value);
public static T Opacity<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.OpacityProperty] = binding);

public static T OpacityMask<T>(this T control, IBrush value) where T : Visual
   => control._set(() => control.OpacityMask = value);
public static T OpacityMask<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.OpacityMaskProperty] = binding);

public static T RenderTransform<T>(this T control, ITransform value) where T : Visual
   => control._set(() => control.RenderTransform = value);
public static T RenderTransform<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.RenderTransformProperty] = binding);

public static T RenderTransformOrigin<T>(this T control, RelativePoint value) where T : Visual
   => control._set(() => control.RenderTransformOrigin = value);
public static T RenderTransformOrigin<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.RenderTransformOriginProperty] = binding);
public static T RenderTransformOrigin<T>(this T control, Double x, Double y, RelativeUnit unit) where T : Visual
   => control._set(() => control.RenderTransformOrigin = new RelativePoint(x, y, unit));
public static T RenderTransformOrigin<T>(this T control, Point point, RelativeUnit unit) where T : Visual
   => control._set(() => control.RenderTransformOrigin = new RelativePoint(point, unit));

public static T ZIndex<T>(this T control, Int32 value) where T : Visual
   => control._set(() => control.ZIndex = value);
public static T ZIndex<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.ZIndexProperty] = binding);

public static T Focusable<T>(this T control, Boolean value) where T : InputElement
   => control._set(() => control.Focusable = value);
public static T Focusable<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.FocusableProperty] = binding);

public static T IsEnabled<T>(this T control, Boolean value) where T : InputElement
   => control._set(() => control.IsEnabled = value);
public static T IsEnabled<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.IsEnabledProperty] = binding);

public static T Cursor<T>(this T control, Cursor value) where T : InputElement
   => control._set(() => control.Cursor = value);
public static T Cursor<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.CursorProperty] = binding);

public static T IsHitTestVisible<T>(this T control, Boolean value) where T : InputElement
   => control._set(() => control.IsHitTestVisible = value);
public static T IsHitTestVisible<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.IsHitTestVisibleProperty] = binding);

public static T IsTabStop<T>(this T control, Boolean value) where T : InputElement
   => control._set(() => control.IsTabStop = value);
public static T IsTabStop<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.IsTabStopProperty] = binding);

public static T TabIndex<T>(this T control, Int32 value) where T : InputElement
   => control._set(() => control.TabIndex = value);
public static T TabIndex<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.TabIndexProperty] = binding);

private static TControl _set<TControl>(this TControl control, Action setAction)
{
    setAction();
    return control;
}
public static Brush ToBrush(this Color color) => new SolidColorBrush(color);

}
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
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class ControlExtensions
{
public static AutoCompleteBox Watermark(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.WatermarkProperty] = binding);
public static AutoCompleteBox Watermark(this AutoCompleteBox control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.WatermarkProperty, ps, () => control.Watermark = value);
public static AutoCompleteBox MinimumPrefixLength(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.MinimumPrefixLengthProperty] = binding);
public static AutoCompleteBox MinimumPrefixLength(this AutoCompleteBox control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.MinimumPrefixLengthProperty, ps, () => control.MinimumPrefixLength = value);
public static AutoCompleteBox MinimumPopulateDelay(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.MinimumPopulateDelayProperty] = binding);
public static AutoCompleteBox MinimumPopulateDelay(this AutoCompleteBox control, TimeSpan value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.MinimumPopulateDelayProperty, ps, () => control.MinimumPopulateDelay = value);
public static AutoCompleteBox MaxDropDownHeight(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.MaxDropDownHeightProperty] = binding);
public static AutoCompleteBox MaxDropDownHeight(this AutoCompleteBox control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value);
public static AutoCompleteBox IsTextCompletionEnabled(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.IsTextCompletionEnabledProperty] = binding);
public static AutoCompleteBox IsTextCompletionEnabled(this AutoCompleteBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.IsTextCompletionEnabledProperty, ps, () => control.IsTextCompletionEnabled = value);
public static AutoCompleteBox ItemTemplate(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.ItemTemplateProperty] = binding);
public static AutoCompleteBox ItemTemplate(this AutoCompleteBox control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.ItemTemplateProperty, ps, () => control.ItemTemplate = value);
public static AutoCompleteBox IsDropDownOpen(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.IsDropDownOpenProperty] = binding);
public static AutoCompleteBox IsDropDownOpen(this AutoCompleteBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value);
public static AutoCompleteBox SelectedItem(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.SelectedItemProperty] = binding);
public static AutoCompleteBox SelectedItem(this AutoCompleteBox control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.SelectedItemProperty, ps, () => control.SelectedItem = value);
public static AutoCompleteBox Text(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.TextProperty] = binding);
public static AutoCompleteBox Text(this AutoCompleteBox control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.TextProperty, ps, () => control.Text = value);
public static AutoCompleteBox FilterMode(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.FilterModeProperty] = binding);
public static AutoCompleteBox FilterMode(this AutoCompleteBox control, AutoCompleteFilterMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.FilterModeProperty, ps, () => control.FilterMode = value);
public static AutoCompleteBox ItemFilter(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.ItemFilterProperty] = binding);
public static AutoCompleteBox ItemFilter(this AutoCompleteBox control, AutoCompleteFilterPredicate<Object> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.ItemFilterProperty, ps, () => control.ItemFilter = value);
public static AutoCompleteBox TextFilter(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.TextFilterProperty] = binding);
public static AutoCompleteBox TextFilter(this AutoCompleteBox control, AutoCompleteFilterPredicate<String> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.TextFilterProperty, ps, () => control.TextFilter = value);
public static AutoCompleteBox ItemSelector(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.ItemSelectorProperty] = binding);
public static AutoCompleteBox ItemSelector(this AutoCompleteBox control, AutoCompleteSelector<Object> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.ItemSelectorProperty, ps, () => control.ItemSelector = value);
public static AutoCompleteBox TextSelector(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.TextSelectorProperty] = binding);
public static AutoCompleteBox TextSelector(this AutoCompleteBox control, AutoCompleteSelector<String> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.TextSelectorProperty, ps, () => control.TextSelector = value);
public static AutoCompleteBox Items(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.ItemsProperty] = binding);
public static AutoCompleteBox Items(this AutoCompleteBox control, IEnumerable value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.ItemsProperty, ps, () => control.Items = value);
public static AutoCompleteBox AsyncPopulator(this AutoCompleteBox control, IBinding binding)
   => control._set(() => control[!AutoCompleteBox.AsyncPopulatorProperty] = binding);
public static AutoCompleteBox AsyncPopulator(this AutoCompleteBox control, Func<String,CancellationToken,Task<IEnumerable<Object>>> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AutoCompleteBox.AsyncPopulatorProperty, ps, () => control.AsyncPopulator = value);
public static Border Background(this Border control, IBinding binding)
   => control._set(() => control[!Border.BackgroundProperty] = binding);
public static Border Background(this Border control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Border.BackgroundProperty, ps, () => control.Background = value);
public static Border BorderBrush(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderBrushProperty] = binding);
public static Border BorderBrush(this Border control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Border.BorderBrushProperty, ps, () => control.BorderBrush = value);
public static Border BorderThickness(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderThicknessProperty] = binding);
public static Border BorderThickness(this Border control, Thickness value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Border.BorderThicknessProperty, ps, () => control.BorderThickness = value);

public static Border BorderThickness(this Border control, Double uniformLength)
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static Border BorderThickness(this Border control, Double horizontal, Double vertical)
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static Border BorderThickness(this Border control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));
public static Border CornerRadius(this Border control, IBinding binding)
   => control._set(() => control[!Border.CornerRadiusProperty] = binding);
public static Border CornerRadius(this Border control, CornerRadius value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Border.CornerRadiusProperty, ps, () => control.CornerRadius = value);

public static Border CornerRadius(this Border control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static Border CornerRadius(this Border control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static Border CornerRadius(this Border control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Border BoxShadow(this Border control, IBinding binding)
   => control._set(() => control[!Border.BoxShadowProperty] = binding);
public static Border BoxShadow(this Border control, BoxShadows value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Border.BoxShadowProperty, ps, () => control.BoxShadow = value);

public static Border BoxShadow(this Border control, BoxShadow shadow)
   => control._set(() => control.BoxShadow = new BoxShadows(shadow));
public static Border BoxShadow(this Border control, BoxShadow first, BoxShadow[] rest)
   => control._set(() => control.BoxShadow = new BoxShadows(first, rest));
public static Border BorderDashOffset(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderDashOffsetProperty] = binding);
public static Border BorderDashOffset(this Border control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Border.BorderDashOffsetProperty, ps, () => control.BorderDashOffset = value);
public static Border BorderDashArray(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderDashArrayProperty] = binding);
public static Border BorderDashArray(this Border control, AvaloniaList<Double> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Border.BorderDashArrayProperty, ps, () => control.BorderDashArray = value);
public static Border BorderLineCap(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderLineCapProperty] = binding);
public static Border BorderLineCap(this Border control, PenLineCap value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Border.BorderLineCapProperty, ps, () => control.BorderLineCap = value);
public static Border BorderLineJoin(this Border control, IBinding binding)
   => control._set(() => control[!Border.BorderLineJoinProperty] = binding);
public static Border BorderLineJoin(this Border control, PenLineJoin value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Border.BorderLineJoinProperty, ps, () => control.BorderLineJoin = value);
public static Button ClickMode(this Button control, IBinding binding)
   => control._set(() => control[!Button.ClickModeProperty] = binding);
public static Button ClickMode(this Button control, ClickMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Button.ClickModeProperty, ps, () => control.ClickMode = value);
public static Button Command(this Button control, IBinding binding)
   => control._set(() => control[!Button.CommandProperty] = binding);
public static Button Command(this Button control, ICommand value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Button.CommandProperty, ps, () => control.Command = value);
public static Button HotKey(this Button control, IBinding binding)
   => control._set(() => control[!Button.HotKeyProperty] = binding);
public static Button HotKey(this Button control, KeyGesture value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Button.HotKeyProperty, ps, () => control.HotKey = value);
public static Button CommandParameter(this Button control, IBinding binding)
   => control._set(() => control[!Button.CommandParameterProperty] = binding);
public static Button CommandParameter(this Button control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Button.CommandParameterProperty, ps, () => control.CommandParameter = value);
public static Button IsDefault(this Button control, IBinding binding)
   => control._set(() => control[!Button.IsDefaultProperty] = binding);
public static Button IsDefault(this Button control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Button.IsDefaultProperty, ps, () => control.IsDefault = value);
public static Button IsCancel(this Button control, IBinding binding)
   => control._set(() => control[!Button.IsCancelProperty] = binding);
public static Button IsCancel(this Button control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Button.IsCancelProperty, ps, () => control.IsCancel = value);
public static Button Flyout(this Button control, IBinding binding)
   => control._set(() => control[!Button.FlyoutProperty] = binding);
public static Button Flyout(this Button control, FlyoutBase value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Button.FlyoutProperty, ps, () => control.Flyout = value);
public static ButtonSpinner AllowSpin(this ButtonSpinner control, IBinding binding)
   => control._set(() => control[!ButtonSpinner.AllowSpinProperty] = binding);
public static ButtonSpinner AllowSpin(this ButtonSpinner control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ButtonSpinner.AllowSpinProperty, ps, () => control.AllowSpin = value);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, IBinding binding)
   => control._set(() => control[!ButtonSpinner.ShowButtonSpinnerProperty] = binding);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ButtonSpinner.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = value);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, IBinding binding)
   => control._set(() => control[!ButtonSpinner.ButtonSpinnerLocationProperty] = binding);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, Location value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ButtonSpinner.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = value);
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = binding);
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, DayOfWeek value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.IsTodayHighlightedProperty] = binding);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.HeaderBackgroundProperty] = binding);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.DisplayModeProperty] = binding);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, CalendarMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.Calendar.DisplayModeProperty, ps, () => control.DisplayMode = value);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.SelectionModeProperty] = binding);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, CalendarSelectionMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.Calendar.SelectionModeProperty, ps, () => control.SelectionMode = value);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.SelectedDateProperty] = binding);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, Nullable<DateTime> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.Calendar.SelectedDateProperty, ps, () => control.SelectedDate = value);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.DisplayDateProperty] = binding);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, DateTime value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateProperty, ps, () => control.DisplayDate = value);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.DisplayDateStartProperty] = binding);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, Nullable<DateTime> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.Calendar.DisplayDateEndProperty] = binding);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, Nullable<DateTime> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value);
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.DisplayDateProperty] = binding);
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, DateTime value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = value);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.DisplayDateStartProperty] = binding);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, Nullable<DateTime> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.DisplayDateEndProperty] = binding);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, Nullable<DateTime> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.FirstDayOfWeekProperty] = binding);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, DayOfWeek value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.IsDropDownOpenProperty] = binding);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.IsTodayHighlightedProperty] = binding);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.SelectedDateProperty] = binding);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, Nullable<DateTime> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.SelectedDateFormatProperty] = binding);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, CalendarDatePickerFormat value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = value);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.CustomDateFormatStringProperty] = binding);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = value);
public static CalendarDatePicker Text(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.TextProperty] = binding);
public static CalendarDatePicker Text(this CalendarDatePicker control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.TextProperty, ps, () => control.Text = value);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.WatermarkProperty] = binding);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = value);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.UseFloatingWatermarkProperty] = binding);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.HorizontalContentAlignmentProperty] = binding);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, HorizontalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, IBinding binding)
   => control._set(() => control[!CalendarDatePicker.VerticalContentAlignmentProperty] = binding);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, VerticalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value);
public static Carousel IsVirtualized(this Carousel control, IBinding binding)
   => control._set(() => control[!Carousel.IsVirtualizedProperty] = binding);
public static Carousel IsVirtualized(this Carousel control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Carousel.IsVirtualizedProperty, ps, () => control.IsVirtualized = value);
public static Carousel PageTransition(this Carousel control, IBinding binding)
   => control._set(() => control[!Carousel.PageTransitionProperty] = binding);
public static Carousel PageTransition(this Carousel control, IPageTransition value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Carousel.PageTransitionProperty, ps, () => control.PageTransition = value);
public static ComboBox IsDropDownOpen(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.IsDropDownOpenProperty] = binding);
public static ComboBox IsDropDownOpen(this ComboBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value);
public static ComboBox MaxDropDownHeight(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.MaxDropDownHeightProperty] = binding);
public static ComboBox MaxDropDownHeight(this ComboBox control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value);
public static ComboBox VirtualizationMode(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.VirtualizationModeProperty] = binding);
public static ComboBox VirtualizationMode(this ComboBox control, ItemVirtualizationMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ComboBox.VirtualizationModeProperty, ps, () => control.VirtualizationMode = value);
public static ComboBox PlaceholderText(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.PlaceholderTextProperty] = binding);
public static ComboBox PlaceholderText(this ComboBox control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ComboBox.PlaceholderTextProperty, ps, () => control.PlaceholderText = value);
public static ComboBox PlaceholderForeground(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.PlaceholderForegroundProperty] = binding);
public static ComboBox PlaceholderForeground(this ComboBox control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ComboBox.PlaceholderForegroundProperty, ps, () => control.PlaceholderForeground = value);
public static ComboBox HorizontalContentAlignment(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.HorizontalContentAlignmentProperty] = binding);
public static ComboBox HorizontalContentAlignment(this ComboBox control, HorizontalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value);
public static ComboBox VerticalContentAlignment(this ComboBox control, IBinding binding)
   => control._set(() => control[!ComboBox.VerticalContentAlignmentProperty] = binding);
public static ComboBox VerticalContentAlignment(this ComboBox control, VerticalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value);
public static T Content<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(() => control[!ContentControl.ContentProperty] = binding);
public static T Content<T>(this T control, Object value, [CallerArgumentExpression("value")] string ps = null) where T : ContentControl
=> control._setEx(ContentControl.ContentProperty, ps, () => control.Content = value);
public static T ContentTemplate<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(() => control[!ContentControl.ContentTemplateProperty] = binding);
public static T ContentTemplate<T>(this T control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null) where T : ContentControl
=> control._setEx(ContentControl.ContentTemplateProperty, ps, () => control.ContentTemplate = value);
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(() => control[!ContentControl.HorizontalContentAlignmentProperty] = binding);
public static T HorizontalContentAlignment<T>(this T control, HorizontalAlignment value, [CallerArgumentExpression("value")] string ps = null) where T : ContentControl
=> control._setEx(ContentControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value);
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(() => control[!ContentControl.VerticalContentAlignmentProperty] = binding);
public static T VerticalContentAlignment<T>(this T control, VerticalAlignment value, [CallerArgumentExpression("value")] string ps = null) where T : ContentControl
=> control._setEx(ContentControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value);
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.HorizontalOffsetProperty] = binding);
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.VerticalOffsetProperty] = binding);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, ps, () => control.VerticalOffset = value);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementAnchorProperty] = binding);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, PopupAnchor value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty] = binding);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, PopupPositionerConstraintAdjustment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementGravityProperty] = binding);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, PopupGravity value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementGravityProperty, ps, () => control.PlacementGravity = value);
public static Avalonia.Controls.ContextMenu PlacementMode(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementModeProperty] = binding);
public static Avalonia.Controls.ContextMenu PlacementMode(this Avalonia.Controls.ContextMenu control, PlacementMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementModeProperty, ps, () => control.PlacementMode = value);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementRectProperty] = binding);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, Nullable<Rect> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementRectProperty, ps, () => control.PlacementRect = value);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty] = binding);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(() => control[!Avalonia.Controls.ContextMenu.PlacementTargetProperty] = binding);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, Control value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementTargetProperty, ps, () => control.PlacementTarget = value);
public static Control FocusAdorner(this Control control, IBinding binding)
   => control._set(() => control[!Control.FocusAdornerProperty] = binding);
public static Control FocusAdorner(this Control control, ITemplate<IControl> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Control.FocusAdornerProperty, ps, () => control.FocusAdorner = value);
public static Control Tag(this Control control, IBinding binding)
   => control._set(() => control[!Control.TagProperty] = binding);
public static Control Tag(this Control control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Control.TagProperty, ps, () => control.Tag = value);
public static Control ContextMenu(this Control control, IBinding binding)
   => control._set(() => control[!Control.ContextMenuProperty] = binding);
public static Control ContextMenu(this Control control, Avalonia.Controls.ContextMenu value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Control.ContextMenuProperty, ps, () => control.ContextMenu = value);
public static Control ContextFlyout(this Control control, IBinding binding)
   => control._set(() => control[!Control.ContextFlyoutProperty] = binding);
public static Control ContextFlyout(this Control control, FlyoutBase value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Control.ContextFlyoutProperty, ps, () => control.ContextFlyout = value);
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, IBinding binding)
   => control._set(() => control[!DataValidationErrors.ErrorTemplateProperty] = binding);
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = value);
public static DataValidationErrors Owner(this DataValidationErrors control, IBinding binding)
   => control._set(() => control[!DataValidationErrors.OwnerProperty] = binding);
public static DataValidationErrors Owner(this DataValidationErrors control, Control value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DataValidationErrors.OwnerProperty, ps, () => control.Owner = value);
public static DatePicker DayFormat(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.DayFormatProperty] = binding);
public static DatePicker DayFormat(this DatePicker control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.DayFormatProperty, ps, () => control.DayFormat = value);
public static DatePicker DayVisible(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.DayVisibleProperty] = binding);
public static DatePicker DayVisible(this DatePicker control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.DayVisibleProperty, ps, () => control.DayVisible = value);
public static DatePicker Header(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.HeaderProperty] = binding);
public static DatePicker Header(this DatePicker control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.HeaderProperty, ps, () => control.Header = value);
public static DatePicker HeaderTemplate(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.HeaderTemplateProperty] = binding);
public static DatePicker HeaderTemplate(this DatePicker control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value);
public static DatePicker MaxYear(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.MaxYearProperty] = binding);
public static DatePicker MaxYear(this DatePicker control, DateTimeOffset value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.MaxYearProperty, ps, () => control.MaxYear = value);
public static DatePicker MinYear(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.MinYearProperty] = binding);
public static DatePicker MinYear(this DatePicker control, DateTimeOffset value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.MinYearProperty, ps, () => control.MinYear = value);
public static DatePicker MonthFormat(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.MonthFormatProperty] = binding);
public static DatePicker MonthFormat(this DatePicker control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = value);
public static DatePicker MonthVisible(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.MonthVisibleProperty] = binding);
public static DatePicker MonthVisible(this DatePicker control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = value);
public static DatePicker YearFormat(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.YearFormatProperty] = binding);
public static DatePicker YearFormat(this DatePicker control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.YearFormatProperty, ps, () => control.YearFormat = value);
public static DatePicker YearVisible(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.YearVisibleProperty] = binding);
public static DatePicker YearVisible(this DatePicker control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.YearVisibleProperty, ps, () => control.YearVisible = value);
public static DatePicker SelectedDate(this DatePicker control, IBinding binding)
   => control._set(() => control[!DatePicker.SelectedDateProperty] = binding);
public static DatePicker SelectedDate(this DatePicker control, Nullable<DateTimeOffset> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value);
public static DatePickerPresenter Date(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.DateProperty] = binding);
public static DatePickerPresenter Date(this DatePickerPresenter control, DateTimeOffset value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePickerPresenter.DateProperty, ps, () => control.Date = value);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.DayFormatProperty] = binding);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = value);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.DayVisibleProperty] = binding);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = value);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.MaxYearProperty] = binding);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, DateTimeOffset value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = value);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.MinYearProperty] = binding);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, DateTimeOffset value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = value);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.MonthFormatProperty] = binding);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = value);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.MonthVisibleProperty] = binding);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = value);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.YearFormatProperty] = binding);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = value);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(() => control[!DatePickerPresenter.YearVisibleProperty] = binding);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = value);
public static TimePicker MinuteIncrement(this TimePicker control, IBinding binding)
   => control._set(() => control[!TimePicker.MinuteIncrementProperty] = binding);
public static TimePicker MinuteIncrement(this TimePicker control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value);
public static TimePicker Header(this TimePicker control, IBinding binding)
   => control._set(() => control[!TimePicker.HeaderProperty] = binding);
public static TimePicker Header(this TimePicker control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TimePicker.HeaderProperty, ps, () => control.Header = value);
public static TimePicker HeaderTemplate(this TimePicker control, IBinding binding)
   => control._set(() => control[!TimePicker.HeaderTemplateProperty] = binding);
public static TimePicker HeaderTemplate(this TimePicker control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TimePicker.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value);
public static TimePicker ClockIdentifier(this TimePicker control, IBinding binding)
   => control._set(() => control[!TimePicker.ClockIdentifierProperty] = binding);
public static TimePicker ClockIdentifier(this TimePicker control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value);
public static TimePicker SelectedTime(this TimePicker control, IBinding binding)
   => control._set(() => control[!TimePicker.SelectedTimeProperty] = binding);
public static TimePicker SelectedTime(this TimePicker control, Nullable<TimeSpan> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = value);
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, IBinding binding)
   => control._set(() => control[!TimePickerPresenter.MinuteIncrementProperty] = binding);
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, IBinding binding)
   => control._set(() => control[!TimePickerPresenter.ClockIdentifierProperty] = binding);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TimePickerPresenter.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value);
public static TimePickerPresenter Time(this TimePickerPresenter control, IBinding binding)
   => control._set(() => control[!TimePickerPresenter.TimeProperty] = binding);
public static TimePickerPresenter Time(this TimePickerPresenter control, TimeSpan value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TimePickerPresenter.TimeProperty, ps, () => control.Time = value);
public static Decorator Child(this Decorator control, IBinding binding)
   => control._set(() => control[!Decorator.ChildProperty] = binding);
public static Decorator Child(this Decorator control, IControl value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Decorator.ChildProperty, ps, () => control.Child = value);
public static Decorator Padding(this Decorator control, IBinding binding)
   => control._set(() => control[!Decorator.PaddingProperty] = binding);
public static Decorator Padding(this Decorator control, Thickness value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Decorator.PaddingProperty, ps, () => control.Padding = value);

public static Decorator Padding(this Decorator control, Double uniformLength)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static Decorator Padding(this Decorator control, Double horizontal, Double vertical)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static Decorator Padding(this Decorator control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static DockPanel LastChildFill(this DockPanel control, IBinding binding)
   => control._set(() => control[!DockPanel.LastChildFillProperty] = binding);
public static DockPanel LastChildFill(this DockPanel control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DockPanel.LastChildFillProperty, ps, () => control.LastChildFill = value);
public static Expander ContentTransition(this Expander control, IBinding binding)
   => control._set(() => control[!Expander.ContentTransitionProperty] = binding);
public static Expander ContentTransition(this Expander control, IPageTransition value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Expander.ContentTransitionProperty, ps, () => control.ContentTransition = value);
public static Expander ExpandDirection(this Expander control, IBinding binding)
   => control._set(() => control[!Expander.ExpandDirectionProperty] = binding);
public static Expander ExpandDirection(this Expander control, ExpandDirection value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = value);
public static Expander IsExpanded(this Expander control, IBinding binding)
   => control._set(() => control[!Expander.IsExpandedProperty] = binding);
public static Expander IsExpanded(this Expander control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Expander.IsExpandedProperty, ps, () => control.IsExpanded = value);
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, IBinding binding)
   => control._set(() => control[!ExperimentalAcrylicBorder.CornerRadiusProperty] = binding);
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, CornerRadius value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ExperimentalAcrylicBorder.CornerRadiusProperty, ps, () => control.CornerRadius = value);

public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, IBinding binding)
   => control._set(() => control[!ExperimentalAcrylicBorder.MaterialProperty] = binding);
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, ExperimentalAcrylicMaterial value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ExperimentalAcrylicBorder.MaterialProperty, ps, () => control.Material = value);
public static MenuFlyoutPresenter CornerRadius(this MenuFlyoutPresenter control, IBinding binding)
   => control._set(() => control[!MenuFlyoutPresenter.CornerRadiusProperty] = binding);
public static MenuFlyoutPresenter CornerRadius(this MenuFlyoutPresenter control, CornerRadius value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MenuFlyoutPresenter.CornerRadiusProperty, ps, () => control.CornerRadius = value);

public static MenuFlyoutPresenter CornerRadius(this MenuFlyoutPresenter control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static MenuFlyoutPresenter CornerRadius(this MenuFlyoutPresenter control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static MenuFlyoutPresenter CornerRadius(this MenuFlyoutPresenter control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Grid ShowGridLines(this Grid control, IBinding binding)
   => control._set(() => control[!Grid.ShowGridLinesProperty] = binding);
public static Grid ShowGridLines(this Grid control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = value);
public static GridSplitter ResizeDirection(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.ResizeDirectionProperty] = binding);
public static GridSplitter ResizeDirection(this GridSplitter control, GridResizeDirection value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(GridSplitter.ResizeDirectionProperty, ps, () => control.ResizeDirection = value);
public static GridSplitter ResizeBehavior(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.ResizeBehaviorProperty] = binding);
public static GridSplitter ResizeBehavior(this GridSplitter control, GridResizeBehavior value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(GridSplitter.ResizeBehaviorProperty, ps, () => control.ResizeBehavior = value);
public static GridSplitter ShowsPreview(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.ShowsPreviewProperty] = binding);
public static GridSplitter ShowsPreview(this GridSplitter control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(GridSplitter.ShowsPreviewProperty, ps, () => control.ShowsPreview = value);
public static GridSplitter KeyboardIncrement(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.KeyboardIncrementProperty] = binding);
public static GridSplitter KeyboardIncrement(this GridSplitter control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(GridSplitter.KeyboardIncrementProperty, ps, () => control.KeyboardIncrement = value);
public static GridSplitter DragIncrement(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.DragIncrementProperty] = binding);
public static GridSplitter DragIncrement(this GridSplitter control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(GridSplitter.DragIncrementProperty, ps, () => control.DragIncrement = value);
public static GridSplitter PreviewContent(this GridSplitter control, IBinding binding)
   => control._set(() => control[!GridSplitter.PreviewContentProperty] = binding);
public static GridSplitter PreviewContent(this GridSplitter control, ITemplate<IControl> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(GridSplitter.PreviewContentProperty, ps, () => control.PreviewContent = value);
public static Image Source(this Image control, IBinding binding)
   => control._set(() => control[!Image.SourceProperty] = binding);
public static Image Source(this Image control, IImage value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Image.SourceProperty, ps, () => control.Source = value);
public static Image Stretch(this Image control, IBinding binding)
   => control._set(() => control[!Image.StretchProperty] = binding);
public static Image Stretch(this Image control, Stretch value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Image.StretchProperty, ps, () => control.Stretch = value);
public static Image StretchDirection(this Image control, IBinding binding)
   => control._set(() => control[!Image.StretchDirectionProperty] = binding);
public static Image StretchDirection(this Image control, StretchDirection value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Image.StretchDirectionProperty, ps, () => control.StretchDirection = value);
public static T Items<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(() => control[!ItemsControl.ItemsProperty] = binding);
public static T Items<T>(this T control, IEnumerable value, [CallerArgumentExpression("value")] string ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemsProperty, ps, () => control.Items = value);
public static T ItemsPanel<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(() => control[!ItemsControl.ItemsPanelProperty] = binding);
public static T ItemsPanel<T>(this T control, ITemplate<IPanel> value, [CallerArgumentExpression("value")] string ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemsPanelProperty, ps, () => control.ItemsPanel = value);
public static T ItemTemplate<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(() => control[!ItemsControl.ItemTemplateProperty] = binding);
public static T ItemTemplate<T>(this T control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemTemplateProperty, ps, () => control.ItemTemplate = value);
public static Label Target(this Label control, IBinding binding)
   => control._set(() => control[!Label.TargetProperty] = binding);
public static Label Target(this Label control, IInputElement value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Label.TargetProperty, ps, () => control.Target = value);
public static LayoutTransformControl LayoutTransform(this LayoutTransformControl control, IBinding binding)
   => control._set(() => control[!LayoutTransformControl.LayoutTransformProperty] = binding);
public static LayoutTransformControl LayoutTransform(this LayoutTransformControl control, ITransform value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(LayoutTransformControl.LayoutTransformProperty, ps, () => control.LayoutTransform = value);
public static LayoutTransformControl UseRenderTransform(this LayoutTransformControl control, IBinding binding)
   => control._set(() => control[!LayoutTransformControl.UseRenderTransformProperty] = binding);
public static LayoutTransformControl UseRenderTransform(this LayoutTransformControl control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(LayoutTransformControl.UseRenderTransformProperty, ps, () => control.UseRenderTransform = value);
public static ListBox SelectedItems(this ListBox control, IBinding binding)
   => control._set(() => control[!ListBox.SelectedItemsProperty] = binding);
public static ListBox SelectedItems(this ListBox control, IList value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = value);
public static ListBox Selection(this ListBox control, IBinding binding)
   => control._set(() => control[!ListBox.SelectionProperty] = binding);
public static ListBox Selection(this ListBox control, ISelectionModel value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ListBox.SelectionProperty, ps, () => control.Selection = value);
public static ListBox SelectionMode(this ListBox control, IBinding binding)
   => control._set(() => control[!ListBox.SelectionModeProperty] = binding);
public static ListBox SelectionMode(this ListBox control, SelectionMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ListBox.SelectionModeProperty, ps, () => control.SelectionMode = value);
public static ListBox VirtualizationMode(this ListBox control, IBinding binding)
   => control._set(() => control[!ListBox.VirtualizationModeProperty] = binding);
public static ListBox VirtualizationMode(this ListBox control, ItemVirtualizationMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ListBox.VirtualizationModeProperty, ps, () => control.VirtualizationMode = value);
public static ListBoxItem IsSelected(this ListBoxItem control, IBinding binding)
   => control._set(() => control[!ListBoxItem.IsSelectedProperty] = binding);
public static ListBoxItem IsSelected(this ListBoxItem control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ListBoxItem.IsSelectedProperty, ps, () => control.IsSelected = value);
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.AsciiOnlyProperty] = binding);
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = value);
public static MaskedTextBox Culture(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.CultureProperty] = binding);
public static MaskedTextBox Culture(this MaskedTextBox control, CultureInfo value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MaskedTextBox.CultureProperty, ps, () => control.Culture = value);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.HidePromptOnLeaveProperty] = binding);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = value);
public static MaskedTextBox Mask(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.MaskProperty] = binding);
public static MaskedTextBox Mask(this MaskedTextBox control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MaskedTextBox.MaskProperty, ps, () => control.Mask = value);
public static MaskedTextBox PasswordChar(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.PasswordCharProperty] = binding);
public static MaskedTextBox PasswordChar(this MaskedTextBox control, Char value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MaskedTextBox.PasswordCharProperty, ps, () => control.PasswordChar = value);
public static MaskedTextBox PromptChar(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.PromptCharProperty] = binding);
public static MaskedTextBox PromptChar(this MaskedTextBox control, Char value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = value);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.ResetOnPromptProperty] = binding);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = value);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, IBinding binding)
   => control._set(() => control[!MaskedTextBox.ResetOnSpaceProperty] = binding);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = value);
public static MenuItem Command(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.CommandProperty] = binding);
public static MenuItem Command(this MenuItem control, ICommand value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MenuItem.CommandProperty, ps, () => control.Command = value);
public static MenuItem HotKey(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.HotKeyProperty] = binding);
public static MenuItem HotKey(this MenuItem control, KeyGesture value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MenuItem.HotKeyProperty, ps, () => control.HotKey = value);
public static MenuItem CommandParameter(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.CommandParameterProperty] = binding);
public static MenuItem CommandParameter(this MenuItem control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value);
public static MenuItem Icon(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.IconProperty] = binding);
public static MenuItem Icon(this MenuItem control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MenuItem.IconProperty, ps, () => control.Icon = value);
public static MenuItem InputGesture(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.InputGestureProperty] = binding);
public static MenuItem InputGesture(this MenuItem control, KeyGesture value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MenuItem.InputGestureProperty, ps, () => control.InputGesture = value);
public static MenuItem IsSelected(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.IsSelectedProperty] = binding);
public static MenuItem IsSelected(this MenuItem control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MenuItem.IsSelectedProperty, ps, () => control.IsSelected = value);
public static MenuItem IsSubMenuOpen(this MenuItem control, IBinding binding)
   => control._set(() => control[!MenuItem.IsSubMenuOpenProperty] = binding);
public static MenuItem IsSubMenuOpen(this MenuItem control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = value);
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, IBinding binding)
   => control._set(() => control[!ReversibleStackPanel.ReverseOrderProperty] = binding);
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ReversibleStackPanel.ReverseOrderProperty, ps, () => control.ReverseOrder = value);
public static NumericUpDown AllowSpin(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.AllowSpinProperty] = binding);
public static NumericUpDown AllowSpin(this NumericUpDown control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.AllowSpinProperty, ps, () => control.AllowSpin = value);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.ButtonSpinnerLocationProperty] = binding);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, Location value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = value);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.ShowButtonSpinnerProperty] = binding);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = value);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.ClipValueToMinMaxProperty] = binding);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.ClipValueToMinMaxProperty, ps, () => control.ClipValueToMinMax = value);
public static NumericUpDown CultureInfo(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.CultureInfoProperty] = binding);
public static NumericUpDown CultureInfo(this NumericUpDown control, CultureInfo value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.CultureInfoProperty, ps, () => control.CultureInfo = value);
public static NumericUpDown FormatString(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.FormatStringProperty] = binding);
public static NumericUpDown FormatString(this NumericUpDown control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.FormatStringProperty, ps, () => control.FormatString = value);
public static NumericUpDown Increment(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.IncrementProperty] = binding);
public static NumericUpDown Increment(this NumericUpDown control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.IncrementProperty, ps, () => control.Increment = value);
public static NumericUpDown IsReadOnly(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.IsReadOnlyProperty] = binding);
public static NumericUpDown IsReadOnly(this NumericUpDown control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.IsReadOnlyProperty, ps, () => control.IsReadOnly = value);
public static NumericUpDown Maximum(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.MaximumProperty] = binding);
public static NumericUpDown Maximum(this NumericUpDown control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.MaximumProperty, ps, () => control.Maximum = value);
public static NumericUpDown Minimum(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.MinimumProperty] = binding);
public static NumericUpDown Minimum(this NumericUpDown control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.MinimumProperty, ps, () => control.Minimum = value);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.ParsingNumberStyleProperty] = binding);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, NumberStyles value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.ParsingNumberStyleProperty, ps, () => control.ParsingNumberStyle = value);
public static NumericUpDown Text(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.TextProperty] = binding);
public static NumericUpDown Text(this NumericUpDown control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.TextProperty, ps, () => control.Text = value);
public static NumericUpDown Value(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.ValueProperty] = binding);
public static NumericUpDown Value(this NumericUpDown control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.ValueProperty, ps, () => control.Value = value);
public static NumericUpDown Watermark(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.WatermarkProperty] = binding);
public static NumericUpDown Watermark(this NumericUpDown control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.WatermarkProperty, ps, () => control.Watermark = value);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.HorizontalContentAlignmentProperty] = binding);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, HorizontalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, IBinding binding)
   => control._set(() => control[!NumericUpDown.VerticalContentAlignmentProperty] = binding);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, VerticalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NumericUpDown.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value);
public static Panel Background(this Panel control, IBinding binding)
   => control._set(() => control[!Panel.BackgroundProperty] = binding);
public static Panel Background(this Panel control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Panel.BackgroundProperty, ps, () => control.Background = value);
public static PathIcon Data(this PathIcon control, IBinding binding)
   => control._set(() => control[!PathIcon.DataProperty] = binding);
public static PathIcon Data(this PathIcon control, Geometry value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(PathIcon.DataProperty, ps, () => control.Data = value);
public static ProgressBar IsIndeterminate(this ProgressBar control, IBinding binding)
   => control._set(() => control[!ProgressBar.IsIndeterminateProperty] = binding);
public static ProgressBar IsIndeterminate(this ProgressBar control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = value);
public static ProgressBar ShowProgressText(this ProgressBar control, IBinding binding)
   => control._set(() => control[!ProgressBar.ShowProgressTextProperty] = binding);
public static ProgressBar ShowProgressText(this ProgressBar control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ProgressBar.ShowProgressTextProperty, ps, () => control.ShowProgressText = value);
public static ProgressBar Orientation(this ProgressBar control, IBinding binding)
   => control._set(() => control[!ProgressBar.OrientationProperty] = binding);
public static ProgressBar Orientation(this ProgressBar control, Orientation value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ProgressBar.OrientationProperty, ps, () => control.Orientation = value);
public static RadioButton GroupName(this RadioButton control, IBinding binding)
   => control._set(() => control[!RadioButton.GroupNameProperty] = binding);
public static RadioButton GroupName(this RadioButton control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(RadioButton.GroupNameProperty, ps, () => control.GroupName = value);
public static RepeatButton Interval(this RepeatButton control, IBinding binding)
   => control._set(() => control[!RepeatButton.IntervalProperty] = binding);
public static RepeatButton Interval(this RepeatButton control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(RepeatButton.IntervalProperty, ps, () => control.Interval = value);
public static RepeatButton Delay(this RepeatButton control, IBinding binding)
   => control._set(() => control[!RepeatButton.DelayProperty] = binding);
public static RepeatButton Delay(this RepeatButton control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(RepeatButton.DelayProperty, ps, () => control.Delay = value);
public static ItemsRepeater HorizontalCacheLength(this ItemsRepeater control, IBinding binding)
   => control._set(() => control[!ItemsRepeater.HorizontalCacheLengthProperty] = binding);
public static ItemsRepeater HorizontalCacheLength(this ItemsRepeater control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ItemsRepeater.HorizontalCacheLengthProperty, ps, () => control.HorizontalCacheLength = value);
public static ItemsRepeater ItemTemplate(this ItemsRepeater control, IBinding binding)
   => control._set(() => control[!ItemsRepeater.ItemTemplateProperty] = binding);
public static ItemsRepeater ItemTemplate(this ItemsRepeater control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ItemsRepeater.ItemTemplateProperty, ps, () => control.ItemTemplate = value);
public static ItemsRepeater Items(this ItemsRepeater control, IBinding binding)
   => control._set(() => control[!ItemsRepeater.ItemsProperty] = binding);
public static ItemsRepeater Items(this ItemsRepeater control, IEnumerable value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ItemsRepeater.ItemsProperty, ps, () => control.Items = value);
public static ItemsRepeater Layout(this ItemsRepeater control, IBinding binding)
   => control._set(() => control[!ItemsRepeater.LayoutProperty] = binding);
public static ItemsRepeater Layout(this ItemsRepeater control, AttachedLayout value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ItemsRepeater.LayoutProperty, ps, () => control.Layout = value);
public static ItemsRepeater VerticalCacheLength(this ItemsRepeater control, IBinding binding)
   => control._set(() => control[!ItemsRepeater.VerticalCacheLengthProperty] = binding);
public static ItemsRepeater VerticalCacheLength(this ItemsRepeater control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ItemsRepeater.VerticalCacheLengthProperty, ps, () => control.VerticalCacheLength = value);
public static ScrollViewer Offset(this ScrollViewer control, IBinding binding)
   => control._set(() => control[!ScrollViewer.OffsetProperty] = binding);
public static ScrollViewer Offset(this ScrollViewer control, Vector value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollViewer.OffsetProperty, ps, () => control.Offset = value);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, IBinding binding)
   => control._set(() => control[!ScrollViewer.HorizontalScrollBarVisibilityProperty] = binding);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, ScrollBarVisibility value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = value);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, IBinding binding)
   => control._set(() => control[!ScrollViewer.VerticalScrollBarVisibilityProperty] = binding);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, ScrollBarVisibility value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = value);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, IBinding binding)
   => control._set(() => control[!ScrollViewer.AllowAutoHideProperty] = binding);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value);
public static Slider Orientation(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.OrientationProperty] = binding);
public static Slider Orientation(this Slider control, Orientation value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Slider.OrientationProperty, ps, () => control.Orientation = value);
public static Slider IsDirectionReversed(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.IsDirectionReversedProperty] = binding);
public static Slider IsDirectionReversed(this Slider control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Slider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value);
public static Slider IsSnapToTickEnabled(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.IsSnapToTickEnabledProperty] = binding);
public static Slider IsSnapToTickEnabled(this Slider control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Slider.IsSnapToTickEnabledProperty, ps, () => control.IsSnapToTickEnabled = value);
public static Slider TickFrequency(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.TickFrequencyProperty] = binding);
public static Slider TickFrequency(this Slider control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Slider.TickFrequencyProperty, ps, () => control.TickFrequency = value);
public static Slider TickPlacement(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.TickPlacementProperty] = binding);
public static Slider TickPlacement(this Slider control, TickPlacement value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Slider.TickPlacementProperty, ps, () => control.TickPlacement = value);
public static Slider Ticks(this Slider control, IBinding binding)
   => control._set(() => control[!Slider.TicksProperty] = binding);
public static Slider Ticks(this Slider control, AvaloniaList<Double> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Slider.TicksProperty, ps, () => control.Ticks = value);
public static Spinner ValidSpinDirection(this Spinner control, IBinding binding)
   => control._set(() => control[!Spinner.ValidSpinDirectionProperty] = binding);
public static Spinner ValidSpinDirection(this Spinner control, ValidSpinDirections value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Spinner.ValidSpinDirectionProperty, ps, () => control.ValidSpinDirection = value);
public static SplitView CompactPaneLength(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.CompactPaneLengthProperty] = binding);
public static SplitView CompactPaneLength(this SplitView control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = value);
public static SplitView DisplayMode(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.DisplayModeProperty] = binding);
public static SplitView DisplayMode(this SplitView control, SplitViewDisplayMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SplitView.DisplayModeProperty, ps, () => control.DisplayMode = value);
public static SplitView IsPaneOpen(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.IsPaneOpenProperty] = binding);
public static SplitView IsPaneOpen(this SplitView control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = value);
public static SplitView OpenPaneLength(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.OpenPaneLengthProperty] = binding);
public static SplitView OpenPaneLength(this SplitView control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = value);
public static SplitView PaneBackground(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.PaneBackgroundProperty] = binding);
public static SplitView PaneBackground(this SplitView control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = value);
public static SplitView PanePlacement(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.PanePlacementProperty] = binding);
public static SplitView PanePlacement(this SplitView control, SplitViewPanePlacement value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SplitView.PanePlacementProperty, ps, () => control.PanePlacement = value);
public static SplitView Pane(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.PaneProperty] = binding);
public static SplitView Pane(this SplitView control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SplitView.PaneProperty, ps, () => control.Pane = value);
public static SplitView PaneTemplate(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.PaneTemplateProperty] = binding);
public static SplitView PaneTemplate(this SplitView control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = value);
public static SplitView UseLightDismissOverlayMode(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.UseLightDismissOverlayModeProperty] = binding);
public static SplitView UseLightDismissOverlayMode(this SplitView control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = value);
public static SplitView TemplateSettings(this SplitView control, IBinding binding)
   => control._set(() => control[!SplitView.TemplateSettingsProperty] = binding);
public static SplitView TemplateSettings(this SplitView control, SplitViewTemplateSettings value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SplitView.TemplateSettingsProperty, ps, () => control.TemplateSettings = value);
public static StackPanel Spacing(this StackPanel control, IBinding binding)
   => control._set(() => control[!StackPanel.SpacingProperty] = binding);
public static StackPanel Spacing(this StackPanel control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(StackPanel.SpacingProperty, ps, () => control.Spacing = value);
public static StackPanel Orientation(this StackPanel control, IBinding binding)
   => control._set(() => control[!StackPanel.OrientationProperty] = binding);
public static StackPanel Orientation(this StackPanel control, Orientation value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(StackPanel.OrientationProperty, ps, () => control.Orientation = value);
public static TabControl TabStripPlacement(this TabControl control, IBinding binding)
   => control._set(() => control[!TabControl.TabStripPlacementProperty] = binding);
public static TabControl TabStripPlacement(this TabControl control, Dock value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TabControl.TabStripPlacementProperty, ps, () => control.TabStripPlacement = value);
public static TabControl HorizontalContentAlignment(this TabControl control, IBinding binding)
   => control._set(() => control[!TabControl.HorizontalContentAlignmentProperty] = binding);
public static TabControl HorizontalContentAlignment(this TabControl control, HorizontalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TabControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value);
public static TabControl VerticalContentAlignment(this TabControl control, IBinding binding)
   => control._set(() => control[!TabControl.VerticalContentAlignmentProperty] = binding);
public static TabControl VerticalContentAlignment(this TabControl control, VerticalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TabControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value);
public static TabControl ContentTemplate(this TabControl control, IBinding binding)
   => control._set(() => control[!TabControl.ContentTemplateProperty] = binding);
public static TabControl ContentTemplate(this TabControl control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TabControl.ContentTemplateProperty, ps, () => control.ContentTemplate = value);
public static TabItem IsSelected(this TabItem control, IBinding binding)
   => control._set(() => control[!TabItem.IsSelectedProperty] = binding);
public static TabItem IsSelected(this TabItem control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TabItem.IsSelectedProperty, ps, () => control.IsSelected = value);
public static TextBlock Background(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.BackgroundProperty] = binding);
public static TextBlock Background(this TextBlock control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.BackgroundProperty, ps, () => control.Background = value);
public static TextBlock Padding(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.PaddingProperty] = binding);
public static TextBlock Padding(this TextBlock control, Thickness value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.PaddingProperty, ps, () => control.Padding = value);

public static TextBlock Padding(this TextBlock control, Double uniformLength)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static TextBlock Padding(this TextBlock control, Double horizontal, Double vertical)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static TextBlock Padding(this TextBlock control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static TextBlock FontFamily(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.FontFamilyProperty] = binding);
public static TextBlock FontFamily(this TextBlock control, FontFamily value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.FontFamilyProperty, ps, () => control.FontFamily = value);
public static TextBlock FontSize(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.FontSizeProperty] = binding);
public static TextBlock FontSize(this TextBlock control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.FontSizeProperty, ps, () => control.FontSize = value);
public static TextBlock FontStyle(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.FontStyleProperty] = binding);
public static TextBlock FontStyle(this TextBlock control, FontStyle value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.FontStyleProperty, ps, () => control.FontStyle = value);
public static TextBlock FontWeight(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.FontWeightProperty] = binding);
public static TextBlock FontWeight(this TextBlock control, FontWeight value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.FontWeightProperty, ps, () => control.FontWeight = value);
public static TextBlock Foreground(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.ForegroundProperty] = binding);
public static TextBlock Foreground(this TextBlock control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.ForegroundProperty, ps, () => control.Foreground = value);
public static TextBlock LineHeight(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.LineHeightProperty] = binding);
public static TextBlock LineHeight(this TextBlock control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.LineHeightProperty, ps, () => control.LineHeight = value);
public static TextBlock MaxLines(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.MaxLinesProperty] = binding);
public static TextBlock MaxLines(this TextBlock control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.MaxLinesProperty, ps, () => control.MaxLines = value);
public static TextBlock Text(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.TextProperty] = binding);
public static TextBlock Text(this TextBlock control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.TextProperty, ps, () => control.Text = value);
public static TextBlock TextAlignment(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.TextAlignmentProperty] = binding);
public static TextBlock TextAlignment(this TextBlock control, TextAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.TextAlignmentProperty, ps, () => control.TextAlignment = value);
public static TextBlock TextWrapping(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.TextWrappingProperty] = binding);
public static TextBlock TextWrapping(this TextBlock control, TextWrapping value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.TextWrappingProperty, ps, () => control.TextWrapping = value);
public static TextBlock TextTrimming(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.TextTrimmingProperty] = binding);
public static TextBlock TextTrimming(this TextBlock control, TextTrimming value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.TextTrimmingProperty, ps, () => control.TextTrimming = value);
public static TextBlock TextDecorations(this TextBlock control, IBinding binding)
   => control._set(() => control[!TextBlock.TextDecorationsProperty] = binding);
public static TextBlock TextDecorations(this TextBlock control, TextDecorationCollection value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = value);
public static TextBox AcceptsReturn(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.AcceptsReturnProperty] = binding);
public static TextBox AcceptsReturn(this TextBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = value);
public static TextBox AcceptsTab(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.AcceptsTabProperty] = binding);
public static TextBox AcceptsTab(this TextBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = value);
public static TextBox CaretIndex(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.CaretIndexProperty] = binding);
public static TextBox CaretIndex(this TextBox control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.CaretIndexProperty, ps, () => control.CaretIndex = value);
public static TextBox IsReadOnly(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.IsReadOnlyProperty] = binding);
public static TextBox IsReadOnly(this TextBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = value);
public static TextBox PasswordChar(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.PasswordCharProperty] = binding);
public static TextBox PasswordChar(this TextBox control, Char value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.PasswordCharProperty, ps, () => control.PasswordChar = value);
public static TextBox SelectionBrush(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.SelectionBrushProperty] = binding);
public static TextBox SelectionBrush(this TextBox control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = value);
public static TextBox SelectionForegroundBrush(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.SelectionForegroundBrushProperty] = binding);
public static TextBox SelectionForegroundBrush(this TextBox control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value);
public static TextBox CaretBrush(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.CaretBrushProperty] = binding);
public static TextBox CaretBrush(this TextBox control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.CaretBrushProperty, ps, () => control.CaretBrush = value);
public static TextBox SelectionStart(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.SelectionStartProperty] = binding);
public static TextBox SelectionStart(this TextBox control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.SelectionStartProperty, ps, () => control.SelectionStart = value);
public static TextBox SelectionEnd(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.SelectionEndProperty] = binding);
public static TextBox SelectionEnd(this TextBox control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = value);
public static TextBox MaxLength(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.MaxLengthProperty] = binding);
public static TextBox MaxLength(this TextBox control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.MaxLengthProperty, ps, () => control.MaxLength = value);
public static TextBox Text(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.TextProperty] = binding);
public static TextBox Text(this TextBox control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.TextProperty, ps, () => control.Text = value);
public static TextBox TextAlignment(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.TextAlignmentProperty] = binding);
public static TextBox TextAlignment(this TextBox control, TextAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = value);
public static TextBox HorizontalContentAlignment(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.HorizontalContentAlignmentProperty] = binding);
public static TextBox HorizontalContentAlignment(this TextBox control, HorizontalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value);
public static TextBox VerticalContentAlignment(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.VerticalContentAlignmentProperty] = binding);
public static TextBox VerticalContentAlignment(this TextBox control, VerticalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value);
public static TextBox TextWrapping(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.TextWrappingProperty] = binding);
public static TextBox TextWrapping(this TextBox control, TextWrapping value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.TextWrappingProperty, ps, () => control.TextWrapping = value);
public static TextBox Watermark(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.WatermarkProperty] = binding);
public static TextBox Watermark(this TextBox control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.WatermarkProperty, ps, () => control.Watermark = value);
public static TextBox UseFloatingWatermark(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.UseFloatingWatermarkProperty] = binding);
public static TextBox UseFloatingWatermark(this TextBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value);
public static TextBox NewLine(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.NewLineProperty] = binding);
public static TextBox NewLine(this TextBox control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.NewLineProperty, ps, () => control.NewLine = value);
public static TextBox InnerLeftContent(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.InnerLeftContentProperty] = binding);
public static TextBox InnerLeftContent(this TextBox control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value);
public static TextBox InnerRightContent(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.InnerRightContentProperty] = binding);
public static TextBox InnerRightContent(this TextBox control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value);
public static TextBox RevealPassword(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.RevealPasswordProperty] = binding);
public static TextBox RevealPassword(this TextBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = value);
public static TextBox IsUndoEnabled(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.IsUndoEnabledProperty] = binding);
public static TextBox IsUndoEnabled(this TextBox control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = value);
public static TextBox UndoLimit(this TextBox control, IBinding binding)
   => control._set(() => control[!TextBox.UndoLimitProperty] = binding);
public static TextBox UndoLimit(this TextBox control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextBox.UndoLimitProperty, ps, () => control.UndoLimit = value);
public static TickBar Fill(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.FillProperty] = binding);
public static TickBar Fill(this TickBar control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TickBar.FillProperty, ps, () => control.Fill = value);
public static TickBar Minimum(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.MinimumProperty] = binding);
public static TickBar Minimum(this TickBar control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TickBar.MinimumProperty, ps, () => control.Minimum = value);
public static TickBar Maximum(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.MaximumProperty] = binding);
public static TickBar Maximum(this TickBar control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TickBar.MaximumProperty, ps, () => control.Maximum = value);
public static TickBar TickFrequency(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.TickFrequencyProperty] = binding);
public static TickBar TickFrequency(this TickBar control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TickBar.TickFrequencyProperty, ps, () => control.TickFrequency = value);
public static TickBar Orientation(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.OrientationProperty] = binding);
public static TickBar Orientation(this TickBar control, Orientation value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TickBar.OrientationProperty, ps, () => control.Orientation = value);
public static TickBar Ticks(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.TicksProperty] = binding);
public static TickBar Ticks(this TickBar control, AvaloniaList<Double> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TickBar.TicksProperty, ps, () => control.Ticks = value);
public static TickBar IsDirectionReversed(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.IsDirectionReversedProperty] = binding);
public static TickBar IsDirectionReversed(this TickBar control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TickBar.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value);
public static TickBar Placement(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.PlacementProperty] = binding);
public static TickBar Placement(this TickBar control, TickBarPlacement value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TickBar.PlacementProperty, ps, () => control.Placement = value);
public static TickBar ReservedSpace(this TickBar control, IBinding binding)
   => control._set(() => control[!TickBar.ReservedSpaceProperty] = binding);
public static TickBar ReservedSpace(this TickBar control, Rect value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TickBar.ReservedSpaceProperty, ps, () => control.ReservedSpace = value);

public static TickBar ReservedSpace(this TickBar control, Double x, Double y, Double width, Double height)
   => control._set(() => control.ReservedSpace = new Rect(x, y, width, height));
public static TickBar ReservedSpace(this TickBar control, Size size)
   => control._set(() => control.ReservedSpace = new Rect(size));
public static TickBar ReservedSpace(this TickBar control, Point position, Size size)
   => control._set(() => control.ReservedSpace = new Rect(position, size));
public static TickBar ReservedSpace(this TickBar control, Point topLeft, Point bottomRight)
   => control._set(() => control.ReservedSpace = new Rect(topLeft, bottomRight));
public static ToggleSwitch OffContent(this ToggleSwitch control, IBinding binding)
   => control._set(() => control[!ToggleSwitch.OffContentProperty] = binding);
public static ToggleSwitch OffContent(this ToggleSwitch control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ToggleSwitch.OffContentProperty, ps, () => control.OffContent = value);
public static ToggleSwitch OffContentTemplate(this ToggleSwitch control, IBinding binding)
   => control._set(() => control[!ToggleSwitch.OffContentTemplateProperty] = binding);
public static ToggleSwitch OffContentTemplate(this ToggleSwitch control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ToggleSwitch.OffContentTemplateProperty, ps, () => control.OffContentTemplate = value);
public static ToggleSwitch OnContent(this ToggleSwitch control, IBinding binding)
   => control._set(() => control[!ToggleSwitch.OnContentProperty] = binding);
public static ToggleSwitch OnContent(this ToggleSwitch control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ToggleSwitch.OnContentProperty, ps, () => control.OnContent = value);
public static ToggleSwitch OnContentTemplate(this ToggleSwitch control, IBinding binding)
   => control._set(() => control[!ToggleSwitch.OnContentTemplateProperty] = binding);
public static ToggleSwitch OnContentTemplate(this ToggleSwitch control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ToggleSwitch.OnContentTemplateProperty, ps, () => control.OnContentTemplate = value);
public static TopLevel TransparencyLevelHint(this TopLevel control, IBinding binding)
   => control._set(() => control[!TopLevel.TransparencyLevelHintProperty] = binding);
public static TopLevel TransparencyLevelHint(this TopLevel control, WindowTransparencyLevel value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = value);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, IBinding binding)
   => control._set(() => control[!TopLevel.TransparencyBackgroundFallbackProperty] = binding);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = value);
public static TreeView AutoScrollToSelectedItem(this TreeView control, IBinding binding)
   => control._set(() => control[!TreeView.AutoScrollToSelectedItemProperty] = binding);
public static TreeView AutoScrollToSelectedItem(this TreeView control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TreeView.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = value);
public static TreeView SelectedItem(this TreeView control, IBinding binding)
   => control._set(() => control[!TreeView.SelectedItemProperty] = binding);
public static TreeView SelectedItem(this TreeView control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TreeView.SelectedItemProperty, ps, () => control.SelectedItem = value);
public static TreeView SelectedItems(this TreeView control, IBinding binding)
   => control._set(() => control[!TreeView.SelectedItemsProperty] = binding);
public static TreeView SelectedItems(this TreeView control, IList value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TreeView.SelectedItemsProperty, ps, () => control.SelectedItems = value);
public static TreeView SelectionMode(this TreeView control, IBinding binding)
   => control._set(() => control[!TreeView.SelectionModeProperty] = binding);
public static TreeView SelectionMode(this TreeView control, SelectionMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TreeView.SelectionModeProperty, ps, () => control.SelectionMode = value);
public static TreeViewItem IsExpanded(this TreeViewItem control, IBinding binding)
   => control._set(() => control[!TreeViewItem.IsExpandedProperty] = binding);
public static TreeViewItem IsExpanded(this TreeViewItem control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TreeViewItem.IsExpandedProperty, ps, () => control.IsExpanded = value);
public static TreeViewItem IsSelected(this TreeViewItem control, IBinding binding)
   => control._set(() => control[!TreeViewItem.IsSelectedProperty] = binding);
public static TreeViewItem IsSelected(this TreeViewItem control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TreeViewItem.IsSelectedProperty, ps, () => control.IsSelected = value);
public static Viewbox StretchDirection(this Viewbox control, IBinding binding)
   => control._set(() => control[!Viewbox.StretchDirectionProperty] = binding);
public static Viewbox StretchDirection(this Viewbox control, StretchDirection value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Viewbox.StretchDirectionProperty, ps, () => control.StretchDirection = value);
public static Window SizeToContent(this Window control, IBinding binding)
   => control._set(() => control[!Window.SizeToContentProperty] = binding);
public static Window SizeToContent(this Window control, SizeToContent value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.SizeToContentProperty, ps, () => control.SizeToContent = value);
public static Window ExtendClientAreaToDecorationsHint(this Window control, IBinding binding)
   => control._set(() => control[!Window.ExtendClientAreaToDecorationsHintProperty] = binding);
public static Window ExtendClientAreaToDecorationsHint(this Window control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = value);
public static Window ExtendClientAreaChromeHints(this Window control, IBinding binding)
   => control._set(() => control[!Window.ExtendClientAreaChromeHintsProperty] = binding);
public static Window ExtendClientAreaChromeHints(this Window control, ExtendClientAreaChromeHints value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = value);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, IBinding binding)
   => control._set(() => control[!Window.ExtendClientAreaTitleBarHeightHintProperty] = binding);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = value);
public static Window SystemDecorations(this Window control, IBinding binding)
   => control._set(() => control[!Window.SystemDecorationsProperty] = binding);
public static Window SystemDecorations(this Window control, SystemDecorations value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = value);
public static Window ShowActivated(this Window control, IBinding binding)
   => control._set(() => control[!Window.ShowActivatedProperty] = binding);
public static Window ShowActivated(this Window control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.ShowActivatedProperty, ps, () => control.ShowActivated = value);
public static Window ShowInTaskbar(this Window control, IBinding binding)
   => control._set(() => control[!Window.ShowInTaskbarProperty] = binding);
public static Window ShowInTaskbar(this Window control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = value);
public static Window WindowState(this Window control, IBinding binding)
   => control._set(() => control[!Window.WindowStateProperty] = binding);
public static Window WindowState(this Window control, WindowState value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.WindowStateProperty, ps, () => control.WindowState = value);
public static Window Title(this Window control, IBinding binding)
   => control._set(() => control[!Window.TitleProperty] = binding);
public static Window Title(this Window control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.TitleProperty, ps, () => control.Title = value);
public static Window Icon(this Window control, IBinding binding)
   => control._set(() => control[!Window.IconProperty] = binding);
public static Window Icon(this Window control, WindowIcon value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.IconProperty, ps, () => control.Icon = value);
public static Window WindowStartupLocation(this Window control, IBinding binding)
   => control._set(() => control[!Window.WindowStartupLocationProperty] = binding);
public static Window WindowStartupLocation(this Window control, WindowStartupLocation value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = value);
public static Window CanResize(this Window control, IBinding binding)
   => control._set(() => control[!Window.CanResizeProperty] = binding);
public static Window CanResize(this Window control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Window.CanResizeProperty, ps, () => control.CanResize = value);
public static WindowBase Topmost(this WindowBase control, IBinding binding)
   => control._set(() => control[!WindowBase.TopmostProperty] = binding);
public static WindowBase Topmost(this WindowBase control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(WindowBase.TopmostProperty, ps, () => control.Topmost = value);
public static WrapPanel Orientation(this WrapPanel control, IBinding binding)
   => control._set(() => control[!WrapPanel.OrientationProperty] = binding);
public static WrapPanel Orientation(this WrapPanel control, Orientation value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(WrapPanel.OrientationProperty, ps, () => control.Orientation = value);
public static WrapPanel ItemWidth(this WrapPanel control, IBinding binding)
   => control._set(() => control[!WrapPanel.ItemWidthProperty] = binding);
public static WrapPanel ItemWidth(this WrapPanel control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = value);
public static WrapPanel ItemHeight(this WrapPanel control, IBinding binding)
   => control._set(() => control[!WrapPanel.ItemHeightProperty] = binding);
public static WrapPanel ItemHeight(this WrapPanel control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = value);
public static Arc StartAngle(this Arc control, IBinding binding)
   => control._set(() => control[!Arc.StartAngleProperty] = binding);
public static Arc StartAngle(this Arc control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Arc.StartAngleProperty, ps, () => control.StartAngle = value);
public static Arc SweepAngle(this Arc control, IBinding binding)
   => control._set(() => control[!Arc.SweepAngleProperty] = binding);
public static Arc SweepAngle(this Arc control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Arc.SweepAngleProperty, ps, () => control.SweepAngle = value);
public static Line StartPoint(this Line control, IBinding binding)
   => control._set(() => control[!Line.StartPointProperty] = binding);
public static Line StartPoint(this Line control, Point value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Line.StartPointProperty, ps, () => control.StartPoint = value);
public static Line EndPoint(this Line control, IBinding binding)
   => control._set(() => control[!Line.EndPointProperty] = binding);
public static Line EndPoint(this Line control, Point value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Line.EndPointProperty, ps, () => control.EndPoint = value);
public static Path Data(this Path control, IBinding binding)
   => control._set(() => control[!Path.DataProperty] = binding);
public static Path Data(this Path control, Geometry value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Path.DataProperty, ps, () => control.Data = value);
public static Polygon Points(this Polygon control, IBinding binding)
   => control._set(() => control[!Polygon.PointsProperty] = binding);
public static Polygon Points(this Polygon control, IList<Point> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Polygon.PointsProperty, ps, () => control.Points = value);
public static Polyline Points(this Polyline control, IBinding binding)
   => control._set(() => control[!Polyline.PointsProperty] = binding);
public static Polyline Points(this Polyline control, IList<Point> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Polyline.PointsProperty, ps, () => control.Points = value);
public static Shape Fill(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.FillProperty] = binding);
public static Shape Fill(this Shape control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Shape.FillProperty, ps, () => control.Fill = value);
public static Shape Stretch(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StretchProperty] = binding);
public static Shape Stretch(this Shape control, Stretch value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Shape.StretchProperty, ps, () => control.Stretch = value);
public static Shape Stroke(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeProperty] = binding);
public static Shape Stroke(this Shape control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Shape.StrokeProperty, ps, () => control.Stroke = value);
public static Shape StrokeDashArray(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeDashArrayProperty] = binding);
public static Shape StrokeDashArray(this Shape control, AvaloniaList<Double> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Shape.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = value);
public static Shape StrokeDashOffset(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeDashOffsetProperty] = binding);
public static Shape StrokeDashOffset(this Shape control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Shape.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = value);
public static Shape StrokeThickness(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeThicknessProperty] = binding);
public static Shape StrokeThickness(this Shape control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Shape.StrokeThicknessProperty, ps, () => control.StrokeThickness = value);
public static Shape StrokeLineCap(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeLineCapProperty] = binding);
public static Shape StrokeLineCap(this Shape control, PenLineCap value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Shape.StrokeLineCapProperty, ps, () => control.StrokeLineCap = value);
public static Shape StrokeJoin(this Shape control, IBinding binding)
   => control._set(() => control[!Shape.StrokeJoinProperty] = binding);
public static Shape StrokeJoin(this Shape control, PenLineJoin value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Shape.StrokeJoinProperty, ps, () => control.StrokeJoin = value);
public static CarouselPresenter IsVirtualized(this CarouselPresenter control, IBinding binding)
   => control._set(() => control[!CarouselPresenter.IsVirtualizedProperty] = binding);
public static CarouselPresenter IsVirtualized(this CarouselPresenter control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CarouselPresenter.IsVirtualizedProperty, ps, () => control.IsVirtualized = value);
public static CarouselPresenter SelectedIndex(this CarouselPresenter control, IBinding binding)
   => control._set(() => control[!CarouselPresenter.SelectedIndexProperty] = binding);
public static CarouselPresenter SelectedIndex(this CarouselPresenter control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CarouselPresenter.SelectedIndexProperty, ps, () => control.SelectedIndex = value);
public static CarouselPresenter PageTransition(this CarouselPresenter control, IBinding binding)
   => control._set(() => control[!CarouselPresenter.PageTransitionProperty] = binding);
public static CarouselPresenter PageTransition(this CarouselPresenter control, IPageTransition value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CarouselPresenter.PageTransitionProperty, ps, () => control.PageTransition = value);
public static ContentPresenter Background(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.BackgroundProperty] = binding);
public static ContentPresenter Background(this ContentPresenter control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.BackgroundProperty, ps, () => control.Background = value);
public static ContentPresenter BorderBrush(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.BorderBrushProperty] = binding);
public static ContentPresenter BorderBrush(this ContentPresenter control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.BorderBrushProperty, ps, () => control.BorderBrush = value);
public static ContentPresenter BorderThickness(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.BorderThicknessProperty] = binding);
public static ContentPresenter BorderThickness(this ContentPresenter control, Thickness value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.BorderThicknessProperty, ps, () => control.BorderThickness = value);

public static ContentPresenter BorderThickness(this ContentPresenter control, Double uniformLength)
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static ContentPresenter BorderThickness(this ContentPresenter control, Double horizontal, Double vertical)
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static ContentPresenter BorderThickness(this ContentPresenter control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));
public static ContentPresenter CornerRadius(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.CornerRadiusProperty] = binding);
public static ContentPresenter CornerRadius(this ContentPresenter control, CornerRadius value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.CornerRadiusProperty, ps, () => control.CornerRadius = value);

public static ContentPresenter CornerRadius(this ContentPresenter control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static ContentPresenter CornerRadius(this ContentPresenter control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static ContentPresenter CornerRadius(this ContentPresenter control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static ContentPresenter BoxShadow(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.BoxShadowProperty] = binding);
public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadows value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.BoxShadowProperty, ps, () => control.BoxShadow = value);

public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadow shadow)
   => control._set(() => control.BoxShadow = new BoxShadows(shadow));
public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadow first, BoxShadow[] rest)
   => control._set(() => control.BoxShadow = new BoxShadows(first, rest));
public static ContentPresenter Content(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.ContentProperty] = binding);
public static ContentPresenter Content(this ContentPresenter control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.ContentProperty, ps, () => control.Content = value);
public static ContentPresenter ContentTemplate(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.ContentTemplateProperty] = binding);
public static ContentPresenter ContentTemplate(this ContentPresenter control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.ContentTemplateProperty, ps, () => control.ContentTemplate = value);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.HorizontalContentAlignmentProperty] = binding);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, HorizontalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.VerticalContentAlignmentProperty] = binding);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, VerticalAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value);
public static ContentPresenter Padding(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.PaddingProperty] = binding);
public static ContentPresenter Padding(this ContentPresenter control, Thickness value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.PaddingProperty, ps, () => control.Padding = value);

public static ContentPresenter Padding(this ContentPresenter control, Double uniformLength)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static ContentPresenter Padding(this ContentPresenter control, Double horizontal, Double vertical)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static ContentPresenter Padding(this ContentPresenter control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, IBinding binding)
   => control._set(() => control[!ContentPresenter.RecognizesAccessKeyProperty] = binding);
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ContentPresenter.RecognizesAccessKeyProperty, ps, () => control.RecognizesAccessKey = value);
public static ItemsPresenter VirtualizationMode(this ItemsPresenter control, IBinding binding)
   => control._set(() => control[!ItemsPresenter.VirtualizationModeProperty] = binding);
public static ItemsPresenter VirtualizationMode(this ItemsPresenter control, ItemVirtualizationMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ItemsPresenter.VirtualizationModeProperty, ps, () => control.VirtualizationMode = value);
public static ItemsPresenterBase Items(this ItemsPresenterBase control, IBinding binding)
   => control._set(() => control[!ItemsPresenterBase.ItemsProperty] = binding);
public static ItemsPresenterBase Items(this ItemsPresenterBase control, IEnumerable value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ItemsPresenterBase.ItemsProperty, ps, () => control.Items = value);
public static ItemsPresenterBase ItemsPanel(this ItemsPresenterBase control, IBinding binding)
   => control._set(() => control[!ItemsPresenterBase.ItemsPanelProperty] = binding);
public static ItemsPresenterBase ItemsPanel(this ItemsPresenterBase control, ITemplate<IPanel> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ItemsPresenterBase.ItemsPanelProperty, ps, () => control.ItemsPanel = value);
public static ItemsPresenterBase ItemTemplate(this ItemsPresenterBase control, IBinding binding)
   => control._set(() => control[!ItemsPresenterBase.ItemTemplateProperty] = binding);
public static ItemsPresenterBase ItemTemplate(this ItemsPresenterBase control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ItemsPresenterBase.ItemTemplateProperty, ps, () => control.ItemTemplate = value);
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, IBinding binding)
   => control._set(() => control[!ScrollContentPresenter.CanHorizontallyScrollProperty] = binding);
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollContentPresenter.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = value);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, IBinding binding)
   => control._set(() => control[!ScrollContentPresenter.CanVerticallyScrollProperty] = binding);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollContentPresenter.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = value);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, IBinding binding)
   => control._set(() => control[!ScrollContentPresenter.OffsetProperty] = binding);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, Vector value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollContentPresenter.OffsetProperty, ps, () => control.Offset = value);
public static TextPresenter CaretIndex(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.CaretIndexProperty] = binding);
public static TextPresenter CaretIndex(this TextPresenter control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = value);
public static TextPresenter RevealPassword(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.RevealPasswordProperty] = binding);
public static TextPresenter RevealPassword(this TextPresenter control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = value);
public static TextPresenter PasswordChar(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.PasswordCharProperty] = binding);
public static TextPresenter PasswordChar(this TextPresenter control, Char value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = value);
public static TextPresenter SelectionBrush(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.SelectionBrushProperty] = binding);
public static TextPresenter SelectionBrush(this TextPresenter control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = value);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.SelectionForegroundBrushProperty] = binding);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value);
public static TextPresenter CaretBrush(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.CaretBrushProperty] = binding);
public static TextPresenter CaretBrush(this TextPresenter control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = value);
public static TextPresenter SelectionStart(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.SelectionStartProperty] = binding);
public static TextPresenter SelectionStart(this TextPresenter control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = value);
public static TextPresenter SelectionEnd(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.SelectionEndProperty] = binding);
public static TextPresenter SelectionEnd(this TextPresenter control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = value);
public static TextPresenter Text(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.TextProperty] = binding);
public static TextPresenter Text(this TextPresenter control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.TextProperty, ps, () => control.Text = value);
public static TextPresenter TextAlignment(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.TextAlignmentProperty] = binding);
public static TextPresenter TextAlignment(this TextPresenter control, TextAlignment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = value);
public static TextPresenter TextWrapping(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.TextWrappingProperty] = binding);
public static TextPresenter TextWrapping(this TextPresenter control, TextWrapping value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = value);
public static TextPresenter Background(this TextPresenter control, IBinding binding)
   => control._set(() => control[!TextPresenter.BackgroundProperty] = binding);
public static TextPresenter Background(this TextPresenter control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(TextPresenter.BackgroundProperty, ps, () => control.Background = value);
public static NotificationCard IsClosed(this NotificationCard control, IBinding binding)
   => control._set(() => control[!NotificationCard.IsClosedProperty] = binding);
public static NotificationCard IsClosed(this NotificationCard control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(NotificationCard.IsClosedProperty, ps, () => control.IsClosed = value);
public static WindowNotificationManager Position(this WindowNotificationManager control, IBinding binding)
   => control._set(() => control[!WindowNotificationManager.PositionProperty] = binding);
public static WindowNotificationManager Position(this WindowNotificationManager control, NotificationPosition value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(WindowNotificationManager.PositionProperty, ps, () => control.Position = value);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, IBinding binding)
   => control._set(() => control[!WindowNotificationManager.MaxItemsProperty] = binding);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = value);
public static CalendarItem HeaderBackground(this CalendarItem control, IBinding binding)
   => control._set(() => control[!CalendarItem.HeaderBackgroundProperty] = binding);
public static CalendarItem HeaderBackground(this CalendarItem control, IBrush value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarItem.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value);
public static CalendarItem DayTitleTemplate(this CalendarItem control, IBinding binding)
   => control._set(() => control[!CalendarItem.DayTitleTemplateProperty] = binding);
public static CalendarItem DayTitleTemplate(this CalendarItem control, ITemplate<IControl> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(CalendarItem.DayTitleTemplateProperty, ps, () => control.DayTitleTemplate = value);
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, IBinding binding)
   => control._set(() => control[!DateTimePickerPanel.ItemHeightProperty] = binding);
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DateTimePickerPanel.ItemHeightProperty, ps, () => control.ItemHeight = value);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, IBinding binding)
   => control._set(() => control[!DateTimePickerPanel.PanelTypeProperty] = binding);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, DateTimePickerPanelType value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DateTimePickerPanel.PanelTypeProperty, ps, () => control.PanelType = value);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, IBinding binding)
   => control._set(() => control[!DateTimePickerPanel.ItemFormatProperty] = binding);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, String value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DateTimePickerPanel.ItemFormatProperty, ps, () => control.ItemFormat = value);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, IBinding binding)
   => control._set(() => control[!DateTimePickerPanel.ShouldLoopProperty] = binding);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(DateTimePickerPanel.ShouldLoopProperty, ps, () => control.ShouldLoop = value);
public static AccessText ShowAccessKey(this AccessText control, IBinding binding)
   => control._set(() => control[!AccessText.ShowAccessKeyProperty] = binding);
public static AccessText ShowAccessKey(this AccessText control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(AccessText.ShowAccessKeyProperty, ps, () => control.ShowAccessKey = value);
public static HeaderedContentControl Header(this HeaderedContentControl control, IBinding binding)
   => control._set(() => control[!HeaderedContentControl.HeaderProperty] = binding);
public static HeaderedContentControl Header(this HeaderedContentControl control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(HeaderedContentControl.HeaderProperty, ps, () => control.Header = value);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, IBinding binding)
   => control._set(() => control[!HeaderedContentControl.HeaderTemplateProperty] = binding);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, IDataTemplate value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(HeaderedContentControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value);
public static HeaderedItemsControl Header(this HeaderedItemsControl control, IBinding binding)
   => control._set(() => control[!HeaderedItemsControl.HeaderProperty] = binding);
public static HeaderedItemsControl Header(this HeaderedItemsControl control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(HeaderedItemsControl.HeaderProperty, ps, () => control.Header = value);
public static HeaderedSelectingItemsControl Header(this HeaderedSelectingItemsControl control, IBinding binding)
   => control._set(() => control[!HeaderedSelectingItemsControl.HeaderProperty] = binding);
public static HeaderedSelectingItemsControl Header(this HeaderedSelectingItemsControl control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(HeaderedSelectingItemsControl.HeaderProperty, ps, () => control.Header = value);
public static Popup WindowManagerAddShadowHint(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.WindowManagerAddShadowHintProperty] = binding);
public static Popup WindowManagerAddShadowHint(this Popup control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value);
public static Popup Child(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.ChildProperty] = binding);
public static Popup Child(this Popup control, Control value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.ChildProperty, ps, () => control.Child = value);
public static Popup IsOpen(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.IsOpenProperty] = binding);
public static Popup IsOpen(this Popup control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.IsOpenProperty, ps, () => control.IsOpen = value);
public static Popup PlacementAnchor(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementAnchorProperty] = binding);
public static Popup PlacementAnchor(this Popup control, PopupAnchor value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value);
public static Popup PlacementConstraintAdjustment(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementConstraintAdjustmentProperty] = binding);
public static Popup PlacementConstraintAdjustment(this Popup control, PopupPositionerConstraintAdjustment value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value);
public static Popup PlacementGravity(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementGravityProperty] = binding);
public static Popup PlacementGravity(this Popup control, PopupGravity value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = value);
public static Popup PlacementMode(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementModeProperty] = binding);
public static Popup PlacementMode(this Popup control, PlacementMode value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.PlacementModeProperty, ps, () => control.PlacementMode = value);
public static Popup PlacementRect(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementRectProperty] = binding);
public static Popup PlacementRect(this Popup control, Nullable<Rect> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.PlacementRectProperty, ps, () => control.PlacementRect = value);
public static Popup PlacementTarget(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.PlacementTargetProperty] = binding);
public static Popup PlacementTarget(this Popup control, Control value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = value);
public static Popup ObeyScreenEdges(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.ObeyScreenEdgesProperty] = binding);
public static Popup ObeyScreenEdges(this Popup control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.ObeyScreenEdgesProperty, ps, () => control.ObeyScreenEdges = value);
public static Popup OverlayDismissEventPassThrough(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.OverlayDismissEventPassThroughProperty] = binding);
public static Popup OverlayDismissEventPassThrough(this Popup control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = value);
public static Popup OverlayInputPassThroughElement(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.OverlayInputPassThroughElementProperty] = binding);
public static Popup OverlayInputPassThroughElement(this Popup control, IInputElement value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = value);
public static Popup HorizontalOffset(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.HorizontalOffsetProperty] = binding);
public static Popup HorizontalOffset(this Popup control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value);
public static Popup IsLightDismissEnabled(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.IsLightDismissEnabledProperty] = binding);
public static Popup IsLightDismissEnabled(this Popup control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = value);
public static Popup VerticalOffset(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.VerticalOffsetProperty] = binding);
public static Popup VerticalOffset(this Popup control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = value);
public static Popup Topmost(this Popup control, IBinding binding)
   => control._set(() => control[!Popup.TopmostProperty] = binding);
public static Popup Topmost(this Popup control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Popup.TopmostProperty, ps, () => control.Topmost = value);
public static RangeBase Minimum(this RangeBase control, IBinding binding)
   => control._set(() => control[!RangeBase.MinimumProperty] = binding);
public static RangeBase Minimum(this RangeBase control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(RangeBase.MinimumProperty, ps, () => control.Minimum = value);
public static RangeBase Maximum(this RangeBase control, IBinding binding)
   => control._set(() => control[!RangeBase.MaximumProperty] = binding);
public static RangeBase Maximum(this RangeBase control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(RangeBase.MaximumProperty, ps, () => control.Maximum = value);
public static RangeBase Value(this RangeBase control, IBinding binding)
   => control._set(() => control[!RangeBase.ValueProperty] = binding);
public static RangeBase Value(this RangeBase control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(RangeBase.ValueProperty, ps, () => control.Value = value);
public static RangeBase SmallChange(this RangeBase control, IBinding binding)
   => control._set(() => control[!RangeBase.SmallChangeProperty] = binding);
public static RangeBase SmallChange(this RangeBase control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(RangeBase.SmallChangeProperty, ps, () => control.SmallChange = value);
public static RangeBase LargeChange(this RangeBase control, IBinding binding)
   => control._set(() => control[!RangeBase.LargeChangeProperty] = binding);
public static RangeBase LargeChange(this RangeBase control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(RangeBase.LargeChangeProperty, ps, () => control.LargeChange = value);
public static ScrollBar ViewportSize(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.ViewportSizeProperty] = binding);
public static ScrollBar ViewportSize(this ScrollBar control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = value);
public static ScrollBar Visibility(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.VisibilityProperty] = binding);
public static ScrollBar Visibility(this ScrollBar control, ScrollBarVisibility value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollBar.VisibilityProperty, ps, () => control.Visibility = value);
public static ScrollBar Orientation(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.OrientationProperty] = binding);
public static ScrollBar Orientation(this ScrollBar control, Orientation value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollBar.OrientationProperty, ps, () => control.Orientation = value);
public static ScrollBar AllowAutoHide(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.AllowAutoHideProperty] = binding);
public static ScrollBar AllowAutoHide(this ScrollBar control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value);
public static ScrollBar HideDelay(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.HideDelayProperty] = binding);
public static ScrollBar HideDelay(this ScrollBar control, TimeSpan value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollBar.HideDelayProperty, ps, () => control.HideDelay = value);
public static ScrollBar ShowDelay(this ScrollBar control, IBinding binding)
   => control._set(() => control[!ScrollBar.ShowDelayProperty] = binding);
public static ScrollBar ShowDelay(this ScrollBar control, TimeSpan value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = value);
public static SelectingItemsControl AutoScrollToSelectedItem(this SelectingItemsControl control, IBinding binding)
   => control._set(() => control[!SelectingItemsControl.AutoScrollToSelectedItemProperty] = binding);
public static SelectingItemsControl AutoScrollToSelectedItem(this SelectingItemsControl control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SelectingItemsControl.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = value);
public static SelectingItemsControl SelectedIndex(this SelectingItemsControl control, IBinding binding)
   => control._set(() => control[!SelectingItemsControl.SelectedIndexProperty] = binding);
public static SelectingItemsControl SelectedIndex(this SelectingItemsControl control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SelectingItemsControl.SelectedIndexProperty, ps, () => control.SelectedIndex = value);
public static SelectingItemsControl SelectedItem(this SelectingItemsControl control, IBinding binding)
   => control._set(() => control[!SelectingItemsControl.SelectedItemProperty] = binding);
public static SelectingItemsControl SelectedItem(this SelectingItemsControl control, Object value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SelectingItemsControl.SelectedItemProperty, ps, () => control.SelectedItem = value);
public static SelectingItemsControl IsTextSearchEnabled(this SelectingItemsControl control, IBinding binding)
   => control._set(() => control[!SelectingItemsControl.IsTextSearchEnabledProperty] = binding);
public static SelectingItemsControl IsTextSearchEnabled(this SelectingItemsControl control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(SelectingItemsControl.IsTextSearchEnabledProperty, ps, () => control.IsTextSearchEnabled = value);
public static T Background<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.BackgroundProperty] = binding);
public static T Background<T>(this T control, IBrush value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BackgroundProperty, ps, () => control.Background = value);
public static T BorderBrush<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.BorderBrushProperty] = binding);
public static T BorderBrush<T>(this T control, IBrush value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BorderBrushProperty, ps, () => control.BorderBrush = value);
public static T BorderThickness<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.BorderThicknessProperty] = binding);
public static T BorderThickness<T>(this T control, Thickness value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BorderThicknessProperty, ps, () => control.BorderThickness = value);

public static T BorderThickness<T>(this T control, Double uniformLength) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static T BorderThickness<T>(this T control, Double horizontal, Double vertical) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, Double left, Double top, Double right, Double bottom) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));
public static T CornerRadius<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.CornerRadiusProperty] = binding);
public static T CornerRadius<T>(this T control, CornerRadius value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.CornerRadiusProperty, ps, () => control.CornerRadius = value);

public static T CornerRadius<T>(this T control, Double uniformRadius) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, Double top, Double bottom) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static T FontFamily<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.FontFamilyProperty] = binding);
public static T FontFamily<T>(this T control, FontFamily value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontFamilyProperty, ps, () => control.FontFamily = value);
public static T FontSize<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.FontSizeProperty] = binding);
public static T FontSize<T>(this T control, Double value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontSizeProperty, ps, () => control.FontSize = value);
public static T FontStyle<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.FontStyleProperty] = binding);
public static T FontStyle<T>(this T control, FontStyle value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontStyleProperty, ps, () => control.FontStyle = value);
public static T FontWeight<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.FontWeightProperty] = binding);
public static T FontWeight<T>(this T control, FontWeight value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontWeightProperty, ps, () => control.FontWeight = value);
public static T Foreground<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.ForegroundProperty] = binding);
public static T Foreground<T>(this T control, IBrush value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.ForegroundProperty, ps, () => control.Foreground = value);
public static T Padding<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.PaddingProperty] = binding);
public static T Padding<T>(this T control, Thickness value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.PaddingProperty, ps, () => control.Padding = value);

public static T Padding<T>(this T control, Double uniformLength) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static T Padding<T>(this T control, Double horizontal, Double vertical) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static T Padding<T>(this T control, Double left, Double top, Double right, Double bottom) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static T Template<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(() => control[!TemplatedControl.TemplateProperty] = binding);
public static T Template<T>(this T control, IControlTemplate value, [CallerArgumentExpression("value")] string ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.TemplateProperty, ps, () => control.Template = value);
public static ToggleButton IsChecked(this ToggleButton control, IBinding binding)
   => control._set(() => control[!ToggleButton.IsCheckedProperty] = binding);
public static ToggleButton IsChecked(this ToggleButton control, Nullable<Boolean> value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = value);
public static ToggleButton IsThreeState(this ToggleButton control, IBinding binding)
   => control._set(() => control[!ToggleButton.IsThreeStateProperty] = binding);
public static ToggleButton IsThreeState(this ToggleButton control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = value);
public static Track Minimum(this Track control, IBinding binding)
   => control._set(() => control[!Track.MinimumProperty] = binding);
public static Track Minimum(this Track control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Track.MinimumProperty, ps, () => control.Minimum = value);
public static Track Maximum(this Track control, IBinding binding)
   => control._set(() => control[!Track.MaximumProperty] = binding);
public static Track Maximum(this Track control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Track.MaximumProperty, ps, () => control.Maximum = value);
public static Track Value(this Track control, IBinding binding)
   => control._set(() => control[!Track.ValueProperty] = binding);
public static Track Value(this Track control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Track.ValueProperty, ps, () => control.Value = value);
public static Track ViewportSize(this Track control, IBinding binding)
   => control._set(() => control[!Track.ViewportSizeProperty] = binding);
public static Track ViewportSize(this Track control, Double value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Track.ViewportSizeProperty, ps, () => control.ViewportSize = value);
public static Track Orientation(this Track control, IBinding binding)
   => control._set(() => control[!Track.OrientationProperty] = binding);
public static Track Orientation(this Track control, Orientation value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Track.OrientationProperty, ps, () => control.Orientation = value);
public static Track Thumb(this Track control, IBinding binding)
   => control._set(() => control[!Track.ThumbProperty] = binding);
public static Track Thumb(this Track control, Thumb value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Track.ThumbProperty, ps, () => control.Thumb = value);
public static Track IncreaseButton(this Track control, IBinding binding)
   => control._set(() => control[!Track.IncreaseButtonProperty] = binding);
public static Track IncreaseButton(this Track control, Button value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = value);
public static Track DecreaseButton(this Track control, IBinding binding)
   => control._set(() => control[!Track.DecreaseButtonProperty] = binding);
public static Track DecreaseButton(this Track control, Button value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = value);
public static Track IsDirectionReversed(this Track control, IBinding binding)
   => control._set(() => control[!Track.IsDirectionReversedProperty] = binding);
public static Track IsDirectionReversed(this Track control, Boolean value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value);
public static UniformGrid Rows(this UniformGrid control, IBinding binding)
   => control._set(() => control[!UniformGrid.RowsProperty] = binding);
public static UniformGrid Rows(this UniformGrid control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(UniformGrid.RowsProperty, ps, () => control.Rows = value);
public static UniformGrid Columns(this UniformGrid control, IBinding binding)
   => control._set(() => control[!UniformGrid.ColumnsProperty] = binding);
public static UniformGrid Columns(this UniformGrid control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(UniformGrid.ColumnsProperty, ps, () => control.Columns = value);
public static UniformGrid FirstColumn(this UniformGrid control, IBinding binding)
   => control._set(() => control[!UniformGrid.FirstColumnProperty] = binding);
public static UniformGrid FirstColumn(this UniformGrid control, Int32 value, [CallerArgumentExpression("value")] string ps = null)
=> control._setEx(UniformGrid.FirstColumnProperty, ps, () => control.FirstColumn = value);
public static T Width<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.WidthProperty] = binding);
public static T Width<T>(this T control, Double value, [CallerArgumentExpression("value")] string ps = null) where T : Layoutable
=> control._setEx(Layoutable.WidthProperty, ps, () => control.Width = value);
public static T Height<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.HeightProperty] = binding);
public static T Height<T>(this T control, Double value, [CallerArgumentExpression("value")] string ps = null) where T : Layoutable
=> control._setEx(Layoutable.HeightProperty, ps, () => control.Height = value);
public static T MinWidth<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.MinWidthProperty] = binding);
public static T MinWidth<T>(this T control, Double value, [CallerArgumentExpression("value")] string ps = null) where T : Layoutable
=> control._setEx(Layoutable.MinWidthProperty, ps, () => control.MinWidth = value);
public static T MaxWidth<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.MaxWidthProperty] = binding);
public static T MaxWidth<T>(this T control, Double value, [CallerArgumentExpression("value")] string ps = null) where T : Layoutable
=> control._setEx(Layoutable.MaxWidthProperty, ps, () => control.MaxWidth = value);
public static T MinHeight<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.MinHeightProperty] = binding);
public static T MinHeight<T>(this T control, Double value, [CallerArgumentExpression("value")] string ps = null) where T : Layoutable
=> control._setEx(Layoutable.MinHeightProperty, ps, () => control.MinHeight = value);
public static T MaxHeight<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.MaxHeightProperty] = binding);
public static T MaxHeight<T>(this T control, Double value, [CallerArgumentExpression("value")] string ps = null) where T : Layoutable
=> control._setEx(Layoutable.MaxHeightProperty, ps, () => control.MaxHeight = value);
public static T Margin<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.MarginProperty] = binding);
public static T Margin<T>(this T control, Thickness value, [CallerArgumentExpression("value")] string ps = null) where T : Layoutable
=> control._setEx(Layoutable.MarginProperty, ps, () => control.Margin = value);

public static T Margin<T>(this T control, Double uniformLength) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(uniformLength));
public static T Margin<T>(this T control, Double horizontal, Double vertical) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(horizontal, vertical));
public static T Margin<T>(this T control, Double left, Double top, Double right, Double bottom) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(left, top, right, bottom));
public static T HorizontalAlignment<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.HorizontalAlignmentProperty] = binding);
public static T HorizontalAlignment<T>(this T control, HorizontalAlignment value, [CallerArgumentExpression("value")] string ps = null) where T : Layoutable
=> control._setEx(Layoutable.HorizontalAlignmentProperty, ps, () => control.HorizontalAlignment = value);
public static T VerticalAlignment<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.VerticalAlignmentProperty] = binding);
public static T VerticalAlignment<T>(this T control, VerticalAlignment value, [CallerArgumentExpression("value")] string ps = null) where T : Layoutable
=> control._setEx(Layoutable.VerticalAlignmentProperty, ps, () => control.VerticalAlignment = value);
public static T UseLayoutRounding<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(() => control[!Layoutable.UseLayoutRoundingProperty] = binding);
public static T UseLayoutRounding<T>(this T control, Boolean value, [CallerArgumentExpression("value")] string ps = null) where T : Layoutable
=> control._setEx(Layoutable.UseLayoutRoundingProperty, ps, () => control.UseLayoutRounding = value);
public static T ClipToBounds<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.ClipToBoundsProperty] = binding);
public static T ClipToBounds<T>(this T control, Boolean value, [CallerArgumentExpression("value")] string ps = null) where T : Visual
=> control._setEx(Visual.ClipToBoundsProperty, ps, () => control.ClipToBounds = value);
public static T Clip<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.ClipProperty] = binding);
public static T Clip<T>(this T control, Geometry value, [CallerArgumentExpression("value")] string ps = null) where T : Visual
=> control._setEx(Visual.ClipProperty, ps, () => control.Clip = value);
public static T IsVisible<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.IsVisibleProperty] = binding);
public static T IsVisible<T>(this T control, Boolean value, [CallerArgumentExpression("value")] string ps = null) where T : Visual
=> control._setEx(Visual.IsVisibleProperty, ps, () => control.IsVisible = value);
public static T Opacity<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.OpacityProperty] = binding);
public static T Opacity<T>(this T control, Double value, [CallerArgumentExpression("value")] string ps = null) where T : Visual
=> control._setEx(Visual.OpacityProperty, ps, () => control.Opacity = value);
public static T OpacityMask<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.OpacityMaskProperty] = binding);
public static T OpacityMask<T>(this T control, IBrush value, [CallerArgumentExpression("value")] string ps = null) where T : Visual
=> control._setEx(Visual.OpacityMaskProperty, ps, () => control.OpacityMask = value);
public static T RenderTransform<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.RenderTransformProperty] = binding);
public static T RenderTransform<T>(this T control, ITransform value, [CallerArgumentExpression("value")] string ps = null) where T : Visual
=> control._setEx(Visual.RenderTransformProperty, ps, () => control.RenderTransform = value);
public static T RenderTransformOrigin<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.RenderTransformOriginProperty] = binding);
public static T RenderTransformOrigin<T>(this T control, RelativePoint value, [CallerArgumentExpression("value")] string ps = null) where T : Visual
=> control._setEx(Visual.RenderTransformOriginProperty, ps, () => control.RenderTransformOrigin = value);

public static T RenderTransformOrigin<T>(this T control, Double x, Double y, RelativeUnit unit) where T : Visual
   => control._set(() => control.RenderTransformOrigin = new RelativePoint(x, y, unit));
public static T RenderTransformOrigin<T>(this T control, Point point, RelativeUnit unit) where T : Visual
   => control._set(() => control.RenderTransformOrigin = new RelativePoint(point, unit));
public static T ZIndex<T>(this T control, IBinding binding) where T : Visual
   => control._set(() => control[!Visual.ZIndexProperty] = binding);
public static T ZIndex<T>(this T control, Int32 value, [CallerArgumentExpression("value")] string ps = null) where T : Visual
=> control._setEx(Visual.ZIndexProperty, ps, () => control.ZIndex = value);
public static T Focusable<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.FocusableProperty] = binding);
public static T Focusable<T>(this T control, Boolean value, [CallerArgumentExpression("value")] string ps = null) where T : InputElement
=> control._setEx(InputElement.FocusableProperty, ps, () => control.Focusable = value);
public static T IsEnabled<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.IsEnabledProperty] = binding);
public static T IsEnabled<T>(this T control, Boolean value, [CallerArgumentExpression("value")] string ps = null) where T : InputElement
=> control._setEx(InputElement.IsEnabledProperty, ps, () => control.IsEnabled = value);
public static T Cursor<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.CursorProperty] = binding);
public static T Cursor<T>(this T control, Cursor value, [CallerArgumentExpression("value")] string ps = null) where T : InputElement
=> control._setEx(InputElement.CursorProperty, ps, () => control.Cursor = value);
public static T IsHitTestVisible<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.IsHitTestVisibleProperty] = binding);
public static T IsHitTestVisible<T>(this T control, Boolean value, [CallerArgumentExpression("value")] string ps = null) where T : InputElement
=> control._setEx(InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = value);
public static T IsTabStop<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.IsTabStopProperty] = binding);
public static T IsTabStop<T>(this T control, Boolean value, [CallerArgumentExpression("value")] string ps = null) where T : InputElement
=> control._setEx(InputElement.IsTabStopProperty, ps, () => control.IsTabStop = value);
public static T TabIndex<T>(this T control, IBinding binding) where T : InputElement
   => control._set(() => control[!InputElement.TabIndexProperty] = binding);
public static T TabIndex<T>(this T control, Int32 value, [CallerArgumentExpression("value")] string ps = null) where T : InputElement
=> control._setEx(InputElement.TabIndexProperty, ps, () => control.TabIndex = value);

}

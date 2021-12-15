using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Input;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Globalization;
using Windows.Media.Capture;
using Windows.Media.Playback;
using Windows.Media.Protection;
using Windows.UI;
using Windows.UI.Input.Inking;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;


public static class ControlExtensions
{
public static T DataContext<T>(this T control, Object value) where T : FrameworkElement
   => control._set(() => control.DataContext = value);
public static T DataContext<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.DataContextProperty, binding));

public static T FlowDirection<T>(this T control, FlowDirection value) where T : FrameworkElement
   => control._set(() => control.FlowDirection = value);
public static T FlowDirection<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.FlowDirectionProperty, binding));

public static T Height<T>(this T control, Double value) where T : FrameworkElement
   => control._set(() => control.Height = value);
public static T Height<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.HeightProperty, binding));

public static T HorizontalAlignment<T>(this T control, HorizontalAlignment value) where T : FrameworkElement
   => control._set(() => control.HorizontalAlignment = value);
public static T HorizontalAlignment<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.HorizontalAlignmentProperty, binding));

public static T Language<T>(this T control, String value) where T : FrameworkElement
   => control._set(() => control.Language = value);
public static T Language<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.LanguageProperty, binding));

public static T Margin<T>(this T control, Thickness value) where T : FrameworkElement
   => control._set(() => control.Margin = value);
public static T Margin<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.MarginProperty, binding));

public static T MaxHeight<T>(this T control, Double value) where T : FrameworkElement
   => control._set(() => control.MaxHeight = value);
public static T MaxHeight<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.MaxHeightProperty, binding));

public static T MaxWidth<T>(this T control, Double value) where T : FrameworkElement
   => control._set(() => control.MaxWidth = value);
public static T MaxWidth<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.MaxWidthProperty, binding));

public static T MinHeight<T>(this T control, Double value) where T : FrameworkElement
   => control._set(() => control.MinHeight = value);
public static T MinHeight<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.MinHeightProperty, binding));

public static T MinWidth<T>(this T control, Double value) where T : FrameworkElement
   => control._set(() => control.MinWidth = value);
public static T MinWidth<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.MinWidthProperty, binding));

public static T Name<T>(this T control, String value) where T : FrameworkElement
   => control._set(() => control.Name = value);
public static T Name<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.NameProperty, binding));

public static T Style<T>(this T control, Style value) where T : FrameworkElement
   => control._set(() => control.Style = value);
public static T Style<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.StyleProperty, binding));

public static T Tag<T>(this T control, Object value) where T : FrameworkElement
   => control._set(() => control.Tag = value);
public static T Tag<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.TagProperty, binding));

public static T VerticalAlignment<T>(this T control, VerticalAlignment value) where T : FrameworkElement
   => control._set(() => control.VerticalAlignment = value);
public static T VerticalAlignment<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.VerticalAlignmentProperty, binding));

public static T Width<T>(this T control, Double value) where T : FrameworkElement
   => control._set(() => control.Width = value);
public static T Width<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.WidthProperty, binding));

public static T RequestedTheme<T>(this T control, ElementTheme value) where T : FrameworkElement
   => control._set(() => control.RequestedTheme = value);
public static T RequestedTheme<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.RequestedThemeProperty, binding));

public static T AllowFocusOnInteraction<T>(this T control, Boolean value) where T : FrameworkElement
   => control._set(() => control.AllowFocusOnInteraction = value);
public static T AllowFocusOnInteraction<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.AllowFocusOnInteractionProperty, binding));

public static T AllowFocusWhenDisabled<T>(this T control, Boolean value) where T : FrameworkElement
   => control._set(() => control.AllowFocusWhenDisabled = value);
public static T AllowFocusWhenDisabled<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.AllowFocusWhenDisabledProperty, binding));

public static T FocusVisualMargin<T>(this T control, Thickness value) where T : FrameworkElement
   => control._set(() => control.FocusVisualMargin = value);
public static T FocusVisualMargin<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.FocusVisualMarginProperty, binding));

public static T FocusVisualPrimaryBrush<T>(this T control, Brush value) where T : FrameworkElement
   => control._set(() => control.FocusVisualPrimaryBrush = value);
public static T FocusVisualPrimaryBrush<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.FocusVisualPrimaryBrushProperty, binding));

public static T FocusVisualPrimaryThickness<T>(this T control, Thickness value) where T : FrameworkElement
   => control._set(() => control.FocusVisualPrimaryThickness = value);
public static T FocusVisualPrimaryThickness<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.FocusVisualPrimaryThicknessProperty, binding));

public static T FocusVisualSecondaryBrush<T>(this T control, Brush value) where T : FrameworkElement
   => control._set(() => control.FocusVisualSecondaryBrush = value);
public static T FocusVisualSecondaryBrush<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.FocusVisualSecondaryBrushProperty, binding));

public static T FocusVisualSecondaryThickness<T>(this T control, Thickness value) where T : FrameworkElement
   => control._set(() => control.FocusVisualSecondaryThickness = value);
public static T FocusVisualSecondaryThickness<T>(this T control, BindingBase binding) where T : FrameworkElement
   => control._set(() => control.SetBinding(FrameworkElement.FocusVisualSecondaryThicknessProperty, binding));

public static T BorderThickness<T>(this T control, Thickness value) where T : Control
   => control._set(() => control.BorderThickness = value);
public static T BorderThickness<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.BorderThicknessProperty, binding));

public static T FontFamily<T>(this T control, FontFamily value) where T : Control
   => control._set(() => control.FontFamily = value);
public static T FontFamily<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.FontFamilyProperty, binding));

public static T FontSize<T>(this T control, Double value) where T : Control
   => control._set(() => control.FontSize = value);
public static T FontSize<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.FontSizeProperty, binding));

public static T FontStretch<T>(this T control, FontStretch value) where T : Control
   => control._set(() => control.FontStretch = value);
public static T FontStretch<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.FontStretchProperty, binding));

public static T FontStyle<T>(this T control, FontStyle value) where T : Control
   => control._set(() => control.FontStyle = value);
public static T FontStyle<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.FontStyleProperty, binding));

public static T FontWeight<T>(this T control, FontWeight value) where T : Control
   => control._set(() => control.FontWeight = value);
public static T FontWeight<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.FontWeightProperty, binding));

public static T Foreground<T>(this T control, Brush value) where T : Control
   => control._set(() => control.Foreground = value);
public static T Foreground<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.ForegroundProperty, binding));

public static T HorizontalContentAlignment<T>(this T control, HorizontalAlignment value) where T : Control
   => control._set(() => control.HorizontalContentAlignment = value);
public static T HorizontalContentAlignment<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.HorizontalContentAlignmentProperty, binding));

public static T IsEnabled<T>(this T control, Boolean value) where T : Control
   => control._set(() => control.IsEnabled = value);
public static T IsEnabled<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.IsEnabledProperty, binding));

public static T IsTabStop<T>(this T control, Boolean value) where T : Control
   => control._set(() => control.IsTabStop = value);
public static T IsTabStop<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.IsTabStopProperty, binding));

public static T Padding<T>(this T control, Thickness value) where T : Control
   => control._set(() => control.Padding = value);
public static T Padding<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.PaddingProperty, binding));

public static T TabIndex<T>(this T control, Int32 value) where T : Control
   => control._set(() => control.TabIndex = value);
public static T TabIndex<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.TabIndexProperty, binding));

public static T TabNavigation<T>(this T control, KeyboardNavigationMode value) where T : Control
   => control._set(() => control.TabNavigation = value);
public static T TabNavigation<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.TabNavigationProperty, binding));

public static T Template<T>(this T control, ControlTemplate value) where T : Control
   => control._set(() => control.Template = value);
public static T Template<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.TemplateProperty, binding));

public static T Background<T>(this T control, Brush value) where T : Control
   => control._set(() => control.Background = value);
public static T Background<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.BackgroundProperty, binding));

public static T BorderBrush<T>(this T control, Brush value) where T : Control
   => control._set(() => control.BorderBrush = value);
public static T BorderBrush<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.BorderBrushProperty, binding));

public static T VerticalContentAlignment<T>(this T control, VerticalAlignment value) where T : Control
   => control._set(() => control.VerticalContentAlignment = value);
public static T VerticalContentAlignment<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.VerticalContentAlignmentProperty, binding));

public static T CharacterSpacing<T>(this T control, Int32 value) where T : Control
   => control._set(() => control.CharacterSpacing = value);
public static T CharacterSpacing<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.CharacterSpacingProperty, binding));

public static T IsTextScaleFactorEnabled<T>(this T control, Boolean value) where T : Control
   => control._set(() => control.IsTextScaleFactorEnabled = value);
public static T IsTextScaleFactorEnabled<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.IsTextScaleFactorEnabledProperty, binding));

public static T UseSystemFocusVisuals<T>(this T control, Boolean value) where T : Control
   => control._set(() => control.UseSystemFocusVisuals = value);
public static T UseSystemFocusVisuals<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.UseSystemFocusVisualsProperty, binding));

public static T ElementSoundMode<T>(this T control, ElementSoundMode value) where T : Control
   => control._set(() => control.ElementSoundMode = value);
public static T ElementSoundMode<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.ElementSoundModeProperty, binding));

public static T IsFocusEngaged<T>(this T control, Boolean value) where T : Control
   => control._set(() => control.IsFocusEngaged = value);
public static T IsFocusEngaged<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.IsFocusEngagedProperty, binding));

public static T IsFocusEngagementEnabled<T>(this T control, Boolean value) where T : Control
   => control._set(() => control.IsFocusEngagementEnabled = value);
public static T IsFocusEngagementEnabled<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.IsFocusEngagementEnabledProperty, binding));

public static T RequiresPointer<T>(this T control, RequiresPointer value) where T : Control
   => control._set(() => control.RequiresPointer = value);
public static T RequiresPointer<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.RequiresPointerProperty, binding));

public static T XYFocusDown<T>(this T control, DependencyObject value) where T : Control
   => control._set(() => control.XYFocusDown = value);
public static T XYFocusDown<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.XYFocusDownProperty, binding));

public static T XYFocusLeft<T>(this T control, DependencyObject value) where T : Control
   => control._set(() => control.XYFocusLeft = value);
public static T XYFocusLeft<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.XYFocusLeftProperty, binding));

public static T XYFocusRight<T>(this T control, DependencyObject value) where T : Control
   => control._set(() => control.XYFocusRight = value);
public static T XYFocusRight<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.XYFocusRightProperty, binding));

public static T XYFocusUp<T>(this T control, DependencyObject value) where T : Control
   => control._set(() => control.XYFocusUp = value);
public static T XYFocusUp<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.XYFocusUpProperty, binding));

public static T DefaultStyleResourceUri<T>(this T control, Uri value) where T : Control
   => control._set(() => control.DefaultStyleResourceUri = value);
public static T DefaultStyleResourceUri<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.DefaultStyleResourceUriProperty, binding));

public static T CornerRadius<T>(this T control, CornerRadius value) where T : Control
   => control._set(() => control.CornerRadius = value);
public static T CornerRadius<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.CornerRadiusProperty, binding));

public static T BackgroundSizing<T>(this T control, BackgroundSizing value) where T : Control
   => control._set(() => control.BackgroundSizing = value);
public static T BackgroundSizing<T>(this T control, BindingBase binding) where T : Control
   => control._set(() => control.SetBinding(Control.BackgroundSizingProperty, binding));

public static ContentControl Content(this ContentControl control, Object value)
   => control._set(() => control.Content = value);
public static ContentControl Content(this ContentControl control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentControl.ContentProperty, binding));

public static ContentControl ContentTemplate(this ContentControl control, DataTemplate value)
   => control._set(() => control.ContentTemplate = value);
public static ContentControl ContentTemplate(this ContentControl control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentControl.ContentTemplateProperty, binding));

public static ContentControl ContentTemplateSelector(this ContentControl control, DataTemplateSelector value)
   => control._set(() => control.ContentTemplateSelector = value);
public static ContentControl ContentTemplateSelector(this ContentControl control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentControl.ContentTemplateSelectorProperty, binding));

public static ContentControl ContentTransitions(this ContentControl control, TransitionCollection value)
   => control._set(() => control.ContentTransitions = value);
public static ContentControl ContentTransitions(this ContentControl control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentControl.ContentTransitionsProperty, binding));

public static AppBar IsOpen(this AppBar control, Boolean value)
   => control._set(() => control.IsOpen = value);
public static AppBar IsOpen(this AppBar control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBar.IsOpenProperty, binding));

public static AppBar IsSticky(this AppBar control, Boolean value)
   => control._set(() => control.IsSticky = value);
public static AppBar IsSticky(this AppBar control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBar.IsStickyProperty, binding));

public static AppBar ClosedDisplayMode(this AppBar control, AppBarClosedDisplayMode value)
   => control._set(() => control.ClosedDisplayMode = value);
public static AppBar ClosedDisplayMode(this AppBar control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBar.ClosedDisplayModeProperty, binding));

public static AppBar LightDismissOverlayMode(this AppBar control, LightDismissOverlayMode value)
   => control._set(() => control.LightDismissOverlayMode = value);
public static AppBar LightDismissOverlayMode(this AppBar control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBar.LightDismissOverlayModeProperty, binding));

public static ButtonBase ClickMode(this ButtonBase control, ClickMode value)
   => control._set(() => control.ClickMode = value);
public static ButtonBase ClickMode(this ButtonBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ButtonBase.ClickModeProperty, binding));

public static ButtonBase CommandParameter(this ButtonBase control, Object value)
   => control._set(() => control.CommandParameter = value);
public static ButtonBase CommandParameter(this ButtonBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ButtonBase.CommandParameterProperty, binding));

public static ButtonBase Command(this ButtonBase control, ICommand value)
   => control._set(() => control.Command = value);
public static ButtonBase Command(this ButtonBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ButtonBase.CommandProperty, binding));

public static Button Flyout(this Button control, FlyoutBase value)
   => control._set(() => control.Flyout = value);
public static Button Flyout(this Button control, BindingBase binding)
   => control._set(() => control.SetBinding(Button.FlyoutProperty, binding));

public static AppBarButton Icon(this AppBarButton control, IconElement value)
   => control._set(() => control.Icon = value);
public static AppBarButton Icon(this AppBarButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarButton.IconProperty, binding));

public static AppBarButton IsCompact(this AppBarButton control, Boolean value)
   => control._set(() => control.IsCompact = value);
public static AppBarButton IsCompact(this AppBarButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarButton.IsCompactProperty, binding));

public static AppBarButton Label(this AppBarButton control, String value)
   => control._set(() => control.Label = value);
public static AppBarButton Label(this AppBarButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarButton.LabelProperty, binding));

public static AppBarButton DynamicOverflowOrder(this AppBarButton control, Int32 value)
   => control._set(() => control.DynamicOverflowOrder = value);
public static AppBarButton DynamicOverflowOrder(this AppBarButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarButton.DynamicOverflowOrderProperty, binding));

public static AppBarButton LabelPosition(this AppBarButton control, CommandBarLabelPosition value)
   => control._set(() => control.LabelPosition = value);
public static AppBarButton LabelPosition(this AppBarButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarButton.LabelPositionProperty, binding));

public static AppBarButton KeyboardAcceleratorTextOverride(this AppBarButton control, String value)
   => control._set(() => control.KeyboardAcceleratorTextOverride = value);
public static AppBarButton KeyboardAcceleratorTextOverride(this AppBarButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarButton.KeyboardAcceleratorTextOverrideProperty, binding));

public static AppBarElementContainer DynamicOverflowOrder(this AppBarElementContainer control, Int32 value)
   => control._set(() => control.DynamicOverflowOrder = value);
public static AppBarElementContainer DynamicOverflowOrder(this AppBarElementContainer control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarElementContainer.DynamicOverflowOrderProperty, binding));

public static AppBarElementContainer IsCompact(this AppBarElementContainer control, Boolean value)
   => control._set(() => control.IsCompact = value);
public static AppBarElementContainer IsCompact(this AppBarElementContainer control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarElementContainer.IsCompactProperty, binding));

public static AppBarSeparator IsCompact(this AppBarSeparator control, Boolean value)
   => control._set(() => control.IsCompact = value);
public static AppBarSeparator IsCompact(this AppBarSeparator control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarSeparator.IsCompactProperty, binding));

public static AppBarSeparator DynamicOverflowOrder(this AppBarSeparator control, Int32 value)
   => control._set(() => control.DynamicOverflowOrder = value);
public static AppBarSeparator DynamicOverflowOrder(this AppBarSeparator control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarSeparator.DynamicOverflowOrderProperty, binding));

public static ToggleButton IsChecked(this ToggleButton control, Nullable<Boolean> value)
   => control._set(() => control.IsChecked = value);
public static ToggleButton IsChecked(this ToggleButton control, BindingBase binding)
   => control._set(() => control.SetBinding(ToggleButton.IsCheckedProperty, binding));

public static ToggleButton IsThreeState(this ToggleButton control, Boolean value)
   => control._set(() => control.IsThreeState = value);
public static ToggleButton IsThreeState(this ToggleButton control, BindingBase binding)
   => control._set(() => control.SetBinding(ToggleButton.IsThreeStateProperty, binding));

public static AppBarToggleButton Icon(this AppBarToggleButton control, IconElement value)
   => control._set(() => control.Icon = value);
public static AppBarToggleButton Icon(this AppBarToggleButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarToggleButton.IconProperty, binding));

public static AppBarToggleButton IsCompact(this AppBarToggleButton control, Boolean value)
   => control._set(() => control.IsCompact = value);
public static AppBarToggleButton IsCompact(this AppBarToggleButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarToggleButton.IsCompactProperty, binding));

public static AppBarToggleButton Label(this AppBarToggleButton control, String value)
   => control._set(() => control.Label = value);
public static AppBarToggleButton Label(this AppBarToggleButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarToggleButton.LabelProperty, binding));

public static AppBarToggleButton DynamicOverflowOrder(this AppBarToggleButton control, Int32 value)
   => control._set(() => control.DynamicOverflowOrder = value);
public static AppBarToggleButton DynamicOverflowOrder(this AppBarToggleButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarToggleButton.DynamicOverflowOrderProperty, binding));

public static AppBarToggleButton LabelPosition(this AppBarToggleButton control, CommandBarLabelPosition value)
   => control._set(() => control.LabelPosition = value);
public static AppBarToggleButton LabelPosition(this AppBarToggleButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarToggleButton.LabelPositionProperty, binding));

public static AppBarToggleButton KeyboardAcceleratorTextOverride(this AppBarToggleButton control, String value)
   => control._set(() => control.KeyboardAcceleratorTextOverride = value);
public static AppBarToggleButton KeyboardAcceleratorTextOverride(this AppBarToggleButton control, BindingBase binding)
   => control._set(() => control.SetBinding(AppBarToggleButton.KeyboardAcceleratorTextOverrideProperty, binding));

public static T DisplayMemberPath<T>(this T control, String value) where T : ItemsControl
   => control._set(() => control.DisplayMemberPath = value);
public static T DisplayMemberPath<T>(this T control, BindingBase binding) where T : ItemsControl
   => control._set(() => control.SetBinding(ItemsControl.DisplayMemberPathProperty, binding));

public static T GroupStyleSelector<T>(this T control, GroupStyleSelector value) where T : ItemsControl
   => control._set(() => control.GroupStyleSelector = value);
public static T GroupStyleSelector<T>(this T control, BindingBase binding) where T : ItemsControl
   => control._set(() => control.SetBinding(ItemsControl.GroupStyleSelectorProperty, binding));

public static T ItemContainerStyle<T>(this T control, Style value) where T : ItemsControl
   => control._set(() => control.ItemContainerStyle = value);
public static T ItemContainerStyle<T>(this T control, BindingBase binding) where T : ItemsControl
   => control._set(() => control.SetBinding(ItemsControl.ItemContainerStyleProperty, binding));

public static T ItemContainerStyleSelector<T>(this T control, StyleSelector value) where T : ItemsControl
   => control._set(() => control.ItemContainerStyleSelector = value);
public static T ItemContainerStyleSelector<T>(this T control, BindingBase binding) where T : ItemsControl
   => control._set(() => control.SetBinding(ItemsControl.ItemContainerStyleSelectorProperty, binding));

public static T ItemContainerTransitions<T>(this T control, TransitionCollection value) where T : ItemsControl
   => control._set(() => control.ItemContainerTransitions = value);
public static T ItemContainerTransitions<T>(this T control, BindingBase binding) where T : ItemsControl
   => control._set(() => control.SetBinding(ItemsControl.ItemContainerTransitionsProperty, binding));

public static T ItemTemplate<T>(this T control, DataTemplate value) where T : ItemsControl
   => control._set(() => control.ItemTemplate = value);
public static T ItemTemplate<T>(this T control, BindingBase binding) where T : ItemsControl
   => control._set(() => control.SetBinding(ItemsControl.ItemTemplateProperty, binding));

public static T ItemTemplateSelector<T>(this T control, DataTemplateSelector value) where T : ItemsControl
   => control._set(() => control.ItemTemplateSelector = value);
public static T ItemTemplateSelector<T>(this T control, BindingBase binding) where T : ItemsControl
   => control._set(() => control.SetBinding(ItemsControl.ItemTemplateSelectorProperty, binding));

public static T ItemsPanel<T>(this T control, ItemsPanelTemplate value) where T : ItemsControl
   => control._set(() => control.ItemsPanel = value);
public static T ItemsPanel<T>(this T control, BindingBase binding) where T : ItemsControl
   => control._set(() => control.SetBinding(ItemsControl.ItemsPanelProperty, binding));

public static T ItemsSource<T>(this T control, Object value) where T : ItemsControl
   => control._set(() => control.ItemsSource = value);
public static T ItemsSource<T>(this T control, BindingBase binding) where T : ItemsControl
   => control._set(() => control.SetBinding(ItemsControl.ItemsSourceProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox AutoMaximizeSuggestionArea(this Windows.UI.Xaml.Controls.AutoSuggestBox control, Boolean value)
   => control._set(() => control.AutoMaximizeSuggestionArea = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox AutoMaximizeSuggestionArea(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.AutoMaximizeSuggestionAreaProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox Header(this Windows.UI.Xaml.Controls.AutoSuggestBox control, Object value)
   => control._set(() => control.Header = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox Header(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.HeaderProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox IsSuggestionListOpen(this Windows.UI.Xaml.Controls.AutoSuggestBox control, Boolean value)
   => control._set(() => control.IsSuggestionListOpen = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox IsSuggestionListOpen(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.IsSuggestionListOpenProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox MaxSuggestionListHeight(this Windows.UI.Xaml.Controls.AutoSuggestBox control, Double value)
   => control._set(() => control.MaxSuggestionListHeight = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox MaxSuggestionListHeight(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.MaxSuggestionListHeightProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox PlaceholderText(this Windows.UI.Xaml.Controls.AutoSuggestBox control, String value)
   => control._set(() => control.PlaceholderText = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox PlaceholderText(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.PlaceholderTextProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox TextBoxStyle(this Windows.UI.Xaml.Controls.AutoSuggestBox control, Style value)
   => control._set(() => control.TextBoxStyle = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox TextBoxStyle(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.TextBoxStyleProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox TextMemberPath(this Windows.UI.Xaml.Controls.AutoSuggestBox control, String value)
   => control._set(() => control.TextMemberPath = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox TextMemberPath(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.TextMemberPathProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox Text(this Windows.UI.Xaml.Controls.AutoSuggestBox control, String value)
   => control._set(() => control.Text = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox Text(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.TextProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox UpdateTextOnSelect(this Windows.UI.Xaml.Controls.AutoSuggestBox control, Boolean value)
   => control._set(() => control.UpdateTextOnSelect = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox UpdateTextOnSelect(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.UpdateTextOnSelectProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox QueryIcon(this Windows.UI.Xaml.Controls.AutoSuggestBox control, IconElement value)
   => control._set(() => control.QueryIcon = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox QueryIcon(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.QueryIconProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox LightDismissOverlayMode(this Windows.UI.Xaml.Controls.AutoSuggestBox control, LightDismissOverlayMode value)
   => control._set(() => control.LightDismissOverlayMode = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox LightDismissOverlayMode(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.LightDismissOverlayModeProperty, binding));

public static Windows.UI.Xaml.Controls.AutoSuggestBox Description(this Windows.UI.Xaml.Controls.AutoSuggestBox control, Object value)
   => control._set(() => control.Description = value);
public static Windows.UI.Xaml.Controls.AutoSuggestBox Description(this Windows.UI.Xaml.Controls.AutoSuggestBox control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.AutoSuggestBox.DescriptionProperty, binding));

public static IconElement Foreground(this IconElement control, Brush value)
   => control._set(() => control.Foreground = value);
public static IconElement Foreground(this IconElement control, BindingBase binding)
   => control._set(() => control.SetBinding(IconElement.ForegroundProperty, binding));

public static BitmapIcon UriSource(this BitmapIcon control, Uri value)
   => control._set(() => control.UriSource = value);
public static BitmapIcon UriSource(this BitmapIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(BitmapIcon.UriSourceProperty, binding));

public static BitmapIcon ShowAsMonochrome(this BitmapIcon control, Boolean value)
   => control._set(() => control.ShowAsMonochrome = value);
public static BitmapIcon ShowAsMonochrome(this BitmapIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(BitmapIcon.ShowAsMonochromeProperty, binding));

public static Border Background(this Border control, Brush value)
   => control._set(() => control.Background = value);
public static Border Background(this Border control, BindingBase binding)
   => control._set(() => control.SetBinding(Border.BackgroundProperty, binding));

public static Border BorderBrush(this Border control, Brush value)
   => control._set(() => control.BorderBrush = value);
public static Border BorderBrush(this Border control, BindingBase binding)
   => control._set(() => control.SetBinding(Border.BorderBrushProperty, binding));

public static Border BorderThickness(this Border control, Thickness value)
   => control._set(() => control.BorderThickness = value);
public static Border BorderThickness(this Border control, BindingBase binding)
   => control._set(() => control.SetBinding(Border.BorderThicknessProperty, binding));

public static Border ChildTransitions(this Border control, TransitionCollection value)
   => control._set(() => control.ChildTransitions = value);
public static Border ChildTransitions(this Border control, BindingBase binding)
   => control._set(() => control.SetBinding(Border.ChildTransitionsProperty, binding));

public static Border CornerRadius(this Border control, CornerRadius value)
   => control._set(() => control.CornerRadius = value);
public static Border CornerRadius(this Border control, BindingBase binding)
   => control._set(() => control.SetBinding(Border.CornerRadiusProperty, binding));

public static Border Padding(this Border control, Thickness value)
   => control._set(() => control.Padding = value);
public static Border Padding(this Border control, BindingBase binding)
   => control._set(() => control.SetBinding(Border.PaddingProperty, binding));

public static Border BackgroundSizing(this Border control, BackgroundSizing value)
   => control._set(() => control.BackgroundSizing = value);
public static Border BackgroundSizing(this Border control, BindingBase binding)
   => control._set(() => control.SetBinding(Border.BackgroundSizingProperty, binding));

public static CalendarDatePicker CalendarIdentifier(this CalendarDatePicker control, String value)
   => control._set(() => control.CalendarIdentifier = value);
public static CalendarDatePicker CalendarIdentifier(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.CalendarIdentifierProperty, binding));

public static CalendarDatePicker CalendarViewStyle(this CalendarDatePicker control, Style value)
   => control._set(() => control.CalendarViewStyle = value);
public static CalendarDatePicker CalendarViewStyle(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.CalendarViewStyleProperty, binding));

public static CalendarDatePicker DateFormat(this CalendarDatePicker control, String value)
   => control._set(() => control.DateFormat = value);
public static CalendarDatePicker DateFormat(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.DateFormatProperty, binding));

public static CalendarDatePicker Date(this CalendarDatePicker control, Nullable<DateTimeOffset> value)
   => control._set(() => control.Date = value);
public static CalendarDatePicker Date(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.DateProperty, binding));

public static CalendarDatePicker DayOfWeekFormat(this CalendarDatePicker control, String value)
   => control._set(() => control.DayOfWeekFormat = value);
public static CalendarDatePicker DayOfWeekFormat(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.DayOfWeekFormatProperty, binding));

public static CalendarDatePicker DisplayMode(this CalendarDatePicker control, CalendarViewDisplayMode value)
   => control._set(() => control.DisplayMode = value);
public static CalendarDatePicker DisplayMode(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.DisplayModeProperty, binding));

public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, Windows.Globalization.DayOfWeek value)
   => control._set(() => control.FirstDayOfWeek = value);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.FirstDayOfWeekProperty, binding));

public static CalendarDatePicker Header(this CalendarDatePicker control, Object value)
   => control._set(() => control.Header = value);
public static CalendarDatePicker Header(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.HeaderProperty, binding));

public static CalendarDatePicker HeaderTemplate(this CalendarDatePicker control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static CalendarDatePicker HeaderTemplate(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.HeaderTemplateProperty, binding));

public static CalendarDatePicker IsCalendarOpen(this CalendarDatePicker control, Boolean value)
   => control._set(() => control.IsCalendarOpen = value);
public static CalendarDatePicker IsCalendarOpen(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.IsCalendarOpenProperty, binding));

public static CalendarDatePicker IsGroupLabelVisible(this CalendarDatePicker control, Boolean value)
   => control._set(() => control.IsGroupLabelVisible = value);
public static CalendarDatePicker IsGroupLabelVisible(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.IsGroupLabelVisibleProperty, binding));

public static CalendarDatePicker IsOutOfScopeEnabled(this CalendarDatePicker control, Boolean value)
   => control._set(() => control.IsOutOfScopeEnabled = value);
public static CalendarDatePicker IsOutOfScopeEnabled(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.IsOutOfScopeEnabledProperty, binding));

public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, Boolean value)
   => control._set(() => control.IsTodayHighlighted = value);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.IsTodayHighlightedProperty, binding));

public static CalendarDatePicker MaxDate(this CalendarDatePicker control, DateTimeOffset value)
   => control._set(() => control.MaxDate = value);
public static CalendarDatePicker MaxDate(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.MaxDateProperty, binding));

public static CalendarDatePicker MinDate(this CalendarDatePicker control, DateTimeOffset value)
   => control._set(() => control.MinDate = value);
public static CalendarDatePicker MinDate(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.MinDateProperty, binding));

public static CalendarDatePicker PlaceholderText(this CalendarDatePicker control, String value)
   => control._set(() => control.PlaceholderText = value);
public static CalendarDatePicker PlaceholderText(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.PlaceholderTextProperty, binding));

public static CalendarDatePicker LightDismissOverlayMode(this CalendarDatePicker control, LightDismissOverlayMode value)
   => control._set(() => control.LightDismissOverlayMode = value);
public static CalendarDatePicker LightDismissOverlayMode(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.LightDismissOverlayModeProperty, binding));

public static CalendarDatePicker Description(this CalendarDatePicker control, Object value)
   => control._set(() => control.Description = value);
public static CalendarDatePicker Description(this CalendarDatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarDatePicker.DescriptionProperty, binding));

public static CalendarView BlackoutForeground(this CalendarView control, Brush value)
   => control._set(() => control.BlackoutForeground = value);
public static CalendarView BlackoutForeground(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.BlackoutForegroundProperty, binding));

public static CalendarView CalendarIdentifier(this CalendarView control, String value)
   => control._set(() => control.CalendarIdentifier = value);
public static CalendarView CalendarIdentifier(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.CalendarIdentifierProperty, binding));

public static CalendarView CalendarItemBackground(this CalendarView control, Brush value)
   => control._set(() => control.CalendarItemBackground = value);
public static CalendarView CalendarItemBackground(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.CalendarItemBackgroundProperty, binding));

public static CalendarView CalendarItemBorderBrush(this CalendarView control, Brush value)
   => control._set(() => control.CalendarItemBorderBrush = value);
public static CalendarView CalendarItemBorderBrush(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.CalendarItemBorderBrushProperty, binding));

public static CalendarView CalendarItemBorderThickness(this CalendarView control, Thickness value)
   => control._set(() => control.CalendarItemBorderThickness = value);
public static CalendarView CalendarItemBorderThickness(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.CalendarItemBorderThicknessProperty, binding));

public static CalendarView CalendarItemForeground(this CalendarView control, Brush value)
   => control._set(() => control.CalendarItemForeground = value);
public static CalendarView CalendarItemForeground(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.CalendarItemForegroundProperty, binding));

public static CalendarView CalendarViewDayItemStyle(this CalendarView control, Style value)
   => control._set(() => control.CalendarViewDayItemStyle = value);
public static CalendarView CalendarViewDayItemStyle(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.CalendarViewDayItemStyleProperty, binding));

public static CalendarView DayItemFontFamily(this CalendarView control, FontFamily value)
   => control._set(() => control.DayItemFontFamily = value);
public static CalendarView DayItemFontFamily(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.DayItemFontFamilyProperty, binding));

public static CalendarView DayItemFontSize(this CalendarView control, Double value)
   => control._set(() => control.DayItemFontSize = value);
public static CalendarView DayItemFontSize(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.DayItemFontSizeProperty, binding));

public static CalendarView DayItemFontStyle(this CalendarView control, FontStyle value)
   => control._set(() => control.DayItemFontStyle = value);
public static CalendarView DayItemFontStyle(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.DayItemFontStyleProperty, binding));

public static CalendarView DayItemFontWeight(this CalendarView control, FontWeight value)
   => control._set(() => control.DayItemFontWeight = value);
public static CalendarView DayItemFontWeight(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.DayItemFontWeightProperty, binding));

public static CalendarView DayOfWeekFormat(this CalendarView control, String value)
   => control._set(() => control.DayOfWeekFormat = value);
public static CalendarView DayOfWeekFormat(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.DayOfWeekFormatProperty, binding));

public static CalendarView DisplayMode(this CalendarView control, CalendarViewDisplayMode value)
   => control._set(() => control.DisplayMode = value);
public static CalendarView DisplayMode(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.DisplayModeProperty, binding));

public static CalendarView FirstDayOfWeek(this CalendarView control, Windows.Globalization.DayOfWeek value)
   => control._set(() => control.FirstDayOfWeek = value);
public static CalendarView FirstDayOfWeek(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.FirstDayOfWeekProperty, binding));

public static CalendarView FirstOfMonthLabelFontFamily(this CalendarView control, FontFamily value)
   => control._set(() => control.FirstOfMonthLabelFontFamily = value);
public static CalendarView FirstOfMonthLabelFontFamily(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.FirstOfMonthLabelFontFamilyProperty, binding));

public static CalendarView FirstOfMonthLabelFontSize(this CalendarView control, Double value)
   => control._set(() => control.FirstOfMonthLabelFontSize = value);
public static CalendarView FirstOfMonthLabelFontSize(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.FirstOfMonthLabelFontSizeProperty, binding));

public static CalendarView FirstOfMonthLabelFontStyle(this CalendarView control, FontStyle value)
   => control._set(() => control.FirstOfMonthLabelFontStyle = value);
public static CalendarView FirstOfMonthLabelFontStyle(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.FirstOfMonthLabelFontStyleProperty, binding));

public static CalendarView FirstOfMonthLabelFontWeight(this CalendarView control, FontWeight value)
   => control._set(() => control.FirstOfMonthLabelFontWeight = value);
public static CalendarView FirstOfMonthLabelFontWeight(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.FirstOfMonthLabelFontWeightProperty, binding));

public static CalendarView FirstOfYearDecadeLabelFontFamily(this CalendarView control, FontFamily value)
   => control._set(() => control.FirstOfYearDecadeLabelFontFamily = value);
public static CalendarView FirstOfYearDecadeLabelFontFamily(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.FirstOfYearDecadeLabelFontFamilyProperty, binding));

public static CalendarView FirstOfYearDecadeLabelFontSize(this CalendarView control, Double value)
   => control._set(() => control.FirstOfYearDecadeLabelFontSize = value);
public static CalendarView FirstOfYearDecadeLabelFontSize(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.FirstOfYearDecadeLabelFontSizeProperty, binding));

public static CalendarView FirstOfYearDecadeLabelFontStyle(this CalendarView control, FontStyle value)
   => control._set(() => control.FirstOfYearDecadeLabelFontStyle = value);
public static CalendarView FirstOfYearDecadeLabelFontStyle(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.FirstOfYearDecadeLabelFontStyleProperty, binding));

public static CalendarView FirstOfYearDecadeLabelFontWeight(this CalendarView control, FontWeight value)
   => control._set(() => control.FirstOfYearDecadeLabelFontWeight = value);
public static CalendarView FirstOfYearDecadeLabelFontWeight(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.FirstOfYearDecadeLabelFontWeightProperty, binding));

public static CalendarView FocusBorderBrush(this CalendarView control, Brush value)
   => control._set(() => control.FocusBorderBrush = value);
public static CalendarView FocusBorderBrush(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.FocusBorderBrushProperty, binding));

public static CalendarView HorizontalDayItemAlignment(this CalendarView control, HorizontalAlignment value)
   => control._set(() => control.HorizontalDayItemAlignment = value);
public static CalendarView HorizontalDayItemAlignment(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.HorizontalDayItemAlignmentProperty, binding));

public static CalendarView HorizontalFirstOfMonthLabelAlignment(this CalendarView control, HorizontalAlignment value)
   => control._set(() => control.HorizontalFirstOfMonthLabelAlignment = value);
public static CalendarView HorizontalFirstOfMonthLabelAlignment(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.HorizontalFirstOfMonthLabelAlignmentProperty, binding));

public static CalendarView HoverBorderBrush(this CalendarView control, Brush value)
   => control._set(() => control.HoverBorderBrush = value);
public static CalendarView HoverBorderBrush(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.HoverBorderBrushProperty, binding));

public static CalendarView IsGroupLabelVisible(this CalendarView control, Boolean value)
   => control._set(() => control.IsGroupLabelVisible = value);
public static CalendarView IsGroupLabelVisible(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.IsGroupLabelVisibleProperty, binding));

public static CalendarView IsOutOfScopeEnabled(this CalendarView control, Boolean value)
   => control._set(() => control.IsOutOfScopeEnabled = value);
public static CalendarView IsOutOfScopeEnabled(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.IsOutOfScopeEnabledProperty, binding));

public static CalendarView IsTodayHighlighted(this CalendarView control, Boolean value)
   => control._set(() => control.IsTodayHighlighted = value);
public static CalendarView IsTodayHighlighted(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.IsTodayHighlightedProperty, binding));

public static CalendarView MaxDate(this CalendarView control, DateTimeOffset value)
   => control._set(() => control.MaxDate = value);
public static CalendarView MaxDate(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.MaxDateProperty, binding));

public static CalendarView MinDate(this CalendarView control, DateTimeOffset value)
   => control._set(() => control.MinDate = value);
public static CalendarView MinDate(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.MinDateProperty, binding));

public static CalendarView MonthYearItemFontFamily(this CalendarView control, FontFamily value)
   => control._set(() => control.MonthYearItemFontFamily = value);
public static CalendarView MonthYearItemFontFamily(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.MonthYearItemFontFamilyProperty, binding));

public static CalendarView MonthYearItemFontSize(this CalendarView control, Double value)
   => control._set(() => control.MonthYearItemFontSize = value);
public static CalendarView MonthYearItemFontSize(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.MonthYearItemFontSizeProperty, binding));

public static CalendarView MonthYearItemFontStyle(this CalendarView control, FontStyle value)
   => control._set(() => control.MonthYearItemFontStyle = value);
public static CalendarView MonthYearItemFontStyle(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.MonthYearItemFontStyleProperty, binding));

public static CalendarView MonthYearItemFontWeight(this CalendarView control, FontWeight value)
   => control._set(() => control.MonthYearItemFontWeight = value);
public static CalendarView MonthYearItemFontWeight(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.MonthYearItemFontWeightProperty, binding));

public static CalendarView NumberOfWeeksInView(this CalendarView control, Int32 value)
   => control._set(() => control.NumberOfWeeksInView = value);
public static CalendarView NumberOfWeeksInView(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.NumberOfWeeksInViewProperty, binding));

public static CalendarView OutOfScopeBackground(this CalendarView control, Brush value)
   => control._set(() => control.OutOfScopeBackground = value);
public static CalendarView OutOfScopeBackground(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.OutOfScopeBackgroundProperty, binding));

public static CalendarView OutOfScopeForeground(this CalendarView control, Brush value)
   => control._set(() => control.OutOfScopeForeground = value);
public static CalendarView OutOfScopeForeground(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.OutOfScopeForegroundProperty, binding));

public static CalendarView PressedBorderBrush(this CalendarView control, Brush value)
   => control._set(() => control.PressedBorderBrush = value);
public static CalendarView PressedBorderBrush(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.PressedBorderBrushProperty, binding));

public static CalendarView PressedForeground(this CalendarView control, Brush value)
   => control._set(() => control.PressedForeground = value);
public static CalendarView PressedForeground(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.PressedForegroundProperty, binding));

public static CalendarView SelectedBorderBrush(this CalendarView control, Brush value)
   => control._set(() => control.SelectedBorderBrush = value);
public static CalendarView SelectedBorderBrush(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.SelectedBorderBrushProperty, binding));

public static CalendarView SelectedForeground(this CalendarView control, Brush value)
   => control._set(() => control.SelectedForeground = value);
public static CalendarView SelectedForeground(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.SelectedForegroundProperty, binding));

public static CalendarView SelectedHoverBorderBrush(this CalendarView control, Brush value)
   => control._set(() => control.SelectedHoverBorderBrush = value);
public static CalendarView SelectedHoverBorderBrush(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.SelectedHoverBorderBrushProperty, binding));

public static CalendarView SelectedPressedBorderBrush(this CalendarView control, Brush value)
   => control._set(() => control.SelectedPressedBorderBrush = value);
public static CalendarView SelectedPressedBorderBrush(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.SelectedPressedBorderBrushProperty, binding));

public static CalendarView SelectionMode(this CalendarView control, CalendarViewSelectionMode value)
   => control._set(() => control.SelectionMode = value);
public static CalendarView SelectionMode(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.SelectionModeProperty, binding));

public static CalendarView TodayFontWeight(this CalendarView control, FontWeight value)
   => control._set(() => control.TodayFontWeight = value);
public static CalendarView TodayFontWeight(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.TodayFontWeightProperty, binding));

public static CalendarView TodayForeground(this CalendarView control, Brush value)
   => control._set(() => control.TodayForeground = value);
public static CalendarView TodayForeground(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.TodayForegroundProperty, binding));

public static CalendarView VerticalDayItemAlignment(this CalendarView control, VerticalAlignment value)
   => control._set(() => control.VerticalDayItemAlignment = value);
public static CalendarView VerticalDayItemAlignment(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.VerticalDayItemAlignmentProperty, binding));

public static CalendarView VerticalFirstOfMonthLabelAlignment(this CalendarView control, VerticalAlignment value)
   => control._set(() => control.VerticalFirstOfMonthLabelAlignment = value);
public static CalendarView VerticalFirstOfMonthLabelAlignment(this CalendarView control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarView.VerticalFirstOfMonthLabelAlignmentProperty, binding));

public static CalendarViewDayItem IsBlackout(this CalendarViewDayItem control, Boolean value)
   => control._set(() => control.IsBlackout = value);
public static CalendarViewDayItem IsBlackout(this CalendarViewDayItem control, BindingBase binding)
   => control._set(() => control.SetBinding(CalendarViewDayItem.IsBlackoutProperty, binding));

public static Panel Background(this Panel control, Brush value)
   => control._set(() => control.Background = value);
public static Panel Background(this Panel control, BindingBase binding)
   => control._set(() => control.SetBinding(Panel.BackgroundProperty, binding));

public static Panel ChildrenTransitions(this Panel control, TransitionCollection value)
   => control._set(() => control.ChildrenTransitions = value);
public static Panel ChildrenTransitions(this Panel control, BindingBase binding)
   => control._set(() => control.SetBinding(Panel.ChildrenTransitionsProperty, binding));

public static CaptureElement Source(this CaptureElement control, MediaCapture value)
   => control._set(() => control.Source = value);
public static CaptureElement Source(this CaptureElement control, BindingBase binding)
   => control._set(() => control.SetBinding(CaptureElement.SourceProperty, binding));

public static CaptureElement Stretch(this CaptureElement control, Stretch value)
   => control._set(() => control.Stretch = value);
public static CaptureElement Stretch(this CaptureElement control, BindingBase binding)
   => control._set(() => control.SetBinding(CaptureElement.StretchProperty, binding));

public static ColorPicker Color(this ColorPicker control, Color value)
   => control._set(() => control.Color = value);
public static ColorPicker Color(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.ColorProperty, binding));

public static ColorPicker ColorSpectrumComponents(this ColorPicker control, ColorSpectrumComponents value)
   => control._set(() => control.ColorSpectrumComponents = value);
public static ColorPicker ColorSpectrumComponents(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.ColorSpectrumComponentsProperty, binding));

public static ColorPicker ColorSpectrumShape(this ColorPicker control, ColorSpectrumShape value)
   => control._set(() => control.ColorSpectrumShape = value);
public static ColorPicker ColorSpectrumShape(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.ColorSpectrumShapeProperty, binding));

public static ColorPicker IsAlphaEnabled(this ColorPicker control, Boolean value)
   => control._set(() => control.IsAlphaEnabled = value);
public static ColorPicker IsAlphaEnabled(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.IsAlphaEnabledProperty, binding));

public static ColorPicker IsAlphaSliderVisible(this ColorPicker control, Boolean value)
   => control._set(() => control.IsAlphaSliderVisible = value);
public static ColorPicker IsAlphaSliderVisible(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.IsAlphaSliderVisibleProperty, binding));

public static ColorPicker IsAlphaTextInputVisible(this ColorPicker control, Boolean value)
   => control._set(() => control.IsAlphaTextInputVisible = value);
public static ColorPicker IsAlphaTextInputVisible(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.IsAlphaTextInputVisibleProperty, binding));

public static ColorPicker IsColorChannelTextInputVisible(this ColorPicker control, Boolean value)
   => control._set(() => control.IsColorChannelTextInputVisible = value);
public static ColorPicker IsColorChannelTextInputVisible(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.IsColorChannelTextInputVisibleProperty, binding));

public static ColorPicker IsColorPreviewVisible(this ColorPicker control, Boolean value)
   => control._set(() => control.IsColorPreviewVisible = value);
public static ColorPicker IsColorPreviewVisible(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.IsColorPreviewVisibleProperty, binding));

public static ColorPicker IsColorSliderVisible(this ColorPicker control, Boolean value)
   => control._set(() => control.IsColorSliderVisible = value);
public static ColorPicker IsColorSliderVisible(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.IsColorSliderVisibleProperty, binding));

public static ColorPicker IsColorSpectrumVisible(this ColorPicker control, Boolean value)
   => control._set(() => control.IsColorSpectrumVisible = value);
public static ColorPicker IsColorSpectrumVisible(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.IsColorSpectrumVisibleProperty, binding));

public static ColorPicker IsHexInputVisible(this ColorPicker control, Boolean value)
   => control._set(() => control.IsHexInputVisible = value);
public static ColorPicker IsHexInputVisible(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.IsHexInputVisibleProperty, binding));

public static ColorPicker IsMoreButtonVisible(this ColorPicker control, Boolean value)
   => control._set(() => control.IsMoreButtonVisible = value);
public static ColorPicker IsMoreButtonVisible(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.IsMoreButtonVisibleProperty, binding));

public static ColorPicker MaxHue(this ColorPicker control, Int32 value)
   => control._set(() => control.MaxHue = value);
public static ColorPicker MaxHue(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.MaxHueProperty, binding));

public static ColorPicker MaxSaturation(this ColorPicker control, Int32 value)
   => control._set(() => control.MaxSaturation = value);
public static ColorPicker MaxSaturation(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.MaxSaturationProperty, binding));

public static ColorPicker MaxValue(this ColorPicker control, Int32 value)
   => control._set(() => control.MaxValue = value);
public static ColorPicker MaxValue(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.MaxValueProperty, binding));

public static ColorPicker MinHue(this ColorPicker control, Int32 value)
   => control._set(() => control.MinHue = value);
public static ColorPicker MinHue(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.MinHueProperty, binding));

public static ColorPicker MinSaturation(this ColorPicker control, Int32 value)
   => control._set(() => control.MinSaturation = value);
public static ColorPicker MinSaturation(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.MinSaturationProperty, binding));

public static ColorPicker MinValue(this ColorPicker control, Int32 value)
   => control._set(() => control.MinValue = value);
public static ColorPicker MinValue(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.MinValueProperty, binding));

public static ColorPicker PreviousColor(this ColorPicker control, Nullable<Color> value)
   => control._set(() => control.PreviousColor = value);
public static ColorPicker PreviousColor(this ColorPicker control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPicker.PreviousColorProperty, binding));

public static Selector IsSynchronizedWithCurrentItem(this Selector control, Nullable<Boolean> value)
   => control._set(() => control.IsSynchronizedWithCurrentItem = value);
public static Selector IsSynchronizedWithCurrentItem(this Selector control, BindingBase binding)
   => control._set(() => control.SetBinding(Selector.IsSynchronizedWithCurrentItemProperty, binding));

public static Selector SelectedIndex(this Selector control, Int32 value)
   => control._set(() => control.SelectedIndex = value);
public static Selector SelectedIndex(this Selector control, BindingBase binding)
   => control._set(() => control.SetBinding(Selector.SelectedIndexProperty, binding));

public static Selector SelectedItem(this Selector control, Object value)
   => control._set(() => control.SelectedItem = value);
public static Selector SelectedItem(this Selector control, BindingBase binding)
   => control._set(() => control.SetBinding(Selector.SelectedItemProperty, binding));

public static Selector SelectedValuePath(this Selector control, String value)
   => control._set(() => control.SelectedValuePath = value);
public static Selector SelectedValuePath(this Selector control, BindingBase binding)
   => control._set(() => control.SetBinding(Selector.SelectedValuePathProperty, binding));

public static Selector SelectedValue(this Selector control, Object value)
   => control._set(() => control.SelectedValue = value);
public static Selector SelectedValue(this Selector control, BindingBase binding)
   => control._set(() => control.SetBinding(Selector.SelectedValueProperty, binding));

public static ComboBox IsDropDownOpen(this ComboBox control, Boolean value)
   => control._set(() => control.IsDropDownOpen = value);
public static ComboBox IsDropDownOpen(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.IsDropDownOpenProperty, binding));

public static ComboBox MaxDropDownHeight(this ComboBox control, Double value)
   => control._set(() => control.MaxDropDownHeight = value);
public static ComboBox MaxDropDownHeight(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.MaxDropDownHeightProperty, binding));

public static ComboBox Header(this ComboBox control, Object value)
   => control._set(() => control.Header = value);
public static ComboBox Header(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.HeaderProperty, binding));

public static ComboBox HeaderTemplate(this ComboBox control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static ComboBox HeaderTemplate(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.HeaderTemplateProperty, binding));

public static ComboBox PlaceholderText(this ComboBox control, String value)
   => control._set(() => control.PlaceholderText = value);
public static ComboBox PlaceholderText(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.PlaceholderTextProperty, binding));

public static ComboBox IsTextSearchEnabled(this ComboBox control, Boolean value)
   => control._set(() => control.IsTextSearchEnabled = value);
public static ComboBox IsTextSearchEnabled(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.IsTextSearchEnabledProperty, binding));

public static ComboBox LightDismissOverlayMode(this ComboBox control, LightDismissOverlayMode value)
   => control._set(() => control.LightDismissOverlayMode = value);
public static ComboBox LightDismissOverlayMode(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.LightDismissOverlayModeProperty, binding));

public static ComboBox SelectionChangedTrigger(this ComboBox control, ComboBoxSelectionChangedTrigger value)
   => control._set(() => control.SelectionChangedTrigger = value);
public static ComboBox SelectionChangedTrigger(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.SelectionChangedTriggerProperty, binding));

public static ComboBox PlaceholderForeground(this ComboBox control, Brush value)
   => control._set(() => control.PlaceholderForeground = value);
public static ComboBox PlaceholderForeground(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.PlaceholderForegroundProperty, binding));

public static ComboBox Description(this ComboBox control, Object value)
   => control._set(() => control.Description = value);
public static ComboBox Description(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.DescriptionProperty, binding));

public static ComboBox IsEditable(this ComboBox control, Boolean value)
   => control._set(() => control.IsEditable = value);
public static ComboBox IsEditable(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.IsEditableProperty, binding));

public static ComboBox TextBoxStyle(this ComboBox control, Style value)
   => control._set(() => control.TextBoxStyle = value);
public static ComboBox TextBoxStyle(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.TextBoxStyleProperty, binding));

public static ComboBox Text(this ComboBox control, String value)
   => control._set(() => control.Text = value);
public static ComboBox Text(this ComboBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ComboBox.TextProperty, binding));

public static SelectorItem IsSelected(this SelectorItem control, Boolean value)
   => control._set(() => control.IsSelected = value);
public static SelectorItem IsSelected(this SelectorItem control, BindingBase binding)
   => control._set(() => control.SetBinding(SelectorItem.IsSelectedProperty, binding));

public static CommandBar CommandBarOverflowPresenterStyle(this CommandBar control, Style value)
   => control._set(() => control.CommandBarOverflowPresenterStyle = value);
public static CommandBar CommandBarOverflowPresenterStyle(this CommandBar control, BindingBase binding)
   => control._set(() => control.SetBinding(CommandBar.CommandBarOverflowPresenterStyleProperty, binding));

public static CommandBar DefaultLabelPosition(this CommandBar control, CommandBarDefaultLabelPosition value)
   => control._set(() => control.DefaultLabelPosition = value);
public static CommandBar DefaultLabelPosition(this CommandBar control, BindingBase binding)
   => control._set(() => control.SetBinding(CommandBar.DefaultLabelPositionProperty, binding));

public static CommandBar IsDynamicOverflowEnabled(this CommandBar control, Boolean value)
   => control._set(() => control.IsDynamicOverflowEnabled = value);
public static CommandBar IsDynamicOverflowEnabled(this CommandBar control, BindingBase binding)
   => control._set(() => control.SetBinding(CommandBar.IsDynamicOverflowEnabledProperty, binding));

public static CommandBar OverflowButtonVisibility(this CommandBar control, CommandBarOverflowButtonVisibility value)
   => control._set(() => control.OverflowButtonVisibility = value);
public static CommandBar OverflowButtonVisibility(this CommandBar control, BindingBase binding)
   => control._set(() => control.SetBinding(CommandBar.OverflowButtonVisibilityProperty, binding));

public static ContentDialog FullSizeDesired(this ContentDialog control, Boolean value)
   => control._set(() => control.FullSizeDesired = value);
public static ContentDialog FullSizeDesired(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.FullSizeDesiredProperty, binding));

public static ContentDialog IsPrimaryButtonEnabled(this ContentDialog control, Boolean value)
   => control._set(() => control.IsPrimaryButtonEnabled = value);
public static ContentDialog IsPrimaryButtonEnabled(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.IsPrimaryButtonEnabledProperty, binding));

public static ContentDialog IsSecondaryButtonEnabled(this ContentDialog control, Boolean value)
   => control._set(() => control.IsSecondaryButtonEnabled = value);
public static ContentDialog IsSecondaryButtonEnabled(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.IsSecondaryButtonEnabledProperty, binding));

public static ContentDialog PrimaryButtonCommandParameter(this ContentDialog control, Object value)
   => control._set(() => control.PrimaryButtonCommandParameter = value);
public static ContentDialog PrimaryButtonCommandParameter(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.PrimaryButtonCommandParameterProperty, binding));

public static ContentDialog PrimaryButtonCommand(this ContentDialog control, ICommand value)
   => control._set(() => control.PrimaryButtonCommand = value);
public static ContentDialog PrimaryButtonCommand(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.PrimaryButtonCommandProperty, binding));

public static ContentDialog PrimaryButtonText(this ContentDialog control, String value)
   => control._set(() => control.PrimaryButtonText = value);
public static ContentDialog PrimaryButtonText(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.PrimaryButtonTextProperty, binding));

public static ContentDialog SecondaryButtonCommandParameter(this ContentDialog control, Object value)
   => control._set(() => control.SecondaryButtonCommandParameter = value);
public static ContentDialog SecondaryButtonCommandParameter(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.SecondaryButtonCommandParameterProperty, binding));

public static ContentDialog SecondaryButtonCommand(this ContentDialog control, ICommand value)
   => control._set(() => control.SecondaryButtonCommand = value);
public static ContentDialog SecondaryButtonCommand(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.SecondaryButtonCommandProperty, binding));

public static ContentDialog SecondaryButtonText(this ContentDialog control, String value)
   => control._set(() => control.SecondaryButtonText = value);
public static ContentDialog SecondaryButtonText(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.SecondaryButtonTextProperty, binding));

public static ContentDialog Title(this ContentDialog control, Object value)
   => control._set(() => control.Title = value);
public static ContentDialog Title(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.TitleProperty, binding));

public static ContentDialog TitleTemplate(this ContentDialog control, DataTemplate value)
   => control._set(() => control.TitleTemplate = value);
public static ContentDialog TitleTemplate(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.TitleTemplateProperty, binding));

public static ContentDialog CloseButtonCommandParameter(this ContentDialog control, Object value)
   => control._set(() => control.CloseButtonCommandParameter = value);
public static ContentDialog CloseButtonCommandParameter(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.CloseButtonCommandParameterProperty, binding));

public static ContentDialog CloseButtonCommand(this ContentDialog control, ICommand value)
   => control._set(() => control.CloseButtonCommand = value);
public static ContentDialog CloseButtonCommand(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.CloseButtonCommandProperty, binding));

public static ContentDialog CloseButtonStyle(this ContentDialog control, Style value)
   => control._set(() => control.CloseButtonStyle = value);
public static ContentDialog CloseButtonStyle(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.CloseButtonStyleProperty, binding));

public static ContentDialog CloseButtonText(this ContentDialog control, String value)
   => control._set(() => control.CloseButtonText = value);
public static ContentDialog CloseButtonText(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.CloseButtonTextProperty, binding));

public static ContentDialog DefaultButton(this ContentDialog control, ContentDialogButton value)
   => control._set(() => control.DefaultButton = value);
public static ContentDialog DefaultButton(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.DefaultButtonProperty, binding));

public static ContentDialog PrimaryButtonStyle(this ContentDialog control, Style value)
   => control._set(() => control.PrimaryButtonStyle = value);
public static ContentDialog PrimaryButtonStyle(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.PrimaryButtonStyleProperty, binding));

public static ContentDialog SecondaryButtonStyle(this ContentDialog control, Style value)
   => control._set(() => control.SecondaryButtonStyle = value);
public static ContentDialog SecondaryButtonStyle(this ContentDialog control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentDialog.SecondaryButtonStyleProperty, binding));

public static ContentPresenter CharacterSpacing(this ContentPresenter control, Int32 value)
   => control._set(() => control.CharacterSpacing = value);
public static ContentPresenter CharacterSpacing(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.CharacterSpacingProperty, binding));

public static ContentPresenter Content(this ContentPresenter control, Object value)
   => control._set(() => control.Content = value);
public static ContentPresenter Content(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.ContentProperty, binding));

public static ContentPresenter ContentTemplate(this ContentPresenter control, DataTemplate value)
   => control._set(() => control.ContentTemplate = value);
public static ContentPresenter ContentTemplate(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.ContentTemplateProperty, binding));

public static ContentPresenter ContentTemplateSelector(this ContentPresenter control, DataTemplateSelector value)
   => control._set(() => control.ContentTemplateSelector = value);
public static ContentPresenter ContentTemplateSelector(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.ContentTemplateSelectorProperty, binding));

public static ContentPresenter ContentTransitions(this ContentPresenter control, TransitionCollection value)
   => control._set(() => control.ContentTransitions = value);
public static ContentPresenter ContentTransitions(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.ContentTransitionsProperty, binding));

public static ContentPresenter FontFamily(this ContentPresenter control, FontFamily value)
   => control._set(() => control.FontFamily = value);
public static ContentPresenter FontFamily(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.FontFamilyProperty, binding));

public static ContentPresenter FontSize(this ContentPresenter control, Double value)
   => control._set(() => control.FontSize = value);
public static ContentPresenter FontSize(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.FontSizeProperty, binding));

public static ContentPresenter FontStretch(this ContentPresenter control, FontStretch value)
   => control._set(() => control.FontStretch = value);
public static ContentPresenter FontStretch(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.FontStretchProperty, binding));

public static ContentPresenter FontStyle(this ContentPresenter control, FontStyle value)
   => control._set(() => control.FontStyle = value);
public static ContentPresenter FontStyle(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.FontStyleProperty, binding));

public static ContentPresenter FontWeight(this ContentPresenter control, FontWeight value)
   => control._set(() => control.FontWeight = value);
public static ContentPresenter FontWeight(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.FontWeightProperty, binding));

public static ContentPresenter Foreground(this ContentPresenter control, Brush value)
   => control._set(() => control.Foreground = value);
public static ContentPresenter Foreground(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.ForegroundProperty, binding));

public static ContentPresenter OpticalMarginAlignment(this ContentPresenter control, OpticalMarginAlignment value)
   => control._set(() => control.OpticalMarginAlignment = value);
public static ContentPresenter OpticalMarginAlignment(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.OpticalMarginAlignmentProperty, binding));

public static ContentPresenter TextLineBounds(this ContentPresenter control, TextLineBounds value)
   => control._set(() => control.TextLineBounds = value);
public static ContentPresenter TextLineBounds(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.TextLineBoundsProperty, binding));

public static ContentPresenter IsTextScaleFactorEnabled(this ContentPresenter control, Boolean value)
   => control._set(() => control.IsTextScaleFactorEnabled = value);
public static ContentPresenter IsTextScaleFactorEnabled(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.IsTextScaleFactorEnabledProperty, binding));

public static ContentPresenter Background(this ContentPresenter control, Brush value)
   => control._set(() => control.Background = value);
public static ContentPresenter Background(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.BackgroundProperty, binding));

public static ContentPresenter BorderBrush(this ContentPresenter control, Brush value)
   => control._set(() => control.BorderBrush = value);
public static ContentPresenter BorderBrush(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.BorderBrushProperty, binding));

public static ContentPresenter BorderThickness(this ContentPresenter control, Thickness value)
   => control._set(() => control.BorderThickness = value);
public static ContentPresenter BorderThickness(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.BorderThicknessProperty, binding));

public static ContentPresenter CornerRadius(this ContentPresenter control, CornerRadius value)
   => control._set(() => control.CornerRadius = value);
public static ContentPresenter CornerRadius(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.CornerRadiusProperty, binding));

public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, HorizontalAlignment value)
   => control._set(() => control.HorizontalContentAlignment = value);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.HorizontalContentAlignmentProperty, binding));

public static ContentPresenter LineHeight(this ContentPresenter control, Double value)
   => control._set(() => control.LineHeight = value);
public static ContentPresenter LineHeight(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.LineHeightProperty, binding));

public static ContentPresenter LineStackingStrategy(this ContentPresenter control, LineStackingStrategy value)
   => control._set(() => control.LineStackingStrategy = value);
public static ContentPresenter LineStackingStrategy(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.LineStackingStrategyProperty, binding));

public static ContentPresenter MaxLines(this ContentPresenter control, Int32 value)
   => control._set(() => control.MaxLines = value);
public static ContentPresenter MaxLines(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.MaxLinesProperty, binding));

public static ContentPresenter Padding(this ContentPresenter control, Thickness value)
   => control._set(() => control.Padding = value);
public static ContentPresenter Padding(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.PaddingProperty, binding));

public static ContentPresenter TextWrapping(this ContentPresenter control, TextWrapping value)
   => control._set(() => control.TextWrapping = value);
public static ContentPresenter TextWrapping(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.TextWrappingProperty, binding));

public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, VerticalAlignment value)
   => control._set(() => control.VerticalContentAlignment = value);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.VerticalContentAlignmentProperty, binding));

public static ContentPresenter BackgroundSizing(this ContentPresenter control, BackgroundSizing value)
   => control._set(() => control.BackgroundSizing = value);
public static ContentPresenter BackgroundSizing(this ContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ContentPresenter.BackgroundSizingProperty, binding));

public static DatePicker CalendarIdentifier(this DatePicker control, String value)
   => control._set(() => control.CalendarIdentifier = value);
public static DatePicker CalendarIdentifier(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.CalendarIdentifierProperty, binding));

public static DatePicker Date(this DatePicker control, DateTimeOffset value)
   => control._set(() => control.Date = value);
public static DatePicker Date(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.DateProperty, binding));

public static DatePicker DayFormat(this DatePicker control, String value)
   => control._set(() => control.DayFormat = value);
public static DatePicker DayFormat(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.DayFormatProperty, binding));

public static DatePicker DayVisible(this DatePicker control, Boolean value)
   => control._set(() => control.DayVisible = value);
public static DatePicker DayVisible(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.DayVisibleProperty, binding));

public static DatePicker Header(this DatePicker control, Object value)
   => control._set(() => control.Header = value);
public static DatePicker Header(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.HeaderProperty, binding));

public static DatePicker HeaderTemplate(this DatePicker control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static DatePicker HeaderTemplate(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.HeaderTemplateProperty, binding));

public static DatePicker MaxYear(this DatePicker control, DateTimeOffset value)
   => control._set(() => control.MaxYear = value);
public static DatePicker MaxYear(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.MaxYearProperty, binding));

public static DatePicker MinYear(this DatePicker control, DateTimeOffset value)
   => control._set(() => control.MinYear = value);
public static DatePicker MinYear(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.MinYearProperty, binding));

public static DatePicker MonthFormat(this DatePicker control, String value)
   => control._set(() => control.MonthFormat = value);
public static DatePicker MonthFormat(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.MonthFormatProperty, binding));

public static DatePicker MonthVisible(this DatePicker control, Boolean value)
   => control._set(() => control.MonthVisible = value);
public static DatePicker MonthVisible(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.MonthVisibleProperty, binding));

public static DatePicker Orientation(this DatePicker control, Orientation value)
   => control._set(() => control.Orientation = value);
public static DatePicker Orientation(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.OrientationProperty, binding));

public static DatePicker YearFormat(this DatePicker control, String value)
   => control._set(() => control.YearFormat = value);
public static DatePicker YearFormat(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.YearFormatProperty, binding));

public static DatePicker YearVisible(this DatePicker control, Boolean value)
   => control._set(() => control.YearVisible = value);
public static DatePicker YearVisible(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.YearVisibleProperty, binding));

public static DatePicker LightDismissOverlayMode(this DatePicker control, LightDismissOverlayMode value)
   => control._set(() => control.LightDismissOverlayMode = value);
public static DatePicker LightDismissOverlayMode(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.LightDismissOverlayModeProperty, binding));

public static DatePicker SelectedDate(this DatePicker control, Nullable<DateTimeOffset> value)
   => control._set(() => control.SelectedDate = value);
public static DatePicker SelectedDate(this DatePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePicker.SelectedDateProperty, binding));

public static DatePickerFlyoutPresenter IsDefaultShadowEnabled(this DatePickerFlyoutPresenter control, Boolean value)
   => control._set(() => control.IsDefaultShadowEnabled = value);
public static DatePickerFlyoutPresenter IsDefaultShadowEnabled(this DatePickerFlyoutPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(DatePickerFlyoutPresenter.IsDefaultShadowEnabledProperty, binding));

public static FlipView UseTouchAnimationsForAllNavigation(this FlipView control, Boolean value)
   => control._set(() => control.UseTouchAnimationsForAllNavigation = value);
public static FlipView UseTouchAnimationsForAllNavigation(this FlipView control, BindingBase binding)
   => control._set(() => control.SetBinding(FlipView.UseTouchAnimationsForAllNavigationProperty, binding));

public static FlyoutPresenter IsDefaultShadowEnabled(this FlyoutPresenter control, Boolean value)
   => control._set(() => control.IsDefaultShadowEnabled = value);
public static FlyoutPresenter IsDefaultShadowEnabled(this FlyoutPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(FlyoutPresenter.IsDefaultShadowEnabledProperty, binding));

public static FontIcon FontFamily(this FontIcon control, FontFamily value)
   => control._set(() => control.FontFamily = value);
public static FontIcon FontFamily(this FontIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(FontIcon.FontFamilyProperty, binding));

public static FontIcon FontSize(this FontIcon control, Double value)
   => control._set(() => control.FontSize = value);
public static FontIcon FontSize(this FontIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(FontIcon.FontSizeProperty, binding));

public static FontIcon FontStyle(this FontIcon control, FontStyle value)
   => control._set(() => control.FontStyle = value);
public static FontIcon FontStyle(this FontIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(FontIcon.FontStyleProperty, binding));

public static FontIcon FontWeight(this FontIcon control, FontWeight value)
   => control._set(() => control.FontWeight = value);
public static FontIcon FontWeight(this FontIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(FontIcon.FontWeightProperty, binding));

public static FontIcon Glyph(this FontIcon control, String value)
   => control._set(() => control.Glyph = value);
public static FontIcon Glyph(this FontIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(FontIcon.GlyphProperty, binding));

public static FontIcon IsTextScaleFactorEnabled(this FontIcon control, Boolean value)
   => control._set(() => control.IsTextScaleFactorEnabled = value);
public static FontIcon IsTextScaleFactorEnabled(this FontIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(FontIcon.IsTextScaleFactorEnabledProperty, binding));

public static FontIcon MirroredWhenRightToLeft(this FontIcon control, Boolean value)
   => control._set(() => control.MirroredWhenRightToLeft = value);
public static FontIcon MirroredWhenRightToLeft(this FontIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(FontIcon.MirroredWhenRightToLeftProperty, binding));

public static Frame CacheSize(this Frame control, Int32 value)
   => control._set(() => control.CacheSize = value);
public static Frame CacheSize(this Frame control, BindingBase binding)
   => control._set(() => control.SetBinding(Frame.CacheSizeProperty, binding));

public static Frame SourcePageType(this Frame control, Type value)
   => control._set(() => control.SourcePageType = value);
public static Frame SourcePageType(this Frame control, BindingBase binding)
   => control._set(() => control.SetBinding(Frame.SourcePageTypeProperty, binding));

public static Frame IsNavigationStackEnabled(this Frame control, Boolean value)
   => control._set(() => control.IsNavigationStackEnabled = value);
public static Frame IsNavigationStackEnabled(this Frame control, BindingBase binding)
   => control._set(() => control.SetBinding(Frame.IsNavigationStackEnabledProperty, binding));

public static Grid BorderBrush(this Grid control, Brush value)
   => control._set(() => control.BorderBrush = value);
public static Grid BorderBrush(this Grid control, BindingBase binding)
   => control._set(() => control.SetBinding(Grid.BorderBrushProperty, binding));

public static Grid BorderThickness(this Grid control, Thickness value)
   => control._set(() => control.BorderThickness = value);
public static Grid BorderThickness(this Grid control, BindingBase binding)
   => control._set(() => control.SetBinding(Grid.BorderThicknessProperty, binding));

public static Grid CornerRadius(this Grid control, CornerRadius value)
   => control._set(() => control.CornerRadius = value);
public static Grid CornerRadius(this Grid control, BindingBase binding)
   => control._set(() => control.SetBinding(Grid.CornerRadiusProperty, binding));

public static Grid Padding(this Grid control, Thickness value)
   => control._set(() => control.Padding = value);
public static Grid Padding(this Grid control, BindingBase binding)
   => control._set(() => control.SetBinding(Grid.PaddingProperty, binding));

public static Grid ColumnSpacing(this Grid control, Double value)
   => control._set(() => control.ColumnSpacing = value);
public static Grid ColumnSpacing(this Grid control, BindingBase binding)
   => control._set(() => control.SetBinding(Grid.ColumnSpacingProperty, binding));

public static Grid RowSpacing(this Grid control, Double value)
   => control._set(() => control.RowSpacing = value);
public static Grid RowSpacing(this Grid control, BindingBase binding)
   => control._set(() => control.SetBinding(Grid.RowSpacingProperty, binding));

public static Grid BackgroundSizing(this Grid control, BackgroundSizing value)
   => control._set(() => control.BackgroundSizing = value);
public static Grid BackgroundSizing(this Grid control, BindingBase binding)
   => control._set(() => control.SetBinding(Grid.BackgroundSizingProperty, binding));

public static ListViewBase CanDragItems(this ListViewBase control, Boolean value)
   => control._set(() => control.CanDragItems = value);
public static ListViewBase CanDragItems(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.CanDragItemsProperty, binding));

public static ListViewBase CanReorderItems(this ListViewBase control, Boolean value)
   => control._set(() => control.CanReorderItems = value);
public static ListViewBase CanReorderItems(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.CanReorderItemsProperty, binding));

public static ListViewBase DataFetchSize(this ListViewBase control, Double value)
   => control._set(() => control.DataFetchSize = value);
public static ListViewBase DataFetchSize(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.DataFetchSizeProperty, binding));

public static ListViewBase Header(this ListViewBase control, Object value)
   => control._set(() => control.Header = value);
public static ListViewBase Header(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.HeaderProperty, binding));

public static ListViewBase HeaderTemplate(this ListViewBase control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static ListViewBase HeaderTemplate(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.HeaderTemplateProperty, binding));

public static ListViewBase HeaderTransitions(this ListViewBase control, TransitionCollection value)
   => control._set(() => control.HeaderTransitions = value);
public static ListViewBase HeaderTransitions(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.HeaderTransitionsProperty, binding));

public static ListViewBase IncrementalLoadingThreshold(this ListViewBase control, Double value)
   => control._set(() => control.IncrementalLoadingThreshold = value);
public static ListViewBase IncrementalLoadingThreshold(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.IncrementalLoadingThresholdProperty, binding));

public static ListViewBase IncrementalLoadingTrigger(this ListViewBase control, IncrementalLoadingTrigger value)
   => control._set(() => control.IncrementalLoadingTrigger = value);
public static ListViewBase IncrementalLoadingTrigger(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.IncrementalLoadingTriggerProperty, binding));

public static ListViewBase IsActiveView(this ListViewBase control, Boolean value)
   => control._set(() => control.IsActiveView = value);
public static ListViewBase IsActiveView(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.IsActiveViewProperty, binding));

public static ListViewBase IsItemClickEnabled(this ListViewBase control, Boolean value)
   => control._set(() => control.IsItemClickEnabled = value);
public static ListViewBase IsItemClickEnabled(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.IsItemClickEnabledProperty, binding));

public static ListViewBase IsSwipeEnabled(this ListViewBase control, Boolean value)
   => control._set(() => control.IsSwipeEnabled = value);
public static ListViewBase IsSwipeEnabled(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.IsSwipeEnabledProperty, binding));

public static ListViewBase IsZoomedInView(this ListViewBase control, Boolean value)
   => control._set(() => control.IsZoomedInView = value);
public static ListViewBase IsZoomedInView(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.IsZoomedInViewProperty, binding));

public static ListViewBase SelectionMode(this ListViewBase control, ListViewSelectionMode value)
   => control._set(() => control.SelectionMode = value);
public static ListViewBase SelectionMode(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.SelectionModeProperty, binding));

public static ListViewBase SemanticZoomOwner(this ListViewBase control, SemanticZoom value)
   => control._set(() => control.SemanticZoomOwner = value);
public static ListViewBase SemanticZoomOwner(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.SemanticZoomOwnerProperty, binding));

public static ListViewBase Footer(this ListViewBase control, Object value)
   => control._set(() => control.Footer = value);
public static ListViewBase Footer(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.FooterProperty, binding));

public static ListViewBase FooterTemplate(this ListViewBase control, DataTemplate value)
   => control._set(() => control.FooterTemplate = value);
public static ListViewBase FooterTemplate(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.FooterTemplateProperty, binding));

public static ListViewBase FooterTransitions(this ListViewBase control, TransitionCollection value)
   => control._set(() => control.FooterTransitions = value);
public static ListViewBase FooterTransitions(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.FooterTransitionsProperty, binding));

public static ListViewBase ShowsScrollingPlaceholders(this ListViewBase control, Boolean value)
   => control._set(() => control.ShowsScrollingPlaceholders = value);
public static ListViewBase ShowsScrollingPlaceholders(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.ShowsScrollingPlaceholdersProperty, binding));

public static ListViewBase ReorderMode(this ListViewBase control, ListViewReorderMode value)
   => control._set(() => control.ReorderMode = value);
public static ListViewBase ReorderMode(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.ReorderModeProperty, binding));

public static ListViewBase IsMultiSelectCheckBoxEnabled(this ListViewBase control, Boolean value)
   => control._set(() => control.IsMultiSelectCheckBoxEnabled = value);
public static ListViewBase IsMultiSelectCheckBoxEnabled(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.IsMultiSelectCheckBoxEnabledProperty, binding));

public static ListViewBase SingleSelectionFollowsFocus(this ListViewBase control, Boolean value)
   => control._set(() => control.SingleSelectionFollowsFocus = value);
public static ListViewBase SingleSelectionFollowsFocus(this ListViewBase control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewBase.SingleSelectionFollowsFocusProperty, binding));

public static Windows.UI.Xaml.Controls.HandwritingView AreCandidatesEnabled(this Windows.UI.Xaml.Controls.HandwritingView control, Boolean value)
   => control._set(() => control.AreCandidatesEnabled = value);
public static Windows.UI.Xaml.Controls.HandwritingView AreCandidatesEnabled(this Windows.UI.Xaml.Controls.HandwritingView control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.HandwritingView.AreCandidatesEnabledProperty, binding));

public static Windows.UI.Xaml.Controls.HandwritingView PlacementAlignment(this Windows.UI.Xaml.Controls.HandwritingView control, HandwritingPanelPlacementAlignment value)
   => control._set(() => control.PlacementAlignment = value);
public static Windows.UI.Xaml.Controls.HandwritingView PlacementAlignment(this Windows.UI.Xaml.Controls.HandwritingView control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.HandwritingView.PlacementAlignmentProperty, binding));

public static Windows.UI.Xaml.Controls.HandwritingView PlacementTarget(this Windows.UI.Xaml.Controls.HandwritingView control, UIElement value)
   => control._set(() => control.PlacementTarget = value);
public static Windows.UI.Xaml.Controls.HandwritingView PlacementTarget(this Windows.UI.Xaml.Controls.HandwritingView control, BindingBase binding)
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Controls.HandwritingView.PlacementTargetProperty, binding));

public static Hub DefaultSectionIndex(this Hub control, Int32 value)
   => control._set(() => control.DefaultSectionIndex = value);
public static Hub DefaultSectionIndex(this Hub control, BindingBase binding)
   => control._set(() => control.SetBinding(Hub.DefaultSectionIndexProperty, binding));

public static Hub Header(this Hub control, Object value)
   => control._set(() => control.Header = value);
public static Hub Header(this Hub control, BindingBase binding)
   => control._set(() => control.SetBinding(Hub.HeaderProperty, binding));

public static Hub HeaderTemplate(this Hub control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static Hub HeaderTemplate(this Hub control, BindingBase binding)
   => control._set(() => control.SetBinding(Hub.HeaderTemplateProperty, binding));

public static Hub IsActiveView(this Hub control, Boolean value)
   => control._set(() => control.IsActiveView = value);
public static Hub IsActiveView(this Hub control, BindingBase binding)
   => control._set(() => control.SetBinding(Hub.IsActiveViewProperty, binding));

public static Hub IsZoomedInView(this Hub control, Boolean value)
   => control._set(() => control.IsZoomedInView = value);
public static Hub IsZoomedInView(this Hub control, BindingBase binding)
   => control._set(() => control.SetBinding(Hub.IsZoomedInViewProperty, binding));

public static Hub Orientation(this Hub control, Orientation value)
   => control._set(() => control.Orientation = value);
public static Hub Orientation(this Hub control, BindingBase binding)
   => control._set(() => control.SetBinding(Hub.OrientationProperty, binding));

public static Hub SemanticZoomOwner(this Hub control, SemanticZoom value)
   => control._set(() => control.SemanticZoomOwner = value);
public static Hub SemanticZoomOwner(this Hub control, BindingBase binding)
   => control._set(() => control.SetBinding(Hub.SemanticZoomOwnerProperty, binding));

public static HubSection ContentTemplate(this HubSection control, DataTemplate value)
   => control._set(() => control.ContentTemplate = value);
public static HubSection ContentTemplate(this HubSection control, BindingBase binding)
   => control._set(() => control.SetBinding(HubSection.ContentTemplateProperty, binding));

public static HubSection Header(this HubSection control, Object value)
   => control._set(() => control.Header = value);
public static HubSection Header(this HubSection control, BindingBase binding)
   => control._set(() => control.SetBinding(HubSection.HeaderProperty, binding));

public static HubSection HeaderTemplate(this HubSection control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static HubSection HeaderTemplate(this HubSection control, BindingBase binding)
   => control._set(() => control.SetBinding(HubSection.HeaderTemplateProperty, binding));

public static HubSection IsHeaderInteractive(this HubSection control, Boolean value)
   => control._set(() => control.IsHeaderInteractive = value);
public static HubSection IsHeaderInteractive(this HubSection control, BindingBase binding)
   => control._set(() => control.SetBinding(HubSection.IsHeaderInteractiveProperty, binding));

public static HyperlinkButton NavigateUri(this HyperlinkButton control, Uri value)
   => control._set(() => control.NavigateUri = value);
public static HyperlinkButton NavigateUri(this HyperlinkButton control, BindingBase binding)
   => control._set(() => control.SetBinding(HyperlinkButton.NavigateUriProperty, binding));

public static IconSourceElement IconSource(this IconSourceElement control, IconSource value)
   => control._set(() => control.IconSource = value);
public static IconSourceElement IconSource(this IconSourceElement control, BindingBase binding)
   => control._set(() => control.SetBinding(IconSourceElement.IconSourceProperty, binding));

public static Image NineGrid(this Image control, Thickness value)
   => control._set(() => control.NineGrid = value);
public static Image NineGrid(this Image control, BindingBase binding)
   => control._set(() => control.SetBinding(Image.NineGridProperty, binding));

public static Image Source(this Image control, ImageSource value)
   => control._set(() => control.Source = value);
public static Image Source(this Image control, BindingBase binding)
   => control._set(() => control.SetBinding(Image.SourceProperty, binding));

public static Image Stretch(this Image control, Stretch value)
   => control._set(() => control.Stretch = value);
public static Image Stretch(this Image control, BindingBase binding)
   => control._set(() => control.SetBinding(Image.StretchProperty, binding));

public static InkToolbar ActiveTool(this InkToolbar control, InkToolbarToolButton value)
   => control._set(() => control.ActiveTool = value);
public static InkToolbar ActiveTool(this InkToolbar control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbar.ActiveToolProperty, binding));

public static InkToolbar InitialControls(this InkToolbar control, InkToolbarInitialControls value)
   => control._set(() => control.InitialControls = value);
public static InkToolbar InitialControls(this InkToolbar control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbar.InitialControlsProperty, binding));

public static InkToolbar IsRulerButtonChecked(this InkToolbar control, Boolean value)
   => control._set(() => control.IsRulerButtonChecked = value);
public static InkToolbar IsRulerButtonChecked(this InkToolbar control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbar.IsRulerButtonCheckedProperty, binding));

public static InkToolbar TargetInkCanvas(this InkToolbar control, InkCanvas value)
   => control._set(() => control.TargetInkCanvas = value);
public static InkToolbar TargetInkCanvas(this InkToolbar control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbar.TargetInkCanvasProperty, binding));

public static InkToolbar ButtonFlyoutPlacement(this InkToolbar control, InkToolbarButtonFlyoutPlacement value)
   => control._set(() => control.ButtonFlyoutPlacement = value);
public static InkToolbar ButtonFlyoutPlacement(this InkToolbar control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbar.ButtonFlyoutPlacementProperty, binding));

public static InkToolbar IsStencilButtonChecked(this InkToolbar control, Boolean value)
   => control._set(() => control.IsStencilButtonChecked = value);
public static InkToolbar IsStencilButtonChecked(this InkToolbar control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbar.IsStencilButtonCheckedProperty, binding));

public static InkToolbar Orientation(this InkToolbar control, Orientation value)
   => control._set(() => control.Orientation = value);
public static InkToolbar Orientation(this InkToolbar control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbar.OrientationProperty, binding));

public static InkToolbar TargetInkPresenter(this InkToolbar control, InkPresenter value)
   => control._set(() => control.TargetInkPresenter = value);
public static InkToolbar TargetInkPresenter(this InkToolbar control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbar.TargetInkPresenterProperty, binding));

public static RadioButton GroupName(this RadioButton control, String value)
   => control._set(() => control.GroupName = value);
public static RadioButton GroupName(this RadioButton control, BindingBase binding)
   => control._set(() => control.SetBinding(RadioButton.GroupNameProperty, binding));

public static InkToolbarToolButton IsExtensionGlyphShown(this InkToolbarToolButton control, Boolean value)
   => control._set(() => control.IsExtensionGlyphShown = value);
public static InkToolbarToolButton IsExtensionGlyphShown(this InkToolbarToolButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarToolButton.IsExtensionGlyphShownProperty, binding));

public static InkToolbarPenButton MaxStrokeWidth(this InkToolbarPenButton control, Double value)
   => control._set(() => control.MaxStrokeWidth = value);
public static InkToolbarPenButton MaxStrokeWidth(this InkToolbarPenButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarPenButton.MaxStrokeWidthProperty, binding));

public static InkToolbarPenButton MinStrokeWidth(this InkToolbarPenButton control, Double value)
   => control._set(() => control.MinStrokeWidth = value);
public static InkToolbarPenButton MinStrokeWidth(this InkToolbarPenButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarPenButton.MinStrokeWidthProperty, binding));

public static InkToolbarPenButton Palette(this InkToolbarPenButton control, IList<Brush> value)
   => control._set(() => control.Palette = value);
public static InkToolbarPenButton Palette(this InkToolbarPenButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarPenButton.PaletteProperty, binding));

public static InkToolbarPenButton SelectedBrushIndex(this InkToolbarPenButton control, Int32 value)
   => control._set(() => control.SelectedBrushIndex = value);
public static InkToolbarPenButton SelectedBrushIndex(this InkToolbarPenButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarPenButton.SelectedBrushIndexProperty, binding));

public static InkToolbarPenButton SelectedStrokeWidth(this InkToolbarPenButton control, Double value)
   => control._set(() => control.SelectedStrokeWidth = value);
public static InkToolbarPenButton SelectedStrokeWidth(this InkToolbarPenButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarPenButton.SelectedStrokeWidthProperty, binding));

public static InkToolbarCustomPenButton ConfigurationContent(this InkToolbarCustomPenButton control, UIElement value)
   => control._set(() => control.ConfigurationContent = value);
public static InkToolbarCustomPenButton ConfigurationContent(this InkToolbarCustomPenButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarCustomPenButton.ConfigurationContentProperty, binding));

public static InkToolbarCustomPenButton CustomPen(this InkToolbarCustomPenButton control, InkToolbarCustomPen value)
   => control._set(() => control.CustomPen = value);
public static InkToolbarCustomPenButton CustomPen(this InkToolbarCustomPenButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarCustomPenButton.CustomPenProperty, binding));

public static InkToolbarCustomToolButton ConfigurationContent(this InkToolbarCustomToolButton control, UIElement value)
   => control._set(() => control.ConfigurationContent = value);
public static InkToolbarCustomToolButton ConfigurationContent(this InkToolbarCustomToolButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarCustomToolButton.ConfigurationContentProperty, binding));

public static InkToolbarEraserButton IsClearAllVisible(this InkToolbarEraserButton control, Boolean value)
   => control._set(() => control.IsClearAllVisible = value);
public static InkToolbarEraserButton IsClearAllVisible(this InkToolbarEraserButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarEraserButton.IsClearAllVisibleProperty, binding));

public static InkToolbarFlyoutItem IsChecked(this InkToolbarFlyoutItem control, Boolean value)
   => control._set(() => control.IsChecked = value);
public static InkToolbarFlyoutItem IsChecked(this InkToolbarFlyoutItem control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarFlyoutItem.IsCheckedProperty, binding));

public static InkToolbarFlyoutItem Kind(this InkToolbarFlyoutItem control, InkToolbarFlyoutItemKind value)
   => control._set(() => control.Kind = value);
public static InkToolbarFlyoutItem Kind(this InkToolbarFlyoutItem control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarFlyoutItem.KindProperty, binding));

public static InkToolbarMenuButton IsExtensionGlyphShown(this InkToolbarMenuButton control, Boolean value)
   => control._set(() => control.IsExtensionGlyphShown = value);
public static InkToolbarMenuButton IsExtensionGlyphShown(this InkToolbarMenuButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarMenuButton.IsExtensionGlyphShownProperty, binding));

public static InkToolbarStencilButton IsProtractorItemVisible(this InkToolbarStencilButton control, Boolean value)
   => control._set(() => control.IsProtractorItemVisible = value);
public static InkToolbarStencilButton IsProtractorItemVisible(this InkToolbarStencilButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarStencilButton.IsProtractorItemVisibleProperty, binding));

public static InkToolbarStencilButton IsRulerItemVisible(this InkToolbarStencilButton control, Boolean value)
   => control._set(() => control.IsRulerItemVisible = value);
public static InkToolbarStencilButton IsRulerItemVisible(this InkToolbarStencilButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarStencilButton.IsRulerItemVisibleProperty, binding));

public static InkToolbarStencilButton SelectedStencil(this InkToolbarStencilButton control, InkToolbarStencilKind value)
   => control._set(() => control.SelectedStencil = value);
public static InkToolbarStencilButton SelectedStencil(this InkToolbarStencilButton control, BindingBase binding)
   => control._set(() => control.SetBinding(InkToolbarStencilButton.SelectedStencilProperty, binding));

public static ItemsPresenter Header(this ItemsPresenter control, Object value)
   => control._set(() => control.Header = value);
public static ItemsPresenter Header(this ItemsPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsPresenter.HeaderProperty, binding));

public static ItemsPresenter HeaderTemplate(this ItemsPresenter control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static ItemsPresenter HeaderTemplate(this ItemsPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsPresenter.HeaderTemplateProperty, binding));

public static ItemsPresenter HeaderTransitions(this ItemsPresenter control, TransitionCollection value)
   => control._set(() => control.HeaderTransitions = value);
public static ItemsPresenter HeaderTransitions(this ItemsPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsPresenter.HeaderTransitionsProperty, binding));

public static ItemsPresenter Padding(this ItemsPresenter control, Thickness value)
   => control._set(() => control.Padding = value);
public static ItemsPresenter Padding(this ItemsPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsPresenter.PaddingProperty, binding));

public static ItemsPresenter Footer(this ItemsPresenter control, Object value)
   => control._set(() => control.Footer = value);
public static ItemsPresenter Footer(this ItemsPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsPresenter.FooterProperty, binding));

public static ItemsPresenter FooterTemplate(this ItemsPresenter control, DataTemplate value)
   => control._set(() => control.FooterTemplate = value);
public static ItemsPresenter FooterTemplate(this ItemsPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsPresenter.FooterTemplateProperty, binding));

public static ItemsPresenter FooterTransitions(this ItemsPresenter control, TransitionCollection value)
   => control._set(() => control.FooterTransitions = value);
public static ItemsPresenter FooterTransitions(this ItemsPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsPresenter.FooterTransitionsProperty, binding));

public static ItemsStackPanel CacheLength(this ItemsStackPanel control, Double value)
   => control._set(() => control.CacheLength = value);
public static ItemsStackPanel CacheLength(this ItemsStackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsStackPanel.CacheLengthProperty, binding));

public static ItemsStackPanel GroupHeaderPlacement(this ItemsStackPanel control, GroupHeaderPlacement value)
   => control._set(() => control.GroupHeaderPlacement = value);
public static ItemsStackPanel GroupHeaderPlacement(this ItemsStackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsStackPanel.GroupHeaderPlacementProperty, binding));

public static ItemsStackPanel GroupPadding(this ItemsStackPanel control, Thickness value)
   => control._set(() => control.GroupPadding = value);
public static ItemsStackPanel GroupPadding(this ItemsStackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsStackPanel.GroupPaddingProperty, binding));

public static ItemsStackPanel Orientation(this ItemsStackPanel control, Orientation value)
   => control._set(() => control.Orientation = value);
public static ItemsStackPanel Orientation(this ItemsStackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsStackPanel.OrientationProperty, binding));

public static ItemsStackPanel AreStickyGroupHeadersEnabled(this ItemsStackPanel control, Boolean value)
   => control._set(() => control.AreStickyGroupHeadersEnabled = value);
public static ItemsStackPanel AreStickyGroupHeadersEnabled(this ItemsStackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsStackPanel.AreStickyGroupHeadersEnabledProperty, binding));

public static ItemsWrapGrid CacheLength(this ItemsWrapGrid control, Double value)
   => control._set(() => control.CacheLength = value);
public static ItemsWrapGrid CacheLength(this ItemsWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsWrapGrid.CacheLengthProperty, binding));

public static ItemsWrapGrid GroupHeaderPlacement(this ItemsWrapGrid control, GroupHeaderPlacement value)
   => control._set(() => control.GroupHeaderPlacement = value);
public static ItemsWrapGrid GroupHeaderPlacement(this ItemsWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsWrapGrid.GroupHeaderPlacementProperty, binding));

public static ItemsWrapGrid GroupPadding(this ItemsWrapGrid control, Thickness value)
   => control._set(() => control.GroupPadding = value);
public static ItemsWrapGrid GroupPadding(this ItemsWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsWrapGrid.GroupPaddingProperty, binding));

public static ItemsWrapGrid ItemHeight(this ItemsWrapGrid control, Double value)
   => control._set(() => control.ItemHeight = value);
public static ItemsWrapGrid ItemHeight(this ItemsWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsWrapGrid.ItemHeightProperty, binding));

public static ItemsWrapGrid ItemWidth(this ItemsWrapGrid control, Double value)
   => control._set(() => control.ItemWidth = value);
public static ItemsWrapGrid ItemWidth(this ItemsWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsWrapGrid.ItemWidthProperty, binding));

public static ItemsWrapGrid MaximumRowsOrColumns(this ItemsWrapGrid control, Int32 value)
   => control._set(() => control.MaximumRowsOrColumns = value);
public static ItemsWrapGrid MaximumRowsOrColumns(this ItemsWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsWrapGrid.MaximumRowsOrColumnsProperty, binding));

public static ItemsWrapGrid Orientation(this ItemsWrapGrid control, Orientation value)
   => control._set(() => control.Orientation = value);
public static ItemsWrapGrid Orientation(this ItemsWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsWrapGrid.OrientationProperty, binding));

public static ItemsWrapGrid AreStickyGroupHeadersEnabled(this ItemsWrapGrid control, Boolean value)
   => control._set(() => control.AreStickyGroupHeadersEnabled = value);
public static ItemsWrapGrid AreStickyGroupHeadersEnabled(this ItemsWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(ItemsWrapGrid.AreStickyGroupHeadersEnabledProperty, binding));

public static ListBox SelectionMode(this ListBox control, SelectionMode value)
   => control._set(() => control.SelectionMode = value);
public static ListBox SelectionMode(this ListBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ListBox.SelectionModeProperty, binding));

public static ListBox SingleSelectionFollowsFocus(this ListBox control, Boolean value)
   => control._set(() => control.SingleSelectionFollowsFocus = value);
public static ListBox SingleSelectionFollowsFocus(this ListBox control, BindingBase binding)
   => control._set(() => control.SetBinding(ListBox.SingleSelectionFollowsFocusProperty, binding));

public static MediaElement Source(this MediaElement control, Uri value)
   => control._set(() => control.Source = value);
public static MediaElement Source(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.SourceProperty, binding));

public static MediaElement Stereo3DVideoPackingMode(this MediaElement control, Stereo3DVideoPackingMode value)
   => control._set(() => control.Stereo3DVideoPackingMode = value);
public static MediaElement Stereo3DVideoPackingMode(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.Stereo3DVideoPackingModeProperty, binding));

public static MediaElement Stereo3DVideoRenderMode(this MediaElement control, Stereo3DVideoRenderMode value)
   => control._set(() => control.Stereo3DVideoRenderMode = value);
public static MediaElement Stereo3DVideoRenderMode(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.Stereo3DVideoRenderModeProperty, binding));

public static MediaElement AudioCategory(this MediaElement control, AudioCategory value)
   => control._set(() => control.AudioCategory = value);
public static MediaElement AudioCategory(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.AudioCategoryProperty, binding));

public static MediaElement AudioDeviceType(this MediaElement control, AudioDeviceType value)
   => control._set(() => control.AudioDeviceType = value);
public static MediaElement AudioDeviceType(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.AudioDeviceTypeProperty, binding));

public static MediaElement AudioStreamIndex(this MediaElement control, Nullable<Int32> value)
   => control._set(() => control.AudioStreamIndex = value);
public static MediaElement AudioStreamIndex(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.AudioStreamIndexProperty, binding));

public static MediaElement AutoPlay(this MediaElement control, Boolean value)
   => control._set(() => control.AutoPlay = value);
public static MediaElement AutoPlay(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.AutoPlayProperty, binding));

public static MediaElement Balance(this MediaElement control, Double value)
   => control._set(() => control.Balance = value);
public static MediaElement Balance(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.BalanceProperty, binding));

public static MediaElement DefaultPlaybackRate(this MediaElement control, Double value)
   => control._set(() => control.DefaultPlaybackRate = value);
public static MediaElement DefaultPlaybackRate(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.DefaultPlaybackRateProperty, binding));

public static MediaElement Volume(this MediaElement control, Double value)
   => control._set(() => control.Volume = value);
public static MediaElement Volume(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.VolumeProperty, binding));

public static MediaElement IsLooping(this MediaElement control, Boolean value)
   => control._set(() => control.IsLooping = value);
public static MediaElement IsLooping(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.IsLoopingProperty, binding));

public static MediaElement IsMuted(this MediaElement control, Boolean value)
   => control._set(() => control.IsMuted = value);
public static MediaElement IsMuted(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.IsMutedProperty, binding));

public static MediaElement PlaybackRate(this MediaElement control, Double value)
   => control._set(() => control.PlaybackRate = value);
public static MediaElement PlaybackRate(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.PlaybackRateProperty, binding));

public static MediaElement Position(this MediaElement control, TimeSpan value)
   => control._set(() => control.Position = value);
public static MediaElement Position(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.PositionProperty, binding));

public static MediaElement PosterSource(this MediaElement control, ImageSource value)
   => control._set(() => control.PosterSource = value);
public static MediaElement PosterSource(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.PosterSourceProperty, binding));

public static MediaElement ProtectionManager(this MediaElement control, MediaProtectionManager value)
   => control._set(() => control.ProtectionManager = value);
public static MediaElement ProtectionManager(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.ProtectionManagerProperty, binding));

public static MediaElement RealTimePlayback(this MediaElement control, Boolean value)
   => control._set(() => control.RealTimePlayback = value);
public static MediaElement RealTimePlayback(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.RealTimePlaybackProperty, binding));

public static MediaElement IsFullWindow(this MediaElement control, Boolean value)
   => control._set(() => control.IsFullWindow = value);
public static MediaElement IsFullWindow(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.IsFullWindowProperty, binding));

public static MediaElement PlayToPreferredSourceUri(this MediaElement control, Uri value)
   => control._set(() => control.PlayToPreferredSourceUri = value);
public static MediaElement PlayToPreferredSourceUri(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.PlayToPreferredSourceUriProperty, binding));

public static MediaElement Stretch(this MediaElement control, Stretch value)
   => control._set(() => control.Stretch = value);
public static MediaElement Stretch(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.StretchProperty, binding));

public static MediaElement AreTransportControlsEnabled(this MediaElement control, Boolean value)
   => control._set(() => control.AreTransportControlsEnabled = value);
public static MediaElement AreTransportControlsEnabled(this MediaElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaElement.AreTransportControlsEnabledProperty, binding));

public static MediaPlayerElement AreTransportControlsEnabled(this MediaPlayerElement control, Boolean value)
   => control._set(() => control.AreTransportControlsEnabled = value);
public static MediaPlayerElement AreTransportControlsEnabled(this MediaPlayerElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaPlayerElement.AreTransportControlsEnabledProperty, binding));

public static MediaPlayerElement AutoPlay(this MediaPlayerElement control, Boolean value)
   => control._set(() => control.AutoPlay = value);
public static MediaPlayerElement AutoPlay(this MediaPlayerElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaPlayerElement.AutoPlayProperty, binding));

public static MediaPlayerElement IsFullWindow(this MediaPlayerElement control, Boolean value)
   => control._set(() => control.IsFullWindow = value);
public static MediaPlayerElement IsFullWindow(this MediaPlayerElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaPlayerElement.IsFullWindowProperty, binding));

public static MediaPlayerElement PosterSource(this MediaPlayerElement control, ImageSource value)
   => control._set(() => control.PosterSource = value);
public static MediaPlayerElement PosterSource(this MediaPlayerElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaPlayerElement.PosterSourceProperty, binding));

public static MediaPlayerElement Source(this MediaPlayerElement control, IMediaPlaybackSource value)
   => control._set(() => control.Source = value);
public static MediaPlayerElement Source(this MediaPlayerElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaPlayerElement.SourceProperty, binding));

public static MediaPlayerElement Stretch(this MediaPlayerElement control, Stretch value)
   => control._set(() => control.Stretch = value);
public static MediaPlayerElement Stretch(this MediaPlayerElement control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaPlayerElement.StretchProperty, binding));

public static MediaPlayerPresenter IsFullWindow(this MediaPlayerPresenter control, Boolean value)
   => control._set(() => control.IsFullWindow = value);
public static MediaPlayerPresenter IsFullWindow(this MediaPlayerPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaPlayerPresenter.IsFullWindowProperty, binding));

public static MediaPlayerPresenter MediaPlayer(this MediaPlayerPresenter control, MediaPlayer value)
   => control._set(() => control.MediaPlayer = value);
public static MediaPlayerPresenter MediaPlayer(this MediaPlayerPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaPlayerPresenter.MediaPlayerProperty, binding));

public static MediaPlayerPresenter Stretch(this MediaPlayerPresenter control, Stretch value)
   => control._set(() => control.Stretch = value);
public static MediaPlayerPresenter Stretch(this MediaPlayerPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaPlayerPresenter.StretchProperty, binding));

public static MediaTransportControls IsCompact(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsCompact = value);
public static MediaTransportControls IsCompact(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsCompactProperty, binding));

public static MediaTransportControls IsFastForwardButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsFastForwardButtonVisible = value);
public static MediaTransportControls IsFastForwardButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsFastForwardButtonVisibleProperty, binding));

public static MediaTransportControls IsFastForwardEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsFastForwardEnabled = value);
public static MediaTransportControls IsFastForwardEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsFastForwardEnabledProperty, binding));

public static MediaTransportControls IsFastRewindButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsFastRewindButtonVisible = value);
public static MediaTransportControls IsFastRewindButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsFastRewindButtonVisibleProperty, binding));

public static MediaTransportControls IsFastRewindEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsFastRewindEnabled = value);
public static MediaTransportControls IsFastRewindEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsFastRewindEnabledProperty, binding));

public static MediaTransportControls IsFullWindowButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsFullWindowButtonVisible = value);
public static MediaTransportControls IsFullWindowButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsFullWindowButtonVisibleProperty, binding));

public static MediaTransportControls IsFullWindowEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsFullWindowEnabled = value);
public static MediaTransportControls IsFullWindowEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsFullWindowEnabledProperty, binding));

public static MediaTransportControls IsPlaybackRateButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsPlaybackRateButtonVisible = value);
public static MediaTransportControls IsPlaybackRateButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsPlaybackRateButtonVisibleProperty, binding));

public static MediaTransportControls IsPlaybackRateEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsPlaybackRateEnabled = value);
public static MediaTransportControls IsPlaybackRateEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsPlaybackRateEnabledProperty, binding));

public static MediaTransportControls IsSeekBarVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsSeekBarVisible = value);
public static MediaTransportControls IsSeekBarVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsSeekBarVisibleProperty, binding));

public static MediaTransportControls IsSeekEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsSeekEnabled = value);
public static MediaTransportControls IsSeekEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsSeekEnabledProperty, binding));

public static MediaTransportControls IsStopButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsStopButtonVisible = value);
public static MediaTransportControls IsStopButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsStopButtonVisibleProperty, binding));

public static MediaTransportControls IsStopEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsStopEnabled = value);
public static MediaTransportControls IsStopEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsStopEnabledProperty, binding));

public static MediaTransportControls IsVolumeButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsVolumeButtonVisible = value);
public static MediaTransportControls IsVolumeButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsVolumeButtonVisibleProperty, binding));

public static MediaTransportControls IsVolumeEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsVolumeEnabled = value);
public static MediaTransportControls IsVolumeEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsVolumeEnabledProperty, binding));

public static MediaTransportControls IsZoomButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsZoomButtonVisible = value);
public static MediaTransportControls IsZoomButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsZoomButtonVisibleProperty, binding));

public static MediaTransportControls IsZoomEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsZoomEnabled = value);
public static MediaTransportControls IsZoomEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsZoomEnabledProperty, binding));

public static MediaTransportControls FastPlayFallbackBehaviour(this MediaTransportControls control, FastPlayFallbackBehaviour value)
   => control._set(() => control.FastPlayFallbackBehaviour = value);
public static MediaTransportControls FastPlayFallbackBehaviour(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.FastPlayFallbackBehaviourProperty, binding));

public static MediaTransportControls IsNextTrackButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsNextTrackButtonVisible = value);
public static MediaTransportControls IsNextTrackButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsNextTrackButtonVisibleProperty, binding));

public static MediaTransportControls IsPreviousTrackButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsPreviousTrackButtonVisible = value);
public static MediaTransportControls IsPreviousTrackButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsPreviousTrackButtonVisibleProperty, binding));

public static MediaTransportControls IsSkipBackwardButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsSkipBackwardButtonVisible = value);
public static MediaTransportControls IsSkipBackwardButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsSkipBackwardButtonVisibleProperty, binding));

public static MediaTransportControls IsSkipBackwardEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsSkipBackwardEnabled = value);
public static MediaTransportControls IsSkipBackwardEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsSkipBackwardEnabledProperty, binding));

public static MediaTransportControls IsSkipForwardButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsSkipForwardButtonVisible = value);
public static MediaTransportControls IsSkipForwardButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsSkipForwardButtonVisibleProperty, binding));

public static MediaTransportControls IsSkipForwardEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsSkipForwardEnabled = value);
public static MediaTransportControls IsSkipForwardEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsSkipForwardEnabledProperty, binding));

public static MediaTransportControls IsRepeatButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsRepeatButtonVisible = value);
public static MediaTransportControls IsRepeatButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsRepeatButtonVisibleProperty, binding));

public static MediaTransportControls IsRepeatEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsRepeatEnabled = value);
public static MediaTransportControls IsRepeatEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsRepeatEnabledProperty, binding));

public static MediaTransportControls ShowAndHideAutomatically(this MediaTransportControls control, Boolean value)
   => control._set(() => control.ShowAndHideAutomatically = value);
public static MediaTransportControls ShowAndHideAutomatically(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.ShowAndHideAutomaticallyProperty, binding));

public static MediaTransportControls IsCompactOverlayButtonVisible(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsCompactOverlayButtonVisible = value);
public static MediaTransportControls IsCompactOverlayButtonVisible(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsCompactOverlayButtonVisibleProperty, binding));

public static MediaTransportControls IsCompactOverlayEnabled(this MediaTransportControls control, Boolean value)
   => control._set(() => control.IsCompactOverlayEnabled = value);
public static MediaTransportControls IsCompactOverlayEnabled(this MediaTransportControls control, BindingBase binding)
   => control._set(() => control.SetBinding(MediaTransportControls.IsCompactOverlayEnabledProperty, binding));

public static MenuBarItem Title(this MenuBarItem control, String value)
   => control._set(() => control.Title = value);
public static MenuBarItem Title(this MenuBarItem control, BindingBase binding)
   => control._set(() => control.SetBinding(MenuBarItem.TitleProperty, binding));

public static MenuFlyoutItem CommandParameter(this MenuFlyoutItem control, Object value)
   => control._set(() => control.CommandParameter = value);
public static MenuFlyoutItem CommandParameter(this MenuFlyoutItem control, BindingBase binding)
   => control._set(() => control.SetBinding(MenuFlyoutItem.CommandParameterProperty, binding));

public static MenuFlyoutItem Command(this MenuFlyoutItem control, ICommand value)
   => control._set(() => control.Command = value);
public static MenuFlyoutItem Command(this MenuFlyoutItem control, BindingBase binding)
   => control._set(() => control.SetBinding(MenuFlyoutItem.CommandProperty, binding));

public static MenuFlyoutItem Text(this MenuFlyoutItem control, String value)
   => control._set(() => control.Text = value);
public static MenuFlyoutItem Text(this MenuFlyoutItem control, BindingBase binding)
   => control._set(() => control.SetBinding(MenuFlyoutItem.TextProperty, binding));

public static MenuFlyoutItem Icon(this MenuFlyoutItem control, IconElement value)
   => control._set(() => control.Icon = value);
public static MenuFlyoutItem Icon(this MenuFlyoutItem control, BindingBase binding)
   => control._set(() => control.SetBinding(MenuFlyoutItem.IconProperty, binding));

public static MenuFlyoutItem KeyboardAcceleratorTextOverride(this MenuFlyoutItem control, String value)
   => control._set(() => control.KeyboardAcceleratorTextOverride = value);
public static MenuFlyoutItem KeyboardAcceleratorTextOverride(this MenuFlyoutItem control, BindingBase binding)
   => control._set(() => control.SetBinding(MenuFlyoutItem.KeyboardAcceleratorTextOverrideProperty, binding));

public static MenuFlyoutPresenter IsDefaultShadowEnabled(this MenuFlyoutPresenter control, Boolean value)
   => control._set(() => control.IsDefaultShadowEnabled = value);
public static MenuFlyoutPresenter IsDefaultShadowEnabled(this MenuFlyoutPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(MenuFlyoutPresenter.IsDefaultShadowEnabledProperty, binding));

public static MenuFlyoutSubItem Text(this MenuFlyoutSubItem control, String value)
   => control._set(() => control.Text = value);
public static MenuFlyoutSubItem Text(this MenuFlyoutSubItem control, BindingBase binding)
   => control._set(() => control.SetBinding(MenuFlyoutSubItem.TextProperty, binding));

public static MenuFlyoutSubItem Icon(this MenuFlyoutSubItem control, IconElement value)
   => control._set(() => control.Icon = value);
public static MenuFlyoutSubItem Icon(this MenuFlyoutSubItem control, BindingBase binding)
   => control._set(() => control.SetBinding(MenuFlyoutSubItem.IconProperty, binding));

public static NavigationView ExpandedModeThresholdWidth(this NavigationView control, Double value)
   => control._set(() => control.ExpandedModeThresholdWidth = value);
public static NavigationView ExpandedModeThresholdWidth(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.ExpandedModeThresholdWidthProperty, binding));

public static NavigationView IsSettingsVisible(this NavigationView control, Boolean value)
   => control._set(() => control.IsSettingsVisible = value);
public static NavigationView IsSettingsVisible(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.IsSettingsVisibleProperty, binding));

public static NavigationView MenuItemContainerStyle(this NavigationView control, Style value)
   => control._set(() => control.MenuItemContainerStyle = value);
public static NavigationView MenuItemContainerStyle(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.MenuItemContainerStyleProperty, binding));

public static NavigationView MenuItemContainerStyleSelector(this NavigationView control, StyleSelector value)
   => control._set(() => control.MenuItemContainerStyleSelector = value);
public static NavigationView MenuItemContainerStyleSelector(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.MenuItemContainerStyleSelectorProperty, binding));

public static NavigationView MenuItemTemplate(this NavigationView control, DataTemplate value)
   => control._set(() => control.MenuItemTemplate = value);
public static NavigationView MenuItemTemplate(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.MenuItemTemplateProperty, binding));

public static NavigationView MenuItemTemplateSelector(this NavigationView control, DataTemplateSelector value)
   => control._set(() => control.MenuItemTemplateSelector = value);
public static NavigationView MenuItemTemplateSelector(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.MenuItemTemplateSelectorProperty, binding));

public static NavigationView MenuItemsSource(this NavigationView control, Object value)
   => control._set(() => control.MenuItemsSource = value);
public static NavigationView MenuItemsSource(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.MenuItemsSourceProperty, binding));

public static NavigationView OpenPaneLength(this NavigationView control, Double value)
   => control._set(() => control.OpenPaneLength = value);
public static NavigationView OpenPaneLength(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.OpenPaneLengthProperty, binding));

public static NavigationView PaneFooter(this NavigationView control, UIElement value)
   => control._set(() => control.PaneFooter = value);
public static NavigationView PaneFooter(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.PaneFooterProperty, binding));

public static NavigationView PaneToggleButtonStyle(this NavigationView control, Style value)
   => control._set(() => control.PaneToggleButtonStyle = value);
public static NavigationView PaneToggleButtonStyle(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.PaneToggleButtonStyleProperty, binding));

public static NavigationView SelectedItem(this NavigationView control, Object value)
   => control._set(() => control.SelectedItem = value);
public static NavigationView SelectedItem(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.SelectedItemProperty, binding));

public static NavigationView AlwaysShowHeader(this NavigationView control, Boolean value)
   => control._set(() => control.AlwaysShowHeader = value);
public static NavigationView AlwaysShowHeader(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.AlwaysShowHeaderProperty, binding));

public static NavigationView AutoSuggestBox(this NavigationView control, Windows.UI.Xaml.Controls.AutoSuggestBox value)
   => control._set(() => control.AutoSuggestBox = value);
public static NavigationView AutoSuggestBox(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.AutoSuggestBoxProperty, binding));

public static NavigationView CompactModeThresholdWidth(this NavigationView control, Double value)
   => control._set(() => control.CompactModeThresholdWidth = value);
public static NavigationView CompactModeThresholdWidth(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.CompactModeThresholdWidthProperty, binding));

public static NavigationView CompactPaneLength(this NavigationView control, Double value)
   => control._set(() => control.CompactPaneLength = value);
public static NavigationView CompactPaneLength(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.CompactPaneLengthProperty, binding));

public static NavigationView Header(this NavigationView control, Object value)
   => control._set(() => control.Header = value);
public static NavigationView Header(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.HeaderProperty, binding));

public static NavigationView HeaderTemplate(this NavigationView control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static NavigationView HeaderTemplate(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.HeaderTemplateProperty, binding));

public static NavigationView IsPaneOpen(this NavigationView control, Boolean value)
   => control._set(() => control.IsPaneOpen = value);
public static NavigationView IsPaneOpen(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.IsPaneOpenProperty, binding));

public static NavigationView IsPaneToggleButtonVisible(this NavigationView control, Boolean value)
   => control._set(() => control.IsPaneToggleButtonVisible = value);
public static NavigationView IsPaneToggleButtonVisible(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.IsPaneToggleButtonVisibleProperty, binding));

public static NavigationView IsBackButtonVisible(this NavigationView control, NavigationViewBackButtonVisible value)
   => control._set(() => control.IsBackButtonVisible = value);
public static NavigationView IsBackButtonVisible(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.IsBackButtonVisibleProperty, binding));

public static NavigationView IsBackEnabled(this NavigationView control, Boolean value)
   => control._set(() => control.IsBackEnabled = value);
public static NavigationView IsBackEnabled(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.IsBackEnabledProperty, binding));

public static NavigationView PaneTitle(this NavigationView control, String value)
   => control._set(() => control.PaneTitle = value);
public static NavigationView PaneTitle(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.PaneTitleProperty, binding));

public static NavigationView IsPaneVisible(this NavigationView control, Boolean value)
   => control._set(() => control.IsPaneVisible = value);
public static NavigationView IsPaneVisible(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.IsPaneVisibleProperty, binding));

public static NavigationView OverflowLabelMode(this NavigationView control, NavigationViewOverflowLabelMode value)
   => control._set(() => control.OverflowLabelMode = value);
public static NavigationView OverflowLabelMode(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.OverflowLabelModeProperty, binding));

public static NavigationView PaneCustomContent(this NavigationView control, UIElement value)
   => control._set(() => control.PaneCustomContent = value);
public static NavigationView PaneCustomContent(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.PaneCustomContentProperty, binding));

public static NavigationView PaneDisplayMode(this NavigationView control, NavigationViewPaneDisplayMode value)
   => control._set(() => control.PaneDisplayMode = value);
public static NavigationView PaneDisplayMode(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.PaneDisplayModeProperty, binding));

public static NavigationView PaneHeader(this NavigationView control, UIElement value)
   => control._set(() => control.PaneHeader = value);
public static NavigationView PaneHeader(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.PaneHeaderProperty, binding));

public static NavigationView SelectionFollowsFocus(this NavigationView control, NavigationViewSelectionFollowsFocus value)
   => control._set(() => control.SelectionFollowsFocus = value);
public static NavigationView SelectionFollowsFocus(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.SelectionFollowsFocusProperty, binding));

public static NavigationView ShoulderNavigationEnabled(this NavigationView control, NavigationViewShoulderNavigationEnabled value)
   => control._set(() => control.ShoulderNavigationEnabled = value);
public static NavigationView ShoulderNavigationEnabled(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.ShoulderNavigationEnabledProperty, binding));

public static NavigationView ContentOverlay(this NavigationView control, UIElement value)
   => control._set(() => control.ContentOverlay = value);
public static NavigationView ContentOverlay(this NavigationView control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationView.ContentOverlayProperty, binding));

public static NavigationViewItem Icon(this NavigationViewItem control, IconElement value)
   => control._set(() => control.Icon = value);
public static NavigationViewItem Icon(this NavigationViewItem control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationViewItem.IconProperty, binding));

public static NavigationViewItem SelectsOnInvoked(this NavigationViewItem control, Boolean value)
   => control._set(() => control.SelectsOnInvoked = value);
public static NavigationViewItem SelectsOnInvoked(this NavigationViewItem control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationViewItem.SelectsOnInvokedProperty, binding));

public static UserControl Content(this UserControl control, UIElement value)
   => control._set(() => control.Content = value);
public static UserControl Content(this UserControl control, BindingBase binding)
   => control._set(() => control.SetBinding(UserControl.ContentProperty, binding));

public static Page BottomAppBar(this Page control, AppBar value)
   => control._set(() => control.BottomAppBar = value);
public static Page BottomAppBar(this Page control, BindingBase binding)
   => control._set(() => control.SetBinding(Page.BottomAppBarProperty, binding));

public static Page TopAppBar(this Page control, AppBar value)
   => control._set(() => control.TopAppBar = value);
public static Page TopAppBar(this Page control, BindingBase binding)
   => control._set(() => control.SetBinding(Page.TopAppBarProperty, binding));

public static ParallaxView Child(this ParallaxView control, UIElement value)
   => control._set(() => control.Child = value);
public static ParallaxView Child(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.ChildProperty, binding));

public static ParallaxView HorizontalShift(this ParallaxView control, Double value)
   => control._set(() => control.HorizontalShift = value);
public static ParallaxView HorizontalShift(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.HorizontalShiftProperty, binding));

public static ParallaxView HorizontalSourceEndOffset(this ParallaxView control, Double value)
   => control._set(() => control.HorizontalSourceEndOffset = value);
public static ParallaxView HorizontalSourceEndOffset(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.HorizontalSourceEndOffsetProperty, binding));

public static ParallaxView HorizontalSourceOffsetKind(this ParallaxView control, ParallaxSourceOffsetKind value)
   => control._set(() => control.HorizontalSourceOffsetKind = value);
public static ParallaxView HorizontalSourceOffsetKind(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.HorizontalSourceOffsetKindProperty, binding));

public static ParallaxView HorizontalSourceStartOffset(this ParallaxView control, Double value)
   => control._set(() => control.HorizontalSourceStartOffset = value);
public static ParallaxView HorizontalSourceStartOffset(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.HorizontalSourceStartOffsetProperty, binding));

public static ParallaxView IsHorizontalShiftClamped(this ParallaxView control, Boolean value)
   => control._set(() => control.IsHorizontalShiftClamped = value);
public static ParallaxView IsHorizontalShiftClamped(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.IsHorizontalShiftClampedProperty, binding));

public static ParallaxView IsVerticalShiftClamped(this ParallaxView control, Boolean value)
   => control._set(() => control.IsVerticalShiftClamped = value);
public static ParallaxView IsVerticalShiftClamped(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.IsVerticalShiftClampedProperty, binding));

public static ParallaxView MaxHorizontalShiftRatio(this ParallaxView control, Double value)
   => control._set(() => control.MaxHorizontalShiftRatio = value);
public static ParallaxView MaxHorizontalShiftRatio(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.MaxHorizontalShiftRatioProperty, binding));

public static ParallaxView MaxVerticalShiftRatio(this ParallaxView control, Double value)
   => control._set(() => control.MaxVerticalShiftRatio = value);
public static ParallaxView MaxVerticalShiftRatio(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.MaxVerticalShiftRatioProperty, binding));

public static ParallaxView Source(this ParallaxView control, UIElement value)
   => control._set(() => control.Source = value);
public static ParallaxView Source(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.SourceProperty, binding));

public static ParallaxView VerticalShift(this ParallaxView control, Double value)
   => control._set(() => control.VerticalShift = value);
public static ParallaxView VerticalShift(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.VerticalShiftProperty, binding));

public static ParallaxView VerticalSourceEndOffset(this ParallaxView control, Double value)
   => control._set(() => control.VerticalSourceEndOffset = value);
public static ParallaxView VerticalSourceEndOffset(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.VerticalSourceEndOffsetProperty, binding));

public static ParallaxView VerticalSourceOffsetKind(this ParallaxView control, ParallaxSourceOffsetKind value)
   => control._set(() => control.VerticalSourceOffsetKind = value);
public static ParallaxView VerticalSourceOffsetKind(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.VerticalSourceOffsetKindProperty, binding));

public static ParallaxView VerticalSourceStartOffset(this ParallaxView control, Double value)
   => control._set(() => control.VerticalSourceStartOffset = value);
public static ParallaxView VerticalSourceStartOffset(this ParallaxView control, BindingBase binding)
   => control._set(() => control.SetBinding(ParallaxView.VerticalSourceStartOffsetProperty, binding));

public static PasswordBox IsPasswordRevealButtonEnabled(this PasswordBox control, Boolean value)
   => control._set(() => control.IsPasswordRevealButtonEnabled = value);
public static PasswordBox IsPasswordRevealButtonEnabled(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.IsPasswordRevealButtonEnabledProperty, binding));

public static PasswordBox MaxLength(this PasswordBox control, Int32 value)
   => control._set(() => control.MaxLength = value);
public static PasswordBox MaxLength(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.MaxLengthProperty, binding));

public static PasswordBox PasswordChar(this PasswordBox control, String value)
   => control._set(() => control.PasswordChar = value);
public static PasswordBox PasswordChar(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.PasswordCharProperty, binding));

public static PasswordBox Password(this PasswordBox control, String value)
   => control._set(() => control.Password = value);
public static PasswordBox Password(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.PasswordProperty, binding));

public static PasswordBox Header(this PasswordBox control, Object value)
   => control._set(() => control.Header = value);
public static PasswordBox Header(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.HeaderProperty, binding));

public static PasswordBox HeaderTemplate(this PasswordBox control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static PasswordBox HeaderTemplate(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.HeaderTemplateProperty, binding));

public static PasswordBox PlaceholderText(this PasswordBox control, String value)
   => control._set(() => control.PlaceholderText = value);
public static PasswordBox PlaceholderText(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.PlaceholderTextProperty, binding));

public static PasswordBox PreventKeyboardDisplayOnProgrammaticFocus(this PasswordBox control, Boolean value)
   => control._set(() => control.PreventKeyboardDisplayOnProgrammaticFocus = value);
public static PasswordBox PreventKeyboardDisplayOnProgrammaticFocus(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, binding));

public static PasswordBox SelectionHighlightColor(this PasswordBox control, SolidColorBrush value)
   => control._set(() => control.SelectionHighlightColor = value);
public static PasswordBox SelectionHighlightColor(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.SelectionHighlightColorProperty, binding));

public static PasswordBox InputScope(this PasswordBox control, InputScope value)
   => control._set(() => control.InputScope = value);
public static PasswordBox InputScope(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.InputScopeProperty, binding));

public static PasswordBox PasswordRevealMode(this PasswordBox control, PasswordRevealMode value)
   => control._set(() => control.PasswordRevealMode = value);
public static PasswordBox PasswordRevealMode(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.PasswordRevealModeProperty, binding));

public static PasswordBox TextReadingOrder(this PasswordBox control, TextReadingOrder value)
   => control._set(() => control.TextReadingOrder = value);
public static PasswordBox TextReadingOrder(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.TextReadingOrderProperty, binding));

public static PasswordBox Description(this PasswordBox control, Object value)
   => control._set(() => control.Description = value);
public static PasswordBox Description(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.DescriptionProperty, binding));

public static PasswordBox SelectionFlyout(this PasswordBox control, FlyoutBase value)
   => control._set(() => control.SelectionFlyout = value);
public static PasswordBox SelectionFlyout(this PasswordBox control, BindingBase binding)
   => control._set(() => control.SetBinding(PasswordBox.SelectionFlyoutProperty, binding));

public static PathIcon Data(this PathIcon control, Geometry value)
   => control._set(() => control.Data = value);
public static PathIcon Data(this PathIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(PathIcon.DataProperty, binding));

public static PersonPicture BadgeGlyph(this PersonPicture control, String value)
   => control._set(() => control.BadgeGlyph = value);
public static PersonPicture BadgeGlyph(this PersonPicture control, BindingBase binding)
   => control._set(() => control.SetBinding(PersonPicture.BadgeGlyphProperty, binding));

public static PersonPicture BadgeImageSource(this PersonPicture control, ImageSource value)
   => control._set(() => control.BadgeImageSource = value);
public static PersonPicture BadgeImageSource(this PersonPicture control, BindingBase binding)
   => control._set(() => control.SetBinding(PersonPicture.BadgeImageSourceProperty, binding));

public static PersonPicture BadgeNumber(this PersonPicture control, Int32 value)
   => control._set(() => control.BadgeNumber = value);
public static PersonPicture BadgeNumber(this PersonPicture control, BindingBase binding)
   => control._set(() => control.SetBinding(PersonPicture.BadgeNumberProperty, binding));

public static PersonPicture BadgeText(this PersonPicture control, String value)
   => control._set(() => control.BadgeText = value);
public static PersonPicture BadgeText(this PersonPicture control, BindingBase binding)
   => control._set(() => control.SetBinding(PersonPicture.BadgeTextProperty, binding));

public static PersonPicture Contact(this PersonPicture control, Contact value)
   => control._set(() => control.Contact = value);
public static PersonPicture Contact(this PersonPicture control, BindingBase binding)
   => control._set(() => control.SetBinding(PersonPicture.ContactProperty, binding));

public static PersonPicture DisplayName(this PersonPicture control, String value)
   => control._set(() => control.DisplayName = value);
public static PersonPicture DisplayName(this PersonPicture control, BindingBase binding)
   => control._set(() => control.SetBinding(PersonPicture.DisplayNameProperty, binding));

public static PersonPicture Initials(this PersonPicture control, String value)
   => control._set(() => control.Initials = value);
public static PersonPicture Initials(this PersonPicture control, BindingBase binding)
   => control._set(() => control.SetBinding(PersonPicture.InitialsProperty, binding));

public static PersonPicture IsGroup(this PersonPicture control, Boolean value)
   => control._set(() => control.IsGroup = value);
public static PersonPicture IsGroup(this PersonPicture control, BindingBase binding)
   => control._set(() => control.SetBinding(PersonPicture.IsGroupProperty, binding));

public static PersonPicture PreferSmallImage(this PersonPicture control, Boolean value)
   => control._set(() => control.PreferSmallImage = value);
public static PersonPicture PreferSmallImage(this PersonPicture control, BindingBase binding)
   => control._set(() => control.SetBinding(PersonPicture.PreferSmallImageProperty, binding));

public static PersonPicture ProfilePicture(this PersonPicture control, ImageSource value)
   => control._set(() => control.ProfilePicture = value);
public static PersonPicture ProfilePicture(this PersonPicture control, BindingBase binding)
   => control._set(() => control.SetBinding(PersonPicture.ProfilePictureProperty, binding));

public static Pivot HeaderTemplate(this Pivot control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static Pivot HeaderTemplate(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.HeaderTemplateProperty, binding));

public static Pivot IsLocked(this Pivot control, Boolean value)
   => control._set(() => control.IsLocked = value);
public static Pivot IsLocked(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.IsLockedProperty, binding));

public static Pivot SelectedIndex(this Pivot control, Int32 value)
   => control._set(() => control.SelectedIndex = value);
public static Pivot SelectedIndex(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.SelectedIndexProperty, binding));

public static Pivot SelectedItem(this Pivot control, Object value)
   => control._set(() => control.SelectedItem = value);
public static Pivot SelectedItem(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.SelectedItemProperty, binding));

public static Pivot Title(this Pivot control, Object value)
   => control._set(() => control.Title = value);
public static Pivot Title(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.TitleProperty, binding));

public static Pivot TitleTemplate(this Pivot control, DataTemplate value)
   => control._set(() => control.TitleTemplate = value);
public static Pivot TitleTemplate(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.TitleTemplateProperty, binding));

public static Pivot LeftHeader(this Pivot control, Object value)
   => control._set(() => control.LeftHeader = value);
public static Pivot LeftHeader(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.LeftHeaderProperty, binding));

public static Pivot LeftHeaderTemplate(this Pivot control, DataTemplate value)
   => control._set(() => control.LeftHeaderTemplate = value);
public static Pivot LeftHeaderTemplate(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.LeftHeaderTemplateProperty, binding));

public static Pivot RightHeader(this Pivot control, Object value)
   => control._set(() => control.RightHeader = value);
public static Pivot RightHeader(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.RightHeaderProperty, binding));

public static Pivot RightHeaderTemplate(this Pivot control, DataTemplate value)
   => control._set(() => control.RightHeaderTemplate = value);
public static Pivot RightHeaderTemplate(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.RightHeaderTemplateProperty, binding));

public static Pivot HeaderFocusVisualPlacement(this Pivot control, PivotHeaderFocusVisualPlacement value)
   => control._set(() => control.HeaderFocusVisualPlacement = value);
public static Pivot HeaderFocusVisualPlacement(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.HeaderFocusVisualPlacementProperty, binding));

public static Pivot IsHeaderItemsCarouselEnabled(this Pivot control, Boolean value)
   => control._set(() => control.IsHeaderItemsCarouselEnabled = value);
public static Pivot IsHeaderItemsCarouselEnabled(this Pivot control, BindingBase binding)
   => control._set(() => control.SetBinding(Pivot.IsHeaderItemsCarouselEnabledProperty, binding));

public static PivotItem Header(this PivotItem control, Object value)
   => control._set(() => control.Header = value);
public static PivotItem Header(this PivotItem control, BindingBase binding)
   => control._set(() => control.SetBinding(PivotItem.HeaderProperty, binding));

public static RangeBase LargeChange(this RangeBase control, Double value)
   => control._set(() => control.LargeChange = value);
public static RangeBase LargeChange(this RangeBase control, BindingBase binding)
   => control._set(() => control.SetBinding(RangeBase.LargeChangeProperty, binding));

public static RangeBase Maximum(this RangeBase control, Double value)
   => control._set(() => control.Maximum = value);
public static RangeBase Maximum(this RangeBase control, BindingBase binding)
   => control._set(() => control.SetBinding(RangeBase.MaximumProperty, binding));

public static RangeBase Minimum(this RangeBase control, Double value)
   => control._set(() => control.Minimum = value);
public static RangeBase Minimum(this RangeBase control, BindingBase binding)
   => control._set(() => control.SetBinding(RangeBase.MinimumProperty, binding));

public static RangeBase SmallChange(this RangeBase control, Double value)
   => control._set(() => control.SmallChange = value);
public static RangeBase SmallChange(this RangeBase control, BindingBase binding)
   => control._set(() => control.SetBinding(RangeBase.SmallChangeProperty, binding));

public static RangeBase Value(this RangeBase control, Double value)
   => control._set(() => control.Value = value);
public static RangeBase Value(this RangeBase control, BindingBase binding)
   => control._set(() => control.SetBinding(RangeBase.ValueProperty, binding));

public static Slider IntermediateValue(this Slider control, Double value)
   => control._set(() => control.IntermediateValue = value);
public static Slider IntermediateValue(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.IntermediateValueProperty, binding));

public static Slider IsDirectionReversed(this Slider control, Boolean value)
   => control._set(() => control.IsDirectionReversed = value);
public static Slider IsDirectionReversed(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.IsDirectionReversedProperty, binding));

public static Slider IsThumbToolTipEnabled(this Slider control, Boolean value)
   => control._set(() => control.IsThumbToolTipEnabled = value);
public static Slider IsThumbToolTipEnabled(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.IsThumbToolTipEnabledProperty, binding));

public static Slider Orientation(this Slider control, Orientation value)
   => control._set(() => control.Orientation = value);
public static Slider Orientation(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.OrientationProperty, binding));

public static Slider SnapsTo(this Slider control, SliderSnapsTo value)
   => control._set(() => control.SnapsTo = value);
public static Slider SnapsTo(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.SnapsToProperty, binding));

public static Slider StepFrequency(this Slider control, Double value)
   => control._set(() => control.StepFrequency = value);
public static Slider StepFrequency(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.StepFrequencyProperty, binding));

public static Slider ThumbToolTipValueConverter(this Slider control, IValueConverter value)
   => control._set(() => control.ThumbToolTipValueConverter = value);
public static Slider ThumbToolTipValueConverter(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.ThumbToolTipValueConverterProperty, binding));

public static Slider TickFrequency(this Slider control, Double value)
   => control._set(() => control.TickFrequency = value);
public static Slider TickFrequency(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.TickFrequencyProperty, binding));

public static Slider TickPlacement(this Slider control, TickPlacement value)
   => control._set(() => control.TickPlacement = value);
public static Slider TickPlacement(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.TickPlacementProperty, binding));

public static Slider Header(this Slider control, Object value)
   => control._set(() => control.Header = value);
public static Slider Header(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.HeaderProperty, binding));

public static Slider HeaderTemplate(this Slider control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static Slider HeaderTemplate(this Slider control, BindingBase binding)
   => control._set(() => control.SetBinding(Slider.HeaderTemplateProperty, binding));

public static ColorPickerSlider ColorChannel(this ColorPickerSlider control, ColorPickerHsvChannel value)
   => control._set(() => control.ColorChannel = value);
public static ColorPickerSlider ColorChannel(this ColorPickerSlider control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorPickerSlider.ColorChannelProperty, binding));

public static ColorSpectrum Color(this ColorSpectrum control, Color value)
   => control._set(() => control.Color = value);
public static ColorSpectrum Color(this ColorSpectrum control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorSpectrum.ColorProperty, binding));

public static ColorSpectrum Components(this ColorSpectrum control, ColorSpectrumComponents value)
   => control._set(() => control.Components = value);
public static ColorSpectrum Components(this ColorSpectrum control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorSpectrum.ComponentsProperty, binding));

public static ColorSpectrum HsvColor(this ColorSpectrum control, Vector4 value)
   => control._set(() => control.HsvColor = value);
public static ColorSpectrum HsvColor(this ColorSpectrum control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorSpectrum.HsvColorProperty, binding));

public static ColorSpectrum MaxHue(this ColorSpectrum control, Int32 value)
   => control._set(() => control.MaxHue = value);
public static ColorSpectrum MaxHue(this ColorSpectrum control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorSpectrum.MaxHueProperty, binding));

public static ColorSpectrum MaxSaturation(this ColorSpectrum control, Int32 value)
   => control._set(() => control.MaxSaturation = value);
public static ColorSpectrum MaxSaturation(this ColorSpectrum control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorSpectrum.MaxSaturationProperty, binding));

public static ColorSpectrum MaxValue(this ColorSpectrum control, Int32 value)
   => control._set(() => control.MaxValue = value);
public static ColorSpectrum MaxValue(this ColorSpectrum control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorSpectrum.MaxValueProperty, binding));

public static ColorSpectrum MinHue(this ColorSpectrum control, Int32 value)
   => control._set(() => control.MinHue = value);
public static ColorSpectrum MinHue(this ColorSpectrum control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorSpectrum.MinHueProperty, binding));

public static ColorSpectrum MinSaturation(this ColorSpectrum control, Int32 value)
   => control._set(() => control.MinSaturation = value);
public static ColorSpectrum MinSaturation(this ColorSpectrum control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorSpectrum.MinSaturationProperty, binding));

public static ColorSpectrum MinValue(this ColorSpectrum control, Int32 value)
   => control._set(() => control.MinValue = value);
public static ColorSpectrum MinValue(this ColorSpectrum control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorSpectrum.MinValueProperty, binding));

public static ColorSpectrum Shape(this ColorSpectrum control, ColorSpectrumShape value)
   => control._set(() => control.Shape = value);
public static ColorSpectrum Shape(this ColorSpectrum control, BindingBase binding)
   => control._set(() => control.SetBinding(ColorSpectrum.ShapeProperty, binding));

public static GridViewItemPresenter CheckBrush(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.CheckBrush = value);
public static GridViewItemPresenter CheckBrush(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.CheckBrushProperty, binding));

public static GridViewItemPresenter CheckHintBrush(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.CheckHintBrush = value);
public static GridViewItemPresenter CheckHintBrush(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.CheckHintBrushProperty, binding));

public static GridViewItemPresenter CheckSelectingBrush(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.CheckSelectingBrush = value);
public static GridViewItemPresenter CheckSelectingBrush(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.CheckSelectingBrushProperty, binding));

public static GridViewItemPresenter ContentMargin(this GridViewItemPresenter control, Thickness value)
   => control._set(() => control.ContentMargin = value);
public static GridViewItemPresenter ContentMargin(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.ContentMarginProperty, binding));

public static GridViewItemPresenter DisabledOpacity(this GridViewItemPresenter control, Double value)
   => control._set(() => control.DisabledOpacity = value);
public static GridViewItemPresenter DisabledOpacity(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.DisabledOpacityProperty, binding));

public static GridViewItemPresenter DragBackground(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.DragBackground = value);
public static GridViewItemPresenter DragBackground(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.DragBackgroundProperty, binding));

public static GridViewItemPresenter DragForeground(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.DragForeground = value);
public static GridViewItemPresenter DragForeground(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.DragForegroundProperty, binding));

public static GridViewItemPresenter DragOpacity(this GridViewItemPresenter control, Double value)
   => control._set(() => control.DragOpacity = value);
public static GridViewItemPresenter DragOpacity(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.DragOpacityProperty, binding));

public static GridViewItemPresenter FocusBorderBrush(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.FocusBorderBrush = value);
public static GridViewItemPresenter FocusBorderBrush(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.FocusBorderBrushProperty, binding));

public static GridViewItemPresenter GridViewItemPresenterHorizontalContentAlignment(this GridViewItemPresenter control, HorizontalAlignment value)
   => control._set(() => control.GridViewItemPresenterHorizontalContentAlignment = value);
public static GridViewItemPresenter GridViewItemPresenterHorizontalContentAlignment(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.GridViewItemPresenterHorizontalContentAlignmentProperty, binding));

public static GridViewItemPresenter GridViewItemPresenterPadding(this GridViewItemPresenter control, Thickness value)
   => control._set(() => control.GridViewItemPresenterPadding = value);
public static GridViewItemPresenter GridViewItemPresenterPadding(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.GridViewItemPresenterPaddingProperty, binding));

public static GridViewItemPresenter GridViewItemPresenterVerticalContentAlignment(this GridViewItemPresenter control, VerticalAlignment value)
   => control._set(() => control.GridViewItemPresenterVerticalContentAlignment = value);
public static GridViewItemPresenter GridViewItemPresenterVerticalContentAlignment(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.GridViewItemPresenterVerticalContentAlignmentProperty, binding));

public static GridViewItemPresenter PlaceholderBackground(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.PlaceholderBackground = value);
public static GridViewItemPresenter PlaceholderBackground(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.PlaceholderBackgroundProperty, binding));

public static GridViewItemPresenter PointerOverBackgroundMargin(this GridViewItemPresenter control, Thickness value)
   => control._set(() => control.PointerOverBackgroundMargin = value);
public static GridViewItemPresenter PointerOverBackgroundMargin(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.PointerOverBackgroundMarginProperty, binding));

public static GridViewItemPresenter PointerOverBackground(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.PointerOverBackground = value);
public static GridViewItemPresenter PointerOverBackground(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.PointerOverBackgroundProperty, binding));

public static GridViewItemPresenter ReorderHintOffset(this GridViewItemPresenter control, Double value)
   => control._set(() => control.ReorderHintOffset = value);
public static GridViewItemPresenter ReorderHintOffset(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.ReorderHintOffsetProperty, binding));

public static GridViewItemPresenter SelectedBackground(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.SelectedBackground = value);
public static GridViewItemPresenter SelectedBackground(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.SelectedBackgroundProperty, binding));

public static GridViewItemPresenter SelectedBorderThickness(this GridViewItemPresenter control, Thickness value)
   => control._set(() => control.SelectedBorderThickness = value);
public static GridViewItemPresenter SelectedBorderThickness(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.SelectedBorderThicknessProperty, binding));

public static GridViewItemPresenter SelectedForeground(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.SelectedForeground = value);
public static GridViewItemPresenter SelectedForeground(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.SelectedForegroundProperty, binding));

public static GridViewItemPresenter SelectedPointerOverBackground(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.SelectedPointerOverBackground = value);
public static GridViewItemPresenter SelectedPointerOverBackground(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.SelectedPointerOverBackgroundProperty, binding));

public static GridViewItemPresenter SelectedPointerOverBorderBrush(this GridViewItemPresenter control, Brush value)
   => control._set(() => control.SelectedPointerOverBorderBrush = value);
public static GridViewItemPresenter SelectedPointerOverBorderBrush(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.SelectedPointerOverBorderBrushProperty, binding));

public static GridViewItemPresenter SelectionCheckMarkVisualEnabled(this GridViewItemPresenter control, Boolean value)
   => control._set(() => control.SelectionCheckMarkVisualEnabled = value);
public static GridViewItemPresenter SelectionCheckMarkVisualEnabled(this GridViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(GridViewItemPresenter.SelectionCheckMarkVisualEnabledProperty, binding));

public static ListViewItemPresenter CheckBrush(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.CheckBrush = value);
public static ListViewItemPresenter CheckBrush(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.CheckBrushProperty, binding));

public static ListViewItemPresenter CheckHintBrush(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.CheckHintBrush = value);
public static ListViewItemPresenter CheckHintBrush(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.CheckHintBrushProperty, binding));

public static ListViewItemPresenter CheckSelectingBrush(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.CheckSelectingBrush = value);
public static ListViewItemPresenter CheckSelectingBrush(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.CheckSelectingBrushProperty, binding));

public static ListViewItemPresenter ContentMargin(this ListViewItemPresenter control, Thickness value)
   => control._set(() => control.ContentMargin = value);
public static ListViewItemPresenter ContentMargin(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.ContentMarginProperty, binding));

public static ListViewItemPresenter DisabledOpacity(this ListViewItemPresenter control, Double value)
   => control._set(() => control.DisabledOpacity = value);
public static ListViewItemPresenter DisabledOpacity(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.DisabledOpacityProperty, binding));

public static ListViewItemPresenter DragBackground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.DragBackground = value);
public static ListViewItemPresenter DragBackground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.DragBackgroundProperty, binding));

public static ListViewItemPresenter DragForeground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.DragForeground = value);
public static ListViewItemPresenter DragForeground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.DragForegroundProperty, binding));

public static ListViewItemPresenter DragOpacity(this ListViewItemPresenter control, Double value)
   => control._set(() => control.DragOpacity = value);
public static ListViewItemPresenter DragOpacity(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.DragOpacityProperty, binding));

public static ListViewItemPresenter FocusBorderBrush(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.FocusBorderBrush = value);
public static ListViewItemPresenter FocusBorderBrush(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.FocusBorderBrushProperty, binding));

public static ListViewItemPresenter ListViewItemPresenterHorizontalContentAlignment(this ListViewItemPresenter control, HorizontalAlignment value)
   => control._set(() => control.ListViewItemPresenterHorizontalContentAlignment = value);
public static ListViewItemPresenter ListViewItemPresenterHorizontalContentAlignment(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.ListViewItemPresenterHorizontalContentAlignmentProperty, binding));

public static ListViewItemPresenter ListViewItemPresenterPadding(this ListViewItemPresenter control, Thickness value)
   => control._set(() => control.ListViewItemPresenterPadding = value);
public static ListViewItemPresenter ListViewItemPresenterPadding(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.ListViewItemPresenterPaddingProperty, binding));

public static ListViewItemPresenter ListViewItemPresenterVerticalContentAlignment(this ListViewItemPresenter control, VerticalAlignment value)
   => control._set(() => control.ListViewItemPresenterVerticalContentAlignment = value);
public static ListViewItemPresenter ListViewItemPresenterVerticalContentAlignment(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.ListViewItemPresenterVerticalContentAlignmentProperty, binding));

public static ListViewItemPresenter PlaceholderBackground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.PlaceholderBackground = value);
public static ListViewItemPresenter PlaceholderBackground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.PlaceholderBackgroundProperty, binding));

public static ListViewItemPresenter PointerOverBackgroundMargin(this ListViewItemPresenter control, Thickness value)
   => control._set(() => control.PointerOverBackgroundMargin = value);
public static ListViewItemPresenter PointerOverBackgroundMargin(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.PointerOverBackgroundMarginProperty, binding));

public static ListViewItemPresenter PointerOverBackground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.PointerOverBackground = value);
public static ListViewItemPresenter PointerOverBackground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.PointerOverBackgroundProperty, binding));

public static ListViewItemPresenter ReorderHintOffset(this ListViewItemPresenter control, Double value)
   => control._set(() => control.ReorderHintOffset = value);
public static ListViewItemPresenter ReorderHintOffset(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.ReorderHintOffsetProperty, binding));

public static ListViewItemPresenter SelectedBackground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.SelectedBackground = value);
public static ListViewItemPresenter SelectedBackground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.SelectedBackgroundProperty, binding));

public static ListViewItemPresenter SelectedBorderThickness(this ListViewItemPresenter control, Thickness value)
   => control._set(() => control.SelectedBorderThickness = value);
public static ListViewItemPresenter SelectedBorderThickness(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.SelectedBorderThicknessProperty, binding));

public static ListViewItemPresenter SelectedForeground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.SelectedForeground = value);
public static ListViewItemPresenter SelectedForeground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.SelectedForegroundProperty, binding));

public static ListViewItemPresenter SelectedPointerOverBackground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.SelectedPointerOverBackground = value);
public static ListViewItemPresenter SelectedPointerOverBackground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.SelectedPointerOverBackgroundProperty, binding));

public static ListViewItemPresenter SelectedPointerOverBorderBrush(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.SelectedPointerOverBorderBrush = value);
public static ListViewItemPresenter SelectedPointerOverBorderBrush(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.SelectedPointerOverBorderBrushProperty, binding));

public static ListViewItemPresenter SelectionCheckMarkVisualEnabled(this ListViewItemPresenter control, Boolean value)
   => control._set(() => control.SelectionCheckMarkVisualEnabled = value);
public static ListViewItemPresenter SelectionCheckMarkVisualEnabled(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.SelectionCheckMarkVisualEnabledProperty, binding));

public static ListViewItemPresenter CheckBoxBrush(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.CheckBoxBrush = value);
public static ListViewItemPresenter CheckBoxBrush(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.CheckBoxBrushProperty, binding));

public static ListViewItemPresenter CheckMode(this ListViewItemPresenter control, ListViewItemPresenterCheckMode value)
   => control._set(() => control.CheckMode = value);
public static ListViewItemPresenter CheckMode(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.CheckModeProperty, binding));

public static ListViewItemPresenter FocusSecondaryBorderBrush(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.FocusSecondaryBorderBrush = value);
public static ListViewItemPresenter FocusSecondaryBorderBrush(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.FocusSecondaryBorderBrushProperty, binding));

public static ListViewItemPresenter PointerOverForeground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.PointerOverForeground = value);
public static ListViewItemPresenter PointerOverForeground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.PointerOverForegroundProperty, binding));

public static ListViewItemPresenter PressedBackground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.PressedBackground = value);
public static ListViewItemPresenter PressedBackground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.PressedBackgroundProperty, binding));

public static ListViewItemPresenter SelectedPressedBackground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.SelectedPressedBackground = value);
public static ListViewItemPresenter SelectedPressedBackground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.SelectedPressedBackgroundProperty, binding));

public static ListViewItemPresenter RevealBackground(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.RevealBackground = value);
public static ListViewItemPresenter RevealBackground(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.RevealBackgroundProperty, binding));

public static ListViewItemPresenter RevealBackgroundShowsAboveContent(this ListViewItemPresenter control, Boolean value)
   => control._set(() => control.RevealBackgroundShowsAboveContent = value);
public static ListViewItemPresenter RevealBackgroundShowsAboveContent(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.RevealBackgroundShowsAboveContentProperty, binding));

public static ListViewItemPresenter RevealBorderBrush(this ListViewItemPresenter control, Brush value)
   => control._set(() => control.RevealBorderBrush = value);
public static ListViewItemPresenter RevealBorderBrush(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.RevealBorderBrushProperty, binding));

public static ListViewItemPresenter RevealBorderThickness(this ListViewItemPresenter control, Thickness value)
   => control._set(() => control.RevealBorderThickness = value);
public static ListViewItemPresenter RevealBorderThickness(this ListViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ListViewItemPresenter.RevealBorderThicknessProperty, binding));

public static LoopingSelector ItemHeight(this LoopingSelector control, Int32 value)
   => control._set(() => control.ItemHeight = value);
public static LoopingSelector ItemHeight(this LoopingSelector control, BindingBase binding)
   => control._set(() => control.SetBinding(LoopingSelector.ItemHeightProperty, binding));

public static LoopingSelector ItemTemplate(this LoopingSelector control, DataTemplate value)
   => control._set(() => control.ItemTemplate = value);
public static LoopingSelector ItemTemplate(this LoopingSelector control, BindingBase binding)
   => control._set(() => control.SetBinding(LoopingSelector.ItemTemplateProperty, binding));

public static LoopingSelector ItemWidth(this LoopingSelector control, Int32 value)
   => control._set(() => control.ItemWidth = value);
public static LoopingSelector ItemWidth(this LoopingSelector control, BindingBase binding)
   => control._set(() => control.SetBinding(LoopingSelector.ItemWidthProperty, binding));

public static LoopingSelector Items(this LoopingSelector control, IList<Object> value)
   => control._set(() => control.Items = value);
public static LoopingSelector Items(this LoopingSelector control, BindingBase binding)
   => control._set(() => control.SetBinding(LoopingSelector.ItemsProperty, binding));

public static LoopingSelector SelectedIndex(this LoopingSelector control, Int32 value)
   => control._set(() => control.SelectedIndex = value);
public static LoopingSelector SelectedIndex(this LoopingSelector control, BindingBase binding)
   => control._set(() => control.SetBinding(LoopingSelector.SelectedIndexProperty, binding));

public static LoopingSelector SelectedItem(this LoopingSelector control, Object value)
   => control._set(() => control.SelectedItem = value);
public static LoopingSelector SelectedItem(this LoopingSelector control, BindingBase binding)
   => control._set(() => control.SetBinding(LoopingSelector.SelectedItemProperty, binding));

public static LoopingSelector ShouldLoop(this LoopingSelector control, Boolean value)
   => control._set(() => control.ShouldLoop = value);
public static LoopingSelector ShouldLoop(this LoopingSelector control, BindingBase binding)
   => control._set(() => control.SetBinding(LoopingSelector.ShouldLoopProperty, binding));

public static NavigationViewItemPresenter Icon(this NavigationViewItemPresenter control, IconElement value)
   => control._set(() => control.Icon = value);
public static NavigationViewItemPresenter Icon(this NavigationViewItemPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(NavigationViewItemPresenter.IconProperty, binding));

public static Popup Child(this Popup control, UIElement value)
   => control._set(() => control.Child = value);
public static Popup Child(this Popup control, BindingBase binding)
   => control._set(() => control.SetBinding(Popup.ChildProperty, binding));

public static Popup ChildTransitions(this Popup control, TransitionCollection value)
   => control._set(() => control.ChildTransitions = value);
public static Popup ChildTransitions(this Popup control, BindingBase binding)
   => control._set(() => control.SetBinding(Popup.ChildTransitionsProperty, binding));

public static Popup HorizontalOffset(this Popup control, Double value)
   => control._set(() => control.HorizontalOffset = value);
public static Popup HorizontalOffset(this Popup control, BindingBase binding)
   => control._set(() => control.SetBinding(Popup.HorizontalOffsetProperty, binding));

public static Popup IsLightDismissEnabled(this Popup control, Boolean value)
   => control._set(() => control.IsLightDismissEnabled = value);
public static Popup IsLightDismissEnabled(this Popup control, BindingBase binding)
   => control._set(() => control.SetBinding(Popup.IsLightDismissEnabledProperty, binding));

public static Popup IsOpen(this Popup control, Boolean value)
   => control._set(() => control.IsOpen = value);
public static Popup IsOpen(this Popup control, BindingBase binding)
   => control._set(() => control.SetBinding(Popup.IsOpenProperty, binding));

public static Popup VerticalOffset(this Popup control, Double value)
   => control._set(() => control.VerticalOffset = value);
public static Popup VerticalOffset(this Popup control, BindingBase binding)
   => control._set(() => control.SetBinding(Popup.VerticalOffsetProperty, binding));

public static Popup LightDismissOverlayMode(this Popup control, LightDismissOverlayMode value)
   => control._set(() => control.LightDismissOverlayMode = value);
public static Popup LightDismissOverlayMode(this Popup control, BindingBase binding)
   => control._set(() => control.SetBinding(Popup.LightDismissOverlayModeProperty, binding));

public static Popup ShouldConstrainToRootBounds(this Popup control, Boolean value)
   => control._set(() => control.ShouldConstrainToRootBounds = value);
public static Popup ShouldConstrainToRootBounds(this Popup control, BindingBase binding)
   => control._set(() => control.SetBinding(Popup.ShouldConstrainToRootBoundsProperty, binding));

public static RepeatButton Delay(this RepeatButton control, Int32 value)
   => control._set(() => control.Delay = value);
public static RepeatButton Delay(this RepeatButton control, BindingBase binding)
   => control._set(() => control.SetBinding(RepeatButton.DelayProperty, binding));

public static RepeatButton Interval(this RepeatButton control, Int32 value)
   => control._set(() => control.Interval = value);
public static RepeatButton Interval(this RepeatButton control, BindingBase binding)
   => control._set(() => control.SetBinding(RepeatButton.IntervalProperty, binding));

public static ScrollBar IndicatorMode(this ScrollBar control, ScrollingIndicatorMode value)
   => control._set(() => control.IndicatorMode = value);
public static ScrollBar IndicatorMode(this ScrollBar control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollBar.IndicatorModeProperty, binding));

public static ScrollBar Orientation(this ScrollBar control, Orientation value)
   => control._set(() => control.Orientation = value);
public static ScrollBar Orientation(this ScrollBar control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollBar.OrientationProperty, binding));

public static ScrollBar ViewportSize(this ScrollBar control, Double value)
   => control._set(() => control.ViewportSize = value);
public static ScrollBar ViewportSize(this ScrollBar control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollBar.ViewportSizeProperty, binding));

public static TickBar Fill(this TickBar control, Brush value)
   => control._set(() => control.Fill = value);
public static TickBar Fill(this TickBar control, BindingBase binding)
   => control._set(() => control.SetBinding(TickBar.FillProperty, binding));

public static ProgressBar IsIndeterminate(this ProgressBar control, Boolean value)
   => control._set(() => control.IsIndeterminate = value);
public static ProgressBar IsIndeterminate(this ProgressBar control, BindingBase binding)
   => control._set(() => control.SetBinding(ProgressBar.IsIndeterminateProperty, binding));

public static ProgressBar ShowError(this ProgressBar control, Boolean value)
   => control._set(() => control.ShowError = value);
public static ProgressBar ShowError(this ProgressBar control, BindingBase binding)
   => control._set(() => control.SetBinding(ProgressBar.ShowErrorProperty, binding));

public static ProgressBar ShowPaused(this ProgressBar control, Boolean value)
   => control._set(() => control.ShowPaused = value);
public static ProgressBar ShowPaused(this ProgressBar control, BindingBase binding)
   => control._set(() => control.SetBinding(ProgressBar.ShowPausedProperty, binding));

public static ProgressRing IsActive(this ProgressRing control, Boolean value)
   => control._set(() => control.IsActive = value);
public static ProgressRing IsActive(this ProgressRing control, BindingBase binding)
   => control._set(() => control.SetBinding(ProgressRing.IsActiveProperty, binding));

public static RatingControl Caption(this RatingControl control, String value)
   => control._set(() => control.Caption = value);
public static RatingControl Caption(this RatingControl control, BindingBase binding)
   => control._set(() => control.SetBinding(RatingControl.CaptionProperty, binding));

public static RatingControl InitialSetValue(this RatingControl control, Int32 value)
   => control._set(() => control.InitialSetValue = value);
public static RatingControl InitialSetValue(this RatingControl control, BindingBase binding)
   => control._set(() => control.SetBinding(RatingControl.InitialSetValueProperty, binding));

public static RatingControl IsClearEnabled(this RatingControl control, Boolean value)
   => control._set(() => control.IsClearEnabled = value);
public static RatingControl IsClearEnabled(this RatingControl control, BindingBase binding)
   => control._set(() => control.SetBinding(RatingControl.IsClearEnabledProperty, binding));

public static RatingControl IsReadOnly(this RatingControl control, Boolean value)
   => control._set(() => control.IsReadOnly = value);
public static RatingControl IsReadOnly(this RatingControl control, BindingBase binding)
   => control._set(() => control.SetBinding(RatingControl.IsReadOnlyProperty, binding));

public static RatingControl ItemInfo(this RatingControl control, RatingItemInfo value)
   => control._set(() => control.ItemInfo = value);
public static RatingControl ItemInfo(this RatingControl control, BindingBase binding)
   => control._set(() => control.SetBinding(RatingControl.ItemInfoProperty, binding));

public static RatingControl MaxRating(this RatingControl control, Int32 value)
   => control._set(() => control.MaxRating = value);
public static RatingControl MaxRating(this RatingControl control, BindingBase binding)
   => control._set(() => control.SetBinding(RatingControl.MaxRatingProperty, binding));

public static RatingControl PlaceholderValue(this RatingControl control, Double value)
   => control._set(() => control.PlaceholderValue = value);
public static RatingControl PlaceholderValue(this RatingControl control, BindingBase binding)
   => control._set(() => control.SetBinding(RatingControl.PlaceholderValueProperty, binding));

public static RatingControl Value(this RatingControl control, Double value)
   => control._set(() => control.Value = value);
public static RatingControl Value(this RatingControl control, BindingBase binding)
   => control._set(() => control.SetBinding(RatingControl.ValueProperty, binding));

public static RefreshContainer PullDirection(this RefreshContainer control, RefreshPullDirection value)
   => control._set(() => control.PullDirection = value);
public static RefreshContainer PullDirection(this RefreshContainer control, BindingBase binding)
   => control._set(() => control.SetBinding(RefreshContainer.PullDirectionProperty, binding));

public static RefreshContainer Visualizer(this RefreshContainer control, RefreshVisualizer value)
   => control._set(() => control.Visualizer = value);
public static RefreshContainer Visualizer(this RefreshContainer control, BindingBase binding)
   => control._set(() => control.SetBinding(RefreshContainer.VisualizerProperty, binding));

public static RefreshVisualizer Content(this RefreshVisualizer control, UIElement value)
   => control._set(() => control.Content = value);
public static RefreshVisualizer Content(this RefreshVisualizer control, BindingBase binding)
   => control._set(() => control.SetBinding(RefreshVisualizer.ContentProperty, binding));

public static RefreshVisualizer Orientation(this RefreshVisualizer control, RefreshVisualizerOrientation value)
   => control._set(() => control.Orientation = value);
public static RefreshVisualizer Orientation(this RefreshVisualizer control, BindingBase binding)
   => control._set(() => control.SetBinding(RefreshVisualizer.OrientationProperty, binding));

public static RelativePanel BorderBrush(this RelativePanel control, Brush value)
   => control._set(() => control.BorderBrush = value);
public static RelativePanel BorderBrush(this RelativePanel control, BindingBase binding)
   => control._set(() => control.SetBinding(RelativePanel.BorderBrushProperty, binding));

public static RelativePanel BorderThickness(this RelativePanel control, Thickness value)
   => control._set(() => control.BorderThickness = value);
public static RelativePanel BorderThickness(this RelativePanel control, BindingBase binding)
   => control._set(() => control.SetBinding(RelativePanel.BorderThicknessProperty, binding));

public static RelativePanel CornerRadius(this RelativePanel control, CornerRadius value)
   => control._set(() => control.CornerRadius = value);
public static RelativePanel CornerRadius(this RelativePanel control, BindingBase binding)
   => control._set(() => control.SetBinding(RelativePanel.CornerRadiusProperty, binding));

public static RelativePanel Padding(this RelativePanel control, Thickness value)
   => control._set(() => control.Padding = value);
public static RelativePanel Padding(this RelativePanel control, BindingBase binding)
   => control._set(() => control.SetBinding(RelativePanel.PaddingProperty, binding));

public static RelativePanel BackgroundSizing(this RelativePanel control, BackgroundSizing value)
   => control._set(() => control.BackgroundSizing = value);
public static RelativePanel BackgroundSizing(this RelativePanel control, BindingBase binding)
   => control._set(() => control.SetBinding(RelativePanel.BackgroundSizingProperty, binding));

public static RichEditBox AcceptsReturn(this RichEditBox control, Boolean value)
   => control._set(() => control.AcceptsReturn = value);
public static RichEditBox AcceptsReturn(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.AcceptsReturnProperty, binding));

public static RichEditBox InputScope(this RichEditBox control, InputScope value)
   => control._set(() => control.InputScope = value);
public static RichEditBox InputScope(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.InputScopeProperty, binding));

public static RichEditBox IsReadOnly(this RichEditBox control, Boolean value)
   => control._set(() => control.IsReadOnly = value);
public static RichEditBox IsReadOnly(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.IsReadOnlyProperty, binding));

public static RichEditBox IsSpellCheckEnabled(this RichEditBox control, Boolean value)
   => control._set(() => control.IsSpellCheckEnabled = value);
public static RichEditBox IsSpellCheckEnabled(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.IsSpellCheckEnabledProperty, binding));

public static RichEditBox IsTextPredictionEnabled(this RichEditBox control, Boolean value)
   => control._set(() => control.IsTextPredictionEnabled = value);
public static RichEditBox IsTextPredictionEnabled(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.IsTextPredictionEnabledProperty, binding));

public static RichEditBox TextAlignment(this RichEditBox control, TextAlignment value)
   => control._set(() => control.TextAlignment = value);
public static RichEditBox TextAlignment(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.TextAlignmentProperty, binding));

public static RichEditBox TextWrapping(this RichEditBox control, TextWrapping value)
   => control._set(() => control.TextWrapping = value);
public static RichEditBox TextWrapping(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.TextWrappingProperty, binding));

public static RichEditBox Header(this RichEditBox control, Object value)
   => control._set(() => control.Header = value);
public static RichEditBox Header(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.HeaderProperty, binding));

public static RichEditBox HeaderTemplate(this RichEditBox control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static RichEditBox HeaderTemplate(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.HeaderTemplateProperty, binding));

public static RichEditBox IsColorFontEnabled(this RichEditBox control, Boolean value)
   => control._set(() => control.IsColorFontEnabled = value);
public static RichEditBox IsColorFontEnabled(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.IsColorFontEnabledProperty, binding));

public static RichEditBox PlaceholderText(this RichEditBox control, String value)
   => control._set(() => control.PlaceholderText = value);
public static RichEditBox PlaceholderText(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.PlaceholderTextProperty, binding));

public static RichEditBox PreventKeyboardDisplayOnProgrammaticFocus(this RichEditBox control, Boolean value)
   => control._set(() => control.PreventKeyboardDisplayOnProgrammaticFocus = value);
public static RichEditBox PreventKeyboardDisplayOnProgrammaticFocus(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, binding));

public static RichEditBox SelectionHighlightColor(this RichEditBox control, SolidColorBrush value)
   => control._set(() => control.SelectionHighlightColor = value);
public static RichEditBox SelectionHighlightColor(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.SelectionHighlightColorProperty, binding));

public static RichEditBox DesiredCandidateWindowAlignment(this RichEditBox control, CandidateWindowAlignment value)
   => control._set(() => control.DesiredCandidateWindowAlignment = value);
public static RichEditBox DesiredCandidateWindowAlignment(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.DesiredCandidateWindowAlignmentProperty, binding));

public static RichEditBox TextReadingOrder(this RichEditBox control, TextReadingOrder value)
   => control._set(() => control.TextReadingOrder = value);
public static RichEditBox TextReadingOrder(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.TextReadingOrderProperty, binding));

public static RichEditBox ClipboardCopyFormat(this RichEditBox control, RichEditClipboardFormat value)
   => control._set(() => control.ClipboardCopyFormat = value);
public static RichEditBox ClipboardCopyFormat(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.ClipboardCopyFormatProperty, binding));

public static RichEditBox MaxLength(this RichEditBox control, Int32 value)
   => control._set(() => control.MaxLength = value);
public static RichEditBox MaxLength(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.MaxLengthProperty, binding));

public static RichEditBox SelectionHighlightColorWhenNotFocused(this RichEditBox control, SolidColorBrush value)
   => control._set(() => control.SelectionHighlightColorWhenNotFocused = value);
public static RichEditBox SelectionHighlightColorWhenNotFocused(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.SelectionHighlightColorWhenNotFocusedProperty, binding));

public static RichEditBox CharacterCasing(this RichEditBox control, CharacterCasing value)
   => control._set(() => control.CharacterCasing = value);
public static RichEditBox CharacterCasing(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.CharacterCasingProperty, binding));

public static RichEditBox DisabledFormattingAccelerators(this RichEditBox control, DisabledFormattingAccelerators value)
   => control._set(() => control.DisabledFormattingAccelerators = value);
public static RichEditBox DisabledFormattingAccelerators(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.DisabledFormattingAcceleratorsProperty, binding));

public static RichEditBox HorizontalTextAlignment(this RichEditBox control, TextAlignment value)
   => control._set(() => control.HorizontalTextAlignment = value);
public static RichEditBox HorizontalTextAlignment(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.HorizontalTextAlignmentProperty, binding));

public static RichEditBox ContentLinkBackgroundColor(this RichEditBox control, SolidColorBrush value)
   => control._set(() => control.ContentLinkBackgroundColor = value);
public static RichEditBox ContentLinkBackgroundColor(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.ContentLinkBackgroundColorProperty, binding));

public static RichEditBox ContentLinkForegroundColor(this RichEditBox control, SolidColorBrush value)
   => control._set(() => control.ContentLinkForegroundColor = value);
public static RichEditBox ContentLinkForegroundColor(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.ContentLinkForegroundColorProperty, binding));

public static RichEditBox ContentLinkProviders(this RichEditBox control, ContentLinkProviderCollection value)
   => control._set(() => control.ContentLinkProviders = value);
public static RichEditBox ContentLinkProviders(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.ContentLinkProvidersProperty, binding));

public static RichEditBox HandwritingView(this RichEditBox control, Windows.UI.Xaml.Controls.HandwritingView value)
   => control._set(() => control.HandwritingView = value);
public static RichEditBox HandwritingView(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.HandwritingViewProperty, binding));

public static RichEditBox IsHandwritingViewEnabled(this RichEditBox control, Boolean value)
   => control._set(() => control.IsHandwritingViewEnabled = value);
public static RichEditBox IsHandwritingViewEnabled(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.IsHandwritingViewEnabledProperty, binding));

public static RichEditBox Description(this RichEditBox control, Object value)
   => control._set(() => control.Description = value);
public static RichEditBox Description(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.DescriptionProperty, binding));

public static RichEditBox SelectionFlyout(this RichEditBox control, FlyoutBase value)
   => control._set(() => control.SelectionFlyout = value);
public static RichEditBox SelectionFlyout(this RichEditBox control, BindingBase binding)
   => control._set(() => control.SetBinding(RichEditBox.SelectionFlyoutProperty, binding));

public static RichTextBlock CharacterSpacing(this RichTextBlock control, Int32 value)
   => control._set(() => control.CharacterSpacing = value);
public static RichTextBlock CharacterSpacing(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.CharacterSpacingProperty, binding));

public static RichTextBlock FontFamily(this RichTextBlock control, FontFamily value)
   => control._set(() => control.FontFamily = value);
public static RichTextBlock FontFamily(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.FontFamilyProperty, binding));

public static RichTextBlock FontSize(this RichTextBlock control, Double value)
   => control._set(() => control.FontSize = value);
public static RichTextBlock FontSize(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.FontSizeProperty, binding));

public static RichTextBlock FontStretch(this RichTextBlock control, FontStretch value)
   => control._set(() => control.FontStretch = value);
public static RichTextBlock FontStretch(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.FontStretchProperty, binding));

public static RichTextBlock FontStyle(this RichTextBlock control, FontStyle value)
   => control._set(() => control.FontStyle = value);
public static RichTextBlock FontStyle(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.FontStyleProperty, binding));

public static RichTextBlock FontWeight(this RichTextBlock control, FontWeight value)
   => control._set(() => control.FontWeight = value);
public static RichTextBlock FontWeight(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.FontWeightProperty, binding));

public static RichTextBlock Foreground(this RichTextBlock control, Brush value)
   => control._set(() => control.Foreground = value);
public static RichTextBlock Foreground(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.ForegroundProperty, binding));

public static RichTextBlock IsTextSelectionEnabled(this RichTextBlock control, Boolean value)
   => control._set(() => control.IsTextSelectionEnabled = value);
public static RichTextBlock IsTextSelectionEnabled(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.IsTextSelectionEnabledProperty, binding));

public static RichTextBlock LineHeight(this RichTextBlock control, Double value)
   => control._set(() => control.LineHeight = value);
public static RichTextBlock LineHeight(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.LineHeightProperty, binding));

public static RichTextBlock LineStackingStrategy(this RichTextBlock control, LineStackingStrategy value)
   => control._set(() => control.LineStackingStrategy = value);
public static RichTextBlock LineStackingStrategy(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.LineStackingStrategyProperty, binding));

public static RichTextBlock OverflowContentTarget(this RichTextBlock control, RichTextBlockOverflow value)
   => control._set(() => control.OverflowContentTarget = value);
public static RichTextBlock OverflowContentTarget(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.OverflowContentTargetProperty, binding));

public static RichTextBlock Padding(this RichTextBlock control, Thickness value)
   => control._set(() => control.Padding = value);
public static RichTextBlock Padding(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.PaddingProperty, binding));

public static RichTextBlock TextAlignment(this RichTextBlock control, TextAlignment value)
   => control._set(() => control.TextAlignment = value);
public static RichTextBlock TextAlignment(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.TextAlignmentProperty, binding));

public static RichTextBlock TextIndent(this RichTextBlock control, Double value)
   => control._set(() => control.TextIndent = value);
public static RichTextBlock TextIndent(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.TextIndentProperty, binding));

public static RichTextBlock TextTrimming(this RichTextBlock control, TextTrimming value)
   => control._set(() => control.TextTrimming = value);
public static RichTextBlock TextTrimming(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.TextTrimmingProperty, binding));

public static RichTextBlock TextWrapping(this RichTextBlock control, TextWrapping value)
   => control._set(() => control.TextWrapping = value);
public static RichTextBlock TextWrapping(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.TextWrappingProperty, binding));

public static RichTextBlock IsColorFontEnabled(this RichTextBlock control, Boolean value)
   => control._set(() => control.IsColorFontEnabled = value);
public static RichTextBlock IsColorFontEnabled(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.IsColorFontEnabledProperty, binding));

public static RichTextBlock MaxLines(this RichTextBlock control, Int32 value)
   => control._set(() => control.MaxLines = value);
public static RichTextBlock MaxLines(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.MaxLinesProperty, binding));

public static RichTextBlock OpticalMarginAlignment(this RichTextBlock control, OpticalMarginAlignment value)
   => control._set(() => control.OpticalMarginAlignment = value);
public static RichTextBlock OpticalMarginAlignment(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.OpticalMarginAlignmentProperty, binding));

public static RichTextBlock SelectionHighlightColor(this RichTextBlock control, SolidColorBrush value)
   => control._set(() => control.SelectionHighlightColor = value);
public static RichTextBlock SelectionHighlightColor(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.SelectionHighlightColorProperty, binding));

public static RichTextBlock TextLineBounds(this RichTextBlock control, TextLineBounds value)
   => control._set(() => control.TextLineBounds = value);
public static RichTextBlock TextLineBounds(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.TextLineBoundsProperty, binding));

public static RichTextBlock TextReadingOrder(this RichTextBlock control, TextReadingOrder value)
   => control._set(() => control.TextReadingOrder = value);
public static RichTextBlock TextReadingOrder(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.TextReadingOrderProperty, binding));

public static RichTextBlock IsTextScaleFactorEnabled(this RichTextBlock control, Boolean value)
   => control._set(() => control.IsTextScaleFactorEnabled = value);
public static RichTextBlock IsTextScaleFactorEnabled(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.IsTextScaleFactorEnabledProperty, binding));

public static RichTextBlock TextDecorations(this RichTextBlock control, TextDecorations value)
   => control._set(() => control.TextDecorations = value);
public static RichTextBlock TextDecorations(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.TextDecorationsProperty, binding));

public static RichTextBlock HorizontalTextAlignment(this RichTextBlock control, TextAlignment value)
   => control._set(() => control.HorizontalTextAlignment = value);
public static RichTextBlock HorizontalTextAlignment(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.HorizontalTextAlignmentProperty, binding));

public static RichTextBlock SelectionFlyout(this RichTextBlock control, FlyoutBase value)
   => control._set(() => control.SelectionFlyout = value);
public static RichTextBlock SelectionFlyout(this RichTextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlock.SelectionFlyoutProperty, binding));

public static RichTextBlockOverflow OverflowContentTarget(this RichTextBlockOverflow control, RichTextBlockOverflow value)
   => control._set(() => control.OverflowContentTarget = value);
public static RichTextBlockOverflow OverflowContentTarget(this RichTextBlockOverflow control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlockOverflow.OverflowContentTargetProperty, binding));

public static RichTextBlockOverflow Padding(this RichTextBlockOverflow control, Thickness value)
   => control._set(() => control.Padding = value);
public static RichTextBlockOverflow Padding(this RichTextBlockOverflow control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlockOverflow.PaddingProperty, binding));

public static RichTextBlockOverflow MaxLines(this RichTextBlockOverflow control, Int32 value)
   => control._set(() => control.MaxLines = value);
public static RichTextBlockOverflow MaxLines(this RichTextBlockOverflow control, BindingBase binding)
   => control._set(() => control.SetBinding(RichTextBlockOverflow.MaxLinesProperty, binding));

public static ScrollContentPresenter CanContentRenderOutsideBounds(this ScrollContentPresenter control, Boolean value)
   => control._set(() => control.CanContentRenderOutsideBounds = value);
public static ScrollContentPresenter CanContentRenderOutsideBounds(this ScrollContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollContentPresenter.CanContentRenderOutsideBoundsProperty, binding));

public static ScrollContentPresenter SizesContentToTemplatedParent(this ScrollContentPresenter control, Boolean value)
   => control._set(() => control.SizesContentToTemplatedParent = value);
public static ScrollContentPresenter SizesContentToTemplatedParent(this ScrollContentPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollContentPresenter.SizesContentToTemplatedParentProperty, binding));

public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer control, Boolean value)
   => control._set(() => control.IsScrollInertiaEnabled = value);
public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.IsScrollInertiaEnabledProperty, binding));

public static ScrollViewer VerticalSnapPointsType(this ScrollViewer control, SnapPointsType value)
   => control._set(() => control.VerticalSnapPointsType = value);
public static ScrollViewer VerticalSnapPointsType(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.VerticalSnapPointsTypeProperty, binding));

public static ScrollViewer ZoomMode(this ScrollViewer control, ZoomMode value)
   => control._set(() => control.ZoomMode = value);
public static ScrollViewer ZoomMode(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.ZoomModeProperty, binding));

public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer control, Boolean value)
   => control._set(() => control.BringIntoViewOnFocusChange = value);
public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.BringIntoViewOnFocusChangeProperty, binding));

public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, ScrollBarVisibility value)
   => control._set(() => control.HorizontalScrollBarVisibility = value);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.HorizontalScrollBarVisibilityProperty, binding));

public static ScrollViewer HorizontalScrollMode(this ScrollViewer control, ScrollMode value)
   => control._set(() => control.HorizontalScrollMode = value);
public static ScrollViewer HorizontalScrollMode(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.HorizontalScrollModeProperty, binding));

public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer control, SnapPointsAlignment value)
   => control._set(() => control.HorizontalSnapPointsAlignment = value);
public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding));

public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer control, SnapPointsType value)
   => control._set(() => control.HorizontalSnapPointsType = value);
public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.HorizontalSnapPointsTypeProperty, binding));

public static ScrollViewer IsDeferredScrollingEnabled(this ScrollViewer control, Boolean value)
   => control._set(() => control.IsDeferredScrollingEnabled = value);
public static ScrollViewer IsDeferredScrollingEnabled(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.IsDeferredScrollingEnabledProperty, binding));

public static ScrollViewer IsHorizontalRailEnabled(this ScrollViewer control, Boolean value)
   => control._set(() => control.IsHorizontalRailEnabled = value);
public static ScrollViewer IsHorizontalRailEnabled(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.IsHorizontalRailEnabledProperty, binding));

public static ScrollViewer IsHorizontalScrollChainingEnabled(this ScrollViewer control, Boolean value)
   => control._set(() => control.IsHorizontalScrollChainingEnabled = value);
public static ScrollViewer IsHorizontalScrollChainingEnabled(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.IsHorizontalScrollChainingEnabledProperty, binding));

public static ScrollViewer ZoomSnapPointsType(this ScrollViewer control, SnapPointsType value)
   => control._set(() => control.ZoomSnapPointsType = value);
public static ScrollViewer ZoomSnapPointsType(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.ZoomSnapPointsTypeProperty, binding));

public static ScrollViewer IsVerticalRailEnabled(this ScrollViewer control, Boolean value)
   => control._set(() => control.IsVerticalRailEnabled = value);
public static ScrollViewer IsVerticalRailEnabled(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.IsVerticalRailEnabledProperty, binding));

public static ScrollViewer IsVerticalScrollChainingEnabled(this ScrollViewer control, Boolean value)
   => control._set(() => control.IsVerticalScrollChainingEnabled = value);
public static ScrollViewer IsVerticalScrollChainingEnabled(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.IsVerticalScrollChainingEnabledProperty, binding));

public static ScrollViewer IsZoomChainingEnabled(this ScrollViewer control, Boolean value)
   => control._set(() => control.IsZoomChainingEnabled = value);
public static ScrollViewer IsZoomChainingEnabled(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.IsZoomChainingEnabledProperty, binding));

public static ScrollViewer IsZoomInertiaEnabled(this ScrollViewer control, Boolean value)
   => control._set(() => control.IsZoomInertiaEnabled = value);
public static ScrollViewer IsZoomInertiaEnabled(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.IsZoomInertiaEnabledProperty, binding));

public static ScrollViewer MaxZoomFactor(this ScrollViewer control, Single value)
   => control._set(() => control.MaxZoomFactor = value);
public static ScrollViewer MaxZoomFactor(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.MaxZoomFactorProperty, binding));

public static ScrollViewer MinZoomFactor(this ScrollViewer control, Single value)
   => control._set(() => control.MinZoomFactor = value);
public static ScrollViewer MinZoomFactor(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.MinZoomFactorProperty, binding));

public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, ScrollBarVisibility value)
   => control._set(() => control.VerticalScrollBarVisibility = value);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.VerticalScrollBarVisibilityProperty, binding));

public static ScrollViewer VerticalScrollMode(this ScrollViewer control, ScrollMode value)
   => control._set(() => control.VerticalScrollMode = value);
public static ScrollViewer VerticalScrollMode(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.VerticalScrollModeProperty, binding));

public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer control, SnapPointsAlignment value)
   => control._set(() => control.VerticalSnapPointsAlignment = value);
public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.VerticalSnapPointsAlignmentProperty, binding));

public static ScrollViewer LeftHeader(this ScrollViewer control, UIElement value)
   => control._set(() => control.LeftHeader = value);
public static ScrollViewer LeftHeader(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.LeftHeaderProperty, binding));

public static ScrollViewer TopHeader(this ScrollViewer control, UIElement value)
   => control._set(() => control.TopHeader = value);
public static ScrollViewer TopHeader(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.TopHeaderProperty, binding));

public static ScrollViewer TopLeftHeader(this ScrollViewer control, UIElement value)
   => control._set(() => control.TopLeftHeader = value);
public static ScrollViewer TopLeftHeader(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.TopLeftHeaderProperty, binding));

public static ScrollViewer HorizontalAnchorRatio(this ScrollViewer control, Double value)
   => control._set(() => control.HorizontalAnchorRatio = value);
public static ScrollViewer HorizontalAnchorRatio(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.HorizontalAnchorRatioProperty, binding));

public static ScrollViewer ReduceViewportForCoreInputViewOcclusions(this ScrollViewer control, Boolean value)
   => control._set(() => control.ReduceViewportForCoreInputViewOcclusions = value);
public static ScrollViewer ReduceViewportForCoreInputViewOcclusions(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.ReduceViewportForCoreInputViewOcclusionsProperty, binding));

public static ScrollViewer VerticalAnchorRatio(this ScrollViewer control, Double value)
   => control._set(() => control.VerticalAnchorRatio = value);
public static ScrollViewer VerticalAnchorRatio(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.VerticalAnchorRatioProperty, binding));

public static ScrollViewer CanContentRenderOutsideBounds(this ScrollViewer control, Boolean value)
   => control._set(() => control.CanContentRenderOutsideBounds = value);
public static ScrollViewer CanContentRenderOutsideBounds(this ScrollViewer control, BindingBase binding)
   => control._set(() => control.SetBinding(ScrollViewer.CanContentRenderOutsideBoundsProperty, binding));

public static SearchBox ChooseSuggestionOnEnter(this SearchBox control, Boolean value)
   => control._set(() => control.ChooseSuggestionOnEnter = value);
public static SearchBox ChooseSuggestionOnEnter(this SearchBox control, BindingBase binding)
   => control._set(() => control.SetBinding(SearchBox.ChooseSuggestionOnEnterProperty, binding));

public static SearchBox FocusOnKeyboardInput(this SearchBox control, Boolean value)
   => control._set(() => control.FocusOnKeyboardInput = value);
public static SearchBox FocusOnKeyboardInput(this SearchBox control, BindingBase binding)
   => control._set(() => control.SetBinding(SearchBox.FocusOnKeyboardInputProperty, binding));

public static SearchBox PlaceholderText(this SearchBox control, String value)
   => control._set(() => control.PlaceholderText = value);
public static SearchBox PlaceholderText(this SearchBox control, BindingBase binding)
   => control._set(() => control.SetBinding(SearchBox.PlaceholderTextProperty, binding));

public static SearchBox QueryText(this SearchBox control, String value)
   => control._set(() => control.QueryText = value);
public static SearchBox QueryText(this SearchBox control, BindingBase binding)
   => control._set(() => control.SetBinding(SearchBox.QueryTextProperty, binding));

public static SearchBox SearchHistoryContext(this SearchBox control, String value)
   => control._set(() => control.SearchHistoryContext = value);
public static SearchBox SearchHistoryContext(this SearchBox control, BindingBase binding)
   => control._set(() => control.SetBinding(SearchBox.SearchHistoryContextProperty, binding));

public static SearchBox SearchHistoryEnabled(this SearchBox control, Boolean value)
   => control._set(() => control.SearchHistoryEnabled = value);
public static SearchBox SearchHistoryEnabled(this SearchBox control, BindingBase binding)
   => control._set(() => control.SetBinding(SearchBox.SearchHistoryEnabledProperty, binding));

public static SemanticZoom CanChangeViews(this SemanticZoom control, Boolean value)
   => control._set(() => control.CanChangeViews = value);
public static SemanticZoom CanChangeViews(this SemanticZoom control, BindingBase binding)
   => control._set(() => control.SetBinding(SemanticZoom.CanChangeViewsProperty, binding));

public static SemanticZoom IsZoomOutButtonEnabled(this SemanticZoom control, Boolean value)
   => control._set(() => control.IsZoomOutButtonEnabled = value);
public static SemanticZoom IsZoomOutButtonEnabled(this SemanticZoom control, BindingBase binding)
   => control._set(() => control.SetBinding(SemanticZoom.IsZoomOutButtonEnabledProperty, binding));

public static SemanticZoom IsZoomedInViewActive(this SemanticZoom control, Boolean value)
   => control._set(() => control.IsZoomedInViewActive = value);
public static SemanticZoom IsZoomedInViewActive(this SemanticZoom control, BindingBase binding)
   => control._set(() => control.SetBinding(SemanticZoom.IsZoomedInViewActiveProperty, binding));

public static SemanticZoom ZoomedInView(this SemanticZoom control, ISemanticZoomInformation value)
   => control._set(() => control.ZoomedInView = value);
public static SemanticZoom ZoomedInView(this SemanticZoom control, BindingBase binding)
   => control._set(() => control.SetBinding(SemanticZoom.ZoomedInViewProperty, binding));

public static SemanticZoom ZoomedOutView(this SemanticZoom control, ISemanticZoomInformation value)
   => control._set(() => control.ZoomedOutView = value);
public static SemanticZoom ZoomedOutView(this SemanticZoom control, BindingBase binding)
   => control._set(() => control.SetBinding(SemanticZoom.ZoomedOutViewProperty, binding));

public static SettingsFlyout HeaderBackground(this SettingsFlyout control, Brush value)
   => control._set(() => control.HeaderBackground = value);
public static SettingsFlyout HeaderBackground(this SettingsFlyout control, BindingBase binding)
   => control._set(() => control.SetBinding(SettingsFlyout.HeaderBackgroundProperty, binding));

public static SettingsFlyout HeaderForeground(this SettingsFlyout control, Brush value)
   => control._set(() => control.HeaderForeground = value);
public static SettingsFlyout HeaderForeground(this SettingsFlyout control, BindingBase binding)
   => control._set(() => control.SetBinding(SettingsFlyout.HeaderForegroundProperty, binding));

public static SettingsFlyout IconSource(this SettingsFlyout control, ImageSource value)
   => control._set(() => control.IconSource = value);
public static SettingsFlyout IconSource(this SettingsFlyout control, BindingBase binding)
   => control._set(() => control.SetBinding(SettingsFlyout.IconSourceProperty, binding));

public static SettingsFlyout Title(this SettingsFlyout control, String value)
   => control._set(() => control.Title = value);
public static SettingsFlyout Title(this SettingsFlyout control, BindingBase binding)
   => control._set(() => control.SetBinding(SettingsFlyout.TitleProperty, binding));

public static SplitButton CommandParameter(this SplitButton control, Object value)
   => control._set(() => control.CommandParameter = value);
public static SplitButton CommandParameter(this SplitButton control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitButton.CommandParameterProperty, binding));

public static SplitButton Command(this SplitButton control, ICommand value)
   => control._set(() => control.Command = value);
public static SplitButton Command(this SplitButton control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitButton.CommandProperty, binding));

public static SplitButton Flyout(this SplitButton control, FlyoutBase value)
   => control._set(() => control.Flyout = value);
public static SplitButton Flyout(this SplitButton control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitButton.FlyoutProperty, binding));

public static SplitView CompactPaneLength(this SplitView control, Double value)
   => control._set(() => control.CompactPaneLength = value);
public static SplitView CompactPaneLength(this SplitView control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitView.CompactPaneLengthProperty, binding));

public static SplitView Content(this SplitView control, UIElement value)
   => control._set(() => control.Content = value);
public static SplitView Content(this SplitView control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitView.ContentProperty, binding));

public static SplitView DisplayMode(this SplitView control, SplitViewDisplayMode value)
   => control._set(() => control.DisplayMode = value);
public static SplitView DisplayMode(this SplitView control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitView.DisplayModeProperty, binding));

public static SplitView IsPaneOpen(this SplitView control, Boolean value)
   => control._set(() => control.IsPaneOpen = value);
public static SplitView IsPaneOpen(this SplitView control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitView.IsPaneOpenProperty, binding));

public static SplitView OpenPaneLength(this SplitView control, Double value)
   => control._set(() => control.OpenPaneLength = value);
public static SplitView OpenPaneLength(this SplitView control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitView.OpenPaneLengthProperty, binding));

public static SplitView PaneBackground(this SplitView control, Brush value)
   => control._set(() => control.PaneBackground = value);
public static SplitView PaneBackground(this SplitView control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitView.PaneBackgroundProperty, binding));

public static SplitView PanePlacement(this SplitView control, SplitViewPanePlacement value)
   => control._set(() => control.PanePlacement = value);
public static SplitView PanePlacement(this SplitView control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitView.PanePlacementProperty, binding));

public static SplitView Pane(this SplitView control, UIElement value)
   => control._set(() => control.Pane = value);
public static SplitView Pane(this SplitView control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitView.PaneProperty, binding));

public static SplitView LightDismissOverlayMode(this SplitView control, LightDismissOverlayMode value)
   => control._set(() => control.LightDismissOverlayMode = value);
public static SplitView LightDismissOverlayMode(this SplitView control, BindingBase binding)
   => control._set(() => control.SetBinding(SplitView.LightDismissOverlayModeProperty, binding));

public static StackPanel AreScrollSnapPointsRegular(this StackPanel control, Boolean value)
   => control._set(() => control.AreScrollSnapPointsRegular = value);
public static StackPanel AreScrollSnapPointsRegular(this StackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(StackPanel.AreScrollSnapPointsRegularProperty, binding));

public static StackPanel Orientation(this StackPanel control, Orientation value)
   => control._set(() => control.Orientation = value);
public static StackPanel Orientation(this StackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(StackPanel.OrientationProperty, binding));

public static StackPanel BorderBrush(this StackPanel control, Brush value)
   => control._set(() => control.BorderBrush = value);
public static StackPanel BorderBrush(this StackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(StackPanel.BorderBrushProperty, binding));

public static StackPanel BorderThickness(this StackPanel control, Thickness value)
   => control._set(() => control.BorderThickness = value);
public static StackPanel BorderThickness(this StackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(StackPanel.BorderThicknessProperty, binding));

public static StackPanel CornerRadius(this StackPanel control, CornerRadius value)
   => control._set(() => control.CornerRadius = value);
public static StackPanel CornerRadius(this StackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(StackPanel.CornerRadiusProperty, binding));

public static StackPanel Padding(this StackPanel control, Thickness value)
   => control._set(() => control.Padding = value);
public static StackPanel Padding(this StackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(StackPanel.PaddingProperty, binding));

public static StackPanel Spacing(this StackPanel control, Double value)
   => control._set(() => control.Spacing = value);
public static StackPanel Spacing(this StackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(StackPanel.SpacingProperty, binding));

public static StackPanel BackgroundSizing(this StackPanel control, BackgroundSizing value)
   => control._set(() => control.BackgroundSizing = value);
public static StackPanel BackgroundSizing(this StackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(StackPanel.BackgroundSizingProperty, binding));

public static SwipeControl BottomItems(this SwipeControl control, SwipeItems value)
   => control._set(() => control.BottomItems = value);
public static SwipeControl BottomItems(this SwipeControl control, BindingBase binding)
   => control._set(() => control.SetBinding(SwipeControl.BottomItemsProperty, binding));

public static SwipeControl LeftItems(this SwipeControl control, SwipeItems value)
   => control._set(() => control.LeftItems = value);
public static SwipeControl LeftItems(this SwipeControl control, BindingBase binding)
   => control._set(() => control.SetBinding(SwipeControl.LeftItemsProperty, binding));

public static SwipeControl RightItems(this SwipeControl control, SwipeItems value)
   => control._set(() => control.RightItems = value);
public static SwipeControl RightItems(this SwipeControl control, BindingBase binding)
   => control._set(() => control.SetBinding(SwipeControl.RightItemsProperty, binding));

public static SwipeControl TopItems(this SwipeControl control, SwipeItems value)
   => control._set(() => control.TopItems = value);
public static SwipeControl TopItems(this SwipeControl control, BindingBase binding)
   => control._set(() => control.SetBinding(SwipeControl.TopItemsProperty, binding));

public static SymbolIcon Symbol(this SymbolIcon control, Symbol value)
   => control._set(() => control.Symbol = value);
public static SymbolIcon Symbol(this SymbolIcon control, BindingBase binding)
   => control._set(() => control.SetBinding(SymbolIcon.SymbolProperty, binding));

public static TextBlock CharacterSpacing(this TextBlock control, Int32 value)
   => control._set(() => control.CharacterSpacing = value);
public static TextBlock CharacterSpacing(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.CharacterSpacingProperty, binding));

public static TextBlock FontFamily(this TextBlock control, FontFamily value)
   => control._set(() => control.FontFamily = value);
public static TextBlock FontFamily(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.FontFamilyProperty, binding));

public static TextBlock FontSize(this TextBlock control, Double value)
   => control._set(() => control.FontSize = value);
public static TextBlock FontSize(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.FontSizeProperty, binding));

public static TextBlock FontStretch(this TextBlock control, FontStretch value)
   => control._set(() => control.FontStretch = value);
public static TextBlock FontStretch(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.FontStretchProperty, binding));

public static TextBlock FontStyle(this TextBlock control, FontStyle value)
   => control._set(() => control.FontStyle = value);
public static TextBlock FontStyle(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.FontStyleProperty, binding));

public static TextBlock FontWeight(this TextBlock control, FontWeight value)
   => control._set(() => control.FontWeight = value);
public static TextBlock FontWeight(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.FontWeightProperty, binding));

public static TextBlock Foreground(this TextBlock control, Brush value)
   => control._set(() => control.Foreground = value);
public static TextBlock Foreground(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.ForegroundProperty, binding));

public static TextBlock IsTextSelectionEnabled(this TextBlock control, Boolean value)
   => control._set(() => control.IsTextSelectionEnabled = value);
public static TextBlock IsTextSelectionEnabled(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.IsTextSelectionEnabledProperty, binding));

public static TextBlock LineHeight(this TextBlock control, Double value)
   => control._set(() => control.LineHeight = value);
public static TextBlock LineHeight(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.LineHeightProperty, binding));

public static TextBlock LineStackingStrategy(this TextBlock control, LineStackingStrategy value)
   => control._set(() => control.LineStackingStrategy = value);
public static TextBlock LineStackingStrategy(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.LineStackingStrategyProperty, binding));

public static TextBlock Padding(this TextBlock control, Thickness value)
   => control._set(() => control.Padding = value);
public static TextBlock Padding(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.PaddingProperty, binding));

public static TextBlock TextAlignment(this TextBlock control, TextAlignment value)
   => control._set(() => control.TextAlignment = value);
public static TextBlock TextAlignment(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.TextAlignmentProperty, binding));

public static TextBlock Text(this TextBlock control, String value)
   => control._set(() => control.Text = value);
public static TextBlock Text(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.TextProperty, binding));

public static TextBlock TextTrimming(this TextBlock control, TextTrimming value)
   => control._set(() => control.TextTrimming = value);
public static TextBlock TextTrimming(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.TextTrimmingProperty, binding));

public static TextBlock TextWrapping(this TextBlock control, TextWrapping value)
   => control._set(() => control.TextWrapping = value);
public static TextBlock TextWrapping(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.TextWrappingProperty, binding));

public static TextBlock IsColorFontEnabled(this TextBlock control, Boolean value)
   => control._set(() => control.IsColorFontEnabled = value);
public static TextBlock IsColorFontEnabled(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.IsColorFontEnabledProperty, binding));

public static TextBlock MaxLines(this TextBlock control, Int32 value)
   => control._set(() => control.MaxLines = value);
public static TextBlock MaxLines(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.MaxLinesProperty, binding));

public static TextBlock OpticalMarginAlignment(this TextBlock control, OpticalMarginAlignment value)
   => control._set(() => control.OpticalMarginAlignment = value);
public static TextBlock OpticalMarginAlignment(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.OpticalMarginAlignmentProperty, binding));

public static TextBlock SelectionHighlightColor(this TextBlock control, SolidColorBrush value)
   => control._set(() => control.SelectionHighlightColor = value);
public static TextBlock SelectionHighlightColor(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.SelectionHighlightColorProperty, binding));

public static TextBlock TextLineBounds(this TextBlock control, TextLineBounds value)
   => control._set(() => control.TextLineBounds = value);
public static TextBlock TextLineBounds(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.TextLineBoundsProperty, binding));

public static TextBlock TextReadingOrder(this TextBlock control, TextReadingOrder value)
   => control._set(() => control.TextReadingOrder = value);
public static TextBlock TextReadingOrder(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.TextReadingOrderProperty, binding));

public static TextBlock IsTextScaleFactorEnabled(this TextBlock control, Boolean value)
   => control._set(() => control.IsTextScaleFactorEnabled = value);
public static TextBlock IsTextScaleFactorEnabled(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.IsTextScaleFactorEnabledProperty, binding));

public static TextBlock TextDecorations(this TextBlock control, TextDecorations value)
   => control._set(() => control.TextDecorations = value);
public static TextBlock TextDecorations(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.TextDecorationsProperty, binding));

public static TextBlock HorizontalTextAlignment(this TextBlock control, TextAlignment value)
   => control._set(() => control.HorizontalTextAlignment = value);
public static TextBlock HorizontalTextAlignment(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.HorizontalTextAlignmentProperty, binding));

public static TextBlock SelectionFlyout(this TextBlock control, FlyoutBase value)
   => control._set(() => control.SelectionFlyout = value);
public static TextBlock SelectionFlyout(this TextBlock control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBlock.SelectionFlyoutProperty, binding));

public static TextBox TextWrapping(this TextBox control, TextWrapping value)
   => control._set(() => control.TextWrapping = value);
public static TextBox TextWrapping(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.TextWrappingProperty, binding));

public static TextBox Text(this TextBox control, String value)
   => control._set(() => control.Text = value);
public static TextBox Text(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.TextProperty, binding));

public static TextBox TextAlignment(this TextBox control, TextAlignment value)
   => control._set(() => control.TextAlignment = value);
public static TextBox TextAlignment(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.TextAlignmentProperty, binding));

public static TextBox MaxLength(this TextBox control, Int32 value)
   => control._set(() => control.MaxLength = value);
public static TextBox MaxLength(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.MaxLengthProperty, binding));

public static TextBox IsTextPredictionEnabled(this TextBox control, Boolean value)
   => control._set(() => control.IsTextPredictionEnabled = value);
public static TextBox IsTextPredictionEnabled(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.IsTextPredictionEnabledProperty, binding));

public static TextBox IsSpellCheckEnabled(this TextBox control, Boolean value)
   => control._set(() => control.IsSpellCheckEnabled = value);
public static TextBox IsSpellCheckEnabled(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.IsSpellCheckEnabledProperty, binding));

public static TextBox IsReadOnly(this TextBox control, Boolean value)
   => control._set(() => control.IsReadOnly = value);
public static TextBox IsReadOnly(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.IsReadOnlyProperty, binding));

public static TextBox InputScope(this TextBox control, InputScope value)
   => control._set(() => control.InputScope = value);
public static TextBox InputScope(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.InputScopeProperty, binding));

public static TextBox AcceptsReturn(this TextBox control, Boolean value)
   => control._set(() => control.AcceptsReturn = value);
public static TextBox AcceptsReturn(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.AcceptsReturnProperty, binding));

public static TextBox HeaderTemplate(this TextBox control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static TextBox HeaderTemplate(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.HeaderTemplateProperty, binding));

public static TextBox Header(this TextBox control, Object value)
   => control._set(() => control.Header = value);
public static TextBox Header(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.HeaderProperty, binding));

public static TextBox SelectionHighlightColor(this TextBox control, SolidColorBrush value)
   => control._set(() => control.SelectionHighlightColor = value);
public static TextBox SelectionHighlightColor(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.SelectionHighlightColorProperty, binding));

public static TextBox PreventKeyboardDisplayOnProgrammaticFocus(this TextBox control, Boolean value)
   => control._set(() => control.PreventKeyboardDisplayOnProgrammaticFocus = value);
public static TextBox PreventKeyboardDisplayOnProgrammaticFocus(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, binding));

public static TextBox PlaceholderText(this TextBox control, String value)
   => control._set(() => control.PlaceholderText = value);
public static TextBox PlaceholderText(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.PlaceholderTextProperty, binding));

public static TextBox IsColorFontEnabled(this TextBox control, Boolean value)
   => control._set(() => control.IsColorFontEnabled = value);
public static TextBox IsColorFontEnabled(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.IsColorFontEnabledProperty, binding));

public static TextBox DesiredCandidateWindowAlignment(this TextBox control, CandidateWindowAlignment value)
   => control._set(() => control.DesiredCandidateWindowAlignment = value);
public static TextBox DesiredCandidateWindowAlignment(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.DesiredCandidateWindowAlignmentProperty, binding));

public static TextBox TextReadingOrder(this TextBox control, TextReadingOrder value)
   => control._set(() => control.TextReadingOrder = value);
public static TextBox TextReadingOrder(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.TextReadingOrderProperty, binding));

public static TextBox SelectionHighlightColorWhenNotFocused(this TextBox control, SolidColorBrush value)
   => control._set(() => control.SelectionHighlightColorWhenNotFocused = value);
public static TextBox SelectionHighlightColorWhenNotFocused(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.SelectionHighlightColorWhenNotFocusedProperty, binding));

public static TextBox PlaceholderForeground(this TextBox control, Brush value)
   => control._set(() => control.PlaceholderForeground = value);
public static TextBox PlaceholderForeground(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.PlaceholderForegroundProperty, binding));

public static TextBox HorizontalTextAlignment(this TextBox control, TextAlignment value)
   => control._set(() => control.HorizontalTextAlignment = value);
public static TextBox HorizontalTextAlignment(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.HorizontalTextAlignmentProperty, binding));

public static TextBox CharacterCasing(this TextBox control, CharacterCasing value)
   => control._set(() => control.CharacterCasing = value);
public static TextBox CharacterCasing(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.CharacterCasingProperty, binding));

public static TextBox IsHandwritingViewEnabled(this TextBox control, Boolean value)
   => control._set(() => control.IsHandwritingViewEnabled = value);
public static TextBox IsHandwritingViewEnabled(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.IsHandwritingViewEnabledProperty, binding));

public static TextBox HandwritingView(this TextBox control, Windows.UI.Xaml.Controls.HandwritingView value)
   => control._set(() => control.HandwritingView = value);
public static TextBox HandwritingView(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.HandwritingViewProperty, binding));

public static TextBox SelectionFlyout(this TextBox control, FlyoutBase value)
   => control._set(() => control.SelectionFlyout = value);
public static TextBox SelectionFlyout(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.SelectionFlyoutProperty, binding));

public static TextBox Description(this TextBox control, Object value)
   => control._set(() => control.Description = value);
public static TextBox Description(this TextBox control, BindingBase binding)
   => control._set(() => control.SetBinding(TextBox.DescriptionProperty, binding));

public static TimePicker ClockIdentifier(this TimePicker control, String value)
   => control._set(() => control.ClockIdentifier = value);
public static TimePicker ClockIdentifier(this TimePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(TimePicker.ClockIdentifierProperty, binding));

public static TimePicker Header(this TimePicker control, Object value)
   => control._set(() => control.Header = value);
public static TimePicker Header(this TimePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(TimePicker.HeaderProperty, binding));

public static TimePicker HeaderTemplate(this TimePicker control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static TimePicker HeaderTemplate(this TimePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(TimePicker.HeaderTemplateProperty, binding));

public static TimePicker MinuteIncrement(this TimePicker control, Int32 value)
   => control._set(() => control.MinuteIncrement = value);
public static TimePicker MinuteIncrement(this TimePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(TimePicker.MinuteIncrementProperty, binding));

public static TimePicker Time(this TimePicker control, TimeSpan value)
   => control._set(() => control.Time = value);
public static TimePicker Time(this TimePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(TimePicker.TimeProperty, binding));

public static TimePicker LightDismissOverlayMode(this TimePicker control, LightDismissOverlayMode value)
   => control._set(() => control.LightDismissOverlayMode = value);
public static TimePicker LightDismissOverlayMode(this TimePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(TimePicker.LightDismissOverlayModeProperty, binding));

public static TimePicker SelectedTime(this TimePicker control, Nullable<TimeSpan> value)
   => control._set(() => control.SelectedTime = value);
public static TimePicker SelectedTime(this TimePicker control, BindingBase binding)
   => control._set(() => control.SetBinding(TimePicker.SelectedTimeProperty, binding));

public static TimePickerFlyoutPresenter IsDefaultShadowEnabled(this TimePickerFlyoutPresenter control, Boolean value)
   => control._set(() => control.IsDefaultShadowEnabled = value);
public static TimePickerFlyoutPresenter IsDefaultShadowEnabled(this TimePickerFlyoutPresenter control, BindingBase binding)
   => control._set(() => control.SetBinding(TimePickerFlyoutPresenter.IsDefaultShadowEnabledProperty, binding));

public static ToggleMenuFlyoutItem IsChecked(this ToggleMenuFlyoutItem control, Boolean value)
   => control._set(() => control.IsChecked = value);
public static ToggleMenuFlyoutItem IsChecked(this ToggleMenuFlyoutItem control, BindingBase binding)
   => control._set(() => control.SetBinding(ToggleMenuFlyoutItem.IsCheckedProperty, binding));

public static ToggleSwitch Header(this ToggleSwitch control, Object value)
   => control._set(() => control.Header = value);
public static ToggleSwitch Header(this ToggleSwitch control, BindingBase binding)
   => control._set(() => control.SetBinding(ToggleSwitch.HeaderProperty, binding));

public static ToggleSwitch HeaderTemplate(this ToggleSwitch control, DataTemplate value)
   => control._set(() => control.HeaderTemplate = value);
public static ToggleSwitch HeaderTemplate(this ToggleSwitch control, BindingBase binding)
   => control._set(() => control.SetBinding(ToggleSwitch.HeaderTemplateProperty, binding));

public static ToggleSwitch IsOn(this ToggleSwitch control, Boolean value)
   => control._set(() => control.IsOn = value);
public static ToggleSwitch IsOn(this ToggleSwitch control, BindingBase binding)
   => control._set(() => control.SetBinding(ToggleSwitch.IsOnProperty, binding));

public static ToggleSwitch OffContent(this ToggleSwitch control, Object value)
   => control._set(() => control.OffContent = value);
public static ToggleSwitch OffContent(this ToggleSwitch control, BindingBase binding)
   => control._set(() => control.SetBinding(ToggleSwitch.OffContentProperty, binding));

public static ToggleSwitch OffContentTemplate(this ToggleSwitch control, DataTemplate value)
   => control._set(() => control.OffContentTemplate = value);
public static ToggleSwitch OffContentTemplate(this ToggleSwitch control, BindingBase binding)
   => control._set(() => control.SetBinding(ToggleSwitch.OffContentTemplateProperty, binding));

public static ToggleSwitch OnContent(this ToggleSwitch control, Object value)
   => control._set(() => control.OnContent = value);
public static ToggleSwitch OnContent(this ToggleSwitch control, BindingBase binding)
   => control._set(() => control.SetBinding(ToggleSwitch.OnContentProperty, binding));

public static ToggleSwitch OnContentTemplate(this ToggleSwitch control, DataTemplate value)
   => control._set(() => control.OnContentTemplate = value);
public static ToggleSwitch OnContentTemplate(this ToggleSwitch control, BindingBase binding)
   => control._set(() => control.SetBinding(ToggleSwitch.OnContentTemplateProperty, binding));

public static ToolTip HorizontalOffset(this ToolTip control, Double value)
   => control._set(() => control.HorizontalOffset = value);
public static ToolTip HorizontalOffset(this ToolTip control, BindingBase binding)
   => control._set(() => control.SetBinding(ToolTip.HorizontalOffsetProperty, binding));

public static ToolTip IsOpen(this ToolTip control, Boolean value)
   => control._set(() => control.IsOpen = value);
public static ToolTip IsOpen(this ToolTip control, BindingBase binding)
   => control._set(() => control.SetBinding(ToolTip.IsOpenProperty, binding));

public static ToolTip Placement(this ToolTip control, PlacementMode value)
   => control._set(() => control.Placement = value);
public static ToolTip Placement(this ToolTip control, BindingBase binding)
   => control._set(() => control.SetBinding(ToolTip.PlacementProperty, binding));

public static ToolTip PlacementTarget(this ToolTip control, UIElement value)
   => control._set(() => control.PlacementTarget = value);
public static ToolTip PlacementTarget(this ToolTip control, BindingBase binding)
   => control._set(() => control.SetBinding(ToolTip.PlacementTargetProperty, binding));

public static ToolTip VerticalOffset(this ToolTip control, Double value)
   => control._set(() => control.VerticalOffset = value);
public static ToolTip VerticalOffset(this ToolTip control, BindingBase binding)
   => control._set(() => control.SetBinding(ToolTip.VerticalOffsetProperty, binding));

public static ToolTip PlacementRect(this ToolTip control, Nullable<Rect> value)
   => control._set(() => control.PlacementRect = value);
public static ToolTip PlacementRect(this ToolTip control, BindingBase binding)
   => control._set(() => control.SetBinding(ToolTip.PlacementRectProperty, binding));

public static TreeView SelectionMode(this TreeView control, TreeViewSelectionMode value)
   => control._set(() => control.SelectionMode = value);
public static TreeView SelectionMode(this TreeView control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeView.SelectionModeProperty, binding));

public static TreeView CanDragItems(this TreeView control, Boolean value)
   => control._set(() => control.CanDragItems = value);
public static TreeView CanDragItems(this TreeView control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeView.CanDragItemsProperty, binding));

public static TreeView CanReorderItems(this TreeView control, Boolean value)
   => control._set(() => control.CanReorderItems = value);
public static TreeView CanReorderItems(this TreeView control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeView.CanReorderItemsProperty, binding));

public static TreeView ItemContainerStyle(this TreeView control, Style value)
   => control._set(() => control.ItemContainerStyle = value);
public static TreeView ItemContainerStyle(this TreeView control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeView.ItemContainerStyleProperty, binding));

public static TreeView ItemContainerStyleSelector(this TreeView control, StyleSelector value)
   => control._set(() => control.ItemContainerStyleSelector = value);
public static TreeView ItemContainerStyleSelector(this TreeView control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeView.ItemContainerStyleSelectorProperty, binding));

public static TreeView ItemContainerTransitions(this TreeView control, TransitionCollection value)
   => control._set(() => control.ItemContainerTransitions = value);
public static TreeView ItemContainerTransitions(this TreeView control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeView.ItemContainerTransitionsProperty, binding));

public static TreeView ItemTemplate(this TreeView control, DataTemplate value)
   => control._set(() => control.ItemTemplate = value);
public static TreeView ItemTemplate(this TreeView control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeView.ItemTemplateProperty, binding));

public static TreeView ItemTemplateSelector(this TreeView control, DataTemplateSelector value)
   => control._set(() => control.ItemTemplateSelector = value);
public static TreeView ItemTemplateSelector(this TreeView control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeView.ItemTemplateSelectorProperty, binding));

public static TreeView ItemsSource(this TreeView control, Object value)
   => control._set(() => control.ItemsSource = value);
public static TreeView ItemsSource(this TreeView control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeView.ItemsSourceProperty, binding));

public static TreeViewItem CollapsedGlyph(this TreeViewItem control, String value)
   => control._set(() => control.CollapsedGlyph = value);
public static TreeViewItem CollapsedGlyph(this TreeViewItem control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeViewItem.CollapsedGlyphProperty, binding));

public static TreeViewItem ExpandedGlyph(this TreeViewItem control, String value)
   => control._set(() => control.ExpandedGlyph = value);
public static TreeViewItem ExpandedGlyph(this TreeViewItem control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeViewItem.ExpandedGlyphProperty, binding));

public static TreeViewItem GlyphBrush(this TreeViewItem control, Brush value)
   => control._set(() => control.GlyphBrush = value);
public static TreeViewItem GlyphBrush(this TreeViewItem control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeViewItem.GlyphBrushProperty, binding));

public static TreeViewItem GlyphOpacity(this TreeViewItem control, Double value)
   => control._set(() => control.GlyphOpacity = value);
public static TreeViewItem GlyphOpacity(this TreeViewItem control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeViewItem.GlyphOpacityProperty, binding));

public static TreeViewItem GlyphSize(this TreeViewItem control, Double value)
   => control._set(() => control.GlyphSize = value);
public static TreeViewItem GlyphSize(this TreeViewItem control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeViewItem.GlyphSizeProperty, binding));

public static TreeViewItem IsExpanded(this TreeViewItem control, Boolean value)
   => control._set(() => control.IsExpanded = value);
public static TreeViewItem IsExpanded(this TreeViewItem control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeViewItem.IsExpandedProperty, binding));

public static TreeViewItem HasUnrealizedChildren(this TreeViewItem control, Boolean value)
   => control._set(() => control.HasUnrealizedChildren = value);
public static TreeViewItem HasUnrealizedChildren(this TreeViewItem control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeViewItem.HasUnrealizedChildrenProperty, binding));

public static TreeViewItem ItemsSource(this TreeViewItem control, Object value)
   => control._set(() => control.ItemsSource = value);
public static TreeViewItem ItemsSource(this TreeViewItem control, BindingBase binding)
   => control._set(() => control.SetBinding(TreeViewItem.ItemsSourceProperty, binding));

public static TwoPaneView MinTallModeHeight(this TwoPaneView control, Double value)
   => control._set(() => control.MinTallModeHeight = value);
public static TwoPaneView MinTallModeHeight(this TwoPaneView control, BindingBase binding)
   => control._set(() => control.SetBinding(TwoPaneView.MinTallModeHeightProperty, binding));

public static TwoPaneView MinWideModeWidth(this TwoPaneView control, Double value)
   => control._set(() => control.MinWideModeWidth = value);
public static TwoPaneView MinWideModeWidth(this TwoPaneView control, BindingBase binding)
   => control._set(() => control.SetBinding(TwoPaneView.MinWideModeWidthProperty, binding));

public static TwoPaneView Pane1Length(this TwoPaneView control, GridLength value)
   => control._set(() => control.Pane1Length = value);
public static TwoPaneView Pane1Length(this TwoPaneView control, BindingBase binding)
   => control._set(() => control.SetBinding(TwoPaneView.Pane1LengthProperty, binding));

public static TwoPaneView Pane1(this TwoPaneView control, UIElement value)
   => control._set(() => control.Pane1 = value);
public static TwoPaneView Pane1(this TwoPaneView control, BindingBase binding)
   => control._set(() => control.SetBinding(TwoPaneView.Pane1Property, binding));

public static TwoPaneView Pane2Length(this TwoPaneView control, GridLength value)
   => control._set(() => control.Pane2Length = value);
public static TwoPaneView Pane2Length(this TwoPaneView control, BindingBase binding)
   => control._set(() => control.SetBinding(TwoPaneView.Pane2LengthProperty, binding));

public static TwoPaneView Pane2(this TwoPaneView control, UIElement value)
   => control._set(() => control.Pane2 = value);
public static TwoPaneView Pane2(this TwoPaneView control, BindingBase binding)
   => control._set(() => control.SetBinding(TwoPaneView.Pane2Property, binding));

public static TwoPaneView PanePriority(this TwoPaneView control, TwoPaneViewPriority value)
   => control._set(() => control.PanePriority = value);
public static TwoPaneView PanePriority(this TwoPaneView control, BindingBase binding)
   => control._set(() => control.SetBinding(TwoPaneView.PanePriorityProperty, binding));

public static TwoPaneView TallModeConfiguration(this TwoPaneView control, TwoPaneViewTallModeConfiguration value)
   => control._set(() => control.TallModeConfiguration = value);
public static TwoPaneView TallModeConfiguration(this TwoPaneView control, BindingBase binding)
   => control._set(() => control.SetBinding(TwoPaneView.TallModeConfigurationProperty, binding));

public static TwoPaneView WideModeConfiguration(this TwoPaneView control, TwoPaneViewWideModeConfiguration value)
   => control._set(() => control.WideModeConfiguration = value);
public static TwoPaneView WideModeConfiguration(this TwoPaneView control, BindingBase binding)
   => control._set(() => control.SetBinding(TwoPaneView.WideModeConfigurationProperty, binding));

public static VariableSizedWrapGrid HorizontalChildrenAlignment(this VariableSizedWrapGrid control, HorizontalAlignment value)
   => control._set(() => control.HorizontalChildrenAlignment = value);
public static VariableSizedWrapGrid HorizontalChildrenAlignment(this VariableSizedWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(VariableSizedWrapGrid.HorizontalChildrenAlignmentProperty, binding));

public static VariableSizedWrapGrid ItemHeight(this VariableSizedWrapGrid control, Double value)
   => control._set(() => control.ItemHeight = value);
public static VariableSizedWrapGrid ItemHeight(this VariableSizedWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(VariableSizedWrapGrid.ItemHeightProperty, binding));

public static VariableSizedWrapGrid ItemWidth(this VariableSizedWrapGrid control, Double value)
   => control._set(() => control.ItemWidth = value);
public static VariableSizedWrapGrid ItemWidth(this VariableSizedWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(VariableSizedWrapGrid.ItemWidthProperty, binding));

public static VariableSizedWrapGrid MaximumRowsOrColumns(this VariableSizedWrapGrid control, Int32 value)
   => control._set(() => control.MaximumRowsOrColumns = value);
public static VariableSizedWrapGrid MaximumRowsOrColumns(this VariableSizedWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(VariableSizedWrapGrid.MaximumRowsOrColumnsProperty, binding));

public static VariableSizedWrapGrid Orientation(this VariableSizedWrapGrid control, Orientation value)
   => control._set(() => control.Orientation = value);
public static VariableSizedWrapGrid Orientation(this VariableSizedWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(VariableSizedWrapGrid.OrientationProperty, binding));

public static VariableSizedWrapGrid VerticalChildrenAlignment(this VariableSizedWrapGrid control, VerticalAlignment value)
   => control._set(() => control.VerticalChildrenAlignment = value);
public static VariableSizedWrapGrid VerticalChildrenAlignment(this VariableSizedWrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(VariableSizedWrapGrid.VerticalChildrenAlignmentProperty, binding));

public static Viewbox StretchDirection(this Viewbox control, StretchDirection value)
   => control._set(() => control.StretchDirection = value);
public static Viewbox StretchDirection(this Viewbox control, BindingBase binding)
   => control._set(() => control.SetBinding(Viewbox.StretchDirectionProperty, binding));

public static Viewbox Stretch(this Viewbox control, Stretch value)
   => control._set(() => control.Stretch = value);
public static Viewbox Stretch(this Viewbox control, BindingBase binding)
   => control._set(() => control.SetBinding(Viewbox.StretchProperty, binding));

public static VirtualizingStackPanel AreScrollSnapPointsRegular(this VirtualizingStackPanel control, Boolean value)
   => control._set(() => control.AreScrollSnapPointsRegular = value);
public static VirtualizingStackPanel AreScrollSnapPointsRegular(this VirtualizingStackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(VirtualizingStackPanel.AreScrollSnapPointsRegularProperty, binding));

public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel control, Orientation value)
   => control._set(() => control.Orientation = value);
public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel control, BindingBase binding)
   => control._set(() => control.SetBinding(VirtualizingStackPanel.OrientationProperty, binding));

public static WebView AllowedScriptNotifyUris(this WebView control, IList<Uri> value)
   => control._set(() => control.AllowedScriptNotifyUris = value);
public static WebView AllowedScriptNotifyUris(this WebView control, BindingBase binding)
   => control._set(() => control.SetBinding(WebView.AllowedScriptNotifyUrisProperty, binding));

public static WebView Source(this WebView control, Uri value)
   => control._set(() => control.Source = value);
public static WebView Source(this WebView control, BindingBase binding)
   => control._set(() => control.SetBinding(WebView.SourceProperty, binding));

public static WebView DefaultBackgroundColor(this WebView control, Color value)
   => control._set(() => control.DefaultBackgroundColor = value);
public static WebView DefaultBackgroundColor(this WebView control, BindingBase binding)
   => control._set(() => control.SetBinding(WebView.DefaultBackgroundColorProperty, binding));

public static WebView XYFocusDown(this WebView control, DependencyObject value)
   => control._set(() => control.XYFocusDown = value);
public static WebView XYFocusDown(this WebView control, BindingBase binding)
   => control._set(() => control.SetBinding(WebView.XYFocusDownProperty, binding));

public static WebView XYFocusLeft(this WebView control, DependencyObject value)
   => control._set(() => control.XYFocusLeft = value);
public static WebView XYFocusLeft(this WebView control, BindingBase binding)
   => control._set(() => control.SetBinding(WebView.XYFocusLeftProperty, binding));

public static WebView XYFocusRight(this WebView control, DependencyObject value)
   => control._set(() => control.XYFocusRight = value);
public static WebView XYFocusRight(this WebView control, BindingBase binding)
   => control._set(() => control.SetBinding(WebView.XYFocusRightProperty, binding));

public static WebView XYFocusUp(this WebView control, DependencyObject value)
   => control._set(() => control.XYFocusUp = value);
public static WebView XYFocusUp(this WebView control, BindingBase binding)
   => control._set(() => control.SetBinding(WebView.XYFocusUpProperty, binding));

public static WrapGrid HorizontalChildrenAlignment(this WrapGrid control, HorizontalAlignment value)
   => control._set(() => control.HorizontalChildrenAlignment = value);
public static WrapGrid HorizontalChildrenAlignment(this WrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(WrapGrid.HorizontalChildrenAlignmentProperty, binding));

public static WrapGrid ItemHeight(this WrapGrid control, Double value)
   => control._set(() => control.ItemHeight = value);
public static WrapGrid ItemHeight(this WrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(WrapGrid.ItemHeightProperty, binding));

public static WrapGrid ItemWidth(this WrapGrid control, Double value)
   => control._set(() => control.ItemWidth = value);
public static WrapGrid ItemWidth(this WrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(WrapGrid.ItemWidthProperty, binding));

public static WrapGrid MaximumRowsOrColumns(this WrapGrid control, Int32 value)
   => control._set(() => control.MaximumRowsOrColumns = value);
public static WrapGrid MaximumRowsOrColumns(this WrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(WrapGrid.MaximumRowsOrColumnsProperty, binding));

public static WrapGrid Orientation(this WrapGrid control, Orientation value)
   => control._set(() => control.Orientation = value);
public static WrapGrid Orientation(this WrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(WrapGrid.OrientationProperty, binding));

public static WrapGrid VerticalChildrenAlignment(this WrapGrid control, VerticalAlignment value)
   => control._set(() => control.VerticalChildrenAlignment = value);
public static WrapGrid VerticalChildrenAlignment(this WrapGrid control, BindingBase binding)
   => control._set(() => control.SetBinding(WrapGrid.VerticalChildrenAlignmentProperty, binding));

public static Glyphs Fill(this Glyphs control, Brush value)
   => control._set(() => control.Fill = value);
public static Glyphs Fill(this Glyphs control, BindingBase binding)
   => control._set(() => control.SetBinding(Glyphs.FillProperty, binding));

public static Glyphs FontRenderingEmSize(this Glyphs control, Double value)
   => control._set(() => control.FontRenderingEmSize = value);
public static Glyphs FontRenderingEmSize(this Glyphs control, BindingBase binding)
   => control._set(() => control.SetBinding(Glyphs.FontRenderingEmSizeProperty, binding));

public static Glyphs FontUri(this Glyphs control, Uri value)
   => control._set(() => control.FontUri = value);
public static Glyphs FontUri(this Glyphs control, BindingBase binding)
   => control._set(() => control.SetBinding(Glyphs.FontUriProperty, binding));

public static Glyphs Indices(this Glyphs control, String value)
   => control._set(() => control.Indices = value);
public static Glyphs Indices(this Glyphs control, BindingBase binding)
   => control._set(() => control.SetBinding(Glyphs.IndicesProperty, binding));

public static Glyphs OriginX(this Glyphs control, Double value)
   => control._set(() => control.OriginX = value);
public static Glyphs OriginX(this Glyphs control, BindingBase binding)
   => control._set(() => control.SetBinding(Glyphs.OriginXProperty, binding));

public static Glyphs OriginY(this Glyphs control, Double value)
   => control._set(() => control.OriginY = value);
public static Glyphs OriginY(this Glyphs control, BindingBase binding)
   => control._set(() => control.SetBinding(Glyphs.OriginYProperty, binding));

public static Glyphs StyleSimulations(this Glyphs control, StyleSimulations value)
   => control._set(() => control.StyleSimulations = value);
public static Glyphs StyleSimulations(this Glyphs control, BindingBase binding)
   => control._set(() => control.SetBinding(Glyphs.StyleSimulationsProperty, binding));

public static Glyphs UnicodeString(this Glyphs control, String value)
   => control._set(() => control.UnicodeString = value);
public static Glyphs UnicodeString(this Glyphs control, BindingBase binding)
   => control._set(() => control.SetBinding(Glyphs.UnicodeStringProperty, binding));

public static Glyphs ColorFontPaletteIndex(this Glyphs control, Int32 value)
   => control._set(() => control.ColorFontPaletteIndex = value);
public static Glyphs ColorFontPaletteIndex(this Glyphs control, BindingBase binding)
   => control._set(() => control.SetBinding(Glyphs.ColorFontPaletteIndexProperty, binding));

public static Glyphs IsColorFontEnabled(this Glyphs control, Boolean value)
   => control._set(() => control.IsColorFontEnabled = value);
public static Glyphs IsColorFontEnabled(this Glyphs control, BindingBase binding)
   => control._set(() => control.SetBinding(Glyphs.IsColorFontEnabledProperty, binding));

public static T Fill<T>(this T control, Brush value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.Fill = value);
public static T Fill<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.FillProperty, binding));

public static T Stretch<T>(this T control, Stretch value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.Stretch = value);
public static T Stretch<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.StretchProperty, binding));

public static T StrokeDashArray<T>(this T control, DoubleCollection value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.StrokeDashArray = value);
public static T StrokeDashArray<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.StrokeDashArrayProperty, binding));

public static T StrokeDashCap<T>(this T control, PenLineCap value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.StrokeDashCap = value);
public static T StrokeDashCap<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.StrokeDashCapProperty, binding));

public static T StrokeDashOffset<T>(this T control, Double value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.StrokeDashOffset = value);
public static T StrokeDashOffset<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.StrokeDashOffsetProperty, binding));

public static T StrokeEndLineCap<T>(this T control, PenLineCap value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.StrokeEndLineCap = value);
public static T StrokeEndLineCap<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.StrokeEndLineCapProperty, binding));

public static T StrokeLineJoin<T>(this T control, PenLineJoin value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.StrokeLineJoin = value);
public static T StrokeLineJoin<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.StrokeLineJoinProperty, binding));

public static T StrokeMiterLimit<T>(this T control, Double value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.StrokeMiterLimit = value);
public static T StrokeMiterLimit<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.StrokeMiterLimitProperty, binding));

public static T Stroke<T>(this T control, Brush value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.Stroke = value);
public static T Stroke<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.StrokeProperty, binding));

public static T StrokeStartLineCap<T>(this T control, PenLineCap value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.StrokeStartLineCap = value);
public static T StrokeStartLineCap<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.StrokeStartLineCapProperty, binding));

public static T StrokeThickness<T>(this T control, Double value) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.StrokeThickness = value);
public static T StrokeThickness<T>(this T control, BindingBase binding) where T : Windows.UI.Xaml.Shapes.Shape
   => control._set(() => control.SetBinding(Windows.UI.Xaml.Shapes.Shape.StrokeThicknessProperty, binding));

public static Line X1(this Line control, Double value)
   => control._set(() => control.X1 = value);
public static Line X1(this Line control, BindingBase binding)
   => control._set(() => control.SetBinding(Line.X1Property, binding));

public static Line X2(this Line control, Double value)
   => control._set(() => control.X2 = value);
public static Line X2(this Line control, BindingBase binding)
   => control._set(() => control.SetBinding(Line.X2Property, binding));

public static Line Y1(this Line control, Double value)
   => control._set(() => control.Y1 = value);
public static Line Y1(this Line control, BindingBase binding)
   => control._set(() => control.SetBinding(Line.Y1Property, binding));

public static Line Y2(this Line control, Double value)
   => control._set(() => control.Y2 = value);
public static Line Y2(this Line control, BindingBase binding)
   => control._set(() => control.SetBinding(Line.Y2Property, binding));

public static Path Data(this Path control, Geometry value)
   => control._set(() => control.Data = value);
public static Path Data(this Path control, BindingBase binding)
   => control._set(() => control.SetBinding(Path.DataProperty, binding));

public static Polygon FillRule(this Polygon control, FillRule value)
   => control._set(() => control.FillRule = value);
public static Polygon FillRule(this Polygon control, BindingBase binding)
   => control._set(() => control.SetBinding(Polygon.FillRuleProperty, binding));

public static Polygon Points(this Polygon control, PointCollection value)
   => control._set(() => control.Points = value);
public static Polygon Points(this Polygon control, BindingBase binding)
   => control._set(() => control.SetBinding(Polygon.PointsProperty, binding));

public static Polyline FillRule(this Polyline control, FillRule value)
   => control._set(() => control.FillRule = value);
public static Polyline FillRule(this Polyline control, BindingBase binding)
   => control._set(() => control.SetBinding(Polyline.FillRuleProperty, binding));

public static Polyline Points(this Polyline control, PointCollection value)
   => control._set(() => control.Points = value);
public static Polyline Points(this Polyline control, BindingBase binding)
   => control._set(() => control.SetBinding(Polyline.PointsProperty, binding));

public static Rectangle RadiusX(this Rectangle control, Double value)
   => control._set(() => control.RadiusX = value);
public static Rectangle RadiusX(this Rectangle control, BindingBase binding)
   => control._set(() => control.SetBinding(Rectangle.RadiusXProperty, binding));

public static Rectangle RadiusY(this Rectangle control, Double value)
   => control._set(() => control.RadiusY = value);
public static Rectangle RadiusY(this Rectangle control, BindingBase binding)
   => control._set(() => control.SetBinding(Rectangle.RadiusYProperty, binding));

private static TControl _set<TControl>(this TControl control, Action setAction)
{
    setAction();
    return control;
}
public static Brush ToBrush(this Color color) => new SolidColorBrush(color);

}
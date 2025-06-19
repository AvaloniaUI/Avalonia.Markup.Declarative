using System.Collections;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests.Controls;
public class ColorPalette : ComponentBase
{
    #region AvaloniaProperties
    /// <summary>
    /// Colors
    /// </summary>
    public static readonly DirectProperty<ColorPalette, IList<Color>> ColorsProperty
        = AvaloniaProperty.RegisterDirect<ColorPalette, IList<Color>>(nameof(Colors), o => o.Colors, (o, v) => o.Colors = v);

    private IList<Color> _colors = new List<Color>();
    public IList<Color> Colors
    {
        get => _colors;
        set
        {
            SetAndRaise(ColorsProperty, ref _colors, value);
            OnColorsSet(ref _colors);
        }
    }

    /// <summary>
    /// Color to add
    /// </summary>
    public static readonly DirectProperty<ColorPalette, Color> ColorToAddProperty
        = AvaloniaProperty.RegisterDirect<ColorPalette, Color>(nameof(ColorToAdd), o => o.ColorToAdd, (o, v) => o.ColorToAdd = v);

    private Color _colorToAdd = Color.FromArgb(0,0,0,0);
    public Color ColorToAdd
    {
        get => _colorToAdd;
        set => SetAndRaise(ColorToAddProperty, ref _colorToAdd, value);
    }

    /// <summary>
    /// Can add color
    /// </summary>
    public static readonly DirectProperty<ColorPalette, bool> CanAddColorProperty
        = AvaloniaProperty.RegisterDirect<ColorPalette, bool>(nameof(CanAddColor), o => o.CanAddColor, (o, v) => o.CanAddColor = v);

    private bool _canAddColor;
    public bool CanAddColor
    {
        get => _canAddColor;
        set
        {
            SetAndRaise(CanAddColorProperty, ref _canAddColor, value);
            OnColorsSet(ref _colors);
        }
    }

    #endregion

    public event Action<Color>? ColorSelected;
    public event Action<Color>? ColorAdded;
    public event Action<Color>? ColorRemoved;

    protected override object Build() =>
        new Grid()
            .Children(
                new ItemsControl()
                    .Ref(out _itemsControl)
                    .ItemsSource(ColorsProperty)
                    .ItemTemplate(new FuncDataTemplate<Color>((itemVm, _) =>
                            itemVm == Color.FromArgb(0, 0, 0, 0)
                                ? new Button() //ADD COLOR BUTTON
                                    .OnClick(OnAddColorClicked)
                                    .Margin(6)
                                    .Width(32)
                                    .Height(32)
                                    .CornerRadius(32)
                                    .Content("+")
                                : new Button() // COLOR ITEM
                                    .Background(itemVm.ToBrush())
                                    .BorderThickness(1)
                                    .OnClick(_ => OnColorItemClicked(itemVm))
                                    .Width(32)
                                    .Height(32)
                                    .CornerRadius(32)
                                    .Margin(6)
                                    .ContextFlyout(
                                        new MenuFlyout()
                                            .Placement(PlacementMode.Bottom)
                                            .ItemsSource(new[]{
                                                new MenuItem()
                                                    .Header("Delete color")
                                                    .OnClick(_ => ColorRemoved?.Invoke(itemVm))
                                            })
                                    )
                        )
                    )

            );

    private ItemsControl _itemsControl = null!;

    private IList<Color>? _sourceColorsCollection;

    private void OnAddColorClicked(RoutedEventArgs obj) => ColorAdded?.Invoke(ColorToAdd);

    private void OnColorItemClicked(Color newColor) => ColorSelected?.Invoke(newColor);

    private void OnColorsSet(ref IList<Color> colors)
    {
        if (CanAddColor)
        {
            if (_sourceColorsCollection is ObservableCollection<Color> oldColors)
            {
                oldColors.CollectionChanged -= Obs_CollectionChanged;
            }

            _sourceColorsCollection = colors;

            if (_sourceColorsCollection is ObservableCollection<Color> obs)
            {
                obs.CollectionChanged += Obs_CollectionChanged;
            }

            _itemsControl.ItemsSource = GetCurrentColors();
        }
        else
            _itemsControl.ItemsSource = colors;
    }

    private void Obs_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        _itemsControl.ItemsSource = GetCurrentColors();
    }

    private IEnumerable GetCurrentColors()
    {
        var colors = new List<Color>();

        if (_sourceColorsCollection == null)
            return colors;

        colors.AddRange(_sourceColorsCollection);
        colors.Add(Color.FromArgb(0, 0, 0, 0));
        return colors;
    }
}
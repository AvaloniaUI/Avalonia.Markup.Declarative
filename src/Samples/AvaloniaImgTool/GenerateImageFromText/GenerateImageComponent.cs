using System.Diagnostics;
using System.Text;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using AvaloniaImgTool.Services;

namespace AvaloniaImgTool.GenerateImageFromText;

public class GenerateImageComponent : ComponentBase
{

    #region Markup

    protected override object Build() =>
        new Grid()
            .Rows("Auto, *")
            .Children(new Control[]
            {
                new TextBlock()
                    .Text("🤗 Text to Image Generator tool")
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .FontWeight(FontWeight.Bold)
                    .Foreground(Brushes.DarkSlateGray)
                    .FontSize(28)
                    .Margin(0, 32),

                new Grid().Row(1)
                    .Cols("250, *, Auto")
                    .Rows("48,48,32,*")
                    .Children(
                        new Control
                            [] //we are using explicit array declaration with brackets, to make Visual studio show guideline to highlight children section
                            {
                                new TextBlock()
                                    .Margin(10, 0)
                                    .VerticalAlignment(VerticalAlignment.Center)
                                    .Text("Api key from https://huggingface.co"),

                                new TextBox().Col(1)
                                    .Margin(0, 0, 10, 0)
                                    .VerticalAlignment(VerticalAlignment.Center)
                                    .Text(Bind(ApiKey)),

                                new TextBlock()
                                    .Margin(10, 0)
                                    .Row(1)
                                    .VerticalAlignment(VerticalAlignment.Center)
                                    .Text("Text prompt for image generation"),

                                new TextBox()
                                    .Row(1).Col(1)
                                    .Margin(0, 0, 10, 0)
                                    .VerticalAlignment(VerticalAlignment.Center)
                                    .Text(Bind(InputText))
                                    .With(tb => tb.OnKeyUp(e =>
                                    {
                                        if(e.Key == Key.Return)
                                            OnGenerateButtonClick(e);
                                    })),

                                new Button()
                                    .Col(3)
                                    .Row(1)
                                    .Content("Generate image")
                                    .Margin(0, 0, 10, 0)
                                    .OnClick(OnGenerateButtonClick),

                                new ProgressBar()
                                    .IsIndeterminate(true)
                                    .Row(2)
                                    .ColSpan(3)
                                    .IsVisible(Bind(ShowProgressBar))
                                    .Width(200),

                                new TextBlock()
                                    .HorizontalAlignment(HorizontalAlignment.Center)
                                    .Row(2)
                                    .ColSpan(3)
                                    .VerticalAlignment(VerticalAlignment.Center)
                                    .Text(Bind(TimeElapsed)),

                                new Grid()
                                    .ColSpan(3)
                                    .Row(3)
                                    .Background(Brushes.WhiteSmoke)
                                    .Children(
                                        new Image()
                                            .HorizontalAlignment(HorizontalAlignment.Center)
                                            .VerticalAlignment(VerticalAlignment.Center)
                                            .Margin(0,48,0,0)
                                            .Ref(out _imageControl),
                                        new Button()
                                            .Margin(8)
                                            .Foreground(Brushes.White)
                                            .HorizontalAlignment(HorizontalAlignment.Center)
                                            .VerticalAlignment(VerticalAlignment.Top)
                                            .Content("Save image to PC")
                                            .IsVisible(Bind(ShowSaveButton))
                                            .OnClick(OnSaveButtonClick)
                                    )
                            }) //inner grid children
            }); //top grid children

    private void OnTextInputKeyPressed(KeyEventArgs obj)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Code

    private Image _imageControl;
    private GenerateImageFromTextResult _lastImageResult;

    [Inject] HuggingFaceService HuggingFaceService { get; set; } = null!;
    [Inject] SaveFilePickerService SaveFilePickerService { get; set; } = null!;
    [Inject] SettingsService SettingsService { get; set; } = null!;

    public string ApiKey { get; set; } = "anonymous";
    public string InputText { get; set; } = "Anime style raccon with minigun flying on jetpack";
    public string TimeElapsed { get; set; } = "";
    public bool ShowProgressBar { get; set; }
    public bool ShowSaveButton { get; set; }


    protected override void OnCreated()
    {
        base.OnCreated();

        ApiKey = SettingsService.Settings.ApiKey;
        InputText = SettingsService.Settings.LastInputText;
    }

    private async void OnGenerateButtonClick(RoutedEventArgs e)
    {
        try
        {
            SettingsService.Settings.ApiKey = ApiKey;
            SettingsService.Settings.LastInputText = InputText;
            SettingsService.SaveSetting();

            ShowProgressBar = true;
            TimeElapsed = "";
            StateHasChanged();

            var result = await HuggingFaceService.GenerateImageFromText(InputText, ApiKey);

            if (result.IsDataValid)
            {
                TimeElapsed = "Time elapsed: " + result.TimeToGenerate.ToString("g");
                var bitmap = new Bitmap(result.GetImageDataAsStream());
                _imageControl.Source = bitmap;
                _lastImageResult = result;
                ShowSaveButton = true;
            }
            else
            {
                TimeElapsed = $"There was an Error while getting image. {result.ErrorMessage}";
            }
        }
        catch (Exception ex)
        {
            TimeElapsed = "There was an Error while getting image: " + ex.Message;
        }
        finally
        {
            ShowProgressBar = false;
            StateHasChanged();
        }
    }

    private async void OnSaveButtonClick(RoutedEventArgs obj)
    {
        await SaveFilePickerService.SaveFileAsync(_lastImageResult.GetImageDataAsStream());
    }


    #endregion
}
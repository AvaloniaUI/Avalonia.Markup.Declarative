using Avalonia.Platform.Storage;

namespace AvaloniaImgTool.Services;

public class SaveFilePickerService
{
    private readonly Func<IStorageProvider> _spProviderFunc;

    public SaveFilePickerService(Func<IStorageProvider> spProviderFunc)
    {
        _spProviderFunc = spProviderFunc;
    }

    public async Task SaveFileAsync(Stream getImageDataAsStream)
    {
        var options = new FilePickerSaveOptions();
        options.FileTypeChoices = new[]
        {
            new FilePickerFileType("Jpeg images") { Patterns = new []{"*.jpg"} }
        };
        options.DefaultExtension = "jpg";
        options.SuggestedFileName = "image.jpg";
        options.ShowOverwritePrompt = true;

        var result = await _spProviderFunc().SaveFilePickerAsync(options);

        if (result is not null)
        {
            await using var stream = await result.OpenWriteAsync();
            await getImageDataAsStream.CopyToAsync(stream);
        }
    }
}
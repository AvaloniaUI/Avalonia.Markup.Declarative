namespace AvaloniaImgTool.GenerateImageFromText;

public class GenerateImageFromTextResult
{
    public string Text { get; set; }
    public byte[]? data { get; set; }

    public TimeSpan TimeToGenerate { get; set; }
    public string ErrorMessage { get; }

    public int DataLength => data?.Length ?? 0;

    public bool IsDataValid => DataLength > 0;

    public GenerateImageFromTextResult(string text, byte[]? data, TimeSpan timeToGenerate, string errorMessage = "")
    {
        Text = text;
        this.data = data;
        TimeToGenerate = timeToGenerate;
        ErrorMessage = errorMessage;
    }

    public Stream GetImageDataAsStream()
    {
        if(data != null)
            return new MemoryStream(data);

        throw new InvalidOperationException("No data in stream");
    }
}
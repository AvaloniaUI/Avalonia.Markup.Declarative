using System.Diagnostics;
using System.Text;
using AvaloniaImgTool.GenerateImageFromText;

namespace AvaloniaImgTool.Services;

public class HuggingFaceService
{
    public string GetData() => "this text is from sample data service";

    /// <summary>
    /// Request hugging face api to generate image with openjourney-v2 model
    /// </summary>
    /// <param name="inputText">Prompt for AI to generate image</param>
    /// <param name="apiKey">api key of hugging face REST service</param>
    /// <returns>jpeg file data</returns>
    public async Task<GenerateImageFromTextResult> GenerateImageFromText(string inputText, string apiKey)
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Bearer", apiKey);
        var modelId = "prompthero/openjourney-v2";
        var apiUrl = $"https://api-inference.huggingface.co/models/{modelId}";
        var prompt = inputText;
        var content = new StringContent($"{{inputs:\"{prompt}\"}}", Encoding.UTF8, "application/json");

        var sw = new Stopwatch();
        sw.Start();
        var response = await client.PostAsync(apiUrl, content);
        sw.Stop();

        byte[]? imageData = null;
        var error = "";

        if (response.IsSuccessStatusCode)
        {
            var image = await response.Content.ReadAsStreamAsync();
            using var ms = new MemoryStream();
            await image.CopyToAsync(ms);
            imageData = ms.ToArray();
        }
        else
        {
            error = await response.Content.ReadAsStringAsync();
        }

        return new GenerateImageFromTextResult(inputText, imageData, sw.Elapsed, error);

    }
}
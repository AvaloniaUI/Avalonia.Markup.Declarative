using System.Diagnostics;
using System.Text.Json;

namespace AvaloniaImgTool.Services;

public class SettingsService
{
    private readonly string _settingsFileName = "settings.json";
    public AppSettings Settings { get; private set; } = new AppSettings();

    public SettingsService()
    {
        LoadSettings();
    }
    public void SaveSetting()
    {
        var json = JsonSerializer.Serialize(Settings);
        File.WriteAllText(_settingsFileName, json);
    }

    public void LoadSettings()
    {
        if (File.Exists(_settingsFileName))
        {
            var json = File.ReadAllText(_settingsFileName);
            var settings = JsonSerializer.Deserialize<AppSettings>(json);
            if (settings != null)
            {
                Settings = settings;
            }
        }
    }
}
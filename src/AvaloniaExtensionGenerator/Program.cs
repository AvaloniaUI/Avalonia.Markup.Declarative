namespace AvaloniaExtensionGenerator;

internal class Program
{
    static async Task Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide the path to the .csproj file using the argument '--projectPath'.");


            Console.WriteLine("\n Or do you want to process Avalonia Framework itself?\nPress Y to start or any key to exit!");

            var keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.WriteLine("\nYou pressed 'Y'. Staring processing...");
                GeneratorHost.RunDefaultAvaloniaFrameworkGenerators();
            }
            return;
        }

        string? projectPath = null;
        foreach (var arg in args)
        {
            if (arg.StartsWith("--projectPath="))
            {
                projectPath = arg.Substring("--projectPath=".Length);
            }
        }

        if (projectPath == null)
        {
            Console.WriteLine("Please provide the path to the .csproj file using the argument '--projectPath'.");
            return;
        }

        if (!File.Exists(projectPath))
        {
            Console.WriteLine($"The file {projectPath} does not exist.");
            return;
        }

        try
        {
            var defaultAvaloniaConfig = new DefaultAvaloniaConfig("");
            var skipTypesFromProcess = defaultAvaloniaConfig.TypesToProcess.ToArray();

            var types = await CsProjectTypesExtractor.LoadTypesFromProject(projectPath);
            var projectDirPath = Path.GetDirectoryName(projectPath);
            GeneratorHost.RunControlTypeGenerators(types, skipTypesFromProcess, projectDirPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
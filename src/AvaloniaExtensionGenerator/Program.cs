namespace AvaloniaExtensionGenerator;

internal class Program
{
    static async Task Main(string[] args)
    {
        string? projectPath = null;

        //for non framework mode ignore types from following base avalonia assemblies
        string[] ignoreAssemblies =
        [
            "Avalonia.Base",
            "Avalonia.Controls",
            "Avalonia.DesignerSupport",
            "Avalonia.Dialogs",
            "Avalonia",
            "Avalonia.Markup",
            "Avalonia.Markup.Xaml",
            "Avalonia.Metal",
            "Avalonia.MicroCom",
            "Avalonia.OpenGL",
            "Avalonia.Vulkan",
        ];

        foreach (var arg in args)
        {
            if (arg.StartsWith("--projectPath="))
            {
                projectPath = arg.Substring("--projectPath=".Length);
            }
        }

        if (args.Length == 0 && string.IsNullOrWhiteSpace(projectPath))
        {
            var curDir = new DirectoryInfo(Directory.GetCurrentDirectory());
            var projectFiles = curDir.GetFiles("*.csproj");

            if (projectFiles.Length == 1)
            {
                Console.WriteLine("'--projectPath' is not set. Using current directory as a root project path");
                Console.WriteLine($"project found: {projectFiles.First().Name}");

                projectPath = projectFiles.First().FullName;
            }
        }

        if (args is ["--framework"])
        {
            //generate extensions for base avalonia types
            ignoreAssemblies = [];
            var projectDir = new DirectoryInfo(
                GetAvaloniaMarkupDeclarativeProjectPath(AppDomain.CurrentDomain.BaseDirectory)).FullName;
            projectPath = Path.Combine(projectDir, "Avalonia.Markup.Declarative.csproj");
        }

        if (projectPath == null)
        {
            Console.WriteLine("Project file not found. Please provide the path to the .csproj file using the argument '--projectPath' or run AvaloniaExtensionGenerator from directory that contains csproj");
            return;
        }

        if (!File.Exists(projectPath))
        {
            Console.WriteLine($"The file {projectPath} does not exist.");
            return;
        }

        try
        {
            var projectDirPath = Path.GetDirectoryName(projectPath);
            var outputPath = Path.Combine(projectDirPath, "ControlExtensions.Generated");

            var types = await CsProjectTypesExtractor
                .LoadTypesFromProject(projectPath, AvaloniaTypeHelper.GetAvaloniaObjectTypeName(), ignoreAssemblies);

            var extensionsOutputPath = GeneratorHost.RunControlTypeGenerators(types, outputPath);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Written extensions into folder: {extensionsOutputPath}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}\n{ex.StackTrace}");
        }
    }

    private static string GetAvaloniaMarkupDeclarativeProjectPath(string path)
    {
        while (true)
        {
            var directories = Directory.EnumerateDirectories(path);
            foreach (var dir in directories)
                if (dir.EndsWith("Avalonia.Markup.Declarative"))
                    return dir;

            path = Path.Combine(path, "..");
        }
    }

}
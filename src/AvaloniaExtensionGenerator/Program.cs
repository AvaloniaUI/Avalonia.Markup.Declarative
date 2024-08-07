namespace AvaloniaExtensionGenerator;

internal class Program
{
    static async Task Main(string[] args)
    {
        if (args is ["--framework"])
        {
            GeneratorHost.RunDefaultAvaloniaFrameworkGenerators();
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

        if (args.Length == 0)
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
            var defaultAvaloniaConfig = new DefaultAvaloniaConfig("");
            var skipTypesFromProcess = defaultAvaloniaConfig.TypesToProcess.ToArray();

            var types = await CsProjectTypesExtractor.LoadTypesFromProject(
                projectPath, typeof(Avalonia.AvaloniaObject));

            var projectDirPath = Path.GetDirectoryName(projectPath);
            GeneratorHost.RunControlTypeGenerators(types, skipTypesFromProcess, projectDirPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
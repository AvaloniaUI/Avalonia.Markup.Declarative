using NuGet.Common;
using NuGet.Configuration;
using NuGet.Packaging;
using NuGet.Protocol.Core.Types;
using System.Reflection;
using System.Xml.Linq;

namespace AvaloniaExtensionGenerator;

internal class CsProjectTypesExtractor
{
    private static List<PackageReference> GetPackageReferences(string csprojPath)
    {
        var packages = new List<PackageReference>();
        var doc = XDocument.Load(csprojPath);

        var packageReferences = doc.Descendants("PackageReference");
        foreach (var reference in packageReferences)
        {
            var name = reference.Attribute("Include")?.Value;
            var version = reference.Attribute("Version")?.Value;
            if (name != null && version != null)
            {
                packages.Add(new PackageReference { Name = name, Version = version });
            }
        }

        return packages;
    }

    private static async Task<string> GetNuGetPackage(string packageName, string packageVersion)
    {
        string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string localCachePath = Path.Combine(userProfile, ".nuget", "packages", packageName.ToLower(), packageVersion);

        if (Directory.Exists(localCachePath))
        {
            Console.WriteLine("Package found in local cache.");
            return Path.Combine(localCachePath, $"{packageName}.{packageVersion}.nupkg");
        }

        Console.WriteLine("Package not found in local cache. Downloading...");
        return await DownloadNuGetPackage(packageName, packageVersion);
    }

    private static async Task<string> DownloadNuGetPackage(string packageName, string packageVersion)
    {
        var providers = Repository.Provider.GetCoreV3();
        var source = new PackageSource("https://api.nuget.org/v3/index.json");
        var sourceRepository = new SourceRepository(source, providers);
        var resource = await sourceRepository.GetResourceAsync<FindPackageByIdResource>();

        using var cacheContext = new SourceCacheContext();
        var logger = NullLogger.Instance;
        var packageIdentity = new NuGet.Packaging.Core.PackageIdentity(packageName, new NuGet.Versioning.NuGetVersion(packageVersion));
        var downloadPath = Path.Combine(Path.GetTempPath(), $"{packageName}.{packageVersion}.nupkg");

        using (var downloadStream = File.Create(downloadPath))
        {
            await resource.CopyNupkgToStreamAsync(packageIdentity.Id, packageIdentity.Version, downloadStream, cacheContext, logger, default);
        }

        return downloadPath;
    }

    private static string ExtractPackage(string packagePath)
    {
        var extractionPath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(packagePath));
        if (!Directory.Exists(extractionPath))
        {
            Directory.CreateDirectory(extractionPath);
        }

        using var packageStream = File.OpenRead(packagePath);
        using var packageArchiveReader = new PackageArchiveReader(packageStream);
        foreach (var file in packageArchiveReader.GetFiles())
        {
            var filePath = Path.Combine(extractionPath, file);
            var directoryPath = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath!);
            }

            using var fileStream = File.Create(filePath);
            using var sourceStream = packageArchiveReader.GetStream(file);
            sourceStream.CopyTo(fileStream);
        }

        return extractionPath;
    }

    private static List<string> GetClassesFromDlls(string extractionPath)
    {
        var classNames = new List<string>();

        foreach (var dll in Directory.GetFiles(extractionPath, "*.dll", SearchOption.AllDirectories))
        {
            try
            {
                var assembly = Assembly.LoadFrom(dll);
                var types = assembly.GetTypes();
                classNames.AddRange(types.Select(t => t.FullName)!);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load assembly {dll}: {ex.Message}");
            }
        }

        return classNames;
    }

    private class PackageReference
    {
        public string Name { get; init; } = null!;
        public string Version { get; init; } = null!;
    }

    public static async Task LoadTypesFromProject(string projectPath)
    {
        List<PackageReference> packages = GetPackageReferences(projectPath);
        Console.WriteLine("Packages found in the .csproj file:");
        foreach (var package in packages)
        {
            Console.WriteLine($"{package.Name} {package.Version}");

            string packagePath = await GetNuGetPackage(package.Name, package.Version);
            string extractionPath = ExtractPackage(packagePath);
            List<string> classes = GetClassesFromDlls(extractionPath);

            Console.WriteLine($"Classes found in {package.Name} {package.Version}:");
            foreach (var className in classes)
            {
                Console.WriteLine(className);
            }
        }
    }
}
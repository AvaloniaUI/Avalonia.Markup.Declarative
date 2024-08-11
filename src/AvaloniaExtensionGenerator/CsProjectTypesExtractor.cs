using NuGet.Common;
using NuGet.Configuration;
using NuGet.Frameworks;
using NuGet.Packaging.Core;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

namespace AvaloniaExtensionGenerator
{
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

        private static string GetTargetFramework(string csprojPath)
        {
            var doc = XDocument.Load(csprojPath);
            var targetFramework = doc.Descendants("TargetFramework").FirstOrDefault()?.Value;
            return targetFramework ?? string.Empty;
        }

        private static async Task RestoreNuGetPackages(string projectPath)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"restore \"{projectPath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            using var process = new Process { StartInfo = processStartInfo };
            process.Start();
            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();

            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                Console.WriteLine($"Failed to restore NuGet packages: {error}");
                throw new Exception($"NuGet restore failed: {error}");
            }
            else
            {
                Console.WriteLine($"NuGet restore succeeded: {output}");
            }
        }

        private static async Task<List<string>> GetAllDependencyPackages(string packageName, string packageVersion, string targetFramework)
        {
            var result = new List<string>();
            var cache = new SourceCacheContext();
            var repositories = Repository.Provider.GetCoreV3();
            var packageSource = new PackageSource("https://api.nuget.org/v3/index.json");
            var repository = new SourceRepository(packageSource, repositories);
            var resource = await repository.GetResourceAsync<DependencyInfoResource>();
            var identity = new PackageIdentity(packageName, NuGetVersion.Parse(packageVersion));
            var nuGetFramework = NuGetFramework.ParseFolder(targetFramework);

            var packageDependencies = await resource.ResolvePackage(
                identity,
                nuGetFramework,
                cache,
                NullLogger.Instance,
                CancellationToken.None);

            if (packageDependencies == null)
            {
                throw new Exception($"Package {packageName} {packageVersion} not found.");
            }

            void AddDependencies(PackageDependencyInfo package)
            {
                if (!result.Contains($"{package.Id},{package.Version}"))
                {
                    result.Add($"{package.Id},{package.Version}");
                    foreach (var dependency in package.Dependencies)
                    {
                        var depPackage = resource.ResolvePackage(
                            new PackageIdentity(dependency.Id, dependency.VersionRange.MinVersion),
                            nuGetFramework,
                            cache,
                            NullLogger.Instance,
                            CancellationToken.None).Result;

                        if (depPackage != null)
                        {
                            AddDependencies(depPackage);
                        }
                    }
                }
            }

            AddDependencies(packageDependencies);
            return result;
        }

        private class PackageReference
        {
            public string Name { get; init; } = null!;
            public string Version { get; init; } = null!;
        }

        public static async Task<IReadOnlyList<Type>> LoadTypesFromProject(
            string projectPath,
            string baseTypeNameToFilter,
            string[] ignoreAssemblies)
        {
            string targetFramework = GetTargetFramework(projectPath);
            await RestoreNuGetPackages(projectPath);
            List<PackageReference> packages = GetPackageReferences(projectPath);
            Console.WriteLine("Packages found in the .csproj file:");
            Dictionary<string, Assembly> loadedAssembliesCache = new();

            Type? filterBaseType = null;

            var result = new List<Type>();

            foreach (var package in packages)
            {
                Console.WriteLine($"{package.Name} {package.Version}");

                // Load the main package's assemblies
                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string packagePath = Path.Combine(userProfile, ".nuget", "packages", package.Name.ToLower(), package.Version);

                if (TryToFindFrameworkPath(Path.Combine(packagePath, "lib"), targetFramework,
                        out var frameworkPath))
                {
                    foreach (var dll in Directory.GetFiles(frameworkPath, "*.dll", SearchOption.AllDirectories))
                    {
                        try
                        {
                            TryLoadAssembly(dll, loadedAssembliesCache, out var assembly);

                            await LoadDependencyAssemblies(package, targetFramework, userProfile, loadedAssembliesCache);

                            if (ignoreAssemblies.Contains(assembly.GetName().Name))
                            {
                                Console.WriteLine($"Skipping base assembly, {assembly.GetName().Name}");
                            }
                            else
                            {
                                //initialize filter type only after loading assembly dependencies
                                filterBaseType ??= loadedAssembliesCache.Values
                                    .SelectMany(x => x.ExportedTypes)
                                    .FirstOrDefault(x => x.FullName == baseTypeNameToFilter);

                                if (filterBaseType != null)
                                {
                                    var types = assembly.ExportedTypes.Where(filterBaseType.IsAssignableFrom).ToArray();
                                    result.AddRange(types);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            if (!ex.Message.StartsWith("Assembly with same name is already loaded"))
                                Console.WriteLine($"Failed to get types from assembly {dll}: {ex.Message}");
                        }
                    }
                }

            }

            return result;
        }

        private static bool TryLoadAssembly(string dll, Dictionary<string, Assembly> loadedAssembliesCache,
            out Assembly asm)
        {
            asm = null;

            if (!loadedAssembliesCache.TryGetValue(dll, out var assembly))
            {
                assembly = Assembly.LoadFrom(dll);
                loadedAssembliesCache[dll] = assembly;
                Console.WriteLine($"-{assembly.GetName().Name}");
            }

            asm = assembly;
            return true;
        }

        private static async Task LoadDependencyAssemblies(PackageReference package, string targetFramework,
            string userProfile, Dictionary<string, Assembly> loadedAssembliesCache)
        {
            // Load dependencies to dictionary
            var dependencies = await GetAllDependencyPackages(package.Name, package.Version, targetFramework);
            foreach (var dep in dependencies)
            {
                var parts = dep.Split(',');
                if (parts.Length == 2)
                {
                    var depName = parts[0];
                    var depVersion = parts[1];
                    string depPackagePath =
                        Path.Combine(userProfile, ".nuget", "packages", depName.ToLower(), depVersion);

                    if (TryToFindFrameworkPath(Path.Combine(depPackagePath, "lib"), targetFramework, out var depFrameworkPath))
                    {
                        foreach (var dll in Directory.GetFiles(depFrameworkPath, "*.dll", SearchOption.AllDirectories))
                        {
                            try
                            {
                                TryLoadAssembly(dll, loadedAssembliesCache, out _);
                            }
                            catch (Exception ex)
                            {
                                if (!ex.Message.StartsWith("Assembly with same name is already loaded"))
                                    Console.WriteLine($"Failed to load dependency assembly {dll}: {ex.Message}");
                            }
                        }
                    }
                }
            }
        }

        private static bool TryToFindFrameworkPath(string libPath, string targetFramework, out string frameworkPath)
        {
            frameworkPath = Path.Combine(libPath, targetFramework);

            if (Directory.Exists(frameworkPath))
                return true;

            frameworkPath = Path.Combine(libPath, "netstandard2.0");
            if (Directory.Exists(frameworkPath))
                return true;

            frameworkPath = Path.Combine(libPath, "netstandard2.1");
            if (Directory.Exists(frameworkPath))
                return true;

            return false;
        }
    }
}

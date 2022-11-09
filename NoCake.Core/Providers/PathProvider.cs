using System;
using System.IO;
using System.Linq;
using NoCake.Core.Abstract;

namespace NoCake.Core.Providers;

public class PathProvider : IPathProvider
{
    private string[]? EnviromentPaths { get; set; }

    public string[]? EnvironmentPaths()
    {
        return EnviromentPaths ??= Environment.GetEnvironmentVariable("Path")?.Split(';').Where(x =>
        {
            if (new DirectoryInfo(x).Exists)
                return true;
            if (new FileInfo(x).Exists) return true;

            return false;
        })?.ToArray() ?? Array.Empty<string>();
    }
}
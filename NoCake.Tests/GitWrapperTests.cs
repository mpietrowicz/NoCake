using NoCake.Core;

namespace NoCake.Tests;

public class GitWrapperTests
{
    [Fact]
    public void Clone()
    {
        var path = "data/" + Guid.NewGuid().ToString();

        try
        {
            var wrapper = new GitWrapper();
            wrapper.Clone("https://github.com/mpietrowicz/NoCake.git",path);
            Assert.True(Directory.Exists(path));
            Assert.True(Directory.GetFiles(path,"*.*").Any());
            Assert.True(Directory.GetFiles(path,"*.gitignore", SearchOption.AllDirectories).Any());
            Assert.True(Directory.GetFiles(path,"*.sln", SearchOption.AllDirectories).Any());
            Assert.True(Directory.GetFiles(path,"*.csproj", SearchOption.AllDirectories).Any());
            Assert.True(Directory.GetFiles(path,"*.cs", SearchOption.AllDirectories).Any());
        }
        finally
        {
            if (Directory.Exists(path))
            {
                foreach (var file in Directory.GetFiles(path,"*.*", SearchOption.AllDirectories))
                {
                    var f = new FileInfo(file);
                    f.IsReadOnly = false;
                    f.Attributes = FileAttributes.Normal;
                    File.Delete(file);
                }
                
                Directory.Delete(path, true);
            }
        }
    }
}
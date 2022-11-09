namespace NoCake.Core.Abstract;

public interface IGitWrapper
{
    void Clone(string url, string path,bool disableSsl = false);
}
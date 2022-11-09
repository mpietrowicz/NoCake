using System;
using LibGit2Sharp;
using NoCake.Core.Abstract;

namespace NoCake.Core;

public class GitWrapper : IGitWrapper
{
   public void Clone(string url, string path,bool disableSsl = false)
   {
      if (string.IsNullOrEmpty(url)) throw new ArgumentException("Value cannot be null or empty.", nameof(url));
      if (string.IsNullOrEmpty(path)) throw new ArgumentException("Value cannot be null or empty.", nameof(path));
         Repository.Clone(url, path);
   }
}
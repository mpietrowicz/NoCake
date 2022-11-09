using System;
using System.Threading.Tasks;

namespace NoCake.Core.Abstract;

public interface IApp : IDisposable
{
    Task Run(params string[] args);
}
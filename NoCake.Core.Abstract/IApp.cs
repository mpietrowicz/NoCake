using System.Threading.Tasks;

namespace NoCake.Core.Abstract;

public interface IApp
{
    Task Run(params string[] args);
}
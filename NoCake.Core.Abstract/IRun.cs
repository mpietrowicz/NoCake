using System.Collections.Generic;
using System.Threading.Tasks;
using Splat;

namespace NoCake.Core.Abstract;

public interface IRun
{
    public Task Run();
}

public abstract class RunBase : IRun
{
    public RunBase()
    {
        
    }

    public IGitWrapper Git => Locator.Current.GetService<IGitWrapper>();
  
    public TType? Resolve<TType>()
    {
        return Locator.Current.GetService<TType>();
    }

    public IEnumerable<TType> ResolveServices<TType>()
    {
        return Locator.Current.GetServices<TType>();
    }

    public abstract Task Run();
}
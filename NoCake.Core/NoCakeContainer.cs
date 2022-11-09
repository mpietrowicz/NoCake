using NoCake.Core.Abstract;
using NoCake.Core.Providers;
using Splat;

namespace NoCake.Core;

public partial class NoCakeContainer
{
    public NoCakeContainer()
    {
        
        Locator.CurrentMutable.RegisterConstant(new ParameterProvider(), typeof(IParameterProvider));
        Locator.CurrentMutable.RegisterConstant(new PathProvider(), typeof(IPathProvider));
        Locator.CurrentMutable.RegisterConstant(new App(), typeof(IApp));
        Locator.CurrentMutable.RegisterConstant(new GitWrapper(), typeof(IGitWrapper));
        
        
    }

    public IApp? Resolve()
    {
       return Locator.Current.GetService<IApp>();
    }
}
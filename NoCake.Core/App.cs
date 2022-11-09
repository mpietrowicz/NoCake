using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using NoCake.Core.Abstract;
using Splat;

namespace NoCake.Core;

public class App : IApp
{
    public App()
    {
        ParameterProvider = Locator.Current.GetService<IParameterProvider>() ?? throw new NullReferenceException(nameof(ParameterProvider));
    }

    private IParameterProvider? ParameterProvider { get; }
    private string[] AppSessionParameters { get; set; } = null!;

    public async Task Run(params string[] args)
    {
        ParameterProvider.Init(args);
        AppSessionParameters = ParameterProvider.GetParameters() ?? Array.Empty<string>();

        var assamblyPath = AppSessionParameters[0];
        if (!File.Exists(assamblyPath))
        {
            throw new FileNotFoundException(assamblyPath);
        }
        
        var assambly = Assembly.LoadFile(AppSessionParameters[0]);

       var runners =  assambly.GetTypes().Where(x => x.GetInterfaces().Any(a=> a.IsAssignableFrom(typeof(IRun)))).ToList();

       foreach (var r in runners ?? new List<Type>())
       {
           var runner = r as IRun;
           
           await runner.Run();
       }
       
        
        
        await Task.CompletedTask;
    }
    public void Dispose()
    {
    }
}
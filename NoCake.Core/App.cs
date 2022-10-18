using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NoCake.Core.Abstract;

namespace NoCake.Core;

public class App : IApp
{
    private IParameterProvider ParameterProvider { get; }
    private List<KeyValuePair<string, string>> AppSessionParameters { get; set; } = null!;

    public App(IParameterProvider parameterProvider)
    {
        ParameterProvider = parameterProvider ?? throw new ArgumentNullException(nameof(parameterProvider));
    }
    public async Task Run(params string[] args)
    {
        ParameterProvider.Init(args);

       AppSessionParameters =  ParameterProvider.GetParameters();
        
        await Task.Delay(0);
    }

}
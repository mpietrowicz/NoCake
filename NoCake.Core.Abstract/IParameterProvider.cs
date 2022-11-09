using System.Collections.Generic;

namespace NoCake.Core.Abstract;

public interface IParameterProvider
{
    void Init(params string[] arguments);
    string[] GetParameters();
}
using System.Collections.Generic;

namespace NoCake.Core.Abstract
{
    public interface IParameterProvider
    {
        void Init(params string[] arguments);
        List<KeyValuePair<string, string>> GetParameters();
    }
}
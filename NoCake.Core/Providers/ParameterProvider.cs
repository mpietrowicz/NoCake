using System;
using System.Collections.Generic;
using System.Linq;
using NoCake.Core.Abstract;

namespace NoCake.Core.Providers
{
    internal class ParameterProvider : IParameterProvider
    {
        private string[]? _arguments;
        public void Init(params string[] arguments)
        {
            _arguments = arguments;
        }
        public List<KeyValuePair<string, string>> GetParameters()
        {
            if (!(_arguments?.Any() ?? false))
            {
                return new();
            }
            else
            {
                foreach (var argument in _arguments)
                {
                    Console.WriteLine($"{argument}");
                }
            }


            return null;
        }
    }
}
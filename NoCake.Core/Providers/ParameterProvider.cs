﻿using System;
using System.Collections.Generic;
using System.Linq;
using NoCake.Core.Abstract;

namespace NoCake.Core.Providers;

internal class ParameterProvider : IParameterProvider
{
    private string[]? _arguments;

    public void Init(params string[] arguments)
    {
        _arguments = arguments;
    }

    public string[] GetParameters()
    {
      

        return _arguments ?? Array.Empty<string>();
    }
}
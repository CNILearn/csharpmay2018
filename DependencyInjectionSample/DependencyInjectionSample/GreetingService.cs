﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public class GreetingService : IGreetingService
    {
        public string Hello(string name) => $"Hello, {name}";
    }
}

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingSample
{
    public class MyService
    {
        private readonly ILogger _logger;
        public MyService(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<MyService>();
        }

        public void MyMethod()
        {
            _logger.LogError("some error in MyMethod");
        }
    }
}

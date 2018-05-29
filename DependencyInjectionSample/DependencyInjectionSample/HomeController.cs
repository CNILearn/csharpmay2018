using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public class HomeController
    {
        private readonly IGreetingService _greetingService;

        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }
        public void Index()
        {
            string greeting = _greetingService.Hello("Stephanie");
            Console.WriteLine(greeting);
        }
    }
}

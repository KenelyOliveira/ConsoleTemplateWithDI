using System;
using ConsoleTemplateWithDI.Dependencies;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleTemplateWithDI
{
    static class Program
    {
        private static IServiceProvider serviceProvider;

        static void Main(string[] args)
        {
            RegisterDependencies.Register();



            
        }

        static void GetServices()
        {
            var services = serviceProvider.GetServices<>();
        }
    }
}

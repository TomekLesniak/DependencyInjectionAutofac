using System;
using Autofac;
using DependencyInjectionLib;

namespace DependencyInjectionAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();
            app.Run();
        }
    }
}

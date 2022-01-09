using System;
using Autofac;
using Inlämning_1_Kenneln.Interfaces;
using Inlämning_1_Kenneln.Models;

namespace Inlämning_1_Kenneln
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run Autofac Configure
            var container = AFConfig.Configure();

            // Create an instance of IApplication since we are not using a constructor here
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}

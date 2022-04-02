using Microsoft.Extensions.DependencyInjection;
using System;

namespace ServiceLifeTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                                  .AddTransient<ISingleTonLifeScopeService, SingleTonLifeScopeService>()
                                  .AddTransient<ITransientLifeScopeService, TransientLifeScopeService>()
                                  .AddTransient<IScopeLifeScopeService, ScopeLifeScopeService>()
                                  .AddScoped<ICounter, Counter>()
                                  //.AddTransient<ICounter, Counter>()
                                  //.AddSingleton<ICounter, Counter>()
                                  .BuildServiceProvider();

            var singleTonScope = serviceProvider.GetService<ISingleTonLifeScopeService>();

            Console.WriteLine(singleTonScope.IncrementAndGet());
            Console.WriteLine(singleTonScope.IncrementAndGet());

        }
    }
}

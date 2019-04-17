using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    internal class Program
    {
        private static void Main()
        {
            var executor1 = new Executor("Glareone", @"Group of usage 1", "Executor Glareone starts to kill'em all");
            var executor2 = new Executor("Lis", @"Group of usage 1", "Executor Lissan starts to reallocate to US");
            var executor3 = new Executor("Hell", @"Group of usage 1", "Executor Hell repairs his apartments");
            var executor4 = new Executor("Arthur", @"Group of usage 2", "Executor Arthur establishes company");

            var executors = new List<Executor> { executor1, executor2, executor3 };

            Mediator.AddExecutors("Mad_Executors", executors);
            Mediator.AddExecutors("Beer_Executors", new List<Executor> { executor4 });

            Mediator.DoByAllExecutors("Mad_Executors");
            Console.WriteLine($"amoung of executors is {Mediator.GetExecutors("Mad_Executors").Count}");

            Mediator.DoByAllExecutors("Beer_Executors");
            Console.WriteLine($"amoung of executors is {Mediator.GetExecutors("Beer_Executors").Count}");

            Console.ReadKey();
        }
    }
}

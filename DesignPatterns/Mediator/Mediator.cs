using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    /// <summary>
    ///     Посредник. С ним должен быть связан
    ///     Composition Root (корень композиции).
    ///     В нем должна находиться логика конфигурирования IoC контейнера
    ///     или создание явного класса-посредника
    ///     Посредник оперирует конкретными исполнителями
    ///     В других реализациях он может и не знать о конкретных исполнителях,
    ///     Но должен знать об астрактном исполнителе,который знает о конкретных исполнителях.
    /// </summary>
    public static class Mediator
    {
        /// <summary>
        ///     Gets or sets the dictionary of executors.
        /// </summary>
        /// <value>
        ///     The dictionary of executors.
        /// </value>
        private static readonly Dictionary<string, List<IExecutor>> ExecutorsCollection =
            new Dictionary<string, List<IExecutor>>();

        /// <summary>
        ///     Adds the executor.
        /// </summary>
        /// <param name="nameOfConcreteMediator">The name of concrete mediator.</param>
        /// <param name="collectionOfExecutors">The collection of executors.</param>
        public static void AddExecutors(string nameOfConcreteMediator, List<IExecutor> collectionOfExecutors)
        {
            if (ExecutorsCollection.ContainsKey(nameOfConcreteMediator)) return;

            ExecutorsCollection.Add(nameOfConcreteMediator, collectionOfExecutors);
        }

        /// <summary>
        ///     Gets the executors.
        /// </summary>
        /// <param name="nameOfConcreteMediator">The name of concrete mediator.</param>
        /// <returns>collection of executors</returns>
        public static List<IExecutor> GetExecutors(string nameOfConcreteMediator)
        {
            return ExecutorsCollection.Where(ec => ec.Key == nameOfConcreteMediator).Select(ec => ec.Value)
                .FirstOrDefault();
        }

        public static void DoByAllExecutors(string nameOfParticularMediator)
        {
            if (!ExecutorsCollection.ContainsKey(nameOfParticularMediator)) return;

            var particularMediatorExecutors = ExecutorsCollection[nameOfParticularMediator];

            foreach (var executor in particularMediatorExecutors) executor.DoSomething();
        }
    }
}
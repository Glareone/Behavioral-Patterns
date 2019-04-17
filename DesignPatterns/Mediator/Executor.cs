using System;

namespace Mediator
{
    /// <summary>
    ///     Concrete executor
    ///     Конкретный исполнитель
    /// </summary>
    public class Executor
    {
        public Executor(string executorName, string executorGroup, string execute)
        {
            ExecutorName = executorName;
            ExecutorGroup = executorGroup;
            Execute = execute;
        }

        /// <summary>
        ///     Prevents a default instance of the <see cref="Executor" /> class from being created.
        /// </summary>
        private Executor()
        {
        }

        /// <summary>
        ///     Gets the Execute.
        /// </summary>
        /// <value>
        ///     The dosomething.
        /// </value>
        private string Execute { get; }

        /// <summary>
        ///     Gets or sets the name of the executor.
        /// </summary>
        /// <value>
        ///     The name of the executor.
        /// </value>
        private string ExecutorName { get; }

        /// <summary>
        ///     Gets or sets the executor group.
        /// </summary>
        /// <value>
        ///     The executor path.
        /// </value>
        private string ExecutorGroup { get; }

        /// <summary>
        ///     Does something.
        /// </summary>
        public void DoSomething()
        {
            Console.WriteLine($"{ExecutorName}, {ExecutorGroup} : {Execute}, {DateTime.Now}");
        }
    }
}
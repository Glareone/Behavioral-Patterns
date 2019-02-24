using System.Collections.Generic;

namespace Command
{
    /// User Class handles a list of commands
    /// to implement undo(cancel action) and redo(repeat action) functions
    /// it corresponds to class Invoker on the pattern scheme.
    public class User
    {
        private readonly Calculator _calculator = new Calculator();
        private readonly List<ICommand> _commands = new List<ICommand>();

        private int _current;

        public void Compute(char @operator, int operand)
        {
            var command = new CalculatorCommand(_calculator, @operator, operand);
            command.Execute();
            _commands.Add(command);
            _current++;
        }

        public void Undo(int levels)
        {
            for (var i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    _commands[--_current].Undo();
                }
            }
        }

        public void Redo(int levels)
        {
            for (var i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    _commands[_current++].Execute();
                }
            }
        }
    }
}
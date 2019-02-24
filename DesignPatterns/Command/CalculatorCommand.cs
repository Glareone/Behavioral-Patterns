using System;

namespace Command
{
    /// particular command
    /// in different implementations it could be a separate commands
    public class CalculatorCommand : ICommand
    {
        // _calculator - это контекст команды
        private readonly Calculator _calculator;

        private readonly char _operator;
        private readonly int _operand;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public void Undo()
        {
            _calculator.Operation(GetOppositeOperator(_operator), _operand);
        }

        private static char GetOppositeOperator(char @operator)
        {
            const string operators = "+-*/";
            const string opposite = "-+/*";

            var pos = operators.IndexOf(@operator);
            if (pos == -1)
            {
                throw new ArgumentException("@operator");
            }

            return opposite[pos];
        }
    }
}
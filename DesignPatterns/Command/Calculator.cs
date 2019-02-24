using static System.Console;

namespace Command
{
    /// it stores integer value
    /// execute some ariphmetic actions
    /// corresponds with class Receiver on the pattern scheme
    public class Calculator
    {
        private int _value;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    _value += operand;
                    break;
                case '-':
                    _value -= operand;
                    break;
                case '*':
                    _value *= operand;
                    break;
                case '/':
                    _value /= operand;
                    break;
            }
            WriteLine("Current value = {0,1}", _value);
        }
    }
}
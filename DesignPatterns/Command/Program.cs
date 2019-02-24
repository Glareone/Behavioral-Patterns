using static System.Console;

namespace Command
{
    public class Program
    {
        public static void Main()
        {
            // create a new object for calculations
            var user = new User();

            // executing several calculation actions
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // cancel 4 last commands
            WriteLine("Undo 4 commands");
            user.Undo(4);

            // repeat 3 of them again
            WriteLine("Redo 3 commands");
            user.Redo(3);

            ReadLine();
        }
    }
}
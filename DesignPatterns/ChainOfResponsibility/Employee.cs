using static System.Console;

namespace ChainOfResponsibility
{
    public class Employee : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                WriteLine($"{GetType().Name} approved request# {purchase.Number}");
            }
            else
            {
                Successor?.ProcessRequest(purchase);
            }
        }
    }
}
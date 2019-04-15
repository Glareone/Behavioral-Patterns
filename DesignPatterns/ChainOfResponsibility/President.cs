using static System.Console;

namespace ChainOfResponsibility
{
    public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                WriteLine($"{GetType().Name} approved request# {purchase.Number}");
            }
            else
            {
                WriteLine($"Request #{purchase.Number} requires an executive meeting!");
            }
        }
    }
}
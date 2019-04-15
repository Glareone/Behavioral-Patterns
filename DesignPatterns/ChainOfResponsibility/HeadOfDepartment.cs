using static System.Console;

namespace ChainOfResponsibility
{
    public class HeadOfDepartment : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
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
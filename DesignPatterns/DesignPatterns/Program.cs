using static System.Console;

namespace ChainOfResponsibility
{
    public class Program
    {
        private static void Main()
        {
            Approver employee = new Employee();
            Approver theHeadOfDepartment = new HeadOfDepartment();
            Approver thePresident = new President();

            // employee -> theHeadOfDepartment -> thePresident
            employee.SetSuccessor(theHeadOfDepartment);
            theHeadOfDepartment.SetSuccessor(thePresident);

            // generate and process purchase requests
            var amount = 350.00;
            var purchaseNumber = 1;
            var firstPurchase = new Purchase(purchaseNumber, amount, $"{purchaseNumber} purchase with amount: {amount}");
            employee.ProcessRequest(firstPurchase);
            ReadLine();

            amount = 19000.10;
            purchaseNumber = 2;
            var secondPurchase = new Purchase(purchaseNumber, amount, $"{purchaseNumber} purchase with amount: {amount}");
            employee.ProcessRequest(secondPurchase);
            ReadLine();

            amount = 32590.10;
            purchaseNumber = 3;
            var thirdPurchase = new Purchase(purchaseNumber, amount, $"{purchaseNumber} purchase with amount: {amount}");
            employee.ProcessRequest(thirdPurchase);
            ReadLine();

            amount = 122100.00;
            purchaseNumber = 4;
            var fourthPurchase = new Purchase(3, amount, $"{purchaseNumber} purchase with amount: {amount}");
            employee.ProcessRequest(fourthPurchase);
            ReadLine();
        }
    }
}
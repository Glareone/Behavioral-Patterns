using System;

namespace Memento
{
    public class Program
    {
        internal static void Main()
        {
            var elementHistory = new ElementHistory();

            var particularElement = new Element(1, "new awesome article", "some sort of information");
            Console.WriteLine($"initial stage : {particularElement.GetElementData()}");

            elementHistory.Push(particularElement.SaveState());

            particularElement.IncreaseOrder();
            Console.WriteLine($"order was increased : {particularElement.GetElementData()}");

            elementHistory.Push(particularElement.SaveState());

            particularElement.SetInformation("new information for this element");
            particularElement.IncreaseOrder();
            Console.WriteLine($"order and information was changed : {particularElement.GetElementData()}");

            elementHistory.Push(particularElement.SaveState());

            particularElement.DecreaseOrder();
            Console.WriteLine($"order was decreased : {particularElement.GetElementData()}");

            particularElement.RestoreState(elementHistory.Pop());
            Console.WriteLine($"particularElement was restored : {particularElement.GetElementData()}");

            particularElement.RestoreState(elementHistory.Pop());
            Console.WriteLine($"particularElement was restored : {particularElement.GetElementData()}");

            particularElement.RestoreState(elementHistory.Pop());
            Console.WriteLine($"particularElement was restored : {particularElement.GetElementData()}");

            Console.ReadKey();
        }
    }
}

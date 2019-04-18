using System;

namespace Memento
{
    public class Element: ICloneable
    {
        private int Id { get; }
        private string Article { get; }
        private string Information { get; set; }
        private uint Order { get; set; }

        private Element()
        {
        }

        public Element(int id, string article, string information)
        {
            Id = id;
            Article = article;
            Information = information;
            Order = 0;
        }

        public ElementMemento SaveState()
        {
            return new ElementMemento(this);
        }

        public void RestoreState(ElementMemento memento)
        {
            Information = memento.Element.Information;
            Order = memento.Element.Order;
        }

        public void SetInformation(string information)
        {
            Information = information;
        }

        public void IncreaseOrder()
        {
            Order += 1;
        }

        public void DecreaseOrder()
        {
            Order = Order > 0 ? Order-- : Order; 
        }

        public string GetElementData()
        {
            return $"id: {Id}, article: {Article}, information: {Information}, order: {Order}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}

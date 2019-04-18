namespace Memento
{
    public class ElementMemento
    {
        public Element Element { get; }

        private ElementMemento()
        {
        }

        public ElementMemento(Element element)
        {
            Element = element.Clone() as Element;
        }
    }
}

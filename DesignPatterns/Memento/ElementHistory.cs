using System.Collections.Generic;

namespace Memento
{
    public class ElementHistory
    {
        private readonly Stack<ElementMemento> _elementMementosStack;

        public ElementHistory()
        {
            _elementMementosStack = new Stack<ElementMemento>();
        }

        public void Push(ElementMemento elementMemento)
        {
            _elementMementosStack.Push(elementMemento);
        }

        public ElementMemento Pop()
        {
            if (_elementMementosStack.Count == 0) return null;
            return _elementMementosStack.Pop();
        }
    }
}

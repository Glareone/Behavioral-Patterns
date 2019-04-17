using Iterator.Interfaces;

namespace Iterator.Entities
{
    public class ConcreteCollection<T>: IIterableCollection<T> where T : class
    {
        private readonly T[] _innerValues;

        public ConcreteCollection()
        {
            _innerValues = new T[100];
        }

        // Get Default Iterator
        public IIterator<T> GetIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        // Get Selected Iterator
        public IIterator<T> GetIterator(IIterator<T> selectedIterator)
        {
            return selectedIterator;
        }

        public T this[int index]
        {
            get => index <= _innerValues.Length - 1 ? _innerValues[index] : null;
            set
            {
                if (index <= _innerValues.Length - 1)
                {
                    _innerValues[index] = value;
                }
            }
        }

        public int Count => _innerValues.Length;
    }
}

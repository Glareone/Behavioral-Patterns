using System;
using Iterator.Interfaces;

namespace Iterator.Entities
{
    public class ConcreteIterator<T>: IIterator<T> where T : class
    {
        private readonly IIterableCollection<T> _aggregate;
        private int _currentIndex;

        public ConcreteIterator(IIterableCollection<T> aggregate)
        {
            _aggregate = aggregate;
        }

        public T FirstItem => _aggregate[0];

        public T GetNext
        {
            get
            {
                _currentIndex += 1;
                if (HasNext())
                {
                    return _aggregate[_currentIndex];
                }

                return null;
            }
        }

        public bool HasNext()
        {
            return _currentIndex < _aggregate.Count && _aggregate[_currentIndex] != null;
        }
    }
}

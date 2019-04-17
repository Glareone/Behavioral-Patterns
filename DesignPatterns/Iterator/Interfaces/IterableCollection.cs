namespace Iterator.Interfaces
{
    public interface IIterableCollection<T> where T: class
    {
        IIterator<T> GetIterator();
        T this[int index] { get; set; }
        int Count { get; }
    }
}

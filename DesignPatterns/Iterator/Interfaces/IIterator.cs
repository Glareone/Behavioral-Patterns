namespace Iterator.Interfaces
{
    public interface IIterator<out T> where T: class
    {
        T FirstItem { get; }
        T GetNext { get; }
        bool HasNext();
    }
}

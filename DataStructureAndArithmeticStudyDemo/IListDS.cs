namespace DataStructureAndArithmeticStudyDemo
{
    public interface IListDS<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Append(T item);
        void Insert(T item, int i);
        T Delete(int i);
        T GetElement(int i);
        int Locate(T value);
        void Reverse();
    }    
}

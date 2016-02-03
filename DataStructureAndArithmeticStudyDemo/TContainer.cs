namespace DataStructureAndArithmeticStudyDemo
{
    public class TContainer<T>
    {
        readonly int Size;
        int ContainerPointer;
        T[] Items;
        public TContainer()
            : this(100)
        {
            ContainerPointer = -1;
            Size = 100;
        }
        public TContainer(int size)
        {
            Size = size;
            Items = new T[Size];
            ContainerPointer = -1;
        }
        public int Count
        {
            get
            {
                return ContainerPointer;
            }
        }
        public bool IsEmpty
        {
            get
            {
                return (ContainerPointer == -1);
            }
        }
        public bool IsFull
        {
            get
            {
                return (ContainerPointer == Size);
            }
        }
        public void Insert(T item)
        {
            if (IsFull)
            {
                return;
            }
            else
            {
                Items[++ContainerPointer] = item;
            }
        }
        public T DeleteInTail()
        {
            if (ContainerPointer >= 0)
            {
                return Items[ContainerPointer--];
            }
            return default(T);
        }
    }
}

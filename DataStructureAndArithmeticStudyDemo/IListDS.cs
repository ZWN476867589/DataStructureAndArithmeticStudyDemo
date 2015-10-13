using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    public class SeqList<T> : IListDS<T>
    {
        private int maxSize;
        private T[] Data;
        private int last;
        public T this[int index]
        {
            get
            {
                return Data[index];
            }
            set
            {
                Data[index] = value;
            }
        }
        public int Last
        {
            get
            {
                return last;
            }
        }
        public int MaxSize
        {
            get
            {
                return maxSize;
            }
            set
            {
                maxSize = value;
            }
        }
        public SeqList(int size)
        {
            maxSize = size;
            Data = new T[maxSize];
            last = -1;
        }
        public int GetLength()
        {
            return last + 1;
        }
        public void Clear()
        {
            last = -1;
        }
        public bool IsEmpty()
        {
            if (last == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFull()
        {
            if (last == maxSize - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Append(T item)
        {
            if (IsFull())
            {
                return;
            }
            Data[++last] = item;
        }
        public void Insert(T item, int i)
        {
            if (IsFull())
            {
                return;
            }
            if (i < 1 || i > last + 2)
            {
                return;
            }
            if (i == last + 2)
            {
                Data[last + 1] = item;
            }
            else
            {
                for (int j = last; j >= i - 1; --j)
                {
                    Data[j + 1] = Data[j];
                }
                Data[i - 1] = item;
            }
            ++last;
        }
        public T Delete(int i)
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                return tmp;
            }
            if (i < 1 || i > last + 2)
            {
                return tmp;
            }
            if (i == last + 1)
            {
                tmp = Data[last--];
            }
            else
            {
                tmp = Data[i - 1];
                for (int j = i; j <= last; ++j)
                {
                    Data[j] = Data[j + 1];
                }
            }
            --last;
            return tmp;
        }
        public T GetElement(int i)
        {
            if (IsEmpty())
            {
                return default(T);
            }
            return Data[i - 1];
        }
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                return -1;
            }
            int i = 0;
            for (i = 0; i < last; ++i)
            {
                if (value.Equals(Data[i]))
                {
                    break;
                }
            }
            if (i > last)
            {
                return -1;
            }
            return i;
        }
        public void Reverse()
        {
            T tmp = default(T);
            int len = GetLength();
            for (int i = 0; i < len / 2; ++i)
            {
                tmp = Data[i];
                Data[i] = Data[len - i];
                Data[len - i] = tmp;
            }
        }
        public SeqList<int> Merge(SeqList<int> L1, SeqList<int> L2)
        {
            SeqList<int> L3 = new SeqList<int>(L1.MaxSize + L2.MaxSize);
            int i = 0, j = 0;
            while ((i <= L1.GetLength() - 1) && (j <= L2.GetLength() - 1))
            {
                if (L1[i] < L2[j])
                {
                    L3.Append(L1[i++]);
                }
                else
                {
                    L3.Append(L2[j++]);
                }

            }
            while (i <= (L1.GetLength() - 1))
            {
                L3.Append(L1[i++]);
            }
            while (j <= (L3.GetLength() - 1))
            {
                L3.Append(L2[j++]);
            }
            return L3;
        }
        public SeqList<int> Purge(SeqList<int> La)
        {
            SeqList<int> Lb = new SeqList<int>(La.MaxSize);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Test1
{
    class Collection<T>
    {
        private T[] _data;
        protected internal int Length = 0;

        public Collection() => _data = new T[0];

        public void Add(T item)
        {
            T[] newData = new T[_data.Length + 1];
            
            for (int i = 0; i < _data.Length; i++)
            {
                newData[i] = _data[i];
            }

            newData[_data.Length] = item;
            _data = newData;
            Length = newData.Length;
        }

        public void Remove(T itemRemove)
        {
            int index = -1;

            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i].Equals(itemRemove))
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
            {
                T[] newData = new T[_data.Length - 1];
                for (int i = 0, j = 0; i < newData.Length; i++)
                {
                    if (i == index) continue;
                    newData[j] = _data[i];
                    j++;
                }

                _data = newData;
                Length = newData.Length;
            }
        }

        public T GetItem(int index)
        {
            if (index > -1 && index < _data.Length)
                return _data[index];
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        internal List<T> ToList<T>() => _data.Cast<T>().ToList(); // LINQ
    }
    class Program
    {
        static void Main()
        {
            Collection<string> n = new Collection<string>();
            n.Add("Unreal Engine");
            n.Add("Unity");
            n.Add("Cocos2D");
            n.Add("CryEngine 3");
            n.Add("Game Maker Studio");

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"{i+1}: {n.GetItem(i)}");
            }

            List<string> list = n.ToList<string>();

            int startsWithC = (from e in list where e.StartsWith("C") select e).Count();  // LINQ
            Console.WriteLine($"Количество движков по букве 'C': {startsWithC}");
        }
    }
}
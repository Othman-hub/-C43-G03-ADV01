using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01ِADV.Q4
{
    internal class FixedSizeList<T>
    {
        public  int Size { get; }
        public FixedSizeList(int size) 
        {
            Size = size;
        }
        private List<T> list = new List<T>();
        public void Add(T item)
        {
            if(list.Count == Size)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                list.Add(item);
            }
        }
        public T GetItem(int index) 
        { 
            return list[index];
        }
    }
}

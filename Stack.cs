using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Stack <T>
    {
        private List<T> imya_massiva = new List<T>();
        public void Add(T newItem)
        {
            imya_massiva.Add(newItem);
        }
        public T Get()
        {
            return imya_massiva[imya_massiva.Count - 1];
        }
        public T Get_and_Remove()
        {
            T a1 = imya_massiva[imya_massiva.Count - 1];
            imya_massiva.RemoveAt(imya_massiva.Count - 1);
            return a1;
        }
        public void Remove()
        {
            imya_massiva.RemoveAt(imya_massiva.Count - 1);
        }
        public int Count()
        {
            return imya_massiva.Count;
        }
    }
}

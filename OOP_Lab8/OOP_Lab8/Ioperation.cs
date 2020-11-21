using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab8
{
    interface Ioperation<T>
    {
        public void Add(T el);
        public void Remove(T el);
        public void Show();
    }
}

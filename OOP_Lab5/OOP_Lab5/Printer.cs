using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab5
{
    public class Printer : Abstract
    {
        public void ShowInformation(object obj)
        {
            Console.WriteLine("Empty");
        }

        public override string WriteType()
        {
            return "Printer obj";
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void IAmPrinting(Object obj)
        {
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.ToString() + "\n");
        }

    }
}

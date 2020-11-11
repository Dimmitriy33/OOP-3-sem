using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab6
{
    public abstract class Abstract
    {
        public int MaxSpeed { get; set; }
        public int MinSpeed { get; set; }

        public string type = "transport";

        public virtual void ShowClass()
        {
            Console.WriteLine("Abstract");
        }

        public virtual void ShowInformation()
        {
            Console.WriteLine("EmptyInfo");
        }

        public virtual string WriteType()
        {
            return "EmptyInfo";
        }

    }
}

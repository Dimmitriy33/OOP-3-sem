using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab6
{
    public class Test : Abstract, Interface1
    {
        public override string WriteType()
        {
            return "Test obj";
        }

        public override void ShowInformation()
        {
            Console.WriteLine("Test");
        }
    }
}

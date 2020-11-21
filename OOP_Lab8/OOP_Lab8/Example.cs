using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab8
{
    [Serializable] public class Example
    {
        string Name;
        string Surname;

        public Example()
        {
            Name = "Pupa";
            Surname = "Lupa";
        }

        public Example(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}

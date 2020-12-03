using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace OOP_Lab11
{
    public class Multitude
    {

        private List<int> elems = new List<int>();
        private string MulName; 

        public List<int> Elems
        {
            get => elems;
            set => elems = value;
        }

        public string MULName
        {
            get => MulName;
            set => MulName = value;
        }

        public Multitude()
        {
            MulName = "unknown";
        }

        //конструкторы
        public Multitude(List<int> list) => this.elems = list;

        public Multitude(string name) => this.MulName = name;

        public Multitude(List<int> list, string name)
        {
            this.elems = list;
            this.MulName = name;
        }
    }

}

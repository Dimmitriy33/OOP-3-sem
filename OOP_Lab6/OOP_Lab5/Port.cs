using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab6
{
    class Port
    {
        public List<object> elems = new List<object>();
        public List<object> ListOfElems
        {
            get => elems;
            set => elems = value;
        }

        public Port()
        {

        }

        public void Add(Corvette corvette)
        {
            elems.Add(corvette);
        }

        public void Add(Ship ship)
        {
            elems.Add(ship);
        }

        public void Add(Boat boat)
        {
            elems.Add(boat);
        }

        public void Add(Streamer streamer)
        {
            elems.Add(streamer);
        }

        public void Add(Sailboat sailboat)
        {
            elems.Add(sailboat);
        }

        public void Remove(Ship ship)
        {
            elems.Remove(ship);
        }

        public void Remove(Corvette corvette)
        {
            elems.Remove(corvette);
        }


        public void Remove(Boat boat)
        {
            elems.Remove(boat);
        }

        public void Remove(Streamer streamer)
        {
            elems.Remove(streamer);
        }

        public void Remove(Sailboat sailboat)
        {
            elems.Remove(sailboat);
        }

        public void ToConsole()
        {
            foreach(object obj in elems)
            {
                Console.WriteLine(obj.ToString());
            }
        }

    }
}

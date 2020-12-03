using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab10
{
    public class Plant : IList<Plant>
    {

        private string type;
        private double length;

        private readonly IList<Plant> _list = new List<Plant>();

        public string Type
        {
            get => type;
            set => type = value;
        }

        public double Length
        {
            get => length;
            set => length = value;
        }

        public Plant()
        {
            this.type = null;
            this.length = 0;
        }

        public Plant(string type)
        {
            this.type = type;
            this.length = 0;
        }

        public Plant(double length)
        {
            this.type = null;
            this.length = length;
        }

        public Plant(string type, double length)
        {
            this.type = type;
            this.length = length;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        IEnumerator<Plant> IEnumerable<Plant>.GetEnumerator() => _list.GetEnumerator();
        void ICollection<Plant>.Add(Plant item) => _list.Add(item);
        bool ICollection<Plant>.Remove(Plant item) => _list.Remove(item);
        void ICollection<Plant>.Clear() => _list.Clear();
        int ICollection<Plant>.Count => _list.Count;
        bool ICollection<Plant>.Contains(Plant item) => _list.Contains(item);
        bool ICollection<Plant>.IsReadOnly => _list.IsReadOnly;
        void ICollection<Plant>.CopyTo(Plant[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);
        int IList<Plant>.IndexOf(Plant item) => _list.IndexOf(item);
        void IList<Plant>.Insert(int index, Plant item) => _list.Insert(index, item);
        void IList<Plant>.RemoveAt(int index) => _list.RemoveAt(index);

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }

        Plant IList<Plant>.this[int index]
        {
            set => _list[index] = value;
            get => _list[index];
        }

    }

    }


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab8
{
    [Serializable] public class Vector<T> : Ioperation<T> where T : class
    {
        public string Path = @"D:\учеба\ООП\lab8\OOP_Lab8\OOP_Lab8\1.txt";

        private const int maxVectorSize = 100;
        public int size;
        public T[] elems = new T[maxVectorSize];

        [Serializable] public class Owner
        {
            int id;
            string name;
            string companyName;

            public Owner(int id = 1, string name = "Dmitriy", string companyName = "417ROOM corporation")
            {
                this.id = id;
                this.name = name;
                this.companyName = companyName;
            }

            public int ID
            {
                get
                {
                    return id;
                }
            }
            public string Name
            {
                get
                {
                    return name;
                }
            }
            public string CompanyName
            {
                get
                {
                    return companyName;
                }
            }

            public void ShowInfo() => Console.WriteLine($"ID -> {id}\nName -> {name}\nCompany name -> {companyName}\n"); // лямбда-выражение
        }

        [Serializable] public class Date
        {
            DateTime date1;

            public Date(int year = 2020, int month = 10, int day = 2, int hour = 15, int minute = 12, int second = 20)
            {
                date1 = new DateTime(year, month, day, hour, minute, second);
            }

            public void ShowDate() => Console.WriteLine($"{date1}\n"); // лямбда-выражение
        }

        public Owner owner = new Owner();
        public Date date = new Date();

        //индексатор
        public T this[int index]
        {
            get
            {
                return elems[index];
            }

            set
            {
                elems[index] = value;
            }
        }

        //конструкторы
        public void Add(params T[] el)
        {
            for (int i = 0; i < el.Length; i++)
            {
                this.elems[i] = el[i];
            }
            this.size = el.Length;
        }

        public void Add(T el)
        {
            this.elems[this.size] = el;
            this.size++;
        }

        public void Remove(T el)
        {

            for (int i = 0; i < elems.Length; i++)
            {
                if ((dynamic)this.elems[i] == (dynamic)el)
                {
                    for (int j = i; j < elems.Length - i; j++)
                        this.elems[j] = this.elems[j + 1];
                    this.elems[this.size] = default;
                    this.size--;
                }

            }
        }

        public void Show()
        {
            for (int i = 0; i < this.size; i++)
                Console.WriteLine(this.elems[i]);

            Console.WriteLine();
        }

        public Vector()
        {
            this.size = 0;
        }
        //перегрузки
        public static Vector<T> operator +(Vector<T> vector1, Vector<T> vector2)
        {
            Vector<T> vector = new Vector<T>();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = default;
                // default присваивает ссылочным типам в качестве значения null, а типам значений - значение 0
                vector.size = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = default;
                vector.size = vector2.size;
            }
            for (int i = 0; i < vector.size; i++)
                vector.elems[i] = (dynamic)vector1.elems[i] + (dynamic)vector2.elems[i];
            return vector;
        }

        public static Vector<T> operator -(Vector<T> vector1, Vector<T> vector2)
        {
            Vector<T> vector = new Vector<T>();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = default;
                vector.size = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = default;
                vector.size = vector2.size;
            }
            for (int i = 0; i < vector.size; i++)
                vector.elems[i] = (dynamic)vector1.elems[i] - (dynamic)vector2.elems[i];
            return vector;
        }

        public static bool operator >(Vector<T> vector1, Vector<T> vector2)
        {
            bool f = true;
            int maxSize = 0;
            Vector<T> vector = new Vector<T>();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = default;
                maxSize = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = default;
                maxSize = vector2.size;
            }
            for (int i = 0; i < maxSize; i++)
                if ((dynamic)vector2.elems[i] > (dynamic)vector1.elems[i])
                    f = false;
            return f;
        }

        public static bool operator <(Vector<T> vector1, Vector<T> vector2)
        {
            bool f = true;
            int maxSize = 0;
            Vector<T> vector = new Vector<T>();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = default;
                maxSize = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = default;
                maxSize = vector2.size;
            }
            for (int i = 0; i < maxSize; i++)
                if ((dynamic)vector2.elems[i] < (dynamic)vector1.elems[i])
                    f = false;
            return f;
        }

        public static bool operator !=(Vector<T> vector1, Vector<T> vector2)
        {
            bool f = true;
            int maxSize = 0;
            Vector<T> vector = new Vector<T>();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = default;
                maxSize = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = default;
                maxSize = vector2.size;
            }
            for (int i = 0; i < maxSize; i++)
                if ((dynamic)vector2.elems[i] == (dynamic)vector1.elems[i])
                    f = false;
            return f;
        }

        public static bool operator ==(Vector<T> vector1, Vector<T> vector2)
        {
            bool f = true;
            int maxSize = 0;
            Vector<T> vector = new Vector<T>();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = default;
                maxSize = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = default;
                maxSize = vector2.size;
            }
            for (int i = 0; i < maxSize; i++)
                if ((dynamic)vector2.elems[i] != (dynamic)vector1.elems[i])
                    f = false;
            return f;
        }

        public static bool operator true(Vector<T> vector)
        {
            /*if (vector.size == 0)
                return true;
            else return false;*/
            return vector.size == 0;
        }

        public static bool operator false(Vector<T> vector)
        {
            /*if (vector.size != 0)
                return true;
            else return false;*/
            return vector.size != 0;
        }

        //методы

        public void isEmptystr(string s)
        {
            if (this)
                Console.WriteLine($"{s} - пустой ");
            else
                Console.WriteLine($"{s} - не пустой ");
        }


    }
}

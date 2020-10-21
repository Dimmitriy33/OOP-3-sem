using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    public class Vector
    {
        private const int maxVectorSize = 100;
        public int size;
        public int[] elems = new int[maxVectorSize];

        public class Owner
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

        public class Date
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
        public int this[int index]
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
        public Vector(params int[] el)
        {
            for (int i = 0; i < el.Length; i++)
            {
                this.elems[i] = el[i];
            }
            this.size = el.Length;
        }

        public Vector()
        {
            this.size = 0;
        }

        //перегрузки
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            Vector vector = new Vector();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = 0;
                vector.size = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = 0;
                vector.size = vector2.size;
            }
            for (int i = 0; i < vector.size; i++)
                vector.elems[i] = vector1.elems[i] + vector2.elems[i];
            return vector;
        }

        public static Vector operator -(Vector vector1, Vector vector2)
        {
            Vector vector = new Vector();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = 0;
                vector.size = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = 0;
                vector.size = vector2.size;
            }
            for (int i = 0; i < vector.size; i++)
                vector.elems[i] = vector1.elems[i] - vector2.elems[i];
            return vector;
        }

        public static bool operator >(Vector vector1, Vector vector2)
        {
            bool f = true;
            int maxSize = 0;
            Vector vector = new Vector();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = 0;
                maxSize = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = 0;
                maxSize = vector2.size;
            }
            for (int i = 0; i < maxSize; i++)
                if (vector2.elems[i] > vector1.elems[i])
                    f = false;
            return f;
        }

        public static bool operator <(Vector vector1, Vector vector2)
        {
            bool f = true;
            int maxSize = 0;
            Vector vector = new Vector();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = 0;
                maxSize = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = 0;
                maxSize = vector2.size;
            }
            for (int i = 0; i < maxSize; i++)
                if (vector2.elems[i] < vector1.elems[i])
                    f = false;
            return f;
        }

        public static bool operator !=(Vector vector1, Vector vector2)
        {
            bool f = true;
            int maxSize = 0;
            Vector vector = new Vector();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = 0;
                maxSize = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = 0;
                maxSize = vector2.size;
            }
            for (int i = 0; i < maxSize; i++)
                if (vector2.elems[i] == vector1.elems[i])
                    f = false;
            return f;
        }

        public static bool operator ==(Vector vector1, Vector vector2)
        {
            bool f = true;
            int maxSize = 0;
            Vector vector = new Vector();
            if (vector1.size > vector2.size)
            {
                for (int i = vector2.size; i < vector1.size; i++)
                    vector2.elems[i] = 0;
                maxSize = vector1.size;
            }
            else
            {
                for (int i = vector1.size; i < vector2.size; i++)
                    vector1.elems[i] = 0;
                maxSize = vector2.size;
            }
            for (int i = 0; i < maxSize; i++)
                if (vector2.elems[i] != vector1.elems[i])
                    f = false;
            return f;
        }

        public static bool operator true(Vector vector)
        {
            if (vector.size == 0)
                return true;
            else return false;
        }

        public static bool operator false(Vector vector)
        {
            if (vector.size != 0)
                return true;
            else return false;
        }

        //методы

        public void isEmptystr(string s)
        {
            if (this)
                Console.WriteLine($"{s} - пустой ");
            else
                Console.WriteLine($"{s} - не пустой ");
        }

        public void DeleteFirst()
        {
            for (int i = 0; i < this.elems.Length - 1; i++)
                this.elems[i] = this.elems[i + 1];
            this.elems[this.size] = 0;
            this.size--;

        }

        public void DeleteMinus()
        {
            for (int i = 0; i < this.size; i++)
            {
                if (this.elems[i] < 0)
                {
                    for (int j = i; j < this.elems.Length - 1; j++)
                        this.elems[j] = this.elems[j + 1];
                    this.elems[this.size] = 0;
                    this.size--;
                }

            }

        }

    }

    internal static class StatisticOperation
    {
        internal static int sum(Vector vector)
        {
            int sum = 0;
            for (int i = 0; i < vector.elems.Length; i++)
                sum += vector.elems[i];
            return sum;
        }

        internal static int MaxMinDifference(Vector vector)
        {
            int min = 0, max = 0;
            for (int i = 0; i < vector.elems.Length; i++)
            {
                if (vector.elems[i] > max)
                    max = vector.elems[i];
                else if (vector.elems[i] < min)
                    min = vector.elems[i];
            }

            return max - min;
        }

        internal static int Count(Vector vector)
        {
            return vector.size;
        }

        internal static int[] FromStringToArrInt(string str)
        {
            int[] arr = str.Split(' ').Select(Int32.Parse).ToArray();
            return arr;
        }

        internal static int[] FromVectorToArrInt(Vector vector)
        {
            int[] arr = new int[vector.size];
            for (int i = 0; i < vector.size; i++)
                arr[i] = vector.elems[i];
            return arr;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector[] points = new Vector[5] {new Vector(1,2,3,4,5),new Vector(1,2,3,5), new Vector(2,3,4,5,6), new Vector(5,-5,7) ,new Vector() };

            Console.WriteLine($"points[2] > points[0] is {points[2] > points[0]}");
            Console.WriteLine($"points[2] < points[3] is {points[2] < points[3]}");

            Console.Write($"\npoints[1] + points[2] is  < ");
            for (int i = 0; i < (points[1] + points[2]).size; i++)
                Console.Write($"{(points[1] + points[2]).elems[i]}, ");
            Console.Write(">\n");

            Console.Write($"points[3] - points[2] is < ");
            for (int i = 0; i < (points[3] - points[2]).size; i++)
                Console.Write($"{(points[3] - points[2]).elems[i]}, ");
            Console.Write(">\n\n");


            points[1].isEmptystr("points[1]");
            points[3].isEmptystr("testEmpty");
            points[4].isEmptystr("testEmpty");

            points[0].DeleteFirst();
            Console.Write($"\npoints[0] is < ");
            for (int i = 0; i < points[0].size; i++)
                Console.Write($"{points[0].elems[i]}, ");
            Console.Write(">\n");

            points[3].DeleteMinus();
            Console.Write($"\npoints[3] is < ");
            for (int i = 0; i < points[3].size; i++)
                Console.Write($"{points[3].elems[i]}, ");
            Console.Write(">\n\n");

            //задание 2
            points[0].owner.ShowInfo();

            //задание 3
            points[0].date.ShowDate();

            //задание 4
            Console.WriteLine($"Sum points[0] = {StatisticOperation.sum(points[0])}");
            Console.WriteLine($"Sum points[0] = {StatisticOperation.MaxMinDifference(points[0])}");
            Console.WriteLine($"Sum points[0] = {StatisticOperation.Count(points[0])}");

            //задание 5
            string str = "1 2 3 4 5";
            int[] arr1 = StatisticOperation.FromStringToArrInt(str);
            int[] arr2 = StatisticOperation.FromVectorToArrInt(points[0]);

        }
    }
}

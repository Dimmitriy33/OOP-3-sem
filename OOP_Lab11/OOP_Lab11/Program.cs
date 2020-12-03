using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;
using StackExchange.Redis;

namespace OOP_Lab11
{
    public static class MultitudeExtensions
    {
        public static void Print(this Multitude mul)
        {
            Console.Write($"{mul.MULName}" + " {");
            foreach (int el in mul.Elems)
                Console.Write(" " + el);
            Console.Write(" }\n");
        }
    }

    public class ForJoin
    {
        string MulName;
        string MulType;
        public string MULName
        {
            get => MulName;
            set => MulName = value;
        }

        public string MULType
        {
            get => MulType;
            set => MulType = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] monthNames = CultureInfo.GetCultureInfo("en-GB").DateTimeFormat.MonthNames;

            Console.WriteLine("Enter a month length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Months consist of {n} letters: ");
            var selectedMonths = from month in monthNames where (month.Length == n) select month;
            foreach (string s in selectedMonths)
                Console.Write(s + " ");
            Console.WriteLine();

            Console.Write("Winter and Summer months: ");
            var winterAndsummerMonths = from month in monthNames where ((month == "January" || month == "December" ||
                month == "February" || month == "June" || month == "July" || month == "August")) select month;
            foreach (string s in winterAndsummerMonths)
                Console.Write(s + " ");
            Console.WriteLine();

            Console.Write("Months alphabetically: ");
            var SortMonth = monthNames.OrderBy(s => s);
            foreach (string s in SortMonth)
                Console.Write(s + " ");
            Console.WriteLine();

            Regex rgx = new Regex(@"u+"); // регулярные выражения
            Console.Write("Months with letter u and less then 5 letters: ");
            var MonthsWithUAndLess5 = monthNames.Where(month => rgx.IsMatch(month) && month.Length < 5);
            foreach (string s in MonthsWithUAndLess5)
                Console.Write(s + " ");
            Console.WriteLine();
            Console.WriteLine();

            //2

            List<Multitude> _list = new List<Multitude>();
            Multitude mul1 = new Multitude(new List<int>() { 1, 2, 3, 4 }, "m1");
            Multitude mul2 = new Multitude(new List<int>() { 2, 1, 4, 3 }, "mul2");
            Multitude mul3 = new Multitude(new List<int>() { 1, -2 }, "mult3");
            Multitude mul4 = new Multitude(new List<int>() { 2, 3, 4 }, "mul4");
            Multitude mul5 = new Multitude(new List<int>() { 1, 2, -3, 4, 5, 6 }, "mul5");
            Multitude mul6 = new Multitude(new List<int>() { 1, -2, 3, 4, 6 }, "mult6");
            Multitude mul7 = new Multitude(new List<int>() { 3, 3, 3, -3, 5 }, "mult6");
            Multitude mul8 = new Multitude(new List<int>() { }, "mul8");
            _list.Add(mul1);
            _list.Add(mul2);
            _list.Add(mul3);
            _list.Add(mul4);
            _list.Add(mul5);
            _list.Add(mul6);
            _list.Add(mul7);
            _list.Add(mul8);


            Console.Write("Mul with shortest name: ");
            var minNameIndex = _list.Min(CurMul => CurMul.MULName);
            var minName = _list.Where(CurMul => CurMul.MULName == minNameIndex);
            foreach (var name in minName)
            {
                name.Print();
            }
            Console.WriteLine();
            Console.WriteLine();

            //3

            var min = _list.Min(list => list.Elems.Sum());
            var Elmin = from list in _list where (list.Elems.Sum() == min) select list;
            Console.WriteLine($"Min: {min}");
            foreach (var el in Elmin)
                el.Print();
            Console.WriteLine();

            var max = _list.Max(list => list.Elems.Sum());
            var Elmax = from list in _list where (list.Elems.Sum() == max) select list;
            Console.WriteLine($"Max: {max}");
            foreach (var el in Elmax)
                el.Print();
            Console.WriteLine();

            var nullList = _list.Where(list => list.Elems.Count == 0);
            Console.WriteLine($"NullList: ");
            foreach (var el in nullList)
                el.Print();
            Console.WriteLine();

            var haveEl = _list.Count(list => list.Elems.Contains(3));
            Console.WriteLine($"Mult which have 3 : {haveEl}");

            var BiggestList = _list.Max(list => list.Elems.Count);
            var BiggestListCount = _list.Where(list => list.Elems.Count == BiggestList);
            Console.WriteLine();

            var NeededEl = _list.Where(list => list.Elems.Contains(6));
            var FirstNeededEl = NeededEl.First();
            Console.WriteLine("First mul with needed element : ");
            FirstNeededEl.Print();
            Console.WriteLine();

            Console.WriteLine("Sorted List by first el: ");
            var ListWithoutNull = _list.Where(list => list.Elems.Count != 0);
            var sortList = ListWithoutNull.OrderBy(list => list.Elems.First());
            foreach (var el in sortList)
                el.Print();

            //4

            /*IEnumerable<Multitude> FindMyEl = (from list in _list
                                               orderby list.Elems.Count
                                               where list.MULName.Contains('t')
                                               group list by list.MULName == "mult6" into l
                                               select l);*/
            var FindMyElems = _list.Where(list => list.MULName.Contains('t')).OrderBy(list => list.Elems.Count).
                    GroupBy(list => list.MULName == "mult6").Select(g => g);
            //5

            List<ForJoin> forjoin = new List<ForJoin>()
            {
                new ForJoin {MULName = "mult6", MULType = "int"},
                new ForJoin {MULName = "mul1", MULType = "int"}
            };

            var new_list = from el in forjoin
                           join mul in _list on el.MULName equals mul.MULName
                           select new{MULName = mul.MULName, MULType = el.MULType, elems = mul.Elems};

        }
    }
}

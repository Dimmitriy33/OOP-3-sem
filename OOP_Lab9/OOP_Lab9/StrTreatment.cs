using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab9
{
    class StrTreatment
    {
        //public delegate void Action<T>(T obj)
        //public delegate TResult Func<out TResult>();
        //public delegate bool Predicate<in T>(T obj);

        public static void Show(Action<string> oper, ref string str) => oper(str);

        public static void NoCommas(string str)
        {
            str = str.Replace(",", " ");
            Console.WriteLine(str);
        }
        public static void ToLower(string str)
        {
            str = str.ToLower();
            Console.WriteLine(str);
        }
        public static void AddHello(string str)
        {
            str += "Hello";
            Console.WriteLine(str);
        }

        public static string NoCommas2(string str)
        {
            str = str.Replace(",", " ");
            return str;
        }
        public static string ToLower2(string str) => str = str.ToLower();
        public static string AddHello2(string str) => str += "Hello";

        public static void Show2(Func<string, string> oper, ref string str) => Console.WriteLine(oper(str) + "\n");


    }
}

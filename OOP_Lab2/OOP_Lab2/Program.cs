using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace OOP_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------- ТИПЫ ----------------------------------------------------

            bool temp1 = true;
            byte temp2 = 1;
            sbyte temp3 = -1;
            char temp4 = 'a';
            decimal temp5 = 123.45m; // m or M suffix is of type decimal + increased accuracy(28 - 29 digits) -- 16 bytes
            double temp6 = 123.45; // without suffix or with the d or D suffix is of type double -- 8 bytes
            float temp7 = 123.45f; //// m or M suffix is of type decimal -- 4 bytes
            int temp8 = -12; // or System.Int32 temp8 = 123;
            uint temp9 = 12;
            long temp10 = -123;
            ulong temp11 = 123;
            short temp12 = -12;
            ushort temp13 = 12;
            object temp14 = 'a'; // You can assign values of any type to variables of type object
            string temp15 = "Daroy";
            dynamic temp16 = 21; // Это ключевое слово позволяет опустить проверку типов во время компиляции. Кроме того, объекты, объявленные как dynamic, могут в течение работы программы менять свой тип

            Console.WriteLine("  --- Input ---");
            Console.WriteLine();
            Console.Write("Bool: ");
            temp1 = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Byte: ");
            temp2 = Convert.ToByte(Console.ReadLine());
            Console.Write("sbyte: ");
            temp3 = Convert.ToSByte(Console.ReadLine());
            Console.Write("char: ");
            temp4 = Convert.ToChar(Console.ReadLine());
            Console.Write("decimal: ");
            temp5 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("double: ");
            temp6 = double.Parse(Console.ReadLine());
            Console.Write("float: ");
            temp7 = float.Parse(Console.ReadLine());
            Console.Write("int: ");
            temp8 = int.Parse(Console.ReadLine());
            Console.Write("uint: ");
            temp9 = uint.Parse(Console.ReadLine());
            Console.Write("long: ");
            temp10 = long.Parse(Console.ReadLine());
            Console.Write("ulong: ");
            temp11 = ulong.Parse(Console.ReadLine());
            Console.Write("short: ");
            temp12 = short.Parse(Console.ReadLine());
            Console.Write("ushort: ");
            temp13 = ushort.Parse(Console.ReadLine());
            Console.Write("object: ");
            temp14 = Console.ReadLine();
            Console.Write("string: ");
            temp15 = Console.ReadLine();
            Console.Write("dynamic: ");
            temp16 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("  --- Output ---");
            Console.WriteLine();
            Console.WriteLine($"Bool: {temp1}"); // 1 variant
            Console.WriteLine("Byte: " + temp2); // 2 variant
            Console.WriteLine("Sbyte: " + (byte)temp3);
            Console.WriteLine("Char: " + temp4);
            Console.WriteLine("Decimal: " + temp5);
            Console.WriteLine("Double: " + (decimal)temp6);
            Console.WriteLine("Float: " + (double)temp7);
            Console.WriteLine("Int: " + (float)temp8);
            Console.WriteLine("Uint: " + temp9);
            Console.WriteLine("Long: " + temp10);
            Console.WriteLine("Ulong: " + temp11);
            Console.WriteLine("Short: " + (int)temp12);
            Console.WriteLine("Ushort: " + temp13);
            Console.WriteLine("Object: " + temp14);
            Console.WriteLine("String: " + temp15);
            Console.WriteLine("Dynamic: " + temp16);
            Console.WriteLine();
            Console.WriteLine();

            // reference types(ссылочные): class, object, string, ...
            // value types(значимые): struct, enum, byte, int, long, ...

            // value -> reference -- boxing(упаковка)
            // reference -> value -- unboxing(распаковка)

            temp14 = temp8; //  int -> object -- boxing
            temp8 = (int)temp14; // object -> int -- unboxing
            // аналагично с остальными(не вижу смысла писать)

            // var -  позволяет создать переменную без указания конкретного типа
            var temp17 = 7;
            var temp18 = 'a';
            /*temp18 = 7;*/ // ---------------- EEEEE  RRRRR  RRRRR OOOOO RRRRR ----------------
            var temp19 = "hello";
            var temp20 = new object[1, 2, 3];
            Console.WriteLine($"temp17: {temp17}");
            Console.WriteLine($"temp18: {temp18}");
            Console.WriteLine($"temp19: {temp19}");
            Console.WriteLine($"temp20: {temp20}");

            Nullable<int> temp21 = null;
            Nullable<double> temp22 = null;
            // or (records are equivalent)
            int? temp23 = null;
            double? temp24 = null;

            Console.WriteLine($"temp21: {temp21}");
            Console.WriteLine($"temp24: {temp24}");
            Console.WriteLine();

            //--------------------------------------------- СТРОКИ ----------------------------------------------------

            string str1 = "hello", str2 = "world", str3 = "hello";

            Console.WriteLine($"str1 = str2 -- {String.Equals(str1, str2)}"); // Equals -- сравненеи строк
            Console.WriteLine($"str1 = str3 -- {String.Equals(str1, str3)}");
            Console.WriteLine($"str2 = str3 -- {String.Equals(str2, str3)}");

            string str4 = string.Concat(str1, " ", str2, "!"); // Concat -- соединение строк
            Console.WriteLine($"Сцепление -- {str4}\n");

            string str5 = string.Copy(str4); // Copy - копирование строки
            string[] str6 = { "Name: Dima", "Surname: Shalunov", "Age: 18" };
            foreach(string str in str6)
            {
                int dot = str.IndexOf(": "); // поиск символа в строке
                Console.WriteLine(str.Substring(dot + 2)); // Substring -- выделение подстроки
            }
            Console.WriteLine();

            string str7 = "My,name is:Dima";
            string[] str8 = str7.Split(new char[] { ' ', ',', ':',}); // Split -- разделение строки на слова ( по заданным разделителям)
            foreach (string str in str8)
                Console.WriteLine(str);
            Console.WriteLine();

            string str9 = "Ination";
            Console.WriteLine($"Before Insert: {str9}");
            Console.WriteLine("After Insert: " + str9.Insert(2, "form") + "\n"); // Insert - вставка строки в указанной позции

            string str10 = "Informmmmmation";
            Console.WriteLine($"Before Remove: {str10}");
            Console.WriteLine("After Remove: " + str10.Remove(5, 4) + "\n"); //Remove(pos, count) - удаление count символов начиная с pos

            string str11 = "", str12 = null;
            Console.WriteLine("\n\tIsNullOrEmpty ");
            Console.WriteLine($"str11 -- {string.IsNullOrEmpty(str11)}");
            Console.WriteLine($"str12 -- {string.IsNullOrEmpty(str12)}\n");
            if(string.IsNullOrEmpty(str11))// прпимер того, где можно применить IsNullOrEmpty
            {
                str11 = "new sentnce";
            }
            else
            {
                str11 = "";
            }

            Console.WriteLine("\tStringBuilder");
            StringBuilder str13 = new StringBuilder("eello WWorl");
            Console.WriteLine(str13);
            str13.Insert(0, 'H'); // Insert(pos, str) - вставка str с позции pos
            Console.WriteLine(str13);
            str13.Remove(1, 1); // Remove(pos, count) - удаление count символов начаная с позции pos
            Console.WriteLine(str13);
            str13.Remove(6, 1);
            Console.WriteLine(str13);
            str13.Insert(10, 'd');
            Console.WriteLine(str13);
            Console.WriteLine();

            //--------------------------------------------- МАССИВЫ ----------------------------------------------------

            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i = 0; i < arr1.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr1.GetLength(1); j++)
                    Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine("\n");

            string[] arr2 = {"This", "is", "Sparta" };
            for (int i = 0; i < arr2.Length; i++)
                if(i != arr2.Length - 1)
                    Console.Write(arr2[i] + " ");
                else
                    Console.Write(arr2[i]);
            Console.WriteLine("\n\nВведите индекс элемента массива для изменения: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите строку: ");
            string NewArr2El = Console.ReadLine();
            arr2[pos] = NewArr2El;
            for (int i = 0; i < arr2.Length; i++)
                if (i != arr2.Length - 1)
                    Console.Write(arr2[i] + " ");
                else
                    Console.Write(arr2[i]);
            Console.WriteLine();

            double[][] arr3 = new double[3][]; // ступенчатый массив 
            arr3[0] = new double[2];
            arr3[1] = new double[3];
            arr3[2] = new double[4];
            Console.WriteLine("\nВведите элементы массива");
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr3[i].Length; j++)
                    arr3[i][j] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr3[i].Length; j++)
                    Console.Write(arr3[i][j] + " ");
            }
            Console.WriteLine("\n");

            /*var arr4 = new object[2]; // если нужна одна переменная, храянщая массив и строку
            arr4[0] = new int[5];
            arr4[1] = "";*/

            var arr4 = new object[2];
            var str14 = "";

            //--------------------------------------------- КОРТЕЖИ(TUPLE) ----------------------------------------------------

            (int num, string Tstr, char l, string Tstr2, ulong num2) Tuple1 = (1, "zda", 'r', "ova", (ulong)2.1);
            Console.WriteLine("\tTouple\nint: {0}\nstring: {1}\nchar: {2}\nstring: {3}\nulong: {4}\n", Tuple1.num, Tuple1.Tstr, Tuple1.l, Tuple1.Tstr2, Tuple1.num2);
            Console.WriteLine("\nint: {0}\nchar: {2}\nstring: {3}\n", Tuple1.num, Tuple1.Tstr, Tuple1.l, Tuple1.Tstr2, Tuple1.num2);

            //РАСПАКОВКА кортежа заключается в присваивании его элементов новым переменным

            (int num, string Tstr, char l, string Tstr2, ulong num2) = Tuple1;
            /*(var numN, var TstrN, var lN, var Tstr2N, var num2N) = Tuple1;*/
            var (numN, TstrN, lN, Tstr2N, num2N) = Tuple1;
            (numN, TstrN, lN, Tstr2N, num2N) = Tuple1;
            Tuple1 = (num: 2, Tstr: "po", l: 'k', Tstr2: "aa", num2: (ulong)1.1);
            (_,_,_,_,_) = Tuple1; // _ - пустая переменная

            (int, int, int) Tuple2 = (1, 2, 3);
            (int, int, int) Tuple3 = (2, 2, 3);
            (int, int, int) Tuple4 = (2, 2, 3);
            (int, int, int) Tuple5 = (1, 2, 3);

            bool Compare(ValueTuple<int, int, int> x, ValueTuple<int, int, int> y)
            {
                if ((x.Item1 == y.Item1 ? x.Item2 - y.Item2 : x.Item1 - y.Item1) == 0)
                    return true;
                else return false;
            }

            Console.WriteLine($"Tuple2: {Tuple2.Item1} {Tuple2.Item2} {Tuple2.Item3}");
            Console.WriteLine($"Tuple3: {Tuple3.Item1} {Tuple3.Item2} {Tuple3.Item3}");
            Console.WriteLine($"Tuple4: {Tuple4.Item1} {Tuple4.Item2} {Tuple4.Item3}");
            Console.WriteLine($"Tuple5: {Tuple5.Item1} {Tuple5.Item2} {Tuple5.Item3}");

            Console.WriteLine($"\nTuple2 == Tuple3 is {Compare(Tuple2, Tuple3)}");
            Console.WriteLine($"Tuple2 == Tuple4 is {Compare(Tuple2, Tuple4)}");
            Console.WriteLine($"Tuple2 == Tuple5 is {Compare(Tuple2, Tuple5)}");
            Console.WriteLine($"Tuple3 == Tuple4 is {Compare(Tuple3, Tuple4)}");
            Console.WriteLine($"Tuple3 == Tuple5 is {Compare(Tuple3, Tuple5)}");
            Console.WriteLine($"Tuple4 == Tuple5 is {Compare(Tuple4, Tuple5)}");
            Console.WriteLine();

            //--------------------------------------------- ЛОКАЛЬНАЯ ФУНКЦИЯ ----------------------------------------------------

            (int, int, int, char) MyFunc (int[] arrf, string strf)
            {
                int min = arrf[0], max = arrf[0], sum = 0;
                for(int i = 0; i < arrf.GetLength(0); i++)
                {
                    if (arrf[i] < min)
                        min = arrf[i];
                    if (arrf[i] > max)
                        max = arrf[i];
                    sum += arrf[i];
                }
                var Tuplef = (min, max, sum, strf[0]);
                return Tuplef;
            }

            //test
            int[] ArrTest = new int[] {1, 3, 5, 7, 9, 2, 4, 6, 8 };
            string StrTest = "BBBBB";
            var TupleTest = MyFunc(ArrTest, StrTest);
            Console.WriteLine($"Min: {TupleTest.Item1}");
            Console.WriteLine($"Max: {TupleTest.Item2}");
            Console.WriteLine($"Sum: {TupleTest.Item3}");
            Console.WriteLine($"First Letter: {TupleTest.Item4}");

            //--------------------------------------------- РАБОТА С CHECKED/UNCHECKED ----------------------------------------------------

            void FuncChecked()
            {
                checked
                {
                    int number1 = Int32.MaxValue;
                    /*int number1 = Int32.MaxValue + 1;*/ // Переполнение при выполнении операции во время компиляции в режиме проверки.

                }
            }

            void FuncUnchecked()
            {
                unchecked
                {
                    int number1 = Int32.MaxValue + 1;
                }
            }

            FuncChecked();
            FuncUnchecked();
        }
    }
}

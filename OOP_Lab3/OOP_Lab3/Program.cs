using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    public partial class Multitude // partial - мы можем иметь несколько файлов с определением одного и того же класса
    {
        public List<int> elems = new List<int>(); // создание списка
        public int sum;
        public int NumOfMinus;
        public int testGetSet;

        // для вы полнения заданий -----------------
        const string MySurname = "Shalunov";
        public static string MyName;
        public static int ObjCount;
        readonly string MulName = "mul"; // при попытке изменить будет оштбка(изменять можно только в конструкторе)
        // --------------------
        
        //свойства get и set
        private List<int> Elems
        {
            get
            {
                return this.elems;
            }
        }

        private string MYSurname
        {
            get
            {
                return MySurname;
            }
        }

        private string MYName
        {
            get
            {
                return MyName;
            }
        }

        private string MUlName
        {
            get
            {
                return this.MulName;
            }
        }

        public int TestGetSet
        {
            set
            {
                if (value < 10)
                    Console.WriteLine("Значение меньше 10");
                else
                    testGetSet = value;
            }
            get
            {
                return testGetSet;
            }
        }


        //переменную, которую вы передаете как параметр out , не нужно инициализировать, но передавая ее как параметр ref , она должна быть установлена
        public void Add(params int[] el) // добавление элемента(params - нефиксированное количество параметров)
        {
            for(int i = 0; i < el.Length; i++)
            {
                this.elems.Add(el[i]);
                sum += el[i];
                if (el[i] < 0)
                    NumOfMinus++;
            }
        }

        public void Remove(ref int el) // удаление элемента(по значению) + параметр передается по ссылке(ref)
        {
            this.elems.Remove(el);
        }

        public void Size(out int count) // out - говорит о том, что параметр является выходным
        {
            count = this.elems.Count;
        }

        public static void Out()
        {
            Console.WriteLine("\nНазвание класса: Multitude");
            Console.WriteLine($"Количество созданных объектов: {ObjCount}");
        }

        //конструкторы        (приватный сделан для отдельного класса)

        //Если не определить конструктор в классе, язык C# автоматически создаст конструктор по умолчанию. 
        //Этот конструктор инициализирует все переменные экземпляра класса их значениями по умолчанию.

        public Multitude(List<int> elements, string MyN, string MulN) // с параметрами
        {
            this.elems = elements;
            MyName = MyN;
            this.MulName = MulN; // изменение readonly-переменной в 1-м конструкторе
            ObjCount++;
        }

        public Multitude(List<int> elements = null, string MulN = "") // по умолчанию
        {
            this.elems = elements;
            this.MulName = MulN; // изменение readonly-переменной в 1-м конструкторе
            ObjCount++;
        }

        public Multitude() // без параметров
        {
            elems = new List<int> ();
            MulName = "конструктор";    
            MyName = "Unnamed"; // изменение readonly-переменной во 2-м конструкторе
            ObjCount++;
        }

        static Multitude() // статический
        {
            //Статический конструктор не принимает модификаторы доступа (public, protected, private) и не имеет параметров.
            //Статический конструктор вызывается автоматически для инициализации класса перед созданием первого объекта класса или ссылкой на какие-либо статические члены
            MyName = "unnamed";
            ObjCount++;
        }

        //Частные конструкторы используются для предотвращения создания экземпляров класса, когда нет полей
        //или методов экземпляра или когда метод вызывается для получения экземпляра класса.

        /*private Multitude() { } // -- конфликтует с двумя предыдущими конструкторами(без параметров)  
*/
    }

    class NumPI
    {
        private NumPI() { } // приватный конструктор, т.е. не допускающий создание объектов данного класса
        public static double PI = Math.PI;
    }

    partial class Multitude
    {
        public new bool Equals(Multitude mul1, Multitude mul2) 
            // Модификатор new указывает компилятору использовать реализацию дочернего класса вместо реализации родительского класса.
        {
            List<int> list1 = mul1.elems;
            List<int> list2 = mul2.elems;
            return list1.GetHashCode() == list2.GetHashCode();
        }

        public override int GetHashCode() // переопределение метода в классе-наследнике
        {
            return this.GetHashCode();
        }

        public override string ToString() // 
        {
            string str = "------------------ Информация об объекте ------------------\n\nЭлементы множества: ";
            foreach(int el in this.elems)
            {
                str += el + " ";
            }
            str += $"\nСумма элементов множества: {this.sum} \n Количество отрицательных элементов: {this.NumOfMinus} \n";
            return str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //вар15

            //конструкторы
            List<int> list = new List<int>();
            Multitude mul1 = new Multitude(); // вызов конструктора без параметров
            Multitude mul2 = new Multitude(list, "Dima", "Mul"); // вызов конструктора с параметрами
            Multitude mul3; // вызов конструктора с параметрамипо умолчанию

            //свойства
            mul1.TestGetSet = 5;
            mul1.TestGetSet = 12;
            Console.WriteLine($"GetSet: {mul1.testGetSet}"); // выведет 10, т.к. в set указано установить значение testGetSet=10

            //методы(+3 задание)
            int nMax = 0, nMin = 0;
            Multitude[] MyList = new Multitude[4];
            for (int i = 0; i < 4; i++)
                MyList[i] = new Multitude(); ;

            MyList[0].Add(1, 2, 3, 4, 5);
            MyList[1].Add(-1, 3, 5, 7, 9);
            MyList[2].Add(11, 2, -3, -4, -5);
            MyList[3].Add(0, 2, 0, 4, 0);
            int pos = 3; // исключительно для ref
            MyList[3].Remove(ref pos);

            int size1 = 0;
            MyList[0].Size(out size1);
            Console.WriteLine($"\nРазмер множества 1 : {size1}");

            Multitude.Out(); // вывод инф-ции об объекте

            Console.WriteLine($"\nМножество 1 = Множеству 2 -- {MyList[0].Equals(MyList[1])}"); // сравнение множеств
            bool isMul = MyList[0] is Multitude;
            Console.WriteLine($"\nMyList[0] is Multitude -- {isMul}");

            int max = MyList[0].sum, min = MyList[0].sum;
            for (int i = 0; i < MyList.Length; i++)
            {
                if (MyList[i].sum > max)
                {
                    max = MyList[i].sum;
                    nMax = i;
                }
                if (MyList[i].sum < min)
                {
                    min = MyList[i].sum;
                    nMin = i;
                }
            }

            Console.Write("\nМножество с наибольшей суммой: ");
            foreach (int el in MyList[nMax].elems)
                Console.Write(el + " ");

            Console.Write("\nМножество с наименьшей суммой: ");
            foreach (int el in MyList[nMin].elems)
                Console.Write(el + " ");

            Console.WriteLine("\nСписок множеств с отрицательными членами:");
            for (int i = 0; i < MyList.Length; i++)
            {
                if (MyList[i].NumOfMinus > 0)
                {
                    foreach (int el in MyList[i].elems)
                        Console.Write(el + " ");
                    Console.WriteLine();
                }
            }

            var Anon = new { list = new List<int>() { 1, 2, 3 }, MulName = "Mul", MyName = "Dmitriy"};
            Console.WriteLine($"\n--------- AnonymousYype ---------\n Множество: {Anon.list[0]} {Anon.list[1]} {Anon.list[2]}\n Имя конструктора: {Anon.MulName}\n Мое имя: {Anon.MyName}");
        }
    }
}

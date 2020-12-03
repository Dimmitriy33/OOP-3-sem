using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace OOP_Lab10
{
    public static class ArrayListExtension
    {
        public static void DisplayContains(this ArrayList arraylist, int num)
        {
            if (arraylist.Contains(num))
                Console.WriteLine($"Element {num} is a part of arraylist");
            else
                Console.WriteLine($"Element {num} is not a part of arraylist");
        }
    }
    class Program
    {
        delegate bool Check(int par);
        static void DisplayCollection(HashSet<int> collection)
        {
            Console.Write("{");
            foreach (int i in collection)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }

        public static void onChangeCollection(object Sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        Console.WriteLine($"Object {Sender.GetType().Name} caused event because of adding");
                        break;
                    }
                case NotifyCollectionChangedAction.Remove:
                    {
                        Console.WriteLine($"Object {Sender.GetType().Name} caused event because of removing");
                        break;
                    }
            }
        }

            private static bool Is3or5(int num) => (num == 3) || (num == 5);
        static void Main(string[] args)
        {
            //1
            HashSet<Plant> items = new HashSet<Plant>();
            Plant rose = new Plant("rose", 80.2);
            Plant sunflower = new Plant("sunflower", 120.3);
            items.Add(rose);
            items.Add(sunflower);
            items.Add(new Plant("dandelion", 15.6));
            items.Remove(rose);
            items.Contains(rose);
            items.Contains(sunflower);
            foreach (Plant item in items)
                Console.WriteLine($"{item.Type}, {item.Length} centimetres");
            Console.WriteLine();

            //2
            HashSet<int> items2 = new HashSet<int>();
            for (int i = 1; i < 5; i++)
                items2.Add(i);
            DisplayCollection(items2);

            Console.Write("Items to Remove = ");
            int iteration = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < iteration; i++)
            {
                items2.Remove(items2.ElementAt(0));
            }
            DisplayCollection(items2);
            Console.WriteLine();

            HashSet<int> items3 = new HashSet<int>() {1,2,3,4,5};
            items2.UnionWith(items3);
            // других методов добавления нет

            ArrayList arraylist = new ArrayList();
            foreach(int num in items2)
                arraylist.Add(num);
            Console.Write("{");
            foreach(int el in arraylist)
                Console.Write(el + " ");
            Console.WriteLine("}");

            //решил вспомнить реализацию методов расширения
            arraylist.DisplayContains(2);
            arraylist.DisplayContains(6);

            ObservableCollection<HashSet<int>> observable = new ObservableCollection<HashSet<int>>
            {
                    
            };
            Console.WriteLine();
            observable.CollectionChanged += onChangeCollection;
            observable.Add(items2);
            observable.Add(items3);
            observable.Remove(items2);


        }



    }
}

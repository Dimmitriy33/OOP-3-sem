using System;

namespace OOP_Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionType<int> variable1 = new CollectionType<int>();
            CollectionType<double> variable2 = new CollectionType<double>();
            variable1.Add(10);
            variable1.Add(20);
            variable1.Add(30);
            variable1.Remove(20);
            variable1.Show();
            Console.WriteLine();

            variable2.Add(10.5);
            variable2.Add(20.2);
            variable2.Add(30.1);
            variable2.Remove(20.2);
            variable2.Show();
            Console.WriteLine();

            Vector<Example> variable3 = new Vector<Example>();
            variable3.Add(new Example("Pupa", "Lupov"));
            variable3.Add(new Example("Lupa", "Pupov"));
            variable3.Add(new Example("NePupa", "NeLupov"));
            variable3.Show();
            Console.WriteLine();

            ClassWriter<Example>.WriteData(variable3);
            Vector<Example> DataFromFile = ClassWriter<Example>.ReadData(variable3.Path);

            


        }
    }
}

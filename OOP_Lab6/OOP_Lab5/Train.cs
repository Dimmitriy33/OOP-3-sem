using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab6
{
    public sealed class Train : Abstract, Interface1
    {
        const int DefaultNumberOfCarriage = 6;
        public int NumberOfCarriage;
        public Train()
        {
            MaxSpeed = 200;
            MinSpeed = 10;
            this.NumberOfCarriage = DefaultNumberOfCarriage;
        }
        public Train(int NumberOfCarriage)
        {
            MaxSpeed = 200;
            MinSpeed = 10;
            this.NumberOfCarriage = NumberOfCarriage;
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"MaxSpeed: {MaxSpeed}");
            Console.WriteLine($"MinSpeed: {MinSpeed}");
            Console.WriteLine($"Price: {this.NumberOfCarriage}");
        }

        public override void ShowClass()
        {
            Console.WriteLine("Train");
        }

        public override string WriteType()
        {
            return "Train obj";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab5
{
    sealed class Car : Abstract, Interface1
    {
        const int DefaultPrice = 100;
        public int price;
        public Car()
        {
            MaxSpeed = 150;
            MinSpeed = 20;
            this.price = DefaultPrice;
        }
        public Car(int price)
        {
            MaxSpeed = 150;
            MinSpeed = 20;
            this.price = price;
        }

        public override void ShowInformation() 
        {
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"MaxSpeed: {MaxSpeed}");
            Console.WriteLine($"MinSpeed: {MinSpeed}");
            Console.WriteLine($"Price: {this.price}");
        }

        public override void ShowClass()
        {
            Console.WriteLine("Car");
        }

        public override string WriteType()
        {
            return "Car obj";
        }
    }
}

using System;

namespace OOP_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat("Pobeda", 12);
            Corvette corvette = new Corvette("Beda", 10);
            Sailboat sailboat = new Sailboat("Ne Beda", 5);
            Ship ship = new Ship("Bedi s bashkoi", 18);
            Streamer streamer = new Streamer("Po obedal", 4);
            Car car = new Car();
            Train train = new Train();
            Test test = new Test();

            //задание 4

            Console.WriteLine($"car type - {car.WriteType()}\n");
            car.ShowInformation();

            Console.WriteLine($"\ntrain type - {train.WriteType()}\n");
            train.ShowInformation();

            // задание 5

            if (boat is Car) { Console.WriteLine("\nboat is car"); }
            else { Console.WriteLine("\nboat is not car"); };

            if (car is Car) { Console.WriteLine("car is car\n"); }
            else { Console.WriteLine("car is not car\n"); };

            //ссылка на интерфейс
            Interface1 Itest;
            Itest = test as Test;

            TransportEl[] arr = { boat, corvette, ship, sailboat, streamer};
            Printer printer = new Printer();
            foreach (object obj in arr)
            {
                printer.IAmPrinting(obj);
            }
        }
    }
}

using System;

namespace OOP_Lab6
{
    class Program
    {
        public struct OutEx4
        {
            public void showInform()
            {
                Car car = new Car();
                Train train = new Train();
                Console.WriteLine($"car type - {car.WriteType()}\n");
                car.ShowInformation();

                Console.WriteLine($"\ntrain type - {train.WriteType()}\n");
                train.ShowInformation();
            }
        }
        static void Main(string[] args)
        {

            Boat boat = new Boat("Pobeda", 12);
            Corvette corvette = new Corvette("Beda", 10);
            Sailboat sailboat = new Sailboat("Ne Beda", 5, 30);
            Sailboat sailboat2 = new Sailboat("Ne LeBeda", 5, 60);
            Sailboat sailboat3 = new Sailboat("LeBeda", 5, 90);
            Ship ship = new Ship("Bedi s bashkoi", 18);
            Streamer streamer = new Streamer("Po obedal", 4, 20);
            Streamer streamer2 = new Streamer("Po obedal", 4, 40);
            Test test = new Test();
            Car car = new Car();
            Train train = new Train();

            //задание 4

            OutEx4 outex4;
            outex4.showInform();

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

            //lab6

            Console.WriteLine($"Average displacement on silboats -- {Control.AverageDisplacementOnSailboats()}");

            Console.WriteLine($"Average seats number on streamers -- {Control.AverageSeats()}");

            boat.captain.age = 12;
            ship.captain.age = 27;
            corvette.captain.age = 44;
            sailboat.captain.age = 19;
            streamer.captain.age = 77;
            Port port = new Port();
            port.Add(boat);
            port.Add(ship);
            port.Add(corvette);
            port.Add(sailboat);
            port.Add(streamer);
            port.Add(streamer2);
            port.Remove(streamer2);

            Control control;
            Console.WriteLine($"Number of captains with age less then 35 -- {Control.CountOfLess35Captain(port)}");

        }
    }
}

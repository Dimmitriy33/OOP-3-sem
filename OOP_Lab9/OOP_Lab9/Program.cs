using System;

namespace OOP_Lab9
{
    class Program
    {
        private static void DisplayMessage(string str) => Console.WriteLine(str);

        static void Main(string[] args)
        {
            User user1 = new User(10, 5);
            User user2 = new User(20, 10);
            User user3 = new User(8, 3);
            user1.MoveElement += DisplayMessage;
            user2.SqueezeElement += DisplayMessage;
            user3.MoveElement += DisplayMessage;
            user3.SqueezeElement += DisplayMessage;

            user1.Move(3);
            user1.Squeeze(0.2);
            Console.WriteLine();

            user2.Move(5);
            user2.Squeeze(0.25);
            Console.WriteLine();

            user3.Move(1);
            user3.Squeeze(0.7);
            Console.WriteLine();

            //2 

            string str = "This string contains commas,, HUGE LETTERS and some space for word... ";
            Action<string> change;
            // в action нельзя задать параметр по ссылке
            
            change = StrTreatment.NoCommas;
            change += StrTreatment.ToLower;
            change += StrTreatment.AddHello;
            StrTreatment.Show(change, ref str);
            Console.WriteLine();

            Func<string, string> change2;
            // в func также нельзя задать параметр по ссылке

            change2 = StrTreatment.NoCommas2;
            str = change2(str);
            change2 = StrTreatment.ToLower2;
            str = change2(str);
            change2 += StrTreatment.AddHello2;
            StrTreatment.Show2(change2, ref str);

        }
    }
}

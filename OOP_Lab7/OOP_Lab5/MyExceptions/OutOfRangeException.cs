using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab7.MyExceptions
{
    class OutOfRangeExceptions : Exception
    {
        private string message, source;
        private int minValue = 18, maxValue = 100;

        public OutOfRangeExceptions(int age)
        {
            if (age < minValue)
                message = "Captain age must be more than 18";
            if (age > maxValue)
                message = "Captain age must be less than 100";
        }

        public OutOfRangeExceptions(int age, object obj)
        {
            if (age < minValue)
            {
                source = obj.GetType().Name.ToString();
                message = "Captain age must be more than 18";
                Console.WriteLine(message);
                Console.WriteLine($"Source: {source}\n");
            }
            if (age > maxValue)
            {
                message = "Captain age must be less than 100";
                source = obj.GetType().Name.ToString();
                Console.WriteLine(message);
                Console.WriteLine($"Source: {source}\n");
            }
        }

        public string getMessage => message;
        public int getMinValue => minValue;
        public int getMaxValue => maxValue;
        public string getSource => source;
    }
}

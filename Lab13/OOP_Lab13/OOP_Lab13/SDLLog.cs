using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Lab13
{
    public static class SDLLog
    {
        private static string path = @"D:\учеба\ООП\lab13\OOP_Lab13\OOP_Lab13\bin\Debug\SDLlogfile.txt";
        public static StreamWriter file = new StreamWriter(path);
        public static string GetPath
        {
            get => path;
        }

        public static string SetPath
        {
            set => path = value;
        }

        public static StreamWriter OpenFile() => file;
        public static void CloseFile()
        {
            if (file != null)
                file.Close();
        }

        public static void SDLWrite()
        {
            string[] str = new string[69];
            int num = 0;
            StreamReader file = new StreamReader(@"D:\учеба\ООП\lab13\OOP_Lab13\OOP_Lab13\bin\Debug\SDLlogfile.txt");
            for (int i = 0; i < 69; i++)
            {
                if (Equals(file.ReadLine(), "@"))
                {
                    num++;
                }
            }
            for (int i = 1; i < 69; i++)
            {
                file.ReadLine();
                if (file.ReadLine().Contains("Path"))
                {
                    while (!Equals(file.ReadLine(), "@"))
                    {
                        i--;
                    }
                    while (Equals(file.ReadLine(), "@"))
                    {
                        Console.WriteLine(file.ReadLine());
                        i++;
                    }

                }
            }
            file.Close();
            Console.WriteLine(num);
        }

    }
}

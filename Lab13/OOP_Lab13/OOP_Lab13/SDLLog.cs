﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Lab13
{
    public static class SDLLog
    {
        private static string path = @"D:\\учеба\\ООП\\lab13\\SDLlogfile.txt";
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
            int num = 0;
            StreamReader file = new StreamReader(@"D:\учеба\ООП\lab13\SDLlogfile.txt");
            for (int i = 0; i < 100; i++)
            {
                if (Equals(file.ReadLine(), "@"))
                {
                    num++;
                }
            }
            for (int i = 1; i < 100; i++)
            {
                if(file.ReadLine() != null)
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
            Console.WriteLine();
            Console.WriteLine("Количество записей: " + num);
        }

        public static void SDLDeletePartOfFile(int line)
        {
            StreamReader file = new StreamReader(@"D:\учеба\ООП\lab13\SDLlogfile.txt");
            StreamWriter tempfile = new StreamWriter(@"D:\учеба\ООП\lab13\SDLlogfileTemp.txt");

            for (int i = 0; i < line; i++)
            {
                tempfile.WriteLine(file.ReadLine());
            }
            file.Close();
            tempfile.Close();
            File.Delete("D:\\учеба\\ООП\\lab13\\SDLlogfile.txt");
            File.Move("D:\\учеба\\ООП\\lab13\\SDLlogfileTemp.txt", "D:\\учеба\\ООП\\lab13\\SDLlogfile.txt");

            Console.WriteLine();
            Console.WriteLine($"SDLlogfile.txt частично очищен");
        }


    }
}

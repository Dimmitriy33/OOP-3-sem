using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace OOP_Lab13
{
    public static class SDLFileManager
    {
        public static void WriteInFile()
        {
            string[] NumOfFiles = new string[50];
            string[] NumOfDir = new string[50];
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            Directory.CreateDirectory(@"D:\учеба\ООП\lab13\SDLInspect");
            StreamWriter dirfile = new StreamWriter(@"D:\учеба\ООП\lab13\SDLInspect\SDLdirinfo.txt", true);
            dirfile.WriteLine("-----------Files-----------:");
            foreach (var x in dir.GetFiles())
            {
                dirfile.WriteLine($"{x}");
            }
            dirfile.WriteLine("\n-----------Directories-----------");
            foreach (var y in dir.GetDirectories())
            {
                dirfile.WriteLine($"{y}");
            }
            dirfile.Close();
            Console.WriteLine("File SDLdirinfo.txt is created");
            SDLLog.OpenFile();

            SDLLog.OpenFile().WriteLine($"{DateTime.Now}\nCreating SDLdirinfo.txt\nPath: {dir.FullName}\n@");
        }

        public static void CopyAndRenameFile()
        {
            File.Copy(@"D:\учеба\ООП\lab13\SDLInspect\SDLdirinfo.txt", @"D:\учеба\ООП\lab13\SDLInspect\SDLdirinfoNew.txt");
            Console.WriteLine("File SDLdirinfo.txt is copied and renamed");

            SDLLog.OpenFile().WriteLine($"{DateTime.Now}\nCopying and renaming SDLdirinfo.txt\nPath: D:\\учеба\\ООП\\lab13\\SDLInspect\\SDLdirinfo.txt@");
        }

        public static void DeleteOldFile()
        {
            File.Delete(@"D:\учеба\ООП\lab13\SDLInspect\SDLdirinfo.txt");
            Console.WriteLine("File SDLdirinfo.txt is deleted");
            Console.WriteLine();

            SDLLog.OpenFile().WriteLine($"{DateTime.Now}\nDeleting old SDLdirinfo.txt\nPath: D:\\учеба\\ООП\\lab13\\SDLInspect\\SDLdirinfo.txt@");
        }

        public static void NewDir()
        {
            Directory.CreateDirectory(@"D:\учеба\ООП\lab13\SDLFiles");
            DirectoryInfo dir = new DirectoryInfo(@"D:\учеба\ООП\lab13\OOP_Lab13");
            foreach (var x in dir.GetFiles())
            {
                if (Equals(x.Extension, ".sln"))
                {
                    File.Copy(@"D:\учеба\ООП\lab13\OOP_Lab13\" + x.Name, @"D:\учеба\ООП\lab13\SDLFiles\" + x.Name);
                }
            }
            Console.WriteLine("New directory SDLFiles is created");

            SDLLog.OpenFile().WriteLine($"{DateTime.Now}\nCreating directory SDLFiles\nPath: {dir.FullName}\n@");
        }

        public static void MoveNewDir()
        {
            Directory.Move(@"D:\учеба\ООП\lab13\SDLFiles", @"D:\учеба\ООП\lab13\SDLInspect\SDLFilesNEW");
            Console.WriteLine("New directory SDLFiles is moved");

            SDLLog.OpenFile().WriteLine($"{DateTime.Now}\nMoving directory SDLFiles\nPath: D:\\учеба\\ООП\\lab13\\SDLInspect\\SDLFiles");
        }

        public static void Zip()
        {
            ZipFile.CreateFromDirectory(@"D:\учеба\ООП\lab13\SDLInspect\SDLFiles", @"D:\учеба\ООП\lab13\SDLInspect\Archive.rar");
            Console.WriteLine("Zip Archive.rar is created");

            SDLLog.OpenFile().WriteLine($"{DateTime.Now}\nCreating Zip Archive.rar\nPath: D:\\учеба\\ООП\\lab13\\SDLInspect\\SDLFiles\n@");
        }
        public static void Unzip()
        {
            ZipFile.ExtractToDirectory(@"D:\учеба\ООП\lab13\SDLInspect\Archive.rar", @"D:\учеба\ООП\lab13");
            Console.WriteLine("Unzipping is successful");

            SDLLog.OpenFile().WriteLine($"{DateTime.Now}\nUnzipping Archive.rar\nPath:  D:\\учеба\\ООП\\lab13\\SDLInspect\n@");
        }

        public static void PrintFileManager()
        {
            WriteInFile();
            CopyAndRenameFile();
            DeleteOldFile();
            NewDir();
            MoveNewDir();
            Zip();
            Unzip();
        }
    }
}

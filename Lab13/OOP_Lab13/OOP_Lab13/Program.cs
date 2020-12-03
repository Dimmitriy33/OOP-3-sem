using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //очистка возможно созданных прежде файлов и директориев
                Directory.Delete(@"D:\учеба\ООП\lab13\SDLInspect", true);
                File.Delete(@"D:\учеба\ООП\lab13\OOP_Lab13.sln");
                File.Delete(@"D:\учеба\ООП\lab13\SDLlogfile.txt");
            }
            catch 
            { }

            SDLDiskInfo.PrintDiskInfo();
            SDLFileInfo.PrintFileInfo(@"D:\учеба\ООП\lab1\New.txt");
            SDLDirInfo.PrintDirInfo(new DirectoryInfo(@"D:\учеба\ООП"));
            SDLFileManager.PrintFileManager();
            SDLLog.CloseFile();

            //для 6(шестого) задания
            SDLLog.SDLWrite();
            SDLLog.SDLDeletePartOfFile(20);
        }
    }
}

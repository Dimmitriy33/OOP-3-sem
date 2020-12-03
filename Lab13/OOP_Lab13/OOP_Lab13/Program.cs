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
            SDLDiskInfo.PrintDiskInfo();
            SDLFileInfo.PrintFileInfo(@"D:\учеба\ООП\lab1\New.txt");
            SDLDirInfo.PrintDirInfo(new DirectoryInfo(@"D:\учеба\ООП"));
            SDLFileManager.PrintFileManager();
            SDLLog.CloseFile();
            SDLLog.SDLWrite();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace OOP_Lab12
{
    public static class Reflector
    {
        private static string path = "MyFile.txt";
        public static StreamWriter file = null;
        public static string GetPath
        {
            get => path;
        }

        public static string SetPath
        {
            set => path = value;
        }

        private static void OpenFile()
        {
            if (path != null)
                file = new StreamWriter(path, true);
        }
        public static void CloseFile()
        {
            if (file != null)
                file.Close();
        }

        public static void AssemblyName(string AssemblyName = @"OOP_Lab12.exe")
        {
            OpenFile();
            Assembly assembly = Assembly.LoadFrom(AssemblyName);

            file.WriteLine($"Assembly: {AssemblyName}");
            file.WriteLine();
            CloseFile();
        }

        public static void PublicConstructors(string ClassName)
        {
            bool AnyPublic = false;
            OpenFile();

            foreach (var item in Type.GetType(ClassName).GetConstructors())
            {
                if (item.IsPublic)
                    AnyPublic = true;
            }

            file.WriteLine($"Class name: {ClassName} - have public constructor: {AnyPublic}");
            file.WriteLine();
            CloseFile();
        }

        public static void PublicMethods(string ClassName)
        {
            OpenFile();

            file.WriteLine($"{ClassName} public methods: ");
            foreach (var item in Type.GetType(ClassName).GetMethods())
            {
                file.WriteLine(item.Name);
            }
            file.WriteLine();
            CloseFile();
        }

        public static void FieldAndProps(string ClassName)
        {
            OpenFile();

            file.WriteLine($"Fields of class: {ClassName}");

            foreach (var item in Type.GetType(ClassName).GetFields())
                file.WriteLine($"Fields: {item.Name}");

            file.WriteLine($"Properties of class: {ClassName}");
            foreach (var item in Type.GetType(ClassName).GetProperties())
                file.WriteLine($"Properties: {item.Name}");

            file.WriteLine();
            CloseFile();
        }

        public static void ImplementedInterfaces(string ClassName)
        {
            OpenFile();

            file.WriteLine($"{ClassName} Implemented interfaces: ");
            foreach (var item in Type.GetType(ClassName).GetInterfaces())
            {
                file.WriteLine(item.Name);
            }

            file.WriteLine();
            CloseFile();
        }

        public static void MethodsWithPar(string ClassName)
        {
            OpenFile();

            Console.WriteLine("Enter a Method Parameter: ");
            string parm = Console.ReadLine();
            file.WriteLine($"Methods with parm: {parm} in class: {ClassName}");

            foreach (var item in Type.GetType(ClassName).GetMethods())
                foreach (var itemParm in item.GetParameters())
                    if (parm == itemParm.ParameterType.Name)
                        file.WriteLine($"Method: {itemParm.Name}");

            file.WriteLine();
            CloseFile();
        }

        public static void Invoke(string ClassName, string MethodName, string ArgPath)
        {
            Console.WriteLine($"Try to call method:{MethodName} in class: {ClassName}");

            var CurMethod = Type.GetType(ClassName).GetMethod(MethodName);

            if (CurMethod == null)
                Console.WriteLine("Didn't find method...");
            else
            {
                StreamReader streamReader = new StreamReader(ArgPath);

                object obj = Activator.CreateInstance(Type.GetType(ClassName));
                string parm;
                while ((parm = streamReader.ReadLine()) != null)
                {
                    if (CurMethod.GetParameters().Length != 0)
                        CurMethod.Invoke(obj, parm.Split(' '));
                    else
                        CurMethod.Invoke(obj, new object[] { });
                }

            }

        }

        public static object CreateType(string className)
        {

            return Activator.CreateInstance(Type.GetType(className));
        }
    }
}

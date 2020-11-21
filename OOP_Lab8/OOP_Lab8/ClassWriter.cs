
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace OOP_Lab8
{
    //класс отвечающий за запись и чтение объектов 
    public static class ClassWriter<T> where T : class
    {
        private static BinaryFormatter formatter;


        static ClassWriter()
        {
            formatter = new BinaryFormatter();
        }

        public static void WriteData(Vector<T> obj)
        {
            using (FileStream fs = new FileStream(obj.Path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }

        public static Vector<T> ReadData(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Vector<T> disValue = (Vector<T>)formatter.Deserialize(fs);
                return disValue;
            }
        }
    }
}

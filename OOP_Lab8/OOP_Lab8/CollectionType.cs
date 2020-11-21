using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab8
{
    public class CollectionType<T> : Ioperation<T> where T : struct
    {
        List<T> list = new List<T>();
        public void Add(T el)
        {
            bool flag = false;
            try
            {
                list.Add(el);
            }
            catch
            {
                Console.WriteLine("Ошибка добавления элемента");
                flag = true;
            }
            finally
            {
                if (flag == false)
                    Console.WriteLine("Элемент упешно добавлен");
            }
        }

        public void Remove(T el)
        {
            bool flag = false;
            try
            {
                list.Remove(el);

            }
            catch
            {
                Console.WriteLine("Ошибка удаления элемента");
                flag = true;
            }
            finally
            {
                if (flag == false)
                    Console.WriteLine("Элемент упешно удален");
            }
        }

        public void Show()
        {
            foreach (T elem in list)
                Console.WriteLine(elem + " ");
        }
    }
}

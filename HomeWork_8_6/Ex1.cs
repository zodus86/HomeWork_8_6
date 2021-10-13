using System;
using System.Collections.Generic;

namespace HomeWork_8_6
{
    /// <summary>
    /// Задание 1.Работа с листом
    /// </summary>
    class Ex1 
    {
        /// <summary>
        ///  Заполните лист 100 случайными числами в диапазоне от 0 до 100.
        /// </summary>
        /// <returns></returns>
        public static List<int> CreatRandomList()
        {
            List<int> list = new List<int>();
            Random random = new Random();
            
            for( int i = 0; i <100; i++)
            {
                list.Add(random.Next(0,100));
            }
            return list;
        }

        /// <summary>
        /// Выведите коллекцию чисел на экран.
        /// </summary>
        /// <param name="list"></param>
        public static void PrintList(List<int> list)
        {
            Console.WriteLine($"\nКоллекция содержит в себе - {list.Count} элементов.");
            foreach (int i in list)
                Console.Write($"{i}, ");
        }

        /// <summary>
        /// Удалите из листа числа, которые больше 25, но меньше 50.
        /// </summary>
        /// <param name="list"></param>
        public static void Delete25_50(List<int > list)
        {
            for(int i = 0; i<list.Count; i++)
            {
                if (list[i] > 25 && list[i] < 50)
                    list.RemoveAt(i);
            }
        }
    }
}

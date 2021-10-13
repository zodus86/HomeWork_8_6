using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8_6
{
    /// <summary>
    /// Задание 3
    /// </summary>
    class Ex3
    {

        private static HashSet<int> heshSet = new HashSet<int>();

        /// <summary>
        /// Проверка повторов
        /// </summary>
        public static void EnterIntDontRepit()
        {
            int temp;
            try
            {
            while (true)
            {
                Console.WriteLine("введите число");
                temp = int.Parse(Console.ReadLine());

                if (heshSet.Contains(temp))
                {
                    Console.WriteLine($"Число {temp} есть в баззе");
                    break;
                }
                else
                    heshSet.Add(temp);
            }
            }catch(Exception ex)
            {               
                Console.WriteLine(ex);
            }

        }
    }
}

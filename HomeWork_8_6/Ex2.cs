using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8_6
{
   /// <summary>
   /// задание 2
   /// </summary>
    class Ex2
    {

        public static Dictionary<Decimal, String> telephonBook = new Dictionary<decimal, string>();

        /// <summary>
        /// Пользователю итеративно предлагается вводить в программу номера телефонов и ФИО их владельцев.
        /// </summary>
        public static void AddTelephonNumberInBook()
        {

            String line;
            Decimal tel; 
            while (true)
            {
                Console.WriteLine("\nВведите телефон только цифры");
                line = Console.ReadLine();

                if (String.IsNullOrEmpty(line))
                {
                    break;
                }

                tel = Decimal.Parse(line);

                Console.WriteLine($"Введите ФИО владельца телефона {tel}");
                line = Console.ReadLine();
                
                if (String.IsNullOrEmpty(line)) //вроде копипаст, но нового метода не стоит
                {
                    break;
                }
                telephonBook.Add(tel, line);
                Console.WriteLine("успешно добавлена запись в телефонную книгу");
            }

        }

        /// <summary>
        /// Пользователь вводит номер телефона и ему выдаётся ФИО владельца.
        /// </summary>
        /// <param name="telephon"></param>
        public static void FindPeopeleAtTelephon()
        {
            Decimal telephon;
            Console.WriteLine("Пользователь вводит номер телефона и ему выдаётся ФИО владельца. Телефон только цифры");
            String temp = Console.ReadLine();

            try
            {
                telephon = Decimal.Parse(temp);
                Console.WriteLine(telephonBook[telephon]);

            }catch (Exception e)
            {
                Console.WriteLine($"телефон {temp} не зарегистрирован в Телефоном справочнике или введен не верно");
                Console.WriteLine(e);
            }
            
        }

    }
}

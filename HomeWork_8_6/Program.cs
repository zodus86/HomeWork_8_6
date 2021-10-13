using System;
using System.Collections;
using System.Collections.Generic;
using static HomeWork_8_6.Ex1;
using static HomeWork_8_6.Ex2;
using static HomeWork_8_6.Ex3;
using static HomeWork_8_6.Ex4;

namespace HomeWork_8_6
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1.");

            List<int> list = CreatRandomList();
            PrintList(list);
            Delete25_50(list);
            PrintList(list);
            Console.ReadKey();

            Console.WriteLine("\nЗадание 2.");
            AddTelephonNumberInBook();
            FindPeopeleAtTelephon();
            Console.ReadKey();

            Console.WriteLine("\nЗадание 3.");
            EnterIntDontRepit();
            Console.ReadKey();

            Console.WriteLine("\nЗадание 4.");
            CrateXmlNoteBook();
            SerializePerson("D:\\temp\\Persona.XML");
        }
    }
}

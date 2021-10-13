using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork_8_6
{
    /// <summary>
    /// Задание 4 Записная книжка
    /// </summary>
    class Ex4
    {
        public static Person person = new Person();

        public static void CrateXmlNoteBook()
        {            
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();
            
            Console.WriteLine("Введите Улицу");
            string Street = Console.ReadLine();

            Console.WriteLine("Введите Номер дома");
            string HouseNumber = Console.ReadLine();

            Console.WriteLine("Введите Номер квартиры");
            string FlatNumber = Console.ReadLine();

            Console.WriteLine("Введите Мобильный телефон");
            string MobilPhone = Console.ReadLine();

            Console.WriteLine("Введите Домашний телефон");
            string FlatPhone = Console.ReadLine();
            
            Address address = new Address(Street, HouseNumber, FlatNumber);
            Phones phones = new Phones(MobilPhone, FlatPhone);
            person = new Person(name, address, phones);
           
        }

        public static void SerializePerson(string Path)
        {
   
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fStream, person);
            fStream.Close();
        }


    }

    public struct Person
    {
        public string name;
        public Address address;
        public Phones phones;

        public Person(string name, Address address, Phones phones)
        {
            this.name = name;
            this.address = address;
            this.phones = phones;
        }

    }

    public struct Address
    {
        public string Street;
        public string HouseNumber;
        public string FlatNumber;

        public Address(string street, string houseNumber, string flatNumber)
        {
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
        }

    }

    public struct Phones
    {
        public string MobilePhone;
        public string FlatPhone;

        public Phones(string mobilePhone, string flatPhone)
        {
            MobilePhone = mobilePhone;
            FlatPhone = flatPhone;
        }
    }

}

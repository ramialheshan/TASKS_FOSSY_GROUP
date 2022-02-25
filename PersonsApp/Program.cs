using PersonsApp.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PersonsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "settings.xml");

            var persons = XML.Load<PersonsSettings>(file);

            if (persons == null)
            {
                persons = new PersonsSettings();
                persons.AddPerson(new FixedPaymentPerson() { FixedPayment = 15000, Name = "Ананасов" });
                persons.AddPerson(new FixedPaymentPerson() { FixedPayment = 15000, Name = "Сидоров" });
                persons.AddPerson(new FixedPaymentPerson() { FixedPayment = 12000, Name = "Гоголев" });

                persons.AddPerson(new HourlyPaymentPerson() { HourlyPayment = 50, Name = "Иванов" });
                persons.AddPerson(new HourlyPaymentPerson() { HourlyPayment = 100, Name = "Давыдов" });
                persons.AddPerson(new HourlyPaymentPerson() { HourlyPayment = 70, Name = "Смирнов" });
            }

            var sorted = persons.Persons.OrderByDescending(s => s, new PersonComparer());

            foreach (var person in sorted)
                Console.WriteLine(person);

            Console.WriteLine("-------------------------------------------------------------");

            foreach (var name in sorted.Take(5).Select(e => e.Name))
                Console.WriteLine(name);

            Console.WriteLine("-------------------------------------------------------------");

            foreach (var id in sorted.Skip(sorted.Count() - 3 > 0 ? sorted.Count() - 3 : 0).Select(e => e.ID))
                Console.WriteLine(id);

            XML.Save<PersonsSettings>(file, persons);

            Console.ReadKey();
        }
    }
}

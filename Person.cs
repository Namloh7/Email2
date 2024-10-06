using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace EMAILS
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public string Mailserver;
        public string Domain;
        public int? Age;


        public Person(string name, string surname, string mailserver, string domain, int? age = null)
        {
            this.Name = name;
            this.Surname = surname;
            this.Mailserver = mailserver;
            this.Domain = domain;
            this.Age = age;






        }
        public static void Peoples()
        {
            List<Person> persons = new List<Person>();
            string currentDirectory = "Emaily.txt";
            List<string> emails = new List<string>();
            emails = File.ReadAllLines(currentDirectory).ToList();

            foreach (string email in emails)
            {
                string[] parts = email.Split('@');
                string ndPart = parts[1];
                string stPart = parts[0];

                string number = Regex.Replace(email, @"\D", "");

                bool hasValidNumber = int.TryParse(number, out int intnum);

                string[] names = stPart.Split('.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
                string name = names[0];
                string surname = names[1];

                string[] DomainMS = ndPart.Split('.');
                string mailserver = DomainMS[0];
                string domain = DomainMS[1];

                if (hasValidNumber && intnum >= DateTime.Now.Year - 100 && intnum <= DateTime.Now.Year)
                { 
                
                int age = DateTime.Now.Year - intnum;
                    Person person = new Person(name, surname, mailserver, domain, age);
                    persons.Add(person);
                }else 
                {
                    Person person = new Person(name, surname, mailserver, domain);
                    persons.Add(person);
                }
                foreach (Person p in persons)
                {
                    Console.WriteLine("Your name. " + p.Name);
                    Console.WriteLine("Your surname. " + p.Surname);
                    Console.WriteLine("Your mailserver: " + p.Mailserver);
                    Console.WriteLine("Your domain: " + p.Domain);
                    if (p.Age != null)
                    {
                        Console.WriteLine("Your age: " + p.Age);
                    }
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

                }

            }







        }
    }
}

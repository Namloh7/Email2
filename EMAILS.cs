using EMAILS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Email

{ //konstruktor, list lidí
    internal class Program
    {
        static void Main(string[] args)
        {
        List<Person> persons = new List<Person>();
        List<string> emails = new List<string>();
             
            string currentDirectory = "Emaily.txt";

            emails = File.ReadAllLines(currentDirectory).ToList();



            foreach (string email in emails)
            {



                string[] parts = email.Split('@');
                string ndPart = parts[1];
                string stPart = parts[0];

                string number = Regex.Replace(email, @"\D", "");
                int intnum;
                bool hasValidNumber = int.TryParse(number, out intnum);

                string[] names = stPart.Split('.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
                string name = names[0];
                string surname = names[1];

                string[] DomainMS = ndPart.Split('.');
                string mailserver = DomainMS[0];
                string domain = DomainMS[1];

                if (hasValidNumber && NumCheck(intnum) != -1)
                {
                    int age = 2024 - intnum;
                    Person person = new Person(name, surname, mailserver, domain, age);
                    persons.Add(person);
                }
                else 
                {
                    Person person = new Person(name, surname, mailserver, domain);
                    persons.Add(person);
                }



                
            }
            int i = 0;
            foreach(Person p in persons) 
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

            Console.Read();


        }
        static int NumCheck(int number)
        {
            if (number >= 1899 && number <= 2019)
            {
                int Age = 2024 - number;
                return Age;
            }
            else
            {
                return -1;
            }




        }

    }
        
        



    

}
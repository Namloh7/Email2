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


        public Person()
        {
            List<string> emails = new List<string>();
            List<Person> persons = new List<Person>();
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

                if(hasValidNumber && NumCheck(intnum)!= -1) 
                {
                    int age = 2024 - intnum;
                    persons.Add(new Person { Name = name, Surname = surname, Mailserver = mailserver, Domain = domain, Age = age });
                }else 
                {
                    persons.Add(new Person { Name = name, Surname = surname, Mailserver = mailserver, Domain = domain });
                }

                

            }
            
            foreach (var person in persons)
            {
                Console.WriteLine("Your name: " + person.Name);
                Console.WriteLine("Your surname: " + person.Surname);
                Console.WriteLine("Your mailserver: " + person.Mailserver);
                Console.WriteLine("Your domain: " + person.Domain);
                if (person.Age.HasValue)
                {
                    Console.WriteLine("Your age: " + person.Age);
                }
                Console.WriteLine("___________________________");
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


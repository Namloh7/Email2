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

            //List<string> emails = new List<string>();
            //List<Person> persons = new List<Person>();
            //string currentDirectory = "Emaily.txt";
            //emails = File.ReadAllLines(currentDirectory).ToList();
            //List<Person> Persons = new List<Person>();

            //foreach (string email in emails)
            //{



            //    string[] parts = email.Split('@');
            //    string ndPart = parts[1];
            //    string stPart = parts[0];

            //    string number = Regex.Replace(email, @"\D", "");
            //    int intnum = Convert.ToInt32(number);

            //    string[] names = stPart.Split('.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            //    string name = names[0];
            //    string surname = names[1];

            //    string[] DomainMS = ndPart.Split('.');
            //    string mailserver = DomainMS[0];
            //    string domain = DomainMS[1];



            //    if (NumCheck(intnum) != -1)
            //    {

            //        int age = 2024 - intnum;


            //        persons.Add(new Person { Name = name, Surname = surname, Mailserver = mailserver, Domain = domain, Age = age });
            //    }
            //    persons.Add(new Person { Name = name, Surname = surname, Mailserver = mailserver, Domain = domain});

            //}
            //Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP");
            //foreach(var person in persons) 
            //{
            //    Console.WriteLine(person.Name);
            //    Console.WriteLine(person.Surname);
            //    Console.WriteLine(person.Mailserver);
            //    Console.WriteLine(person.Domain);
            //    if (person.Age.HasValue) 
            //    { 
            //        Console.WriteLine(person.Age);
            //    }
            //    Console.WriteLine("___________________________");
            //}

            
            //Console.Read();


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
        static void SlowRead(string s)
        {

            foreach (char c in s)
            {
                Thread.Sleep(25);
                Console.Write(c);
            }
            Console.WriteLine();
        }



    }

}
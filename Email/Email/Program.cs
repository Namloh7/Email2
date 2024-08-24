using Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your email in this format: name.surnamenumber@mailserver.domain");
            string email = Console.ReadLine();
            string[] parts = email.Split('@');
            string ndPart = parts[1];
            string stPart = parts[0];

            int intnum = 0;

            //číslo
            bool emaiContainsDigit = false;
            string[] digits = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            foreach (string digit in digits)
            {
                emaiContainsDigit = email.Contains(digit) ? true : false;
            };


            // přiřadí hodnotu číslu jen v případě, že email nějaké číslo obsahuje
            if (emaiContainsDigit)
            {
                string number = Regex.Replace(email, @"\D", "");
                intnum = int.Parse(number);
            }

            //Křestní jméno, příjmeňí
            // Tady ti ještě chybí ty další oddělovače (- a _) jinak úplně v pořádku

            string[] names = stPart.Split('.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            string name = names[0];
            string surname = names[1];

            //Doména
            string[] DomainMS = ndPart.Split('.');
            string mailserver = DomainMS[0];
            string Domain = DomainMS[1];

            Thread.Sleep(25);
            Console.Write("Your name: "); HelperClass.SlowRead(name);
            Console.Write("Your surname: "); HelperClass.SlowRead(surname);

            if (NumCheck(intnum, out int Age))
            {
                Thread.Sleep(25);
                Console.WriteLine("The year you were born: " + intnum);
                Console.WriteLine("Your age: " + Age);
            }

            Console.Write("Mailserver: "); HelperClass.SlowRead(mailserver);
            Console.Write("Domain: "); HelperClass.SlowRead(Domain);

            Console.ReadLine();
        }

        static bool NumCheck(int number, out int Age)
        {
            bool success = true;

            // tady jsem jen ty datumy chtěl dynamické pomocí DateTime třídy... 
            if (number >= DateTime.Now.Year - 125 && number <= DateTime.Now.Year - 5)
            {
                Age = DateTime.Now.Year - number;
            }
            else
            {
                Age = 0;
                success = false;
            }
            return success;
        }

    }
}
﻿using System;
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
            //číslo
            string number = Regex.Replace(email, @"\D", "");
            int intnum = Convert.ToInt32(number);

            
           

           //Křestní jméno, příjmeňí
            
            string[] names = stPart.Split('.', '1','2', '3', '4', '5', '6', '7', '8', '9', '0'); 
            string name = names[0];
            string surname = names[1];

            //Doména
            string[] DomainMS = ndPart.Split('.');
            string mailserver = DomainMS[0];
            string Domain = DomainMS[1];
            
            
            Thread.Sleep(25);
            Console.Write("Your name: "); SlowRead(name);
            Console.Write("Your surname: "); SlowRead(surname);
            Console.Write("Mailserver: "); SlowRead(mailserver);
            Console.Write("Domain: "); SlowRead(Domain);
            if (NumCheck(intnum) != -1) 
                Thread.Sleep(25);
                Console.Write("The year you were born: " + intnum);
            Console.WriteLine();
            int Age = 2024 - intnum;
                Console.Write("Your age: " + Age );


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
        static void  SlowRead(string s) 
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
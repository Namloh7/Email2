﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
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
            List<string> emails = new List<string>();
            Console.WriteLine("Write your email in this format: name.surnamenumber@mailserver.domain");
            Console.WriteLine("Write done when you are finished");
            
            string input = @"jan.novak1987@seznam.cz
pavel.kral193 @gmail.com
lucie.kovarikova2001 @outlook.com
marketa.svobodova1990 @centrum.cz
petr.kubicek18 @gmail.com
lenka.vanickova1986 @seznam.cz
tomas.horak1992 @post.cz
martin.krejci200344 @yahoo.com
veronika.hrdlickova1999 @seznam.cz
eva.nemcova1984 @gmail.com
milan.cerny1969 @centrum.cz
jakub.dolezal187 @outlook.com
jitka.kucerova1972 @seznam.cz
ondrej.bernard1998 @gmail.com
zdenek.havlicek1977 @yahoo.com
jana.vitkova5756 @post.cz
radek.kolar4565 @centrum.cz
roman.svoboda1996 @gmail.com
klara.mrazkova1991 @seznam.cz
pavlina.machova182 @gmail.com";



            string[] emailArray = emails.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            foreach (string email in emailArray) 
            {
                string[] parts = email.Split('@');
                string ndPart = parts[1];
                string stPart = parts[0];
                //číslo
                string number = Regex.Replace(email, @"\D", "");
                int intnum = Convert.ToInt32(number);




                //Křestní jméno, příjmeňí

                string[] names = stPart.Split('.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
                string name = names[0];
                string surname = names[1];

                //Doména
                string[] DomainMS = ndPart.Split('.');
                string mailserver = DomainMS[0];
                string Domain = DomainMS[1];

                Console.WriteLine("******************************");
                Thread.Sleep(25);
                Console.Write("Your name: "); SlowRead(name);
                Console.Write("Your surname: "); SlowRead(surname);
                Console.Write("Mailserver: "); SlowRead(mailserver);
                Console.Write("Domain: "); SlowRead(Domain);
                if (NumCheck(intnum) != -1)
                {
                    Thread.Sleep(25);
                    Console.Write("The year you were born: " + intnum);
                    Console.WriteLine();
                    int Age = 2024 - intnum;
                    Console.Write("Your age: " + Age);

                }


                Console.WriteLine();

                Console.WriteLine("******************************");



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
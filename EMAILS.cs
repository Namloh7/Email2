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
            Person personManager = new Person("", "", "", "");
            List<Person> persons = personManager.Peoples();
            
            foreach (Person person in persons)
            {
                person.PrintInfo();

            }

            Console.Read();


        }
        

    }
        
        



    

}
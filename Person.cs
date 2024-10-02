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


        public Person(string name,string surname,string mailserver,string domain,int? age = null)
        {
            this.Name = name;
            this.Surname = surname;
            this.Mailserver = mailserver;
            this.Domain = domain;
            this.Age = age;
            
            

            


        }
        




        
        

    }
}


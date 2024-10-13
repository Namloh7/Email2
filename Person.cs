using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace EMAILZ
{
    internal class Person
    {
        private string email;
        public string Email 
        { 
            get { return email; }
            set 
            { 
            email = value;
            }
        }

        private string name;
        public string Name 
        { 
            get { return name; }
            set {  name = value; }
            
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        
        }
        private string mailserver;
        public string Mailserver
        {
            get { return mailserver; }
            set { mailserver = value; }
        }
        private string domain;
        public string Domain
        {
            get { return domain;}
            set { domain = value; }
        }
        private int? age;
        public int? Age
        {
            get { return age;}
            set 
            {

                if (value >= DateTime.Now.Year - 100 && value <= DateTime.Now.Year)
                {
                    age = DateTime.Now.Year - value;
                }
                else value = null; 
            }
        
        
        }
        private int? bornYear;
        public int? BornYear 
        { 
        get { return bornYear;}
        set 
            { 
            if (value >= DateTime.Now.Year - 100 && value <= DateTime.Now.Year) 
            {
                    bornYear = value;   
            }else value = null;



            }
        
        }

        

        public Person(string email)
        {
            this.Email = email;
            DataFromEmail();
        }
        private void PrintInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Your name: " + Name);
            sb.AppendLine("Your surname. " + Surname);
            sb.AppendLine("Your mailserver: " + Mailserver);
            sb.AppendLine("Your domain: " + Domain);
            if (Age != null) sb.AppendLine("Your age: " + Age);
            if (BornYear != null) sb.AppendLine("You were born in: " + BornYear);
            sb.Append("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine(sb.ToString());
        }
        private void DataFromEmail()
        {
            string[] parts = this.Email.Split('@');
            string ndPart = parts[1];
            string stPart = parts[0];

            string number = Regex.Replace(this.Email, @"\D", "");
            

            string[] names = stPart.Split('.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            this.Name = names[0];
            this.Surname = names[1];

            string[] DomainMS = ndPart.Split('.');
            this.Mailserver = DomainMS[0];
            this.Domain = DomainMS[1];

            
            PrintInfo();
        }
    }
}

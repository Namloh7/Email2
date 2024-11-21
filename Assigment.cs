using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClass
{
    public class Assigment
    {
        public string content { get; set; }
        public bool isfavourite {  get; set; }
        public Assigment(string con) 
        {
            content = con;
            isfavourite = false;

         
            
        }  
        public void Favourite() 
        { 
            this.isfavourite = true;
        }
        public void UnFavourite() 
        {
            this.isfavourite = false;
        }
    }
}

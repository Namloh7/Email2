using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            while(true) 
            {
                ToDo task = new ToDo(HelperClass.GetIntInRange("Write 1 to show your list, 2 to add tomething to it and 3 to remove smth from it", 1, 3));
            } 
        }
 
    }

}

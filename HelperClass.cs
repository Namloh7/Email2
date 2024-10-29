using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClass
{
    public static class HelperClass
    {
    
    public static int GetIntInRange(string message, int min, int max) 
            {
                bool isnumber = true;
                int value = 0;
                do
                {
                    Console.WriteLine(message);
                    isnumber = int.TryParse(Console.ReadLine(), out value);
                }
                while (value < min && value > max && !isnumber);
                return value;
            }


    }
}

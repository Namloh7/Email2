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
            while (true)
            {
                bool gcontinue = true;
                while(gcontinue) 
                {
                    Console.WriteLine("Write 1 to show your list, 2 to add tomething to it and 3 to remove smth from it");
                    string input = Console.ReadLine();
                    bool IsNumber = int.TryParse(input, out int intnumber);
                    if (IsNumber)
                    {
                        if (intnumber <= 3 && intnumber >= 1)
                        {
                            gcontinue = false;
                            int num = intnumber;
                            ToDo task = new ToDo(num);
                        }
                    }
                    else { gcontinue = true; }

                }

            }
        }
 
    }

}

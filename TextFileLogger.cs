using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClass
{
    static public class TextFileLogger
    {
        static string CurrentDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\List.txt");
        
        static public void ToTextFile(List<string> ASSIGMENT)
        {

            File.WriteAllLines(CurrentDirectory, ASSIGMENT);

        }

        static public string[] FromTextToList()
        {
            return File.ReadAllLines(CurrentDirectory);
        }
    }



}

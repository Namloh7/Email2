using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClass
{
    public class ToDo
    {
        private string task{  get; set; }
        public static List<ToDo> Tasks = new List<ToDo>();
    public ToDo(int  num) 
        {
            if (num == 1) { PrintList(); } 
            if (num == 2) { AddRemove.AddTask();}
            if (num == 2) { AddRemove.RemoveTask(); }
        }
        public static void PrintList() 
        {
            int i = 1;
        foreach(var o in Tasks) 
            { 
            Console.WriteLine($"{i}) {o.task}");
                i++;
            }
        }
        
    }
}   
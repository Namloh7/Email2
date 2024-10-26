using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClass
{
    internal class ToDo
    {
        private string task{  get; set; }
        private static List<ToDo> Tasks = new List<ToDo>();
    public ToDo(int  num) 
        { 
            if (num == 1) { PrintList(); }
            if(num == 2) { AddTask(); }
            if(num == 3) { RemoveTask(); }
        }

        private void AddTask() 
        {
            Console.WriteLine("Add to your list: ");
            this.task = Console.ReadLine();
            Tasks.Add(this);
        }
        private void PrintList() 
        {
            int i = 1;
        foreach(var o in Tasks) 
            { 
            Console.WriteLine($"{i}) {o.task}");
                i++;
            }
        }
        private void RemoveTask() 
        {
            PrintList();
            Console.WriteLine("What task do you want to remove: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int num);
            int removenum = num - 1;
            Tasks.RemoveAt(removenum);
            PrintList();
        }
    }
}   
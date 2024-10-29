using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClass
{
    internal class AddRemove
    {
        public string Task{  get; set; }
        public AddRemove(int num) 
        {
            if (num == 2) { AddTask(); }
            if (num == 3) { RemoveTask(); }

        }  
        public static void RemoveTask()
        {
            ToDo.PrintList();
            Console.WriteLine("What task do you want to remove: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int num);
            int removenum = num - 1;
            ToDo.Tasks.RemoveAt(removenum);
            ToDo.PrintList();

        }
        public static void AddTask()
        {
            Console.WriteLine("Add to your list: ");
            this.Task = Console.ReadLine();
            ToDo.Tasks.Add(this);
            ToDo.PrintList();
        }
    }
}

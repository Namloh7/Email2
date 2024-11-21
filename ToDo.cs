using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClass
{
    public class ToDo
    {

        public List<Assigment> Assigments = new List<Assigment>();

        public ToDo()
        {
            ReadTextFile();
            while (true)
            {
                int num = HelperClass.GetIntInRange("¨Write 1 to show the list 2 to add smth and 3 to remove smth", 1, 5);

                if (num == 1) { PrintList(); }
                else if (num == 2) { AddTask(); }
                else if (num == 3){ RemoveTask(); }
                else if (num == 4) { AssigmentFavourite(); }
                else { AssigmentUnFavourite(); }

            }
        }
        public void PrintList()
        {
            List<string> FavouriteTasks = new List<string>();
            List<string> UnFavouriteTasks = new List<string>();



            foreach (Assigment Ass in Assigments)
            {
                if (Ass.isfavourite)
                {
                    FavouriteTasks.Add(Ass.content);
                }
                else 
                { 
                    UnFavouriteTasks.Add(Ass.content);
                }
            }
            foreach(string  FavouriteTask in FavouriteTasks)
            {
                HelperClass.WriteLine(FavouriteTask);
            }
            foreach (string UnFavouriteTask in UnFavouriteTasks)
            {
                HelperClass.WriteLine(UnFavouriteTask);
            }

        } /*k + d*/
        public void RemoveTask()
        {

            if (Assigments.Count == 0)
            {
                HelperClass.WriteLine("There isnt anything you can remove"); return;
            }
            PrintList();
            int num = HelperClass.GetIntInRange("What task do you want to remove: ", 1, Assigments.Count) - 1;
            Assigments.RemoveAt(num);

            TextFileAssigments();
            PrintList();
        }
        public void AddTask()
        {
            HelperClass.WriteLine("Add to your list: ");
            Assigment ass = new Assigment(HelperClass.ReadLine());
            Assigments.Add(ass);
            PrintList();

            TextFileAssigments();
        }

        void TextFileAssigments()
        {
            List<string> Tmp = new List<string>();
            foreach (var Ass in Assigments)
            {
                Tmp.Add(Ass.content);
            }
            TextFileLogger.ToTextFile(Tmp);
        }
        void ReadTextFile()
        {
            string[] lsit = TextFileLogger.FromTextToList();
            foreach (string s in lsit)
            {
                Assigment Ass = new Assigment(s);
                Assigments.Add(Ass);
            }
        }
        void AssigmentFavourite() //TODO vyberu task udelám fav
        {
            PrintList();
            HelperClass.GetIntInRange("What task would you like to set to favourite?",0,Assigments.Count);
            int TaskToFav = Console.Read();
            
            Assigments[TaskToFav].isfavourite = true;
        }
        void AssigmentUnFavourite() //TODO vyberu task udelám unfav
        {
            PrintList();
            HelperClass.GetIntInRange("What task would you like to set to unfavourite?",0,Assigments.Count);
            int TaskToUnfav = Console.Read();
            Assigments[TaskToUnfav].isfavourite = false;
        }
    }

}
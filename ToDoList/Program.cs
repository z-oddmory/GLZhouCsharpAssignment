using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> groceryList = new List<string>();
            groceryList.Add("Coke");
            groceryList.Add("Pepsi");
            groceryList.Remove("pineapple");
            //could optimize the program

            //The first two operations should just include add or remove
            Console.WriteLine("The current grocery list has:");
            groceryList.ForEach(Console.WriteLine);
            for (int j = 0; j < 2; j++)
            {
                //Console.WriteLine($"Now the j is {j}");
                Console.WriteLine($"Enter command (+ item, - item, or -- to clear)):");
                string command = Console.ReadLine();
                if (command == "+ item")
                {
                    Console.WriteLine("The adding item name is:");
                    string addItem = Console.ReadLine();
                    Console.WriteLine("------");
                    groceryList.Add(addItem);
                    //for (int k = 0; k < groceryList.Count; k++)
                    //{
                    //    Console.WriteLine(groceryList[k]);
                    //}
                    groceryList.ForEach(Console.WriteLine);
                }
                else if (command == "- item")
                {
                    Console.WriteLine("The item that will be deleted is:");                   
                    string deleteItem = Console.ReadLine();
                    Console.WriteLine("------");
                    groceryList.Remove(deleteItem);
                    groceryList.ForEach(Console.WriteLine);
                }
                else
                {
                    Console.WriteLine("You are not allowed to use '-- item' command here or you use wrong command. Please try another one.");
                    --j;
                }

            }

            Console.WriteLine("Now you could give more commands(>2):");
            while (true)
            {
                Console.WriteLine($"Enter command (+ item, - item, or -- to clear)):");
                string command = Console.ReadLine();
                if (command == "+ item")
                {
                    Console.WriteLine("The adding item name is:");
                    string addItem = Console.ReadLine();
                    Console.WriteLine("------");
                    groceryList.Add(addItem);
                    groceryList.ForEach(Console.WriteLine);
                }
                else if (command == "- item")
                {
                    Console.WriteLine("The item that will be deleted is:");
                    string deleteItem = Console.ReadLine();
                    Console.WriteLine("------");
                    groceryList.Remove(deleteItem);
                    groceryList.ForEach(Console.WriteLine);
                }
                else if (command == "--")
                {
                    groceryList.Clear();
                    Console.WriteLine("------");
                    groceryList.ForEach(Console.WriteLine);
                    Console.WriteLine("Now the grocery list is empty.");
                }
                else
                {
                    Console.WriteLine($"Your command is {command}. Please use '+ item', '- item' or '--'");
                }

            }
            Console.ReadKey();

        }
    }
}

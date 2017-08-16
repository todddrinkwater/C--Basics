using System;
using System.Collections.Generic;

namespace csharppractice.cs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool toggle = true;
            List<string> groceries = new List<string>() { "apples", "bananas", "oranges" };
            while (toggle == true)
            {
                Console.WriteLine("Input '+' to add items, '-' to remove items, '--' to clear the list, or type 'end' to finish adding items.");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "+":
                        Console.WriteLine("What would you like to add?");
                        string addItem = Console.ReadLine();
                        groceries.Add(addItem);
                        Console.WriteLine($"Thank you. You've added {addItem}");
                        Console.WriteLine($"Your updated shopping list is now:");
                        groceries.ForEach(c => { Console.WriteLine($"{c}"); });
                        break;
                    case "-":
                        Console.WriteLine("What would you like to remove?");
                        string removedItem = Console.ReadLine();
                        groceries.Remove(removedItem);
                        Console.WriteLine($"Thank you. You've removed {removedItem}");
                        Console.WriteLine($"Your updated shopping list is now:");
                        groceries.ForEach(c => { Console.WriteLine($"{c}"); });
                        break;
                    case "--":
                        groceries.Clear();
                        Console.WriteLine($"Thank you. Your has list currently has {groceries.Count} items.");
                        break;
                    case "end":
                        toggle = false;
                        Console.WriteLine("Thank you. Your session has finished.");
                        break;
                }
            }
        }
    }
}

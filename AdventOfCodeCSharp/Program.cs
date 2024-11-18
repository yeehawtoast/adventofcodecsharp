using System;
using System.Diagnostics;
using AdventOfCodeCSharp;

class Program
{
    static void Main()
    {
        string userInput = string.Empty;
        SelectOptions obj2023 = new SelectOptions();

        while (userInput.ToLower() != "exit")
        {
            Console.Clear();
           MakeTree();
           Console.WriteLine("Welcome to Advent of Code!");
           Console.WriteLine("Please type a year between 2015 and 2023 to continue or type exit to quit!");
           userInput = Console.ReadLine() ?? throw new InvalidOperationException();
           switch (userInput)
           {
               case "2015":
                   obj2023.Select2015();
                   break;
               case "2016":
                   break;
               case "2017":
                   break;
               case "2018":
                   break;
               case "2019":
                   break;
               case "2020":
                   break;
               case "2021":
                   break;
               case "2022":
                   obj2023.Select2022();
                   break;
               case "2023":
                   
                   obj2023.Select2023();
                   break;
           }
        }

        Console.Clear();
        Console.WriteLine("Exiting the application. Goodbye!");
    }

    static void MakeTree()
    {
        Console.WriteLine(
            "             /\\\n            <  >\n             \\/\n             /\\\n            /  \\\n           /++++\\\n          /  ()  \\\n          /      \\\n         /~`~`~`~`\\\n        /  ()  ()  \\\n        /          \\\n       /*&*&*&*&*&*&\\\n      /  ()  ()  ()  \\\n      /              \\\n     /++++++++++++++++\\\n    /  ()  ()  ()  ()  \\\n    /                  \\\n   /~`~`~`~`~`~`~`~`~`~`\\\n  /  ()  ()  ()  ()  ()  \\\n  /*&*&*&*&*&*&*&*&*&*&*&\\\n /                        \\\n/,.,.,.,.,.,.,.,.,.,.,.,.,.\\\n           |   |\n          |`````|\n          \\_____/");
    }

}

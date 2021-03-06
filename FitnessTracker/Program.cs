﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var runningTotal = 0.0;

            // Repeat until the user quits
            while (true)
            {

                // Prompt the user for minutes excercised
                Console.Write("Enter how many minutes you exercised or type 'quit' to exit: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    Console.WriteLine("You exercised " + runningTotal + " minutes!  Great workout!");
                    break;
                }
                
                // Converting entry string into int minutes
                var minutes = 0.0;
                try
                {
                    minutes = double.Parse(entry);
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input.");
                    continue;
                }

                // Checking validity of entry
                if (minutes <= 0)
                {
                    Console.WriteLine("You have entered an invalid number of minutes.");
                }
                else
                {
                    // Add minutes exercised to total
                    runningTotal += minutes;

                    // Display total minutes exercised to the screen
                    Console.WriteLine("You have exercised " + runningTotal + " minutes!");

                    // Extra message based on total workout time
                    if (runningTotal <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (runningTotal <= 30)
                    {
                        Console.WriteLine("Way to go, hot stuff!");
                    }
                    else if (runningTotal <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }
                }
            }
        }
    }
}
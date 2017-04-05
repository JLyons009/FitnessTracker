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
            int runningTotal = 0;
            bool keepGoing = true;

            // Repeat until the user quits
            while (keepGoing)
            {

                // Prompt the user for minutes excercised
                Console.Write("Enter how many minutes you exercised or type 'quit' to exit: ");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                    Console.WriteLine("You exercised " + runningTotal + " minutes!  Great workout!");
                }

                else
                {
                    int minutes = int.Parse(entry);
                    if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go, hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }

                    // Add minutes exercised to total
                    runningTotal += minutes;

                    // Display total minutes exercised to the screen
                    Console.WriteLine("You have exercised " + runningTotal + " minutes!");
                }

            }
        }
    }
}
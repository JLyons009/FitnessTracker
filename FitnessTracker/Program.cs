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

            // Prompt the user for minutes excercised
            Console.Write("Enter how many minutes you exercised: ");
            string entry = Console.ReadLine();

            // Add minutes exercised to total
            int minutes = int.Parse(entry);
            runningTotal = runningTotal + minutes;

            // Display total minutes exercised to the screen
            Console.WriteLine("You have exercised " + runningTotal + " minutes!");

            // Repeat until the user quits


        }
    }
}
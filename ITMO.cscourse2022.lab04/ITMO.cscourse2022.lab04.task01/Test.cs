﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Test
    {
        public static void Main()
        {
            int x; // Input value 1
            int y; // Input value 2
            int greater; // Result from Greater()

            // Get input numbers
            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());

            // Test the Greater( ) method
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);

            Console.WriteLine("Before swap: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);

            int f; // Factorial result
            bool ok; // Factorial success or failure

            // Get input for factorial

            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());

            // Test the factorial function
            ok = Utils.Factorial(x, out f);
            // Output factorial results
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");

        }
    }

}
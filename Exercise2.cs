using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace second_CSharp_exercises_entra21
{
    public class Exercise2
    {
        public static void PrintingInReverseAndDirectOrder()
        {
            double [] numbers = new double[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Insert the {i + 1} number");
                while (true)
                {
                    try
                    {
                        numbers[i] = Double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try Again!");
                    }    
                }
            }

            Console.WriteLine("Printing in the direct order:");
            Console.WriteLine(string.Join(" ", numbers));
                        
            Console.WriteLine("Printing in the reverse order:");
            for (int i = numbers.Length - 1; i > -1 ; i--)
                Console.WriteLine(numbers[i]);
        }
    }
}

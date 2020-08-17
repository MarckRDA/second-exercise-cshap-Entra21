using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace second_CSharp_exercises_entra21
{
    public class Exercise3
    {
        public static void IsItInArrayOrNot()
        {
            double [] numbers = new double[3];
            var guess = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Insert the {i + 1}º number");
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

            Console.WriteLine("Give a guess: ");
            while (true)
            {
                try
                {
                    guess = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try Again!");
                }    
            }
            var thereIsANumber = false;

            foreach (var item in numbers)
            {
                if (guess == item)
                {
                    thereIsANumber = true;
                    break;
                }
            }
            var messager = (thereIsANumber) ? "There's a number equal yours" : "There's not a number equal yours";
            Console.WriteLine(messager);                 
        }
    }
}

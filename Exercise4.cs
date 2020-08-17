using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace second_CSharp_exercises_entra21
{
    public class Exercise4
    {
        public static void EqualityBetweenArrays()
        {
            const int arraysLength = 10;
            double?[] arrayA = new double?[arraysLength];
            double[] arrayB = new double[arraysLength];
            var doesNotEqual = false;
            for (int i = 0; i < arraysLength; i++)
            {
                Console.WriteLine($"Digit the {i + 1}º number");
                while (true)
                {
                    try
                    {
                        arrayA[i] = Double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try Again!");
                    }
                }
            }

            for (int i = 0; i < arraysLength; i++)
            {
                Console.WriteLine($"Digit the {i + 1}º number");
                while (true)
                {
                    try
                    {
                        arrayB[i] = Double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try Again!");
                    }
                }

                for (int j = 0; j < arrayA.Length; j++)
                {
                    if (arrayA[j] == arrayB[i])
                    {
                        arrayA[j] = null;
                        doesNotEqual = true;
                        break;
                    }
                    doesNotEqual = false;
                }
            }

            var messager = (doesNotEqual) ? "The arrays are equals" : "The arrays aren't equals";
            Console.WriteLine(messager);

        }

    }
}

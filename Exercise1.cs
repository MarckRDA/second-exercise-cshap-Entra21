using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace second_CSharp_exercises_entra21
{
    public class Exercise1
    {
        public static void ArrayCMixUp()
        {
            const int arraysLength = 15;
            double[] arrayA = new double[arraysLength];
            double[] arrayB = new double[arraysLength];
            double[] arrayC = new double[arraysLength];

            for (int i = 0; i < arraysLength; i++)
            {
                Console.WriteLine($"Insert the {i + 1} number in Array A");
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
                Console.WriteLine($"Insert the {i + 1} number in Array B");
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
                arrayC[i] = arrayA[i] - arrayB[i];
            }
            Console.WriteLine(string.Join(", ", arrayC));

        }
    }
}

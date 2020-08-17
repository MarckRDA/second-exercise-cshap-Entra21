using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace second_CSharp_exercises_entra21
{
    public class Exercise6
    {
        public static void ReorderArrays()
        {
            const int arrayLength = 5;
            double[] arrayA = new double [arrayLength];
            double[] arrayB = new double [arrayLength];
            double[] arrayC = new double [arrayLength];
            var temp = 0.0;
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Digit the {i + 1}º number in the A array: ");
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
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayA.Length; j++)
                {
                    if (arrayA[i] < arrayA[j] )
                    {
                        temp = arrayA[j];
                        arrayA[j] = arrayA[i];
                        arrayA[i] = temp;
                    }
                }
            }
            
            temp = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Digit the {i + 1}º number in the B array: ");
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
                
            }
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayA.Length; j++)
                {
                    if (arrayB[i] > arrayB[j] )
                    {
                        temp = arrayB[j];
                        arrayB[j] = arrayB[i];
                        arrayB[i] = temp;
                    }
                }
            }

            temp = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                arrayC[i] = arrayA[i] + arrayB[i];
            }
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayC.Length; j++)
                {
                    if (arrayC[i] < arrayC[j] )
                    {
                        temp = arrayC[j];
                        arrayC[j] = arrayC[i];
                        arrayC[i] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arrayC));
        }

    }
}

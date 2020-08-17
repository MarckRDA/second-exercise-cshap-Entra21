using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace second_CSharp_exercises_entra21
{
    public class Exercise5
    {
        public static void EqualLowerOrBiggerThanAvarage()
        {
            const int arrayLength = 5;
            double[] numbers = new double[arrayLength];
            double avarage = 0.0;
            var bigger = 0.0;
            var lower = 0.0;
            var equal = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Digit the {i + 1}º number: ");
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
                avarage += numbers[i];
            }
            avarage /= arrayLength;

            for (int i = 0; i < arrayLength; i++)
            {
                var number = numbers[i];
                if (number > avarage)
                {
                    bigger++;
                }
                else if (number < avarage)
                {
                    lower++;
                }
                else
                {
                    equal++;
                }
            }

            System.Console.WriteLine($"The avarage of that array is {avarage} and there are {lower} elements under the avarage, {bigger} elements abouve the avarage and {equal} elementes equals the avarage");
        }

    }
}

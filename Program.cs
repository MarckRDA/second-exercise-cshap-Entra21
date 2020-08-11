using System;

namespace second_exersises_csharo_entra21
{
    class Program
    {
        static void Exercise1()
        {
            const int arraysLength = 15;
            double [] arrayA = new double[arraysLength];
            double [] arrayB = new double[arraysLength];
            double [] arrayC = new double[arraysLength];

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
              
        }
        static void Exercise2()
        {
            double [] numbers = new double[10];

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
            foreach (var item in numbers)
                Console.WriteLine(item);
                        
            Console.WriteLine("Printing in the reverse order:");
            for (int i = numbers.Length - 1; i > -1 ; i--)
                Console.WriteLine(numbers[i]);
            
        }
        
        static void Exercise3()
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
        static void Exercise4()
        {
            const int arraysLength = 10;
            double? [] arrayA = new double?[arraysLength];
            double [] arrayB = new double[arraysLength];
            var doesNotEqual = false;
            for(int i = 0; i < arraysLength; i++)
            {
                Console.WriteLine($"Digit the {i+1}º number");
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

            for(int i = 0; i <arraysLength; i++)
            {
                Console.WriteLine($"Digit the {i+1}º number");
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
                    if(arrayA[j] == arrayB[i])
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

        static void Exercise5()
        {   
            const int arrayLength = 5;
            double [] numbers = new double[arrayLength];
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
                avarage+=numbers[i];
            }
            avarage/=arrayLength;

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

        static void Exercise6()
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

         static void Main(string[] args)
         {
            Exercise6();             
         }
    }
}

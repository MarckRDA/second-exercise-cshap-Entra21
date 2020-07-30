using System;

namespace second_exersises_csharo_entra21
{
    class Program
    {
        //Exercise 1
        static void CArrayDiffAandB(string[] args)
        {
            int [] a= {1, 2, 50, 4, 677, 11, 34, 56, 78, 22, 1, 90, 1083, 755, 32};
            int [] b = {133, 44, 7, 23, 54, 2, 78, 44, 13, 1, 45, 67, 21, 455, 45};
            int [] c = new int [15];

            var count = 0;

            while (count < 15){
                c[count] = a[count] - b[count];
                count++;
            }
    
        }
        //Exercise 2
        static void PrintinginDirectandReverseOrder(string[] args)
        {
            int [] numbers = new int [10];
            var count = 0;

            while (count < 10){
                System.Console.WriteLine($"Digit the {count + 1}º number");
                numbers[count] = Convert.ToInt32(System.Console.ReadLine());
                count++;
            }
            count = 0;
            System.Console.WriteLine("Printing in a direct order : ");
            
            while (count < 10){
                System.Console.WriteLine(numbers[count]);
                count++;
            }
            
            System.Console.WriteLine("Printing in a reverse order : ");
            count = 9;

            while (count >= 0){
                System.Console.WriteLine(numbers[count]);
                count--;
            }
    
        }
        //Exercise 3
         static void GuessNumberInArray(string[] args)
        {
           int [] numbers = new int[10];
           var count = 0;
           
           while (count < 10){
               System.Console.WriteLine($"Digit {count + 1}º number");
               numbers[count] = Convert.ToInt32(System.Console.ReadLine());
               count++;     
           }

           System.Console.WriteLine("Digit a number that suppost be in this array: ");
           var guessUser = Convert.ToInt32(System.Console.ReadLine());
           count = 0;
           while(count < 10){
                if (numbers[count] != guessUser){
                    count++;
                    if(count == 9){
                        System.Console.WriteLine("This number does not exist in this array!");
                    }
                    continue;
                }
                else{
                    System.Console.WriteLine("This number exists in this array! ");
                    break;
                }

            }
                     
        }
        //Exercise 4
        static void ArraysIsEquals(string[] args)
        {
            int [] a = new int [10];
            int [] b = new int [10];
            var count = 0;
            var match = 0;
            while(count < 10){
                System.Console.WriteLine($"Digit the {count + 1}º number in the A array: ");
                a[count] = Convert.ToInt32(System.Console.ReadLine());
                count++;
            }
            count = 0;
            while(count < 10){
                System.Console.WriteLine($"Digit the {count + 1}º number in the B array: ");
                b[count] = Convert.ToInt32(System.Console.ReadLine());
                count++;
            }
            count = 0;

            while(count < 10){
                if(a[count] == b[count]){
                    match++;
                }
                count++;
            }

            if(match == 10){
                System.Console.WriteLine("These arrays are the same! ");
            }                
            else{
                System.Console.WriteLine("These arrays do not the same!");
            }
                
            
        }

        //Exercise 5
         static void AvarageArray(string[] args)
        {
            int [] a = new int [15];
            var count = 0;
            var sum = 0;
            double avarage = 0.0;
            var bigger = 0.0;
            var lower = 0.0;
            var equal = 0.0;

            while (count < 15){
                System.Console.WriteLine($"Insert the {count + 1}º number: ");
                a[count] = System.Convert.ToInt32(System.Console.ReadLine());
                sum += a[count];
                count++;
            }

            avarage = sum/count;
            count = 0;
            while (count < 15){
                if(a[count] < avarage){
                    lower++;
                }
                else if (a[count] > avarage){
                    bigger++;
                }
                else{
                    equal++;
                }  
                count++;  
            }
            System.Console.WriteLine($"The avarage of that array is {avarage} and there are {lower} elements under the avarage, {bigger} elements abouve the avarage and {equal} elementes equals the avarage");
        }

        //Exercise 6
         static void SortedArraysABandC(string[] args)
        {
            int [] a = new int [12];
            int [] b = new int [12];
            int [] c = new int [12];
            var count = 0;

            while (count < 12){
                System.Console.WriteLine("Digit the {0}º number in the A array: ", count+1);
                a[count] = Convert.ToInt32(System.Console.ReadLine());
                count++;
            }
            Array.Sort(a);
                                       
            count = 0;
            while (count < 12){
                System.Console.WriteLine("Digit the {0}º number in the B array: ", count+1);
                b[count] = Convert.ToInt32(System.Console.ReadLine());
                count++;
            }
            Array.Reverse(b);
            
            count = 0;
            while (count < 12){
                c[count] = a[count] + b[count];
                count++;
            }
            Array.Sort(c);
            System.Console.WriteLine(string.Join(" ", c));

        }
    }
}

using System;

namespace second_CSharp_exercises_entra21
{
    class Menu
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha o exercício de 1-6 de interesse:  Pressione Ctrl + C para sair");
                var option = Console.ReadLine();

                if (option == "1")
                {
                    Exercise1.ArrayCMixUp();
                    continue;
                }
                else if (option == "2")
                {
                    Exercise2.PrintingInReverseAndDirectOrder();
                    continue;
                }
                else if (option == "3")
                {
                    Exercise3.IsItInArrayOrNot();
                    continue;
                }
                else if (option == "4")
                {
                    Exercise4.EqualityBetweenArrays();
                    continue;
                }
                else if (option == "5")
                {
                    Exercise5.EqualLowerOrBiggerThanAvarage();
                    continue;
                }
                else if (option == "6")
                {
                    Exercise6.ReorderArrays();
                    continue;
                }
                else
                {
                    Console.WriteLine("Escolha o número correto, por favor!");
                    continue;
                }
            }
        }
    }
}

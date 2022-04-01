using System;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sprawdzenie czy liczba jest pierwsza");
            Console.WriteLine("podaj liczbę");
            int user_number = int.Parse(Console.ReadLine());

            for (int k = 2; k < user_number; k++)
            {
                if (user_number % k == 0)
                {
                    Console.WriteLine($"{user_number} Nie jest to liczba pierwsza");
                    break;
                }
                //break;
                else
                {
                    Console.WriteLine($"{user_number} To jest liczba pierwsza");
                    break;
                }
            }

        }
    }
}

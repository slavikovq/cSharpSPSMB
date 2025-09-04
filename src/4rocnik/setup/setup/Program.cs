using System;

namespace setup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            */
            
            bool gameRunning = true;
            while (gameRunning)
            {
                Console.WriteLine("Write a number between 1 and 100.");
                Random rnd = new Random();
                int generatedNumber = rnd.Next(1, 100);
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == generatedNumber)
                {
                    Console.WriteLine("You are the same number!");
                    gameRunning = false;
                }
                else if(userNumber < 0 || userNumber > 100)
                {
                    Console.WriteLine("You don't have a number between 1 and 100!");
                }
                else
                {
                    Console.WriteLine("You are different numbers!");
                }
            }
        }
    }
}
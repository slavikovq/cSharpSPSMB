using System;
using System.Text.RegularExpressions;

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
            /*
            bool gameRunning = true;
            Random rnd = new Random();
            int generatedNumber = rnd.Next(1, 100);
            while (gameRunning)
            {
                Console.WriteLine("Write a number between 1 and 100.");

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
            */
            Console.Write("Math problem: ");
            string mathProblem = Console.ReadLine();

            string[] splitProblem = Regex.Split(mathProblem, @"\s+");
            double finished = 0;

            foreach (var item in splitProblem)
            {
                Console.WriteLine(item + " &#");
            }

            switch (splitProblem[1])
            {
                case "+":
                    finished = Convert.ToDouble(splitProblem[0]) +  Convert.ToDouble(splitProblem[2]); 
                    break;
                case "-":
                    finished = Convert.ToDouble(splitProblem[0]) - Convert.ToDouble(splitProblem[2]);
                    break;
                case "*":
                    finished = Convert.ToDouble(splitProblem[0]) * Convert.ToDouble(splitProblem[2]);
                    break;
                case "/":
                    finished = Convert.ToDouble(splitProblem[0]) / Convert.ToDouble(splitProblem[2]);
                    break;
                case "**":
                    finished = Math.Pow(Convert.ToDouble(splitProblem[0]), Convert.ToDouble(splitProblem[2]));
                    break;
                default: 
                    Console.WriteLine("Sth went wrong!");
                    break;
            }

            Console.WriteLine($"{splitProblem[0]} {splitProblem[1]} {splitProblem[2]} = {finished}");
            
        }
    }
}
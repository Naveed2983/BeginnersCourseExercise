using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeginnersCourse
{
    public class LoopEx1
    {
        public static void exercise()
        {
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
    public class LoopEx2
    {
        public static void exercise()
        {
            int count = 0;
            Console.WriteLine("Enter a Number or OK: ");
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    Console.WriteLine("Program Terminated");
                    break;
                }
                else
                {
                    count += int.Parse(input);
                }
            }
            Console.WriteLine("Sum is :"+count);
            Console.ReadKey();
        }
    }
    public class LoopEx3
    {
        public static void exercise()
        {
            int Factorial = 1;
            Console.Write("Enter the Number : ");
            var input = int.Parse(Console.ReadLine());

            for (int i = input; i >= 1; i--)
            {
                Factorial *= i;
            }
            Console.WriteLine(Factorial);
            Console.ReadKey();
        }
    }
    public class LoopEx4
    {
        public static void exercise()
        {
            var random = new Random();
            int guessCount = 0;
            var secretNumber = random.Next(0, 10);
            Console.WriteLine(secretNumber);

            Console.Write("Enter your Guess Between 0 - 10 : ");
            while (guessCount <= 4)
            {
                var input = int.Parse(Console.ReadLine());
                if (input == secretNumber)
                {
                    Console.WriteLine("You Guessed it Right!! ");
                    break;
                }
                else
                {
                    Console.WriteLine("Try Again!!");
                }
                guessCount++;
            }
            Console.ReadKey();
        }
    }
    public class LoopEx5
    {
        public static void exercise()
        {
            Console.Write("Enter the numbers Seprated by Commas: ");
            string input = Console.ReadLine();

            int max = int.MinValue;
            string number = "";
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch != ',')
                    number += ch;

                if (ch == ',' || i == input.Length - 1)
                {
                    int current = int.Parse(number);
                    if (max < current)
                    {
                        max = current;
                    }
                    number = "";
                }
            }
            Console.WriteLine("The Largest Number :"+max);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnersCourse
{
    public class Section6Ex1
    {
        public static void exercise()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter Names or Press Enter.");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }
    }
    public class Section6Ex2
    {
        public static void exercise()
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }
    }
    public class Section6Ex3
    {
        public static void exercise()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
    public class Section6Ex4
    {
        public static void exercise()
        {
            var list = new List<int>();
            while (true)
            {
                Console.Write("Enter Number or (Quit) to exit: ");
                var input = (Console.ReadLine());

                if (input.ToLower() == "quit")
                    break;
                list.Add(Convert.ToInt32(input));
            }
            var uniqueNumber = new List<int>();
            foreach (var number in list)
            {
                if (!uniqueNumber.Contains(number))
                {
                    uniqueNumber.Add(number);
                }
            }
            Console.WriteLine("Numbers are: ");
            foreach (var number in uniqueNumber)
                Console.WriteLine(number);
            Console.ReadKey();
        }
    }
    public class Section6Ex5
    {
        public static void exercise()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }

}

/*
    
*/


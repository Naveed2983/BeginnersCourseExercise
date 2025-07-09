using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeginnersCourse
{
    public class Section8Ex1
    {
        public static void exercise()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();
            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
    public class Section8Ex2
    {
        public static void exercise()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }
            if (includesDuplicates)
                Console.WriteLine("Duplicate");
        }
    }
    public class Section8Ex3
    {
        public static void exercise()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var hour = Convert.ToInt32(components[0]);
            var minute = Convert.ToInt32(components[1]);

            if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid Time");
        }
    }
    public class Section8Ex4
    {
        public static void exercise()
        {
            Console.WriteLine("Enter Some Words: ");
            var str = Console.ReadLine();

            if (String.IsNullOrEmpty(str))
            {
                Console.WriteLine("Invalid Words. ");
                return;
            }

            var PascalString = "";
            var str1 = str.Split(' ');
            foreach (var word in str1)
            {
                var Pascalword = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                PascalString += Pascalword;
            }
            Console.WriteLine("Pascal Form is : "+PascalString);


        }
    }
    public class Section8Ex5
    {
        public static void exercise()
        {
            Console.Write("Enter a word: ");
            var input = Console.ReadLine();
            input = input.ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }
            Console.WriteLine("The Vowel Count is: "+vowelsCount);
            Console.ReadKey();
        }

    }

}




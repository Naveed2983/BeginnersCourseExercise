using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnersCourse
{
    public class Exercise1
    {
        public static void exercise()
        {
            Console.Write("Enter your Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Number is Valid.");
            }
            else
            {
                Console.WriteLine("Number is not Valid.");
            }
            Console.ReadKey();
            //Can aslo write like that.
            //Console.WriteLine(number > 0 && number <= 10 ? "Number is Valid " : "Number is not Valid");
        }
    }
    public class Exercise2
    {
        public static void exercise()
        {
            Console.Write("Enter Number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
                Console.WriteLine("Both are Same.");
            else if (number1 > number2)
                Console.WriteLine("Number {0} is Greater", number1);
            else Console.WriteLine("Number {0} is Greater", number2);

            Console.ReadKey();
        }
    }
    public class Exercise3
    {
        public static void exercise()
        {
            Console.Write("Enter the Width of the Image : ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Enter the Height of the Image : ");
            float height = float.Parse(Console.ReadLine());

            if (width == height)
            {
                Console.WriteLine("It is a Square Image. ");
            }
            else if (width > height)
            {
                Console.WriteLine("It is a LandScape Image. ");
            }
            else
            {
                Console.WriteLine("It is a Potrait Image. ");
            }
            Console.ReadKey();
        }
    }
    public class Exercise4
    {
        public static void exercise()
        {
            Console.Write("Enter the Speed Limit: ");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter the Speed of Car: ");
            int speedOfCar = int.Parse(Console.ReadLine());

            if (speedOfCar < speedLimit)
            {
                Console.WriteLine("Speed is Okay!");
            }
            else
            {
                int points = CalculatePoints(speedOfCar, speedLimit);
                if (points > 12)
                    Console.WriteLine("License Suspended as your Points are {0} ", points);
                else
                    Console.WriteLine("Warning Issued!! Your Points are : {0} ", points);
            }
            Console.ReadKey();
        }
        public static int CalculatePoints(int speedOfCar, int speedLimit)
        {
            int points = (speedOfCar - speedLimit) / 5;
            return points;
        }
    }
}

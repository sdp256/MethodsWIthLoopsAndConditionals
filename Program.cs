using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberPrinter();
            NumbersByThree();
            EqualityChecker(67, 88);
            DivisibleByTwo(93);
            IsThisThingNegative(-555);
            CanYouVote();
            InTheZone();
            MultiplicationToTwelve();

        }
        static void MultiplicationToTwelve()
        {
            Console.WriteLine("Gimme another number bro");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] twelveTable = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            foreach (var number in twelveTable)
            {
                Console.WriteLine(x * number);
            }

        }

        static void InTheZone()
        {
            Console.WriteLine("Gimme a number bro");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x  >= -10 && x <= 10)
            {
                Console.WriteLine($"{x} is in the zone... (of -10 to 10)");
            }
            else
            {
                Console.WriteLine($"{x} is not in the zone... (of -10 to 10");
            }

        }
        static void CanYouVote()
        {
            Console.WriteLine("What's your age?");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You're too young to vote go back to school bro");
            }
        }


        static void IsThisThingNegative(int x)
        {
            if (x >= 0)
            {
                Console.WriteLine($"{x} is not negative. It's positive");
            }
            else
            {
                Console.WriteLine($"{x} is negative bro");
            }
        }
        static void DivisibleByTwo(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is an even number");
            }
            else
            {
                Console.WriteLine($"{x} is an odd number");
            }
        }
        static void EqualityChecker(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
            else
            {
                Console.WriteLine($"{x} is not equal to {y}");
            }
        }
        static void NumbersByThree()
        {
            for (int i = 3; i <=999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        static void NumberPrinter()
        {
           
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}

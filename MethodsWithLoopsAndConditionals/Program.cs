using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We're going to do a number of tests.");
            Console.WriteLine("");

            PrintRange();
            Multiples3();

            Console.WriteLine("");
            Console.WriteLine("TEST 3:");
            Console.WriteLine("");
            Console.WriteLine("Enter a number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            int number2 = int.Parse(Console.ReadLine());

            CheckEqual(number1,number2);
            EvenOrOdd();
            PositiveOrNegative();
            VotingAge();
            IntegerRange();
            MultiplicationTable(); 
        }

        static void PrintRange()
        {
            Console.WriteLine("TEST 1:");
            Console.WriteLine("");

            int num = 100;
            while (num > -100)
            {
                Console.WriteLine(num);
                num--;
            }
              
        }

        static void Multiples3()
        {
            Console.WriteLine("");
            Console.WriteLine("TEST 2:");
            Console.WriteLine("");
            for (int i= 3; i <=999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        static void CheckEqual(int number1,int number2)
        {
            
            
            string message = (number1 == number2) ? "The numbers are equal." : "The numbers are not equal.";
            Console.WriteLine(message);
        }

        static void EvenOrOdd()
        {
            Console.WriteLine("");
            Console.WriteLine("TEST 4:");
            Console.WriteLine("");
            Console.WriteLine("Enter another number:");
            int number4 = int.Parse(Console.ReadLine());
            string even = (number4 % 2 == 0) ? "even" : "odd";
            Console.WriteLine($"The number is {even}");
            
        }

        static void PositiveOrNegative()
        {
            Console.WriteLine("");
            Console.WriteLine("TEST 5:");
            Console.WriteLine("");
            Console.WriteLine("Enter another number:");
            int number5 = int.Parse(Console.ReadLine());
            string positive = (number5 >= 0) ? "positive" : "negative";
            Console.WriteLine($"The number is {positive}");
        }

        static void VotingAge()
        {
            Console.WriteLine("");
            Console.WriteLine("TEST 6:");
            Console.WriteLine("");
            Console.WriteLine("Enter a person's age:");
            int number6 = int.Parse(Console.ReadLine());
            string vote = (number6 >= 18) ? "is" : "is not";
            Console.WriteLine($"The person {vote} old enough to vote");
        }

        static void IntegerRange()
        {
            Console.WriteLine("");
            Console.WriteLine("TEST 7:");
            Console.WriteLine("");
            Console.WriteLine("Enter an integer:");
            int number7 = int.Parse(Console.ReadLine());
            string inRange = (number7 >= -10 && number7 <= 10) ? "is" : "is not";
            Console.WriteLine($"That number {inRange} between -10 and 10.");

        }

        static void MultiplicationTable()
        {
            Console.WriteLine("");
            Console.WriteLine("TEST 8:");
            Console.WriteLine("");
            Console.WriteLine("Enter an integer:");
            int number8 = int.Parse(Console.ReadLine());
            for (int i= 1; i <= 12; i++)
            {
                Console.WriteLine($"{number8} x {i} = {number8 * i}");
            }
        }
    }
}

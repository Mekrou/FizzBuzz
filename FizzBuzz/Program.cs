using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int number = 1; number < 101; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                    Console.WriteLine(number);
                        
            }
        }
    }
}

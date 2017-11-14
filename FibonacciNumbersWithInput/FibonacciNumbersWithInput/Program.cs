using FibonacciNumbersWithInput.Properties;
using FibonacciNumbersWithInputUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;

namespace FibonacciNumbersWithInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number (positive) from where the Fibonacci sequence should start");
            string sInputNumberOne = Console.ReadLine();

            Console.WriteLine("Enter second number (positive) from where the Fibonacci sequence should start");
            string sInputNumberTwo = Console.ReadLine();

            BigInteger inputNumberOne = 0;
            BigInteger inputNumberTwo = 0;


            if (!BigInteger.TryParse(sInputNumberOne, out inputNumberOne) || !BigInteger.TryParse(sInputNumberTwo, out inputNumberTwo))
            {
                Error.DisplayErrorAndTerminat("One of the numbers you enter is not a number. Programm will terminate now.");
            }

            Console.WriteLine("Enter how many items in the sequence you want to see");
            string sMaxNumbers = Console.ReadLine();
            int maxNumbers;

            if (!int.TryParse(sMaxNumbers, out maxNumbers))
            {
                Error.DisplayErrorAndTerminat("Maximum number should be an integer. Programm will terminate now.");
            }

            //if (inputNumberOne < 0 || inputNumberTwo < 0)
            //{
            //    Error.DisplayErrorAndTerminat("One of the numbers you enter is less than zero.");
            //}

            //if (!isFibonacci(inputNumberOne) || !isFibonacci(inputNumberTwo))
            //{
            //    Error.DisplayErrorAndTerminat("One of the numbers you added is not Fibonacci number. Programm will terminate now.");
            //}


            //if (maxNumbers < 0)
            //{
            //    Error.DisplayErrorAndTerminat("Maximum number should greater than zero");
            //}

            try
            {
                Febonacci febonacci = new Febonacci(inputNumberOne, inputNumberTwo, maxNumbers);
                febonacci.CalculateAndDisplaySequence();

            }
            catch (Exception e)
            {
                Error.DisplayErrorAndTerminat(e.Message);
            }


            Console.WriteLine("Press any key to quit the programm");
            Console.Read();

        }



    }
}

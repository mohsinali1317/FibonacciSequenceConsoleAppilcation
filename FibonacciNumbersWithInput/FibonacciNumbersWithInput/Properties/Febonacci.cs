using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbersWithInput.Properties
{
    public class Febonacci
    {
        BigInteger inputNumberOne = 0;
        BigInteger inputNumberTwo = 0;

        int maxNumbers;

        public Febonacci(BigInteger inputNumberOne, BigInteger inputNumberTwo, int maxNumbers)
        {
            if (inputNumberOne < 0 || inputNumberTwo < 0)
            {
                throw new Exception("One of the numbers you enter is less than zero. Programm will terminate now.");
            }

            if (!isFibonacci(inputNumberOne) || !isFibonacci(inputNumberTwo))
            {
                throw new Exception("One of the numbers you added is not Fibonacci number. Programm will terminate now.");
            }


            if (maxNumbers < 0)
            {
                throw new Exception("Maximum number should greater than zero. Programm will terminate now.");
            }

            this.inputNumberOne = inputNumberOne;
            this.inputNumberTwo = inputNumberTwo;
            this.maxNumbers = maxNumbers;
        }

        public List<BigInteger> CalculateAndDisplaySequence()
        {
            List<BigInteger> febonacciNumbers = new List<BigInteger>();

            int count = 0;
            BigInteger nextFebonacciNumber = 0;

            while (count < maxNumbers)
            {
                nextFebonacciNumber = 0;
                if (count == 0)
                {
                    febonacciNumbers.Add(inputNumberOne);
                    febonacciNumbers.Add(inputNumberTwo);
                }


                nextFebonacciNumber = inputNumberOne + inputNumberTwo;
                inputNumberOne = inputNumberTwo;
                inputNumberTwo = nextFebonacciNumber;

                febonacciNumbers.Add(nextFebonacciNumber);

                count++;
            }
            DisplaySequence(febonacciNumbers);

            return febonacciNumbers;
        }


        public void DisplaySequence(List<BigInteger> febonacciNumbers)
        {
            Console.WriteLine("Febonacci numbers");
            foreach (BigInteger item in febonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }


        static bool isFibonacci(BigInteger testedNumber, int a = 1, int b = 1)
        {
            if (testedNumber == 0 || testedNumber == 1)
                return true;//returning true for 0 and 1 right away.
            int nextFib = a + b;//getting the next number in the sequence
            if (nextFib > testedNumber)
                return false;//if we have passed the tested number, it's not in the sequence
            else if (nextFib == testedNumber)
                return true;//if we have a perfect match, the tested number is in the sequence
            else
                return isFibonacci(testedNumber, b, nextFib);//otherwise, get the next fibonacci number and repeat.
        }

    }
}

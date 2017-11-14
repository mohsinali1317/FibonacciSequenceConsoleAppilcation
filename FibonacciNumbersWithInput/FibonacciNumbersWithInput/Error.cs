using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FibonacciNumbersWithInputUnitTest
{
    public class Error
    {
        public static void DisplayErrorAndTerminat(string error)
        {
            Console.WriteLine(error);

            int milliseconds = 2000;
            Thread.Sleep(milliseconds);

            Environment.Exit(0);

        }
    }
}

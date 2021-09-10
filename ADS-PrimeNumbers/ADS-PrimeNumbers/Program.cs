using System;
using System.Linq;

namespace ADS_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = new int[1000];

            int number = 1;
            int i = 0;
            Console.WriteLine("Prime Numbers\n");

            while (i < 1000)
            {
                if (IsPrime(number))
                {
                    primes[i] = number;
                    i++;
                }

                number++;
            }
            PrintArray(primes);
        }

        private static void PrintArray(int[] primes)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(primes[i] + " ");
            }
        }

        private static bool IsPrime(int number)
        {
            for (int j = 2; j < number; j++)
            {
                if (number % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
using System;

namespace ADS_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeNumbers = new int[1000];
            int n = 0;
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Console.Write(primeNumbers[n] + " ");
                    n++;
                }
                Console.WriteLine();
            }
        }
    }
}
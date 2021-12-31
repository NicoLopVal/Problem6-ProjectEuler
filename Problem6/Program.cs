using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double result2 = 0;

            for (int i = 1; i <= 100; i++)
            {
                result = result + Math.Pow(i, 2);
                result2 = result2 + i;
                if(i == 100)
                {
                    result2 = Math.Pow(result2, 2);
                }
            }

            Console.WriteLine("the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is: " + (result2 - result));
        }
    }
}

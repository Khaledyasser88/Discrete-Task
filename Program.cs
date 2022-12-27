using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int min, max;

            Console.Write("Please enter first number : ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter second number : ");
            max = Convert.ToInt32(Console.ReadLine());

            Console.Write("The Perfect numbers between the number  is : \n");

            for (int i = min; i <= max; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (sum == i)
                    Console.WriteLine(" {0} ", i);

                  Console.ReadKey();
  

            }
        }
    }
}

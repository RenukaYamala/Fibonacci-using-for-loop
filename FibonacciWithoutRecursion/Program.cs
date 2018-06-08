using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciWithoutRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, nthFibonacci, fibonacci1 = 0, fibonacci2 = 1, fibonacci3=0;
            Console.Write("Enter the Limit");
            nthFibonacci = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci1);
            Console.WriteLine(fibonacci2);
            for (i = 0; i <= nthFibonacci; i++)
            {
                fibonacci3 = fibonacci1 + fibonacci2;
                Console.WriteLine(fibonacci3);
                fibonacci1 = fibonacci2;
                fibonacci2 = fibonacci3;
            }
            Console.ReadLine();

        }

    }
}

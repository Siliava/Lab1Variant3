using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Variant3
{
    class Program
    {
        static long Fact(long value)
        {
            return (value == 0) ? 1 : value * Fact(value - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            double r = 0;

            for (int n = 0; n <= k; n++)
                r += Math.Pow(x, n) / Fact(n);

            Console.WriteLine("Результат = {0}", r.ToString());
            Console.ReadKey();
        }
    }
}
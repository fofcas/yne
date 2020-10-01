using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variant_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                const double b = 0.4;
                Console.WriteLine("y = e^2x + 9.7^c");
                Console.WriteLine("c = a^2 + (b*x)^1/2");
                Console.WriteLine("a = lg(x)");
                Console.WriteLine("b = " + b);
                Console.WriteLine("Введите число х:");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("x = " + x);
                double a = Math.Log10(x);
                double c = Math.Pow(a, 2) + Math.Sqrt(b * x);
                double y = Math.Exp(2 * x) + Math.Pow(9.7, c);
                Console.WriteLine("y = e^2x + 9.7^c");
                Console.WriteLine("c = a^2 + (b*x)^1/2");
                Console.WriteLine("a = lg(x)");
                Console.WriteLine("a = lg(" + x + ")");
                Console.WriteLine("c = " + a + "^2 + (" + b + "*" + x + ")^1/2");
                Console.WriteLine("y = e^2" + x + "+ 9.7^" + c);
                Console.WriteLine("y =" + y);
            }
            catch (Exception e)
            {
                ;
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
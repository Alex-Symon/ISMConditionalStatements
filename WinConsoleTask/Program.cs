using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            try
            {
                Console.WriteLine("Значення x = ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Значення y = ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Значення z = ");
                z = double.Parse(Console.ReadLine());
                double r = (2 * Math.Cos(x * x) - 1 / 2.0) / (1 / 2.0 + Math.Sin(Math.Pow(y, 2 - z))) + z * z / (7 - z / 3);
                Console.WriteLine("{0}", r);
            }
            catch {
                Console.WriteLine("Помилка введення");
            }
            Console.ReadKey();
        }
    }
}

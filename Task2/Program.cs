using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите размер грани куба");
            double v = 0;
            double s = 0;
            var a = Convert.ToDouble(Console.ReadLine());
            CalculateParams(a, out v, out s);
            Console.WriteLine($"Площадь куба равна {s}, объем куба равен {v}");
            Console.ReadKey();
        }


        static void CalculateParams(double a, out double v, out double s)
        {
            v = a * a * a;
            s = 6 * a * a;
        }
    }
}

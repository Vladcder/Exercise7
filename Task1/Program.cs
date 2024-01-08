using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] squares = new double[2];
            double a;
            double b ;
            double c;

            for (int i = 0; i < squares.Length; i++)
            {
                Console.WriteLine($"Введите размеры сторон треугольника {i+1}");
                 a = Convert.ToDouble(Console.ReadLine());
                 b = Convert.ToDouble(Console.ReadLine());
                 c = Convert.ToDouble(Console.ReadLine());
                if (CheckTriangel(a, b, c))
                {
                    squares[i] = CalcTriangleSquare(a, b, c);
                }
                else
                {
                    Console.WriteLine("Треугольник не возможный");
                    Console.ReadKey();
                    return;
                }
            }
       if (squares[0] > squares[1])
            {
                Console.WriteLine("Первый треугольник больше");
            }
       else if (squares[0] < squares[1])
            {
                Console.WriteLine("Второй треугольник больше");
            }
       else
            {
                Console.WriteLine("Треугольники равны");
            }

       Console.ReadKey();
        }

        static double CalcTriangleSquare(double x, double y, double z) 
        {
            double p = x + y + z;
            double halfP = p / 2;
            var sq= Math.Sqrt(halfP * (halfP - x) * (halfP - y) * (halfP - z));
            return sq;
        }

        static bool CheckTriangel(double x, double y, double z)
        {
            if (x+y>z&&y+z>x&&x+z>y)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
    }
}

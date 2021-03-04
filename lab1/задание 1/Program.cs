using System;
using System.Numerics;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите коэффициент при х^3: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите коэффициент при х^2: ");
            double a = Convert.ToDouble(Console.ReadLine()) / d;
            Console.WriteLine("введите коэффициент при х: ");
            double b = Convert.ToDouble(Console.ReadLine()) / d;
            Console.WriteLine("введите свободный коэффициент: ");
            double c = Convert.ToDouble(Console.ReadLine()) / d;
            Console.WriteLine("\n"+d +"x^3+("+a*d+"x^2)+("+b*d+"x)+("+c*d+")=0\n");
            double p = a * a / 3 - a * a * 2 / 3 + b;
            double q = -a * a * a / 27 + a * a * a / 9 - a * b / 3 + c;
            Console.WriteLine("промежуточные коэффициенты: ");
            Console.WriteLine("p=" + p + " q=" + q);
            double D = q * q / 4 + p * p * p / 27;
            Console.WriteLine("D=" + D);
            if (D > 0)
            {
                double u1 = -q / 2.0 + Math.Sqrt(D);
                double u2 = -q / 2.0 - Math.Sqrt(D);
                Complex a1 = new Complex(p / 3, 0);
                if (u1 > 0)
                {
                    double x1 = Math.Pow(u1, 1.0 / 3.0) - Math.Pow(-u2, 1.0 / 3.0);
                    Complex x2 = new Complex(Math.Pow(u1, 1 / 3.0) * Math.Cos(2 * Math.PI / 3), Math.Pow(u1, 1 / 3.0) * Math.Sin(2 * Math.PI / 3));
                    Complex x3 = new Complex(Math.Pow(u1, 1 / 3.0) * Math.Cos(4 * Math.PI / 3), Math.Pow(u1, 1 / 3.0) * Math.Sin(4 * Math.PI / 3));
                    x2 = Complex.Subtract(x2, Complex.Divide(a1, x2));
                    x3 = Complex.Subtract(x3, Complex.Divide(a1, x3));
                    x1 -= a / 3.0;
                    x2 -= a / 3.0;
                    x3 -= a / 3.0;
                    Console.WriteLine("\nкорни данного уравнения\nx1=" + x1 + "\nx2=" + x2 + "\nx3=" + x3);
                }
                else
                {
                    double x1 = -Math.Pow(-u1, 1.0 / 3.0) - Math.Pow(-u2, 1.0 / 3.0);
                    Complex x2 = new Complex(-Math.Pow(-u1, 1 / 3.0) * Math.Cos(2 * Math.PI / 3), -Math.Pow(-u1, 1 / 3.0) * Math.Sin(2 * Math.PI / 3));
                    Complex x3 = new Complex(-Math.Pow(-u1, 1 / 3.0) * Math.Cos(4 * Math.PI / 3), -Math.Pow(-u1, 1 / 3.0) * Math.Sin(4 * Math.PI / 3));
                    x2 = Complex.Subtract(x2, Complex.Divide(a1, x2));
                    x3 = Complex.Subtract(x3, Complex.Divide(a1, x3));
                    x1 -= a / 3.0;
                    x2 -= a / 3.0;
                    x3 -= a / 3.0;
                    Console.WriteLine("\nкорни данного уравнения\nx1=" + x1 + "\nx2=" + x2 + "\nx3=" + x3);
                }
            }
            else
            {
                double x1 = -Math.Cos(1 / 3.0 * Math.Acos(q / 2 / Math.Pow(-p / 3.0, 3 / 2.0)) + 2 * Math.PI / 3 * 0) * Math.Sqrt(-4 * p / 3.0) - a / 3.0;
                double x2 = -Math.Cos(1 / 3.0 * Math.Acos(q / 2 / Math.Pow(-p / 3.0, 3 / 2.0)) + 2 * Math.PI / 3 * 1) * Math.Sqrt(-4 * p / 3.0) - a / 3.0;
                double x3 = -Math.Cos(1 / 3.0 * Math.Acos(q / 2 / Math.Pow(-p / 3.0, 3 / 2.0)) + 2 * Math.PI / 3 * 2) * Math.Sqrt(-4 * p / 3.0) - a / 3.0;
                Console.WriteLine("\nкорни данного уравнения\nx1=" + x1 + "\nx2=" + x2 + "\nx3=" + x3);
            }
            Console.ReadLine();
        }
    }
}
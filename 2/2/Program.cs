using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static double Segment1(double x)
        {
            return -3;
        }
        static double Segment2(double x)
        {
            return 5/8f * x + 2; 
        }
        static double Segment3(double x, double r)
        {
            double y;
            y = Math.Sqrt(r * r - (x - 0) * (x - 0)) - 0;
            return -y;
        }
        static double Segment4(double x)
        {
            return 1 * x - 3;
        }
        static double Segment5(double x)
        {
            return 3;
        }
        static void Main(string[] args)
        {
            double y;
            double r = 0;
            Console.WriteLine("Пожалуйста введите значение радиуса r");
            r = Convert.ToDouble(Console.ReadLine());
            for (double x = -10; x <= 8; x += 0.2)
            {
                if (x < -10)
                {
                    Console.WriteLine("Функция не определенна");
                }
                else if (x < -8)
                {
                    Console.WriteLine("y({0:0.00} = {1:0.00})", x, Segment1(x));
                }
                else if (x < -3)
                {
                    Console.WriteLine("y({0:0.00} = {1:0.00})", x, Segment2(x));
                }
                else if (x < 3)
                {
                    Console.WriteLine("y({0:0.00} = {1:0.00})", x, Segment3(x, r));
                }
                else if (x < 5)
                {
                    Console.WriteLine("y({0:0.00} = {1:0.00})", x, Segment4(x));
                }
                else if (x < 8)
                {
                    Console.WriteLine("y({0:0.00} = {1:0.00})", x, Segment5(x));
                }
            }
            Console.ReadKey();
        }
    }
}

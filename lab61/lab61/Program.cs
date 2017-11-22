using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab61
{
    class Program
    {
        delegate double Average(int p1, int p2, int p3);
        static double Arif(int a1, int a2, int a3)
        {
            return (a1 + a2 + a3) / 3;
        }

        static void PrintAverage(int i1, int i2, int i3, Average AvParam)
        {
            Console.WriteLine("среднее от {0}, {1}, {2} = {3}", i1, i2, i3, AvParam(i1, i2, i3));
        }
        static void PrintAverageFunc(int i1, int i2, int i3, Func<int,int,int,double> AvParam)
        {
            Console.WriteLine("среднее от {0}, {1}, {2} = {3}", i1, i2, i3, AvParam(i1, i2, i3));
        }

        static void Main()
        {
            Console.WriteLine("Делегат Average\nделегат с готовым методом: ср. ариф.");
            PrintAverage(1, 2, 3, Arif);
            Console.WriteLine("делегат с лямбда-выражением: ср. геом.");
            PrintAverage(1, 8, 27, (x, y, z) => Math.Pow(x*y*z, 1.0 / 3.0));
            Console.WriteLine("Делегат Func<>\nделегат с готовым методом: ср. ариф.");
            PrintAverage(1, 2, 3, Arif);
            Console.WriteLine("делегат с лямбда-выражением: ср. геом.");
            PrintAverage(1, 8, 27, (x, y, z) => Math.Pow(x * y * z, 1.0 / 3.0));
        }
    }
}

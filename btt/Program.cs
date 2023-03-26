using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("kq: " + tinh(a,b,y));
            Console.ReadLine();
        }
        public static double tinh(double a, double b,double y)
        {
            return (double) ((y - b) / a); 
        }
    }
}

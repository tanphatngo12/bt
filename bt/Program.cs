using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            double gt = 1;
            for (int i = 2; i <= n; i++)
            {
                gt = gt *= i;
            }
            Console.WriteLine("Tong: " + gt);
            Console.ReadLine();
        }
    }
}

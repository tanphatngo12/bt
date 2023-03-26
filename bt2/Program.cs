using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Nhap so nguyen n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                sum = sum + i;
                Console.WriteLine(" " + i);
            }
            Console.WriteLine("Tong la" + sum);
            Console.ReadLine();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Escape);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Nhap so nguyen to n");
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadLine();
            /* ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Escape); */
        }
    }
}

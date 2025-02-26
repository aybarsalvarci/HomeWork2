using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 346;

            int toplam = 0;

            for(; number > 0; number /= 10)
            {
                toplam += number % 10;
            }

            Console.WriteLine(toplam);
        }
    }
}

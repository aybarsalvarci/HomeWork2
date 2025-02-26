using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("1-100 aralığında bir sayı girin: ");

                int number = Convert.ToInt32(Console.ReadLine());

                if(number <= 100 && number >= 1)
                {
                    Console.WriteLine($"Sayı: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("Girilen sayı 1-100 aralığında olmalıdır.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kaç adet sayı girilecek: ");
            int maxLength = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>();
            int top = 0;
            for(int i = 0; i < maxLength; i++)
            {
                Console.Write("Sayı girin: ");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
                top += number;
            }

            numbers.Sort();

            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Ortalama = {top / numbers.Count()}");
        }
    }
}

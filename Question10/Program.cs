using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Numbers = new List<int> { 1, 5, 7, 3, 4, 7, 23, 66 };

            Numbers.RemoveAll(n => n < 10);

            foreach (int Number in Numbers)
            {
                Console.WriteLine(Number);
            }
        }
    }
}

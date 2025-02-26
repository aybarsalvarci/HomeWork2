using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 4, 4, 3, 2, 4 };

            int repeated = 0;
            int maxCount = 0;

            for (int i = 0; i < numbers.Count(); i++)
            {
                int selfCount = 0;

                for (int j = 0; j < numbers.Count(); j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        selfCount++;
                    }
                }

                if(selfCount > maxCount)
                {
                    maxCount = selfCount;
                    repeated = numbers[i];
                }
            }

            Console.WriteLine($"{repeated}, {maxCount} kez tekrar etti.");
        }
    }
}

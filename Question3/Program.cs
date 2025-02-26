using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> agesOfPersons = new List<int>();


            while (true)
            {
                Console.Write("Yaş giriniz: (q ile iptal)");
                string input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }

                agesOfPersons.Add(Convert.ToInt32(input));
            }


            foreach(int age in agesOfPersons)
            {
                if(age > 0 && age <= 12)
                {
                    Console.WriteLine("Çocuk");
                }
                else if(age > 12 && age <= 19)
                {
                    Console.WriteLine("Genç");
                }
                else if (age > 20 && age <= 64)
                {
                    Console.WriteLine("Yetişkin");
                }
                else if (age >= 65)
                {
                    Console.WriteLine("Yaşlı");
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle giriniz: ");
            string sentence = Console.ReadLine();

            string[] Words = sentence.Split(' ');

            for(int i = Words.Count() - 1; i >= 0; i--)
            {
                Console.WriteLine(Words[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Notes = new List<int> { 32, 17, 5, 67, 88, 95, 61};

            for (int i = 0; i < Notes.Count(); i++)
            {
                if (Notes[i] < 50)
                {
                    Notes[i] = 50;
                }
            }


            foreach (var Note in Notes)
            {
                Console.WriteLine(Note);
            }
        }
    }
}

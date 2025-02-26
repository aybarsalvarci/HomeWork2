using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Words = new List<string> { "Lorem", "Ipsum", "is", "simply", "dummy", "text", "typesetting", "industry" };

            int? MinLength = null;
            int? MaxLength = null;
            string Shortest = "";
            string Longest = "";

            foreach(string word in Words)
            {
                if(MinLength == null || word.Length < MinLength)
                {
                    MinLength = word.Length;
                    Shortest = word;
                }

                if (MaxLength == null || word.Length > MaxLength)
                {
                    MaxLength = word.Length;
                    Longest = word;
                }
            }

            Console.WriteLine($"En uzun kelime {Longest}({MaxLength})\nEn kısa kelime {Shortest}({MinLength})");
        }
    }
}

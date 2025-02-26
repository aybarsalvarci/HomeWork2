using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Strings = { "Aybars", "Hasan", "Şalvarcı" };

            Strings = AppendToArray(Strings, "test");

            foreach (var item in Strings)
            {
                Console.WriteLine(item);
            }

        }
        
        static string[] AppendToArray(string[] array, string ElementToAppend)
        {
            int newSize = array.Count() + 1;
            string[] newArray = new string[newSize];
            Array.Copy(array, newArray, array.Count());
            newArray[newSize - 1] = ElementToAppend;

            return newArray;
            
        }
    }
}

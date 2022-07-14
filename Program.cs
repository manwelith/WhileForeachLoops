using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Foreach_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 78, 3, 35, 6, 8 };
            int toplam = 0;
            int index = 0;
            while (index < numbers.Length)
            {
               toplam+=numbers[index];

                index++;                          
            }
            Console.WriteLine(toplam);         
            Console.ReadLine();
        }
        static void ForEachLoop()
        {
            int[] numbers = { 2, 4, 6, 78, 3, 35, 6, 8 };

            int toplam = 0;
            foreach (int i in numbers)
            {
                toplam += i;
            }

            Console.WriteLine(toplam);         
        }
    }
}

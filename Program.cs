using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTDL;
using System.IO;

namespace CTDL
{
    class Program
         
    {
        public static string filepath = "d:\\hex_numbers.txt";
        public static string sortedfile = "d:\\sorted_numbers.txt";
        static void Main(string[] args)
        {
            int[] X = Business.ReadHexNumbers(filepath);
            Business.SelectionSort(ref X);
            Business.writeHexNumbers(X);
            Business.binarySearch(X);
            Console.ReadKey();
        }
    }
}

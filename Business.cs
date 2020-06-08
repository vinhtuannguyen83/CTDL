using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL
{
    
    class Business
     {
        public static string sortedfile = "d:\\sorted_numbers.txt";
        public static int []  ReadHexNumbers(string filepath)
        {
                    
            string[] M = File.ReadAllLines(filepath);
            string [] A = M[0].Split(' ');
            int[] b = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                b[i] = Convert.ToInt32(A[i],16);
            }
            return b;
        }
        public static void swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            
        }
        public static void Hienthimang(int []a) //để debug
        {
            foreach (var element in a)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n\n");
        }

        public static void SelectionSort(ref int[] a)
        {
            int min = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }

                }
                if (min != i)
                    swap(ref a[i], ref a[min]);
            }
            
        }
        public static void writeHexNumbers(int[]a)
        {
            string[] b = new string[a.Length];
            string s= string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i].ToString("X");
                s = s + b[i]+" ";
            }
            
            File.WriteAllText(sortedfile,s);
        }
        public static void binarySearch(int []a)

        {
            
            int x;
            int left = 0;
            int right = a.Length - 1;
            int mid;
            Console.WriteLine(" Nhap gia tri x can tim");
            x = int.Parse(Console.ReadLine());
            string s = $"Khong tim thay {x} trong mang";
            while (left<=right)
            {
                mid = (left + right) / 2;
                if (a[mid] == x)
                {
                   s= $" Tim dc {x} tai vi tri {mid}";
                    break;
                }
                if( a[mid] <x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine(s);
        }
    }
}

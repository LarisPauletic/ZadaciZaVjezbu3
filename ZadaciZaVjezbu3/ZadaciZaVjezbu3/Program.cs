using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciZaVjezbu3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 3, 8, 5, 9, 6, 2, 0, 4, 1 };

            Sort x = new Sort();
            x.QuickSort(arr, 1, arr.Length - 2);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            Console.ReadKey();
        }
    }
}

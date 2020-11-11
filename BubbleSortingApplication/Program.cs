using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, 12, 14, 15, 32, 15, 11, 1, 8, 9 };
            int temp;
            Console.WriteLine("before sorting");
            foreach (int p in arr)
            {
                Console.WriteLine(p + " ");
            }
            for (int j = 0; j <= arr.Length-2; j++)
            {
                for (int i = 0; i <= arr.Length-2; i++)
                {
                    if (arr[i]>arr[i+1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("after sorting");
            foreach (int p in arr)
            {
                Console.WriteLine(p+ " ");
            }
        }
    }
}

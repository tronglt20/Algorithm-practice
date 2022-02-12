using System;

namespace Insertion_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 10, 5, 8 };

            for(int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;
                while(j >= 0 && current < arr[j] )
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = current;

            }

            Console.WriteLine("Sorted");
            foreach (int item in arr)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadLine();
        }
    }
}

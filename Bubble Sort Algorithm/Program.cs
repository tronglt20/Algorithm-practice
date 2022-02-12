using System;

namespace Bubble_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };

            int temp;

            for(int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(j) ;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231012_exercise_3
{
    class Program
    {
        static void SortElements(int[] arr)
        {
            int storage = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        storage = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = storage; 
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sort elements of array in ascending order:");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Input the number of elements to be stored in the array: ");
            int arraylen = int.Parse(Console.ReadLine());

            int[] array = new int[arraylen];

            Console.WriteLine("Input " + arraylen + " element in the array:");

            for(int i = 0; i < arraylen; i++)
            {
                Console.Write("element - " + i + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            SortElements(array);

            Console.WriteLine("Elements of array in sorted ascending order: ");

            for(int i = 0; i < arraylen; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
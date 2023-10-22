using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231012_exercise_2
{
    class Program
    {
        static int CountDuplicateElements(int[] arr)
        {
            int count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Count total number of duplicate elements in an array:");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Input the number of elements to be stored in the array:");
            int arrlen = int.Parse(Console.ReadLine());

            int[] array = new int[arrlen];

            Console.WriteLine("Input " + arrlen + " element in the array:");

            for(int i = 0; i < arrlen; i++)
            {
                Console.Write("element - " + i + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int duplicateElements = CountDuplicateElements(array);

            Console.Write("The number of duplicate elements is: " + duplicateElements);
        }
    }
}
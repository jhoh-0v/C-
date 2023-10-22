using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231012_exercise_5
{
    class Program
    {
        static int SumofElementsinArray(int[] arr)
        {
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Funtion: Calculate the sum of the elements in an array:");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Input the number of elements to be stored in the array:");
            int arraylen = int.Parse(Console.ReadLine());

            int[] array = new int[arraylen];

            Console.WriteLine("Input " + arraylen + " element in the array:");

            for(int i = 0; i < arraylen; i++)
            {
                Console.Write("element - " + i + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int SumofElements = SumofElementsinArray(array);

            Console.Write("The sum of the elements of the array is: " + SumofElements);
        }
    }
}
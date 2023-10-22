using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231012_exercise_1
{
    class Program
    {
        static int FindMin(int a, int b)
        {
            return (a < b) ? a : b;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int min = FindMin(num1, num2);
            Console.Write("The smaller number is: " + min);
        }
    }
}
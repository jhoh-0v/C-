using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231012_exercise_4
{
    class Program
    {
        static void Pattern(int ptrn)
        {
            int num = 1;

            for(int i = 0; i <= ptrn; i++)
            {
                for(int j = 0; j < ptrn - i; j++)
                {
                    Console.Write(" ");
                }

                for(int k = 0; k < i; k++)
                {
                    Console.Write(num + " ");
                    num++;
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("input number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Pattern(rows);
        }
    }
}
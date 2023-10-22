using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230926_encapsulation_2{

    internal class MathFunctions{

        internal int Add(int a, int b){
            return a + b;
        }

        internal int Subtract(int a, int b){
            return a - b;
        }

        internal int Multiply(int a, int b){
            return a * b;
        }

        internal double Divide(int a, int b){
            if(b != 0){
                return (double)a / b;
            }

            else{
                throw new DivideByZeroException("YOU CAN'T DIVIDE BY 0");
            }
            
        }
    }

    class Program{

        static void Main(){

            Console.Write("Enter the value of a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of a: ");
            int b = int.Parse(Console.ReadLine());

            MathFunctions math = new MathFunctions();

            int AddResult = math.Add(a, b);
            int SubResult = math.Subtract(a, b);
            int MulResult = math.Multiply(a, b);

            Console.WriteLine("Add:" + AddResult);
            Console.WriteLine("Substract: " + SubResult);
            Console.WriteLine("Multiply: " + MulResult);

            try{
                double DivResult = math.Divide(a, b);
                Console.WriteLine("Divide: " + DivResult);
            }

            catch (DivideByZeroException ex){
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}
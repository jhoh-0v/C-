using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230921_practice_1{

    class Voing_Eligibillty_Checker{

        static void Main(string[] args){

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if(age >= 18){
                Console.WriteLine("You eligible to vote.");
            }

            if(age < 18){
                Console.WriteLine("You NOT eligible to vote.");
            }

            Console.ReadKey();
        }
    }
}
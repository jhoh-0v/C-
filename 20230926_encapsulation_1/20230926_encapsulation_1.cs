using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230926_encapsulation_1{

    public class Animal{

        protected string name;

        public Animal(string name){
            this.name = name;
        }
    }

    public class Cat : Animal{

        public Cat(string name) : base(name){}

        public string GetName(){
            return name;
        }
    }

    class Program{
        static void Main(string[] args){

            Cat myCat = new Cat("cat");

            Console.WriteLine("cat name: " + myCat.GetName());
        }
    }
}
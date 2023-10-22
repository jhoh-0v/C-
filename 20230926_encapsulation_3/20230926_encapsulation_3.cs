using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230926_encapsulation_3
{
    class Shape{

        protected internal double CalculateArea(){
            return 0;
        }
    }

    class Rectangle : Shape{

        private double width;
        private double height;

        public Rectangle(double width, double height){

            this.width = width;
            this.height = height;
        }

        public double GetRectangleArea(){
            return width * height;
        }
    }

    class Circle : Shape{

        private double radius;

        public Circle(double radius){
            this.radius = radius;
        }

        public double GetCircleArea(){
            return Math.PI * radius * radius;
        }
    }

    class Program{

        static void Main(){

            Rectangle rectangle = new Rectangle(3, 4);
            double rectangleArea = rectangle.GetRectangleArea();
            Console.WriteLine("Area of Rectangle: " + rectangleArea);

            Circle circle = new Circle(3);
            double circleArea = circle.GetCircleArea();
            Console.WriteLine("Area of Circle: " + circleArea);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230921_practice_5{

    class Robot_Grid_Movement_with_a_While_Loop{

        public static void Main(string[] args){

            int x = 0;
            int y = 0;
            
            Console.WriteLine("Welcome to the Robot Grid Movement Simulator!");

            Console.Write("Enter the target X-coordinate: ");
            int x_input = int.Parse(Console.ReadLine());

            Console.Write("Enter the target Y-coordinate: ");
            int y_input = int.Parse(Console.ReadLine());

            Console.WriteLine("Simulating Robot Movement...");

            Control(x, x_input, y, y_input);
        }

        public static void Control(int x, int x_input, int y, int y_input){

            while (true){
                if (x != x_input){
                    if (x < x_input){
                        x++;
                        Console.WriteLine("Robot moves right: (" + x + "," + y + ")");
                    }

                    else{
                        x--;
                        Console.WriteLine("Robot moves left: (" + x + "," + y + ")");
                    }
                }

                if (y != y_input){
                    if (y < y_input){
                        y++;
                        Console.WriteLine("Robot moves up: (" + x + "," + y + ")");
                    }

                    else{
                        y--;
                        Console.WriteLine("Robot moves down: (" + x + "," + y + ")");
                    }
                }

                else{
                    Console.WriteLine("Robot reached the target: (" + x + "," + y + ")");
                    break;
                }
            }
        }
    }
}
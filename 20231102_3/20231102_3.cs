using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231102_3
{
    class Robot
    {
        internal string name;
        private float battery = 100.0f;
        private int x = 0;
        private int y = 0;

        internal Robot(string name)
        {
            this.name = name;
        }

        internal void charge()
        {
            battery = 100.0f;
        }

        internal void say_hello()
        {
            Console.WriteLine("Hello, I am " + name + " Bot!");
        }

        internal float get_battery()
        {
            return battery;
        }

        internal void move(int distance, string direction)
        {
            if (direction.ToLower() == "right")
            {
                x += distance;
            }

            else if (direction.ToLower() == "left")
            {
                x -= distance;
            }

            if (direction.ToLower() == "up")
            {
                y += distance;
            }

            else if (direction.ToLower() == "down")
            {
                y -= distance;
            }

            battery -= distance * 10;
        }

        internal string get_location()
        {
            return "(" + x + ", " + y + ")";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Robot myBot = new Robot("Robo");

            int number_of_moves;

            Console.Write("Enter the number of moves for the robot: ");
            number_of_moves = int.Parse(Console.ReadLine());
            Console.WriteLine();

            myBot.say_hello();

            Console.WriteLine("Current Battery Level: " + myBot.get_battery() + "\n");

            int Distance = 0;
            string Direction = string.Empty;

            for (int movement = 1; movement <= number_of_moves; movement++)
            {
                distanceERROR:
                batteryERROR:

                Console.Write("Enter distance to move for move " + movement + ":");
                try
                {
                    Distance = int.Parse(Console.ReadLine());
                }

                catch (System.FormatException)
                {
                    Console.WriteLine("ERROR: WRONG DISTANCE\n");

                    goto distanceERROR;
                }

                if (myBot.get_battery() >= Distance * 10)
                {
                    directionERROR:

                    Console.Write("Enter direction to move (up, down, left, right) for move " + movement + ": ");
                    Direction = Console.ReadLine();

                    if (Direction.ToLower() == "up" || Direction.ToLower() == "down" || Direction.ToLower() == "left" || Direction.ToLower() == "right")
                    {
                        myBot.move(Distance, Direction);
                    }

                    else
                    {
                        Console.WriteLine("ERROR: WRONG DIRECTION\n");

                        goto directionERROR;
                    }
                }

                else
                {
                    Console.WriteLine("ERROR: INSUFFICIENT BATTERY\n");

                    goto batteryERROR;
                }
                
                Console.WriteLine(myBot.name + " Bot has moved " + Distance + " units " + Direction + ". Battery reduced to " + myBot.get_battery() + "\n");
            }

            Console.WriteLine("Current Location " + myBot.get_location() + "\n");

            myBot.charge();
            Console.WriteLine(myBot.name + " Bot has been charged. Battery level is now " + myBot.get_battery());

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeLadderGame
    {
        public void SnakeLadder()
        {
            int Position = 0;
            int count = 0;
            int[] Players = { 1, 2 };

            Console.Write("Press Enter to Start to play : ");
            string start = Console.ReadLine();

            Console.WriteLine("Number of Players : " + Players.Length);
            Console.WriteLine("Player 1 at position : " + Position);

            Random random = new Random();

            while (Position != 100)
            {
                for (int i = 0; i < Players.Length; i++)
                {
                    Console.WriteLine("Player " + Players[i] +" turn");

                    int DiceNumber1 = random.Next(1, 7);
                    Console.WriteLine("Player rolled the Die ....");
                    Console.WriteLine("Dies turns to : " + DiceNumber1);

                    int Option1 = random.Next(1, 4);

                    switch (Option1)
                    {
                        case 1:
                            Console.WriteLine("you are at No Play option");
                            Console.WriteLine("Current Position: " + Position + "\n");
                            break;

                        case 2:
                            Console.WriteLine("you Get Move Ahead option");
                            Console.WriteLine("Great! You get to Move Ahead, By " + DiceNumber1);
                            Position +=DiceNumber1;
                            Console.WriteLine("Current Position: " + Position + "\n");
                            if (Position > 100)
                            {
                                Position -= DiceNumber1;
                                Console.WriteLine("Cannot Move Forward Remains in Same Position : " + Position + "\n");
                            }
                            break;

                        case 3:
                            Console.WriteLine("But you get Move back option");
                            Console.WriteLine("Oops! you Need to Move Back, By" + DiceNumber1);
                            Position -= DiceNumber1;
                            Console.WriteLine("Current Position: " + Position + "\n");
                            if (Position < 0)
                            {
                                Console.WriteLine("Please Restart");
                                Position = 0;
                                continue;
                            }
                            break;
                    }

                    if (Position == 100)
                    {
                        Console.WriteLine("\n**************** Playar : " + Players[i] + " *********************\n");
                        break;
                    }
                    count++;
                }
            }
            Console.WriteLine("Total Number of Times Dies Role is : " + count);
        }
    }
}

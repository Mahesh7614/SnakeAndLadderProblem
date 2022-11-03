using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeLadderGame
    {
        int Position1 = 0;
        int Position2 = 0;
        int NoOfDiceRolled = 0;
        int[] Players = { 1, 2 };
        bool IsPlayer1 = true;
        Random random = new Random();
        public void SnakeLadder()
        {
            Console.Write("Press Enter to Start to play : ");
            string start = Console.ReadLine();

            Console.WriteLine("Number of Players : " + Players.Length);
            Console.WriteLine("Player 1 at position : " + Position1);
            Console.WriteLine("Player 2 at position : " + Position2);

            

            while (Position1 != 100 || Position2 !=100)
            {
                int i = 0;
                while ( i < Players.Length)
                {
                    Play(ref i);
                    
                }
                if (Position1 == 100 || Position2 == 100)
                {
                    Console.WriteLine("\n**************** Playar : " + (Position1 == 100 ? " 1" : " 2") + " Wins *********************\n");
                    break;
                }

            }
            Console.WriteLine("Total Number of Times Dies Role is : " + NoOfDiceRolled);
        }
        public void Play(ref int i)
        {
            Console.WriteLine("Player " + Players[i] + " turn");
            int DiceNumber1 = random.Next(1, 7);
            Console.WriteLine("Player rolled the Die ....");
            Console.WriteLine("Dies turns to : " + DiceNumber1);

            int Option = random.Next(1, 4);

            switch (Option)
            {
                case 1:
                    Console.WriteLine("you are at No Play option");

                    break;

                case 2:
                    Console.WriteLine("you Get Move Ahead option");
                    Console.WriteLine("Great! You get to Move Ahead, By : " + DiceNumber1);
                    if (Players[i] == 1)
                    {
                        Position1 += DiceNumber1;
                        if (Position1 > 100)
                        {
                            Position1 -= DiceNumber1;
                            Console.WriteLine("Cannot Move Forward Remains in Same Position : " + Position1 + "\n");
                        }
                    }
                    else if(Players[i] == 2)
                    {
                        Position2 += DiceNumber1;
                        if (Position2 > 100)
                        {
                            Position2 -= DiceNumber1;
                            Console.WriteLine("Cannot Move Forward Remains in Same Position : " + Position2 + "\n");
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("But you get Move back option");
                    Console.WriteLine("Oops! you Need to Move Back, By : " + DiceNumber1);
                    if (Players[i] == 1)
                    {
                        Position1 -= DiceNumber1;
                        if (Position1 < 0)
                        {
                            Console.WriteLine("Please Restart");
                            Position1 = 0;
                        }
                    }
                    else if (Players[i] == 2)
                    {
                        Position2 -= DiceNumber1;
                        if (Position2 < 0)
                        {
                            Console.WriteLine("Please Restart");
                            Position2 = 0;
                        }
                    }
                    break;
            }
            Console.WriteLine("Player 1 Position : " + Position1 );
            Console.WriteLine("Player 2 Position : " + Position2 );
            Console.WriteLine("-----------------------------------------\n");
            i++;
            if (Option == 2 && i == 1 && Position1 != 100 && Position2 !=100)
            {
                i = 0;
                Console.WriteLine("Player " + Players[i] + " Plays again");
            }
            if (Option == 2 && i == 2 && Position2 != 100 && Position1 !=100)
            {
                i = 1;
                Console.WriteLine("Player " + Players[i] + " Plays again");
            }
            NoOfDiceRolled++;
        }
    }
}

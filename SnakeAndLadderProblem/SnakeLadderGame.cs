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
            int position1 = 0;
            int Num_Of_Players = 1;
            
            Console.Write("Enter s to Start to play : ");
            string start = Console.ReadLine();

            Console.WriteLine("Number of Players : " + Num_Of_Players);
            Console.WriteLine("Player 1 at position : " + position1);

            Random random = new Random();
            int DieNumber1 = random.Next(1, 7);
            Console.WriteLine("Player rolled the Die ....");
            Console.WriteLine("Dies turns to : " + DieNumber1);
            
            
        }
    }
}

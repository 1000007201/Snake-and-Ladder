using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POS = 100;
        int playerpos = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            return random.Next(7);
        }
        public int Player()
        {
            int count = 1;
            while ( playerpos < WINNING_POS)
            {
                int option = random.Next(3);
                int dice = DiceRoll();
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        
                        if (playerpos + dice <= WINNING_POS)
                        {
                            playerpos += dice;

                        }
                        break;
                    case SNAKE:
                        if (playerpos - dice >=0)
                        {
                            playerpos -= dice;
                        }
                        else
                        {
                            playerpos = 0;
                        }
                        
                        break;
                }
                count++;
                
            }
            return count;
        }

    }
}

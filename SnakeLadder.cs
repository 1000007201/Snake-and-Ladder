using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        int playerpos = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            return random.Next(7);
        }
        public void Player()
        {
            int option = random.Next(3);
            switch (option)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    playerpos += DiceRoll();
                    break;
                case SNAKE:
                    playerpos -= DiceRoll();
                    break;
            }
            Console.WriteLine(playerpos);

        }

    }
}

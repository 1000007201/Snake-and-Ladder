using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        Random random = new Random();
        public void DiceRoll()
        {
            Console.WriteLine("Player got {0}", random.Next(7));
        }

    }
}

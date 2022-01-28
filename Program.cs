// See https://aka.ms/new-console-template for more information
using SnakeAndLadder;

SnakeLadder player1 = new SnakeLadder();
SnakeLadder player2 = new SnakeLadder();
int moves_player1 = player1.Player();
int moves_player2 = player2.Player();

if (moves_player1 > moves_player2)
{
    Console.WriteLine("2nd Player wins game by {0} moves",moves_player1 - moves_player2);
}
if (moves_player2 > moves_player1)
{
    Console.WriteLine("1st Player wins game by {0} moves",moves_player2 - moves_player1);
}
if (moves_player2 == moves_player1)
{
    Console.WriteLine("There is a tie");
}

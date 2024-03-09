using System;
using System.Xml.XPath;


namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {

            GameItem move1 = (GameItem)Enum.Parse(typeof(GameItem), player1);
            GameItem move2 = (GameItem)Enum.Parse(typeof(GameItem), player2); 


            GameStatus result = 0;

            if (player1 == player2)
            {
                result = GameStatus.Draw;
                return (int)result; // Draw
            }
            if (((player1 == "Rock") && (player2 == "Scissors")) ||
                ((player1 == "Scissors") && (player2 == "Paper")) ||
                ((player1 == "Paper") && (player2 == "Rock")))
            {
                result = GameStatus.Player1Wins;
                return (int) result; // Player 1 wins
            }
            else
            {   
                result = GameStatus.Player2Wins;
                return (int) result; // Player 2 wins
            }
        }
    }
}

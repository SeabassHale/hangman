using static System.Console;

namespace Hangman
{
    internal class Program
    {


        public static void Main()
        {
            int playCount = 0;
            WriteLine("Welcome to HANGMAN");

            // PLAYER OBJECT INSTANTIATION
            Player player1 = new Player("Player 1", "");
            Player player2 = new Player("Player 2", "");
            Player currentPlayer = new Player("Null", "");
            Player currentGuesser = new Player("Null", "");

            WriteLine("Press ENTER for a new game or ESC to quit");
            if (ReadKey().Key == ConsoleKey.Enter)
            {
                NewGame.StartNewGame(playCount, player1, player2, currentPlayer, currentGuesser);
            }
            else if (ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                WriteLine("Press ENTER or ESC, ya chump.");
                Main();
            }
        }
    }
}
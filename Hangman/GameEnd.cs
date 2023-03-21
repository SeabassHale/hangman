using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hangman
{
    public class GameEnd
    {
        public static void EndGame(int playcount, Player player1, Player player2, Player currentPlayer, Player currentGuesser)
        {
            playcount++;
            WriteLine("Press ENTER to start a new game, or ESC to quit.");

            Console.ReadKey();

            if (ReadKey().Key == ConsoleKey.Enter)
            {
                //REMEBER TO CHANGE THE BELOW
                NewGame.StartNewGame(playcount, player1, player2, currentPlayer, currentGuesser);
            }
            else if (ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                EndGame(playcount, player1, player2, currentPlayer, currentGuesser);
            }
            //while (ReadKey().Key != ConsoleKey.Enter || ReadKey().Key != ConsoleKey.Escape)
            //{

            //}
        }
    }
}

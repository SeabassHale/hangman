using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hangman
{
    public class NewGame
    {
        public static void StartNewGame(int playcount, Player player1, Player player2, Player currentPlayer, Player currentGuesser)
        {
            if (playcount == 0)
            {
                player1 = Player.PlayerNaming(player1);
                player2 = Player.PlayerNaming(player2);
                //WriteLine(player1.playerName);
                currentPlayer.playerName = player1.playerName;
                currentGuesser.playerName = player2.playerName;
            }
            else
            {
                //playcount++;
                if(playcount / 2 != 0)
                {
                    currentPlayer.playerName = player2.playerName;
                    currentGuesser.playerName = player1.playerName;
                }
                else
                {
                    currentPlayer.playerName = player1.playerName;
                    currentGuesser.playerName = player2.playerName;
                }
            }

            Write($"{currentPlayer.playerName} input your word to be guessed: ");
            
            
            BackgroundColor = ConsoleColor.Gray; // masks input word while being typed
            string inputWord = ReadLine().ToUpper();
            BackgroundColor = ConsoleColor.Black; // resets background masking
            string maskedWord = TextFormatting.WordMasking(inputWord);
            WriteLine($"{maskedWord}");
            var guessedLetters = new List<string>();
            int guessCount = 0;
            GuessProcess.GuessInput(inputWord, maskedWord, guessedLetters, guessCount, playcount, player1, player2, currentPlayer, currentGuesser); // Now need to open game to allow letter guesses
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hangman
{
    internal class GuessProcess
    
    {
        internal static void GuessInput(string inputWord, string maskedWord, List<string> guessedLetters, int guessCount, int playcount, Player player1, Player player2, Player currentPlayer, Player currentGuesser)
        {
            // initialistion of required variables
            char[] maskedWordAsChars = maskedWord.ToCharArray();
            char[] inputWordAsChars = inputWord.ToCharArray();
            WriteLine($"{currentGuesser.playerName} has had {guessCount} of maximum 5 incorrect guesses");

            // guesser guesses a letter
            Write($"Please guess a letter: ");
            string letterGuess = Convert.ToString(ReadKey().Key);
            WriteLine();

            WriteLine($"{currentGuesser.playerName} guessed the letter {letterGuess}.\n");

            // guessed letter is compared to and added to a list. If letter has been guessed, no further action taken.
            if (guessedLetters.Contains(letterGuess))
            {
                Console.WriteLine($"You've already guessed {letterGuess}, try another letter.\n");
                //guessCount++;
                if (guessCount >= 5)
                {
                    WriteLine("Game over. You failed to guess the word\n");
                    WriteLine("Would you like to play again");
                    GameEnd.EndGame(playcount, player1, player2, currentPlayer, currentGuesser);
                }
                else
                {
                    GuessInput(inputWord, maskedWord, guessedLetters, guessCount, playcount, player1, player2, currentPlayer, currentGuesser);
                }
            } 
            else
            {
                //guessCount++;
                guessedLetters.Add(letterGuess);
            }


            // guessed letter is compared to characters in inputWord and maskedWord updated if matches found.
            int i = 0;
            bool letterIncluded = false;
            foreach (char c in inputWordAsChars)
            {
                if (c == Convert.ToChar(letterGuess))
                {
                    maskedWordAsChars[i] = Convert.ToChar(letterGuess);
                    letterIncluded = true;
                }
                i++;
            }

            if(letterIncluded!=true)
            {
                guessCount++;
            }

            string updatedMaskedWord = new string(maskedWordAsChars);
            WriteLine($"{updatedMaskedWord}\n");
            
            if (updatedMaskedWord.Contains("*") && guessCount < 5) // UPDATE 5 TO A DIFFICULTY SELECTION ON NEWGAME
            {
                i++;
                GuessProcess.GuessInput(inputWord, updatedMaskedWord, guessedLetters, guessCount, playcount, player1, player2, currentPlayer, currentGuesser);
            }
            else if ((updatedMaskedWord.Contains("*") && guessCount >= 5) || guessCount >= 5)
            {
                WriteLine("Game over. You failed to guess the word\n");
                WriteLine("Would you like to play again");
                GameEnd.EndGame(playcount, player1, player2, currentPlayer, currentGuesser);
            }
            else
            {
                WriteLine("Congratulations. You guessed the word!");
                WriteLine("Would you like to play again");
                GameEnd.EndGame(playcount, player1, player2, currentPlayer, currentGuesser);
            }
            
        }

    }
}

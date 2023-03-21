using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hangman
{
    internal class TextFormatting
    {
        public static string WordMasking(string maskWord)
        {
            string _secretString = maskWord;
            string[] maskedWordArray = new string[_secretString.Length];

            for (int i = 0; i < _secretString.Length; i++)
            {
                maskedWordArray[i] = "*";
            }
            string maskedWord = String.Join("", maskedWordArray);
            return maskedWord;
        }

        //public static string FontColour(string wordColour)
        //{
        //    BackgroundColor = ConsoleColor.White;
        //    string _wordColour = wordColour;
        //    BackgroundColor = ConsoleColor.Black;
        //    return _wordColour;
        //}
    }
}

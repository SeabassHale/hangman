using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hangman
{
    public struct Player
    {
        public string playerName { get; set; }
        public string playerLongestWord { get; set; }

        public Player(string name, string longestWord)
        {
            playerName = name;
            playerLongestWord = longestWord;
        }

        public static Player PlayerNaming(Player player)
        {
            Write("Please enter player name: ");
            player.playerName = ReadLine();
            return player;
        }

        public static string CurrentPlayer(string player1Name, string player2Name, int playcount)
        {
            if(playcount / 2 != 0)
            {
                return player2Name;
            }
            else
            {
                return player1Name;
            }
        }
    }
}

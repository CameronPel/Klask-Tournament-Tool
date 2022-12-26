using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaskBasementChampionships
{
    public class Match
    {
        public string matchName;

        //who is playing
        public Player? participant1; //alphabetical order always
        public Player? participant2;

        //who won
        public Player? winner;
        public Player? loser;

        //extra info
        //FIGURE OUT HOW TO ADD A TIMER???
        public int p1Score;
        public int p2Score;
        public int gameTime = 0; //match length in seconds

    }
}

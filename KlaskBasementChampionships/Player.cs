using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Player represents a player and a myriad of specific stats that I want to keep track of.
namespace KlaskBasementChampionships
{
    public class Player
    {
        public string? name; //name of player
        public CheckBox inMatch = new CheckBox();

        //betting
        public TextBox currentBet = new TextBox();
        public int payout = 0;
        public bool wonBet = false;
        public Player? whoThisPlayerBetOn;
        public ComboBox comboBoxForDisplay = new ComboBox();
        public int totalCausedPayout; //this is tabulates how much, as a sum, that a player caused other players to GAIN by betting on them.
        public int totalCausedLosses; //this is tabulates how much, as a sum, that a player caused other players to LOSE by betting on them.

        //stats/////////////////////////////////////////////////////////////////////////
        public Button statsButton = new Button();

        //points
        public int points = 0; //total amount of points scored, any type
        public int standardPoints = 0; //points gained by getting the ball into the opponents goal
        public int biscuitPoints = 0; //amount of times the player gained a point by getting two biscuits on an opponent
        public int klaskPoints = 0; //amount of points gained by the opponent klasking
        public int oobPoints = 0; //amount of points gained by opponent losing control of their striker

        //points given up
        public int pointsGivenUp = 0; //amount of points given up
        public int standardPointsGivenUp = 0; //amount of points given up by the opponent getting the ball into this players goal
        public int biscuitPointsGivenUp = 0; //amount of times the player lost a point by getting two biscuits on their striker
        public int klaskPointsGivenUp = 0; //amount of times the player lost a point by klasking
        public int oobPointsGivenUp = 0; //amount of points lost by losing control of their striker

        //other
        public int matchesPlayed = 0; //amount of matches played
        public int wins = 0; //amount of wins
        public int losses = 0; //amount of losses
        public int shutouts = 0; //amount of wins in which the opponent did not score a point
        public int totalGameTime = 0; //amount of time spent playing all games in seconds

        public void ScoredStandardPoint() 
        {
            this.points++;
            this.standardPoints++;
        }

        public void ScoredBiscuitPoint()
        {
            this.points++;
            this.biscuitPoints++;
        }

        public void ScoredKlaskPoint()
        {
            this.points++;
            this.klaskPoints++;
        }

        public void ScoredOOBPoint()
        {
            this.points++;
            this.oobPoints++;
        }

        public void LostStandardPoint()
        {
            this.pointsGivenUp++;
            this.standardPointsGivenUp++;
        }

        public void LostBiscuitPoint()
        {
            this.pointsGivenUp++;
            this.biscuitPointsGivenUp++;
        }

        public void LostKlaskPoint()
        {
            this.pointsGivenUp++;
            this.klaskPointsGivenUp++;
        }

        public void LostOOBPoint()
        {
            this.pointsGivenUp++;
            this.oobPointsGivenUp++;
        }


    }
}

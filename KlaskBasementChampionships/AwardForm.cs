using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlaskBasementChampionships
{
    public partial class AwardForm : Form
    {
        public AwardForm(Tournament tournament)
        {
            InitializeComponent();
            Player luckyAwardPlayer; //player with the highest percentage of klask/oob points
            Player feederAwardPlayer; //player with the highest percentage of biscuit points
            Player sharpShooterAwardPlayer; //player with the highest percentage of standard points
            Player iAmSpeedAwardPlayer; //player with the lowest average game time
            Player bigMoneyAwardPlayer; //player who caused they highest average payout per game for those who bet on them
            Player nowThatIsKlaskAwardPlayer; //player who klasked the most
            Player dominantAwardPlayer; //player with highest percentage of shutouts

            double luckyHighest = 0;
            double feederHighest = 0;
            double sharpHighest = 0;
            double iAmSpeedLowest;
            double bigMoneyHighest = 0;
            double nowThatIsKlaskHighest = 0;
            double shutoutHighest = 0;


            List<Player> participants = tournament.participants;

            
            for (int i = 0; i < participants.Count; i++)
            {
                //SHARPSHOOTER
                double sharpPercent = (participants[i].standardPoints / participants[i].points) * 100; //percentage of standard points
                if (sharpPercent > sharpHighest) //highest so far?
                {
                    sharpHighest = sharpPercent;
                    sharpShooterAwardPlayer = participants[i];
                }

                //FEEDER
                double biscuitPercent = (participants[i].biscuitPoints / participants[i].points) * 100; //percentage of biscuit points
                if (biscuitPercent > feederHighest) //highest so far?
                {
                    feederHighest = biscuitPercent;
                    feederAwardPlayer = participants[i];
                }

                //KLASK
                if (participants[i].klaskPointsGivenUp > nowThatIsKlaskHighest)
                {
                    nowThatIsKlaskHighest = participants[i].klaskPointsGivenUp;
                    nowThatIsKlaskAwardPlayer = participants[i];
                }

                //SHUTOUTS
                double shutoutPercent = (participants[i].shutouts / participants[i].matchesPlayed) * 100; //percent of shutouts
                if (shutoutPercent > shutoutHighest)
                {
                    shutoutHighest = shutoutPercent;
                    dominantAwardPlayer = participants[i];
                }

                //LUCKY
                double luckPercent = ((participants[i].klaskPoints + participants[i].oobPoints) / participants[i].points) * 100;
                if (luckPercent > luckyHighest)
                {
                    luckyHighest = luckPercent;
                    luckyAwardPlayer = participants[i];
                }

                //BIG MONEY
                double bigMoneyPercent = participants[i].totalCausedPayout / participants[i].matchesPlayed;
                if (bigMoneyPercent > bigMoneyHighest)
                {
                    bigMoneyHighest = bigMoneyPercent;
                    bigMoneyAwardPlayer = participants[i];
                }

                //I AM SPEED

            }
        }
    }
}

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
    public partial class StatsForm : Form
    {
        public StatsForm(Player player)
        {
            InitializeComponent();
            statsLabel.Text = player.name + " Stats";

            // I mean, there isn't really a better way of doing this, gotta do what you gotta do.

            ////////////////////////////////////////////////////
            //overall labels
            Label wins = new Label();
            Label losses = new Label();
            Label matches = new Label();

            //points gained labels
            Label points = new Label();
            Label standardPoints = new Label();
            Label biscuitPoints = new Label();
            Label klaskPoints = new Label();
            Label oobPoints = new Label();

            //points lost labels
            Label pointsGivenUp = new Label();
            Label standardPointsGivenUp = new Label();
            Label biscuitPointsGivenUp = new Label();
            Label klaskPointsGivenUp = new Label();
            Label oobPointsGivenUp = new Label();
           /////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////
            //change text points
            points.Text = "Total Points: " + player.points;
            standardPoints.Text = "Standard Points: " + player.standardPoints;
            biscuitPoints.Text = "Biscuit Points: " + player.biscuitPoints;
            klaskPoints.Text = "Klask Points: " + player.klaskPoints;
            oobPoints.Text = "Lost Striker Points: " + player.oobPoints;

            //chagnes texts points lost
            pointsGivenUp.Text = "Points Given Up: " + player.pointsGivenUp;
            standardPointsGivenUp.Text = "Standard Points Given Up: " + player.standardPointsGivenUp;
            biscuitPointsGivenUp.Text = "Biscuit Points Given Up: " + player.biscuitPointsGivenUp;
            klaskPointsGivenUp.Text = "Klask Points Given Up: " + player.klaskPointsGivenUp;
            oobPointsGivenUp.Text = "Lost Striker Points Given Up: " + player.oobPointsGivenUp;

            //change text overall
            matches.Text = "Matches Played: " + player.matchesPlayed;
            wins.Text = "Wins: " + player.wins;
            losses.Text = "Losses: " + player.losses;
            ////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////
            //add the labels to the 
            statsPanel.Controls.Add(matches);
            statsPanel.Controls.Add(wins);
            statsPanel.Controls.Add(losses);
            statsPanel.Controls.Add(points);
            statsPanel.Controls.Add(standardPoints);
            statsPanel.Controls.Add(biscuitPoints);
            statsPanel.Controls.Add(klaskPoints);
            statsPanel.Controls.Add(oobPoints);
            statsPanel.Controls.Add(pointsGivenUp);
            statsPanel.Controls.Add(standardPointsGivenUp);
            statsPanel.Controls.Add(biscuitPointsGivenUp);
            statsPanel.Controls.Add(klaskPointsGivenUp);
            statsPanel.Controls.Add(oobPointsGivenUp);
            ////////////////////////////////////////////////////////////////////////////////

            //make things look nice
            foreach (Label c in statsPanel.Controls)
            {
                c.AutoSize = true;
                c.Font = new Font("Segoe UI", 22);
            }


        }
    }
}

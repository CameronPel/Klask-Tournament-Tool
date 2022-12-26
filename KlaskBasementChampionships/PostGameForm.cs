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
    public partial class PostGameForm : Form
    {
        Tournament tournament;
        public PostGameForm(Tournament passedTournament, Player winner, Match match)
        {
            InitializeComponent();

            double pool = 0; //total amount bet by all players
            double winnerPool = 0; //total amount bet by the people who chose correctly
            List<Player> betters = new List<Player>(); //a list of all players that actually chose to bet on someone
            this.tournament = passedTournament;
            double percentagePayout = 0;

            for (int i = 0; i < tournament.participants.Count; i++) //loop over every player
            {
                if (tournament.participants[i].comboBoxForDisplay.SelectedIndex >= 0) //check if they chose someone to bet on then add them to the array of betters
                {
                    betters.Add(tournament.participants[i]);
                }
                if (tournament.participants[i].comboBoxForDisplay.Text == winner.name) //check if they bet correctly
                {
                    tournament.participants[i].wonBet = true;
                }
                else //lost the bet
                {
                    tournament.participants[i].wonBet = false;
                }
                if (string.IsNullOrEmpty(tournament.participants[i].currentBet.Text)) //they bet 0
                {
                    tournament.participants[i].currentBet.Text = "1"; //this means they have no money or don't want to risk any, allow them to get something
                }
            }

            for (int i = 0; i < betters.Count; i++) //sum pool and winner pool
            {
                pool = pool + double.Parse(betters[i].currentBet.Text); //add their bet to the pool
                if (betters[i].wonBet)
                {
                    winnerPool = winnerPool + double.Parse(betters[i].currentBet.Text); //add their bet to winner pool
                }
            }

            if (betters.Count > 0 && winnerPool != 0) //dont bother calculating percentage when no one bothered to bet in the first place
            {
                percentagePayout = pool / winnerPool; //calculate the payout percentage
            }

            for (int i = 0; i < betters.Count; i++) //calculate their payout
            {
                if (betters[i].wonBet) //they won the bet
                {
                    double tempPayout = Math.Ceiling(double.Parse(tournament.participants[i].currentBet.Text) * percentagePayout);
                    match.winner.totalCausedPayout = match.winner.totalCausedPayout + (int)tempPayout;
                    betters[i].payout = (int)tempPayout + 2; //their payout
                }
                else
                {
                    tournament.participants[i].payout = 0; //lost bet, they get nothing
                }

                Label label = new Label(); //make the label
                label.AutoSize = true; //make it actually appear properly
                label.Font = new Font("Segoe UI", 18); //make things look nice
                label.Text = "Name: " + betters[i].name + " | Betted On: " + betters[i].comboBoxForDisplay.Text + " | Bet: " + betters[i].currentBet.Text + " | Payout: " + betters[i].payout;
                flowLayoutPanel1.Controls.Add(label);
            }

        }

        private void PostGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form.ActiveForm == this)
            {
                if (MessageBox.Show("Are you sure about closing the form? If this is not Cameron, do not close this window. There is no save feature and all data will be lost", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            //time to reset a bunch of stuff
            for (int i = 0; i < tournament.participants.Count; i++)
            {
                tournament.participants[i].currentBet.Text = "";
                tournament.participants[i].comboBoxForDisplay.SelectedIndex = -1;
                tournament.participants[i].comboBoxForDisplay.Items.Clear();
                tournament.participants[i].inMatch.Checked = false;
                tournament.participants[i].comboBoxForDisplay.Enabled = true;
                tournament.participants[i].currentBet.Enabled = true;
            }
            this.Hide();
            MatchBetForm matchBetForm = new MatchBetForm(tournament);
            matchBetForm.ShowDialog(); 
        }
    }
}

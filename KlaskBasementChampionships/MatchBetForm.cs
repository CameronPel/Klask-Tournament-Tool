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
    public partial class MatchBetForm : Form
    {
        Tournament tournament;
        public MatchBetForm(Tournament passedTournament)
        {
            InitializeComponent();
            tournament = passedTournament; //make sure the tournaments are all the same
            int disUnit = 1; //make sure this stuff doesn't overlap
            Label[] playingLabelArray = new Label[passedTournament.participants.Count]; //playing label array
            Label[] bettingLabelArray = new Label[passedTournament.participants.Count]; //betting label array
            for (int i = 0; i < passedTournament.participants.Count; i++)
            {
                //for the playing panel
                playingLabelArray[i] = new Label(); //make a new label to display player name
                playingLabelArray[i].AutoSize = true; //make sure the label is only as big as it needs to be
                playingLabelArray[i].Text = passedTournament.participants[i].name; //change label text to display player name
                playingPanel.Controls.Add(playingLabelArray[i]); //add the label to the panel
                playingLabelArray[i].Top = disUnit * 45; //distancing
                playingLabelArray[i].Left = 20; //distancing
                playingLabelArray[i].Size = new System.Drawing.Size(10, 10);

                passedTournament.participants[i].inMatch.CheckedChanged += InMatch_CheckedChanged; ;
                playingPanel.Controls.Add(passedTournament.participants[i].inMatch); //add the checkbox in player object to panel
                passedTournament.participants[i].inMatch.Top = disUnit * 45; //change location so nothing overlaps

                //for the stats buttons
                playingPanel.Controls.Add(passedTournament.participants[i].statsButton);
                passedTournament.participants[i].statsButton.Top = disUnit * 45; //spacing
                passedTournament.participants[i].statsButton.Left = 110; //spacing
                passedTournament.participants[i].statsButton.Text = passedTournament.participants[i].name + " Stats"; //add text to player button
                passedTournament.participants[i].statsButton.AutoSize = true;
                passedTournament.participants[i].statsButton.Click += statButton_Click;


                //for the betting panel
                bettingLabelArray[i] = new Label(); //make a new label to display player name
                bettingLabelArray[i].AutoSize = true; //make sure the label is only as big as it needs to be
                bettingLabelArray[i].Text = passedTournament.participants[i].name; //change label text to display player name
                bettingPanel.Controls.Add(bettingLabelArray[i]); //add the label to the panel
                bettingLabelArray[i].Top = disUnit * 45; //

                passedTournament.participants[i].currentBet.KeyPress += currentBet_KeyPress; //add checkbox event handler

                bettingPanel.Controls.Add(passedTournament.participants[i].comboBoxForDisplay); //add the combox box to let them decide who they are betting on
                passedTournament.participants[i].comboBoxForDisplay.Left = 250; //distancing
                passedTournament.participants[i].comboBoxForDisplay.Top = disUnit * 45; //distancing
                passedTournament.participants[i].comboBoxForDisplay.DropDownStyle = ComboBoxStyle.DropDownList; //stop user from adding their own input
                //passedTournament.participants[i].comboBoxForDisplay.Enabled = false; //start of as disabled


                bettingPanel.Controls.Add(passedTournament.participants[i].currentBet); //add betting textbox to bet panel
                passedTournament.participants[i].currentBet.Left = 100; //distancing
                passedTournament.participants[i].currentBet.Top = disUnit * 45; //distancing




                disUnit++; //distancing
            }
        }

        //check to make sure everything adds up when a box is changed
        private void InMatch_CheckedChanged(object? sender, EventArgs e)
        {
            //this fixes a bug where this event handler will be triggered when the combo boxes are reset in another form therefore doing the opposite of what I want and adding stuff back to the combo box
            if (Form.ActiveForm != this)
            {
                return;
            }

            string? nameToAddToBoxes = null;
            string? nameToRemoveBoxes = null;
            CheckBox? chk = sender as CheckBox; //get the checkbox that set off this event
            for (int i = 0; i < tournament.participants.Count; i++) //get the participant this checkbox belongs to
            {
                if (tournament.participants[i].inMatch == chk) //is this the right player
                {
                    tournament.participants[i].currentBet.Text = ""; //clear their bet if their box is checked

                    if (chk.Checked) //add this player to the list
                    {
                        nameToAddToBoxes = tournament.participants[i].name;
                        tournament.participants[i].comboBoxForDisplay.Enabled = false;
                        tournament.participants[i].currentBet.Enabled = false;
                        tournament.participants[i].comboBoxForDisplay.SelectedIndex = -1;
                    }
                    else //the box was unchecked, remove their name from the list
                    {
                        nameToRemoveBoxes = tournament.participants[i].name;
                        tournament.participants[i].comboBoxForDisplay.Enabled = true;
                        tournament.participants[i].currentBet.Enabled = true;
                    }
                }
            }
            if (nameToAddToBoxes != null) //name to add to every combo box
            {
                for (int i = 0; i < tournament.participants.Count; i++)
                {
                    tournament.participants[i].comboBoxForDisplay.Items.Add(nameToAddToBoxes);
                }
            }

            if (nameToRemoveBoxes != null) //remove this name from every combo box
            {
                for (int i = 0; i < tournament.participants.Count; i++)
                {
                    tournament.participants[i].comboBoxForDisplay.Items.Remove(nameToRemoveBoxes);
                }
            }




        }

        //start a match
        private void btnBeginMatch_Click(object sender, EventArgs e)
        {
            int playerBoxesChecked = 0; //track how many checkboxes have been checked
            for (int i = 0; i < tournament.participants.Count; i++) //make two boxes are checked
            {
                if (tournament.participants[i].inMatch.Checked) //checks if a given checkbox is checked
                {
                    playerBoxesChecked++; //increase checkbox counter
                }
            }
            if (playerBoxesChecked != 2) //check if you have the correct amount of players
            {
                MessageBox.Show("You have an incorrect amount of players! Try again");
                return; //kick them out
            }
            this.Hide();
            MatchForm matchForm = new MatchForm(tournament);
            matchForm.ShowDialog();
        }

        //when a stats button is clicked
        private void statButton_Click(object? sender, EventArgs e)
        {
            if (Form.ActiveForm != this) //this fixes a bug of the stats box opening twice and dear god I don't know why
            {
                return;
            }
            Button? btn = sender as Button; //get the button
            for (int i = 0; i < tournament.participants.Count; i++) //get the participant this button belongs to
            {
                if (tournament.participants[i].statsButton.Text == btn.Text) //is this the right player?
                {
                    StatsForm stats = new StatsForm(tournament.participants[i]); //create stats form
                    stats.ShowDialog(); //show stats form
                }
            }
        }

        //check bets for only numbers + checkbox can't enter any numbers
        private void currentBet_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MatchBetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form.ActiveForm == this)
            {
                if (MessageBox.Show("Are you sure about closing the form? If this is not Cameron, do not close this window. There is no save feature and all data will be lost", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void matchHistoryButton_Click(object sender, EventArgs e)
        {
            MatchHistoryForm matchHistoryForm = new MatchHistoryForm(tournament);
            matchHistoryForm.ShowDialog();
        }

        private void awardsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO NOT PRESS YES UNLESS THIS IS CAMERON, YOU CAN NOT GO BACK FROM THIS POINT FORWARD", "", MessageBoxButtons.YesNo) == DialogResult.No) return;
            AwardForm awardsForm = new AwardForm(tournament);
            this.Hide();
            awardsForm.ShowDialog();
        }
    }
}

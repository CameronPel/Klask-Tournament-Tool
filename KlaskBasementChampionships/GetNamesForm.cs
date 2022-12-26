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
    public partial class GetNamesForm : Form
    {
        Tournament tournament = new Tournament();
        public GetNamesForm(Tournament passedInTournament)
        {
            InitializeComponent();
            tournament = passedInTournament;
            TextBox[] txtboxArray = new TextBox[tournament.participants.Count]; //make an array of text boxes
            int disUnit = 1; //make sure the textboxes dont overlap
            for (int i = 0; i < tournament.participants.Count; i++) //populate the array
            {
                txtboxArray[i] = new TextBox(); //initialize textbox into array
                flowLayout.Controls.Add(txtboxArray[i]); //add textbox to panel

            }
        }

        private void btnNamesDone_Click(object sender, EventArgs e)
        {
            string[] playerNamesArray = new string[tournament.participants.Count];
            int index = 0;
            foreach (Control ctl in flowLayout.Controls) //get each textbox again
            {
                if (ctl is TextBox) //make sure that I have found a textbox
                {
                    if (string.IsNullOrEmpty(ctl.Text)) //make sure they didnt leave one of them empty
                    {
                        MessageBox.Show("One of your names is empty!!!");
                        return;
                    }
                    playerNamesArray[index] = ctl.Text; //add the name to the array of player names
                    index++; //move to next spot in playerNamesArray
                }
            }
            Array.Sort(playerNamesArray); //alphabetize the array
            for (int i = 0; i < tournament.participants.Count; i++) //loop through the names
            {
                tournament.participants[i].name = playerNamesArray[i]; //assign each player object a name
            }

            MatchBetForm matchingAndBetting = new MatchBetForm(tournament);
            this.Hide();
            matchingAndBetting.ShowDialog();

        }

        private void GetNamesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form.ActiveForm == this)
            {
                if (MessageBox.Show("Are you sure about closing the form? If this is not Cameron, do not close this window. There is no save feature and all data will be lost", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}

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
    public partial class MatchForm : Form
    {
        Match match = new Match(); //start up a new match object
        int ticks = 0;
        Tournament tournament;
        string undoString = "";
        public MatchForm(Tournament passedTournament)
        {
            InitializeComponent();
            tournament = passedTournament;
            tournament.matches.Add(match);

            bool FoundTheFirstParticipant = false;
            for (int i = 0; i < passedTournament.participants.Count; i++) //get the players for this match
            {
                if (passedTournament.participants[i].inMatch.Checked) //find a player with a checked match box
                {
                    if (!FoundTheFirstParticipant){ match.participant1 = passedTournament.participants[i]; FoundTheFirstParticipant = true; } //if this is the first player we found, make it p1
                    else { match.participant2 = passedTournament.participants[i]; } //make it p2
                }
            }
            player1Label.Text = match.participant1.name;
            player2Label.Text = match.participant2.name;
        }

        //all the points and what not, pretty simple stuff
        private void p1Standard_Click(object sender, EventArgs e)
        {
            match.p1Score++;
            match.participant1.ScoredStandardPoint();
            match.participant2.LostStandardPoint();
            score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
            if (match.p2Score == 6 || match.p1Score == 6)
            {
                DisablePointButtons();
            }
            undoButton.Enabled = true; //enable undo
            undoString = "p1Standard"; //most recent thing that happened
        }

        private void p1Biscuit_Click(object sender, EventArgs e)
        {
            match.p1Score++;
            match.participant1.ScoredBiscuitPoint();
            match.participant2.LostBiscuitPoint();
            score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
            if (match.p2Score == 6 || match.p1Score == 6)
            {
                DisablePointButtons();
            }
            undoButton.Enabled = true; //enable undo
            undoString = "p1Biscuit"; //most recent thing that happened
        }

        private void p1Klask_Click(object sender, EventArgs e)
        {
            match.p1Score++;
            match.participant1.ScoredKlaskPoint();
            match.participant2.LostKlaskPoint();
            score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
            if (match.p2Score == 6 || match.p1Score == 6)
            {
                DisablePointButtons();
            }
            undoButton.Enabled = true; //enable undo
            undoString = "p1Klask"; //most recent thing that happened
        }

        private void p1Oob_Click(object sender, EventArgs e)
        {
            match.p1Score++;
            match.participant1.ScoredOOBPoint();
            match.participant2.LostOOBPoint();
            score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
            if (match.p2Score == 6 || match.p1Score == 6)
            {
                DisablePointButtons();
            }
            undoButton.Enabled = true; //enable undo
            undoString = "p1Oob"; //most recent thing that happened
        }

        private void p2Standard_Click(object sender, EventArgs e)
        {
            match.p2Score++;
            match.participant2.ScoredStandardPoint();
            match.participant1.LostStandardPoint();
            score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
            if (match.p2Score == 6 || match.p1Score == 6)
            {
                DisablePointButtons();
            }
            undoButton.Enabled = true; //enable undo
            undoString = "p2Standard"; //most recent thing that happened
        }

        private void p2Biscuit_Click(object sender, EventArgs e)
        {
            match.p2Score++;
            match.participant2.ScoredBiscuitPoint();
            match.participant1.LostBiscuitPoint();
            score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
            if (match.p2Score == 6 || match.p1Score == 6)
            {
                DisablePointButtons();
            }
            undoButton.Enabled = true; //enable undo
            undoString = "p2Biscuit"; //most recent thing that happened
        }

        private void p2Klask_Click(object sender, EventArgs e)
        {
            match.p2Score++;
            match.participant2.ScoredKlaskPoint();
            match.participant1.LostKlaskPoint();
            score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
            if (match.p2Score == 6 || match.p1Score == 6)
            {
                DisablePointButtons();
            }
            undoButton.Enabled = true; //enable undo
            undoString = "p2Klask"; //most recent thing that happened
        }

        private void p2Oob_Click(object sender, EventArgs e)
        {
            match.p2Score++;
            match.participant2.ScoredOOBPoint();
            match.participant2.LostOOBPoint();
            score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
            if (match.p2Score == 6 || match.p1Score == 6)
            {
                DisablePointButtons();
            }
            undoButton.Enabled = true; //enable undo
            undoString = "p2Oob"; //most recent thing that happened
        }

        private void DisablePointButtons() 
        {
            p1Biscuit.Enabled = false;
            p1Klask.Enabled = false;
            p1Oob.Enabled = false;
            p1Standard.Enabled = false; 
            p2Biscuit.Enabled = false;
            p2Oob.Enabled = false;
            p2Klask.Enabled=false;
            p2Standard.Enabled=false;

            postGame.Enabled = true;
            timer1.Stop();
        }

        private void postGame_Click(object sender, EventArgs e)
        {
            if (match.p1Score == 6) //figure out who won then adjust stats
            {
                match.winner = match.participant1;
                match.loser = match.participant2;
                match.winner.wins++;
                match.loser.losses++;
            }
            if (match.p2Score == 6) //figure out who won then adjust stats
            {
                match.winner = match.participant2;
                match.loser = match.participant1;
                match.winner.wins++;
                match.loser.losses++;

            }
            if (match.p1Score == 0) //check for a shutout
            {
                match.participant2.shutouts++;
            }
            if (match.p2Score == 0) //check for a shutout
            {
                match.participant1.shutouts++;
            }
            match.gameTime = ticks; //add match gametime
            match.participant1.totalGameTime = match.participant1.totalGameTime + ticks; //add gametime to players
            match.participant2.totalGameTime = match.participant2.totalGameTime + ticks; //add gametime to players
            match.matchName = matchNameBox.Text;

            this.Hide();
            PostGameForm postGameForm = new PostGameForm(tournament, match.winner, match);
            postGameForm.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            timerLabel.Text = ticks.ToString();
        }

        private void MatchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form.ActiveForm == this)
            {
                if (MessageBox.Show("Are you sure about closing the form? If this is not Cameron, do not close this window. There is no save feature and all data will be lost", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        //undo button
        private void button10_Click(object sender, EventArgs e)
        {

            switch (undoString)
            {
                case "p1Standard":
                    match.participant1.points--;
                    match.participant1.standardPoints--;
                    match.participant2.pointsGivenUp--;
                    match.participant2.standardPointsGivenUp--;
                    match.p1Score--;
                    score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
                    break;
                case "p1Biscuit":
                    match.participant1.points--;
                    match.participant1.biscuitPoints--;
                    match.participant2.pointsGivenUp--;
                    match.participant2.biscuitPointsGivenUp--;
                    match.p1Score--;
                    score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
                    break;
                case "p1Klask":
                    match.participant1.points--;
                    match.participant1.klaskPoints--;
                    match.participant2.pointsGivenUp--;
                    match.participant2.klaskPointsGivenUp--;
                    match.p1Score--;
                    score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
                    break;
                case "p1Oob":
                    match.participant1.points--;
                    match.participant1.oobPoints--;
                    match.participant2.pointsGivenUp--;
                    match.participant2.oobPointsGivenUp--;
                    match.p1Score--;
                    score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
                    break;
                case "p2Standard":
                    match.participant2.points--;
                    match.participant2.standardPoints--;
                    match.participant1.pointsGivenUp--;
                    match.participant1.standardPointsGivenUp--;
                    match.p2Score--;
                    score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
                    break;
                case "p2Biscuit":
                    match.participant2.points--;
                    match.participant2.biscuitPoints--;
                    match.participant1.pointsGivenUp--;
                    match.participant1.biscuitPointsGivenUp--;
                    match.p2Score--;
                    score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
                    break;
                case "p2Klask":
                    match.participant2.points--;
                    match.participant2.klaskPoints--;
                    match.participant1.pointsGivenUp--;
                    match.participant1.klaskPointsGivenUp--;
                    match.p2Score--;
                    score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
                    break;
                case "p2Oob":
                    match.participant2.points--;
                    match.participant2.oobPoints--;
                    match.participant1.pointsGivenUp--;
                    match.participant1.oobPointsGivenUp--;
                    match.p2Score--;
                    score.Text = match.p1Score.ToString() + " - " + match.p2Score.ToString();
                    break;
            }
            // enable everything just in case
            undoButton.Enabled = false; //turn the damn button back off

            p1Biscuit.Enabled = true;
            p1Klask.Enabled = true;
            p1Oob.Enabled = true;
            p1Standard.Enabled = true;
            p2Biscuit.Enabled = true;
            p2Oob.Enabled = true;
            p2Klask.Enabled = true;
            p2Standard.Enabled = true;

            postGame.Enabled = false;
            timer1.Start();

        }
    }
}

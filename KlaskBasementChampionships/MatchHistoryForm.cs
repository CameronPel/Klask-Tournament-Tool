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
    public partial class MatchHistoryForm : Form
    {
        public MatchHistoryForm(Tournament tournament)
        {
            InitializeComponent();
            for (int i = 0; i < tournament.matches.Count; i++)
            {
                Match match = tournament.matches[i];
                Label tmpLabel = new Label();
                tmpLabel.AutoSize = true;
                tmpLabel.Font = new Font("Segoe UI", 18);
                tmpLabel.Text = match.matchName + " | Score: " + match.p1Score + "-" + match.p2Score + " Winner: " + match.winner.name + " Loser: " + match.loser.name + " Match Time: " + match.gameTime.ToString();
                layoutPanel.Controls.Add(tmpLabel);
            }
        }

       
    }
}

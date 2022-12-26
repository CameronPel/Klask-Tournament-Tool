namespace KlaskBasementChampionships
{
    partial class MatchBetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playingPanel = new System.Windows.Forms.Panel();
            this.bettingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBeginMatch = new System.Windows.Forms.Button();
            this.awardsButton = new System.Windows.Forms.Button();
            this.matchHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playingPanel
            // 
            this.playingPanel.AutoScroll = true;
            this.playingPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playingPanel.Location = new System.Drawing.Point(75, 51);
            this.playingPanel.Name = "playingPanel";
            this.playingPanel.Size = new System.Drawing.Size(241, 435);
            this.playingPanel.TabIndex = 0;
            // 
            // bettingPanel
            // 
            this.bettingPanel.AutoScroll = true;
            this.bettingPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bettingPanel.Location = new System.Drawing.Point(471, 51);
            this.bettingPanel.Name = "bettingPanel";
            this.bettingPanel.Size = new System.Drawing.Size(439, 435);
            this.bettingPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Who is playing in this match?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(471, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bets";
            // 
            // btnBeginMatch
            // 
            this.btnBeginMatch.Location = new System.Drawing.Point(343, 445);
            this.btnBeginMatch.Name = "btnBeginMatch";
            this.btnBeginMatch.Size = new System.Drawing.Size(101, 41);
            this.btnBeginMatch.TabIndex = 4;
            this.btnBeginMatch.Text = "Begin Match";
            this.btnBeginMatch.UseVisualStyleBackColor = true;
            this.btnBeginMatch.Click += new System.EventHandler(this.btnBeginMatch_Click);
            // 
            // awardsButton
            // 
            this.awardsButton.Location = new System.Drawing.Point(993, 445);
            this.awardsButton.Name = "awardsButton";
            this.awardsButton.Size = new System.Drawing.Size(101, 41);
            this.awardsButton.TabIndex = 5;
            this.awardsButton.Text = "Awards";
            this.awardsButton.UseVisualStyleBackColor = true;
            this.awardsButton.Click += new System.EventHandler(this.awardsButton_Click);
            // 
            // matchHistoryButton
            // 
            this.matchHistoryButton.Location = new System.Drawing.Point(993, 381);
            this.matchHistoryButton.Name = "matchHistoryButton";
            this.matchHistoryButton.Size = new System.Drawing.Size(101, 41);
            this.matchHistoryButton.TabIndex = 6;
            this.matchHistoryButton.Text = "Match History";
            this.matchHistoryButton.UseVisualStyleBackColor = true;
            this.matchHistoryButton.Click += new System.EventHandler(this.matchHistoryButton_Click);
            // 
            // MatchBetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 530);
            this.Controls.Add(this.matchHistoryButton);
            this.Controls.Add(this.awardsButton);
            this.Controls.Add(this.btnBeginMatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bettingPanel);
            this.Controls.Add(this.playingPanel);
            this.Name = "MatchBetForm";
            this.Text = "MatchingAndBetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatchBetForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel playingPanel;
        private Panel bettingPanel;
        private Label label1;
        private Label label2;
        private Button btnBeginMatch;
        private Button awardsButton;
        private Button matchHistoryButton;
    }
}
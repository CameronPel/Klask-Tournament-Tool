namespace KlaskBasementChampionships
{
    partial class MatchForm
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
            this.components = new System.ComponentModel.Container();
            this.score = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.matchNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.postGame = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.p1Standard = new System.Windows.Forms.Button();
            this.p1Biscuit = new System.Windows.Forms.Button();
            this.p1Klask = new System.Windows.Forms.Button();
            this.p1Oob = new System.Windows.Forms.Button();
            this.p2Standard = new System.Windows.Forms.Button();
            this.p2Biscuit = new System.Windows.Forms.Button();
            this.p2Klask = new System.Windows.Forms.Button();
            this.p2Oob = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(354, 98);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(110, 72);
            this.score.TabIndex = 0;
            this.score.Text = "0-0";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(389, 180);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(32, 37);
            this.timerLabel.TabIndex = 1;
            this.timerLabel.Text = "0";
            // 
            // matchNameBox
            // 
            this.matchNameBox.Location = new System.Drawing.Point(280, 72);
            this.matchNameBox.Name = "matchNameBox";
            this.matchNameBox.Size = new System.Drawing.Size(267, 23);
            this.matchNameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(322, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Match Name";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(82, 98);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(73, 15);
            this.player1Label.TabIndex = 12;
            this.player1Label.Text = "Participant 1";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(669, 98);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(73, 15);
            this.player2Label.TabIndex = 13;
            this.player2Label.Text = "Participant 2";
            // 
            // postGame
            // 
            this.postGame.Enabled = false;
            this.postGame.Location = new System.Drawing.Point(373, 378);
            this.postGame.Name = "postGame";
            this.postGame.Size = new System.Drawing.Size(75, 51);
            this.postGame.TabIndex = 14;
            this.postGame.Text = "Post Game Report";
            this.postGame.UseVisualStyleBackColor = true;
            this.postGame.Click += new System.EventHandler(this.postGame_Click);
            // 
            // undoButton
            // 
            this.undoButton.Enabled = false;
            this.undoButton.Location = new System.Drawing.Point(373, 323);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(75, 37);
            this.undoButton.TabIndex = 15;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(553, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "ex: A vs B | r1";
            // 
            // p1Standard
            // 
            this.p1Standard.BackColor = System.Drawing.Color.SkyBlue;
            this.p1Standard.Location = new System.Drawing.Point(80, 120);
            this.p1Standard.Name = "p1Standard";
            this.p1Standard.Size = new System.Drawing.Size(75, 61);
            this.p1Standard.TabIndex = 17;
            this.p1Standard.Text = "Standard Point";
            this.p1Standard.UseVisualStyleBackColor = false;
            this.p1Standard.Click += new System.EventHandler(this.p1Standard_Click);
            // 
            // p1Biscuit
            // 
            this.p1Biscuit.BackColor = System.Drawing.Color.SkyBlue;
            this.p1Biscuit.Location = new System.Drawing.Point(80, 209);
            this.p1Biscuit.Name = "p1Biscuit";
            this.p1Biscuit.Size = new System.Drawing.Size(75, 61);
            this.p1Biscuit.TabIndex = 18;
            this.p1Biscuit.Text = "Biscuit Point";
            this.p1Biscuit.UseVisualStyleBackColor = false;
            this.p1Biscuit.Click += new System.EventHandler(this.p1Biscuit_Click);
            // 
            // p1Klask
            // 
            this.p1Klask.BackColor = System.Drawing.Color.SkyBlue;
            this.p1Klask.Location = new System.Drawing.Point(80, 289);
            this.p1Klask.Name = "p1Klask";
            this.p1Klask.Size = new System.Drawing.Size(75, 61);
            this.p1Klask.TabIndex = 19;
            this.p1Klask.Text = "Klask Point";
            this.p1Klask.UseVisualStyleBackColor = false;
            this.p1Klask.Click += new System.EventHandler(this.p1Klask_Click);
            // 
            // p1Oob
            // 
            this.p1Oob.BackColor = System.Drawing.Color.SkyBlue;
            this.p1Oob.Location = new System.Drawing.Point(80, 377);
            this.p1Oob.Name = "p1Oob";
            this.p1Oob.Size = new System.Drawing.Size(75, 61);
            this.p1Oob.TabIndex = 20;
            this.p1Oob.Text = "Lost Striker Point";
            this.p1Oob.UseVisualStyleBackColor = false;
            this.p1Oob.Click += new System.EventHandler(this.p1Oob_Click);
            // 
            // p2Standard
            // 
            this.p2Standard.BackColor = System.Drawing.Color.Crimson;
            this.p2Standard.Location = new System.Drawing.Point(667, 120);
            this.p2Standard.Name = "p2Standard";
            this.p2Standard.Size = new System.Drawing.Size(75, 61);
            this.p2Standard.TabIndex = 21;
            this.p2Standard.Text = "Standard Point";
            this.p2Standard.UseVisualStyleBackColor = false;
            this.p2Standard.Click += new System.EventHandler(this.p2Standard_Click);
            // 
            // p2Biscuit
            // 
            this.p2Biscuit.BackColor = System.Drawing.Color.Crimson;
            this.p2Biscuit.Location = new System.Drawing.Point(667, 209);
            this.p2Biscuit.Name = "p2Biscuit";
            this.p2Biscuit.Size = new System.Drawing.Size(75, 61);
            this.p2Biscuit.TabIndex = 22;
            this.p2Biscuit.Text = "Biscuit Point";
            this.p2Biscuit.UseVisualStyleBackColor = false;
            this.p2Biscuit.Click += new System.EventHandler(this.p2Biscuit_Click);
            // 
            // p2Klask
            // 
            this.p2Klask.BackColor = System.Drawing.Color.Crimson;
            this.p2Klask.Location = new System.Drawing.Point(667, 289);
            this.p2Klask.Name = "p2Klask";
            this.p2Klask.Size = new System.Drawing.Size(75, 61);
            this.p2Klask.TabIndex = 23;
            this.p2Klask.Text = "Klask Point";
            this.p2Klask.UseVisualStyleBackColor = false;
            this.p2Klask.Click += new System.EventHandler(this.p2Klask_Click);
            // 
            // p2Oob
            // 
            this.p2Oob.BackColor = System.Drawing.Color.Crimson;
            this.p2Oob.Location = new System.Drawing.Point(667, 368);
            this.p2Oob.Name = "p2Oob";
            this.p2Oob.Size = new System.Drawing.Size(75, 61);
            this.p2Oob.TabIndex = 24;
            this.p2Oob.Text = "Lost Striker Point";
            this.p2Oob.UseVisualStyleBackColor = false;
            this.p2Oob.Click += new System.EventHandler(this.p2Oob_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p2Oob);
            this.Controls.Add(this.p2Klask);
            this.Controls.Add(this.p2Biscuit);
            this.Controls.Add(this.p2Standard);
            this.Controls.Add(this.p1Oob);
            this.Controls.Add(this.p1Klask);
            this.Controls.Add(this.p1Biscuit);
            this.Controls.Add(this.p1Standard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.postGame);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matchNameBox);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.score);
            this.Name = "MatchForm";
            this.Text = "MatchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatchForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label score;
        private Label timerLabel;
        private TextBox matchNameBox;
        private Label label3;
        private Label player1Label;
        private Label player2Label;
        private Button postGame;
        private Button undoButton;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button p1Standard;
        private Button p1Biscuit;
        private Button p1Klask;
        private Button p1Oob;
        private Button p2Standard;
        private Button p2Biscuit;
        private Button p2Klask;
        private Button p2Oob;
        private System.Windows.Forms.Timer timer1;
    }
}
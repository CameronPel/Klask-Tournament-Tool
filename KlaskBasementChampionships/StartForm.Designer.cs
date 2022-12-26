namespace KlaskBasementChampionships
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.txtPlayerCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(608, 525);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(173, 75);
            this.beginButton.TabIndex = 3;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // txtPlayerCount
            // 
            this.txtPlayerCount.Location = new System.Drawing.Point(608, 465);
            this.txtPlayerCount.Name = "txtPlayerCount";
            this.txtPlayerCount.Size = new System.Drawing.Size(173, 23);
            this.txtPlayerCount.TabIndex = 4;
            this.txtPlayerCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerCount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(230, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(965, 89);
            this.label3.TabIndex = 5;
            this.label3.Text = "Klask Basement Championships";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(578, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number Of Players";
            // 
            // StartForm
            // 
            this.ClientSize = new System.Drawing.Size(1368, 710);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlayerCount);
            this.Controls.Add(this.beginButton);
            this.Name = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button beginButton;
        private TextBox txtPlayerCount;
        private Label label3;
        private Label label2;
    }
}
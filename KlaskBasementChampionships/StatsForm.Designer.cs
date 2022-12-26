namespace KlaskBasementChampionships
{
    partial class StatsForm
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
            this.statsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.statsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.statsPanel.Location = new System.Drawing.Point(12, 83);
            this.statsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(776, 355);
            this.statsPanel.TabIndex = 0;
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statsLabel.Location = new System.Drawing.Point(355, 42);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(90, 37);
            this.statsLabel.TabIndex = 1;
            this.statsLabel.Text = "label1";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.statsPanel);
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel statsPanel;
        private Label statsLabel;
    }
}
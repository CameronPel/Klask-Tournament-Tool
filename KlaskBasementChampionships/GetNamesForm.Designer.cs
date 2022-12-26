namespace KlaskBasementChampionships
{
    partial class GetNamesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNamesDone = new System.Windows.Forms.Button();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Player Alias";
            // 
            // btnNamesDone
            // 
            this.btnNamesDone.Location = new System.Drawing.Point(150, 601);
            this.btnNamesDone.Name = "btnNamesDone";
            this.btnNamesDone.Size = new System.Drawing.Size(75, 23);
            this.btnNamesDone.TabIndex = 2;
            this.btnNamesDone.Text = "Continue";
            this.btnNamesDone.UseVisualStyleBackColor = true;
            this.btnNamesDone.Click += new System.EventHandler(this.btnNamesDone_Click);
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayout.Location = new System.Drawing.Point(74, 49);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(253, 535);
            this.flowLayout.TabIndex = 3;
            // 
            // GetNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 636);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.btnNamesDone);
            this.Controls.Add(this.label1);
            this.Name = "GetNamesForm";
            this.Text = "GetNames";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetNamesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnNamesDone;
        private FlowLayoutPanel flowLayout;
    }
}
namespace Assignment3
{
    partial class RosterForm
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
            this.rosterTitle = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.rosterPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rosterTitle
            // 
            this.rosterTitle.AutoSize = true;
            this.rosterTitle.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rosterTitle.Location = new System.Drawing.Point(171, 9);
            this.rosterTitle.Name = "rosterTitle";
            this.rosterTitle.Size = new System.Drawing.Size(278, 45);
            this.rosterTitle.TabIndex = 0;
            this.rosterTitle.Text = "Check Rosters";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.backBtn.FlatAppearance.BorderSize = 3;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtn.Location = new System.Drawing.Point(12, 544);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(197, 57);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // rosterPanel
            // 
            this.rosterPanel.AutoScroll = true;
            this.rosterPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.rosterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rosterPanel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rosterPanel.Location = new System.Drawing.Point(12, 53);
            this.rosterPanel.Name = "rosterPanel";
            this.rosterPanel.Size = new System.Drawing.Size(618, 485);
            this.rosterPanel.TabIndex = 2;
            this.rosterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rosterPanel_Paint);
            // 
            // RosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(642, 613);
            this.Controls.Add(this.rosterPanel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.rosterTitle);
            this.Name = "RosterForm";
            this.Text = "RosterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RosterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rosterTitle;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel rosterPanel;
    }
}
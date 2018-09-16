namespace Assignment3
{
    partial class A3
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.officerbtn = new System.Windows.Forms.Button();
            this.ambulancebtn = new System.Windows.Forms.Button();
            this.rosterbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(29, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(567, 56);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Ambulance Rostering System";
            // 
            // officerbtn
            // 
            this.officerbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.officerbtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.officerbtn.FlatAppearance.BorderSize = 3;
            this.officerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.officerbtn.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officerbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.officerbtn.Location = new System.Drawing.Point(138, 78);
            this.officerbtn.Name = "officerbtn";
            this.officerbtn.Size = new System.Drawing.Size(331, 79);
            this.officerbtn.TabIndex = 1;
            this.officerbtn.Text = "Officers";
            this.officerbtn.UseVisualStyleBackColor = false;
            this.officerbtn.Click += new System.EventHandler(this.officerbtn_Click);
            // 
            // ambulancebtn
            // 
            this.ambulancebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ambulancebtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.ambulancebtn.FlatAppearance.BorderSize = 3;
            this.ambulancebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ambulancebtn.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulancebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ambulancebtn.Location = new System.Drawing.Point(138, 174);
            this.ambulancebtn.Name = "ambulancebtn";
            this.ambulancebtn.Size = new System.Drawing.Size(331, 79);
            this.ambulancebtn.TabIndex = 2;
            this.ambulancebtn.Text = "Ambulances";
            this.ambulancebtn.UseVisualStyleBackColor = false;
            this.ambulancebtn.Click += new System.EventHandler(this.ambulancebtn_Click);
            // 
            // rosterbtn
            // 
            this.rosterbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rosterbtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.rosterbtn.FlatAppearance.BorderSize = 3;
            this.rosterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rosterbtn.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rosterbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rosterbtn.Location = new System.Drawing.Point(138, 272);
            this.rosterbtn.Name = "rosterbtn";
            this.rosterbtn.Size = new System.Drawing.Size(331, 79);
            this.rosterbtn.TabIndex = 3;
            this.rosterbtn.Text = "Check Rosters";
            this.rosterbtn.UseVisualStyleBackColor = false;
            this.rosterbtn.Click += new System.EventHandler(this.rosterbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitbtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.exitbtn.FlatAppearance.BorderSize = 3;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitbtn.Location = new System.Drawing.Point(138, 376);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(331, 79);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // A3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(608, 467);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.rosterbtn);
            this.Controls.Add(this.ambulancebtn);
            this.Controls.Add(this.officerbtn);
            this.Controls.Add(this.titleLbl);
            this.Name = "A3";
            this.Text = "A3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.A3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button officerbtn;
        private System.Windows.Forms.Button ambulancebtn;
        private System.Windows.Forms.Button rosterbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}


namespace Assignment3
{
    partial class AddOfficerForm
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
            this.cancelbtn = new System.Windows.Forms.Button();
            this.titlelbl = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.fnLabel = new System.Windows.Forms.Label();
            this.skillLabel = new System.Windows.Forms.Label();
            this.officerIDLabel = new System.Windows.Forms.Label();
            this.snLabel = new System.Windows.Forms.Label();
            this.ambIDLabel = new System.Windows.Forms.Label();
            this.fnTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.lnTexBox = new System.Windows.Forms.TextBox();
            this.skillComboBox = new System.Windows.Forms.ComboBox();
            this.ambComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelbtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.cancelbtn.FlatAppearance.BorderSize = 3;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbtn.Location = new System.Drawing.Point(12, 497);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(232, 57);
            this.cancelbtn.TabIndex = 0;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(7, 9);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(522, 55);
            this.titlelbl.TabIndex = 1;
            this.titlelbl.Text = "New Ambulance Officer";
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.savebtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.savebtn.FlatAppearance.BorderSize = 3;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savebtn.Location = new System.Drawing.Point(505, 497);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(232, 57);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnLabel.Location = new System.Drawing.Point(9, 83);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(243, 45);
            this.fnLabel.TabIndex = 3;
            this.fnLabel.Text = "First Names:";
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLabel.Location = new System.Drawing.Point(9, 343);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(206, 45);
            this.skillLabel.TabIndex = 4;
            this.skillLabel.Text = "Skill Level:";
            // 
            // officerIDLabel
            // 
            this.officerIDLabel.AutoSize = true;
            this.officerIDLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officerIDLabel.Location = new System.Drawing.Point(9, 256);
            this.officerIDLabel.Name = "officerIDLabel";
            this.officerIDLabel.Size = new System.Drawing.Size(198, 45);
            this.officerIDLabel.TabIndex = 5;
            this.officerIDLabel.Text = "Officer ID:";
            // 
            // snLabel
            // 
            this.snLabel.AutoSize = true;
            this.snLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snLabel.Location = new System.Drawing.Point(9, 169);
            this.snLabel.Name = "snLabel";
            this.snLabel.Size = new System.Drawing.Size(223, 45);
            this.snLabel.TabIndex = 6;
            this.snLabel.Text = "Last Name:";
            // 
            // ambIDLabel
            // 
            this.ambIDLabel.AutoSize = true;
            this.ambIDLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambIDLabel.Location = new System.Drawing.Point(9, 426);
            this.ambIDLabel.Name = "ambIDLabel";
            this.ambIDLabel.Size = new System.Drawing.Size(278, 45);
            this.ambIDLabel.TabIndex = 7;
            this.ambIDLabel.Text = "Ambulance ID:";
            // 
            // fnTextBox
            // 
            this.fnTextBox.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnTextBox.Location = new System.Drawing.Point(242, 75);
            this.fnTextBox.Name = "fnTextBox";
            this.fnTextBox.Size = new System.Drawing.Size(487, 53);
            this.fnTextBox.TabIndex = 8;
            this.fnTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fnTextBox_Validating);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(210, 248);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(519, 53);
            this.idTextBox.TabIndex = 11;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // lnTexBox
            // 
            this.lnTexBox.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnTexBox.Location = new System.Drawing.Point(222, 161);
            this.lnTexBox.Name = "lnTexBox";
            this.lnTexBox.Size = new System.Drawing.Size(507, 53);
            this.lnTexBox.TabIndex = 12;
            // 
            // skillComboBox
            // 
            this.skillComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillComboBox.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillComboBox.FormattingEnabled = true;
            this.skillComboBox.Location = new System.Drawing.Point(210, 343);
            this.skillComboBox.Name = "skillComboBox";
            this.skillComboBox.Size = new System.Drawing.Size(519, 53);
            this.skillComboBox.TabIndex = 13;
            this.skillComboBox.SelectedIndexChanged += new System.EventHandler(this.skillComboBox_SelectedIndexChanged);
            // 
            // ambComboBox
            // 
            this.ambComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ambComboBox.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambComboBox.FormattingEnabled = true;
            this.ambComboBox.Location = new System.Drawing.Point(279, 418);
            this.ambComboBox.Name = "ambComboBox";
            this.ambComboBox.Size = new System.Drawing.Size(446, 53);
            this.ambComboBox.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // AddOfficerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(754, 570);
            this.Controls.Add(this.ambComboBox);
            this.Controls.Add(this.skillComboBox);
            this.Controls.Add(this.lnTexBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.fnTextBox);
            this.Controls.Add(this.ambIDLabel);
            this.Controls.Add(this.snLabel);
            this.Controls.Add(this.officerIDLabel);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.fnLabel);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.cancelbtn);
            this.Name = "AddOfficerForm";
            this.Text = "AddOfficerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddOfficerForm_FormClosing);
            this.Load += new System.EventHandler(this.AddOfficerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label skillLabel;
        private System.Windows.Forms.Label officerIDLabel;
        private System.Windows.Forms.Label snLabel;
        private System.Windows.Forms.Label ambIDLabel;
        private System.Windows.Forms.TextBox fnTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox lnTexBox;
        private System.Windows.Forms.ComboBox skillComboBox;
        private System.Windows.Forms.ComboBox ambComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}
namespace Assignment3
{
    partial class AddAmbulanceForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.AIDLabel = new System.Windows.Forms.Label();
            this.CrewLabel = new System.Windows.Forms.Label();
            this.StationLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AIDTextBox = new System.Windows.Forms.TextBox();
            this.StationTextBox = new System.Windows.Forms.TextBox();
            this.CrewTextBox = new System.Windows.Forms.TextBox();
            this.AIDError = new System.Windows.Forms.ErrorProvider(this.components);
            this.StationError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AIDError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationError)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(10, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(306, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "New Ambulance";
            // 
            // AIDLabel
            // 
            this.AIDLabel.AutoSize = true;
            this.AIDLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIDLabel.Location = new System.Drawing.Point(12, 76);
            this.AIDLabel.Name = "AIDLabel";
            this.AIDLabel.Size = new System.Drawing.Size(194, 32);
            this.AIDLabel.TabIndex = 1;
            this.AIDLabel.Text = "Ambulance ID:";
            this.AIDLabel.Click += new System.EventHandler(this.AIDLabel_Click);
            // 
            // CrewLabel
            // 
            this.CrewLabel.AutoSize = true;
            this.CrewLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrewLabel.Location = new System.Drawing.Point(12, 226);
            this.CrewLabel.Name = "CrewLabel";
            this.CrewLabel.Size = new System.Drawing.Size(86, 32);
            this.CrewLabel.TabIndex = 2;
            this.CrewLabel.Text = "Crew:";
            // 
            // StationLabel
            // 
            this.StationLabel.AutoSize = true;
            this.StationLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationLabel.Location = new System.Drawing.Point(12, 156);
            this.StationLabel.Name = "StationLabel";
            this.StationLabel.Size = new System.Drawing.Size(108, 32);
            this.StationLabel.TabIndex = 3;
            this.StationLabel.Text = "Station:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.FlatAppearance.BorderSize = 3;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(18, 496);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(214, 61);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.SaveButton.FlatAppearance.BorderSize = 3;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(394, 496);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(202, 61);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AIDTextBox
            // 
            this.AIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.AIDTextBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIDTextBox.Location = new System.Drawing.Point(212, 73);
            this.AIDTextBox.Name = "AIDTextBox";
            this.AIDTextBox.Size = new System.Drawing.Size(384, 39);
            this.AIDTextBox.TabIndex = 6;
            // 
            // StationTextBox
            // 
            this.StationTextBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationTextBox.Location = new System.Drawing.Point(116, 156);
            this.StationTextBox.Name = "StationTextBox";
            this.StationTextBox.Size = new System.Drawing.Size(480, 39);
            this.StationTextBox.TabIndex = 7;
            // 
            // CrewTextBox
            // 
            this.CrewTextBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrewTextBox.Location = new System.Drawing.Point(116, 226);
            this.CrewTextBox.Multiline = true;
            this.CrewTextBox.Name = "CrewTextBox";
            this.CrewTextBox.ReadOnly = true;
            this.CrewTextBox.Size = new System.Drawing.Size(480, 264);
            this.CrewTextBox.TabIndex = 8;
            // 
            // AIDError
            // 
            this.AIDError.ContainerControl = this;
            // 
            // StationError
            // 
            this.StationError.ContainerControl = this;
            // 
            // AddAmbulanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(648, 569);
            this.Controls.Add(this.CrewTextBox);
            this.Controls.Add(this.StationTextBox);
            this.Controls.Add(this.AIDTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.StationLabel);
            this.Controls.Add(this.CrewLabel);
            this.Controls.Add(this.AIDLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddAmbulanceForm";
            this.Text = "AddAmbulanceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAmbulanceForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.AIDError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StationError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label AIDLabel;
        private System.Windows.Forms.Label CrewLabel;
        private System.Windows.Forms.Label StationLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox AIDTextBox;
        private System.Windows.Forms.TextBox StationTextBox;
        private System.Windows.Forms.TextBox CrewTextBox;
        private System.Windows.Forms.ErrorProvider AIDError;
        private System.Windows.Forms.ErrorProvider StationError;
    }
}
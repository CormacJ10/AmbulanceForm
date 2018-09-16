namespace Assignment3
{
    partial class AmbulanceOfficerForm
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
            this.backbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.amboffcrlbl = new System.Windows.Forms.Label();
            this.amboffcrtable = new System.Windows.Forms.DataGridView();
            this.IDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambulanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.amboffcrtable)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.backbtn.FlatAppearance.BorderSize = 3;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbtn.Location = new System.Drawing.Point(12, 423);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(266, 84);
            this.backbtn.TabIndex = 0;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.addbtn.FlatAppearance.BorderSize = 3;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(408, 423);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(266, 84);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add New";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // amboffcrlbl
            // 
            this.amboffcrlbl.AutoSize = true;
            this.amboffcrlbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amboffcrlbl.Location = new System.Drawing.Point(124, 9);
            this.amboffcrlbl.Name = "amboffcrlbl";
            this.amboffcrlbl.Size = new System.Drawing.Size(441, 55);
            this.amboffcrlbl.TabIndex = 2;
            this.amboffcrlbl.Text = "Ambulance Officers";
            // 
            // amboffcrtable
            // 
            this.amboffcrtable.AllowUserToDeleteRows = false;
            this.amboffcrtable.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.amboffcrtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.amboffcrtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcolumn,
            this.nameColumn,
            this.skillColumn,
            this.ambulanceColumn});
            this.amboffcrtable.Location = new System.Drawing.Point(24, 67);
            this.amboffcrtable.Name = "amboffcrtable";
            this.amboffcrtable.ReadOnly = true;
            this.amboffcrtable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.amboffcrtable.RowHeadersVisible = false;
            this.amboffcrtable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.amboffcrtable.Size = new System.Drawing.Size(640, 350);
            this.amboffcrtable.TabIndex = 3;
            this.amboffcrtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.amboffcrtable_CellClick);
            this.amboffcrtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.amboffcrtable_CellContentClick);
            this.amboffcrtable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.amboffcrtable_CellContentDoubleClick);
            this.amboffcrtable.SelectionChanged += new System.EventHandler(this.amboffcrtable_SelectionChanged);
            // 
            // IDcolumn
            // 
            this.IDcolumn.HeaderText = "ID";
            this.IDcolumn.Name = "IDcolumn";
            this.IDcolumn.ReadOnly = true;
            this.IDcolumn.Width = 150;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 150;
            // 
            // skillColumn
            // 
            this.skillColumn.HeaderText = "Skill";
            this.skillColumn.Name = "skillColumn";
            this.skillColumn.ReadOnly = true;
            this.skillColumn.Width = 150;
            // 
            // ambulanceColumn
            // 
            this.ambulanceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ambulanceColumn.HeaderText = "Ambulance";
            this.ambulanceColumn.Name = "ambulanceColumn";
            this.ambulanceColumn.ReadOnly = true;
            // 
            // AmbulanceOfficerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(686, 519);
            this.Controls.Add(this.amboffcrtable);
            this.Controls.Add(this.amboffcrlbl);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.backbtn);
            this.Name = "AmbulanceOfficerForm";
            this.Text = "AmbulanceOfficerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AmbulanceOfficerForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.amboffcrtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label amboffcrlbl;
        private System.Windows.Forms.DataGridView amboffcrtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambulanceColumn;
    }
}
namespace Assignment3
{
    partial class AmbulanceForm
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
            this.ambulanceLbl = new System.Windows.Forms.Label();
            this.ambulanceTable = new System.Windows.Forms.DataGridView();
            this.idClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.backbtn.FlatAppearance.BorderSize = 3;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbtn.Location = new System.Drawing.Point(12, 399);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(164, 83);
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
            this.addbtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(259, 399);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(188, 83);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add New";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // ambulanceLbl
            // 
            this.ambulanceLbl.AutoSize = true;
            this.ambulanceLbl.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulanceLbl.Location = new System.Drawing.Point(104, 25);
            this.ambulanceLbl.Name = "ambulanceLbl";
            this.ambulanceLbl.Size = new System.Drawing.Size(236, 45);
            this.ambulanceLbl.TabIndex = 3;
            this.ambulanceLbl.Text = "Ambulances";
            this.ambulanceLbl.Click += new System.EventHandler(this.ambulanceLbl_Click);
            // 
            // ambulanceTable
            // 
            this.ambulanceTable.AllowUserToDeleteRows = false;
            this.ambulanceTable.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ambulanceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ambulanceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClmn,
            this.nameClmn});
            this.ambulanceTable.Location = new System.Drawing.Point(65, 73);
            this.ambulanceTable.Name = "ambulanceTable";
            this.ambulanceTable.ReadOnly = true;
            this.ambulanceTable.RowHeadersVisible = false;
            this.ambulanceTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ambulanceTable.Size = new System.Drawing.Size(304, 320);
            this.ambulanceTable.TabIndex = 4;
            this.ambulanceTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ambulanceTable_CellContentClick);
            this.ambulanceTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ambulanceTable_CellContentDoubleClick);
            // 
            // idClmn
            // 
            this.idClmn.HeaderText = "ID";
            this.idClmn.Name = "idClmn";
            this.idClmn.ReadOnly = true;
            this.idClmn.Width = 150;
            // 
            // nameClmn
            // 
            this.nameClmn.HeaderText = "Station";
            this.nameClmn.Name = "nameClmn";
            this.nameClmn.ReadOnly = true;
            this.nameClmn.Width = 150;
            // 
            // AmbulanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(459, 507);
            this.Controls.Add(this.ambulanceTable);
            this.Controls.Add(this.ambulanceLbl);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.backbtn);
            this.Name = "AmbulanceForm";
            this.Text = "AmbulanceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AmbulanceForm_FormClosing);
            this.Load += new System.EventHandler(this.AmbulanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label ambulanceLbl;
        private System.Windows.Forms.DataGridView ambulanceTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClmn;
    }
}
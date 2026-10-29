namespace ConnectDatabase
{
    partial class FormViewRecords
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordsToolStripMenuItem,
            this.viewRecordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRecordsToolStripMenuItem
            // 
            this.addRecordsToolStripMenuItem.Name = "addRecordsToolStripMenuItem";
            this.addRecordsToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.addRecordsToolStripMenuItem.Text = "Add Record";
            this.addRecordsToolStripMenuItem.Click += new System.EventHandler(this.addRecordsToolStripMenuItem_Click);
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 55);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(402, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 32);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(95, 17);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(292, 22);
            this.txtSearchID.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Number";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtLastName);
            this.panel3.Controls.Add(this.txtMiddleName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblIDNumber);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.dtpBirthDate);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtFirstName);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Location = new System.Drawing.Point(12, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 346);
            this.panel3.TabIndex = 14;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(127, 185);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(292, 22);
            this.txtLastName.TabIndex = 23;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(127, 120);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(292, 22);
            this.txtMiddleName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Middle Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "First Name:";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIDNumber.Location = new System.Drawing.Point(133, 17);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(71, 16);
            this.lblIDNumber.TabIndex = 17;
            this.lblIDNumber.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(95, 293);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 32);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(127, 246);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(292, 22);
            this.dtpBirthDate.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Employee ID:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(127, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(292, 22);
            this.txtFirstName.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(233, 293);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 32);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDisplay);
            this.panel2.Location = new System.Drawing.Point(570, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 407);
            this.panel2.TabIndex = 15;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(20, 20);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersWidth = 51;
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.Size = new System.Drawing.Size(387, 366);
            this.dgvDisplay.TabIndex = 0;
            this.dgvDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellContentClick);
            // 
            // FormViewRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormViewRecords";
            this.Text = "FormViewRecords";
            this.Load += new System.EventHandler(this.FormViewRecords_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDisplay;
    }
}
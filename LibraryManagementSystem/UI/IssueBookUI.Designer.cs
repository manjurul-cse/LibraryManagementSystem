namespace LibraryManagementSystem.UI
{
    partial class IssueBookUI
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookSerachButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.addIssueBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.bookLendTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookAvailableTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookSearchtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentSearchButton = new System.Windows.Forms.Button();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.addIssueBooksDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(261, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Issue Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Name";
            // 
            // bookSerachButton
            // 
            this.bookSerachButton.Location = new System.Drawing.Point(271, 27);
            this.bookSerachButton.Name = "bookSerachButton";
            this.bookSerachButton.Size = new System.Drawing.Size(75, 23);
            this.bookSerachButton.TabIndex = 40;
            this.bookSerachButton.Text = "Search";
            this.bookSerachButton.UseVisualStyleBackColor = true;
            this.bookSerachButton.Click += new System.EventHandler(this.bookSerachButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Reg No";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(417, 137);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 23);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(157, 140);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpIssueDate.TabIndex = 37;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(271, 150);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 36;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addIssueBooksDataGridView
            // 
            this.addIssueBooksDataGridView.AllowUserToAddRows = false;
            this.addIssueBooksDataGridView.AllowUserToDeleteRows = false;
            this.addIssueBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addIssueBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.addIssueBooksDataGridView.Location = new System.Drawing.Point(12, 283);
            this.addIssueBooksDataGridView.Name = "addIssueBooksDataGridView";
            this.addIssueBooksDataGridView.ReadOnly = true;
            this.addIssueBooksDataGridView.Size = new System.Drawing.Size(568, 125);
            this.addIssueBooksDataGridView.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Book ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 140F;
            this.Column2.HeaderText = "Book Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 200F;
            this.Column3.HeaderText = "Book Auhtor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "No. of Copy";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "No. of Lending Copy";
            // 
            // bookLendTextBox
            // 
            this.bookLendTextBox.Location = new System.Drawing.Point(401, 121);
            this.bookLendTextBox.Name = "bookLendTextBox";
            this.bookLendTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookLendTextBox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "No. of Present Copy";
            // 
            // bookAvailableTextBox
            // 
            this.bookAvailableTextBox.Location = new System.Drawing.Point(132, 128);
            this.bookAvailableTextBox.Name = "bookAvailableTextBox";
            this.bookAvailableTextBox.ReadOnly = true;
            this.bookAvailableTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookAvailableTextBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Author";
            // 
            // bookAuthorTextBox
            // 
            this.bookAuthorTextBox.Location = new System.Drawing.Point(401, 66);
            this.bookAuthorTextBox.Multiline = true;
            this.bookAuthorTextBox.Name = "bookAuthorTextBox";
            this.bookAuthorTextBox.ReadOnly = true;
            this.bookAuthorTextBox.Size = new System.Drawing.Size(147, 20);
            this.bookAuthorTextBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Book Name";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(132, 73);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.ReadOnly = true;
            this.bookNameTextBox.Size = new System.Drawing.Size(214, 20);
            this.bookNameTextBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Book ID";
            // 
            // bookSearchtextBox
            // 
            this.bookSearchtextBox.Location = new System.Drawing.Point(136, 30);
            this.bookSearchtextBox.Name = "bookSearchtextBox";
            this.bookSearchtextBox.Size = new System.Drawing.Size(100, 20);
            this.bookSearchtextBox.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bookSearchtextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bookAuthorTextBox);
            this.groupBox1.Controls.Add(this.bookNameTextBox);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.bookSerachButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bookLendTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bookAvailableTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 179);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studentSearchButton);
            this.groupBox2.Controls.Add(this.contactNoTextBox);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(this.regNoTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpIssueDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 168);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            // 
            // studentSearchButton
            // 
            this.studentSearchButton.Location = new System.Drawing.Point(196, 32);
            this.studentSearchButton.Name = "studentSearchButton";
            this.studentSearchButton.Size = new System.Drawing.Size(75, 23);
            this.studentSearchButton.TabIndex = 48;
            this.studentSearchButton.Text = "Search";
            this.studentSearchButton.UseVisualStyleBackColor = true;
            this.studentSearchButton.Click += new System.EventHandler(this.studentSearchButton_Click);
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(360, 87);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.ReadOnly = true;
            this.contactNoTextBox.Size = new System.Drawing.Size(139, 20);
            this.contactNoTextBox.TabIndex = 47;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(360, 28);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(182, 20);
            this.emailTextBox.TabIndex = 46;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(57, 91);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(203, 20);
            this.nameTextBox.TabIndex = 45;
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(69, 35);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.regNoTextBox.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Contact No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Email";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.menuStrip1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 55);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookEntryToolStripMenuItem,
            this.searchBookToolStripMenuItem,
            this.studentEntryToolStripMenuItem,
            this.issueBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookEntryToolStripMenuItem
            // 
            this.bookEntryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookEntryToolStripMenuItem.Name = "bookEntryToolStripMenuItem";
            this.bookEntryToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.bookEntryToolStripMenuItem.Text = "Book Entry";
            this.bookEntryToolStripMenuItem.Click += new System.EventHandler(this.bookEntryToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchBookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // studentEntryToolStripMenuItem
            // 
            this.studentEntryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentEntryToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.studentEntryToolStripMenuItem.Name = "studentEntryToolStripMenuItem";
            this.studentEntryToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.studentEntryToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.studentEntryToolStripMenuItem.Text = "Student Entry";
            this.studentEntryToolStripMenuItem.Click += new System.EventHandler(this.studentEntryToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.issueBookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.issueBookToolStripMenuItem.Text = "Issue Book";
            this.issueBookToolStripMenuItem.Visible = false;
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.returnBookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // IssueBookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 594);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addIssueBooksDataGridView);
            this.Name = "IssueBookUI";
            this.Text = "IssueBookUI";
            this.ResizeBegin += new System.EventHandler(this.bookSerachButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.addIssueBooksDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bookSerachButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView addIssueBooksDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookLendTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookAvailableTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookAuthorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookSearchtextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button studentSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}
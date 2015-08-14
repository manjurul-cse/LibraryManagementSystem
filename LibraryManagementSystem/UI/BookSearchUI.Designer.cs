namespace LibraryManagementSystem.UI
{
    partial class BookSearchUI
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
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bookIdTextBox = new System.Windows.Forms.TextBox();
            this.bookIdRadioButton = new System.Windows.Forms.RadioButton();
            this.authorRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.authorTextBox);
            this.searchGroupBox.Controls.Add(this.nameTextBox);
            this.searchGroupBox.Controls.Add(this.bookIdTextBox);
            this.searchGroupBox.Controls.Add(this.bookIdRadioButton);
            this.searchGroupBox.Controls.Add(this.authorRadioButton);
            this.searchGroupBox.Controls.Add(this.nameRadioButton);
            this.searchGroupBox.Location = new System.Drawing.Point(11, 87);
            this.searchGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.searchGroupBox.Size = new System.Drawing.Size(576, 197);
            this.searchGroupBox.TabIndex = 4;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search By";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(457, 117);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 32);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(204, 75);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(168, 20);
            this.authorTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(204, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // bookIdTextBox
            // 
            this.bookIdTextBox.Location = new System.Drawing.Point(204, 122);
            this.bookIdTextBox.Name = "bookIdTextBox";
            this.bookIdTextBox.Size = new System.Drawing.Size(168, 20);
            this.bookIdTextBox.TabIndex = 3;
            // 
            // bookIdRadioButton
            // 
            this.bookIdRadioButton.AutoSize = true;
            this.bookIdRadioButton.Location = new System.Drawing.Point(20, 125);
            this.bookIdRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.bookIdRadioButton.Name = "bookIdRadioButton";
            this.bookIdRadioButton.Size = new System.Drawing.Size(62, 17);
            this.bookIdRadioButton.TabIndex = 2;
            this.bookIdRadioButton.Text = "Book Id";
            this.bookIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // authorRadioButton
            // 
            this.authorRadioButton.AutoSize = true;
            this.authorRadioButton.Location = new System.Drawing.Point(20, 78);
            this.authorRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.authorRadioButton.Name = "authorRadioButton";
            this.authorRadioButton.Size = new System.Drawing.Size(56, 17);
            this.authorRadioButton.TabIndex = 1;
            this.authorRadioButton.Text = "Author";
            this.authorRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Checked = true;
            this.nameRadioButton.Location = new System.Drawing.Point(20, 29);
            this.nameRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.nameRadioButton.TabIndex = 0;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultListView);
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 258);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Result";
            // 
            // resultListView
            // 
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.resultListView.FullRowSelect = true;
            this.resultListView.GridLines = true;
            this.resultListView.Location = new System.Drawing.Point(6, 30);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(563, 208);
            this.resultListView.TabIndex = 0;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No. of copy(inside)";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No. of copy(outside)";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 91;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
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
            this.searchBookToolStripMenuItem.Visible = false;
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
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
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
            // BookSearchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Name = "BookSearchUI";
            this.Text = "BookSearchUI";
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox bookIdTextBox;
        private System.Windows.Forms.RadioButton bookIdRadioButton;
        private System.Windows.Forms.RadioButton authorRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI
{
    public partial class MainManuUI : Form
    {
        public MainManuUI()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInUI logInUi=new LogInUI();
            logInUi.Show();
            Close();
        }
        
        private void bookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookEntryUI bookEntryUi = new BookEntryUI();
            bookEntryUi.Show();
            Close();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSearchUI bookSearchUi = new BookSearchUI();
            bookSearchUi.Show();
            Close();
        }

        private void studentEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentEntryUI studentEntryUi = new StudentEntryUI();
            studentEntryUi.Show();
            Close();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBookUI issueBookUi=new IssueBookUI();
            issueBookUi.Show();
            Close();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookUI returnBookUi=new ReturnBookUI();
            returnBookUi.Show();
            Close();
        }
    }
}

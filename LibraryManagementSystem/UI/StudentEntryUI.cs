using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.UI
{
    public partial class StudentEntryUI : Form
    {
        StudentManager studentManager=new StudentManager();
        private int id;
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            aStudent.Id = id;
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.ContactNo = Convert.ToInt32(contactNoTextBox.Text);
            if (nameTextBox.Text==string.Empty)
            {
                MessageBox.Show("Please entre name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (emailTextBox.Text==string.Empty)
            {
                MessageBox.Show("Please entre email address.", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (regNoTextBox.Text==string.Empty)
            {
                MessageBox.Show("Please entre registration No.", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if(contactNoTextBox.Text==string.Empty)
            {
                MessageBox.Show("Please entre contact No.", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                string message = null;
                try
                {
                    message = studentManager.Save(aStudent);
                    MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearAll();
        }
        public void ClearAll()
        {
            nameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            regNoTextBox.Text = string.Empty;
            contactNoTextBox.Text = string.Empty;
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

        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBookUI issueBookUi = new IssueBookUI();
            issueBookUi.Show();
            Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInUI logInUi = new LogInUI();
            logInUi.Show();
            Close();
        }
    }
}

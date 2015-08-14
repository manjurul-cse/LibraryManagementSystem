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
    public partial class BookEntryUI : Form
    {
        BookManager bookManager = new BookManager();
        
        public BookEntryUI()
        {
            InitializeComponent();
            bookIdTextBox.Text = Convert.ToString(bookManager.GetBookId());
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Book aBook=new Book();
            if (booknameTextBox.Text == string.Empty)
            {
                MessageBox.Show(@"Please entre book title.","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (authorNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please entre the author name.", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (iSBNNoTextBox.Text==string.Empty)
            {
                MessageBox.Show("Please entre ISBN no.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (priceTextBox.Text==string.Empty)
            {
                MessageBox.Show("Please entre the prie of this book.", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (noOfInitiatCopyTextBox.Text==string.Empty)
            {
                MessageBox.Show("Give how many book in your store.", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                string message = null;
                try
                {
                    aBook.Id = Convert.ToInt32(bookIdTextBox.Text);
                    aBook.Title = booknameTextBox.Text;
                    aBook.AuthorName = authorNameTextBox.Text;
                    aBook.ISbnNo = iSBNNoTextBox.Text;
                    aBook.Price = Convert.ToInt32(priceTextBox.Text);
                    aBook.InitialCopy = Convert.ToInt32(noOfInitiatCopyTextBox.Text);
                    aBook.OutsideCopy = 0;
                    message = bookManager.Save(aBook);
                    MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearAll()
        {
            bookIdTextBox.Text = bookManager.GetBookId().ToString();
            booknameTextBox.Text = null;
            authorNameTextBox.Text = null;
            iSBNNoTextBox.Text = null;
            priceTextBox.Text = null;
            noOfInitiatCopyTextBox.Text = null;
        }

        private void bookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSearchUI bookSearchUi=new BookSearchUI();
            bookSearchUi.Show();
            Close();
        }

        private void studentEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentEntryUI studentEntryUi=new StudentEntryUI();
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInUI logInUi=new LogInUI();
            logInUi.Show();
            Close();
        }
    }
}

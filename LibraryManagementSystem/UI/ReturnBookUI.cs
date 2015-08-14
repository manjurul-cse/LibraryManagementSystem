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
    public partial class ReturnBookUI : Form
    {
        IssueManager issueManager=new IssueManager();
        BookManager bookManager=new BookManager();
        public ReturnBookUI()
        {
            InitializeComponent();
        }
        List<int> bookId;

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultListView.Items.Clear();
            List<IssueBook> issueBooks;
            if (studentRegNoTextBox.Text!="")
            {
                try
                {
                    issueBooks = issueManager.GetIssueBooks(studentRegNoTextBox.Text);
                    if (issueBooks.Count>0)
                    {
                        foreach (IssueBook issueBook in issueBooks)
                        {
                            ListViewItem item=new ListViewItem(issueBook.Book.Id.ToString());
                            item.Tag = (IssueBook)issueBook;
                            item.SubItems.Add(issueBook.Book.Title);
                            item.SubItems.Add(issueBook.Book.AuthorName);
                            item.SubItems.Add(issueBook.IssueCopy.ToString());
                            item.SubItems.Add(issueBook.DateTime.ToString());
                            resultListView.Items.Add(item);
                        }
                    }
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter your reg no.");
            }
            
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook selectedIssueBook = GetSelectedIssueBook();
            int selectIndex = resultListView.SelectedIndices[0];
            if(selectedIssueBook!=null)
            {
                DialogResult result = MessageBox.Show(@"Do you want to return " + selectedIssueBook.Book.Title + ".","Return Book", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    try
                    {
                       issueManager.ReturnBook(selectedIssueBook);
                        resultListView.Items.RemoveAt(selectIndex);
                        MessageBox.Show("You have successfully return this book.");
                    }
                    catch (Exception exception)
                    {

                        MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private IssueBook GetSelectedIssueBook()
        {
            int index = resultListView.SelectedIndices[0];
            ListViewItem item = resultListView.Items[index];
            return (IssueBook) item.Tag;
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

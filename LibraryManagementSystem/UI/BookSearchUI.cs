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
    public partial class BookSearchUI : Form
    {
        BookManager bookManager=new BookManager();
        public BookSearchUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string bookName;
            string authorName;
            int bookId;
            if (nameRadioButton.Checked)
            {
                bookName = nameTextBox.Text;
                LoadBook(bookName, "name");
            }else if (authorRadioButton.Checked)
            {
                authorName = authorTextBox.ToString();
                LoadBook(authorName, "author");
            }else if (bookIdRadioButton.Checked)
            {
                bookId = Convert.ToInt32(bookIdTextBox.Text);
                LoadBook(bookId.ToString(), "bookId");
            }
            else
            {
                MessageBox.Show("Please select any radio button.");
            }
        }

        public void LoadBook(string name,string searchType)
        {
            resultListView.Items.Clear();
            List<Book> books;
            try
            {
                books = bookManager.GetAllBook(name, searchType);
                if (books.Count > 0)
                {
                    foreach (Book book in books)
                    {
                        ListViewItem aItem = new ListViewItem(book.Id.ToString());
                        aItem.Tag = (Book)book;
                        aItem.SubItems.Add(book.Title);
                        aItem.SubItems.Add(book.AuthorName);
                        aItem.SubItems.Add(book.InitialCopy.ToString());
                        aItem.SubItems.Add(book.OutsideCopy.ToString());
                        aItem.SubItems.Add(book.Price.ToString());
                        resultListView.Items.Add(aItem);
                    }

                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void bookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookEntryUI bookEntryUi=new BookEntryUI();
            bookEntryUi.Show();
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
            LogInUI logInUi= new LogInUI();
            logInUi.Show();
            Close();
        }

    }
}

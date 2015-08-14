using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.DAO;

namespace LibraryManagementSystem.UI
{

    public partial class IssueBookUI : Form
    {
        BookManager bookManager=new BookManager();
        StudentManager studentManager=new StudentManager();
        List<Book> books=new List<Book>();
        List<Student> students=new List<Student>();
        IssueManager issueManager=new IssueManager();

        public IssueBookUI()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            saveButton.Enabled = false;
            addButton.Enabled = false;
            dtpIssueDate.Format=DateTimePickerFormat.Custom;
            dtpIssueDate.CustomFormat = "dd-MM-yyyy hh:mm:ss";

        }

        private int bookId;
        private string studentId;

        private void bookSerachButton_Click(object sender, EventArgs e)
        {
            
            if (bookSearchtextBox.Text!="")
            {
                try
                {
                    bookId = Convert.ToInt32(bookSearchtextBox.Text);
                    Book book = new Book();
                    book = bookManager.SearchBook(bookId);
                    bookNameTextBox.Text = book.Title;
                    bookAuthorTextBox.Text = book.AuthorName;
                    bookAvailableTextBox.Text = book.InitialCopy.ToString();
                    bookLendTextBox.Text = "0";
                    if (book.InitialCopy<1)
                    {
                        bookLendTextBox.ReadOnly = true;
                    }
                    else
                    {
                        addButton.Enabled = true;
                        groupBox2.Enabled = true;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill the book ID text box.");
            }
        }

        private void studentSearchButton_Click(object sender, EventArgs e)
        {
            studentId = (regNoTextBox.Text);
            if (regNoTextBox.Text!="")
            {
                try
                {
                    Student aStudent=new Student();
                    aStudent=studentManager.SearchStudent(studentId);
                    nameTextBox.Text = aStudent.Name;
                    emailTextBox.Text = aStudent.Email;
                    contactNoTextBox.Text = aStudent.ContactNo.ToString();
                    if (nameTextBox.Text!="")
                    {
                        saveButton.Enabled = true;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
             addIssueBooksDataGridView.DataSource = null;
            int i = 0;
             Book aBook = new Book();
             aBook.Id = Convert.ToInt32(bookSearchtextBox.Text);
             aBook.Title = bookNameTextBox.Text;
             aBook.AuthorName = bookAuthorTextBox.Text;
             aBook.OutsideCopy = Convert.ToInt32(bookLendTextBox.Text);
               
             if (books.Count<1)
            {
                if (Convert.ToInt32(bookAvailableTextBox.Text) - Convert.ToInt32(bookLendTextBox.Text) >= 0)
                {
                    if(Convert.ToInt32(bookLendTextBox.Text) !=0)
                    {
                        books.Add(aBook);
                        LoadDatagridview(books);
                    }
                    else
                    {
                        MessageBox.Show("Please insert how many books you want.");
                    }
                }
                else
                {
                    MessageBox.Show("");
                }
            }
           else
            {
                foreach (Book book in books)
                {
                    if (book.Id==aBook.Id)
                    {
                        i = 1;
                        int noOfBook = book.OutsideCopy + aBook.OutsideCopy;

                        if (Convert.ToInt32(bookAvailableTextBox.Text)-noOfBook>=0)
                        {
                            book.OutsideCopy += aBook.OutsideCopy;
                            goto solution;
                        }
                        else
                        {
                            MessageBox.Show("No available book to lend");
                        }
                    }
                }
             solution:
                 if (i == 0)
                 {
                     if (Convert.ToInt32(bookAvailableTextBox.Text) - aBook.OutsideCopy >= 0)
                     {
                         books.Add(aBook);
                         LoadDatagridview(books);
                     }
                     else
                     {
                         MessageBox.Show("No available book to lend");
                         LoadDatagridview(books);
                     }
                 }
                 else
                 {
                     LoadDatagridview(books);
                 }
            }
        }

        private void LoadDatagridview(List<Book> books)
        {
                addIssueBooksDataGridView.AutoGenerateColumns = false;
                addIssueBooksDataGridView.DataSource = books;
                addIssueBooksDataGridView.Columns[0].DataPropertyName = "Id";
                addIssueBooksDataGridView.Columns[1].DataPropertyName = "Title";
                addIssueBooksDataGridView.Columns[2].DataPropertyName = "AuthorName";
                addIssueBooksDataGridView.Columns[3].DataPropertyName = "OutsideCopy";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            string regNo = regNoTextBox.Text;
            aStudent = studentManager.SearchStudent(regNo);
            string message = "";
            if (aStudent!=null)
            {
                foreach (Book aBook in books)
                {
                    bookManager.UpdateBook(aBook.Id,aBook.OutsideCopy,1);
                }
                string dateTime = dtpIssueDate.Text;
                message = issueManager.GetBook(books, DateTime.ParseExact(dateTime, "dd-MM-yyyy hh:mm:ss",CultureInfo.InvariantCulture), aStudent);
                ClearAll();
                
                MessageBox.Show(message);
            }
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookUI returnBookUi=new ReturnBookUI();
            returnBookUi.Show();
            Close();
        }

        private void ClearAll()
        {
            addIssueBooksDataGridView.DataSource = null;
            bookSearchtextBox.Text = "";
            bookNameTextBox.Text = "";
            bookAuthorTextBox.Text = "";
            bookAvailableTextBox.Text = "";
            bookLendTextBox.Text = "";
            regNoTextBox.Text = "";
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            contactNoTextBox.Text = "";
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInUI logInUi = new LogInUI();
            logInUi.Show();
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.DAL.Gateway
{
    class IssueGateway :DBGateway
    {
        BookGateway bookGateway=new BookGateway();
        StudentGateway studentGateway=new StudentGateway();
       
        public string GetBook(List<Book> books, DateTime toShortDateString, Student aStudent)
        {
            SqlConnectionObj.Open();
            foreach (Book book in books)
            {
                string query = string.Format("Insert into tbl_Issueed(Book_id,Lend_copy,Issue_date,student_Reg) values({0},{1},'{2}', '{3}')", book.Id, book.OutsideCopy, toShortDateString, aStudent.RegNo);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();
            }

            return "Book Lend Successfully";
        }

        public List<IssueBook> GetIssueBooks(string regNo)
        {
            List<IssueBook> issueBooks=new List<IssueBook>();
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from tbl_Issueed where student_Reg='{0}' and Return_date is null", regNo);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                while (reader.Read())
                {
                    IssueBook issueBook=new IssueBook();
                    issueBook.Book =bookGateway.GetBooks(Convert.ToInt32(reader[0]));
                    issueBook.IssueCopy = Convert.ToInt32(reader[1]);
                    issueBook.DateTime = Convert.ToDateTime(reader[3]);
                    issueBook.Student = studentGateway.GetStudent(regNo);
                    issueBooks.Add(issueBook);
                }
            }
            catch (Exception exception)
            {

                throw new Exception("Error occurred during search this book.",exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
            return issueBooks;
        }

        public void ReturnBook(IssueBook selectedIssueBook)
        {
            bookGateway.UpdateBook(selectedIssueBook.Book.Id,selectedIssueBook.IssueCopy, 2);
           UpdateReturn(selectedIssueBook);
        }

        private void UpdateReturn(IssueBook selectedIssueBook)
        {
            DateTime now = DateTime.Now;
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("Update tbl_Issueed set  Return_date='{0}' where Book_id={1} and student_Reg='{2}' and Issue_date='{3}'", now, selectedIssueBook.Book.Id, selectedIssueBook.Student.RegNo, selectedIssueBook.DateTime);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();

                }
            catch (Exception exception)
            {

                throw new Exception("Error occurred during return this book.", exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.BLL
{
    class IssueManager
    {
        IssueGateway issueGateway=new IssueGateway();

        public string GetBook(List<Book> books, DateTime toShortDateString, Student aStudent)
        {
           return issueGateway.GetBook(books,toShortDateString,aStudent);
        }

        public List<IssueBook> GetIssueBooks(string regNo)
        {
            return issueGateway.GetIssueBooks(regNo);
        }


        public void ReturnBook(IssueBook selectedIssueBook)
        {
            issueGateway.ReturnBook(selectedIssueBook);
        }
    }
}

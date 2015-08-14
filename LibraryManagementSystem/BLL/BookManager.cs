using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.BLL
{
    class BookManager
    {
        BookGateway bookGateway=new BookGateway();
        public int GetBookId()
        {
            return bookGateway.GetBookId();
        }

        public string Save(Book aBook )
        {
            if (bookGateway.HasBookName(aBook.Title))
            {
                throw new Exception("This system has this book name.Please try again.");
            }else if (bookGateway.HasISBNNo(aBook.ISbnNo))
            {
                throw new Exception("This system already have this ISBN No.Please try again.");
            }
            else
            {
                return bookGateway.Save(aBook);
            }
        }

        public List<Book> GetAllBook(string name, string searchType)
        {
               return  bookGateway.GetAllBooks(name, searchType);
        }

        public Book SearchBook(int bookId)
        {
            return bookGateway.SearchBook(bookId);
        }

        public void UpdateBook(int id,  int outsideCopy, int i)
        {
             bookGateway.UpdateBook(id,  outsideCopy, i);
        }
    }
}

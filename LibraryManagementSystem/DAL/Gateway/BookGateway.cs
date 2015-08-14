using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LibraryManagementSystem.DAL.DAO;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.DAL.Gateway
{
    class BookGateway : DBGateway
    {
       
       public int GetBookId()
       {
           try
           {
               int bookId = 0;
               SqlConnectionObj.Open();
               string query = string.Format("select * from tbl_book");
               SqlCommandObj.CommandText = query;
               SqlDataReader reader = SqlCommandObj.ExecuteReader();
               
               while (reader.Read())
               {
                   bookId = (int) reader[0];
               }
               bookId++;
               return bookId;
           }
           catch (Exception)
           {
               
               throw;
           }
           finally
           {
               SqlConnectionObj.Close();
           }
       }

        public bool HasBookName(string title)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from tbl_book where Title='{0}'", title);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                if (reader!=null)
                {
                    return reader.HasRows;
                }
                return false;
            }
            catch (Exception exception)
            {

                throw new Exception("Title couldn't loaded from your system", exception);
            }finally
            {
                SqlConnectionObj.Close();
            }
        }

        public bool HasISBNNo(string isbnNo)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from tbl_book where ISBNno='{0}'", isbnNo);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                if (reader != null)
                {
                    return reader.HasRows;
                }
                return false;
            }
            catch (Exception exception)
            {

                throw new Exception("ISBN No couldn't loaded from your system", exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
            
        }

        public string Save(Book aBook)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("INSERT INTO tbl_book VALUES({0},'{1}','{2}','{3}',{4},{5},{6})",aBook.Id, aBook.Title, aBook.AuthorName, aBook.ISbnNo, aBook.Price, aBook.InitialCopy,aBook.OutsideCopy);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();
                return "Book have been saved.";
            }
            catch (Exception ex)
            {
                
                throw new Exception("Book couldn't be saved.",ex);
            }finally
            {
                SqlConnectionObj.Close();
            }
            
        }

        public List<Book> GetAllBooks(string name, string searchType)
        {
            List<Book> books=new List<Book>();
            try
            {
                SqlConnectionObj.Open();
                if (searchType == "name")
                {
                    string quere = string.Format("select * from tbl_book where Title like '%{0}%'", name );
                    SqlCommandObj.CommandText = quere;
                    SqlDataReader reader = SqlCommandObj.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        Book aBook = new Book();
                        aBook.Id = Convert.ToInt32(reader["Id"]);
                        aBook.Title = reader["Title"].ToString();
                        aBook.AuthorName = reader["AuthorName"].ToString();
                        aBook.InitialCopy = Convert.ToInt32(reader["InitialCopy"]);
                        aBook.OutsideCopy = Convert.ToInt32(reader["OutsideCopy"]);
                        aBook.Price = Convert.ToInt32(reader["Price"]);
                        books.Add(aBook);
                    }
                    
                }
                else if (searchType == "author")
                {
                    string quere = string.Format("select * from tbl_book where AuthorName like '%{0}%'", name);
                    SqlCommandObj.CommandText = quere;
                    SqlDataReader reader = SqlCommandObj.ExecuteReader();

                    while (reader.Read())
                    {
                        Book aBook = new Book();
                        aBook.Id = Convert.ToInt32(reader["Id"]);
                        aBook.Title = reader["Title"].ToString();
                        aBook.AuthorName = reader["AuthorName"].ToString();
                        aBook.InitialCopy = Convert.ToInt32(reader["InitialCopy"]);
                        aBook.OutsideCopy = Convert.ToInt32(reader["OutsideCopy"]);
                        aBook.Price = Convert.ToInt32(reader["Price"]);
                        books.Add(aBook);
                    }
                }
                else if (searchType == "bookId")
                {
                    string quere = string.Format("select * from tbl_book where Id={0}", name);
                    SqlCommandObj.CommandText = quere;
                    SqlDataReader reader = SqlCommandObj.ExecuteReader();

                    while (reader.Read())
                    {
                        Book aBook = new Book();
                        aBook.Id = Convert.ToInt32(reader["Id"]);
                        aBook.Title = reader["Title"].ToString();
                        aBook.AuthorName = reader["AuthorName"].ToString();
                        aBook.InitialCopy = Convert.ToInt32(reader["InitialCopy"]);
                        aBook.OutsideCopy = Convert.ToInt32(reader["OutsideCopy"]);
                        aBook.Price = Convert.ToInt32(reader["Price"]);
                        books.Add(aBook);
                    }
                }
            }
            catch (Exception exception)
            {

                throw new Exception("Error occurred during books loading from your system.", exception);
            }finally
            {
                SqlConnectionObj.Close();
            }
            return books;
        }

        public Book SearchBook(int bookId)
        {
            Book aBook = new Book();
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from tbl_book where Id='{0}'", bookId);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                while (reader.Read())
                {
                    
                    aBook.Id = Convert.ToInt32(reader["Id"]);
                    aBook.Title = reader["Title"].ToString();
                    aBook.AuthorName = reader["AuthorName"].ToString();
                    aBook.ISbnNo = reader["IsbnNo"].ToString();
                    aBook.InitialCopy = Convert.ToInt32(reader["InitialCopy"]);
                    aBook.OutsideCopy = Convert.ToInt32(reader["OutsideCopy"]);
                    aBook.Price = Convert.ToInt32(reader["Price"]);
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
            return aBook;
        }

        public void UpdateBook(int id,  int outsideCopy, int i)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = "";
                if (i == 1)
                {
                    query =
                        string.Format(
                            "update tbl_book set InitialCopy=InitialCopy -{0}, OutsideCopy=OutsideCopy + {1} where Id={2}",
                            outsideCopy, outsideCopy, id);
                }
                if (i==2)
                {
                     query=string.Format("update tbl_book set InitialCopy=InitialCopy +{0}, OutsideCopy=OutsideCopy - {1} where Id={2}",
                            outsideCopy, outsideCopy, id);
                }
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw new Exception("Problem on this system.", exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
        }

        public Book GetBooks(int toInt32)
        {
             
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from tbl_book where Id={0}", toInt32);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                Book aBook=new Book();
                while (reader.Read())
                {
                    aBook.Id = Convert.ToInt32(reader[0]);
                    aBook.Title = reader[1].ToString();
                    aBook.AuthorName = reader[2].ToString();
                    aBook.ISbnNo = reader[3].ToString();
                    aBook.Price = Convert.ToInt32(reader[4]);
                }
                return aBook;
            }
            catch (Exception exception)
            {
                
                throw new Exception("System can not return those books.",exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
        }
    }
}

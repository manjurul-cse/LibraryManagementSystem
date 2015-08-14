using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAL.DAO
{
    class Book
    {
        private int id;
        private string title;
        private string authorName;
        private string iSBNNo;
        private int price;
        private int initialCopy;
        private int outsideCopy;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }

        public string ISbnNo
        {
            get { return iSBNNo; }
            set { iSBNNo = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int InitialCopy
        {
            get { return initialCopy; }
            set { initialCopy = value; }
        }

        public int OutsideCopy
        {
            get { return outsideCopy; }
            set { outsideCopy = value; }
        }
    }
}

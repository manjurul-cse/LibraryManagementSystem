using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAL.DAO
{
    class IssueBook
    {
        
        private DateTime dateTime;
        private int issueCopy;
        public Book Book{get; set;}
        private Student student;

        

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public int IssueCopy
        {
            get { return issueCopy; }
            set { issueCopy = value; }
        }

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }
    }
}

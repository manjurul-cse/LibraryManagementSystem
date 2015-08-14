using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAL.DAO
{
    class Student
    {
        private int id;
        private string regNo;
        private string name;
        private string email;
        private int contactNo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }
    }
}

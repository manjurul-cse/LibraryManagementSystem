using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.BLL
{
    class StudentManager

    {
        StudentGateway studentGateway=new StudentGateway();
        public string Save(Student aStudent)
        {
            if (studentGateway.HasEmail(aStudent.Email))
            {
                throw new Exception("Email address already used.");
            }
            else if (studentGateway.HasRegNo(aStudent.RegNo))
            {
                throw new Exception("Reg no already used.");
            }
            else
            {
                return studentGateway.Save(aStudent);
            }
        }

        public Student SearchStudent(string studentId)
        {
            return studentGateway.SearchStudent(studentId);
        }
    }
}

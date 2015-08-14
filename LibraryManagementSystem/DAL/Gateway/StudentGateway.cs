using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.DAO;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.DAL.Gateway
{
    class StudentGateway:DBGateway
    {
        public bool HasEmail(string email)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from tbl_Student where Email='{0}'", email);
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
                throw new Exception("System dose not load this email.",exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
        }

        public bool HasRegNo(string regNo)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from tbl_Student where regNo='{0}'", regNo);
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
                throw new Exception("System Does not load this registration no.",exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
        }

        public string Save(Student aStudent)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("insert into tbl_Student values('{0}','{1}','{2}','{3}')",
                                             aStudent.Name, aStudent.Email, aStudent.RegNo,
                                             aStudent.ContactNo);
                SqlCommandObj.CommandText = query;
                SqlCommandObj.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw new Exception("Student does not load this student.",exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
            return aStudent.Name+" hase been saved.";
        }

        public Student SearchStudent(string studentId)
        {
            Student aStudent=new Student();
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from tbl_Student where regNo='{0}'", studentId);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                while (reader.Read())
                {
                    aStudent.Id = Convert.ToInt32(reader["Id"]);
                    aStudent.Name = reader["Name"].ToString();
                    aStudent.Email = reader["Email"].ToString();
                    aStudent.RegNo = reader["RegNo"].ToString();
                    aStudent.ContactNo = Convert.ToInt32(reader["ContactNo"]);
                }
            }
            catch (Exception exception)
            {
                throw new Exception("System doesnot load this student reg no.",exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
            return aStudent;
        }

        public Student GetStudent(string regNo)
        {
            try
            {
                SqlConnectionObj.Open();
                string query = string.Format("select * from tbl_Student where RegNo={0}", regNo);
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                Student aStudent=new Student();
                while (reader.Read())
                {
                    aStudent.Name = reader[1].ToString();
                    aStudent.RegNo = reader[3].ToString();
                    aStudent.Email = reader[2].ToString();
                    aStudent.ContactNo = Convert.ToInt32(reader[4]);
                }
                return aStudent;
            }
            catch (Exception exception)
            {

                throw new Exception("Error occurred during student management system.", exception);
            }
            finally
            {
                SqlConnectionObj.Close();
            }
        }
    }
}

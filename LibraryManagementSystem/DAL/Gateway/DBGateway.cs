﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace LibraryManagementSystem.DAL.Gateway
{
    class DBGateway
    {
        private SqlConnection connectionObj;
        private SqlCommand commandObj;

        public DBGateway()
        {
            connectionObj = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryManagementSystem"].ConnectionString);
            commandObj=new SqlCommand();
        }
        public SqlConnection SqlConnectionObj
        {
            get { return connectionObj; }
        }
        public SqlCommand SqlCommandObj
        {
            get 
            { 
                commandObj.Connection = connectionObj;
                return commandObj;
            }
        }
    }
}

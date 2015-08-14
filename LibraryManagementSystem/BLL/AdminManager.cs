using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL.Gateway;

namespace LibraryManagementSystem.BLL
{
    class AdminManager
    {
        AdminGateway adminGateway=new AdminGateway();
        public bool CheckAll(string username, string password)
        {
            return adminGateway.CheckAll(username, password);
        }
    }
}

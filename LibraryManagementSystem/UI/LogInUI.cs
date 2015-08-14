using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL.Gateway;
using LibraryManagementSystem.UI;

namespace LibraryManagementSystem.UI
{
   
    public partial class LogInUI : Form
    {
        AdminManager adminManager=new AdminManager();

        public LogInUI()
        {
            InitializeComponent();
        }
       
        public void Clear()
        {
            userNameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text!=""&& passwordTextBox.Text!="")
            {
                string username=userNameTextBox.Text;
                string password = passwordTextBox.Text;

                try
                {
                  if (adminManager.CheckAll(username, password))
                  {
                      MainManuUI mainManuUi = new MainManuUI();
                      mainManuUi.Show();
                      this.Opacity = 0;
                  }
                  else
                  {
                      MessageBox.Show("Please give valid username & password.");
                  }
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Clear();
            }
           
        }
    }
}

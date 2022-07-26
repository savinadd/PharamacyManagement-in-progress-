using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logindbEntities x = new logindbEntities();
            if(txtBxUsername.Text!=string.Empty || txtBxPassword.Text != string.Empty)
            {
                var user = x.AdminLogins.Where(a => a.Username.Equals(txtBxUsername.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(txtBxPassword.Text))
                    {
                        var form = new Pick();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Username is incorrect");
                }
            }
            else
            {
                MessageBox.Show("Please enter in your username and password");
            }

    }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}


    


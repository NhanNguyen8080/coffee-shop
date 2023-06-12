using Repository.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop_test
{
    public partial class Login : Form
    {
        UserService _userService = new UserService();
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if (txtUsername.Text.Trim().Length > 0)
            {
                MessageBox.Show("Please enter username!!!", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtPassword.Text.Trim().Length > 0)
            {
                MessageBox.Show("Please enter password!!!", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (txtUsername.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {
                MessageBox.Show("Please enter username and password!!!", "Notification", MessageBoxButtons.OK);
                return;
            }
            var user = _userService.GetAll().Where(p => p.Username.Equals(username)).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("User does not exist!", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (!user.Password.Equals(password))
            {
                MessageBox.Show("Invalid password!", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (user != null && !user.Password.Equals(password))
            {
                MessageBox.Show("Invalid username and password!", "Notification!", MessageBoxButtons.OK);
                return;
            }
            //if (user.UserRole.Equals(""))
        }
    }
}

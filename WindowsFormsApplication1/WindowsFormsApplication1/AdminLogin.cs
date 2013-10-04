using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            this.password.PasswordChar = '*';
            username.Focus();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (username.Text != "" && password.Text != "" && e.KeyCode == Keys.Enter)
                loginBtn.PerformClick();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (username.Text != "" && e.KeyCode == Keys.Tab)
                password.Focus();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "pass")
            {
                this.Hide();
                AdminView form = new AdminView();
                form.ShowDialog();
                this.Close();
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

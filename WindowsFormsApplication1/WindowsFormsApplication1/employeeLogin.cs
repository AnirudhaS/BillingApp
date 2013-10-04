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
    public partial class employeeLogin : Form
    {
        public employeeLogin()
        {
            InitializeComponent();
            EmployeeList employeelogin = new EmployeeList();
            loginAttempt.Text = "";
            username.Focus();
            password.PasswordChar = '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool login = true;
            EmployeeList employeelogin = new EmployeeList();
            //Search for username 
            for (i = 0; i < employeelogin.employee.Count(); i++)
            {
                if (username.Text == employeelogin.employee[i].user && password.Text == employeelogin.employee[i].pass)
                {
                    this.Hide();
                    Form1 form = new Form1();
                    form.ShowDialog();
                    this.Close();
                }
                else
                    login = false;
            }
            if (login == false)
            {
                loginAttempt.Text = "Username or Password incorrect. Please contact admin if recurrent.";
                loginAttempt.Visible = true;
            }
            

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (username.Text != "" && e.KeyCode == Keys.Tab)
                password.Focus();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (username.Text != "" && e.KeyCode == Keys.Enter)
                loginButton.PerformClick();
        }

        private void employeeLogin_Load(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = @"D:\logo1.jpg";

            this.label2.Text = @"Product of RSR Software Inc." + Environment.NewLine + @"Rights Reserved. Copyright ©.";
        }

    }
}

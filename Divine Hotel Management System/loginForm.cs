using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divine_Hotel_Management_System
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginNameTB_Enter(object sender, EventArgs e)
        {
            if (loginNameTB.Text == "Enter username here")
            {
                loginNameTB.Text = "";
                loginNameTB.ForeColor = Color.Black;
            }
        }

        private void loginNameTB_Leave_1(object sender, EventArgs e)
        {
            if (loginNameTB.Text == "")
            {
                loginNameTB.Text = "Enter username here";
                loginNameTB.ForeColor = Color.Gray;
            }
        }

        private void loginPasswordTB_Enter(object sender, EventArgs e)
        {
            if (loginPasswordTB.Text == "Enter password")
            {
                loginPasswordTB.Text = "";
                loginPasswordTB.ForeColor = Color.Black;
            }
        }

        private void loginPasswordTB_Leave_1(object sender, EventArgs e)
        {
            if (loginPasswordTB.Text == "")
            {
                loginPasswordTB.Text = "Enter password";

                loginPasswordTB.ForeColor = Color.Gray;
            }
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainF = new mainForm();
            mainF.ShowDialog();

            /*if (loginNameTB.Text == "ahmer" && loginPasswordTB.Text == "pakistan")
            {
                this.Hide();
                mainForm mainF = new mainForm();
                mainF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password incorrect. Try Again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}

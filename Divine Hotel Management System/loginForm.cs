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

        private void loginNameTB_Leave(object sender, EventArgs e)
        {
            if (loginNameTB.Text == "")
            {
                loginNameTB.Text = "Enter username here";
                loginNameTB.ForeColor = Color.Gray;
            }
        }

        private void loginPasswordTB_Enter(object sender, EventArgs e)
        {
            if (loginPasswordTB.Text == "Enter password here")
            {
                loginPasswordTB.Text = "";
                loginPasswordTB.ForeColor = Color.Black;
            }
        }

        private void loginPasswordTB_Leave(object sender, EventArgs e)
        {
            if (loginPasswordTB.Text == "")
            {
                loginPasswordTB.Text = "Enter password here";
                loginPasswordTB.ForeColor = Color.Gray;
            }
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            if (loginNameTB.Text == "ahmer" && loginPasswordTB.Text == "pakistan")
            {
                this.Hide();
                mainForm mainF = new mainForm();
                mainF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password incorrect. Try Again!", "Error!");
            }
        }
    }
}

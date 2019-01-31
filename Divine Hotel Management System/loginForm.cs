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
                MessageBox.Show("User name or password incorrect. Try Again!", "Error!");
            }
        }
    }
}

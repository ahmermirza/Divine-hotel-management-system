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
    public partial class addEmployeesForm : Form
    {
        public addEmployeesForm()
        {
            InitializeComponent();
        }

        private void addEmployeeIDTB_Enter(object sender, EventArgs e)
        {
            if(addEmployeeIDTB.Text == "Enter Employee ID Here")
            {
                addEmployeeIDTB.Text = "";
                addEmployeeIDTB.ForeColor = Color.Black;
            }
        }

        private void addEmployeeIDTB_Leave(object sender, EventArgs e)
        {
            if (addEmployeeIDTB.Text == "")
            {
                addEmployeeIDTB.Text = "Enter Employee ID Here";
                addEmployeeIDTB.ForeColor = Color.Gray;
            }
        }
    }
}

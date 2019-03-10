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
    public partial class employeesInfoForm : Form
    {
        public employeesInfoForm()
        {
            InitializeComponent();
        }

        private void addEmployeesB_Click(object sender, EventArgs e)
        {
            addEmployeesForm addEmployeesF = new addEmployeesForm();
            addEmployeesF.ShowDialog();
        }
    }
}

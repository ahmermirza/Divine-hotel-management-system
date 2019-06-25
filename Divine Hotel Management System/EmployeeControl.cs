using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divine_Hotel_Management_System
{
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
        {
            InitializeComponent();
        }
        bool recordSelected;

        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            ReloadData();
            employeeDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Employee employee = new Employee();
            employeeDGV.DataSource = employee.ListAll();
        }

        private void employeeDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            recordSelected = true;
            string employeeId = employeeDGV.SelectedRows[0].Cells[0].Value.ToString();
            Employee employee = new Employee();
            employee.Get(int.Parse(employeeId));
            employeeFirstNameTB.Text = employee.FirstName;
            employeeLastNameTB.Text = employee.LastName;
            employeePhoneTB.Text = employee.PhoneNumber;
            employeeAddressTB.Text = employee.Address;
            employeeCNICTB.Text = employee.CnicNumber;
            employeeSalaryTB.Text = employee.Salary;
        }

        private void addEmployeeB_Click(object sender, EventArgs e)
        {
            if (employeeFirstNameTB.Text == "" || employeeLastNameTB.Text == "" || employeePhoneTB.Text == "" || employeeAddressTB.Text == "" || employeeCNICTB.Text == "" || employeeSalaryTB.Text == "")
            {
                MessageBox.Show("Please enter the missing data to add a new employee!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Employee employee = new Employee();
                employee.FirstName = employeeFirstNameTB.Text;
                employee.LastName = employeeLastNameTB.Text;
                employee.PhoneNumber = employeePhoneTB.Text;
                employee.Address = employeeAddressTB.Text;
                employee.CnicNumber = employeeCNICTB.Text;
                employee.Salary = employeeSalaryTB.Text;
                employee.Insert();
                employee.CloseConnection();
                ResetForm();
                ReloadData();
            }
        }

        private void employeeDeleteB_Click(object sender, EventArgs e)
        {
            int rowCount = employeeDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no record to be deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Employee employee = new Employee();
                    int employeeId = (int)employeeDGV.SelectedRows[0].Cells[0].Value;
                    employee.Delete(employeeId);
                    employee.CloseConnection();
                    ResetForm();
                    ReloadData();
                }
            }
        }

        private void employeeUpdateB_Click(object sender, EventArgs e)
        {
            int rowCount = employeeDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no record to be updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (recordSelected)
            {
                Employee employee = new Employee();
                employee.FirstName = employeeFirstNameTB.Text;
                employee.LastName = employeeLastNameTB.Text;
                employee.PhoneNumber = employeePhoneTB.Text;
                employee.Address = employeeAddressTB.Text;
                employee.CnicNumber = employeeCNICTB.Text;
                employee.Salary = employeeSalaryTB.Text;
                int employeeId = (int)employeeDGV.SelectedRows[0].Cells[0].Value;
                employee.Update(employeeId);
                employee.CloseConnection();
                ResetForm();
                ReloadData();
                MessageBox.Show("Record updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recordSelected = false;
            }
            else
            {
                MessageBox.Show("To update a record, please double click to select the record first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetForm()
        {
            employeeFirstNameTB.Text = "";
            employeeLastNameTB.Text = "";
            employeePhoneTB.Text = "";
            employeeAddressTB.Text = "";
            employeeCNICTB.Text = "";
            employeeSalaryTB.Text = "";
        }

        private void employeePhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsNumber(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void employeeCNICTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsNumber(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void employeeSalaryTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsNumber(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
    }
}

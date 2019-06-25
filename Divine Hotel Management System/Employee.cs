using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divine_Hotel_Management_System
{
    class Employee
    {
        public int EmployeeId;
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Address;
        public string CnicNumber;
        public string Salary;

        public string conString = "Server=LOCALHOST\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public Employee()
        {
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
        }
        public DataTable ListAll()
        {
            DataTable employeesDT = new DataTable();
            try
            { 
                string queryString = "SELECT * FROM employees";
            
                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(employeesDT);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return employeesDT;
        }

        public Employee Get(int employeeId)
        {
            string queryString = "SELECT * FROM employees WHERE employee_ID = '"+ employeeId + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable employeesDT = new DataTable();
            sqlDA.Fill(employeesDT);

            FirstName = employeesDT.Rows[0]["first_name"].ToString().Trim();
            LastName = employeesDT.Rows[0]["last_name"].ToString().Trim();
            PhoneNumber = employeesDT.Rows[0]["phone_number"].ToString().Trim();
            Address = employeesDT.Rows[0]["address"].ToString().Trim();
            CnicNumber = employeesDT.Rows[0]["CNIC_number"].ToString().Trim();
            Salary = employeesDT.Rows[0]["salary"].ToString().Trim();

            return this;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO employees (first_name, last_name, phone_number, address, CNIC_number, salary) VALUES('" + FirstName + "', '" + LastName + "', '" + PhoneNumber + "', '" + Address + "', '" + CnicNumber + "', '" + Salary + "')";

            SqlCommand sqlCom = new SqlCommand(queryString, sqlCon);
            try
            {
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete(int employeeId)
        {
            string queryString = "DELETE FROM employees WHERE employee_ID = '" + employeeId + "'";

            SqlCommand sqlCom = new SqlCommand(queryString, sqlCon);
            try
            {
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Update(int employeeId)
        {
            string queryString = "UPDATE employees SET first_name = '"+ FirstName + "', last_name = '" + LastName + "', phone_number = '" + PhoneNumber + "', address = '" + Address + "', CNIC_number = '" + CnicNumber + "', salary = '" + Salary + "' WHERE employee_ID = '" + employeeId + "'";

            SqlCommand sqlCom = new SqlCommand(queryString, sqlCon);
            try
            {
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void CloseConnection()
        {
            sqlCon.Close();
        }
    }
}

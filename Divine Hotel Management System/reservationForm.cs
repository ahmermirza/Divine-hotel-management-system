using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Divine_Hotel_Management_System
{
    public partial class reservationForm : Form
    {
        public reservationForm()
        {
            InitializeComponent();
            addComboBox();
        }

        public string conString = "Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=DHMSdatabase;Integrated Security=True";

        public void addComboBox()
        {
            string queryStr = "select [Room Type] from roomTable where [Reservation Status]='False'";
            SqlConnection sqlCon = new SqlConnection(conString);
            SqlCommand sqlCom = new SqlCommand(queryStr, sqlCon);
            SqlDataReader sqlReader;
            try
            {
                sqlCon.Open();
                sqlReader = sqlCom.ExecuteReader();
                while (sqlReader.Read())
                {
                    String temp = sqlReader.GetString(sqlReader.GetOrdinal("Room Type"));
                    resSelectRoomCB.Items.Add(temp);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            sqlCon.Close();
        }

        private void resB_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            //Room r = new Room();
            SqlCommand sqlCom = sqlCon.CreateCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.CommandText = "insert into resTable([First Name], [Last Name], [Room Type], [Check-in Date], [Check-out Date], [Phone Number])values('" + this.resFirstNameTB.Text+"', '"+this.resLastNameTB.Text+ "', '"+ this.resSelectRoomCB.Text+"', '"+this.resCheckinDT.Value.ToString()+"', '"+this.resCheckoutDT.Value.ToString()+"', '"+this.resPhoneTB.Text+"')";
            sqlCom.ExecuteNonQuery();
            sqlCon.Close();
            MessageBox.Show("Reservation Successful!");
        }
    }
}

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
            resCheckinDTP.MinDate = DateTime.Now;
            resCheckinDTP.Value = DateTime.Now;
            resCheckoutDTP.MinDate = DateTime.Now;
            resCheckoutDTP.Value = DateTime.Now;
        }

        public string conString = "Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=DHMSdatabase;Integrated Security=True";
        private bool checkinDateChanged = false;
        private bool checkoutDateChanged = false;

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
                    resRoomTypeCB.Items.Add(temp);
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
            if (resFirstNameTB.Text == "Enter First Name Here" || resLastNameTB.Text == "Enter Last Name Here" || resPhoneTB.Text == "Enter Phone Number Here")
            {
                MessageBox.Show("Please fill in the missing field(s) to complete the reservation process!", "Error");
            }
            else if (resRoomTypeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Room type!", "Error");
            }
            else if (!checkinDateChanged)
            {
                MessageBox.Show("Please select reservation checkin date!", "Error");
                if (!checkoutDateChanged)
                {
                    MessageBox.Show("Please select reservation checkout date!", "Error");
                }
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection(conString);
                sqlCon.Open();
                //Room r = new Room();
                SqlCommand sqlCom = sqlCon.CreateCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "insert into resTable([First Name], [Last Name], [Room Type], [Check-in Date], [Check-out Date], [Phone Number])values('" + this.resFirstNameTB.Text + "', '" + this.resLastNameTB.Text + "', '" + this.resRoomTypeCB.Text + "', '" + this.resCheckinDTP.Value.ToString() + "', '" + this.resCheckoutDTP.Value.ToString() + "', '" + this.resPhoneTB.Text + "')";
                sqlCom.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Reservation Successful!", "Message");
            }
        }

        private void resFirstNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if(!Char.IsLetter(chr) && chr != 8 && chr != 32)
            {
                MessageBox.Show("This field cannot contain numbers or special characters. Please enter a valid first name!", "Error");
                e.Handled = true;
            }

            //keyPress event to select all of the text in the textbox
            /*
            else if (e.KeyChar == Convert.ToChar(1))
            {
                TextBox txt = sender as TextBox;
                txt.SelectAll();
                e.Handled = true;   
            } */
        }

        private void resFirstNameTB_Enter(object sender, EventArgs e)
        {
            if(resFirstNameTB.Text == "Enter First Name Here")
            {
                resFirstNameTB.Text = "";
                resFirstNameTB.ForeColor = Color.Black;
            }
        }

        private void resFirstNameTB_Leave(object sender, EventArgs e)
        {
            if (resFirstNameTB.Text == "")
            {
                resFirstNameTB.Text = "Enter First Name Here";
                resFirstNameTB.ForeColor = Color.Gray;
            }
        }

        private void resLastNameTB_Enter(object sender, EventArgs e)
        {
            if (resLastNameTB.Text == "Enter Last Name Here")
            {
                resLastNameTB.Text = "";
                resLastNameTB.ForeColor = Color.Black;
            }
        }

        private void resLastNameTB_Leave(object sender, EventArgs e)
        {
            if (resLastNameTB.Text == "")
            {
                resLastNameTB.Text = "Enter Last Name Here";
                resLastNameTB.ForeColor = Color.Gray;
            }
        }

        private void resLastNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsLetter(chr) && chr != 8 && chr != 32)
            {
                e.Handled = true;
                MessageBox.Show("This field cannot contain numbers or special characters. Please enter a valid last name!", "Error");
            }
        }

        private void resPhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsNumber(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("This field cannot contain letters or special characters. Please enter a valid phone number!", "Error");
            }
        }

        private void resPhoneTB_Enter(object sender, EventArgs e)
        {
            if (resPhoneTB.Text == "Enter Phone Number Here")
            {
                resPhoneTB.Text = "";
                resPhoneTB.ForeColor = Color.Black;
            }
        }

        private void resPhoneTB_Leave(object sender, EventArgs e)
        {
            if (resPhoneTB.Text == "")
            {
                resPhoneTB.Text = "Enter Phone Number Here";
                resPhoneTB.ForeColor = Color.Gray;
            }
        }

        private void resCheckinDTP_ValueChanged(object sender, EventArgs e)
        {
            checkinDateChanged = true;
        }

        private void resCheckoutDTP_ValueChanged(object sender, EventArgs e)
        {
            checkinDateChanged = true;
        }

        private void resRoomTypeCB_TextChanged(object sender, EventArgs e)
        {
            resRoomTypeCB.ForeColor = Color.Black;
        }

        private void resetResB_Click(object sender, EventArgs e)
        {
            resFirstNameTB.Text = "Enter First Name Here";
            resFirstNameTB.ForeColor = Color.Silver;
            resLastNameTB.Text = "Enter Last Name Here";
            resLastNameTB.ForeColor = Color.Silver;
            resRoomTypeCB.Text = "Select Room Type";
            resRoomTypeCB.ForeColor = Color.Silver;
            resCheckinDTP.MinDate = DateTime.Now;
            resCheckinDTP.Value = DateTime.Now;
            resCheckoutDTP.MinDate = DateTime.Now;
            resCheckoutDTP.Value = DateTime.Now;
            resPhoneTB.Text = "Enter Phone Number Here";
            resPhoneTB.ForeColor = Color.Silver;
        }
    }
}

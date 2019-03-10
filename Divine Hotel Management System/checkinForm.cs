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
    public partial class checkinForm : Form
    {
        public checkinForm()
        {
            InitializeComponent();
            checkinDTP.MinDate = DateTime.Now;
            checkinDTP.Value = DateTime.Now;
        }

        private void checkinB_Click(object sender, EventArgs e)
        {
            if(checkinFirstNameTB.Text == "Enter First Name Here" || checkinLastNameTB.Text == "Enter Last Name Here" ||  checkinIDNumTB.Text == "Enter ID Number Here" || checkinPhoneTB.Text == "Enter Phone Number Here")
            {
                MessageBox.Show("Please fill in the missing field(s) to complete the checkin process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkinResNumCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Reservation Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkinRoomTypeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Room Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkinRoomNumCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Room Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void checkinFirstNameTB_Enter(object sender, EventArgs e)
        {
            if (checkinFirstNameTB.Text == "Enter First Name Here")
            {
                checkinFirstNameTB.Text = "";
                checkinFirstNameTB.ForeColor = Color.Black;
            }
        }

        private void checkinFirstNameTB_Leave(object sender, EventArgs e)
        {
            if (checkinFirstNameTB.Text == "")
            {
                checkinFirstNameTB.Text = "Enter First Name Here";
                checkinFirstNameTB.ForeColor = Color.Gray;
            }
        }

        private void checkinLastNameTB_Enter(object sender, EventArgs e)
        {
            if (checkinLastNameTB.Text == "Enter Last Name Here")
            {
                checkinLastNameTB.Text = "";
                checkinLastNameTB.ForeColor = Color.Black;
            }
        }

        private void checkinLastNameTB_Leave(object sender, EventArgs e)
        {
            if (checkinLastNameTB.Text == "")
            {
                checkinLastNameTB.Text = "Enter Last Name Here";
                checkinLastNameTB.ForeColor = Color.Gray;
            }
        }

        private void checkinIDNumTB_Enter(object sender, EventArgs e)
        {
            if (checkinIDNumTB.Text == "Enter ID Number Here")
            {
                checkinIDNumTB.Text = "";
                checkinIDNumTB.ForeColor = Color.Black;
            }
        }

        private void checkinIDNumTB_Leave(object sender, EventArgs e)
        {
            if (checkinIDNumTB.Text == "")
            {
                checkinIDNumTB.Text = "Enter ID Number Here";
                checkinIDNumTB.ForeColor = Color.Gray;
            }
        }

        private void checkinPhoneTB_Enter(object sender, EventArgs e)
        {
            if (checkinPhoneTB.Text == "Enter Phone Number Here")
            {
                checkinPhoneTB.Text = "";
                checkinPhoneTB.ForeColor = Color.Black;
            }
        }

        private void checkinPhoneTB_Leave(object sender, EventArgs e)
        {
            if (checkinPhoneTB.Text == "")
            {
                checkinPhoneTB.Text = "Enter Phone Number Here";
                checkinPhoneTB.ForeColor = Color.Gray;
            }
        }

        private void checkinFirstNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if(!Char.IsLetter(chr) && chr != 8 && chr != 32)
            {
                e.Handled = true;
                MessageBox.Show("This field cannot contain numbers or special characters. Please enter a valid first name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkinLastNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsLetter(chr) && chr != 8 && chr != 32)
            {
                e.Handled = true;
                MessageBox.Show("This field cannot contain numbers or special characters. Please enter a valid last name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkinIDNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsNumber(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("This field cannot contain letters or special characters. Please enter a valid ID Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkinPhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsNumber(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("This field cannot contain letters or special characters. Please enter a valid Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkinResNumCB_TextChanged(object sender, EventArgs e)
        {
            checkinResNumCB.ForeColor = Color.Black;
        }

        private void checkinRoomTypeCB_TextChanged(object sender, EventArgs e)
        {
            checkinRoomTypeCB.ForeColor = Color.Black;
        }

        private void checkinRoomNumCB_TextChanged(object sender, EventArgs e)
        {
            checkinRoomNumCB.ForeColor = Color.Black;
        }

        private void resetCheckinB_Click(object sender, EventArgs e)
        {
            checkinResNumCB.Text = "Select Reservation Number";
            checkinResNumCB.ForeColor = Color.Gray;
            checkinFirstNameTB.Text = "Enter First Name Here";
            checkinFirstNameTB.ForeColor = Color.Gray;
            checkinLastNameTB.Text = "Enter Last Name Here";
            checkinLastNameTB.ForeColor = Color.Gray;
            checkinRoomTypeCB.Text = "Select Room Type";
            checkinRoomTypeCB.ForeColor = Color.Gray;
            checkinRoomNumCB.Text = "Select Room Number";
            checkinRoomNumCB.ForeColor = Color.Gray;
            checkinIDNumTB.Text = "Enter ID Number Here";
            checkinIDNumTB.ForeColor = Color.Gray;
            checkinPhoneTB.Text = "Enter Phone Number Here";
            checkinPhoneTB.ForeColor = Color.Gray;
            checkinDTP.MinDate = DateTime.Now;
            checkinDTP.Value = DateTime.Now;
        }
    }
}

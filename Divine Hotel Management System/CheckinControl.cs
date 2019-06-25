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
    public partial class CheckinControl : UserControl
    {
        public CheckinControl()
        {
            InitializeComponent();
            checkinDTP.MinDate = DateTime.Now;
            checkinDTP.Value = DateTime.Now;
        }

        private void CheckinControl_Load(object sender, EventArgs e)
        {
            checkinResNumCB.SelectedValue = null;
            checkinResNumCB.DisplayMember = "reservation_ID";

            Checkin checkin = new Checkin();
            checkinResNumCB.DataSource = checkin.ReservationsComboBox();
            checkinResNumCB.SelectedText = "Select Reservation Number";

            ReloadData();
            ResetForm();

            checkinDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Checkin checkin = new Checkin();
            checkinDGV.DataSource = checkin.ListAll();
        }

        private void checkinB_Click(object sender, EventArgs e)
        {
            if (checkinResNumCB.Text == "Select Reservation Number" || checkinRoomNumCB.Text == "Select Room Number" || checkinTotalAmountTB.Text == "0" || checkinAmountPaidTB.Text == "0" || checkinResNumCB.Text == "")
            {
                MessageBox.Show("Please enter the missing detail to make a checkin!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Checkin checkin = new Checkin();
                checkin.ReservationId = int.Parse(checkinResNumCB.Text);
                checkin.RoomId = int.Parse(checkinRoomNumCB.Text);
                checkin.CheckinDate = DateTime.Parse(checkinDTP.Text);
                checkin.TotalAmount = int.Parse(checkinTotalAmountTB.Text);
                checkin.AmountPaid = int.Parse(checkinAmountPaidTB.Text);
                checkin.Insert(checkin.RoomId);
                checkin.CloseConnection();
                ResetForm();
                ReloadData();
            }
        }

        private void ResetForm()
        {
            checkinResNumCB.Text = "Select Reservation Number";
            checkinRoomNumCB.Text = "Select Room Number";
            checkinDTP.MinDate = DateTime.Now;
            checkinDTP.Value = DateTime.Now;
            checkinTotalAmountTB.Text = "0";
            checkinAmountPaidTB.Text = "0";
        }

        private void checkinResNumCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRow = (checkinResNumCB.SelectedItem as DataRowView);

            string resRoomType = selectedRow["room_type_name"].ToString().Trim();
            checkinTotalAmountTB.Text = selectedRow["total_amount"].ToString().Trim();
            
            Checkin checkin = new Checkin();
            checkinRoomNumCB.DataSource = checkin.RoomsComboBox(resRoomType);
            checkinRoomNumCB.DisplayMember = "room_ID";
            checkinRoomNumCB.SelectedItem = null;
            checkinRoomNumCB.SelectedText = "Select Room Number";

            string tempResColumnValue;          //Temporary variable to store values of the "reservation_ID" column of the DataGridView
            foreach (DataGridViewRow row in checkinDGV.Rows)
            {
                tempResColumnValue = row.Cells[1].Value.ToString();
                if (checkinResNumCB.SelectedIndex == checkinResNumCB.FindStringExact(tempResColumnValue))
                {
                    checkinTotalAmountTB.Text = "0";
                    checkinAmountPaidTB.Text = "0";
                    MessageBox.Show("Sorry! This person has already checked-in. Please select another one!");
                    checkinResNumCB.SelectedText = null;
                }
            }
        }

        private void checkinAmountPaidTB_Enter(object sender, EventArgs e)
        {
            if(checkinAmountPaidTB.Text == "0")
            {
                checkinAmountPaidTB.Text = "";
            }
        }

        private void checkinAmountPaidTB_Leave(object sender, EventArgs e)
        {
            if (checkinAmountPaidTB.Text == "")
            {
                checkinAmountPaidTB.Text = "0";
            }
        }

        private void checkinAmountPaidTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsNumber(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
    }
}

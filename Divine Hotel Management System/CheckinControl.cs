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
            checkinRoomNumCB.DisplayMember = "room_ID";
            checkinRoomNumCB.SelectedItem = null;
            checkinRoomNumCB.SelectedText = "Select Room Number";

            checkinResNumCB.DisplayMember = "reservation_ID";
            checkinResNumCB.SelectedItem = null;
            checkinResNumCB.SelectedText = "Select Reservation Number";
            checkinResNumCB.ValueMember = "room_type_ID";
            ReloadData();
            checkinDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Checkin checkin = new Checkin();
            checkinDGV.DataSource = checkin.ListAll();
            checkinResNumCB.DataSource = checkin.ReservationsComboBox();
        }

        private void checkinB_Click(object sender, EventArgs e)
        {
            if (checkinResNumCB.Text == "Select Reservation Number" || checkinRoomNumCB.Text == "Select Room Number" || checkinAmountPaidTB.Text == "0.00")
            {
                MessageBox.Show("Please enter the missing detail to make a checkin!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Checkin checkin = new Checkin();
                checkin.ReservationId = int.Parse(checkinResNumCB.Text);
                checkin.RoomId = int.Parse(checkinRoomNumCB.Text);
                checkin.CheckinDate = DateTime.Parse(checkinDTP.Text);
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
            checkinAmountPaidTB.Text = "0.00";
        }

        private void checkinResNumCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resRoomType = int.Parse(checkinResNumCB.SelectedValue.ToString().Trim());
            Checkin checkin = new Checkin();
            checkinRoomNumCB.DataSource = checkin.RoomsComboBox(resRoomType);
        }
    }
}

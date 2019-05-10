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
        bool recordSelected;

        private void CheckinControl_Load(object sender, EventArgs e)
        {
            ReloadData();
            checkinDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Checkin checkin = new Checkin();
            checkinDGV.DataSource = checkin.ListAll();
        }

        private void checkinDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            recordSelected = true;
            string checkinId = checkinDGV.SelectedRows[0].Cells[0].Value.ToString();
            Checkin checkin = new Checkin();
            checkin.Get(int.Parse(checkinId));
            checkinResNumCB.Text = checkin.ReservationId.ToString().Trim();
            checkinRoomNumCB.Text = checkin.RoomId.ToString().Trim();
            checkinDTP.Text = checkin.CheckinDate.ToLongDateString().Trim();
            checkinAmountPaidTB.Text = checkin.AmountPaid.ToString().Trim();
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
                checkin.Insert();
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
    }
}

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
    public partial class ReservationControl : UserControl
    {
        public ReservationControl()
        {
            InitializeComponent();
            resCheckinDTP.MinDate = DateTime.Now;
            resCheckinDTP.Value = DateTime.Now;
            resCheckoutDTP.MinDate = DateTime.Now;
            resCheckoutDTP.Value = DateTime.Now;
            resRoomTypeCB.DisplayMember = "room_type_ID";
            resRoomTypeCB.SelectedItem = null;
            resRoomTypeCB.SelectedText = "Select Room ID";
            resRoomTypeCB.ValueMember = "base_price";
        }
        bool recordSelected;
        int daysCount;
        int totalCharges;
        int basePrice;
        DateTime checkinDate;
        DateTime checkoutDate;
        TimeSpan daysSpan;

        private void amenityB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("AmenityControl"))
            {
                AmenityControl amenity = new AmenityControl();
                amenity.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(amenity);
            }
            mainForm.Instance.controlsContainer.Controls["AmenityControl"].BringToFront();
        }

        private void ReservationControl_Load(object sender, EventArgs e)
        {
            ReloadData();
            reservationDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resGuestsIDCB.DisplayMember = "guest_ID";
            resGuestsIDCB.SelectedItem = null;
            resGuestsIDCB.SelectedText = "Select Guest ID";
        }

        private void ReloadData()
        {
            Reservation reservation = new Reservation();
            reservationDGV.DataSource = reservation.ListAll();
            resGuestsIDCB.DataSource = reservation.GuestsComboBox();
            resRoomTypeCB.DataSource = reservation.RoomTypeComboBox();
        }

        private void reservationDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            recordSelected = true;
            string reservationId = reservationDGV.SelectedRows[0].Cells[0].Value.ToString();
            Reservation reservation = new Reservation();
            reservation.Get(int.Parse(reservationId));
            resGuestsIDCB.Text = reservation.GuestId.ToString().Trim();
            resRoomTypeCB.Text = reservation.RoomTypeId.ToString().Trim();
            resCheckinDTP.Text = reservation.CheckinDate.ToLongDateString().Trim();
            resCheckoutDTP.Text = reservation.CheckoutDate.ToLongDateString().Trim();
            resPeopleNumCB.Text = reservation.NumberOfPeople.ToString().Trim();
            resTotalAmountTB.Text = reservation.TotalAmount.ToString().Trim();
        }

        private void addResB_Click(object sender, EventArgs e)
        {
            if (resGuestsIDCB.Text == "Select Guest ID" || resRoomTypeCB.Text == "Select Room Type" || resPeopleNumCB.Text == "Select Number of People" || resTotalAmountTB.Text == "0.00")
            {
                MessageBox.Show("Please enter the missing detail to add a new reservation!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Reservation reservation = new Reservation();
                reservation.GuestId = int.Parse(resGuestsIDCB.Text);
                reservation.RoomTypeId = int.Parse(resRoomTypeCB.Text);
                reservation.CheckinDate = DateTime.Parse(resCheckinDTP.Text);
                reservation.CheckoutDate = DateTime.Parse(resCheckoutDTP.Text);
                reservation.NumberOfPeople = resPeopleNumCB.Text;
                reservation.TotalAmount = int.Parse(resTotalAmountTB.Text);
                reservation.Insert();
                reservation.CloseConnection();
                ResetForm();
                ReloadData();
            }
        }

        private void resDeleteB_Click(object sender, EventArgs e)
        {
            int rowCount = reservationDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no record to be deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this reservation?", "Delete Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Reservation reservation = new Reservation();
                    int reservationId = (int)reservationDGV.SelectedRows[0].Cells[0].Value;
                    reservation.Delete(reservationId);
                    reservation.CloseConnection();
                    ResetForm();
                    ReloadData();
                }
            }
        }

        private void resUpdateB_Click(object sender, EventArgs e)
        {
            int rowCount = reservationDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no record to be updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (recordSelected)
            {
                Reservation reservation = new Reservation();
                reservation.GuestId = int.Parse(resGuestsIDCB.Text);
                reservation.RoomTypeId = int.Parse(resRoomTypeCB.Text);
                reservation.CheckinDate = DateTime.Parse(resCheckinDTP.Text);
                reservation.CheckoutDate = DateTime.Parse(resCheckoutDTP.Text);
                reservation.NumberOfPeople = resPeopleNumCB.Text;
                reservation.TotalAmount = int.Parse(resTotalAmountTB.Text);
                int reservationId = (int)reservationDGV.SelectedRows[0].Cells[0].Value;
                reservation.Update(reservationId);
                reservation.CloseConnection();
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
            resGuestsIDCB.Text = "Select Guest ID";
            resRoomTypeCB.Text = "Select Room Type";
            resCheckinDTP.MinDate = DateTime.Now;
            resCheckinDTP.Value = DateTime.Now;
            resCheckoutDTP.MinDate = DateTime.Now;
            resCheckoutDTP.Value = DateTime.Now;
            resPeopleNumCB.Text = "Select Number of People";
            resTotalAmountTB.Text = "0.00";
        }

        private void resRoomTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            basePrice = int.Parse(resRoomTypeCB.SelectedValue.ToString().Trim());
            daysSpan = checkoutDate.Subtract(checkinDate);
            daysCount = daysSpan.Days;
            totalCharges = daysCount * (basePrice);
            resTotalAmountTB.Text = totalCharges.ToString().Trim();

        }

        private void resCheckoutDTP_ValueChanged(object sender, EventArgs e)
        {
            checkoutDate = resCheckoutDTP.Value;
            daysSpan = checkoutDate.Subtract(checkinDate);
            daysCount = daysSpan.Days;
            totalCharges = daysCount * (basePrice);
            resTotalAmountTB.Text = totalCharges.ToString().Trim();
        }

        private void resCheckinDTP_ValueChanged(object sender, EventArgs e)
        {
            checkinDate = resCheckinDTP.Value;
            daysSpan = checkoutDate.Subtract(checkinDate);
            daysCount = daysSpan.Days;
            totalCharges = daysCount * (basePrice);
            resTotalAmountTB.Text = totalCharges.ToString().Trim();
        }
    }
}

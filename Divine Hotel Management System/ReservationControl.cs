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
        }
        int daysCount;
        int basePrice;
        int roomCharges;
        int amenityCharges;
        int totalCharges;
        DateTime checkinDate;
        DateTime checkoutDate;
        TimeSpan daysSpan;
        bool recordSelected;
        bool checkindateChanged = false;
        bool checkoutdateChanged = false;

        private void ReservationControl_Load(object sender, EventArgs e)
        {
            resGuestsIDCB.SelectedValue = null;
            resGuestsIDCB.DisplayMember = "guest_ID";

            Reservation reservation = new Reservation();
            resGuestsIDCB.DataSource = reservation.GuestsComboBox();
            resGuestsIDCB.SelectedText = "Select Guest ID";

            resRoomTypeCB.DisplayMember = "room_type_name";
            resRoomTypeCB.SelectedItem = null;
            resRoomTypeCB.SelectedText = "Select Room Type";
            resRoomTypeCB.ValueMember = "base_price";

            ReloadData();
            ResetForm();

            resAmenitiesCLB.DisplayMember = "amenity_name";
            resAmenitiesCLB.ValueMember = "price";
            resAmenitiesCLB.ClearSelected();

            reservationDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Reservation reservation = new Reservation();
            reservationDGV.DataSource = reservation.ListAll();
            resRoomTypeCB.DataSource = reservation.RoomTypeComboBox();
            resAmenitiesCLB.DataSource = reservation.AmenitiesCLB();
        }

        private void reservationDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            recordSelected = true;

            string reservationId = reservationDGV.SelectedRows[0].Cells[0].Value.ToString();
            Reservation reservation = new Reservation();
            reservation.Get(int.Parse(reservationId));
            resRoomTypeCB.Text = reservation.RoomType.ToString().Trim();
            resCheckinDTP.MinDate = DateTime.Parse(reservation.CheckinDate.ToLongDateString().Trim());
            resCheckinDTP.Value = DateTime.Parse(reservation.CheckinDate.ToLongDateString().Trim());
            resPeopleNumCB.Text = reservation.NumberOfPeople.ToString().Trim();
            resTotalAmountTB.Text = reservation.TotalAmount.ToString().Trim();

            resGuestsIDCB.Enabled = false;
            resRoomTypeCB.Enabled = false;
            resCheckinDTP.Enabled = false;
            resPeopleNumCB.Enabled = false;
            resAmenitiesCLB.Enabled = false;
            addResB.Enabled = false;
            resDeleteB.Enabled = false;
        }

        private void addResB_Click(object sender, EventArgs e)
        {
            if (resGuestsIDCB.Text == "Select Guest ID" || resRoomTypeCB.Text == "Select Room Type" || resPeopleNumCB.Text == "Select Number of People" || resTotalAmountTB.Text == "0")
            {
                MessageBox.Show("Please enter the missing detail to add a new reservation!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (checkinDate == checkoutDate)
            {
                MessageBox.Show("Checkin date cannot be the same as checkout date!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (checkinDate > checkoutDate)
            {
                MessageBox.Show("Checkin date must be less than the checkout date!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (checkindateChanged)
            {
                if (checkoutdateChanged)
                {
                    Reservation reservation = new Reservation();
                    reservation.GuestId = int.Parse(resGuestsIDCB.Text);
                    reservation.RoomType = resRoomTypeCB.Text;
                    reservation.CheckinDate = DateTime.Parse(resCheckinDTP.Text);
                    reservation.CheckoutDate = DateTime.Parse(resCheckoutDTP.Text);
                    reservation.NumberOfPeople = resPeopleNumCB.Text;
                    if (resAmenitiesCLB.CheckedItems.Count > 0)
                    {
                        for (int i = 0; i < resAmenitiesCLB.CheckedItems.Count; i++)
                        {
                            if (reservation.Amenities == "")
                            {
                                reservation.Amenities = resAmenitiesCLB.GetItemText(resAmenitiesCLB.CheckedItems[i]).ToString();
                            }
                            else
                            {
                                reservation.Amenities += ", " + resAmenitiesCLB.GetItemText(resAmenitiesCLB.CheckedItems[i]).ToString();
                            }
                        }
                    }
                    reservation.TotalAmount = int.Parse(resTotalAmountTB.Text);
                    reservation.Insert();
                    reservation.CloseConnection();

                    ResetForm();
                    ReloadData();
                }
                else
                {
                    MessageBox.Show("Please select a checkout date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else if (checkoutdateChanged)
            {
                if (checkindateChanged)
                {
                    Reservation reservation = new Reservation();
                    reservation.GuestId = int.Parse(resGuestsIDCB.Text);
                    reservation.RoomType = resRoomTypeCB.Text;
                    reservation.CheckinDate = DateTime.Parse(resCheckinDTP.Text);
                    reservation.CheckoutDate = DateTime.Parse(resCheckoutDTP.Text);
                    reservation.NumberOfPeople = resPeopleNumCB.Text;
                    if (resAmenitiesCLB.CheckedItems.Count > 0)
                    {
                        for (int i = 0; i < resAmenitiesCLB.CheckedItems.Count; i++)
                        {
                            if (reservation.Amenities == "")
                            {
                                reservation.Amenities = resAmenitiesCLB.GetItemText(resAmenitiesCLB.CheckedItems[i]).ToString();
                            }
                            else
                            {
                                reservation.Amenities += ", " + resAmenitiesCLB.GetItemText(resAmenitiesCLB.CheckedItems[i]).ToString();
                            }
                        }
                    }
                    reservation.TotalAmount = int.Parse(resTotalAmountTB.Text);
                    reservation.Insert();
                    reservation.CloseConnection();

                    ResetForm();
                    ReloadData();
                }
                else
                {
                    MessageBox.Show("Please select a checkin date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please select appropriate checkin and checkout dates", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                reservation.RoomType = resRoomTypeCB.Text;
                reservation.CheckinDate = DateTime.Parse(resCheckinDTP.Text);
                reservation.CheckoutDate = DateTime.Parse(resCheckoutDTP.Text);
                reservation.NumberOfPeople = resPeopleNumCB.Text;
                reservation.TotalAmount = int.Parse(resTotalAmountTB.Text);
                int reservationId = (int)reservationDGV.SelectedRows[0].Cells[0].Value;
                reservation.Update(reservationId);
                reservation.CloseConnection();

                ResetForm();
                ReloadData();

                resGuestsIDCB.Enabled = true;
                resRoomTypeCB.Enabled = true;
                resCheckinDTP.Enabled = true;
                resPeopleNumCB.Enabled = true;
                resAmenitiesCLB.Enabled = true;
                addResB.Enabled = true;
                resDeleteB.Enabled = true;

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
            resTotalAmountTB.Text = "0";
        }

        private void resGuestsIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempGuestColumnValue;    //Temporary variable to store values of the "guest_ID" column of the DataGridView
            foreach (DataGridViewRow row in reservationDGV.Rows)
            {
                tempGuestColumnValue = row.Cells[1].Value.ToString();
                if (resGuestsIDCB.SelectedIndex == resGuestsIDCB.FindStringExact(tempGuestColumnValue))
                {
                    MessageBox.Show("Sorry! This person has already made a reservation. Please select another one!");
                    resGuestsIDCB.SelectedText = null;
                }
            }
        }

        private void resRoomTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            basePrice = int.Parse(resRoomTypeCB.SelectedValue.ToString().Trim());
            daysSpan = checkoutDate.Subtract(checkinDate);
            daysCount = daysSpan.Days;
            roomCharges = daysCount * (basePrice);
            totalCharges = amenityCharges + roomCharges;
            resTotalAmountTB.Text = totalCharges.ToString().Trim();
        }

        private void resCheckinDTP_ValueChanged(object sender, EventArgs e)
        {
            checkindateChanged = true;
            checkinDate = resCheckinDTP.Value;
            daysSpan = checkoutDate.Subtract(checkinDate);
            daysCount = daysSpan.Days;
            roomCharges = daysCount * (basePrice);
            totalCharges = amenityCharges + roomCharges;
            resTotalAmountTB.Text = totalCharges.ToString().Trim();
        }

        private void resCheckoutDTP_ValueChanged(object sender, EventArgs e)
        {
            checkoutdateChanged = true;
            checkoutDate = resCheckoutDTP.Value;
            daysSpan = checkoutDate.Subtract(checkinDate);
            daysCount = daysSpan.Days;
            roomCharges = daysCount * (basePrice);
            totalCharges = amenityCharges + roomCharges;
            resTotalAmountTB.Text = totalCharges.ToString().Trim();
        }

        private void resAmenitiesCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            resAmenitiesCLB.ClearSelected();
            foreach (DataRowView view in resAmenitiesCLB.CheckedItems)
            {
                amenityCharges = amenityCharges + int.Parse(view[resAmenitiesCLB.ValueMember].ToString());
                totalCharges = amenityCharges + roomCharges;
                resTotalAmountTB.Text = totalCharges.ToString();

                if (e.NewValue == CheckState.Unchecked)
                {
                    amenityCharges = amenityCharges - int.Parse(view[resAmenitiesCLB.ValueMember].ToString());
                    totalCharges = amenityCharges + roomCharges;
                    resTotalAmountTB.Text = totalCharges.ToString();
                }
            }
        }

        private void resAmenitiesCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            amenityCharges = 0;

            foreach (DataRowView view in resAmenitiesCLB.CheckedItems)
            {
                amenityCharges = amenityCharges + int.Parse(view[resAmenitiesCLB.ValueMember].ToString());
            }
            totalCharges = amenityCharges + roomCharges;
            resTotalAmountTB.Text = totalCharges.ToString();
        }

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
    }
}
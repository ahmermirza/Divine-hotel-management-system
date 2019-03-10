﻿using System;
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
    public partial class availabilityForm : Form
    {
        public availabilityForm()
        {
            InitializeComponent();
            availCheckinDTP.MinDate = DateTime.Now;
            availCheckinDTP.Value = DateTime.Now;
            availCheckoutDTP.MinDate = DateTime.Now;
            availCheckoutDTP.Value = DateTime.Now;
        }
        
        private void availCheckoutDT_CloseUp(object sender, EventArgs e)
        {
            
            DateTime fromDate = Convert.ToDateTime(availCheckinDTP.Text);
            DateTime toDate = Convert.ToDateTime(availCheckoutDTP.Text);
            if(fromDate < toDate)
            {
                dateValidityMessageL.ResetText();
            }
            else if(fromDate == toDate)
            {
                dateValidityMessageL.Text= "Check-out date cannot be same as check-in date!";
            }
            else
            {
                dateValidityMessageL.Text = "Please select a valid date!";
            }
        }

        private void availCheckB_Click(object sender, EventArgs e)
        {
            if (availRoomTypeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Room type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("Rooms are available. Would you like to make a reservation?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                reservationForm reservationF = new reservationForm();
                reservationF.ShowDialog();
            }
        }

        private void availRoomTypeCB_TextChanged(object sender, EventArgs e)
        {
            availRoomTypeCB.ForeColor = Color.Black;
        }
    }
}
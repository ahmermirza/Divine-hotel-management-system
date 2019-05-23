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
    public partial class CheckoutControl : UserControl
    {
        public CheckoutControl()
        {
            InitializeComponent();
            checkoutDTP.MinDate = DateTime.Now;
            checkoutDTP.Value = DateTime.Now;
        }

        private void CheckoutControl_Load(object sender, EventArgs e)
        {
            checkoutRoomNumCB.DisplayMember = "room_ID";
            checkoutRoomNumCB.SelectedItem = null;
            checkoutRoomNumCB.SelectedText = "Select Room Number";
            //checkoutRoomNumCB.ValueMember = "checkin_ID";

            ReloadData();
            ResetForm();

            checkoutDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Checkout checkout = new Checkout();
            checkoutDGV.DataSource = checkout.ListAll();
            checkoutRoomNumCB.DataSource = checkout.RoomsComboBox();
        }

        private void checkoutB_Click(object sender, EventArgs e)
        {
            if (checkoutRoomNumCB.Text == "Select Room Number" || checkoutCheckinNumTB.Text == "" || checkoutTotalAmountTB.Text == "0" || checkoutAmountPaidTB.Text == "0" || checkoutRemainingTB.Text == "0")
            {
                MessageBox.Show("Please enter the missing detail to make a checkout!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Checkout checkout = new Checkout();
                checkout.RoomId = int.Parse(checkoutRoomNumCB.Text);
                checkout.CheckinId = int.Parse(checkoutCheckinNumTB.Text);
                checkout.CheckoutDate = DateTime.Parse(checkoutDTP.Text);
                checkout.TotalAmount = int.Parse(checkoutTotalAmountTB.Text);
                checkout.AmountPaid = int.Parse(checkoutAmountPaidTB.Text);
                checkout.Remaining = int.Parse(checkoutRemainingTB.Text);
                checkout.Insert(checkout.RoomId);
                checkout.CloseConnection();

                ResetForm();
                ReloadData();
            }
        }

        private void ResetForm()
        {
            checkoutRoomNumCB.Text = "Select Room Number";
            checkoutCheckinNumTB.Text = "";
            checkoutDTP.MinDate = DateTime.Now;
            checkoutDTP.Value = DateTime.Now;
            checkoutTotalAmountTB.Text = "0";
            checkoutAmountPaidTB.Text = "0";
            checkoutRemainingTB.Text = "0";
        }

        private void checkoutRoomNumCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRow = (checkoutRoomNumCB.SelectedItem as DataRowView);

            checkoutCheckinNumTB.Text = selectedRow["checkin_ID"].ToString().Trim();

            int totalAmount = int.Parse(selectedRow["total_amount"].ToString().Trim());
            int amountPaid = int.Parse(selectedRow["amount_paid"].ToString().Trim());
            int remaining = amountPaid - totalAmount;

            checkoutTotalAmountTB.Text = totalAmount.ToString().Trim();
            checkoutAmountPaidTB.Text = amountPaid.ToString().Trim();
            checkoutRemainingTB.Text = remaining.ToString().Trim();
        }
    }
}
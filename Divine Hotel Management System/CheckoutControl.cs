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
        bool recordSelected;

        private void CheckoutControl_Load(object sender, EventArgs e)
        {
            ReloadData();
            checkoutDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Checkout checkout = new Checkout();
            checkoutDGV.DataSource = checkout.ListAll();
        }

        private void checkoutDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            recordSelected = true;
            string checkoutId = checkoutDGV.SelectedRows[0].Cells[0].Value.ToString();
            Checkout checkout = new Checkout();
            checkout.Get(int.Parse(checkoutId));
            checkoutCheckinNumCB.Text = checkout.CheckinId.ToString().Trim();
            checkoutRoomNumCB.Text = checkout.RoomId.ToString().Trim();
            checkoutDTP.Text = checkout.CheckoutDate.ToLongDateString().Trim();
            checkinAmountPaidTB.Text = checkout.AmountPaid.ToString().Trim();
        }
    }
}

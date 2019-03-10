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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainAvailCheckB_Click(object sender, EventArgs e)
        {
            availabilityForm availabilityF = new availabilityForm();
            availabilityF.ShowDialog();
        }

        private void mainResB_Click(object sender, EventArgs e)
        {
            reservationForm reservationF = new reservationForm();
            reservationF.ShowDialog();
        }

        private void mainCheckinB_Click(object sender, EventArgs e)
        {
            checkinForm checkinF = new checkinForm();
            checkinF.ShowDialog();
        }

        private void mainCheckoutB_Click(object sender, EventArgs e)
        {
            checkoutForm checkOutF = new checkoutForm();
            checkOutF.ShowDialog();
        }

        private void mainAddRoomB_Click(object sender, EventArgs e)
        {
            roomsInfoForm roomsF = new roomsInfoForm();
            roomsF.ShowDialog();
        }

        private void mainEmployeeB_Click(object sender, EventArgs e)
        {
            employeesInfoForm employeesInfoF = new employeesInfoForm();
            employeesInfoF.ShowDialog();
        }

        private void mainLogoutB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are about to logout. Do you want to continue?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                loginForm loginF = new loginForm();
                loginF.ShowDialog();
            }
        }

        private void mainInventoryB_Click(object sender, EventArgs e)
        {
            inventoryInfoForm inventoryInfoF = new inventoryInfoForm();
            inventoryInfoF.ShowDialog();
        }
    }
}

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
            addRoomForm addNewRoomF = new addRoomForm();
            addNewRoomF.ShowDialog();
        }

        private void mainLogoutB_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginF = new loginForm();
            loginF.ShowDialog();
        }
    }
}

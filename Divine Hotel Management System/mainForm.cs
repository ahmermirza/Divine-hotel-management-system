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

        private void checkAvailabilityB_Click(object sender, EventArgs e)
        {
            checkRoomAvailability checkAvailabilityF = new checkRoomAvailability();
            checkAvailabilityF.ShowDialog();
        }

        private void reservationB_Click(object sender, EventArgs e)
        {
            reservationForm reservationF = new reservationForm();
            reservationF.ShowDialog();
        }

        private void checkinB_Click(object sender, EventArgs e)
        {
            checkinForm checkinF = new checkinForm();
            checkinF.ShowDialog();
        }

        private void checkoutB_Click(object sender, EventArgs e)
        {
            Checkout checkOutF = new Checkout();
            checkOutF.ShowDialog();
        }

        private void addRoomB_Click(object sender, EventArgs e)
        {
            Addnewroom addNewRoomF = new Addnewroom();
            addNewRoomF.ShowDialog();
        }
    }
}

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
    public partial class checkoutForm : Form
    {
        public checkoutForm()
        {
            InitializeComponent();
        }

        private void checkoutB_Click(object sender, EventArgs e)
        {
            if(checkoutRoomNumCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Room Number!", "Error");
            }
            else
            {

            }
        }

        private void checkoutRoomNumCB_TextChanged(object sender, EventArgs e)
        {
            checkoutRoomNumCB.ForeColor = Color.Black;
        }
    }
}

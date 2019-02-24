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
    public partial class checkRoomAvailability : Form
    {
        public checkRoomAvailability()
        {
            InitializeComponent();
            availCheckinDTP.MinDate = DateTime.Now;
            availCheckinDTP.Value = DateTime.Now;
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

        private void checkRoomAvailability_Load(object sender, EventArgs e)
        {

        }
    }
}

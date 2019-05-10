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
    public partial class AmenityControl : UserControl
    {
        public AmenityControl()
        {
            InitializeComponent();
        }

        private void reservationB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("ReservationControl"))
            {
                ReservationControl reservation = new ReservationControl();
                reservation.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(reservation);
            }
            mainForm.Instance.controlsContainer.Controls["ReservationControl"].BringToFront();
        }
    }
}

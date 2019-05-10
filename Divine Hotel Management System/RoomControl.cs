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
    public partial class RoomControl : UserControl
    {
        public RoomControl()
        {
            InitializeComponent();
        }

        private void RoomTypeB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("RoomTypeControl"))
            {
                RoomTypeControl roomType = new RoomTypeControl();
                roomType.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(roomType);
            }
            mainForm.Instance.controlsContainer.Controls["RoomTypeControl"].BringToFront();
        }
    }
}

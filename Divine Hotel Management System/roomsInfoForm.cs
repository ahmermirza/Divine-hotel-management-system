using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divine_Hotel_Management_System
{
    public partial class roomsInfoForm : Form
    {

        public roomsInfoForm()
        {
            InitializeComponent();
        }

        private void roomsInfoForm_Load(object sender, EventArgs e)
        {
            this.roomTableTableAdapter.Fill(this.dHMSdatabaseDataSet.roomTable);
        }

        private void addNewRoomB_Click(object sender, EventArgs e)
        {
            addRoomForm addNewRoomF = new addRoomForm();
            addNewRoomF.ShowDialog();
        }
    }
}

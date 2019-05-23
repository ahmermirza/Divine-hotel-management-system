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
        bool recordSelected;

        private void RoomControl_Load(object sender, EventArgs e)
        {
            ReloadData();
            roomDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomDGV.Columns[3].ReadOnly = true;
            roomTypeCB.DisplayMember = "room_type_name";
            roomTypeCB.SelectedItem = null;
            roomTypeCB.SelectedText = "Select Room Type";
        }

        private void ReloadData()
        {
            Room room = new Room();
            roomDGV.DataSource = room.ListAll();
            roomTypeCB.DataSource = room.RoomTypeComboBox();
        }

        private void roomDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            recordSelected = true;
            string roomId = roomDGV.SelectedRows[0].Cells[0].Value.ToString();
            Room room = new Room();
            room.Get(int.Parse(roomId));
            roomNumberTB.Text = room.RoomId.ToString().Trim();
            roomTypeCB.Text = room.RoomType;
            roomFloorNumCB.Text = room.FloorNumber;
            addRoomB.Enabled = false;
            roomDeleteB.Enabled = false;
        }

        private void addRoomB_Click(object sender, EventArgs e)
        {
            if (roomNumberTB.Text == "" || roomTypeCB.Text == "Select Room Type" || roomFloorNumCB.Text == "Select Floor Number")
            {
                MessageBox.Show("Please enter the missing detail to add a new room!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Room room = new Room();
                room.RoomId = int.Parse(roomNumberTB.Text);
                room.RoomType = roomTypeCB.Text;
                room.FloorNumber = roomFloorNumCB.Text;
                room.Insert();
                room.CloseConnection();
                ResetForm();
                ReloadData();
            }
        }

        private void roomDeleteB_Click(object sender, EventArgs e)
        {
            int rowCount = roomDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no room to be deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Room room = new Room();
                    int roomId = (int)roomDGV.SelectedRows[0].Cells[0].Value;
                    room.Delete(roomId);
                    room.CloseConnection();
                    ResetForm();
                    ReloadData();
                }
            }
        }

        private void roomUpdateB_Click(object sender, EventArgs e)
        {
            int rowCount = roomDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no room to be updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (recordSelected)
            {
                Room room = new Room();
                room.RoomId = int.Parse(roomNumberTB.Text);
                room.RoomType = roomTypeCB.Text;
                room.FloorNumber = roomFloorNumCB.Text;
                int roomId = (int)roomDGV.SelectedRows[0].Cells[0].Value;
                room.Update(roomId);
                room.CloseConnection();
                ResetForm();
                ReloadData();
                addRoomB.Enabled = true;
                roomDeleteB.Enabled = true;
                MessageBox.Show("Room updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recordSelected = false;
            }
            else
            {
                MessageBox.Show("To update a room, please double click to select the room first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetForm()
        {
            roomNumberTB.Text = "";
            roomTypeCB.Text = "Select Room Type";
            roomFloorNumCB.Text = "Select Floor Number";
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

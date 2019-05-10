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
    public partial class RoomTypeControl : UserControl
    {
        public RoomTypeControl()
        {
            InitializeComponent();
        }
        bool recordSelected;

        private void BackToRoomsB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("RoomControl"))
            {
                RoomControl room = new RoomControl();
                room.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(room);
            }
            mainForm.Instance.controlsContainer.Controls["RoomControl"].BringToFront();
        }

        private void RoomTypeControl_Load(object sender, EventArgs e)
        {
            ReloadData();
            roomTypeDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            RoomType roomType = new RoomType();
            roomTypeDGV.DataSource = roomType.ListAll();
        }

        private void roomTypeDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            recordSelected = true;
            string roomTypeId = roomTypeDGV.SelectedRows[0].Cells[0].Value.ToString();
            RoomType roomType = new RoomType();
            roomType.Get(int.Parse(roomTypeId));
            roomTypeNameTB.Text = roomType.RoomTypeName;
            roomDescriptionTB.Text = roomType.Description;
            roomBedsCB.Text = roomType.NumberOfBeds;
            roomBasePriceTB.Text = roomType.BasePrice.ToString().Trim();
        }

        private void addRoomTypeB_Click(object sender, EventArgs e)
        {
            if (roomTypeNameTB.Text == "" || roomDescriptionTB.Text == "" || roomBedsCB.Text == "Select Number of Beds" || roomBasePriceTB.Text == "")
            {
                MessageBox.Show("Please enter the missing detail to add a new room type!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RoomType roomType = new RoomType();
                roomType.RoomTypeName = roomTypeNameTB.Text;
                roomType.Description = roomDescriptionTB.Text;
                roomType.NumberOfBeds = roomBedsCB.Text;
                roomType.BasePrice = int.Parse(roomBasePriceTB.Text);
                roomType.Insert();
                roomType.CloseConnection();
                ResetForm();
                ReloadData();
            }
        }

        private void roomTypeDeleteB_Click(object sender, EventArgs e)
        {
            int rowCount = roomTypeDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no room type to be deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this room type?", "Delete Room Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RoomType roomType = new RoomType();
                    int roomTypeId = (int)roomTypeDGV.SelectedRows[0].Cells[0].Value;
                    roomType.Delete(roomTypeId);
                    roomType.CloseConnection();
                    ResetForm();
                    ReloadData();
                }
            }
        }

        private void roomTypeUpdateB_Click(object sender, EventArgs e)
        {
            int rowCount = roomTypeDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no room type to be updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (recordSelected)
            {
                RoomType roomType = new RoomType();
                roomType.RoomTypeName = roomTypeNameTB.Text;
                roomType.Description = roomDescriptionTB.Text;
                roomType.NumberOfBeds = roomBedsCB.Text;
                roomType.BasePrice = int.Parse(roomBasePriceTB.Text);
                int roomTypeId = (int)roomTypeDGV.SelectedRows[0].Cells[0].Value;
                roomType.Update(roomTypeId);
                roomType.CloseConnection();
                ResetForm();
                ReloadData();
                MessageBox.Show("Room type updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recordSelected = false;
            }
            else
            {
                MessageBox.Show("To update a room type, please double click to select the room type first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetForm()
        {
            roomTypeNameTB.Text = "";
            roomDescriptionTB.Text = "";
            roomBedsCB.Text = "Select Number of Beds";
            roomBasePriceTB.Text = "";
        }
    }
}

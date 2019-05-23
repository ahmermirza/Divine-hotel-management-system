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
        bool recordSelected;

        private void AmenityControl_Load(object sender, EventArgs e)
        {
            ReloadData();
            amenityDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Amenity amenity = new Amenity();
            amenityDGV.DataSource = amenity.ListAll();
        }

        private void amenityDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            recordSelected = true;

            string amenityId = amenityDGV.SelectedRows[0].Cells[0].Value.ToString();
            Amenity amenity = new Amenity();
            amenity.Get(int.Parse(amenityId));
            amenityNameTB.Text = amenity.AmenityName;
            amenityDescriptionTB.Text = amenity.Description;
            amenityPriceTB.Text = amenity.Price.ToString().Trim();

            addAmenityB.Enabled = false;
            amenityDeleteB.Enabled = false;
        }

        private void addAmenityB_Click(object sender, EventArgs e)
        {
            if (amenityNameTB.Text == "" || amenityDescriptionTB.Text == "" || amenityPriceTB.Text == "")
            {
                MessageBox.Show("Please enter the missing data to add a new amenity into the system!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Amenity amenity = new Amenity();
                amenity.AmenityName = amenityNameTB.Text;
                amenity.Description = amenityDescriptionTB.Text;
                amenity.Price = int.Parse(amenityPriceTB.Text);
                amenity.Insert();
                amenity.CloseConnection();

                ResetForm();
                ReloadData();
            }
        }

        private void amenityDeleteB_Click(object sender, EventArgs e)
        {
            int rowCount = amenityDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no amenity to be deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this amenity?", "Delete Amenity", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Amenity amenity = new Amenity();
                    int amenityId = (int)amenityDGV.SelectedRows[0].Cells[0].Value;
                    amenity.Delete(amenityId);
                    amenity.CloseConnection();

                    ResetForm();
                    ReloadData();
                }
            }
        }

        private void amenityUpdateB_Click(object sender, EventArgs e)
        {
            int rowCount = amenityDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no amenity to be updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (recordSelected)
            {
                Amenity amenity = new Amenity();
                amenity.AmenityName = amenityNameTB.Text;
                amenity.Description = amenityDescriptionTB.Text;
                amenity.Price = int.Parse(amenityPriceTB.Text);
                int amenityId = (int)amenityDGV.SelectedRows[0].Cells[0].Value;
                amenity.Update(amenityId);
                amenity.CloseConnection();

                ResetForm();
                ReloadData();

                addAmenityB.Enabled = true;
                amenityDeleteB.Enabled = true;

                MessageBox.Show("Amenity updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recordSelected = false;
            }
            else
            {
                MessageBox.Show("To update an amenity, please double click to select the amenity first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetForm()
        {
            amenityNameTB.Text = "";
            amenityDescriptionTB.Text = "";
            amenityPriceTB.Text = "";
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

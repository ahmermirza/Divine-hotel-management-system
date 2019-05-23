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
    public partial class GuestControl : UserControl
    {
        public GuestControl()
        {
            InitializeComponent();
        }
        bool recordSelected;

        private void GuestControl_Load(object sender, EventArgs e)
        {
            ReloadData();
            guestDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Guest guest = new Guest();
            guestDGV.DataSource = guest.ListAll();
        }

        private void guestDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            recordSelected = true;
            string guestId = guestDGV.SelectedRows[0].Cells[0].Value.ToString();
            Guest guest = new Guest();
            guest.Get(int.Parse(guestId));
            guestFirstNameTB.Text = guest.FirstName;
            guestLastNameTB.Text = guest.LastName;
            guestPhoneTB.Text = guest.PhoneNumber;
            guestCNICTB.Text = guest.CnicNumber;
            addGuestB.Enabled = false;
            guestDeleteB.Enabled = false;
        }

        private void addGuestB_Click(object sender, EventArgs e)
        {
            if (guestFirstNameTB.Text == "" || guestLastNameTB.Text == "" || guestPhoneTB.Text == "" || guestCNICTB.Text == "")
            {
                MessageBox.Show("Please enter the missing data to add a new guest!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Guest guest = new Guest();
                guest.FirstName = guestFirstNameTB.Text;
                guest.LastName = guestLastNameTB.Text;
                guest.PhoneNumber = guestPhoneTB.Text;
                guest.CnicNumber = guestCNICTB.Text;
                guest.Insert();
                guest.CloseConnection();
                ResetForm();
                ReloadData();
            }
        }

        private void guestDeleteB_Click(object sender, EventArgs e)
        {
            int rowCount = guestDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no record to be deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this guest?", "Delete Guest", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Guest guest = new Guest();
                    int guestId = (int)guestDGV.SelectedRows[0].Cells[0].Value;
                    guest.Delete(guestId);
                    guest.CloseConnection();
                    ResetForm();
                    ReloadData();
                }
            }
        }

        private void guestUpdateB_Click(object sender, EventArgs e)
        {
            int rowCount = guestDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no record to be updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (recordSelected)
            {
                Guest guest = new Guest();
                guest.FirstName = guestFirstNameTB.Text;
                guest.LastName = guestLastNameTB.Text;
                guest.PhoneNumber = guestPhoneTB.Text;
                guest.CnicNumber = guestCNICTB.Text;
                int guestId = (int)guestDGV.SelectedRows[0].Cells[0].Value;
                guest.Update(guestId);
                guest.CloseConnection();
                ResetForm();
                ReloadData();
                addGuestB.Enabled = true;
                guestDeleteB.Enabled = true;
                MessageBox.Show("Record updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recordSelected = false;
            }
            else
            {
                MessageBox.Show("To update a record, please double click to select the record first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetForm()
        {
            guestFirstNameTB.Text = "";
            guestLastNameTB.Text = "";
            guestPhoneTB.Text = "";
            guestCNICTB.Text = "";
        }
    }
}

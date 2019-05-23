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
        static mainForm tempObj;

        public static mainForm Instance
        {
            get
            {
                if(tempObj == null)
                {
                    tempObj = new mainForm();
                }
                return tempObj;
            }
        }

        public Panel controlsContainer
        {
            get { return controlsPanel; }
            set { controlsPanel = value; }
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            tempObj = this;
            GuestControl guest = new GuestControl();
            guest.Dock = DockStyle.Fill;
            controlsContainer.Controls.Add(guest);
        }

        private void mainGuestB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("GuestControl"))
            {
                GuestControl guest = new GuestControl();
                guest.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(guest);
            }
            mainForm.Instance.controlsContainer.Controls["GuestControl"].BringToFront();
        }

        private void mainResB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("ReservationControl"))
            {
                ReservationControl reservation = new ReservationControl();
                reservation.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(reservation);
            }
            mainForm.Instance.controlsContainer.Controls["ReservationControl"].BringToFront();
        }

        private void mainCheckinB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("CheckinControl"))
            {
                CheckinControl checkin = new CheckinControl();
                checkin.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(checkin);
            }
            mainForm.Instance.controlsContainer.Controls["CheckinControl"].BringToFront();
        }

        private void mainCheckoutB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("CheckoutControl"))
            {
                CheckoutControl checkout = new CheckoutControl();
                checkout.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(checkout);
            }
            mainForm.Instance.controlsContainer.Controls["CheckoutControl"].BringToFront();
        }

        private void mainEmployeeB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("EmployeeControl"))
            {
                EmployeeControl employee = new EmployeeControl();
                employee.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(employee);
            }
            mainForm.Instance.controlsContainer.Controls["EmployeeControl"].BringToFront();
        }

        private void mainInventoryB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("InventoryControl"))
            {
                InventoryControl inventory = new InventoryControl();
                inventory.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(inventory);
            }
            mainForm.Instance.controlsContainer.Controls["InventoryControl"].BringToFront();
        }

        private void mainRoomB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("RoomControl"))
            {
                RoomControl room = new RoomControl();
                room.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(room);
            }
            mainForm.Instance.controlsContainer.Controls["RoomControl"].BringToFront();
        }

        private void mainFoodB_Click(object sender, EventArgs e)
        {
            if (!mainForm.Instance.controlsContainer.Controls.ContainsKey("MenuControl"))
            {
                MenuControl menu = new MenuControl();
                menu.Dock = DockStyle.Fill;
                mainForm.Instance.controlsContainer.Controls.Add(menu);
            }
            mainForm.Instance.controlsContainer.Controls["MenuControl"].BringToFront();
        }

        private void mainLogoutB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are about to logout. Do you want to continue?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                loginForm loginF = new loginForm();
                loginF.ShowDialog();
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            loginForm loginF = new loginForm();
            loginF.ShowDialog();
        }
    }
}

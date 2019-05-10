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
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
        }
        bool recordSelected;

        private void MenuControl_Load(object sender, EventArgs e)
        {
            ReloadData();
            menuDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Menu menu = new Menu();
            menuDGV.DataSource = menu.ListAll();
        }

        private void addMenuB_Click(object sender, EventArgs e)
        {
            if (menuItemTB.Text == "" || menuPriceTB.Text == "")
            {
                MessageBox.Show("Please enter the missing data to add new item to the menu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Menu menu = new Menu();
                menu.ItemName = menuItemTB.Text;
                menu.Price = int.Parse(menuPriceTB.Text);
                menu.Insert();
                menu.CloseConnection();
                ResetForm();
                ReloadData();
            }
        }

        private void deleteMenuB_Click(object sender, EventArgs e)
        {
            int rowCount = menuDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no menu item to be deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this item off the menu?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Menu menu = new Menu();
                    int menuId = (int)menuDGV.SelectedRows[0].Cells[0].Value;
                    menu.Delete(menuId);
                    menu.CloseConnection();
                    ResetForm();
                    ReloadData();
                }
            }
        }

        private void updateMenuB_Click(object sender, EventArgs e)
        {
            int rowCount = menuDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no menu item to be updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (recordSelected)
            {
                Menu menu = new Menu();
                menu.ItemName = menuItemTB.Text;
                menu.Price = int.Parse(menuPriceTB.Text);
                int menuId = (int)menuDGV.SelectedRows[0].Cells[0].Value;
                menu.Update(menuId);
                menu.CloseConnection();
                ResetForm();
                ReloadData();
                MessageBox.Show("Menu Item updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recordSelected = false;
            }
            else
            {
                MessageBox.Show("To update an item, please double click to select the menu item first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetForm()
        {
            menuItemTB.Text = "";
            menuPriceTB.Text = "";
        }
    }
}

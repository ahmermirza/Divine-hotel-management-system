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
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
        }
        bool recordSelected;

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            ReloadData();
            inventoryDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReloadData()
        {
            Inventory inventory = new Inventory();
            inventoryDGV.DataSource = inventory.ListAll();
        }
        
        private void inventoryDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            recordSelected = true;
            string inventoryId = inventoryDGV.SelectedRows[0].Cells[0].Value.ToString();
            Inventory inventory = new Inventory();
            inventory.Get(int.Parse(inventoryId));
            inventoryItemTB.Text = inventory.Name;
            inventoryDescriptionTB.Text = inventory.Description;
            inventoryQuantityTB.Text = inventory.Quantity.ToString().Trim();
            inventoryCostTB.Text = inventory.Cost.ToString().Trim();
            inventoryPurchaseDTP.Text = inventory.PurchaseDate.ToLongDateString().Trim();
        }

        private void addInventoryB_Click(object sender, EventArgs e)
        {
            if(inventoryItemTB.Text == "" || inventoryDescriptionTB.Text == "" || inventoryQuantityTB.Text == "" || inventoryCostTB.Text == "" || inventoryPurchaseDTP.Text == "")
            {
                MessageBox.Show("Please enter the missing data to add new item to the inventory!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Inventory inventory = new Inventory();
                inventory.Name = inventoryItemTB.Text;
                inventory.Description = inventoryDescriptionTB.Text;
                inventory.Quantity = int.Parse(inventoryQuantityTB.Text);
                inventory.Cost = int.Parse(inventoryCostTB.Text);
                inventory.PurchaseDate = DateTime.Parse(inventoryPurchaseDTP.Text);
                inventory.Insert();
                inventory.CloseConnection();
                ResetForm();
                ReloadData();
            }
        }

        private void inventoryDeleteB_Click(object sender, EventArgs e)
        {
            int rowCount = inventoryDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no record to be deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Inventory inventory = new Inventory();
                    int inventoryId = (int)inventoryDGV.SelectedRows[0].Cells[0].Value;
                    inventory.Delete(inventoryId);
                    inventory.CloseConnection();
                    ResetForm();
                    ReloadData();
                }
            }
        }

        private void inventoryUpdateB_Click(object sender, EventArgs e)
        {
            int rowCount = inventoryDGV.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Currently there is no record to be updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (recordSelected)
            {
                Inventory inventory = new Inventory();
                inventory.Name = inventoryItemTB.Text;
                inventory.Description = inventoryDescriptionTB.Text;
                inventory.Quantity = int.Parse(inventoryQuantityTB.Text);
                inventory.Cost = int.Parse(inventoryCostTB.Text);
                inventory.PurchaseDate = DateTime.Parse(inventoryPurchaseDTP.Text);
                int inventoryId = (int)inventoryDGV.SelectedRows[0].Cells[0].Value;
                inventory.Update(inventoryId);
                inventory.CloseConnection();
                ResetForm();
                ReloadData();
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
            inventoryItemTB.Text = "";
            inventoryDescriptionTB.Text = "";
            inventoryQuantityTB.Text = "";
            inventoryCostTB.Text = "";
            inventoryPurchaseDTP.Text = "";
        }
    }
}

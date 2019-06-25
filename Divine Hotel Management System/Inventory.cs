using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divine_Hotel_Management_System
{
    class Inventory
    {
        public int InventoryId;
        public string Name;
        public string Description;
        public int Quantity;
        public int Cost;
        public DateTime PurchaseDate;

        public string conString = "Server=LOCALHOST\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public Inventory()
        {
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
        }

        public DataTable ListAll()
        {
            DataTable inventoryDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM inventories";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(inventoryDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return inventoryDT;
        }

        public Inventory Get(int inventoryId)
        {
            string queryString = "SELECT * FROM inventories WHERE inventory_ID = '" + inventoryId + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable inventoryDT = new DataTable();
            sqlDA.Fill(inventoryDT);

            Name = inventoryDT.Rows[0]["name"].ToString().Trim();
            Description = inventoryDT.Rows[0]["description"].ToString().Trim();
            Quantity = int.Parse(inventoryDT.Rows[0]["quantity"].ToString().Trim());
            Cost = int.Parse(inventoryDT.Rows[0]["cost"].ToString().Trim());
            PurchaseDate = DateTime.Parse(inventoryDT.Rows[0]["date"].ToString().Trim());

            return this;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO inventories (name, description, quantity, cost, date) VALUES('" + Name + "', '" + Description + "', '" + Quantity + "', '" + Cost + "', '" + PurchaseDate + "')";

            SqlCommand sqlCom = new SqlCommand(queryString, sqlCon);
            try
            {
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete(int inventoryId)
        {
            string queryString = "DELETE FROM inventories WHERE inventory_ID = '" + inventoryId + "'";

            SqlCommand sqlCom = new SqlCommand(queryString, sqlCon);
            try
            {
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Update(int inventoryId)
        {
            string queryString = "UPDATE inventories SET name = '" + Name + "', description = '" + Description + "', quantity = '" + Quantity + "', cost = '" + Cost + "', date = '" + PurchaseDate + "' WHERE inventory_ID = '" + inventoryId + "'";

            SqlCommand sqlCom = new SqlCommand(queryString, sqlCon);
            try
            {
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void CloseConnection()
        {
            sqlCon.Close();
        }
    }
}

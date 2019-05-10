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
    class Amenity
    {
        public int AmenityId;
        public int InventoryId;
        public int ReservationId;
        public int Cost;
        public int Quantity;

        public string conString = "Server=LENOVO-PC\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public Amenity()
        {
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
        }

        public DataTable ListAll()
        {
            DataTable amenityDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM amenities";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(amenityDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return amenityDT;
        }

        public Amenity Get(int amenityId)
        {
            string queryString = "SELECT * FROM amenities WHERE amenity_ID = '" + amenityId + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable amenityDT = new DataTable();
            sqlDA.Fill(amenityDT);

            InventoryId = int.Parse(amenityDT.Rows[0]["inventory_ID"].ToString().Trim());
            ReservationId = int.Parse(amenityDT.Rows[0]["reservation_ID"].ToString().Trim());
            Cost = int.Parse(amenityDT.Rows[0]["cost"].ToString().Trim());
            Quantity = int.Parse(amenityDT.Rows[0]["quantity"].ToString().Trim());

            return this;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO amenities (inventory_ID, reservation_ID, cost, quantity) VALUES('" + InventoryId + "', '" + ReservationId + "', '" + Cost + "', '" + Quantity + "')";

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

        public void Delete(int amenityId)
        {
            string queryString = "DELETE FROM amenities WHERE amenity_ID = '" + amenityId + "'";

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

        public void Update(int amenityId)
        {
            string queryString = "UPDATE amenities SET inventory_ID = '" + InventoryId + "', reservation_ID = '" + ReservationId + "', cost = '" + Cost + "', quantity = '" + Quantity + "' WHERE amenity_ID = '" + amenityId + "'";

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

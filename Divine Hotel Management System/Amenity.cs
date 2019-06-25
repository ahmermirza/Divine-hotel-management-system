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
        public string AmenityName;
        public string Description;
        public int Price;

        public string conString = "Server=LOCALHOST\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
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

            AmenityName = amenityDT.Rows[0]["amenity_name"].ToString().Trim();
            Description = amenityDT.Rows[0]["description"].ToString().Trim();
            Price = int.Parse(amenityDT.Rows[0]["price"].ToString().Trim());

            return this;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO amenities (amenity_name, description, price) VALUES('" + AmenityName + "', '" + Description + "', '" + Price + "')";

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
            string queryString = "UPDATE amenities SET amenity_name = '" + AmenityName + "', description = '" + Description + "', price = '" + Price + "' WHERE amenity_ID = '" + amenityId + "'";

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

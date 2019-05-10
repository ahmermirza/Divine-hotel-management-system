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
    class RoomType
    {
        public int RoomTypeId;
        public string RoomTypeName;
        public string Description;
        public string NumberOfBeds;
        public int BasePrice;

        public string conString = "Server=LENOVO-PC\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public RoomType()
        {
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
        }

        public DataTable ListAll()
        {
            DataTable roomTypesDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM room_types";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(roomTypesDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return roomTypesDT;
        }

        public RoomType Get(int roomTypeId)
        {
            string queryString = "SELECT * FROM room_types WHERE room_type_ID = '" + roomTypeId + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable roomTypesDT = new DataTable();
            sqlDA.Fill(roomTypesDT);

            RoomTypeName = roomTypesDT.Rows[0]["room_type_name"].ToString().Trim();
            Description = roomTypesDT.Rows[0]["description"].ToString().Trim();
            NumberOfBeds = roomTypesDT.Rows[0]["number_of_beds"].ToString().Trim();
            BasePrice = int.Parse(roomTypesDT.Rows[0]["base_price"].ToString().Trim());

            return this;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO room_types (room_type_name, description, number_of_beds, base_price) VALUES('" + RoomTypeName + "', '" + Description + "', '" + NumberOfBeds + "', '" + BasePrice + "')";

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

        public void Delete(int roomTypeId)
        {
            string queryString = "DELETE FROM room_types WHERE room_type_ID = '" + roomTypeId + "'";

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

        public void Update(int roomTypeId)
        {
            string queryString = "UPDATE room_types SET room_type_name = '" + RoomTypeName + "', description = '" + Description + "', number_of_beds = '" + NumberOfBeds + "', base_price = '" + BasePrice + "' WHERE room_type_ID = '" + roomTypeId + "'";

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

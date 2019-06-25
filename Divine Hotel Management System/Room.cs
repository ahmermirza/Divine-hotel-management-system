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
    class Room
    {
        public int RoomId;
        public string RoomType;
        public string FloorNumber;
        public bool Occupied = false;

        public string conString = "Server=LOCALHOST\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public Room()
        {
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
        }

        public DataTable ListAll()
        {
            DataTable roomsDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM rooms";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(roomsDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return roomsDT;
        }

        public Room Get(int roomId)
        {
            string queryString = "SELECT * FROM rooms WHERE room_ID = '" + roomId + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable roomsDT = new DataTable();
            sqlDA.Fill(roomsDT);
            RoomId = int.Parse(roomsDT.Rows[0]["room_ID"].ToString().Trim());
            RoomType = roomsDT.Rows[0]["room_type_name"].ToString().Trim();
            FloorNumber = roomsDT.Rows[0]["floor_number"].ToString().Trim();
            
            return this;
        }

        public DataTable RoomTypeComboBox()
        {
            DataTable roomTypeDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM room_types";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(roomTypeDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return roomTypeDT;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO rooms (room_ID, room_type_name, floor_number, occupied) VALUES('" + RoomId + "', '" + RoomType + "', '" + FloorNumber + "', '" + Occupied + "')";

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

        public void Delete(int roomId)
        {
            string queryString = "DELETE FROM rooms WHERE room_ID = '" + roomId + "'";

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

        public void Update(int roomId)
        {
            string queryString = "UPDATE rooms SET room_ID = '" + RoomId + "', room_type_name = '" + RoomType + "', floor_number = '" + FloorNumber + "' WHERE room_ID = '" + roomId + "'";

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

﻿using System;
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
        public int RoomTypeId;
        public string FloorNumber;

        public string conString = "Server=LENOVO-PC\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
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

            RoomTypeId = int.Parse(roomsDT.Rows[0]["room_type_ID"].ToString().Trim());
            FloorNumber = roomsDT.Rows[0]["floor_number"].ToString().Trim();
            
            return this;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO rooms (room_ID, room_type_ID, floor_number) VALUES('" + RoomId + "', '" + RoomTypeId + "', '" + FloorNumber + "')";

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
            string queryString = "UPDATE rooms SET room_ID = '" + RoomId + "', room_type_ID = '" + RoomTypeId + "', floor_number = '" + FloorNumber + "' WHERE room_ID = '" + roomId + "'";

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

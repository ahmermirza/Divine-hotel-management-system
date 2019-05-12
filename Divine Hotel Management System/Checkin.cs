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
    class Checkin
    {
        public int CheckinId;
        public int ReservationId;
        public int RoomId;
        public DateTime CheckinDate;
        public int AmountPaid;

        public string conString = "Server=LENOVO-PC\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public Checkin()
        {
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
        }

        public DataTable ListAll()
        {
            DataTable checkinDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM checkins";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(checkinDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return checkinDT;
        }

        public DataTable ReservationsComboBox()
        {
            DataTable reservationsDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM reservations";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(reservationsDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return reservationsDT;
        }

        public DataTable RoomsComboBox(int roomTypeId)
        {
            DataTable roomsDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM rooms WHERE occupied = '0' AND room_type_ID = '"+ roomTypeId + "'";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(roomsDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return roomsDT;
        }

        public void Insert(int roomId)
        {
            string queryString = "INSERT INTO checkins (reservation_ID, room_ID, checkin_time, amount_paid) VALUES('" + ReservationId + "', '" + RoomId + "', '" + CheckinDate + "', '" + AmountPaid + "') ; UPDATE rooms SET occupied = '1' WHERE room_ID = '" + roomId + "'";

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


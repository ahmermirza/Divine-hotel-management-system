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

        public DataTable GuestIDComboBox()
        {
            DataTable guestIdDT = new DataTable();
            try
            {
                string queryString = "SELECT reservation_ID FROM reservations";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(guestIdDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return guestIdDT;
        }

        public Checkin Get(int checkinId)
        {
            string queryString = "SELECT * FROM checkins WHERE checkin_ID = '" + checkinId + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable checkinDT = new DataTable();
            sqlDA.Fill(checkinDT);

            ReservationId = int.Parse(checkinDT.Rows[0]["reservation_ID"].ToString().Trim());
            RoomId = int.Parse(checkinDT.Rows[0]["room_ID"].ToString().Trim());
            CheckinDate = DateTime.Parse(checkinDT.Rows[0]["checkin_time"].ToString().Trim());
            AmountPaid = int.Parse(checkinDT.Rows[0]["amount_paid"].ToString().Trim());

            return this;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO checkins (reservation_ID, room_ID, checkin_time, amount_paid) VALUES('" + ReservationId + "', '" + RoomId + "', '" + CheckinDate + "', '" + AmountPaid + "')";

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

        public void Delete(int checkinId)
        {
            string queryString = "DELETE FROM checkins WHERE checkin_ID = '" + checkinId + "'";

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

        public void Update(int checkinId)
        {
            string queryString = "UPDATE checkins SET reservation_ID = '" + ReservationId + "', room_ID = '" + RoomId + "', checkin_time = '" + CheckinDate + "', amount_paid = '" + AmountPaid + "' WHERE checkin_ID = '" + checkinId + "'";

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


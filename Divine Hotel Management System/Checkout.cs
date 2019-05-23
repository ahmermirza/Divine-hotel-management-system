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
    class Checkout
    {
        public int CheckoutId;
        public int RoomId;
        public int CheckinId;
        public DateTime CheckoutDate;
        public int TotalAmount;
        public int AmountPaid;
        public int Remaining;

        public string conString = "Server=LENOVO-PC\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public Checkout()
        {
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
        }

        public DataTable ListAll()
        {
            DataTable checkoutDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM checkouts";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(checkoutDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return checkoutDT;
        }

        public DataTable RoomsComboBox()
        {
            DataTable roomsDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM checkins";

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
            string queryString = "INSERT INTO checkouts (room_ID, checkin_ID, checkout_time, total_amount, amount_paid, remaining) VALUES('" + RoomId + "', '" + CheckinId + "', '" + CheckoutDate + "', '" + TotalAmount + "', '" + AmountPaid + "', '" + Remaining + "'); UPDATE rooms SET occupied = '0' WHERE room_ID = '" + roomId + "'";

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

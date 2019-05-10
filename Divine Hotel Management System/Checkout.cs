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
        public int CheckinId;
        public int RoomId;
        public DateTime CheckoutDate;
        public int AmountPaid;

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

        public Checkout Get(int checkoutId)
        {
            string queryString = "SELECT * FROM checkouts WHERE checkout_ID = '" + checkoutId + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable checkoutDT = new DataTable();
            sqlDA.Fill(checkoutDT);

            CheckinId = int.Parse(checkoutDT.Rows[0]["checkin_ID"].ToString().Trim());
            RoomId = int.Parse(checkoutDT.Rows[0]["room_ID"].ToString().Trim());
            CheckoutDate = DateTime.Parse(checkoutDT.Rows[0]["checkout_time"].ToString().Trim());
            AmountPaid = int.Parse(checkoutDT.Rows[0]["amount_paid"].ToString().Trim());

            return this;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO checkouts (checkin_ID, room_ID, checkout_time, amount_paid) VALUES('" + CheckinId + "', '" + RoomId + "', '" + CheckoutDate + "', '" + AmountPaid + "')";

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

        public void Delete(int checkoutId)
        {
            string queryString = "DELETE FROM checkouts WHERE checkout_ID = '" + checkoutId + "'";

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

        public void Update(int checkoutId)
        {
            string queryString = "UPDATE checkouts SET checkin_ID = '" + CheckinId + "', room_ID = '" + RoomId + "', checkout_time = '" + CheckoutDate + "', amount_paid = '" + AmountPaid + "' WHERE checkout_ID = '" + checkoutId + "'";

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

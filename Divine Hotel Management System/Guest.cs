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
    class Guest
    {
        public int GuestId;
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string CnicNumber;

        public string conString = "Server=LOCALHOST\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public Guest()
        {
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
        }

        public DataTable ListAll()
        {
            DataTable guestsDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM guests";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(guestsDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return guestsDT;
        }

        public Guest Get(int guestId)
        {
            string queryString = "SELECT * FROM guests WHERE guest_ID = '" + guestId + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable guestsDT = new DataTable();
            sqlDA.Fill(guestsDT);

            FirstName = guestsDT.Rows[0]["first_name"].ToString().Trim();
            LastName = guestsDT.Rows[0]["last_name"].ToString().Trim();
            PhoneNumber = guestsDT.Rows[0]["phone_number"].ToString().Trim();
            CnicNumber = guestsDT.Rows[0]["CNIC_number"].ToString().Trim();

            return this;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO guests (first_name, last_name, phone_number, CNIC_number) VALUES('" + FirstName + "', '" + LastName + "', '" + PhoneNumber + "', '" + CnicNumber + "')";

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

        public void Delete(int guestId)
        {
            string queryString = "DELETE FROM guests WHERE guest_ID = '" + guestId + "'";

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

        public void Update(int guestId)
        {
            string queryString = "UPDATE guests SET first_name = '" + FirstName + "', last_name = '" + LastName + "', phone_number = '" + PhoneNumber + "', CNIC_number = '" + CnicNumber + "' WHERE guest_ID = '" + guestId + "'";

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

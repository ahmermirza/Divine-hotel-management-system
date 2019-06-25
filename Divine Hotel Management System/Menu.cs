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
    class Menu
    {
        public int MenuId;
        public string ItemName;
        public int Price;

        public string conString = "Server=LOCALHOST\\SQLEXPRESS;Database=DHMSdatabase;Integrated Security=True";
        SqlConnection sqlCon;

        public Menu()
        {
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
        }

        public DataTable ListAll()
        {
            DataTable menuDT = new DataTable();
            try
            {
                string queryString = "SELECT * FROM menu";

                SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
                sqlDA.Fill(menuDT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return menuDT;
        }

        public Menu Get(int menuId)
        {
            string queryString = "SELECT * FROM menu WHERE menu_ID = '" + menuId + "'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(queryString, sqlCon);
            DataTable menuDT = new DataTable();
            sqlDA.Fill(menuDT);

            ItemName = menuDT.Rows[0]["menu_item"].ToString().Trim();
            Price = int.Parse(menuDT.Rows[0]["price"].ToString().Trim());

            return this;
        }

        public void Insert()
        {
            string queryString = "INSERT INTO menu (menu_item, price) VALUES('" + ItemName + "', '" + Price + "')";

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

        public void Delete(int menuId)
        {
            string queryString = "DELETE FROM menu WHERE menu_ID = '" + menuId + "'";

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

        public void Update(int menuId)
        {
            string queryString = "UPDATE menu SET menu_item = '" + ItemName + "', price = '" + Price + "' WHERE menu_ID = '" + menuId + "'";

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Library_Managment
{
    class Security
    {
        private string username;
        private string password;
        private static int ID;
        public bool isValid(string myUser, string myKey)
        {
            username = myUser;
            password = myKey;

            SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=BlackBox;Integrated Security=True");
            string query = "Select * from tbl_Black_Box Where Username = '" + this.username.Trim() + "' and Password = '" + this.password.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count!=0)
            {
                ID = Convert.ToInt32(dtbl.Rows[0][0].ToString());
                return true;
            }
            else
                return false;
        }

        public static int returnUserID()
        {
            return ID;
        }
    }
}

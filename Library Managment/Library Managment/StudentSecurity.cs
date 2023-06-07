using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_Managment
{
    class StudentSecurity
    {
        private string Reg_No;
        private string CNIC;
        private static int ID;
        public bool isValid(string myUser, string myKey)
        {
            Reg_No = myUser;
            CNIC = myKey;

            SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");
            string query = "Select * from tbl_Students_Record Where Reg_No = '" + this.Reg_No.Trim() + "' and CNIC = '" + this.CNIC.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                ID = Convert.ToInt32(dtbl.Rows[0][0]);
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

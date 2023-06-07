using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Library_Managment
{
    public partial class DisplayStudentProfileForm : Form
    {
        public DisplayStudentProfileForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");
        private int ID;

        private byte[] img;

        private void fillProfile()
        {
            try
            {
                this.ID = Students.passStudentID();
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM tbl_Students_Record WHERE Student_ID=@Student_ID", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Student_ID", this.ID);
                DataTable dtbl = new DataTable();

                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dtbl.Load(reader);
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();

                lbl_StuPro_Name.Text = dtbl.Rows[0][1].ToString();
                lbl_StuPro_FName.Text = dtbl.Rows[0][2].ToString();
                lbl_StuPro_CNIC.Text = dtbl.Rows[0][3].ToString();
                lbl_StuPro_Gender.Text = dtbl.Rows[0][4].ToString();
                lbl_StuPro_Cont.Text = dtbl.Rows[0][5].ToString();
                lbl_StuPro_Mail.Text = dtbl.Rows[0][6].ToString();
                lbl_StuPro_Reg.Text = dtbl.Rows[0][7].ToString();
                lbl_StuPro_Sec.Text = dtbl.Rows[0][8].ToString();
                lbl_StuPro_Sem.Text = dtbl.Rows[0][9].ToString();
                lbl_StuPro_Dept.Text = dtbl.Rows[0][10].ToString();

                img = (Byte[])dtbl.Rows[0][11];
                convImg_Extract();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void convImg_Extract()
        {
            MemoryStream myStream = new MemoryStream((Byte[])img);
            pBox_StuPro_Stu.Image = Image.FromStream(myStream);
        }

        private void DisplayStudentProfileForm_Load(object sender, EventArgs e)
        {
            try
            {
                fillProfile();
                convImg_Extract();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        public void setStudentID(int id)
        {
            ID = id;
        }

        private void lbl_StuPro_Head_Click(object sender, EventArgs e)
        {

        }
    }
}

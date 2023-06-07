using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Library_Managment
{
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");

        byte[] img;
        static int returnBookID;

        private void txt_ReturnBk_Stu_Reg_Click(object sender, EventArgs e)
        {
            if (txt_ReturnBk_Stu_Reg.Text == "" || txt_ReturnBk_Stu_Reg.Text == "2019-MC-263")
            {
                txt_ReturnBk_Stu_Reg.Text = "";
                txt_ReturnBk_Stu_Reg.ForeColor = Color.Black;
            }
        }

        private void txt_ReturnBk_Stu_Reg_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void extractIssuedBookData()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM tbl_Issue_Book_Record WHERE Reg_No LIKE '%'+@Reg_No+'%'", sqlCon);
            sqlCmd.Parameters.AddWithValue("@Reg_No", txt_ReturnBk_Stu_Reg.Text);
            DataTable dtbl = new DataTable();

            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();

            dgView_ReturnBk.DataSource = dtbl;
            dgView_ReturnBk.Columns[0].Visible = false;
            dgView_ReturnBk.Columns[1].Visible = false;
        }

        private void extractStudentData()
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM tbl_Students_Record WHERE Reg_No LIKE '%'+@Reg_No+'%'", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Reg_No", txt_ReturnBk_Stu_Reg.Text);
                DataTable dtbl = new DataTable();

                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dtbl.Load(reader);
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();

                lbl_ReturnBk_Stu_Name.Text = dtbl.Rows[0][1].ToString();
                lbl_ReturnBk_Stu_Sec.Text = dtbl.Rows[0][8].ToString();
                lbl_ReturnBk_Stu_Sem.Text = dtbl.Rows[0][9].ToString();
                lbl_ReturnBk_Stu_Dept.Text = dtbl.Rows[0][10].ToString();
                img = (Byte[])dtbl.Rows[0][11];
                MemoryStream myStream = new MemoryStream((Byte[])img);
                pBox_ReturnBk_Stu.Image = Image.FromStream(myStream);
            }

            catch (Exception ex)
            {
                if (ex.Message.ToString() == "There is no row at position 0.")
                    MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ReturnBk_Stu_Reg_Leave(object sender, EventArgs e)
        {
            if (txt_ReturnBk_Stu_Reg.Text == "")
            {
                txt_ReturnBk_Stu_Reg.Text = "2019-MC-263";
                txt_ReturnBk_Stu_Reg.ForeColor = Color.Gray;
            }
            else
            {
                extractStudentData();
                extractIssuedBookData();
            }
        }

        private void txt_ReturnBk_Stu_Reg_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                extractStudentData();
                extractIssuedBookData();
            }
        }

        private void dgView_ReturnBk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //returnBookID = Convert.ToInt32(dgView_ReturnBk.SelectedRows[0].Cells[0].Value.ToString());
            lbl_ReturnBk_Bk_ISBN.Text = dgView_ReturnBk.SelectedRows[0].Cells[0].Value.ToString();

            dtPick_ReturnBk_Issue_Date.Value = Convert.ToDateTime(dgView_ReturnBk.SelectedRows[0].Cells[1].Value);
            DateTime issueTill = Convert.ToDateTime(dgView_ReturnBk.SelectedRows[0].Cells[2].Value);
            DateTime returnDate = DateTime.Today;
            int days = Convert.ToInt32(returnDate.Subtract(issueTill).TotalDays);
            if (days < 0)
            {
                lbl_ReturnBk_Days.ForeColor = Color.Green;
                days = Math.Abs(days);
                lbl_ReturnBk_Days.Text = Convert.ToString(days) + " Left";
            }
            else
            {
                lbl_ReturnBk_Days.ForeColor = Color.Red;
                days = Math.Abs(days);
                lbl_ReturnBk_Days.Text = Convert.ToString(days) + " Passed";
                lbl_ReturnBk_Fine.Text += 20 * days;
            }
        }

        private void incrementBook_BookRecord()
        {
            SqlCommand readCmd = new SqlCommand("Select * FROM tbl_Books_Record WHERE ISBN=@ISBN", sqlCon);
            readCmd.Parameters.AddWithValue("@ISBN", lbl_ReturnBk_Bk_ISBN.Text);
            DataTable dtbl = new DataTable();

            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            SqlDataReader reader = readCmd.ExecuteReader();
            dtbl.Load(reader);
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();

            int quantity = Convert.ToInt32(dtbl.Rows[0][6].ToString());
            quantity++;

            SqlCommand writeCmd = new SqlCommand("UPDATE tbl_Books_Record SET Quantity=@Quantity WHERE ISBN=@ISBN", sqlCon);
            writeCmd.Parameters.AddWithValue("@ISBN", lbl_ReturnBk_Bk_ISBN.Text);
            writeCmd.Parameters.AddWithValue("@Quantity", quantity);
            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            writeCmd.ExecuteNonQuery();
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private void deleteBook_StudentRecord()
        {
            SqlCommand sqlCmd = new SqlCommand("DELETE FROM tbl_Issue_Book_Record WHERE Book_ISBN=@Book_ISBN", sqlCon);
            sqlCmd.Parameters.AddWithValue("@Book_ISBN", lbl_ReturnBk_Bk_ISBN.Text);

            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private void btn_ReturnBk_Return_Click(object sender, EventArgs e)
        {
            if (lbl_ReturnBk_Fine.Text.Length > 5 && chk_ReturnBk_IsFinePaid.Checked == false)
                MessageBox.Show("Submit the dues first", "Dues Pending", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                deleteBook_StudentRecord();
                incrementBook_BookRecord();
                extractIssuedBookData();
            }
        }

        private void btn_ReturnBk_Clear_Click(object sender, EventArgs e)
        {
            lbl_ReturnBk_Stu_Name.Text = "";
            lbl_ReturnBk_Bk_ISBN.Text = "";
            lbl_ReturnBk_Days.Text = "";
            lbl_ReturnBk_Fine.Text = "";
            lbl_ReturnBk_Stu_Dept.Text = "";
            lbl_ReturnBk_Stu_Sec.Text = "";
            lbl_ReturnBk_Stu_Sem.Text = "";
            dtPick_ReturnBk_Issue_Date.Value = DateTime.Today;
            chk_ReturnBk_IsFinePaid.Checked = false;
            pBox_ReturnBk_Stu.Image = null;
            dgView_ReturnBk.DataSource = null;
        }

        private void btn_ReturnBk_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void enableDock()
        {
            btn_ReturnBk_Back.Hide();
        }
    }
}

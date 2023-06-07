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
using System.Threading;

namespace Library_Managment
{
    public partial class IssueBookForm : Form
    {
        public IssueBookForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");

        static int tempID;
        static int ID;
        static string BookISBN = "";
        byte[] img;

        public void passBookID4Issue(int ID)
        {
            IssueBookForm.ID = ID;
            IssueBookForm.tempID = ID;

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            chk_Date_Today.Checked = true;
            chk_Till_Default.Checked = true;
            btn_IssueBk_ClearCancel.Hide();

            txt_IssueBk_Stu_Reg.Text = "2019-MC-263";
            txt_IssueBk_Stu_Reg.ForeColor = Color.Gray;

            dtPick_IssueBk_Till_Date.Value = dtPick_IssueBk_Issue_Date.Value.AddDays(20);
        }

        private void chk_Date_Today_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Date_Today.Checked == true)
                dtPick_IssueBk_Issue_Date.Enabled = false;
            else
                dtPick_IssueBk_Issue_Date.Enabled = true;
        }

        private void chk_Till_Defalut_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Till_Default.Checked == true)
                dtPick_IssueBk_Till_Date.Enabled = false;
            else
                dtPick_IssueBk_Till_Date.Enabled = true;
        }

        private async void btn_IssueBtn_Srch_Click(object sender, EventArgs e)
        {
            SearchBookForm myBookSearch = new SearchBookForm();
            myBookSearch.Show();
            Task<bool> task = new Task<bool>(executeTask);
            task.Start();

            bool myVar = await task;
            if (myVar)
            {
                extractBookData();
                tempID = 0;
            }
        }

        private bool executeTask()
        {
            while (tempID == 0) ;
            return true;
        }

        private async void btn_IssueBtn_Pick_Click(object sender, EventArgs e)
        {
            DisplayBooksForm myBookDisplay = new DisplayBooksForm();
            myBookDisplay.bookForIssue();
            myBookDisplay.Show();

            Task<bool> task = new Task<bool>(executeTask);
            task.Start();

            bool myVar = await task;
            if (myVar)
            {
                extractBookData();
                tempID = 0;
            }
        }

        private void btn_IssueBk_Cancel_Click(object sender, EventArgs e)
        {
            clearAll();
            this.Hide();
        }

        private void clearAll()
        {
            txt_IssueBk_Stu_Reg.Text = "";
            lbl_IssueBk_Stu_Name.Text = "";
            lbl_IssueBk_Stu_Sec.Text = "";
            lbl_IssueBk_Stu_Sem.Text = "";
            lbl_IssueBk_Stu_Dept.Text = "";
            lbl_IssueBk_Title.Text = "";
            lbl_IssueBk_Auth.Text = "";
            lbl_IssueBk_Edt.Text = "";
            lbl_IssueBk_Pub.Text = "";
            pBox_IssueBk_Stu.Image = null;
            dtPick_IssueBk_Issue_Date.Value = DateTime.Today;
            dtPick_IssueBk_Till_Date.Value = dtPick_IssueBk_Issue_Date.Value.AddDays(20);
            chk_Date_Today.Checked = true;
            chk_Till_Default.Checked = true;
            ID = 0;
            tempID = 0;
            BookISBN = "";
        }

        private void btn_IssueBk_ClearCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void enableClearCancel()
        {
            btn_IssueBk_Cancel.Hide();
            btn_IssueBk_ClearCancel.Show();
        }

        private void txt_IssueBk_Stu_Reg_Leave(object sender, EventArgs e)
        {
            if (txt_IssueBk_Stu_Reg.Text == "")
            {
                txt_IssueBk_Stu_Reg.Text = "2019-MC-263";
                txt_IssueBk_Stu_Reg.ForeColor = Color.Gray;
            }
            else
                extractStudentData();
        }

        private void extractStudentData()
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM tbl_Students_Record WHERE Reg_No LIKE '%'+@Reg_No+'%'", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Reg_No", txt_IssueBk_Stu_Reg.Text);
                DataTable dtbl = new DataTable();

                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dtbl.Load(reader);
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();

                lbl_IssueBk_Stu_Name.Text = dtbl.Rows[0][1].ToString();
                lbl_IssueBk_Stu_Sec.Text = dtbl.Rows[0][8].ToString();
                lbl_IssueBk_Stu_Sem.Text = dtbl.Rows[0][9].ToString();
                lbl_IssueBk_Stu_Dept.Text = dtbl.Rows[0][10].ToString();
                img = (Byte[])dtbl.Rows[0][11];
                MemoryStream myStream = new MemoryStream((Byte[])img);
                pBox_IssueBk_Stu.Image = Image.FromStream(myStream);
            }

            catch (Exception ex)
            {
                if (ex.Message.ToString() == "There is no row at position 0.")
                    MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_IssueBk_Stu_Reg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                extractStudentData();
        }

        private void extractBookData()
        {
            if (ID != 0)
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM tbl_Books_Record WHERE BookID=@BookID", sqlCon);
                sqlCmd.Parameters.AddWithValue("@BookID", ID);
                DataTable dtbl = new DataTable();

                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dtbl.Load(reader);
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();

                lbl_IssueBk_Title.Text = dtbl.Rows[0][1].ToString();
                lbl_IssueBk_Auth.Text = dtbl.Rows[0][2].ToString();
                lbl_IssueBk_Edt.Text = dtbl.Rows[0][3].ToString();
                lbl_IssueBk_Pub.Text = dtbl.Rows[0][4].ToString();
                BookISBN = dtbl.Rows[0][7].ToString();
            }
        }

        private void btn_IssueBk_Issue_Click(object sender, EventArgs e)
        {
            if (_isValid_IssueData())
                issueBook();
            else
                MessageBox.Show("No Student or Book Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void issueBook()
        {
            try
            {
                writeIssueData();
                decrementBook_BookRecord();
                incrementBook_StudentRecord();
                MessageBox.Show("Books Issued", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void writeIssueData()
        {
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO tbl_Issue_Book_Record VALUES (@Reg_No, @Book_Title, @Book_ISBN, @Issue_From, @Issue_Till)", sqlCon);
            sqlCmd.Parameters.AddWithValue("@Reg_No", txt_IssueBk_Stu_Reg.Text);
            sqlCmd.Parameters.AddWithValue("@Book_Title", lbl_IssueBk_Title.Text);
            sqlCmd.Parameters.AddWithValue("@Book_ISBN", BookISBN);
            dtPick_IssueBk_Till_Date.CustomFormat = "dd/MMM/yyyy";
            sqlCmd.Parameters.AddWithValue("@Issue_From", dtPick_IssueBk_Issue_Date.Value.Date.ToString("D"));
            sqlCmd.Parameters.AddWithValue("@Issue_Till", dtPick_IssueBk_Till_Date.Value.Date.ToString("D"));

            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private void decrementBook_BookRecord()
        {
            SqlCommand readCmd = new SqlCommand("Select * FROM tbl_Books_Record WHERE BookID=@BookID", sqlCon);
            readCmd.Parameters.AddWithValue("@BookID", ID);
            DataTable dtbl = new DataTable();

            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            SqlDataReader reader = readCmd.ExecuteReader();
            dtbl.Load(reader);
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();

            int quantity = Convert.ToInt32(dtbl.Rows[0][6].ToString());
            quantity--;

            SqlCommand writeCmd = new SqlCommand("UPDATE tbl_Books_Record SET Quantity=@Quantity WHERE BookID=@BookID", sqlCon);
            writeCmd.Parameters.AddWithValue("@BookID", ID);
            writeCmd.Parameters.AddWithValue("@Quantity", quantity);
            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            writeCmd.ExecuteNonQuery();
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private void incrementBook_StudentRecord()
        {
            SqlCommand readCmd = new SqlCommand("Select * FROM tbl_Students_Record WHERE Reg_No LIKE '%'+@Reg_No+'%'", sqlCon);
            readCmd.Parameters.AddWithValue("@Reg_No", txt_IssueBk_Stu_Reg.Text);
            DataTable dtbl = new DataTable();

            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            SqlDataReader reader = readCmd.ExecuteReader();
            dtbl.Load(reader);
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();

            int issued = Convert.ToInt32(dtbl.Rows[0][12].ToString());
            issued++;

            SqlCommand writeCmd = new SqlCommand("UPDATE tbl_Students_Record SET Issued=@Books_Issued WHERE Reg_No LIKE '%'+@Reg_No+'%'", sqlCon);
            writeCmd.Parameters.AddWithValue("@Reg_No", txt_IssueBk_Stu_Reg.Text);
            writeCmd.Parameters.AddWithValue("@Books_Issued", issued);
            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            writeCmd.ExecuteNonQuery();
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private bool _isValid_IssueData()
        {
            if (lbl_IssueBk_Stu_Name.Text != "" && lbl_IssueBk_Title.Text != "")
                return true;
            else
                return false;
        }

        private void txt_IssueBk_Stu_Reg_Click(object sender, EventArgs e)
        {
            if (txt_IssueBk_Stu_Reg.ForeColor == Color.Gray)
                txt_IssueBk_Stu_Reg.Text = "";
        }
    }
}
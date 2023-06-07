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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");

        static int ID;
        byte[] img;

        private void displayUserInfo()
        {
            try
            {
                ID = StudentSecurity.returnUserID();
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM tbl_Students_Record WHERE Student_ID=@ID", sqlCon);
                sqlCmd.Parameters.AddWithValue("@ID", ID);
                DataTable dtbl = new DataTable();

                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dtbl.Load(reader);
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();

                if (dtbl.Rows[0][3].ToString() != "")
                    lbl_StudentForm_User_Display_Name.Text = dtbl.Rows[0][1].ToString();
                if (dtbl.Rows[0][4].ToString() != "")
                    lbl_StudentForm_User_Display_Reg.Text = dtbl.Rows[0][7].ToString();
                if (dtbl.Rows[0][5].ToString() != "")
                {
                    img = (Byte[])dtbl.Rows[0][11];
                    convImg_Extract();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void convImg_Extract()
        {
            MemoryStream myStream = new MemoryStream((Byte[])img);
            pBox_StudentForm_User_Display.Image = Image.FromStream(myStream);
        }

        private void displayBookList()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT Title FROM tbl_Books_Record", sqlCon);
            DataTable dtbl = new DataTable();

            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();

            dgView_Student_BooksList.DataSource = dtbl;
        }

        private void dockBookIssue()
        {
            IssueBookForm myBookIssue = new IssueBookForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myBookIssue.FormBorderStyle = FormBorderStyle.None;
            this.pnl_Student_BkIssue.Controls.Add(myBookIssue);
            myBookIssue.Show();
            myBookIssue.enableClearCancel();
        }

        private void dockBookSearch()
        {
            SearchBookForm myBookSearch = new SearchBookForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myBookSearch.FormBorderStyle = FormBorderStyle.None;
            this.pnl_Student_SrStu.Controls.Add(myBookSearch);
            myBookSearch.Show();
            myBookSearch.dockEnable();
        }

        private void dockBookReturn()
        {
            ReturnBookForm myReturnBook = new ReturnBookForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myReturnBook.FormBorderStyle = FormBorderStyle.None;
            this.pnl_Student_ReturnBook.Controls.Add(myReturnBook);
            myReturnBook.enableDock();
            myReturnBook.Show();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            Library myLibrary = new Library();
            Library.setRackData(10, 5);
            Library.setBooksPerRack(120);

            dockBookIssue();
            dockBookSearch();
            displayBookList();
            displayUserInfo();
            dockBookReturn();
        }

        private void displayProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayStudentProfileForm myCard = new DisplayStudentProfileForm();
            myCard.setStudentID(ID);
            myCard.Show();
        }

        private void displayBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBooksForm myDisplayBooks = new DisplayBooksForm();
            myDisplayBooks.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm myLoginForm = new LoginForm();
            this.Hide();
            myLoginForm.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBookForm mySearchBook = new SearchBookForm();
            mySearchBook.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBookForm myIssueBook = new IssueBookForm();
            myIssueBook.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm myReturnBook = new ReturnBookForm();
            myReturnBook.Show();
        }
    }
}

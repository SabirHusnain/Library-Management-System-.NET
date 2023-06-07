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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        byte[] img;

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");
        SqlConnection sqlSec = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=BlackBox;Integrated Security=True");

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooksForm BookAdd = new AddBooksForm();
            BookAdd.invokeAdd();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login_form = new LoginForm();
            login_form.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void showBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBooksForm myBooksDisplay = new DisplayBooksForm();
            myBooksDisplay.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm UserAdd = new AddUserForm();
            UserAdd.Show();
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addExistingBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExistingBookForm myExistingBook = new AddExistingBookForm();
            myExistingBook.Show();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBookForm srchBk = new SearchBookForm();
            srchBk.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Library myLibrary = new Library();
            Library.setRackData(10, 5);
            Library.setBooksPerRack(120);

            dockBookIssue();
            dockStudentSearch();
            displayBookList();
            displayUserInfo();
            dockBookReturn();
        }

        private void displayUserInfo()
        {
            try
            {
                int ID = Security.returnUserID();
                Console.WriteLine(ID);
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM tbl_Black_Box WHERE userId=@ID", sqlSec);
                sqlCmd.Parameters.AddWithValue("@ID", ID);
                DataTable dtbl = new DataTable();
                if (sqlSec.State != ConnectionState.Open)
                    sqlSec.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dtbl.Load(reader);
                if (sqlSec.State == ConnectionState.Open)
                    sqlSec.Close();

                if (dtbl.Rows[0][3].ToString() != "")
                    lbl_AdminForm_User_Display_Name.Text = dtbl.Rows[0][3].ToString();
                if (dtbl.Rows[0][4].ToString() != "")
                    lbl_AdminForm_User_Display_Email.Text = dtbl.Rows[0][4].ToString();
                if (dtbl.Rows[0][5].ToString() != "")
                {
                    img = (Byte[])dtbl.Rows[0][5];
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
            pBox_AdminForm_User_Display.Image = Image.FromStream(myStream);
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

            dgView_Admin_BooksList.DataSource = dtbl;
        }

        private void dockBookIssue()
        {
            IssueBookForm myBookIssue = new IssueBookForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myBookIssue.FormBorderStyle = FormBorderStyle.None;
            this.pnl_Admin_BkIssue.Controls.Add(myBookIssue);
            myBookIssue.Show();
            myBookIssue.enableClearCancel();
        }

        private void dockStudentSearch()
        {
            SearchStudentForm myStudentSearch = new SearchStudentForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myStudentSearch.FormBorderStyle = FormBorderStyle.None;
            this.pnl_Admin_SrStu.Controls.Add(myStudentSearch);
            myStudentSearch.Show();
            myStudentSearch.enableClear();
        }

        private void dockBookReturn()
        {
            ReturnBookForm myReturnBook = new ReturnBookForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myReturnBook.FormBorderStyle = FormBorderStyle.None;
            this.pnl_Admin_ReturnBook.Controls.Add(myReturnBook);
            myReturnBook.enableDock();
            myReturnBook.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBookForm myBookIssue = new IssueBookForm();
            myBookIssue.Show();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm myStudentAdd = new AddStudentForm();
            myStudentAdd.Show();
        }

        private void viewStudentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayStudentForm myStudentDisplay = new DisplayStudentForm();
            myStudentDisplay.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudentForm myStudentSearch = new SearchStudentForm();
            myStudentSearch.Show();
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm myReturnBook = new ReturnBookForm();
            myReturnBook.Show();
        }
    }
}
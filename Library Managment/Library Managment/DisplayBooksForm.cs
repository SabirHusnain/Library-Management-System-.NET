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

namespace Library_Managment
{
    public partial class DisplayBooksForm : Form
    {
        public DisplayBooksForm()
        {
            InitializeComponent();
        }

        private static int ID = 0;
        private bool rowSelected = false;

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");

        private void DisplayBooksForm_Load(object sender, EventArgs e)
        {
            displayBooksRecord();
        }

        public void invokeDisplayBooksRecord()
        {
            this.displayBooksRecord();
        }

        private void displayBooksRecord()
        {
            SqlCommand sqlCmd = new SqlCommand("Select * from tbl_Books_Record", sqlCon);
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_BooksRecord.DataSource = dtbl;
            dgView_BooksRecord.Columns[0].Visible = false;
        }

        private void btn_DpBk_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_DpBk_Add_Click(object sender, EventArgs e)
        {
            AddBooksForm myAddBooks = new AddBooksForm();
            myAddBooks.change_lbl_BkAdd_Head_Text("Add Book");
            myAddBooks.Show();
        }

        private void btn_DpBk_Update_Click(object sender, EventArgs e)
        {
            if (rowSelected)
                Books.getBookData();
            else
                MessageBox.Show("Select Data to Update", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgView_BooksRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Books.setBookData(dgView_BooksRecord.SelectedRows[0].Cells[0].Value.ToString(), dgView_BooksRecord.SelectedRows[0].Cells[1].Value.ToString(), dgView_BooksRecord.SelectedRows[0].Cells[2].Value.ToString(), dgView_BooksRecord.SelectedRows[0].Cells[3].Value.ToString(), dgView_BooksRecord.SelectedRows[0].Cells[6].Value.ToString(), dgView_BooksRecord.SelectedRows[0].Cells[7].Value.ToString());
            Books.setPublisherData(dgView_BooksRecord.SelectedRows[0].Cells[4].Value.ToString(), dgView_BooksRecord.SelectedRows[0].Cells[5].Value.ToString());
            Books.setLocationData(dgView_BooksRecord.SelectedRows[0].Cells[8].Value.ToString(), dgView_BooksRecord.SelectedRows[0].Cells[9].Value.ToString());
            Books.setOthersData(dgView_BooksRecord.SelectedRows[0].Cells[10].Value.ToString(), dgView_BooksRecord.SelectedRows[0].Cells[11].Value.ToString(), dgView_BooksRecord.SelectedRows[0].Cells[12].Value.ToString());
            rowSelected = true;
        }

        public void bookForIssue()
        {
            btn_DpBk_Add.Enabled = false;
            btn_DpBk_Del.Enabled = false;
            btn_DpBk_Update.Enabled = false;
        }

        private void deleteRecord()
        {
            DialogResult result = MessageBox.Show("Do You Want to Delete Data", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlCmd = new SqlCommand("DELETE FROM tbl_Books_Record WHERE BookID=@BookID", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@BookID", DisplayBooksForm.ID);

                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();

                MessageBox.Show("Data has succefully been Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_BkDp_Rf_Click(object sender, EventArgs e)
        {
            this.displayBooksRecord();
            txt_DpBk_Srch.Text = "Enter Book Title";
            txt_DpBk_Srch.ForeColor = Color.Gray;
        }

        private void btn_DpBk_Del_Click(object sender, EventArgs e)
        {
            DisplayBooksForm.ID = Books.passID();
            if (rowSelected)
            {
                deleteRecord();
                displayBooksRecord();
            }
            else
                MessageBox.Show("Select a Row to Delete Record", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_DpBk_Srch_Click(object sender, EventArgs e)
        {
            if (txt_DpBk_Srch.Text == "Enter Book Title")
                txt_DpBk_Srch.Text = "";
            txt_DpBk_Srch.ForeColor = Color.Black;
        }

        private void txt_DpBk_Srch_Leave(object sender, EventArgs e)
        {
            if (txt_DpBk_Srch.Text == "")
            {
                txt_DpBk_Srch.ForeColor = Color.Gray;
                txt_DpBk_Srch.Text = "Enter Book Title";
            }
        }

        private void btn_DpBk_Srch_Click(object sender, EventArgs e)
        {
            if (txt_DpBk_Srch.Text != "" && txt_DpBk_Srch.Text != "Enter Book Title")
                displaySearchResult();
        }

        private void displaySearchResult()
        {
            SqlCommand sqlCmd = new SqlCommand("Select * from tbl_Books_Record where Title Like '%'+@Book_Title+'%'", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Book_Title", txt_DpBk_Srch.Text);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_BooksRecord.DataSource = dtbl;
            dgView_BooksRecord.Columns[0].Visible = false;
        }

        private void dgView_BooksRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IssueBookForm myIssueBook = new IssueBookForm();
            myIssueBook.passBookID4Issue(Convert.ToInt32(dgView_BooksRecord.SelectedRows[0].Cells[0].Value));
            this.Hide();
        }
    }
}
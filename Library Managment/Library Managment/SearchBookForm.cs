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
    public partial class SearchBookForm : Form
    {
        public SearchBookForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");

        private bool _found()
        {
            if (txt_SrBk_Title.Text == "")
                return false;
            else
                return true;
        }

        private void titleSearchResult()
        {
            SqlCommand sqlCmd = new SqlCommand("Select * from tbl_Books_Record where Title Like '%'+@Book_Title+'%'", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Book_Title", txt_SrBk_Title.Text);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_SrBk.DataSource = dtbl;
            dgView_SrBk.Columns[0].Visible = false;
        }

        private void authorSearchResult()
        {
            SqlCommand sqlCmd = new SqlCommand("Select * from tbl_Books_Record where Author Like '%'+@Book_Author+'%'", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Book_Author", txt_SrBk_Auth.Text);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_SrBk.DataSource = dtbl;
            dgView_SrBk.Columns[0].Visible = false;
        }

        private void publisherSearchResult()
        {
            SqlCommand sqlCmd = new SqlCommand("Select * from tbl_Books_Record where Publisher Like '%'+@Book_Publisher+'%'", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Book_Publisher", txt_SrBk_Pub.Text);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_SrBk.DataSource = dtbl;
            dgView_SrBk.Columns[0].Visible = false;
        }

        private void rackSearchResult()
        {
            SqlCommand sqlCmd = new SqlCommand("Select * from tbl_Books_Record where Rack_row Like '%'+@Rack_Row+'%' and Rack_Col Like '%'+@Rack_Col+'%'", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Rack_Row", cmb_SrBk_RkRow.Text);
            sqlCmd.Parameters.AddWithValue("@Rack_Col", cmb_SrBk_RkCol.Text);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_SrBk.DataSource = dtbl;
            dgView_SrBk.Columns[0].Visible = false;
        }

        private void txt_SrBk_Title_Srch_Click(object sender, EventArgs e)
        {
            if (txt_SrBk_Title.Text == "Enter Book Title")
                txt_SrBk_Title.Text = "";
            txt_SrBk_Title.ForeColor = Color.Black;
        }

        private void txt_SrBk_Title_Srch_Leave(object sender, EventArgs e)
        {
            if (txt_SrBk_Title.Text == "")
            {
                txt_SrBk_Title.ForeColor = Color.Gray;
                txt_SrBk_Title.Text = "Enter Book Title";
            }
        }

        private void txt_SrBk_Auth_Click(object sender, EventArgs e)
        {
            if (txt_SrBk_Auth.Text == "Enter Book Author")
                txt_SrBk_Auth.Text = "";
            txt_SrBk_Auth.ForeColor = Color.Black;
        }

        private void txt_SrBk_Auth_Leave(object sender, EventArgs e)
        {
            if (txt_SrBk_Title.Text == "")
            {
                txt_SrBk_Title.ForeColor = Color.Gray;
                txt_SrBk_Title.Text = "Enter Book Author";
            }
        }

        private void txt_SrBk_Pub_Click(object sender, EventArgs e)
        {
            if (txt_SrBk_Pub.Text == "Enter Book Publisher")
                txt_SrBk_Pub.Text = "";
            txt_SrBk_Pub.ForeColor = Color.Black;
        }

        private void txt_SrBk_Pub_Leave(object sender, EventArgs e)
        {
            if (txt_SrBk_Pub.Text == "")
            {
                txt_SrBk_Pub.ForeColor = Color.Gray;
                txt_SrBk_Pub.Text = "Enter Book Publisher";
            }
        }

        private void btn_SrBk_Title_Click(object sender, EventArgs e)
        {
            titleSearchResult();
            if (!_found())
            {
                MessageBox.Show("No Results Found", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SrBk_Auth_Click(object sender, EventArgs e)
        {
            authorSearchResult();
            if (!_found())
            {
                MessageBox.Show("No Results Found", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SrBk_Pub_Click(object sender, EventArgs e)
        {
            publisherSearchResult();
            if (!_found())
            {
                MessageBox.Show("No Results Found", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SrBk_Rack_Click(object sender, EventArgs e)
        {
            rackSearchResult();
            if (!_found())
            {
                MessageBox.Show("No Results Found", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SrBk_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchBook_Load(object sender, EventArgs e)
        {
            Library myLibrary = new Library();
            Library.setRackData(10, 5);

            for (int i = 1; i <= Library.getRackRow(); i++)
                cmb_SrBk_RkRow.Items.Add(Convert.ToString(i));

            for (int i = 1; i <= Library.getRackCol(); i++)
                cmb_SrBk_RkCol.Items.Add(Convert.ToString(i));
        }

        private void dgView_SrBk_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IssueBookForm myBookIssue = new IssueBookForm();
            myBookIssue.passBookID4Issue(Convert.ToInt32(dgView_SrBk.SelectedRows[0].Cells[0].Value));
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgView_SrBk.DataSource = null;
            txt_SrBk_Auth.Text = "";
            txt_SrBk_Pub.Text = "";
            txt_SrBk_Title.Text = "";
            cmb_SrBk_RkCol.Text = "";
            cmb_SrBk_RkRow.Text = "";
        }

        public void dockEnable()
        {
            btn_SrBk_Back.Hide();
        }
    }
}
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
    public partial class AddExistingBookForm : Form
    {
        public AddExistingBookForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");
        private int ID;

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

        private void btn_AddExBk_Srch_Click(object sender, EventArgs e)
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

            dgView_AddExBk.DataSource = dtbl;
            dgView_AddExBk.Columns[0].Visible = false;
            dgView_AddExBk.Columns[3].Visible = false;
            dgView_AddExBk.Columns[5].Visible = false;
            dgView_AddExBk.Columns[8].Visible = false;
            dgView_AddExBk.Columns[9].Visible = false;
            dgView_AddExBk.Columns[10].Visible = false;
            dgView_AddExBk.Columns[11].Visible = false;
            dgView_AddExBk.Columns[12].Visible = false;
            dgView_AddExBk.Columns[13].Visible = false;
        }

        private void btn_AddExBk_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bnt_AddExBk_Cnfrm_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("UPDATE tbl_Books_Record SET Quantity=@Quantity WHERE BookID=@BookID", sqlCon);
            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.Parameters.AddWithValue("@BookID", this.ID);
            sqlCmd.Parameters.AddWithValue("@Quantity", upDn_AddExBk_Qnty.Text);

            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            MessageBox.Show("Book has Succesfully been added", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            displaySearchResult();
        }

        private void dgView_AddExBk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ID = Convert.ToInt32(dgView_AddExBk.SelectedRows[0].Cells[0].Value);
            lbl_AddExBk_Title.Text = dgView_AddExBk.SelectedRows[0].Cells[1].Value.ToString();
            lbl_AddExBk_Author.Text = dgView_AddExBk.SelectedRows[0].Cells[2].Value.ToString();
            lbl_AddExBk_Publisher.Text = dgView_AddExBk.SelectedRows[0].Cells[4].Value.ToString();
            upDn_AddExBk_Qnty.Text = dgView_AddExBk.SelectedRows[0].Cells[6].Value.ToString();
            lbl_AddExBk_ISBN.Text = dgView_AddExBk.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void upDn_AddExBk_Qnty_KeyUp(object sender, KeyEventArgs e)
        {
            int temp;
            temp = Convert.ToInt32(upDn_AddExBk_Qnty.Text);
            temp++;
            upDn_AddExBk_Qnty.Text = Convert.ToString(temp);
        }

        private void preRequesties()
        {
            for (int i = 0; i <= 1000; i++)
                upDn_AddExBk_Qnty.Items.Add(i);
        }

        private void addExistingBook_Load(object sender, EventArgs e)
        {
            preRequesties();
        }
    }
}

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
    public partial class SearchStudentForm : Form
    {
        public SearchStudentForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");
        bool rowSelected = false;

        private bool _found()
        {
            if (dgView_SrStu.Rows[0].Cells[0].Value.ToString() == "")
                return false;
            else
                return true;
        }

        private void nameSearchResult()
        {
            SqlCommand sqlCmd = new SqlCommand("Select * from tbl_Students_Record where Student_Name Like '%'+@Student_Name+'%'", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Student_Name", txt_SrStu_Name.Text);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_SrStu.DataSource = dtbl;
            dgView_SrStu.Columns[0].Visible = false;
            dgView_SrStu.Columns[11].Visible = false;
        }

        private void regSearchResult()
        {
            SqlCommand sqlCmd = new SqlCommand("Select * from tbl_Students_Record where Reg_No Like '%'+@Reg_No+'%'", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Reg_No", txt_SrStu_Reg.Text);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_SrStu.DataSource = dtbl;
            dgView_SrStu.Columns[0].Visible = false;
            dgView_SrStu.Columns[11].Visible = false;
        }

        private void insSearchResult()
        {
            SqlCommand sqlCmd = new SqlCommand("Select * from tbl_Students_Record where Section Like '%'+@Section+'%' and Semester Like '%'+@Semester+'%' and Department Like '%'+@Department+'%'", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Section", cmb_SrStu_Sec.Text);
            sqlCmd.Parameters.AddWithValue("@Semester", cmb_SrStu_Sem.Text);
            sqlCmd.Parameters.AddWithValue("@Department", cmb_SrStu_Dept.Text);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_SrStu.DataSource = dtbl;
            dgView_SrStu.Columns[0].Visible = false;
            dgView_SrStu.Columns[11].Visible = false;
        }

        private void SearchStudentForm_Load(object sender, EventArgs e)
        {
            this.btn_SrStu_Clear.Hide();
        }

        public void enableClear()
        {
            this.btn_SrStu_Back.Hide();
            this.btn_SrStu_Clear.Show();
        }

        private void txt_SrStu_Name_Enter(object sender, EventArgs e)
        {
            if (txt_SrStu_Name.Text == "Enter Student Name")
                txt_SrStu_Name.Text = "";
            txt_SrStu_Name.ForeColor = Color.Black;
        }
        private void txt_SrStu_Name_Leave(object sender, EventArgs e)
        {
            if (txt_SrStu_Name.Text == "")
            {
                txt_SrStu_Name.ForeColor = Color.Gray;
                txt_SrStu_Name.Text = "Enter Student Name";
            }
        }

        private void txt_SrStu_Reg_Enter(object sender, EventArgs e)
        {
            if (txt_SrStu_Reg.Text == "Enter Student Registration")
                txt_SrStu_Reg.Text = "";
            txt_SrStu_Reg.ForeColor = Color.Black;
        }

        private void txt_SrStu_Reg_Leave(object sender, EventArgs e)
        {
            if (txt_SrStu_Reg.Text == "")
            {
                txt_SrStu_Reg.ForeColor = Color.Gray;
                txt_SrStu_Reg.Text = "Enter Student Registration";
            }
        }

        private void btn_SrStu_Name_Click(object sender, EventArgs e)
        {
            if (!(txt_SrStu_Name.Text == "" || txt_SrStu_Reg.Text == "Enter Student Name"))
            {
                nameSearchResult();
                if (!_found())
                {
                    MessageBox.Show("No Results Found", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Insufficient Information for Searching", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_SrStu_Reg_Click(object sender, EventArgs e)
        {
            if (txt_SrStu_Reg.Text != "" && txt_SrStu_Reg.Text != "Enter Student Registration")
            {
                regSearchResult();
                if (!_found())
                {
                    MessageBox.Show("No Results Found", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Insufficient Information for Searching", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_SrStu_Ins_Click(object sender, EventArgs e)
        {
            if (cmb_SrStu_Sec.Text != "" && cmb_SrStu_Sem.Text != "" && cmb_SrStu_Dept.Text != "")
            {
                insSearchResult();
                if (!_found())
                {
                    MessageBox.Show("No Results Found", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Insufficient Information for Searching", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgView_SrStu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Students.setStudentData(dgView_SrStu.SelectedRows[0].Cells[0].Value.ToString(), dgView_SrStu.SelectedRows[0].Cells[1].Value.ToString(), dgView_SrStu.SelectedRows[0].Cells[2].Value.ToString(), dgView_SrStu.SelectedRows[0].Cells[3].Value.ToString(), dgView_SrStu.SelectedRows[0].Cells[4].Value.ToString(), dgView_SrStu.SelectedRows[0].Cells[5].Value.ToString(), dgView_SrStu.SelectedRows[0].Cells[6].Value.ToString(), dgView_SrStu.SelectedRows[0].Cells[7].Value.ToString(), dgView_SrStu.SelectedRows[0].Cells[8].Value.ToString(), dgView_SrStu.SelectedRows[0].Cells[9].Value.ToString(), dgView_SrStu.SelectedRows[0].Cells[10].Value.ToString());
            rowSelected = true;
        }

        private void btn_SrStu_Card_Click(object sender, EventArgs e)
        {
            if (rowSelected)
            {
                DisplayStudentProfileForm myStudentProfile = new DisplayStudentProfileForm();
                myStudentProfile.Show();
            }
            else
                MessageBox.Show("Select a Row to Display Student Card", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_SrStu_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_SrStu_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txt_SrStu_Name.Text = "Enter Student Name";
            txt_SrStu_Name.ForeColor = Color.Gray;
            txt_SrStu_Reg.Text = "Enter Student Registration";
            txt_SrStu_Reg.ForeColor = Color.Gray;
            cmb_SrStu_Sec.Text = "";
            cmb_SrStu_Sem.Text = "";
            cmb_SrStu_Dept.Text = "";
            rowSelected = false;
            dgView_SrStu.DataSource = null;
        }
    }
}
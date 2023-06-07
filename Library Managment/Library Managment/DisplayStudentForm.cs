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
    public partial class DisplayStudentForm : Form
    {
        public DisplayStudentForm()
        {
            InitializeComponent();
        }

        private static int ID = 0;
        private bool rowSelected = false;
        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");

        private void txt_DpStu_Srch_Click(object sender, EventArgs e)
        {
            if (txt_DpStu_Srch.Text == "Enter Student's Registration")
                txt_DpStu_Srch.Text = "";
            txt_DpStu_Srch.ForeColor = Color.Black;
        }

        private void txt_DpStu_Srch_Leave(object sender, EventArgs e)
        {
            if (txt_DpStu_Srch.Text == "")
            {
                txt_DpStu_Srch.ForeColor = Color.Gray;
                txt_DpStu_Srch.Text = "Enter Student's Registration";
            }
        }

        public void change_lbl_StuAdd_Head(string newLbl)
        {
            lbl_DpStu_Head.Text = newLbl;
        }

        private void btn_DpStu_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgView_StudentsRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Students.setStudentData(dgView_StudentsRecord.SelectedRows[0].Cells[0].Value.ToString(), dgView_StudentsRecord.SelectedRows[0].Cells[1].Value.ToString(), dgView_StudentsRecord.SelectedRows[0].Cells[2].Value.ToString(), dgView_StudentsRecord.SelectedRows[0].Cells[3].Value.ToString(), dgView_StudentsRecord.SelectedRows[0].Cells[4].Value.ToString(), dgView_StudentsRecord.SelectedRows[0].Cells[5].Value.ToString(), dgView_StudentsRecord.SelectedRows[0].Cells[6].Value.ToString(), dgView_StudentsRecord.SelectedRows[0].Cells[7].Value.ToString(), dgView_StudentsRecord.SelectedRows[0].Cells[8].Value.ToString(), dgView_StudentsRecord.SelectedRows[0].Cells[9].Value.ToString(), dgView_StudentsRecord.SelectedRows[0].Cells[10].Value.ToString());
            rowSelected = true;
        }

        private void DisplayStudent_Load(object sender, EventArgs e)
        {
            displayStudentData();
        }

        private void displayStudentData()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM tbl_Students_Record", sqlCon);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_StudentsRecord.DataSource = dtbl;
            dgView_StudentsRecord.Columns[0].Visible = false;
            dgView_StudentsRecord.Columns[11].Visible = false;
        }
        private void deleteRecord()
        {
            try
            {
                DialogResult result = MessageBox.Show("Do You Want to Delete Data", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand sqlCmd = new SqlCommand("DELETE FROM tbl_Students_Record WHERE Student_ID=@Student_ID", sqlCon);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@Student_ID", DisplayStudentForm.ID);

                    sqlCon.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Data has succefully been Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DpStu_Del_Click(object sender, EventArgs e)
        {
            DisplayStudentForm.ID = Students.passStudentID();
            if (rowSelected)
            {
                deleteRecord();
                displayStudentData();
            }
        }

        private void btn_DpStu_Add_Click(object sender, EventArgs e)
        {
            AddStudentForm myStudentAdd = new AddStudentForm();
            myStudentAdd.change_lbl_StuAdd_Head("Add Student");
            myStudentAdd.Show();
        }

        private void btn_BkStu_Rf_Click(object sender, EventArgs e)
        {
            displayStudentData();
        }

        private void btn_DpStu_Srch_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM tbl_Students_Record WHERE Reg_No LIKE '%'+@Reg_No+'%'", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@Reg_No", txt_DpStu_Srch.Text);
            DataTable dtbl = new DataTable();

            sqlCon.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            dtbl.Load(reader);
            sqlCon.Close();

            dgView_StudentsRecord.DataSource = dtbl;
            dgView_StudentsRecord.Columns[0].Visible = false;
            dgView_StudentsRecord.Columns[11].Visible = false;
        }

        private void btn_DpStu_Update_Click(object sender, EventArgs e)
        {
            AddStudentForm myStudentAdd = new AddStudentForm();
            myStudentAdd.uploadToBoxes();
            myStudentAdd.change_lbl_StuAdd_Head("Update Student");
            myStudentAdd.Show();
        }

        private void btn_DpStu_Card_Click(object sender, EventArgs e)
        {
            DisplayStudentProfileForm myStudentProfile = new DisplayStudentProfileForm();
            myStudentProfile.Show();
        }
    }
}
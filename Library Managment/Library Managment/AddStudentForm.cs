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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private int ID = 0;
        private string imageLoc = "";
        private byte[] img = null;
        private bool browseClicked = false;

        SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=DataRecords;Integrated Security=True");

        private void browseImage()
        {
            browseClicked = true;
            OpenFileDialog log = new OpenFileDialog();
            log.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            log.Title = "Select Student Image";
            if (log.ShowDialog() == DialogResult.OK)
            {
                imageLoc = log.FileName.ToString();
                pBox_StuAdd_Stu.ImageLocation = imageLoc;
                convImg_Embed();
            }
        }

        public void uploadToBoxes()
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

                txt_StuAdd_Name.Text = dtbl.Rows[0][1].ToString();
                txt_StuAdd_FName.Text = dtbl.Rows[0][2].ToString();
                txt_StuAdd_CNIC.Text = dtbl.Rows[0][3].ToString();
                if (dtbl.Rows[0][4].ToString() == "Male")
                    rbtn_StuAdd_Male.Checked = true;
                else if (dtbl.Rows[0][4].ToString() == "Female")
                    rbtn_StuAdd_Female.Checked = true;
                txt_StuAdd_Cont.Text = dtbl.Rows[0][5].ToString();
                txt_StuAdd_Mail.Text = dtbl.Rows[0][6].ToString();
                txt_StuAdd_Reg.Text = dtbl.Rows[0][7].ToString();
                cmb_StuAdd_Sec.Text = dtbl.Rows[0][8].ToString();
                cmb_StuAdd_Sem.Text = dtbl.Rows[0][9].ToString();
                cmb_StuAdd_Dept.Text = dtbl.Rows[0][10].ToString();

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
            MemoryStream myStream = new MemoryStream(img);
            pBox_StuAdd_Stu.Image = Image.FromStream(myStream);
        }

        private void convImg_Embed()
        {
            FileStream file = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
            BinaryReader bReader = new BinaryReader(file);
            img = bReader.ReadBytes((int)file.Length);
        }

        private bool _isValid()
        {
            if (txt_StuAdd_Name.Text == "" || txt_StuAdd_FName.Text == "" || txt_StuAdd_CNIC.Text == "" || (rbtn_StuAdd_Male.Checked == false && rbtn_StuAdd_Female.Checked == false) || txt_StuAdd_Cont.Text == "" || txt_StuAdd_Mail.Text == "" || txt_StuAdd_Reg.Text == "" || cmb_StuAdd_Sec.Text == "" || cmb_StuAdd_Sem.Text == "" || cmb_StuAdd_Dept.Text == "" || pBox_StuAdd_Stu.Image == null)
                return false;
            else
                return true;
        }

        private void writeStudentData()
        {
            try
            {
                if (_isValid())
                {
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO tbl_Students_Record VALUES (@Student_Name, @Father_Name, @CNIC, @Gender, @Contact, @Email, @Reg_No, @Section, @Semester, @Department, @Image)", sqlCon);

                    sqlCmd.Parameters.AddWithValue("@Student_Name", txt_StuAdd_Name.Text);
                    sqlCmd.Parameters.AddWithValue("@Father_Name", txt_StuAdd_FName.Text);
                    sqlCmd.Parameters.AddWithValue("@CNIC", txt_StuAdd_CNIC.Text);
                    if (rbtn_StuAdd_Male.Checked == true)
                        sqlCmd.Parameters.AddWithValue("@Gender", "Male");
                    if (rbtn_StuAdd_Female.Checked == true)
                        sqlCmd.Parameters.AddWithValue("@Gender", "Female");
                    sqlCmd.Parameters.AddWithValue("@Contact", txt_StuAdd_Cont.Text);
                    sqlCmd.Parameters.AddWithValue("@Email", txt_StuAdd_Mail.Text);
                    sqlCmd.Parameters.AddWithValue("@Reg_No", txt_StuAdd_Reg.Text);
                    sqlCmd.Parameters.AddWithValue("@Section", cmb_StuAdd_Sec.Text);
                    sqlCmd.Parameters.AddWithValue("@Semester", cmb_StuAdd_Sem.Text);
                    sqlCmd.Parameters.AddWithValue("@Department", cmb_StuAdd_Dept.Text);

                    sqlCmd.Parameters.Add(new SqlParameter("@Image", img));

                    if (sqlCon.State != ConnectionState.Open)
                        sqlCon.Open();
                    sqlCmd.ExecuteNonQuery();
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();

                    MessageBox.Show("Data has succefully been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                    txt_StuAdd_Name.Focus();
                }

                else
                {
                    MessageBox.Show("Insufficient Information for Registration", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                sqlCon.Close();
                MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateStudentData()
        {
            try
            {
                if (_isValid())
                {
                    string query = "UPDATE tbl_Students_Record SET Student_Name=@Student_Name, Father_Name=@Father_Name, CNIC=@CNIC, Gender=@Gender, Contact=@Contact, Email=@Email, Reg_No=@Reg_No, Section=@Section, Semester=@Semester, Department=@Department WHERE Student_ID=@Student_ID";
                    if (browseClicked)
                        query = "UPDATE tbl_Students_Record SET Student_Name=@Student_Name, Father_Name=@Father_Name, CNIC=@CNIC, Gender=@Gender, Contact=@Contact, Email=@Email, Reg_No=@Reg_No, Section=@Section, Semester=@Semester, Department=@Department, Image=@Image WHERE Student_ID=@Student_ID";

                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

                    sqlCmd.Parameters.AddWithValue("@Student_ID", this.ID);
                    sqlCmd.Parameters.AddWithValue("@Student_Name", txt_StuAdd_Name.Text);
                    sqlCmd.Parameters.AddWithValue("@Father_Name", txt_StuAdd_FName.Text);
                    sqlCmd.Parameters.AddWithValue("@CNIC", txt_StuAdd_CNIC.Text);
                    if (rbtn_StuAdd_Male.Checked == true)
                        sqlCmd.Parameters.AddWithValue("@Gender", "Male");
                    if (rbtn_StuAdd_Female.Checked == true)
                        sqlCmd.Parameters.AddWithValue("@Gender", "Female");
                    sqlCmd.Parameters.AddWithValue("@Contact", txt_StuAdd_Cont.Text);
                    sqlCmd.Parameters.AddWithValue("@Email", txt_StuAdd_Mail.Text);
                    sqlCmd.Parameters.AddWithValue("@Reg_No", txt_StuAdd_Reg.Text);
                    sqlCmd.Parameters.AddWithValue("@Section", cmb_StuAdd_Sec.Text);
                    sqlCmd.Parameters.AddWithValue("@Semester", cmb_StuAdd_Sem.Text);
                    sqlCmd.Parameters.AddWithValue("@Department", cmb_StuAdd_Dept.Text);

                    if (browseClicked)
                        sqlCmd.Parameters.Add(new SqlParameter("@Image", img));

                    if (sqlCon.State != ConnectionState.Open)
                        sqlCon.Open();
                    sqlCmd.ExecuteNonQuery();
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();

                    DialogResult result = MessageBox.Show("Data has succefully been Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                        this.Close();

                }
                else
                {
                    MessageBox.Show("Insufficient Information for Registration", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            browseClicked = false;
        }

        private void clearAll()
        {
            this.ID = 0;
            txt_StuAdd_Name.Text = "";
            txt_StuAdd_FName.Text = "";
            txt_StuAdd_CNIC.Text = "";
            rbtn_StuAdd_Female.Checked = false;
            rbtn_StuAdd_Male.Checked = false;
            txt_StuAdd_Cont.Text = "";
            txt_StuAdd_Mail.Text = "";
            txt_StuAdd_Reg.Text = "";
            cmb_StuAdd_Sec.Text = "";
            cmb_StuAdd_Sem.Text = "";
            cmb_StuAdd_Dept.Text = "";
            pBox_StuAdd_Stu.Image = null;
        }

        private void btn_BkAdd_Cnfrm_Click(object sender, EventArgs e)
        {
            if (lbl_StuAdd_Head.Text == "Add Student")
                writeStudentData();
            else if (lbl_StuAdd_Head.Text == "Update Student")
                updateStudentData();
        }

        private void btn_StuAdd_BrowseImg_Click(object sender, EventArgs e)
        {
            browseImage();
        }

        private void btn_StuAdd_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void change_lbl_StuAdd_Head(string newLbl)
        {
            lbl_StuAdd_Head.Text = newLbl;
        }

        private void btn_StuAdd_Clear_Click(object sender, EventArgs e)
        {
            clearAll();
            txt_StuAdd_Name.Focus();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            txt_StuAdd_Name.Focus();
        }
    }
}
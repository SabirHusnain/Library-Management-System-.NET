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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        string imageLoc = "";
        byte[] img;

        private void convImg_Embed()
        {
            FileStream file = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
            BinaryReader bReader = new BinaryReader(file);
            img = bReader.ReadBytes((int)file.Length);
        }

        private bool isValid()
        {
            if (txt_Username.Text != null)
            {
                if (txt_Password.Text != null)
                {
                    if (txt_Password.Text.Length >= 8)
                    {
                        if (txt_Password.Text == txt_Password_Confirm.Text)
                        {
                            if (txt_DisplayName.Text != "")
                                return true;
                            else
                            {
                                MessageBox.Show("Display Name is Required", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password Doesn't Match", "Recheck Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password is too short", "Must be 8 or more", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Password Required", "Must be 8 or more", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Username Required", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=HUSNAINSPC\SQLEXPRESS;Initial Catalog=BlackBox;Integrated Security=True");
                SqlCommand sqlCmd = new SqlCommand("INSERT INTO tbl_Black_Box VALUES (@Username, @Password, @DisplayName, @Email, @Image)", sqlCon);
                sqlCmd.Parameters.AddWithValue("@Username", txt_Username.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txt_Password.Text);
                sqlCmd.Parameters.AddWithValue("@DisplayName", txt_DisplayName.Text);
                sqlCmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                sqlCmd.Parameters.AddWithValue("@Image", img);

                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();

                MessageBox.Show("User Added Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            txt_Username.Focus();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog log = new OpenFileDialog();
            log.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            log.Title = "Select Student Image";
            if (log.ShowDialog() == DialogResult.OK)
            {
                imageLoc = log.FileName.ToString();
                pBox_User.ImageLocation = imageLoc;
                convImg_Embed();
            }
        }
    }
}

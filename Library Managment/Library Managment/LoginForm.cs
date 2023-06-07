using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Library_Managment
{
    public partial class LoginForm : Form
    {
        Library myLibrary = new Library();
        Security objectSecurity = new Security();
        StudentSecurity myStudentSecurity = new StudentSecurity();
        AdminForm myAdminForm = new AdminForm();
        StudentForm myStudentForm = new StudentForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            Page_Choose.Visible = false;
            Page_Login.Visible = false;
            page_Stu_Login.Visible = true;
            txt_Login_Reg.Focus();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Page_Choose.Visible = false;
            Page_Login.Visible = true;
            page_Stu_Login.Visible = false;
            txt_Username.Focus();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Page_Login.Visible = false;
            Page_Choose.Visible = true;
            page_Stu_Login.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            myLibrary.setLibraryName("UET Library");
            lbl_LibraryName.Text = myLibrary.getLibraryName() + " Managment";
        }

        private void btn_Singin_Click(object sender, EventArgs e)
        {
            if (objectSecurity.isValid(txt_Username.Text, txt_Password.Text))
            {
                this.Hide();
                myAdminForm.Show();
            }
            else
                MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Stu_Bk_Click(object sender, EventArgs e)
        {
            Page_Login.Visible = false;
            Page_Choose.Visible = true;
            page_Stu_Login.Visible = false;
        }

        private void btn_Stu_SignIn_Click(object sender, EventArgs e)
        {
            if (myStudentSecurity.isValid(txt_Login_Reg.Text, txt_Login_CNIC.Text))
            {
                this.Hide();
                myStudentForm.Show();
            }
            else
                MessageBox.Show("Reg_No or CNIC is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
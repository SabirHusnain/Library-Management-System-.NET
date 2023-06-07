
namespace Library_Managment
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_LibraryName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Student = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.Page_Choose = new System.Windows.Forms.Panel();
            this.Page_Login = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Singin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.page_Stu_Login = new System.Windows.Forms.Panel();
            this.btn_Stu_Bk = new System.Windows.Forms.Button();
            this.txt_Login_CNIC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Login_Reg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Stu_SignIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Page_Choose.SuspendLayout();
            this.Page_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.page_Stu_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_LibraryName);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbl_LibraryName
            // 
            resources.ApplyResources(this.lbl_LibraryName, "lbl_LibraryName");
            this.lbl_LibraryName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LibraryName.ForeColor = System.Drawing.Color.White;
            this.lbl_LibraryName.Name = "lbl_LibraryName";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btn_Student
            // 
            this.btn_Student.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Student.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_Student.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_Student.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btn_Student, "btn_Student");
            this.btn_Student.ForeColor = System.Drawing.Color.White;
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.UseVisualStyleBackColor = false;
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Admin.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_Admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btn_Admin, "btn_Admin");
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Quit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_Quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_Quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btn_Quit, "btn_Quit");
            this.btn_Quit.ForeColor = System.Drawing.Color.White;
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // Page_Choose
            // 
            this.Page_Choose.Controls.Add(this.label2);
            this.Page_Choose.Controls.Add(this.btn_Quit);
            this.Page_Choose.Controls.Add(this.btn_Student);
            this.Page_Choose.Controls.Add(this.btn_Admin);
            resources.ApplyResources(this.Page_Choose, "Page_Choose");
            this.Page_Choose.Name = "Page_Choose";
            // 
            // Page_Login
            // 
            this.Page_Login.Controls.Add(this.btn_Back);
            this.Page_Login.Controls.Add(this.txt_Password);
            this.Page_Login.Controls.Add(this.label5);
            this.Page_Login.Controls.Add(this.txt_Username);
            this.Page_Login.Controls.Add(this.label4);
            this.Page_Login.Controls.Add(this.label3);
            this.Page_Login.Controls.Add(this.btn_Singin);
            resources.ApplyResources(this.Page_Login, "Page_Login");
            this.Page_Login.Name = "Page_Login";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btn_Back, "btn_Back");
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txt_Password
            // 
            resources.ApplyResources(this.txt_Password, "txt_Password");
            this.txt_Password.Name = "txt_Password";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txt_Username
            // 
            resources.ApplyResources(this.txt_Username, "txt_Username");
            this.txt_Username.Name = "txt_Username";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btn_Singin
            // 
            this.btn_Singin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Singin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Singin.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_Singin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_Singin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btn_Singin, "btn_Singin");
            this.btn_Singin.ForeColor = System.Drawing.Color.White;
            this.btn_Singin.Name = "btn_Singin";
            this.btn_Singin.UseVisualStyleBackColor = false;
            this.btn_Singin.Click += new System.EventHandler(this.btn_Singin_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library_Managment.Properties.Resources.PngItem_171570;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // page_Stu_Login
            // 
            this.page_Stu_Login.Controls.Add(this.btn_Stu_Bk);
            this.page_Stu_Login.Controls.Add(this.txt_Login_CNIC);
            this.page_Stu_Login.Controls.Add(this.label1);
            this.page_Stu_Login.Controls.Add(this.txt_Login_Reg);
            this.page_Stu_Login.Controls.Add(this.label7);
            this.page_Stu_Login.Controls.Add(this.label8);
            this.page_Stu_Login.Controls.Add(this.btn_Stu_SignIn);
            resources.ApplyResources(this.page_Stu_Login, "page_Stu_Login");
            this.page_Stu_Login.Name = "page_Stu_Login";
            // 
            // btn_Stu_Bk
            // 
            this.btn_Stu_Bk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Stu_Bk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stu_Bk.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_Stu_Bk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_Stu_Bk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btn_Stu_Bk, "btn_Stu_Bk");
            this.btn_Stu_Bk.ForeColor = System.Drawing.Color.White;
            this.btn_Stu_Bk.Name = "btn_Stu_Bk";
            this.btn_Stu_Bk.UseVisualStyleBackColor = false;
            this.btn_Stu_Bk.Click += new System.EventHandler(this.btn_Stu_Bk_Click);
            // 
            // txt_Login_CNIC
            // 
            resources.ApplyResources(this.txt_Login_CNIC, "txt_Login_CNIC");
            this.txt_Login_CNIC.Name = "txt_Login_CNIC";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txt_Login_Reg
            // 
            resources.ApplyResources(this.txt_Login_Reg, "txt_Login_Reg");
            this.txt_Login_Reg.Name = "txt_Login_Reg";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btn_Stu_SignIn
            // 
            this.btn_Stu_SignIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Stu_SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stu_SignIn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_Stu_SignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_Stu_SignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btn_Stu_SignIn, "btn_Stu_SignIn");
            this.btn_Stu_SignIn.ForeColor = System.Drawing.Color.White;
            this.btn_Stu_SignIn.Name = "btn_Stu_SignIn";
            this.btn_Stu_SignIn.UseVisualStyleBackColor = false;
            this.btn_Stu_SignIn.Click += new System.EventHandler(this.btn_Stu_SignIn_Click);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Page_Choose);
            this.Controls.Add(this.page_Stu_Login);
            this.Controls.Add(this.Page_Login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Page_Choose.ResumeLayout(false);
            this.Page_Choose.PerformLayout();
            this.Page_Login.ResumeLayout(false);
            this.Page_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.page_Stu_Login.ResumeLayout(false);
            this.page_Stu_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_LibraryName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Panel Page_Choose;
        private System.Windows.Forms.Panel Page_Login;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Singin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel page_Stu_Login;
        private System.Windows.Forms.Button btn_Stu_Bk;
        private System.Windows.Forms.TextBox txt_Login_CNIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Login_Reg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Stu_SignIn;
    }
}
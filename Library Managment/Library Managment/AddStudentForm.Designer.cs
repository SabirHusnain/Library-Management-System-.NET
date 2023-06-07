
namespace Library_Managment
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.lbl_StuAdd_Head = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_StuAdd_Dept = new System.Windows.Forms.ComboBox();
            this.cmb_StuAdd_Sem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_StuAdd_Sec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_StuAdd_Reg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_StuAdd_Clear = new System.Windows.Forms.Button();
            this.btn_StuAdd_Cancel = new System.Windows.Forms.Button();
            this.btn_StuAdd_Confirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_StuAdd_Mail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_StuAdd_Cont = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtn_StuAdd_Female = new System.Windows.Forms.RadioButton();
            this.btn_StuAdd_BrowseImg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtn_StuAdd_Male = new System.Windows.Forms.RadioButton();
            this.txt_StuAdd_CNIC = new System.Windows.Forms.TextBox();
            this.pBox_StuAdd_Stu = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_StuAdd_FName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_StuAdd_Name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_StuAdd_Stu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_StuAdd_Head
            // 
            this.lbl_StuAdd_Head.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_StuAdd_Head.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_StuAdd_Head.ForeColor = System.Drawing.Color.White;
            this.lbl_StuAdd_Head.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_StuAdd_Head.Location = new System.Drawing.Point(68, 4);
            this.lbl_StuAdd_Head.Name = "lbl_StuAdd_Head";
            this.lbl_StuAdd_Head.Size = new System.Drawing.Size(424, 23);
            this.lbl_StuAdd_Head.TabIndex = 36;
            this.lbl_StuAdd_Head.Text = "Add Student";
            this.lbl_StuAdd_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btn_StuAdd_Clear);
            this.panel1.Controls.Add(this.btn_StuAdd_Cancel);
            this.panel1.Controls.Add(this.btn_StuAdd_Confirm);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 361);
            this.panel1.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_StuAdd_Dept);
            this.groupBox2.Controls.Add(this.cmb_StuAdd_Sem);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmb_StuAdd_Sec);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_StuAdd_Reg);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(4, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 90);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Institutional Information";
            // 
            // cmb_StuAdd_Dept
            // 
            this.cmb_StuAdd_Dept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_StuAdd_Dept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_StuAdd_Dept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_StuAdd_Dept.FormattingEnabled = true;
            this.cmb_StuAdd_Dept.Items.AddRange(new object[] {
            "Chemical Engineering",
            "Electrical Engineering",
            "Mechatronics and Control Engineering",
            "Textile Engineering"});
            this.cmb_StuAdd_Dept.Location = new System.Drawing.Point(313, 58);
            this.cmb_StuAdd_Dept.Name = "cmb_StuAdd_Dept";
            this.cmb_StuAdd_Dept.Size = new System.Drawing.Size(234, 24);
            this.cmb_StuAdd_Dept.Sorted = true;
            this.cmb_StuAdd_Dept.TabIndex = 120;
            // 
            // cmb_StuAdd_Sem
            // 
            this.cmb_StuAdd_Sem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_StuAdd_Sem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_StuAdd_Sem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_StuAdd_Sem.FormattingEnabled = true;
            this.cmb_StuAdd_Sem.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th"});
            this.cmb_StuAdd_Sem.Location = new System.Drawing.Point(112, 57);
            this.cmb_StuAdd_Sem.Name = "cmb_StuAdd_Sem";
            this.cmb_StuAdd_Sem.Size = new System.Drawing.Size(107, 24);
            this.cmb_StuAdd_Sem.TabIndex = 117;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(225, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 115;
            this.label11.Text = "Department";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_StuAdd_Sec
            // 
            this.cmb_StuAdd_Sec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_StuAdd_Sec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_StuAdd_Sec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_StuAdd_Sec.FormattingEnabled = true;
            this.cmb_StuAdd_Sec.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmb_StuAdd_Sec.Location = new System.Drawing.Point(440, 28);
            this.cmb_StuAdd_Sec.Name = "cmb_StuAdd_Sec";
            this.cmb_StuAdd_Sec.Size = new System.Drawing.Size(107, 24);
            this.cmb_StuAdd_Sec.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(38, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 114;
            this.label4.Text = "Semester";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(379, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 112;
            this.label3.Text = "Section";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StuAdd_Reg
            // 
            this.txt_StuAdd_Reg.Location = new System.Drawing.Point(112, 28);
            this.txt_StuAdd_Reg.Name = "txt_StuAdd_Reg";
            this.txt_StuAdd_Reg.Size = new System.Drawing.Size(245, 23);
            this.txt_StuAdd_Reg.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(43, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "Reg. No.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_StuAdd_Clear
            // 
            this.btn_StuAdd_Clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_StuAdd_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StuAdd_Clear.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_StuAdd_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_StuAdd_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_StuAdd_Clear.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_StuAdd_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_StuAdd_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_StuAdd_Clear.Location = new System.Drawing.Point(401, 323);
            this.btn_StuAdd_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StuAdd_Clear.Name = "btn_StuAdd_Clear";
            this.btn_StuAdd_Clear.Size = new System.Drawing.Size(73, 31);
            this.btn_StuAdd_Clear.TabIndex = 98;
            this.btn_StuAdd_Clear.Text = "Clear";
            this.btn_StuAdd_Clear.UseVisualStyleBackColor = false;
            this.btn_StuAdd_Clear.Click += new System.EventHandler(this.btn_StuAdd_Clear_Click);
            // 
            // btn_StuAdd_Cancel
            // 
            this.btn_StuAdd_Cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_StuAdd_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StuAdd_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_StuAdd_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_StuAdd_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_StuAdd_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_StuAdd_Cancel.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_StuAdd_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_StuAdd_Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_StuAdd_Cancel.Location = new System.Drawing.Point(324, 323);
            this.btn_StuAdd_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StuAdd_Cancel.Name = "btn_StuAdd_Cancel";
            this.btn_StuAdd_Cancel.Size = new System.Drawing.Size(73, 31);
            this.btn_StuAdd_Cancel.TabIndex = 99;
            this.btn_StuAdd_Cancel.Text = "Cancel";
            this.btn_StuAdd_Cancel.UseVisualStyleBackColor = false;
            this.btn_StuAdd_Cancel.Click += new System.EventHandler(this.btn_StuAdd_Cancel_Click);
            // 
            // btn_StuAdd_Confirm
            // 
            this.btn_StuAdd_Confirm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_StuAdd_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StuAdd_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_StuAdd_Confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_StuAdd_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_StuAdd_Confirm.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_StuAdd_Confirm.ForeColor = System.Drawing.Color.White;
            this.btn_StuAdd_Confirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_StuAdd_Confirm.Location = new System.Drawing.Point(478, 323);
            this.btn_StuAdd_Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StuAdd_Confirm.Name = "btn_StuAdd_Confirm";
            this.btn_StuAdd_Confirm.Size = new System.Drawing.Size(73, 31);
            this.btn_StuAdd_Confirm.TabIndex = 97;
            this.btn_StuAdd_Confirm.Text = "Confirm";
            this.btn_StuAdd_Confirm.UseVisualStyleBackColor = false;
            this.btn_StuAdd_Confirm.Click += new System.EventHandler(this.btn_BkAdd_Cnfrm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_StuAdd_Mail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_StuAdd_Cont);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rbtn_StuAdd_Female);
            this.groupBox1.Controls.Add(this.btn_StuAdd_BrowseImg);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rbtn_StuAdd_Male);
            this.groupBox1.Controls.Add(this.txt_StuAdd_CNIC);
            this.groupBox1.Controls.Add(this.pBox_StuAdd_Stu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_StuAdd_FName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_StuAdd_Name);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Personal Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(59, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 111;
            this.label14.Text = "E-Mail";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StuAdd_Mail
            // 
            this.txt_StuAdd_Mail.Location = new System.Drawing.Point(113, 188);
            this.txt_StuAdd_Mail.Name = "txt_StuAdd_Mail";
            this.txt_StuAdd_Mail.Size = new System.Drawing.Size(312, 23);
            this.txt_StuAdd_Mail.TabIndex = 112;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(50, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 109;
            this.label10.Text = "Contact";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StuAdd_Cont
            // 
            this.txt_StuAdd_Cont.Location = new System.Drawing.Point(112, 155);
            this.txt_StuAdd_Cont.Name = "txt_StuAdd_Cont";
            this.txt_StuAdd_Cont.Size = new System.Drawing.Size(312, 23);
            this.txt_StuAdd_Cont.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(50, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 108;
            this.label9.Text = "Gender";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtn_StuAdd_Female
            // 
            this.rbtn_StuAdd_Female.AutoSize = true;
            this.rbtn_StuAdd_Female.Location = new System.Drawing.Point(174, 125);
            this.rbtn_StuAdd_Female.Name = "rbtn_StuAdd_Female";
            this.rbtn_StuAdd_Female.Size = new System.Drawing.Size(73, 20);
            this.rbtn_StuAdd_Female.TabIndex = 89;
            this.rbtn_StuAdd_Female.Text = "Female";
            this.rbtn_StuAdd_Female.UseVisualStyleBackColor = true;
            // 
            // btn_StuAdd_BrowseImg
            // 
            this.btn_StuAdd_BrowseImg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_StuAdd_BrowseImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StuAdd_BrowseImg.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_StuAdd_BrowseImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_StuAdd_BrowseImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_StuAdd_BrowseImg.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_StuAdd_BrowseImg.ForeColor = System.Drawing.Color.White;
            this.btn_StuAdd_BrowseImg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_StuAdd_BrowseImg.Location = new System.Drawing.Point(430, 181);
            this.btn_StuAdd_BrowseImg.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StuAdd_BrowseImg.Name = "btn_StuAdd_BrowseImg";
            this.btn_StuAdd_BrowseImg.Size = new System.Drawing.Size(117, 31);
            this.btn_StuAdd_BrowseImg.TabIndex = 108;
            this.btn_StuAdd_BrowseImg.Text = "Browse";
            this.btn_StuAdd_BrowseImg.UseVisualStyleBackColor = false;
            this.btn_StuAdd_BrowseImg.Click += new System.EventHandler(this.btn_StuAdd_BrowseImg_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(66, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 94;
            this.label8.Text = "CNIC";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtn_StuAdd_Male
            // 
            this.rbtn_StuAdd_Male.AutoSize = true;
            this.rbtn_StuAdd_Male.Location = new System.Drawing.Point(112, 125);
            this.rbtn_StuAdd_Male.Name = "rbtn_StuAdd_Male";
            this.rbtn_StuAdd_Male.Size = new System.Drawing.Size(56, 20);
            this.rbtn_StuAdd_Male.TabIndex = 88;
            this.rbtn_StuAdd_Male.Text = "Male";
            this.rbtn_StuAdd_Male.UseVisualStyleBackColor = true;
            // 
            // txt_StuAdd_CNIC
            // 
            this.txt_StuAdd_CNIC.Location = new System.Drawing.Point(112, 92);
            this.txt_StuAdd_CNIC.Name = "txt_StuAdd_CNIC";
            this.txt_StuAdd_CNIC.Size = new System.Drawing.Size(312, 23);
            this.txt_StuAdd_CNIC.TabIndex = 95;
            // 
            // pBox_StuAdd_Stu
            // 
            this.pBox_StuAdd_Stu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_StuAdd_Stu.InitialImage = global::Library_Managment.Properties.Resources.Profile_PNG_Icon_715x715;
            this.pBox_StuAdd_Stu.Location = new System.Drawing.Point(430, 26);
            this.pBox_StuAdd_Stu.Name = "pBox_StuAdd_Stu";
            this.pBox_StuAdd_Stu.Size = new System.Drawing.Size(117, 150);
            this.pBox_StuAdd_Stu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_StuAdd_Stu.TabIndex = 107;
            this.pBox_StuAdd_Stu.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(16, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 92;
            this.label7.Text = "Father Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StuAdd_FName
            // 
            this.txt_StuAdd_FName.Location = new System.Drawing.Point(112, 59);
            this.txt_StuAdd_FName.Name = "txt_StuAdd_FName";
            this.txt_StuAdd_FName.Size = new System.Drawing.Size(312, 23);
            this.txt_StuAdd_FName.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Student Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StuAdd_Name
            // 
            this.txt_StuAdd_Name.Location = new System.Drawing.Point(112, 26);
            this.txt_StuAdd_Name.Name = "txt_StuAdd_Name";
            this.txt_StuAdd_Name.Size = new System.Drawing.Size(312, 23);
            this.txt_StuAdd_Name.TabIndex = 91;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(584, 404);
            this.Controls.Add(this.lbl_StuAdd_Head);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_StuAdd_Stu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_StuAdd_Head;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_StuAdd_Female;
        private System.Windows.Forms.RadioButton rbtn_StuAdd_Male;
        private System.Windows.Forms.PictureBox pBox_StuAdd_Stu;
        private System.Windows.Forms.Button btn_StuAdd_BrowseImg;
        private System.Windows.Forms.Button btn_StuAdd_Clear;
        private System.Windows.Forms.Button btn_StuAdd_Cancel;
        private System.Windows.Forms.Button btn_StuAdd_Confirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_StuAdd_FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_StuAdd_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_StuAdd_CNIC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_StuAdd_Dept;
        private System.Windows.Forms.ComboBox cmb_StuAdd_Sem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_StuAdd_Sec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_StuAdd_Reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_StuAdd_Mail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_StuAdd_Cont;
    }
}
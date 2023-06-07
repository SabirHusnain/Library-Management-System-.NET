
namespace Library_Managment
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Admin_BkIssue = new System.Windows.Forms.Panel();
            this.pnl_Admin_SrStu = new System.Windows.Forms.Panel();
            this.pnl_Admin_Users = new System.Windows.Forms.Panel();
            this.lbl_AdminForm_User_Display_Email = new System.Windows.Forms.Label();
            this.lbl_AdminForm_User_Display_Name = new System.Windows.Forms.Label();
            this.pBox_AdminForm_User_Display = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Admin_ReturnBook = new System.Windows.Forms.Panel();
            this.pnl_Admin_BookList = new System.Windows.Forms.Panel();
            this.lbl_Admin_BookList_Head = new System.Windows.Forms.Label();
            this.dgView_Admin_BooksList = new System.Windows.Forms.DataGridView();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExistingBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mstp_Admin_Form = new System.Windows.Forms.MenuStrip();
            this.pnl_Admin_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AdminForm_User_Display)).BeginInit();
            this.pnl_Admin_BookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Admin_BooksList)).BeginInit();
            this.mstp_Admin_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 26);
            this.panel1.TabIndex = 3;
            // 
            // pnl_Admin_BkIssue
            // 
            this.pnl_Admin_BkIssue.Location = new System.Drawing.Point(12, 158);
            this.pnl_Admin_BkIssue.Name = "pnl_Admin_BkIssue";
            this.pnl_Admin_BkIssue.Size = new System.Drawing.Size(415, 536);
            this.pnl_Admin_BkIssue.TabIndex = 38;
            // 
            // pnl_Admin_SrStu
            // 
            this.pnl_Admin_SrStu.Location = new System.Drawing.Point(433, 317);
            this.pnl_Admin_SrStu.Name = "pnl_Admin_SrStu";
            this.pnl_Admin_SrStu.Size = new System.Drawing.Size(734, 377);
            this.pnl_Admin_SrStu.TabIndex = 39;
            // 
            // pnl_Admin_Users
            // 
            this.pnl_Admin_Users.Controls.Add(this.lbl_AdminForm_User_Display_Email);
            this.pnl_Admin_Users.Controls.Add(this.lbl_AdminForm_User_Display_Name);
            this.pnl_Admin_Users.Controls.Add(this.pBox_AdminForm_User_Display);
            this.pnl_Admin_Users.Controls.Add(this.label1);
            this.pnl_Admin_Users.Location = new System.Drawing.Point(12, 32);
            this.pnl_Admin_Users.Name = "pnl_Admin_Users";
            this.pnl_Admin_Users.Size = new System.Drawing.Size(415, 120);
            this.pnl_Admin_Users.TabIndex = 40;
            // 
            // lbl_AdminForm_User_Display_Email
            // 
            this.lbl_AdminForm_User_Display_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AdminForm_User_Display_Email.Font = new System.Drawing.Font("Arial Narrow", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_AdminForm_User_Display_Email.Location = new System.Drawing.Point(98, 74);
            this.lbl_AdminForm_User_Display_Email.Name = "lbl_AdminForm_User_Display_Email";
            this.lbl_AdminForm_User_Display_Email.Size = new System.Drawing.Size(314, 23);
            this.lbl_AdminForm_User_Display_Email.TabIndex = 3;
            this.lbl_AdminForm_User_Display_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AdminForm_User_Display_Name
            // 
            this.lbl_AdminForm_User_Display_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AdminForm_User_Display_Name.Font = new System.Drawing.Font("Arial Narrow", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_AdminForm_User_Display_Name.Location = new System.Drawing.Point(98, 41);
            this.lbl_AdminForm_User_Display_Name.Name = "lbl_AdminForm_User_Display_Name";
            this.lbl_AdminForm_User_Display_Name.Size = new System.Drawing.Size(314, 23);
            this.lbl_AdminForm_User_Display_Name.TabIndex = 2;
            this.lbl_AdminForm_User_Display_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBox_AdminForm_User_Display
            // 
            this.pBox_AdminForm_User_Display.Location = new System.Drawing.Point(3, 3);
            this.pBox_AdminForm_User_Display.Name = "pBox_AdminForm_User_Display";
            this.pBox_AdminForm_User_Display.Size = new System.Drawing.Size(89, 114);
            this.pBox_AdminForm_User_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_AdminForm_User_Display.TabIndex = 0;
            this.pBox_AdminForm_User_Display.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "User (Admin)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Admin_ReturnBook
            // 
            this.pnl_Admin_ReturnBook.Font = new System.Drawing.Font("Arial", 10F);
            this.pnl_Admin_ReturnBook.Location = new System.Drawing.Point(433, 32);
            this.pnl_Admin_ReturnBook.Name = "pnl_Admin_ReturnBook";
            this.pnl_Admin_ReturnBook.Size = new System.Drawing.Size(734, 279);
            this.pnl_Admin_ReturnBook.TabIndex = 41;
            // 
            // pnl_Admin_BookList
            // 
            this.pnl_Admin_BookList.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_Admin_BookList.Controls.Add(this.lbl_Admin_BookList_Head);
            this.pnl_Admin_BookList.Controls.Add(this.dgView_Admin_BooksList);
            this.pnl_Admin_BookList.Location = new System.Drawing.Point(1173, 32);
            this.pnl_Admin_BookList.Name = "pnl_Admin_BookList";
            this.pnl_Admin_BookList.Size = new System.Drawing.Size(179, 662);
            this.pnl_Admin_BookList.TabIndex = 42;
            // 
            // lbl_Admin_BookList_Head
            // 
            this.lbl_Admin_BookList_Head.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Admin_BookList_Head.ForeColor = System.Drawing.Color.White;
            this.lbl_Admin_BookList_Head.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Admin_BookList_Head.Location = new System.Drawing.Point(20, 4);
            this.lbl_Admin_BookList_Head.Name = "lbl_Admin_BookList_Head";
            this.lbl_Admin_BookList_Head.Size = new System.Drawing.Size(139, 23);
            this.lbl_Admin_BookList_Head.TabIndex = 35;
            this.lbl_Admin_BookList_Head.Text = "Book List";
            this.lbl_Admin_BookList_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgView_Admin_BooksList
            // 
            this.dgView_Admin_BooksList.AllowUserToAddRows = false;
            this.dgView_Admin_BooksList.AllowUserToDeleteRows = false;
            this.dgView_Admin_BooksList.AllowUserToResizeColumns = false;
            this.dgView_Admin_BooksList.AllowUserToResizeRows = false;
            this.dgView_Admin_BooksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgView_Admin_BooksList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgView_Admin_BooksList.BackgroundColor = System.Drawing.Color.White;
            this.dgView_Admin_BooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Admin_BooksList.GridColor = System.Drawing.Color.Black;
            this.dgView_Admin_BooksList.Location = new System.Drawing.Point(3, 30);
            this.dgView_Admin_BooksList.Name = "dgView_Admin_BooksList";
            this.dgView_Admin_BooksList.Size = new System.Drawing.Size(173, 629);
            this.dgView_Admin_BooksList.TabIndex = 0;
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.userToolStripMenuItem.Text = "&Users";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.removeUserToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 22);
            this.toolStripMenuItem2.Text = "Manage Users (Admin)";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(234, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBooksToolStripMenuItem,
            this.showBooksToolStripMenuItem,
            this.searchBookToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.booksToolStripMenuItem.Text = "&Books";
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.addExistingBookToolStripMenuItem});
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.addBooksToolStripMenuItem.Text = "&Add Books";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addNewBookToolStripMenuItem.Text = "&Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // addExistingBookToolStripMenuItem
            // 
            this.addExistingBookToolStripMenuItem.Name = "addExistingBookToolStripMenuItem";
            this.addExistingBookToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addExistingBookToolStripMenuItem.Text = "&Add Existing Book";
            this.addExistingBookToolStripMenuItem.Click += new System.EventHandler(this.addExistingBookToolStripMenuItem_Click);
            // 
            // showBooksToolStripMenuItem
            // 
            this.showBooksToolStripMenuItem.Name = "showBooksToolStripMenuItem";
            this.showBooksToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.showBooksToolStripMenuItem.Text = "&Show \\ Edit Books";
            this.showBooksToolStripMenuItem.Click += new System.EventHandler(this.showBooksToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.searchBookToolStripMenuItem.Text = "&Search Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.viewStudentDataToolStripMenuItem,
            this.searchStudentToolStripMenuItem,
            this.toolStripMenuItem3,
            this.issueBookToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.studentToolStripMenuItem.Text = "&Students";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.addNewStudentToolStripMenuItem.Text = "&Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // viewStudentDataToolStripMenuItem
            // 
            this.viewStudentDataToolStripMenuItem.Name = "viewStudentDataToolStripMenuItem";
            this.viewStudentDataToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.viewStudentDataToolStripMenuItem.Text = "&Show \\ Edit Students";
            this.viewStudentDataToolStripMenuItem.Click += new System.EventHandler(this.viewStudentDataToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.searchStudentToolStripMenuItem.Text = "&Search Student";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.searchStudentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(217, 6);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.issueBookToolStripMenuItem.Text = "&Issue Book";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.returnBookToolStripMenuItem.Text = "&Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(48, 22);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem1_Click);
            // 
            // mstp_Admin_Form
            // 
            this.mstp_Admin_Form.Font = new System.Drawing.Font("Arial", 12F);
            this.mstp_Admin_Form.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem1});
            this.mstp_Admin_Form.Location = new System.Drawing.Point(0, 0);
            this.mstp_Admin_Form.Name = "mstp_Admin_Form";
            this.mstp_Admin_Form.Size = new System.Drawing.Size(1364, 26);
            this.mstp_Admin_Form.TabIndex = 0;
            this.mstp_Admin_Form.Text = "Menu";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 706);
            this.Controls.Add(this.pnl_Admin_BookList);
            this.Controls.Add(this.pnl_Admin_ReturnBook);
            this.Controls.Add(this.pnl_Admin_Users);
            this.Controls.Add(this.pnl_Admin_SrStu);
            this.Controls.Add(this.pnl_Admin_BkIssue);
            this.Controls.Add(this.mstp_Admin_Form);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstp_Admin_Form;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Managment System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnl_Admin_Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AdminForm_User_Display)).EndInit();
            this.pnl_Admin_BookList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Admin_BooksList)).EndInit();
            this.mstp_Admin_Form.ResumeLayout(false);
            this.mstp_Admin_Form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Admin_BkIssue;
        private System.Windows.Forms.Panel pnl_Admin_SrStu;
        private System.Windows.Forms.Panel pnl_Admin_Users;
        private System.Windows.Forms.Panel pnl_Admin_ReturnBook;
        private System.Windows.Forms.Panel pnl_Admin_BookList;
        private System.Windows.Forms.DataGridView dgView_Admin_BooksList;
        private System.Windows.Forms.Label lbl_Admin_BookList_Head;
        private System.Windows.Forms.PictureBox pBox_AdminForm_User_Display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_AdminForm_User_Display_Email;
        private System.Windows.Forms.Label lbl_AdminForm_User_Display_Name;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExistingBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip mstp_Admin_Form;
    }
}